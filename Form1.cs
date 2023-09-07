using DietSentry;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
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
        // It prompts for amout of food eaten and appends a time stamed row to the Eaten foods table.
        private void actWhenFoodSelected()
        {
            if (this.dbContext != null)
            {
                var foodItem = (Food)this.dataGridViewFoods.CurrentRow.DataBoundItem;

                if (foodItem != null)
                {
                    using (var context = new FoodsContext())
                    {
                        // gain access to selected entry in food table
                        var FoodSelected = context.Foods.Single(b => b.FoodId == foodItem.FoodId);
                        eatenFoodDescription = FoodSelected.FoodDescription;

                        // this opens dialog used to input the quantity of that food eaten
                        InputForm frm = new InputForm(this);
                        //frm.StartPosition = FormStartPosition.Manual;
                        //frm.Location = new Point(100, 100);
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
                        }
                    }
                }
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

        private void foodBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();

            this.dataGridViewFoods.Refresh();
            this.dataGridViewEaten.Refresh();
        }

        private void buttonSetFilter_Click(object sender, EventArgs e)
        {
            if (this.dbContext != null)
            {
                var filteredData = dbContext.Foods.Local.ToBindingList().Where(x => x.FoodDescription.Contains(this.textBoxFilter.Text));
                this.foodBindingSource.DataSource = filteredData.Count() > 0 ? filteredData : filteredData.ToArray();
            }
        }

        private void buttonClearFilter_Click(object sender, EventArgs e)
        {
            if (this.dbContext != null)
            {
                this.foodBindingSource.DataSource = dbContext.Foods.Local.ToBindingList();
            }
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


        // manually implements the deletion of a Eaten table row.
        // This was partly to overcome an exception raised when done automatically.
        // mult selection is disabled for convenience.
        private void dataGridViewEaten_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true; // cancels the automatic deletion process
            if (this.dbContext != null)
            {
                // determine row to be deleted from Eaten table by accessing it in its dataGrid
                var foodItem = (Eaten)this.dataGridViewEaten.CurrentRow.DataBoundItem;

                if (foodItem != null)
                {
                    using (var context = new FoodsContext())
                    {
                        // gain direct access to selected entry in Eaten table
                        var FoodSelected = context.Eaten.Single(b => b.EatenId == foodItem.EatenId);
                        this.label1.Text = FoodSelected.FoodDescription;

                        // delete this row from Eaten table
                        context.Eaten.Remove(FoodSelected);
                        context.SaveChanges();

                        // update dataGridViewEaten - but why does this work and is there any memory leakage?
                 //       var EatenFood = context.Eaten;
                        context.Eaten.Load();
                        eatenBindingSource.DataSource = context.Eaten.Local.ToBindingList();
                        eatenBindingSource.Sort = "EatenId Asc"; // also sort in Ascending order by Id
                    }
                }
            }
        }

        private void dataGridViewEaten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPageEaten_Click(object sender, EventArgs e)
        {

        }

        private void buttonRunQuery_Click(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("d-MMM-yy   hh:mm:ss");

            try
            {
                using (var context = new FoodsContext())
                {
                    context.Eaten.Load();

                    // display filtered data in DataGrid
                    //               var filteredData = context.Eaten.Local.ToBindingList().Where(x => x.DateEaten.Contains("7-Sept-23"));
                    var filteredData = context.Eaten.Local.ToBindingList().GroupBy(o => o.DateEaten).Select(g => new {
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
                    });
                    this.eatenBindingSource.DataSource = filteredData.Count() > 0 ? filteredData : filteredData.ToArray();

                    /*
                                            // gain access to selected entries in food table
                                            var TotalFoodsEaten = context.Eaten.Local.ToBindingList().Where(b => b.EatenId == foodItem.EatenId);
                                            float X = TotalFoodsEaten.AmountEaten;
                                            string S = X.ToString("N0");
                                            labelAmountTotal.Text = S;
                    */
                }

            }
            catch // some sorting problem
            {
                labelAmountTotal.Text = "Caught exception";
            }
        }

        private void buttonResetQuery_Click(object sender, EventArgs e)
        {
            using (var context = new FoodsContext())
            {
                    // update dataGridViewEaten - but why does this work and is there any memory leakage?
                    context.Eaten.Load();
                    eatenBindingSource.DataSource = context.Eaten.Local.ToBindingList();
                    eatenBindingSource.Sort = "EatenId Asc"; // also sort in Ascending order by Id
            }
            labelAmountTotal.Text = "Reset";
        }
    }

}