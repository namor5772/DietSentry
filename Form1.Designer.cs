namespace DietSentry
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabControlMain = new TabControl();
            tabPageFood = new TabPage();
            buttonSave = new Button();
            dataGridViewFoods = new DataGridView();
            foodBindingSource = new BindingSource(components);
            tabPageEaten = new TabPage();
            foodIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            foodDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            energyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proteinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fatTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saturatedFatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transFatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            polyunsaturatedFatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            monounsaturatedFatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carbohydrateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sugarsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dietaryFibreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sodiumNaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            calciumCaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            potassiumKDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            thiaminB1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            riboflavinB2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            niacinB3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            folateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ironFeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            magnesiumMgDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vitaminCDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            caffeineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cholesterolDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            alcoholDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabPageFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFoods).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foodBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(522, 343);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(13, 8);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(5, 0);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(5, 0);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageFood);
            tabControlMain.Controls.Add(tabPageEaten);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1687, 665);
            tabControlMain.TabIndex = 1;
            // 
            // tabPageFood
            // 
            tabPageFood.Controls.Add(buttonSave);
            tabPageFood.Controls.Add(dataGridViewFoods);
            tabPageFood.Location = new Point(4, 24);
            tabPageFood.Name = "tabPageFood";
            tabPageFood.Padding = new Padding(3);
            tabPageFood.Size = new Size(1679, 637);
            tabPageFood.TabIndex = 0;
            tabPageFood.Text = "Food";
            tabPageFood.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(8, 549);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFoods
            // 
            dataGridViewFoods.AutoGenerateColumns = false;
            dataGridViewFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFoods.Columns.AddRange(new DataGridViewColumn[] { foodIdDataGridViewTextBoxColumn, foodDescriptionDataGridViewTextBoxColumn, energyDataGridViewTextBoxColumn, proteinDataGridViewTextBoxColumn, fatTotalDataGridViewTextBoxColumn, saturatedFatDataGridViewTextBoxColumn, transFatDataGridViewTextBoxColumn, polyunsaturatedFatDataGridViewTextBoxColumn, monounsaturatedFatDataGridViewTextBoxColumn, carbohydrateDataGridViewTextBoxColumn, sugarsDataGridViewTextBoxColumn, dietaryFibreDataGridViewTextBoxColumn, sodiumNaDataGridViewTextBoxColumn, calciumCaDataGridViewTextBoxColumn, potassiumKDataGridViewTextBoxColumn, thiaminB1DataGridViewTextBoxColumn, riboflavinB2DataGridViewTextBoxColumn, niacinB3DataGridViewTextBoxColumn, folateDataGridViewTextBoxColumn, ironFeDataGridViewTextBoxColumn, magnesiumMgDataGridViewTextBoxColumn, vitaminCDataGridViewTextBoxColumn, caffeineDataGridViewTextBoxColumn, cholesterolDataGridViewTextBoxColumn, alcoholDataGridViewTextBoxColumn });
            dataGridViewFoods.DataSource = foodBindingSource;
            dataGridViewFoods.Dock = DockStyle.Top;
            dataGridViewFoods.Location = new Point(3, 3);
            dataGridViewFoods.Name = "dataGridViewFoods";
            dataGridViewFoods.RowTemplate.Height = 25;
            dataGridViewFoods.Size = new Size(1673, 540);
            dataGridViewFoods.TabIndex = 0;
            // 
            // foodBindingSource
            // 
            foodBindingSource.DataSource = typeof(Food);
            foodBindingSource.CurrentChanged += foodBindingSource_CurrentChanged;
            // 
            // tabPageEaten
            // 
            tabPageEaten.Location = new Point(4, 24);
            tabPageEaten.Name = "tabPageEaten";
            tabPageEaten.Padding = new Padding(3);
            tabPageEaten.Size = new Size(1679, 637);
            tabPageEaten.TabIndex = 1;
            tabPageEaten.Text = "Eaten";
            tabPageEaten.UseVisualStyleBackColor = true;
            // 
            // foodIdDataGridViewTextBoxColumn
            // 
            foodIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            foodIdDataGridViewTextBoxColumn.DataPropertyName = "FoodId";
            foodIdDataGridViewTextBoxColumn.HeaderText = "Id";
            foodIdDataGridViewTextBoxColumn.Name = "foodIdDataGridViewTextBoxColumn";
            foodIdDataGridViewTextBoxColumn.ReadOnly = true;
            foodIdDataGridViewTextBoxColumn.Width = 42;
            // 
            // foodDescriptionDataGridViewTextBoxColumn
            // 
            foodDescriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            foodDescriptionDataGridViewTextBoxColumn.DataPropertyName = "FoodDescription";
            foodDescriptionDataGridViewTextBoxColumn.HeaderText = "Food description";
            foodDescriptionDataGridViewTextBoxColumn.Name = "foodDescriptionDataGridViewTextBoxColumn";
            foodDescriptionDataGridViewTextBoxColumn.Width = 111;
            // 
            // energyDataGridViewTextBoxColumn
            // 
            energyDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            energyDataGridViewTextBoxColumn.DataPropertyName = "Energy";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "n0";
            dataGridViewCellStyle1.NullValue = "0";
            energyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            energyDataGridViewTextBoxColumn.HeaderText = "Energy (kJ)";
            energyDataGridViewTextBoxColumn.Name = "energyDataGridViewTextBoxColumn";
            energyDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            energyDataGridViewTextBoxColumn.Width = 63;
            // 
            // proteinDataGridViewTextBoxColumn
            // 
            proteinDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            proteinDataGridViewTextBoxColumn.DataPropertyName = "Protein";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N1";
            dataGridViewCellStyle2.NullValue = "0";
            proteinDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            proteinDataGridViewTextBoxColumn.HeaderText = "Protein (g)";
            proteinDataGridViewTextBoxColumn.Name = "proteinDataGridViewTextBoxColumn";
            proteinDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            proteinDataGridViewTextBoxColumn.Width = 62;
            // 
            // fatTotalDataGridViewTextBoxColumn
            // 
            fatTotalDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            fatTotalDataGridViewTextBoxColumn.DataPropertyName = "FatTotal";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N1";
            dataGridViewCellStyle3.NullValue = "0";
            fatTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            fatTotalDataGridViewTextBoxColumn.HeaderText = "Fat Total (g)";
            fatTotalDataGridViewTextBoxColumn.Name = "fatTotalDataGridViewTextBoxColumn";
            fatTotalDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            fatTotalDataGridViewTextBoxColumn.Width = 68;
            // 
            // saturatedFatDataGridViewTextBoxColumn
            // 
            saturatedFatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            saturatedFatDataGridViewTextBoxColumn.DataPropertyName = "SaturatedFat";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N1";
            dataGridViewCellStyle4.NullValue = "0";
            saturatedFatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            saturatedFatDataGridViewTextBoxColumn.HeaderText = "-Saturated Fat (g)";
            saturatedFatDataGridViewTextBoxColumn.Name = "saturatedFatDataGridViewTextBoxColumn";
            saturatedFatDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            saturatedFatDataGridViewTextBoxColumn.Width = 81;
            // 
            // transFatDataGridViewTextBoxColumn
            // 
            transFatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            transFatDataGridViewTextBoxColumn.DataPropertyName = "TransFat";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N1";
            dataGridViewCellStyle5.NullValue = "0";
            transFatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            transFatDataGridViewTextBoxColumn.HeaderText = "-Trans Fat (g)";
            transFatDataGridViewTextBoxColumn.Name = "transFatDataGridViewTextBoxColumn";
            transFatDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            transFatDataGridViewTextBoxColumn.Width = 60;
            // 
            // polyunsaturatedFatDataGridViewTextBoxColumn
            // 
            polyunsaturatedFatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            polyunsaturatedFatDataGridViewTextBoxColumn.DataPropertyName = "PolyunsaturatedFat";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N1";
            dataGridViewCellStyle6.NullValue = "0";
            polyunsaturatedFatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            polyunsaturatedFatDataGridViewTextBoxColumn.HeaderText = "-Polyunsaturated Fat (g)";
            polyunsaturatedFatDataGridViewTextBoxColumn.Name = "polyunsaturatedFatDataGridViewTextBoxColumn";
            polyunsaturatedFatDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            polyunsaturatedFatDataGridViewTextBoxColumn.Width = 114;
            // 
            // monounsaturatedFatDataGridViewTextBoxColumn
            // 
            monounsaturatedFatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            monounsaturatedFatDataGridViewTextBoxColumn.DataPropertyName = "MonounsaturatedFat";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N1";
            dataGridViewCellStyle7.NullValue = "0";
            monounsaturatedFatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            monounsaturatedFatDataGridViewTextBoxColumn.HeaderText = "-Monounsaturated Fat (g)";
            monounsaturatedFatDataGridViewTextBoxColumn.Name = "monounsaturatedFatDataGridViewTextBoxColumn";
            monounsaturatedFatDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            monounsaturatedFatDataGridViewTextBoxColumn.Width = 122;
            // 
            // carbohydrateDataGridViewTextBoxColumn
            // 
            carbohydrateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            carbohydrateDataGridViewTextBoxColumn.DataPropertyName = "Carbohydrate";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N1";
            dataGridViewCellStyle8.NullValue = "0";
            carbohydrateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            carbohydrateDataGridViewTextBoxColumn.HeaderText = "Carbohydrate (g)";
            carbohydrateDataGridViewTextBoxColumn.Name = "carbohydrateDataGridViewTextBoxColumn";
            carbohydrateDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            carbohydrateDataGridViewTextBoxColumn.Width = 93;
            // 
            // sugarsDataGridViewTextBoxColumn
            // 
            sugarsDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sugarsDataGridViewTextBoxColumn.DataPropertyName = "Sugars";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            sugarsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            sugarsDataGridViewTextBoxColumn.HeaderText = "-Sugars (g)";
            sugarsDataGridViewTextBoxColumn.Name = "sugarsDataGridViewTextBoxColumn";
            sugarsDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            sugarsDataGridViewTextBoxColumn.Width = 64;
            // 
            // dietaryFibreDataGridViewTextBoxColumn
            // 
            dietaryFibreDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dietaryFibreDataGridViewTextBoxColumn.DataPropertyName = "DietaryFibre";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            dietaryFibreDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            dietaryFibreDataGridViewTextBoxColumn.HeaderText = "Dietary Fibre (g)";
            dietaryFibreDataGridViewTextBoxColumn.Name = "dietaryFibreDataGridViewTextBoxColumn";
            dietaryFibreDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            dietaryFibreDataGridViewTextBoxColumn.Width = 74;
            // 
            // sodiumNaDataGridViewTextBoxColumn
            // 
            sodiumNaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sodiumNaDataGridViewTextBoxColumn.DataPropertyName = "SodiumNa";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N1";
            dataGridViewCellStyle11.NullValue = "0";
            sodiumNaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            sodiumNaDataGridViewTextBoxColumn.HeaderText = "Sodium Na (mg)";
            sodiumNaDataGridViewTextBoxColumn.Name = "sodiumNaDataGridViewTextBoxColumn";
            sodiumNaDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            sodiumNaDataGridViewTextBoxColumn.Width = 68;
            // 
            // calciumCaDataGridViewTextBoxColumn
            // 
            calciumCaDataGridViewTextBoxColumn.DataPropertyName = "CalciumCa";
            calciumCaDataGridViewTextBoxColumn.HeaderText = "Calcium Ca (g)";
            calciumCaDataGridViewTextBoxColumn.Name = "calciumCaDataGridViewTextBoxColumn";
            // 
            // potassiumKDataGridViewTextBoxColumn
            // 
            potassiumKDataGridViewTextBoxColumn.DataPropertyName = "PotassiumK";
            potassiumKDataGridViewTextBoxColumn.HeaderText = "Potassium K (mg)";
            potassiumKDataGridViewTextBoxColumn.Name = "potassiumKDataGridViewTextBoxColumn";
            // 
            // thiaminB1DataGridViewTextBoxColumn
            // 
            thiaminB1DataGridViewTextBoxColumn.DataPropertyName = "ThiaminB1";
            thiaminB1DataGridViewTextBoxColumn.HeaderText = "Thiamin B1 (mg)";
            thiaminB1DataGridViewTextBoxColumn.Name = "thiaminB1DataGridViewTextBoxColumn";
            // 
            // riboflavinB2DataGridViewTextBoxColumn
            // 
            riboflavinB2DataGridViewTextBoxColumn.DataPropertyName = "RiboflavinB2";
            riboflavinB2DataGridViewTextBoxColumn.HeaderText = "Riboflavin B2 (mg)";
            riboflavinB2DataGridViewTextBoxColumn.Name = "riboflavinB2DataGridViewTextBoxColumn";
            // 
            // niacinB3DataGridViewTextBoxColumn
            // 
            niacinB3DataGridViewTextBoxColumn.DataPropertyName = "NiacinB3";
            niacinB3DataGridViewTextBoxColumn.HeaderText = "Niacin B3 (mg)";
            niacinB3DataGridViewTextBoxColumn.Name = "niacinB3DataGridViewTextBoxColumn";
            // 
            // folateDataGridViewTextBoxColumn
            // 
            folateDataGridViewTextBoxColumn.DataPropertyName = "Folate";
            folateDataGridViewTextBoxColumn.HeaderText = "Folate (ug)";
            folateDataGridViewTextBoxColumn.Name = "folateDataGridViewTextBoxColumn";
            // 
            // ironFeDataGridViewTextBoxColumn
            // 
            ironFeDataGridViewTextBoxColumn.DataPropertyName = "IronFe";
            ironFeDataGridViewTextBoxColumn.HeaderText = "Iron Fe (mg)";
            ironFeDataGridViewTextBoxColumn.Name = "ironFeDataGridViewTextBoxColumn";
            // 
            // magnesiumMgDataGridViewTextBoxColumn
            // 
            magnesiumMgDataGridViewTextBoxColumn.DataPropertyName = "MagnesiumMg";
            magnesiumMgDataGridViewTextBoxColumn.HeaderText = "Magnesium Mg (mg)";
            magnesiumMgDataGridViewTextBoxColumn.Name = "magnesiumMgDataGridViewTextBoxColumn";
            // 
            // vitaminCDataGridViewTextBoxColumn
            // 
            vitaminCDataGridViewTextBoxColumn.DataPropertyName = "VitaminC";
            vitaminCDataGridViewTextBoxColumn.HeaderText = "Vitamin C (mg)";
            vitaminCDataGridViewTextBoxColumn.Name = "vitaminCDataGridViewTextBoxColumn";
            // 
            // caffeineDataGridViewTextBoxColumn
            // 
            caffeineDataGridViewTextBoxColumn.DataPropertyName = "Caffeine";
            caffeineDataGridViewTextBoxColumn.HeaderText = "Caffeine (mg)";
            caffeineDataGridViewTextBoxColumn.Name = "caffeineDataGridViewTextBoxColumn";
            // 
            // cholesterolDataGridViewTextBoxColumn
            // 
            cholesterolDataGridViewTextBoxColumn.DataPropertyName = "Cholesterol";
            cholesterolDataGridViewTextBoxColumn.HeaderText = "Cholesterol (mg)";
            cholesterolDataGridViewTextBoxColumn.Name = "cholesterolDataGridViewTextBoxColumn";
            // 
            // alcoholDataGridViewTextBoxColumn
            // 
            alcoholDataGridViewTextBoxColumn.DataPropertyName = "Alcohol";
            alcoholDataGridViewTextBoxColumn.HeaderText = "Alcohol (g)";
            alcoholDataGridViewTextBoxColumn.Name = "alcoholDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1687, 665);
            Controls.Add(tabControlMain);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Diet Sentry";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabControlMain.ResumeLayout(false);
            tabPageFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFoods).EndInit();
            ((System.ComponentModel.ISupportInitialize)foodBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabControl tabControlMain;
        private TabPage tabPageFood;
        private TabPage tabPageEaten;
        private DataGridView dataGridViewFoods;
        private Button buttonSave;
        private BindingSource foodBindingSource;
        private DataGridViewTextBoxColumn foodIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn foodDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn energyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proteinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fatTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saturatedFatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transFatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn polyunsaturatedFatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn monounsaturatedFatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carbohydrateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sugarsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dietaryFibreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sodiumNaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn calciumCaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn potassiumKDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thiaminB1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn riboflavinB2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn niacinB3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn folateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ironFeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn magnesiumMgDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vitaminCDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn caffeineDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cholesterolDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alcoholDataGridViewTextBoxColumn;
    }
}