using DietSentry;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DietSentry
{
    public partial class MainForm : Form
    {

        private FoodsContext? dbContext;

        public MainForm()
        {
            InitializeComponent();
        }

        public void SetTextForLabel(string myText)
        {
            this.labelTest.Text = myText;
        }


        /* Code that acts when a food item is selected (in whatever way) from the Foods dataGridView.
         * It prompts for amount of food eaten and appends a time stamped row to the Eaten foods table */
        private void actWhenFoodSelected()
        {
            var foodItem = (Food)dataGridViewFoods.CurrentRow.DataBoundItem;

            if (foodItem != null)
            {
                using (var context = new FoodsContext())
                {
                    // gain access to selected entry in food table
                    var FoodSelected = context.Foods.Single(b => b.FoodId == foodItem.FoodId);
                    eatenFoodDescription = FoodSelected.FoodDescription;

                    // opens dialog used to input the quantity of that food eaten, position is "locked" to the food tabPage
                    InputForm frm = new(this);
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.Location = this.PointToScreen(tabPageFood.Location);
                    frm.ShowDialog();

                    // only act on input if amout eaten >0, this includes the case when Enter is immediately pressed in the text box
                    if (amountOfFoodEaten > 0.0)
                    {

                        // we can now add the appropriate entry to the Eaten table, sort it and refresh its Eaten data grid and give it focus
                        var EatenFood = context.Eaten;
                        EatenFood.Add(new Eaten
                        {
                            DateEaten = DateTime.Now.ToString("d-MMM-yy"),
                            TimeEaten = DateTime.Now.ToString("hh:mm"),
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
                        actOnEatenFoodFilteringStates();
                        tabControlMain.SelectedTab = tabPageEaten;
                    }
                }
            }
        }


        /* Code that acts on Eaten foods filtering states, only showing the current days data and/or aggregating by days
         * There are 4 states and this makes sure the Eaten foods datagrid always correctly displays the data */
        private void actOnEatenFoodFilteringStates()
        {
            string sDate = DateTime.Now.ToString("d-MMM-yy");

            if ((checkBoxDailyTotals.Checked) & (!(checkBoxDateFilter.Checked)))
            {
                try
                {
                    using (var context = new FoodsContext())
                    {
                        context.Eaten.Load();

                        // display queried data in DataGrid (in particular aggregated by date and summed)
                        var queriedData = context.Eaten.Local.ToBindingList().GroupBy(o => o.DateEaten).Select(g => new
                        {
                            DateEaten = g.Key,
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
                        });//.Where(x => x.DateEaten.Contains(sDate));

                        // hide columns not necessary for display of aggregated data
                        dataGridViewEaten.Columns[0].Visible = false; // hide EatenId column
                        dataGridViewEaten.Columns[2].Visible = false; // hide TimeEaten column
                        dataGridViewEaten.Columns[3].Visible = false; // hide AmountEaten column
                        dataGridViewEaten.Columns[4].Visible = false; // hide FoodDescription column

                        // the queried data table result should only contain one record/row.

                        // this is where exception occurs.
                        // this binds the data so that it is displayed in the data grid.
                        eatenBindingSource.DataSource = queriedData.Count() > 0 ? queriedData : queriedData.ToArray();
                    }
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
                    using (var context = new FoodsContext())
                    {
                        context.Eaten.Load();

                        // display queried data in DataGrid (in particular aggregated by date and summed)
                        var queriedData = context.Eaten.Local.ToBindingList().GroupBy(o => o.DateEaten).Select(g => new
                        {
                            DateEaten = g.Key,
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
                        }).Where(x => x.DateEaten.Contains(sDate));

                        // hide columns not necessary for display of aggregated data
                        dataGridViewEaten.Columns[0].Visible = false; // hide EatenId column
                        dataGridViewEaten.Columns[2].Visible = false; // hide TimeEaten column
                        dataGridViewEaten.Columns[3].Visible = false; // hide AmountEaten column
                        dataGridViewEaten.Columns[4].Visible = false; // hide FoodDescription column

                        // the queried data table result should only contain one record/row.

                        // this is where exception occurs.
                        // this binds the data so that it is displayed in the data grid.
                        eatenBindingSource.DataSource = queriedData.Count() > 0 ? queriedData : queriedData.ToArray();
                    }
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
                    eatenBindingSource.DataSource = context.Eaten.Local.ToBindingList();
                    eatenBindingSource.Sort = "EatenId Asc"; // also sort in Ascending order by Id
                    var filteredData = context.Eaten.Local.ToBindingList().Where(x => x.DateEaten.Contains(sDate));
                    this.eatenBindingSource.DataSource = filteredData.Count() > 0 ? filteredData : filteredData.ToArray();
                }

                // restore view of previously hidden columns 
                dataGridViewEaten.Columns[0].Visible = true; // show EatenId column
                dataGridViewEaten.Columns[2].Visible = true; // show TimeEaten column
                dataGridViewEaten.Columns[3].Visible = true; // show AmountEaten column
                dataGridViewEaten.Columns[4].Visible = true; // show FoodDescription column
            }
            else // ((!checkBoxDailyTotals.Checked)&(!checkBoxDateFilter.Checked))
            {
                using (var context = new FoodsContext())
                {
                    // update dataGridViewEaten with no filters
                    context.Eaten.Load();
                    eatenBindingSource.DataSource = context.Eaten.Local.ToBindingList();
                    eatenBindingSource.Sort = "EatenId Asc"; // also sort in Ascending order by Id
                }

                // restore view of previously hidden columns 
                dataGridViewEaten.Columns[0].Visible = true; // show EatenId column
                dataGridViewEaten.Columns[2].Visible = true; // show TimeEaten column
                dataGridViewEaten.Columns[3].Visible = true; // show AmountEaten column
                dataGridViewEaten.Columns[4].Visible = true; // show FoodDescription column
            }
        }


        /* Code that acts on Food filtering states
         * There are 2 states and this makes sure the foods datagrid always correctly displays the data */
        private void actOnFoodFilteringStates()
        {
            using (var context = new FoodsContext())
            {
                // determine current filter from labelFilter label.
                string strFilter;
                if (labelFilter.Text == "Unfiltered")
                {
                    strFilter = "";
                }
                else
                {
                    strFilter = labelFilter.Text;
                }

                // refresh Food data grid view while maintaining current filter status (if any)
                context.Foods.Load();
                foodBindingSource.DataSource = context.Foods.Local.ToBindingList();
//                foodBindingSource.Sort = "FoodId Asc"; // also sort in Ascending order by Id
                var filteredData = context.Foods.Local.ToBindingList().Where(x => x.FoodDescription.Contains(strFilter));
                this.foodBindingSource.DataSource = filteredData.Count() > 0 ? filteredData : filteredData.ToArray();
                foodBindingSource.Sort = "FoodId Asc"; // also sort in Ascending order by Id
                /*
                if (filteredData.Count() > 0)
                {
                    // shifts focus to first displayed cell, as long as there is something to display
                    dataGridViewFoods.Focus();
                    dataGridViewFoods.CurrentCell = dataGridViewFoods.FirstDisplayedCell;
                }
                */
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new FoodsContext();

            // Uncomment the line below to start fresh with a new database.
            //this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Foods.Load();
            this.dbContext.Eaten.Load();

            this.foodBindingSource.DataSource = dbContext.Foods.Local.ToBindingList();
            this.eatenBindingSource.DataSource = dbContext.Eaten.Local.ToBindingList();
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            labelFilter.Text = "Unfiltered";
            this.dbContext!.SaveChanges();
            this.dataGridViewFoods.Refresh();
        }

        /* Only reacts to the Enter key being pressed in the Food filter text box, by processing the filter request */
        private void textBoxFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 

                if (this.textBoxFilter.Text != "") // only accept a non-null string as a filter
                {
                    using (var context = new FoodsContext())
                    {
                        // update dataGridViewFood with filter
                        context.Foods.Load();
                        foodBindingSource.DataSource = context.Foods.Local.ToBindingList();
                        foodBindingSource.Sort = "FoodId Asc"; // also sort in Ascending order by Id
                        var filteredData = context.Foods.Local.ToBindingList().Where(x => x.FoodDescription.Contains(this.textBoxFilter.Text));
                        this.foodBindingSource.DataSource = filteredData.Count() > 0 ? filteredData : filteredData.ToArray();
                        if (filteredData.Count() > 0)
                        {
                            // shifts focus to first displayed cell, as long as there is something to display
                            dataGridViewFoods.Focus();
                            dataGridViewFoods.CurrentCell = dataGridViewFoods.FirstDisplayedCell;
                        }
                    }

                    // display filter in label next to text box
                    labelFilter.Text = textBoxFilter.Text;

                    // clear filter text box (in readiness for next input) while retaining focus
                    textBoxFilter.Text = "";
                }
                else // just clear filter with focus retained 
                {
                    using (var context = new FoodsContext())
                    {
                        // update dataGridViewFood with no filters
                        context.Foods.Load();
                        foodBindingSource.DataSource = context.Foods.Local.ToBindingList();
                        foodBindingSource.Sort = "FoodId Asc"; // also sort in Ascending order by Id
                    }
                    labelFilter.Text = "Unfiltered";

                    // shifts focus to fist displayed cell
                    dataGridViewFoods.Focus();
                    dataGridViewFoods.CurrentCell = dataGridViewFoods.FirstDisplayedCell;
                }
            }
        }


        /* When the Food filter text box is entered just clears the text */
        private void textBoxFilter_Enter(object sender, EventArgs e)
        {
            // always clear filter when enter text box
            textBoxFilter.Text = "";
        }


        /* This is way ONE you select an item (for recording as eaten) from the Food table
         * from the Food data grid Double Click selected item with mouse */
        private void dataGridViewFoods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            actWhenFoodSelected();
        }


        /* This is way TWO you select an item (for recording as eaten) from the food table
         * from the Food data grid Press Enter key on selected item.
         * ALSO picks up when Insert key is pressed. Used to insert/Add food to the database
         * - selection row is then clearly not relevant but just a way of enabling this action) */
        private void dataGridViewFoods_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Selecting eaten food item
            {
                actWhenFoodSelected();
                e.Handled = true; // prevents Enter key press causing next lower cell getting focus 
            }
            else if (e.KeyCode == Keys.Insert) // Adding/Inserting new food item into database
            {
                using (var context = new FoodsContext())
                {
                    // opens a dialog form used to input a record to the food table
                    // positions this form at same location (ie. top left hand corner) as this MainForm
                    foodInputForm frm = new(this);
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.Location = this.Location;
                    frm.ShowDialog();

                    if (actOnFoodAdded) // then actually add food item to database otherwise ignore (if {Cancel} button pressed)
                    {
                        // what happens now depends on what foodType you originally wanted to add. 
                        string sFD;
                        if (foodType == 0)
                        {
                            // manually added Solid food item description ends in " #"
                            sFD = addedFoodItem.FoodDescription + " #";
                        }
                        else if (foodType == 1)
                        {
                            // manually added Liquid food item description ends in " mL#"
                            sFD = addedFoodItem.FoodDescription + " mL#";
                        }
                        else // if (foodType == 2)
                        {
                            // manually added Recipe food item description ends in " *"
                            sFD = addedFoodItem.FoodDescription + " *";
                        }

                        if ((foodType == 0)|(foodType == 1))
                        {
                            // we can now add the appropriate entry to the Food table
                            var NewFood = context.Foods;
                            NewFood.Add(new Food
                            {
                                FoodDescription = sFD,
                                Energy = addedFoodItem.Energy,
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
                        }
                        else // if (foodType == 2)
                        {
                            ; // DO RECIPIE STUFF HERE
                        }

                        // refresh Foods data grid view while maintaining filter status
                        actOnFoodFilteringStates();
                    }
                }
            }
        }


        /* Manually implements the deletion of an Eaten table row
         * This was partly to overcome an exception raised when done automatically
         * mult selection is disabled for convenience */
        private void dataGridViewEaten_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // cancel the automatic deletion process (to avoid raising exceptions)
            e.Cancel = true;

            // can delete row only if the totals filter check boxed is unchecked
            if ((!checkBoxDailyTotals.Checked))
            {
                // determine row to be deleted from Eaten table by accessing it in its dataGrid
                var foodItem = (Eaten)this.dataGridViewEaten.CurrentRow.DataBoundItem;

                if (foodItem != null)
                {
                    using (var context = new FoodsContext())
                    {
                        // gain direct access to selected entry in Eaten table
                        var FoodSelected = context.Eaten.Single(b => b.EatenId == foodItem.EatenId);

                        // delete this row from Eaten table
                        context.Eaten.Remove(FoodSelected);
                        context.SaveChanges();

                        // refresh Eaten data grid view while maintaining filter status
                        actOnEatenFoodFilteringStates();
                    }
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
            }
        }


        /* Wrapper for actOnEatenFoodFilteringStates() when Date filter check box state changed */
        private void checkBoxDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            actOnEatenFoodFilteringStates();
        }


        /* Wrapper for actOnEatenFoodFilteringStates() when Totals filter check box state changed */
        private void checkBoxDailyTotals_CheckedChanged(object sender, EventArgs e)
        {
            actOnEatenFoodFilteringStates();
        }


        /* Changes visibility of columns in the Eaten Foods data grid in response to the controlling check box */
        private void checkBoxMainCols_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMainCols.Checked)
            {
                // hide non-main columns 
                dataGridViewEaten.Columns[3].Visible = false; // hide AmountEaten column
                dataGridViewEaten.Columns[9].Visible = false; // hide TransFat column
                dataGridViewEaten.Columns[10].Visible = false; // hide PolyunsaturatedFat column
                dataGridViewEaten.Columns[11].Visible = false; // hide MonounsaturatedFat column
                dataGridViewEaten.Columns[16].Visible = false; // hide CalciumCa column
                dataGridViewEaten.Columns[17].Visible = false; // hide PotassiumK column
                dataGridViewEaten.Columns[18].Visible = false; // hide ThiaminB1 column
                dataGridViewEaten.Columns[19].Visible = false; // hide RiboflavinB2 column
                dataGridViewEaten.Columns[20].Visible = false; // hide NiacinB3 column
                dataGridViewEaten.Columns[21].Visible = false; // hide Folate column
                dataGridViewEaten.Columns[22].Visible = false; // hide IronFe column
                dataGridViewEaten.Columns[23].Visible = false; // hide MagnesiumMg column
                dataGridViewEaten.Columns[24].Visible = false; // hide VitaminC column
                dataGridViewEaten.Columns[25].Visible = false; // hide Caffeine column
                dataGridViewEaten.Columns[26].Visible = false; // hide Cholesterol column
                dataGridViewEaten.Columns[27].Visible = false; // hide Alcohol column
            }
            else // if (!checkBoxMainCols.Checked)
            {
                // restore view of previously hidden non-main columns 
                dataGridViewEaten.Columns[9].Visible = true; // show TransFat column
                dataGridViewEaten.Columns[10].Visible = true; // show PolyunsaturatedFat column
                dataGridViewEaten.Columns[11].Visible = true; // show MonounsaturatedFat column
                dataGridViewEaten.Columns[16].Visible = true; // show CalciumCa column
                dataGridViewEaten.Columns[17].Visible = true; // show PotassiumK column
                dataGridViewEaten.Columns[18].Visible = true; // show ThiaminB1 column
                dataGridViewEaten.Columns[19].Visible = true; // show RiboflavinB2 column
                dataGridViewEaten.Columns[20].Visible = true; // show NiacinB3 column
                dataGridViewEaten.Columns[21].Visible = true; // show Folate column
                dataGridViewEaten.Columns[22].Visible = true; // show IronFe column
                dataGridViewEaten.Columns[23].Visible = true; // show MagnesiumMg column
                dataGridViewEaten.Columns[24].Visible = true; // show VitaminC column
                dataGridViewEaten.Columns[25].Visible = true; // show Caffeine column
                dataGridViewEaten.Columns[26].Visible = true; // show Cholesterol column
                dataGridViewEaten.Columns[27].Visible = true; // show Alcohol column
            }
        }


        /* Manually implements the deletion of a Food selected in its data grid
         * This is to control the process and fully delete recipe foods. Multi selection is disabled for convenience
         * This is run when a row is selected and any Delete key pressed (Delete or Del on the number pad) */
        private void dataGridViewFoods_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                    using (var context = new FoodsContext())
                    {
                        // gain direct access to selected record in the Foods table
                        var FoodSelected = context.Foods.Single(b => b.FoodId == foodItem.FoodId);
                        string FoodSelectedId = FoodSelected.FoodId.ToString(); // get Id for later display

                        // delete this record from Foods table
                        context.Foods.Remove(FoodSelected);
                        context.SaveChanges();
                        labelTest.Text = "Deleted food item: " + FoodSelectedId;

                        // refresh Foods data grid view while maintaining filter status
                        actOnFoodFilteringStates();
                    }
                }
            }
            else
            {
                labelTest.Text = "Did NOT delete selected food item!";
            }
        }

        /* Changes visibility of columns in the Foods data grid in response to the controlling check box */
        private void checkBoxMainFoodCols_CheckedChanged(object sender, EventArgs e)
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

    }

}