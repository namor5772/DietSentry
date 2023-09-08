using DietSentry;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DietSentry
{
    public partial class MainForm : Form
    {

        private FoodsContext? dbContext;

        public MainForm()
        {
            InitializeComponent();
        }

        // code that acts when a food item is selected from the Foods dataGridView.
        // It prompts for amount of food eaten and appends a time stamped row to the Eaten foods table.
        private void actWhenFoodSelected()
        {
            if (dbContext != null)
            {
                var foodItem = (Food)dataGridViewFoods.CurrentRow.DataBoundItem;

                if (foodItem != null)
                {
                    using (var context = new FoodsContext())
                    {
                        // gain access to selected entry in food table
                        var FoodSelected = context.Foods.Single(b => b.FoodId == foodItem.FoodId);
                        eatenFoodDescription = FoodSelected.FoodDescription;

                        // this opens dialog used to input the quantity of that food eaten
                        InputForm frm = new InputForm(this);
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
                                Alcohol = (FoodSelected.Alcohol) * amountOfFoodEaten,
                            });
                            context.SaveChanges();

                            // this updates dataGridViewEaten - but why, and is there any memory leakage?
                            EatenFood.Load();
                            eatenBindingSource.DataSource = EatenFood.Local.ToBindingList();
                            eatenBindingSource.Sort = "EatenId Asc"; // also sort in Ascending order by Id
                            tabControlMain.SelectedTab = tabPageEaten; // and make the Eaten tab visible

                            actOnEatenFoodFilteringStates();

                            // 
                        }
                    }
                }
            }
        }

        // act on Eaten food filtering states
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
                dataGridViewEaten.Columns[4].Visible = true; // show FoodDescription column
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
            this.dbContext!.SaveChanges();

            this.dataGridViewFoods.Refresh();
            this.dataGridViewEaten.Refresh();
        }


        private void textBoxFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.dbContext != null)
                {
                    e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 

                    if (this.textBoxFilter.Text != "") // only accept a non-null string as a filter
                    {
                        // display filtered data in DataGrid
                        var filteredData = dbContext.Foods.Local.ToBindingList().Where(x => x.FoodDescription.Contains(this.textBoxFilter.Text));
                        this.foodBindingSource.DataSource = filteredData.Count() > 0 ? filteredData : filteredData.ToArray();

                        // display filter in label next to text box
                        labelFilter.Text = textBoxFilter.Text;

                        // clear filter text box (in readiness for next input) while retaining focus
                        textBoxFilter.Text = "";
                    }
                    else // just clear filter with focus retained 
                    {
                        this.foodBindingSource.DataSource = dbContext.Foods.Local.ToBindingList();
                        labelFilter.Text = "unfiltered";
                    }
                }
            }
        }

        private void textBoxFilter_Enter(object sender, EventArgs e)
        {
            // always clear filter when enter text box
            textBoxFilter.Text = "";
        }

        private void buttonAddSolid_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddLiquid_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {

        }


        // this is one way you select an item in the food table from the Food data grid  
        private void dataGridViewFoods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            actWhenFoodSelected();
        }


        // this is another way you select an item in the food table from the Food data grid  
        private void dataGridViewFoods_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                actWhenFoodSelected();
                e.Handled = true; // prevents Enter key press causing next lower cell getting focus 
            }
        }


        // manually implements the deletion of an Eaten table row.
        // This was partly to overcome an exception raised when done automatically.
        // mult selection is disabled for convenience.
        private void dataGridViewEaten_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // cancel the automatic deletion process (to avoid raising exceptions)
            e.Cancel = true;

            // can delete row only if both the totals and date filter check boxed are unchecked
            if ((!checkBoxDailyTotals.Checked) & (!checkBoxDateFilter.Checked))
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

                        // update dataGridViewEaten - but why does this work and is there any memory leakage?
                        context.Eaten.Load();
                        eatenBindingSource.DataSource = context.Eaten.Local.ToBindingList();
                        eatenBindingSource.Sort = "EatenId Asc"; // also sort in Ascending order by Id
                    }
                }
            }
            else // prevent row deletion and inform user of this by displaying Message Box
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Only possible when table view unchanged";
                string caption = "CANNOT DELETE ROW";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                // Displays the MessageBox.
                MessageBox.Show(message, caption, buttons);

                checkBoxDateFilter.Checked = false;
                checkBoxDailyTotals.Checked = false;
            }
        }

        private void checkBoxDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            actOnEatenFoodFilteringStates();
        }

        private void checkBoxDailyTotals_CheckedChanged(object sender, EventArgs e)
        {
            actOnEatenFoodFilteringStates();
        }

        private void checkBoxMainCols_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMainCols.Checked)
            {
                // hide non-main columns 
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
    }

}