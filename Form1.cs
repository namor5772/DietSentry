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
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Foods.Load();

            this.foodBindingSource.DataSource = dbContext.Foods.Local.ToBindingList();
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
                          var filteredData = dbContext.Foods.Local.ToBindingList().Where(x => x.FoodDescription.Contains(this.textBoxFilter.Text));
                          this.foodBindingSource.DataSource = filteredData.Count() > 0 ? filteredData : filteredData.ToArray();
                          textBoxFilter.Text = "";
                    }
                    else // just clear filter 
                    {
                        this.foodBindingSource.DataSource = dbContext.Foods.Local.ToBindingList();
                    }
                }
            }
        }

        private void textBoxFilter_Enter(object sender, EventArgs e)
        {
            textBoxFilter.Text = "";
        }
    }
}