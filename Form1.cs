using DietSentry;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

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

        private void eatenBindingSource_CurrentChanged(object sender, EventArgs e)
        {

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

        private void dataGridViewFoods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InputForm frm = new InputForm(this);
            actOnInputFormClose = true;
            frm.ShowDialog();
            this.label1.Text = sX;
            //            this.label1.Text = "HO HO HO";
        }

    }
}