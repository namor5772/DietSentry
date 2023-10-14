using DietSentry;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static DietSentry.UtilitiesRMG; // so can use the isRecipe function
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DietSentry
{
    public partial class MainForm : Form
    {
        private FoodsContext? dbContext;

        public MainForm()
        {
            SplashScreen splash = new();
            splash.Show();

            InitializeComponent();
        }


        private void ATimer_Tick(object sender, EventArgs e)
        {
            iTick += 1;
            if (iTick <= 26)
            {
                // keep this form invisible (ie 0% opacity) for 2.6 seconds
                // while splash screen displays and then closes, with 0 seconds overlap.
                ;
            }
            else if ((iTick > 26) & (iTick <= 28))
            {
                // increase opacity from 0% to 100% over 1 second
                Opacity = (iTick - 16) / 2F;
            }
            else if (iTick == 29)
            {
                // shut down timer, not needed anymore
                aTimer.Enabled = false;
            }
        }


        /* Code that acts when a food item is selected (in whatever way) from the Foods dataGridView.
         * It prompts for amount of food eaten and appends a time stamped row to the Eaten foods table */
        private void ActWhenFoodSelected()
        {
            var foodItem = (Food)dataGridViewFoods.CurrentRow.DataBoundItem;

            if (foodItem != null)
            {
                using var context = new FoodsContext();
                // gain access to selected entry in food table
                var FoodSelected = context.Foods.Single(b => b.FoodId == foodItem.FoodId);
                eatenFoodDescription = FoodSelected.FoodDescription;

                // opens dialog used to input the quantity of that food eaten, position is "locked" to the food tabPage
                InputForm frm = new(this)
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = this.PointToScreen(tabPageFood.Location)
                };
                frm.ShowDialog();

                // only act on input if amout eaten >0, this includes the case when Enter is immediately pressed in the text box
                if (amountOfFoodEaten > 0.0)
                {
                    //                    DateTime ts = DateTime.Now;
                    // creating time stamp, it is actually generated in the InputForm either as "now" by default or manually adjusted
                    DateTime ts = dateTimeEaten;

                    // we can now add the appropriate entry to the Eaten table, sort it and refresh its Eaten data grid and give it focus
                    var EatenFood = context.Eaten;
                    EatenFood.Add(new Eaten
                    {
                        // even though the contents of the DateTimePicker component may display data in a format determined by the Windows locale,
                        // the following makes sure that the date is stored in the db table in the en-AU format, since that cannot be changed in SQLite
                        // when the locale is changed. Otherwise app will "crash" if locale is changed from en_AU.
                        DateEaten = ts.ToString("d-MMM-yy", CultureInfo.CreateSpecificCulture("en-AU")),

                        TimeEaten = ts.ToString("HH:mm"), // 24hr hour format
                        EatenTs = MTimeSpan(ts), // Number of whole minutes elapsed since start of reference date 1-Jan-2023
                        AmountEaten = amountOfFoodEaten * 100F,
                        FoodDescription = FoodSelected.FoodDescription,
                        Energy = (FoodSelected.Energy) * amountOfFoodEaten,
                        Protein = (FoodSelected.Protein) * amountOfFoodEaten,
                        FatTotal = (FoodSelected.FatTotal) * amountOfFoodEaten,
                        SaturatedFat = (FoodSelected.SaturatedFat) * amountOfFoodEaten,
                        TransFat = (FoodSelected.TransFat) * amountOfFoodEaten,
                        PolyunsaturatedFat = (FoodSelected.PolyunsaturatedFat) * amountOfFoodEaten,
                        MonounsaturatedFat = (FoodSelected.MonounsaturatedFat) * amountOfFoodEaten,
                        Carbohydrate = (FoodSelected.Carbohydrate) * amountOfFoodEaten,
                        Sugars = (FoodSelected.Sugars) * amountOfFoodEaten,
                        DietaryFibre = (FoodSelected.DietaryFibre) * amountOfFoodEaten,
                        SodiumNa = (FoodSelected.SodiumNa) * amountOfFoodEaten,
                        CalciumCa = (FoodSelected.CalciumCa) * amountOfFoodEaten,
                        PotassiumK = (FoodSelected.PotassiumK) * amountOfFoodEaten,
                        ThiaminB1 = (FoodSelected.ThiaminB1) * amountOfFoodEaten,
                        RiboflavinB2 = (FoodSelected.RiboflavinB2) * amountOfFoodEaten,
                        NiacinB3 = (FoodSelected.NiacinB3) * amountOfFoodEaten,
                        Folate = (FoodSelected.Folate) * amountOfFoodEaten,
                        IronFe = (FoodSelected.IronFe) * amountOfFoodEaten,
                        MagnesiumMg = (FoodSelected.MagnesiumMg) * amountOfFoodEaten,
                        VitaminC = (FoodSelected.VitaminC) * amountOfFoodEaten,
                        Caffeine = (FoodSelected.Caffeine) * amountOfFoodEaten,
                        Cholesterol = (FoodSelected.Cholesterol) * amountOfFoodEaten,
                        Alcohol = (FoodSelected.Alcohol) * amountOfFoodEaten
                    });
                    context.SaveChanges();

                    // Updates the dataGridViewEaten while maintaining filtering states and making the Eaten tab visible
                    ActOnEatenFoodFilteringStates();
                    tabControlMain.SelectedTab = tabPageEaten;

                    labelInfoEaten.Text = "Added food: " + FoodSelected.FoodDescription;
                }
            }
        }


        /* Code that acts on Food filtering states
         * There are 2 states and this makes sure the foods datagrid always correctly displays the data
         * there is an argument which determines the sort order via the Id: 0=Asc, 1=Desc */
        private void ActOnFoodFilteringStates(int sortingType)
        {
            using var context = new FoodsContext();
            context.Foods.Load();

            // start updating dataGridViewFood
            foodBindingSource.DataSource = context.Foods.Local.ToBindingList();
            if (sortingType == 0)
            {
                foodBindingSource.Sort = "FoodId Asc"; // sort in Ascending order by Id
            }
            else // if (sortingType == 1)
            {
                foodBindingSource.Sort = "FoodId Desc"; // sort in Descending order by Id
            }

            // determine current filter from labelFilter label.
            if (labelFilter.Text == "Unfiltered")
            {
                ;
            }
            else // if have filer
            {
                var filteredData = context.Foods.Local.ToBindingList().Where(x => x.FoodDescription!.Contains(labelFilter.Text));
                this.foodBindingSource.DataSource = filteredData.Any() ? filteredData : filteredData.ToArray();
            }

            // setting focus to first displayed cell in data grid. Ignore (via exception) if nothing display in data grid 
            try
            {
                dataGridViewFoods.CurrentCell = dataGridViewFoods.FirstDisplayedCell;
                dataGridViewFoods.CurrentCell.Selected = true;
                dataGridViewFoods.Focus();
            }
            catch
            {
                ; // do nothing!
            }
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new FoodsContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Foods.Load();
            this.dbContext.Eaten.Load();
            this.dbContext.Recipe.Load();

            this.foodBindingSource.DataSource = dbContext.Foods.Local.ToBindingList();
            this.eatenBindingSource.DataSource = dbContext.Eaten.Local.ToBindingList();
            this.recipeBindingSource.DataSource = dbContext.Recipe.Local.ToBindingList();

            // the default value on loading is today's date
            dateEatenFilter = dateTimePickerEaten.Value;

            ActOnFoodColumnStates();
            ActOnEatenFoodColumnStates();
            ActOnEatenFoodFilteringStates();
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }


        /* Only reacts to the Enter key being pressed in the Food filter text box, by processing the filter request */
        private void TextBoxFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 

                if (textBoxFilter.Text == "")
                {
                    labelFilter.Text = "Unfiltered";
                }
                else
                {
                    labelFilter.Text = textBoxFilter.Text;
                }
                textBoxFilter.Text = "";

                ActOnFoodFilteringStates(0);
            }
        }


        /* When the Food filter text box is entered just clears the text */
        private void TextBoxFilter_Enter(object sender, EventArgs e)
        {
            // always clear filter when enter text box
            textBoxFilter.Text = "";
        }


        /* This is way ONE you select an item (for recording as eaten) from the Food table.
         * - From the Food data grid Double Click selected item with mouse */
        private void DataGridViewFoods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ActWhenFoodSelected();
        }


        /* This is way TWO you select an item (for recording as eaten) from the food table.
         * - From the Food data grid Press Enter key on selected item.
         * ALSO picks up when Insert key is pressed. Used to Insert/Add food to the database.
         * - Selection row is then clearly not relevant but just a way of enabling this action)
         * ALSO picks up when F2 key is pressed. Used to Edit/Inspect selected food item (especially relevant for Recipe foods
         * ALSO picks up when F4 key is pressed. Used to create a g denominated (Solid) copy of a mL (Liquid) food item */
        private void DataGridViewFoods_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Selecting eaten food item
            {
                ActWhenFoodSelected();
                e.Handled = true; // prevents Enter key press causing next lower cell getting focus 
            }
            else if (e.KeyCode == Keys.Insert) // Adding/Inserting new food item into database
            {
                // opens a dialog form used to input a record to the food table
                // positions this form at same location (ie. top left hand corner) as this MainForm
                inputType = 0; // tells foodInput form that we are adding food item
                FoodInputForm frm = new(this)
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = this.Location
                };
                frm.ShowDialog();

                if (actOnFoodAdded) // then actually add food item to database otherwise ignore (if {Cancel} button pressed)
                {
                    if ((foodType == 0) | (foodType == 1) | (foodType == 3) | (foodType == 4))
                    {
                        using var context = new FoodsContext();
                        // we can now add the appropriate entry to the Food table, this is done in the mainForm but could have been
                        // done more logically in the foodInput form.
                        var NewFood = context.Foods;
                        NewFood.Add(new Food
                        {
                            FoodDescription = addedFoodItem.FoodDescription,
                            Energy = addedFoodItem.Energy,
                            Protein = addedFoodItem.Protein,
                            FatTotal = addedFoodItem.FatTotal,
                            SaturatedFat = addedFoodItem.SaturatedFat,
                            TransFat = addedFoodItem.TransFat,
                            PolyunsaturatedFat = addedFoodItem.PolyunsaturatedFat,
                            MonounsaturatedFat = addedFoodItem.MonounsaturatedFat,
                            Carbohydrate = addedFoodItem.Carbohydrate,
                            Sugars = addedFoodItem.Sugars,
                            DietaryFibre = addedFoodItem.DietaryFibre,
                            SodiumNa = addedFoodItem.SodiumNa,
                            CalciumCa = addedFoodItem.CalciumCa,
                            PotassiumK = addedFoodItem.PotassiumK,
                            ThiaminB1 = addedFoodItem.ThiaminB1,
                            RiboflavinB2 = addedFoodItem.RiboflavinB2,
                            NiacinB3 = addedFoodItem.NiacinB3,
                            Folate = addedFoodItem.Folate,
                            IronFe = addedFoodItem.IronFe,
                            MagnesiumMg = addedFoodItem.MagnesiumMg,
                            VitaminC = addedFoodItem.VitaminC,
                            Caffeine = addedFoodItem.Caffeine,
                            Cholesterol = addedFoodItem.Cholesterol,
                            Alcohol = addedFoodItem.Alcohol
                        });
                        context.SaveChanges();

                        labelInfoFood.Text = "Added new food item " + addedFoodItem.FoodDescription;
                    }
                    else if (foodType == 2)
                    {
                        ; // DO RECIPE STUFF HERE
                        // but actually all has already been done in the FoodInputForm form

                    }
                    else
                    {
                        ;
                    }

                    // refresh Foods data grid view while maintaining filter status
                    ActOnFoodFilteringStates(1);
                }
                else // addition of food item cancelled
                {
                    labelInfoFood.Text = "Addition of food item cancelled";
                }
            }
            else if (e.KeyCode == Keys.F2) // Editing selected food item
            {
                var foodItem = (Food)dataGridViewFoods.CurrentRow.DataBoundItem;

                if (foodItem != null)
                {
                    using var context = new FoodsContext();
                    // gain access to selected entry in food table
                    var FoodSelected = context.Foods.Single(b => b.FoodId == foodItem.FoodId);

                    // copy its fields to the public editedFooditem class instance
                    editedFoodItem.FoodId = FoodSelected.FoodId;
                    editedFoodItem.FoodDescription = FoodSelected.FoodDescription;
                    editedFoodItem.Energy = FoodSelected.Energy;
                    editedFoodItem.Protein = FoodSelected.Protein;
                    editedFoodItem.FatTotal = FoodSelected.FatTotal;
                    editedFoodItem.SaturatedFat = FoodSelected.SaturatedFat;
                    editedFoodItem.TransFat = FoodSelected.TransFat;
                    editedFoodItem.PolyunsaturatedFat = FoodSelected.PolyunsaturatedFat;
                    editedFoodItem.MonounsaturatedFat = FoodSelected.MonounsaturatedFat;
                    editedFoodItem.Carbohydrate = FoodSelected.Carbohydrate;
                    editedFoodItem.Sugars = FoodSelected.Sugars;
                    editedFoodItem.DietaryFibre = FoodSelected.DietaryFibre;
                    editedFoodItem.SodiumNa = FoodSelected.SodiumNa;
                    editedFoodItem.CalciumCa = FoodSelected.CalciumCa;
                    editedFoodItem.PotassiumK = FoodSelected.PotassiumK;
                    editedFoodItem.ThiaminB1 = FoodSelected.ThiaminB1;
                    editedFoodItem.RiboflavinB2 = FoodSelected.RiboflavinB2;
                    editedFoodItem.NiacinB3 = FoodSelected.NiacinB3;
                    editedFoodItem.Folate = FoodSelected.Folate;
                    editedFoodItem.IronFe = FoodSelected.IronFe;
                    editedFoodItem.MagnesiumMg = FoodSelected.MagnesiumMg;
                    editedFoodItem.VitaminC = FoodSelected.VitaminC;
                    editedFoodItem.Caffeine = FoodSelected.Caffeine;
                    editedFoodItem.Cholesterol = FoodSelected.Cholesterol;
                    editedFoodItem.Alcohol = FoodSelected.Alcohol;

                    // determine the food type by examining the FoodDescription string
                    string editedFoodId = (editedFoodItem.FoodId).ToString(); // for later use
                    string sFD = editedFoodItem.FoodDescription!;

                    RDesc rFD = TruncFoodDesc(sFD);
                    foodType = rFD.foodType;
                    editedFoodItem.FoodDescription = rFD.truncDesc;

                    // a bit of a cludge, need to record the Key of the selected Recipe food item being edited
                    // as well as the unchanged food description in case of cancellation.
                    if (foodType == 2)
                    {
                        recordID = FoodSelected.FoodId;
                        fullFoodDescription = sFD;
                    }

                    // opens a dialog form used to edit a food item
                    // positions this form at same location (ie. top left hand corner) as this MainForm
                    inputType = 1; // tells foodinput form that we are editing food item
                    FoodInputForm frm = new(this)
                    {
                        StartPosition = FormStartPosition.Manual,
                        Location = this.Location
                    };
                    frm.ShowDialog();

                    if ((actOnFoodAdded)) // then actually modify/edit food item in database otherwise ignore (if {Cancel} button pressed)
                    {
                        if (foodType != 2)
                        {
                            FoodSelected.FoodDescription = addedFoodItem.FoodDescription;
                            FoodSelected.Energy = addedFoodItem.Energy;
                            FoodSelected.Protein = addedFoodItem.Protein;
                            FoodSelected.FatTotal = addedFoodItem.FatTotal;
                            FoodSelected.SaturatedFat = addedFoodItem.SaturatedFat;
                            FoodSelected.TransFat = addedFoodItem.TransFat;
                            FoodSelected.PolyunsaturatedFat = addedFoodItem.PolyunsaturatedFat;
                            FoodSelected.MonounsaturatedFat = addedFoodItem.MonounsaturatedFat;
                            FoodSelected.Carbohydrate = addedFoodItem.Carbohydrate;
                            FoodSelected.Sugars = addedFoodItem.Sugars;
                            FoodSelected.DietaryFibre = addedFoodItem.DietaryFibre;
                            FoodSelected.SodiumNa = addedFoodItem.SodiumNa;
                            FoodSelected.CalciumCa = addedFoodItem.CalciumCa;
                            FoodSelected.PotassiumK = addedFoodItem.PotassiumK;
                            FoodSelected.ThiaminB1 = addedFoodItem.ThiaminB1;
                            FoodSelected.RiboflavinB2 = addedFoodItem.RiboflavinB2;
                            FoodSelected.NiacinB3 = addedFoodItem.NiacinB3;
                            FoodSelected.Folate = addedFoodItem.Folate;
                            FoodSelected.IronFe = addedFoodItem.IronFe;
                            FoodSelected.MagnesiumMg = addedFoodItem.MagnesiumMg;
                            FoodSelected.VitaminC = addedFoodItem.VitaminC;
                            FoodSelected.Caffeine = addedFoodItem.Caffeine;
                            FoodSelected.Cholesterol = addedFoodItem.Cholesterol;
                            FoodSelected.Alcohol = addedFoodItem.Alcohol;

                            context.SaveChanges();
                            ActOnFoodFilteringStates(0);
                        }
                        else // if if (foodType!=2)
                        {
                            ActOnFoodFilteringStates(1);
                        }
                        labelInfoFood.Text = "Edited food item " + editedFoodId + " : " + FoodSelected.FoodDescription;
                    }
                    else // editing of food item cancelled
                    {
                        labelInfoFood.Text = "Cancelled editing of food item " + editedFoodId + " : " + FoodSelected.FoodDescription;
                    }
                }
            }
            else if (e.KeyCode == Keys.F4) // Creating Solid copy of Liquid food item
            {
                var foodItem = (Food)dataGridViewFoods.CurrentRow.DataBoundItem;

                if (foodItem != null)
                {
                    using var context = new FoodsContext();

                    // gain access to selected entry in food table
                    var FoodSelected = context.Foods.Single(b => b.FoodId == foodItem.FoodId);

                    // determine if selected food is a Liquid, as this is the only type that can be processed
                    // get truncated food description and food type identifier
                    RDesc rDesc = TruncFoodDesc(FoodSelected.FoodDescription!);
                    editedFoodDescription = rDesc.truncDesc;
                    int fT = rDesc.foodType;

                    if ((fT == 1) | (fT == 4)) // can continue since selected a food which is a liquid
                    {
                        // opens dialog used to input the density of the selected liquid foodn
                        InputDensity frm = new(this)
                        {
                            StartPosition = FormStartPosition.Manual,
                            Location = this.PointToScreen(tabPageFood.Location)
                        };
                        frm.ShowDialog();

                        //                        labelInfo.Text = "{F4} Key pressed:   " + fT.ToString() + "  " + densityOfFood.ToString();

                        if (densityOfFood == 0.0) // invalid input, so error message
                        {
                            // Initializes the variables to pass to the MessageBox.Show method
                            string message = "Try again!";
                            string caption = "INVALID DENSITY";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;

                            // Displays the MessageBox.
                            MessageBox.Show(message, caption, buttons);
                            checkBoxDailyTotals.Checked = false;
                        }
                        else // proceed to create copy of food item in Solid form
                        {
                            // Creating new FoodDescription, with the same trucated base but extension varying depending on original food type
                            string sDescriptionDensity = editedFoodDescription + " {density=" + string.Format("{0:N3}", densityOfFood) + "g/ml}";
                            if (fT == 1) // dealing with "public" liquid
                            {
                                editedFoodDescription = sDescriptionDensity;
                            }
                            else // (fT==4) and dealing with "private" liquid
                            {
                                editedFoodDescription = sDescriptionDensity + " #";
                            }

                            var CopiedFood = context.Foods;
                            CopiedFood.Add(new Food
                            {
                                FoodDescription = editedFoodDescription,
                                Energy = FoodSelected.Energy / densityOfFood,
                                Protein = FoodSelected.Protein / densityOfFood,
                                FatTotal = FoodSelected.FatTotal / densityOfFood,
                                SaturatedFat = FoodSelected.SaturatedFat / densityOfFood,
                                TransFat = FoodSelected.TransFat / densityOfFood,
                                PolyunsaturatedFat = FoodSelected.PolyunsaturatedFat / densityOfFood,
                                MonounsaturatedFat = FoodSelected.MonounsaturatedFat / densityOfFood,
                                Carbohydrate = FoodSelected.Carbohydrate / densityOfFood,
                                Sugars = FoodSelected.Sugars / densityOfFood,
                                DietaryFibre = FoodSelected.DietaryFibre / densityOfFood,
                                SodiumNa = FoodSelected.SodiumNa / densityOfFood,
                                CalciumCa = FoodSelected.CalciumCa / densityOfFood,
                                PotassiumK = FoodSelected.PotassiumK / densityOfFood,
                                ThiaminB1 = FoodSelected.ThiaminB1 / densityOfFood,
                                RiboflavinB2 = FoodSelected.RiboflavinB2 / densityOfFood,
                                NiacinB3 = FoodSelected.NiacinB3 / densityOfFood,
                                Folate = FoodSelected.Folate / densityOfFood,
                                IronFe = FoodSelected.IronFe / densityOfFood,
                                MagnesiumMg = FoodSelected.MagnesiumMg / densityOfFood,
                                VitaminC = FoodSelected.VitaminC / densityOfFood,
                                Caffeine = FoodSelected.Caffeine / densityOfFood,
                                Cholesterol = FoodSelected.Cholesterol / densityOfFood,
                                Alcohol = FoodSelected.Alcohol / densityOfFood
                            });

                            context.SaveChanges();
                            ActOnFoodFilteringStates(1);
                        }

                    }
                    else // no further processing possible so display "Error" message box
                    {
                        // Initializes the variables to pass to the MessageBox.Show method
                        string message = "Only possible when Liquid food selected";
                        string caption = "CANNOT CREATE SOLID FOOD";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;

                        // Displays the MessageBox.
                        MessageBox.Show(message, caption, buttons);
                        checkBoxDailyTotals.Checked = false;
                    }

                }
            }
        }

        /* Manually implements the deletion of an Eaten table row
         * This was partly to overcome an exception raised when done automatically
         * mult selection is disabled for convenience */
        private void DataGridViewEaten_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // cancel the automatic deletion process (to avoid raising exceptions)
            e.Cancel = true;

            // can delete row only if the totals filter check boxed is unchecked
            if ((!checkBoxDailyTotals.Checked))
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Are you sure you wish to DELETE the selected eaten food?";
                string caption = "DELETE CONFIRMATION";
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    // determine row to be deleted from Eaten table by accessing it in its dataGrid
                    var foodItem = (Eaten)this.dataGridViewEaten.CurrentRow.DataBoundItem;

                    if (foodItem != null)
                    {
                        using var context = new FoodsContext();
                        // gain direct access to selected entry in Eaten table
                        var FoodSelected = context.Eaten.Single(b => b.EatenId == foodItem.EatenId);

                        // delete this row from Eaten table
                        context.Eaten.Remove(FoodSelected);
                        context.SaveChanges();

                        // refresh Eaten data grid view while maintaining filter status
                        ActOnEatenFoodFilteringStates();

                        labelInfoEaten.Text = "Deleted selected food: " + foodItem.FoodDescription;
                    }
                }
                else
                {
                    labelInfoEaten.Text = "Deletion of selected eaten food cancelled!";
                }
            }
            else // prevent row deletion and inform user of this by displaying Message Box
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Only possible when not showing totalled data";
                string caption = "CANNOT DELETE ROW";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                // Displays the MessageBox.
                MessageBox.Show(message, caption, buttons);
                checkBoxDailyTotals.Checked = false;

                labelInfoEaten.Text = "Selection was not a particular food, so could not be deleted!";
            }
        }


        /* Code that acts on Eaten foods filtering states, only showing the current days data and/or aggregating by days
         * There are 4 states and this makes sure the Eaten foods datagrid always correctly displays the data */
        private void ActOnEatenFoodFilteringStates()
        {
            // even though the contents of the DateTimePicker component may display data in a format determined by the Windows locale,
            // the following makes sure that the date is selected is expressed in the en-AU format, since that cannot be changed in SQLite
            // when the locale is changed. Otherwise app will "crash" if locale is changed from en_AU.
            string sDate = dateEatenFilter.ToString("d-MMM-yy", CultureInfo.CreateSpecificCulture("en-AU"));

            if ((checkBoxDailyTotals.Checked) & (!(checkBoxDateFilter.Checked)))
            {
                try
                {
                    using var context = new FoodsContext();
                    context.Eaten.Load();

                    // display queried data in DataGrid (in particular aggregated by date and summed)
                    var queriedData = context.Eaten.Local.ToBindingList().
                        GroupBy(o => o.DateEaten).Select(g => new
                        {
                            DateEaten = g.Key,
                            EatenId = g.Max(i => i.EatenId),
                            EatenTs = g.Max(i => i.EatenTs), // use Max so sorting by date & time works!
                            AmountEaten = g.Sum(i => i.AmountEaten),
                            Energy = g.Sum(i => i.Energy),
                            Protein = g.Sum(i => i.Protein),
                            FatTotal = g.Sum(i => i.FatTotal),
                            SaturatedFat = g.Sum(i => i.SaturatedFat),
                            TransFat = g.Sum(i => i.TransFat),
                            PolyunsaturatedFat = g.Sum(i => i.PolyunsaturatedFat),
                            MonounsaturatedFat = g.Sum(i => i.MonounsaturatedFat),
                            Carbohydrate = g.Sum(i => i.Carbohydrate),
                            Sugars = g.Sum(i => i.Sugars),
                            DietaryFibre = g.Sum(i => i.DietaryFibre),
                            SodiumNa = g.Sum(i => i.SodiumNa),
                            CalciumCa = g.Sum(i => i.CalciumCa),
                            PotassiumK = g.Sum(i => i.PotassiumK),
                            ThiaminB1 = g.Sum(i => i.ThiaminB1),
                            RiboflavinB2 = g.Sum(i => i.RiboflavinB2),
                            NiacinB3 = g.Sum(i => i.NiacinB3),
                            Folate = g.Sum(i => i.Folate),
                            IronFe = g.Sum(i => i.IronFe),
                            MagnesiumMg = g.Sum(i => i.MagnesiumMg),
                            VitaminC = g.Sum(i => i.VitaminC),
                            Caffeine = g.Sum(i => i.Caffeine),
                            Cholesterol = g.Sum(i => i.Cholesterol),
                            Alcohol = g.Sum(i => i.Alcohol)
                        }).
                        OrderByDescending(x => x.EatenTs);

                    // hide columns not necessary for display of aggregated data
                    dataGridViewEaten.Columns[0].Visible = false; // hide EatenId column
                    dataGridViewEaten.Columns[2].Visible = false; // hide TimeEaten column
                    dataGridViewEaten.Columns[3].Visible = false; // hide EatenTs column *****
                    dataGridViewEaten.Columns[4].Visible = false; // hide AmountEaten column
                    dataGridViewEaten.Columns[5].Visible = false; // hide FoodDescription column

                    // the queried data table result should only contain one record/row.

                    // this is where exception might occur.
                    // this binds the data so that it is displayed in the data grid.
                    eatenBindingSource.DataSource = queriedData.Any() ? queriedData : queriedData.ToArray();
                }
                catch // some sorting problem
                {
                    ;
                }
            }
            else if ((checkBoxDailyTotals.Checked) & (checkBoxDateFilter.Checked))
            {
                try
                {
                    using var context = new FoodsContext();
                    context.Eaten.Load();

                    // display queried data in DataGrid (in particular aggregated by date and summed)
                    var queriedData = context.Eaten.Local.ToBindingList().
                        GroupBy(o => o.DateEaten).
                        Select(g => new
                        {
                            DateEaten = g.Key,
                            EatenId = g.Max(i => i.EatenId),
                            EatenTs = g.Max(i => i.EatenTs), // use Max so sorting by date & time works!
                            AmountEaten = g.Sum(i => i.AmountEaten),
                            Energy = g.Sum(i => i.Energy),
                            Protein = g.Sum(i => i.Protein),
                            FatTotal = g.Sum(i => i.FatTotal),
                            SaturatedFat = g.Sum(i => i.SaturatedFat),
                            TransFat = g.Sum(i => i.TransFat),
                            PolyunsaturatedFat = g.Sum(i => i.PolyunsaturatedFat),
                            MonounsaturatedFat = g.Sum(i => i.MonounsaturatedFat),
                            Carbohydrate = g.Sum(i => i.Carbohydrate),
                            Sugars = g.Sum(i => i.Sugars),
                            DietaryFibre = g.Sum(i => i.DietaryFibre),
                            SodiumNa = g.Sum(i => i.SodiumNa),
                            CalciumCa = g.Sum(i => i.CalciumCa),
                            PotassiumK = g.Sum(i => i.PotassiumK),
                            ThiaminB1 = g.Sum(i => i.ThiaminB1),
                            RiboflavinB2 = g.Sum(i => i.RiboflavinB2),
                            NiacinB3 = g.Sum(i => i.NiacinB3),
                            Folate = g.Sum(i => i.Folate),
                            IronFe = g.Sum(i => i.IronFe),
                            MagnesiumMg = g.Sum(i => i.MagnesiumMg),
                            VitaminC = g.Sum(i => i.VitaminC),
                            Caffeine = g.Sum(i => i.Caffeine),
                            Cholesterol = g.Sum(i => i.Cholesterol),
                            Alcohol = g.Sum(i => i.Alcohol)
                        }).
                        Where(x => x.DateEaten!.Equals(sDate)).
                        OrderByDescending(x => x.EatenTs);

                    // hide columns not necessary for display of aggregated data
                    dataGridViewEaten.Columns[0].Visible = false; // hide EatenId column
                    dataGridViewEaten.Columns[2].Visible = false; // hide TimeEaten column
                    dataGridViewEaten.Columns[3].Visible = false; // hide EatenTs column *****
                    dataGridViewEaten.Columns[4].Visible = false; // hide AmountEaten column
                    dataGridViewEaten.Columns[5].Visible = false; // hide FoodDescription column

                    // the queried data table result should only contain one record/row.

                    // this is where exception occurs.
                    // this binds the data so that it is displayed in the data grid.
                    eatenBindingSource.DataSource = queriedData.Any() ? queriedData : queriedData.ToArray();
                }
                catch // some sorting problem
                {
                    ;
                }
            }
            else if ((!checkBoxDailyTotals.Checked) & (checkBoxDateFilter.Checked))
            {
                using (var context = new FoodsContext())
                {
                    // update dataGridViewEaten with todays date as filter
                    context.Eaten.Load();
                    var queriedData = context.Eaten.Local.ToBindingList().
                        Where(x => x.DateEaten!.Equals(sDate)).
                        OrderByDescending(x => x.EatenTs);
                    eatenBindingSource.DataSource = queriedData.Any() ? queriedData : queriedData.ToArray();
                }

                // restore view of previously hidden columns 
                dataGridViewEaten.Columns[0].Visible = false; // show EatenId column
                dataGridViewEaten.Columns[2].Visible = true; // show TimeEaten column
                dataGridViewEaten.Columns[3].Visible = false; // show EatenTs column *****
                dataGridViewEaten.Columns[4].Visible = true; // show AmountEaten column
                dataGridViewEaten.Columns[5].Visible = true; // show FoodDescription column
            }
            else // ((!checkBoxDailyTotals.Checked)&(!checkBoxDateFilter.Checked))
            {
                using (var context = new FoodsContext())
                {
                    // update dataGridViewEaten with no filters
                    context.Eaten.Load();
                    eatenBindingSource.DataSource = context.Eaten.Local.ToBindingList().
                        OrderByDescending(x => x.EatenTs);
                }

                // restore view of previously hidden columns 
                dataGridViewEaten.Columns[0].Visible = false; // show EatenId column
                dataGridViewEaten.Columns[2].Visible = true; // show TimeEaten column
                dataGridViewEaten.Columns[3].Visible = false; // show EatenTs column *****
                dataGridViewEaten.Columns[4].Visible = true; // show AmountEaten column
                dataGridViewEaten.Columns[5].Visible = true; // show FoodDescription column
            }
        }


        /* Changes visibility of columns in the Eaten Foods data grid in response to the corresponding check box's state */
        private void ActOnEatenFoodColumnStates()
        {
            if (checkBoxMainCols.Checked)
            {
                // hide non-main columns 
                //dataGridViewEaten.Columns[3].Visible = false; // hide AmountEaten column
                dataGridViewEaten.Columns[10].Visible = false; // hide TransFat column
                dataGridViewEaten.Columns[11].Visible = false; // hide PolyunsaturatedFat column
                dataGridViewEaten.Columns[12].Visible = false; // hide MonounsaturatedFat column
                dataGridViewEaten.Columns[17].Visible = false; // hide CalciumCa column
                dataGridViewEaten.Columns[18].Visible = false; // hide PotassiumK column
                dataGridViewEaten.Columns[19].Visible = false; // hide ThiaminB1 column
                dataGridViewEaten.Columns[20].Visible = false; // hide RiboflavinB2 column
                dataGridViewEaten.Columns[21].Visible = false; // hide NiacinB3 column
                dataGridViewEaten.Columns[22].Visible = false; // hide Folate column
                dataGridViewEaten.Columns[23].Visible = false; // hide IronFe column
                dataGridViewEaten.Columns[24].Visible = false; // hide MagnesiumMg column
                dataGridViewEaten.Columns[25].Visible = false; // hide VitaminC column
                dataGridViewEaten.Columns[26].Visible = false; // hide Caffeine column
                dataGridViewEaten.Columns[27].Visible = false; // hide Cholesterol column
                dataGridViewEaten.Columns[28].Visible = false; // hide Alcohol column
            }
            else // if (!checkBoxMainCols.Checked)
            {
                // restore view of previously hidden non-main columns 
                dataGridViewEaten.Columns[10].Visible = true; // show TransFat column
                dataGridViewEaten.Columns[11].Visible = true; // show PolyunsaturatedFat column
                dataGridViewEaten.Columns[12].Visible = true; // show MonounsaturatedFat column
                dataGridViewEaten.Columns[17].Visible = true; // show CalciumCa column
                dataGridViewEaten.Columns[18].Visible = true; // show PotassiumK column
                dataGridViewEaten.Columns[19].Visible = true; // show ThiaminB1 column
                dataGridViewEaten.Columns[20].Visible = true; // show RiboflavinB2 column
                dataGridViewEaten.Columns[21].Visible = true; // show NiacinB3 column
                dataGridViewEaten.Columns[22].Visible = true; // show Folate column
                dataGridViewEaten.Columns[23].Visible = true; // show IronFe column
                dataGridViewEaten.Columns[24].Visible = true; // show MagnesiumMg column
                dataGridViewEaten.Columns[25].Visible = true; // show VitaminC column
                dataGridViewEaten.Columns[26].Visible = true; // show Caffeine column
                dataGridViewEaten.Columns[27].Visible = true; // show Cholesterol column
                dataGridViewEaten.Columns[28].Visible = true; // show Alcohol column
            }
        }


        /* Wrapper for actOnEatenFoodFilteringStates() when Date filter check box state changed */
        private void CheckBoxDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            ActOnEatenFoodFilteringStates();
        }


        /* Wrapper for actOnEatenFoodFilteringStates() when Totals filter check box state changed */
        private void CheckBoxDailyTotals_CheckedChanged(object sender, EventArgs e)
        {
            ActOnEatenFoodFilteringStates();
        }


        /* Wrapper for actOnEatenFoodColumnStates() when check box state changed */
        private void CheckBoxMainCols_CheckedChanged(object sender, EventArgs e)
        {
            ActOnEatenFoodColumnStates();
        }


        /* Manually implements the deletion of a Food selected in its data grid
         * This is to control the process and fully delete recipe foods. Multi selection is disabled for convenience
         * This is run when a row is selected and any Delete key pressed (Delete or Del on the number pad) */
        private void DataGridViewFoods_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // cancel the automatic deletion process (to avoid raising exceptions and for manual enhancements)
            e.Cancel = true;

            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "Are you sure you wish to delete the selected food item?";
            string caption = "DELETE CONFIRMATION";
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                // determine row to be deleted from Foods table by accessing it in its dataGrid
                var foodItem = (Food)this.dataGridViewFoods.CurrentRow.DataBoundItem;

                if (foodItem != null)
                {
                    using var context = new FoodsContext();
                    // gain direct access to selected record in the Foods table
                    var FoodSelected = context.Foods.Single(b => b.FoodId == foodItem.FoodId);
                    int FoodSelectedId = FoodSelected.FoodId; // get Id for later display
                    string FoodSelectedDesc = FoodSelected.FoodDescription!; // get FoodDescription for later use

                    // delete this record from Foods table
                    context.Foods.Remove(FoodSelected);
                    context.SaveChanges();

                    // determines if this food is a recipe because extra stuff has to be deleted
                    if (IsRecipe(FoodSelectedDesc))
                    {
                        // delete any records in the recipe table
                        var recipeFoods = context.Recipe.Where(r => r.FoodId == FoodSelectedId);
                        context.Recipe.RemoveRange(recipeFoods);
                        context.SaveChanges();
                    }
                    else

                        labelInfoFood.Text = "Deleted food item " + FoodSelectedId + " : " + FoodSelectedDesc;

                    // refresh Foods data grid view while maintaining filter status - it is done in this complicated way
                    // because it crashes under some patricular circumstances !
                    string SF = labelFilter.Text;
                    labelFilter.Text = "Unfiltered";
                    ActOnFoodFilteringStates(0);
                    labelFilter.Text = SF;
                    ActOnFoodFilteringStates(0);
                }
            }
            else
            {
                labelInfoFood.Text = "Cancelled deletion of selected food item";
            }
        }


        /* Changes visibility of columns in the Foods data grid in response to the corresponing check box's state */
        private void ActOnFoodColumnStates()
        {
            if (checkBoxMainFoodCols.Checked)
            {
                // hide non-main columns 
                dataGridViewFoods.Columns[6].Visible = false; // hide TransFat column
                dataGridViewFoods.Columns[7].Visible = false; // hide PolyunsaturatedFat column
                dataGridViewFoods.Columns[8].Visible = false; // hide MonounsaturatedFat column
                dataGridViewFoods.Columns[13].Visible = false; // hide CalciumCa column
                dataGridViewFoods.Columns[14].Visible = false; // hide PotassiumK column
                dataGridViewFoods.Columns[15].Visible = false; // hide ThiaminB1 column
                dataGridViewFoods.Columns[16].Visible = false; // hide RiboflavinB2 column
                dataGridViewFoods.Columns[17].Visible = false; // hide NiacinB3 column
                dataGridViewFoods.Columns[18].Visible = false; // hide Folate column
                dataGridViewFoods.Columns[19].Visible = false; // hide IronFe column
                dataGridViewFoods.Columns[20].Visible = false; // hide MagnesiumMg column
                dataGridViewFoods.Columns[21].Visible = false; // hide VitaminC column
                dataGridViewFoods.Columns[22].Visible = false; // hide Caffeine column
                dataGridViewFoods.Columns[23].Visible = false; // hide Cholesterol column
                dataGridViewFoods.Columns[24].Visible = false; // hide Alcohol column
            }
            else // if (!checkBoxMainFoodCols.Checked)
            {
                // restore view of previously hidden non-main columns 
                dataGridViewFoods.Columns[6].Visible = true; // show TransFat column
                dataGridViewFoods.Columns[7].Visible = true; // show PolyunsaturatedFat column
                dataGridViewFoods.Columns[8].Visible = true; // show MonounsaturatedFat column
                dataGridViewFoods.Columns[13].Visible = true; // show CalciumCa column
                dataGridViewFoods.Columns[14].Visible = true; // show PotassiumK column
                dataGridViewFoods.Columns[15].Visible = true; // show ThiaminB1 column
                dataGridViewFoods.Columns[16].Visible = true; // show RiboflavinB2 column
                dataGridViewFoods.Columns[17].Visible = true; // show NiacinB3 column
                dataGridViewFoods.Columns[18].Visible = true; // show Folate column
                dataGridViewFoods.Columns[19].Visible = true; // show IronFe column
                dataGridViewFoods.Columns[20].Visible = true; // show MagnesiumMg column
                dataGridViewFoods.Columns[21].Visible = true; // show VitaminC column
                dataGridViewFoods.Columns[22].Visible = true; // show Caffeine column
                dataGridViewFoods.Columns[23].Visible = true; // show Cholesterol column
                dataGridViewFoods.Columns[24].Visible = true; // show Alcohol column
            }
        }


        /* Wrapper for actOnFoodColumnStates() when controlling check box's state changed */
        private void CheckBoxMainFoodCols_CheckedChanged(object sender, EventArgs e)
        {
            ActOnFoodColumnStates();
        }

        private void DateTimePickerEaten_Leave(object sender, EventArgs e)
        {
            dateEatenFilter = dateTimePickerEaten.Value;
            ActOnEatenFoodFilteringStates();
        }

        private void DateTimePickerEaten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 

                dateEatenFilter = dateTimePickerEaten.Value;
                ActOnEatenFoodFilteringStates();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tabPageFood_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewEaten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) // Selecting eaten food item
            {




            }

        }
    }
}