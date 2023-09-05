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

        private void MainForm_Load(object sender, EventArgs e)
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

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /*
                private void eatenBindingSource_CurrentChanged(object sender, EventArgs e)
                {

                }
        */
        private void buttonAddSolid_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddLiquid_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            /**
                        if (actOnInputFormClose)
                        {
                            this.label1.Text = sX;
                            actOnInputFormClose = false;
                        }
*/
        }

        // this is how you select an item in the food table from the Food data grid  
        private void dataGridViewFoods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

                        this.textBox1.Text = FoodSelected.FoodId.ToString();
                        this.textBox2.Text = FoodSelected.FoodDescription;

                        // this opens dialog used to input the quantity of that food eaten
                        InputForm frm = new InputForm(this);
                        //actOnInputFormClose = true;
                        frm.ShowDialog();

                        // only act on input if amout eaten >0, this includes the case when Enter is immediately pressed in the text box
                        if (amountOfFoodEaten > 0.0)
                        {

                            // we can now add the appropriate entry to the Eaten table, sort it and refresh its Eaten data grid and give it focus
                            var EatenFood = context.Eaten;
                            EatenFood.Add(new Eaten
                            {
                                DateTimeEaten = DateTime.Now.ToString("d-MMM-yy hh:mm"),
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

    }
}