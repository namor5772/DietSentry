using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

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

        // MY "GLOBAL" VARIABLES ******************

        // variable which is set to true so that something specific can be done when MainForm is reactivated after InputForm is closed
        public Boolean actOnInputFormClose = false;

        // A variable in MainForm which stores data collected from the InputForm
        public float amountOfFoodEaten; // in "units" of 100 g or mL

        // A string describing the eaten food selected
        public string eatenFoodDescription;

        // Declaring a Food item class instance
        public Food addedFoodItem = new Food();

        // ****************************************


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
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
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle58 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle31 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle32 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle33 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle34 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle35 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle36 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle37 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle38 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle39 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle40 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle43 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle44 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle45 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle46 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle47 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle48 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle49 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle50 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle51 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle52 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle53 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle54 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle55 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle56 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle57 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabControlMain = new TabControl();
            tabPageFood = new TabPage();
            labelTest = new Label();
            checkBoxMainFoodCols = new CheckBox();
            labelFilter = new Label();
            textBoxFilter = new TextBox();
            buttonSave = new Button();
            dataGridViewFoods = new DataGridView();
            FoodIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            foodBindingSource = new BindingSource(components);
            tabPageEaten = new TabPage();
            checkBoxMainCols = new CheckBox();
            checkBoxDailyTotals = new CheckBox();
            checkBoxDateFilter = new CheckBox();
            dataGridViewEaten = new DataGridView();
            EatenId = new DataGridViewTextBoxColumn();
            DateEaten = new DataGridViewTextBoxColumn();
            TimeEaten = new DataGridViewTextBoxColumn();
            amountEatenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            foodDescriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            energyDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            proteinDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            fatTotalDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            saturatedFatDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            transFatDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            polyunsaturatedFatDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            monounsaturatedFatDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            carbohydrateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            sugarsDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dietaryFibreDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            sodiumNaDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            calciumCaDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            potassiumKDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            thiaminB1DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            riboflavinB2DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            niacinB3DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            folateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ironFeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            magnesiumMgDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            vitaminCDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            caffeineDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            cholesterolDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            alcoholDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            eatenBindingSource = new BindingSource(components);
            tabControl1.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabPageFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFoods).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foodBindingSource).BeginInit();
            tabPageEaten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEaten).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eatenBindingSource).BeginInit();
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
            tabControlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlMain.Appearance = TabAppearance.Buttons;
            tabControlMain.Controls.Add(tabPageFood);
            tabControlMain.Controls.Add(tabPageEaten);
            tabControlMain.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Multiline = true;
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1347, 635);
            tabControlMain.TabIndex = 1;
            tabControlMain.TabStop = false;
            // 
            // tabPageFood
            // 
            tabPageFood.Controls.Add(labelTest);
            tabPageFood.Controls.Add(checkBoxMainFoodCols);
            tabPageFood.Controls.Add(labelFilter);
            tabPageFood.Controls.Add(textBoxFilter);
            tabPageFood.Controls.Add(buttonSave);
            tabPageFood.Controls.Add(dataGridViewFoods);
            tabPageFood.Location = new Point(4, 27);
            tabPageFood.Name = "tabPageFood";
            tabPageFood.Padding = new Padding(3);
            tabPageFood.Size = new Size(1339, 604);
            tabPageFood.TabIndex = 0;
            tabPageFood.Text = "Food";
            tabPageFood.UseVisualStyleBackColor = true;
            // 
            // labelTest
            // 
            labelTest.AutoSize = true;
            labelTest.Location = new Point(341, 19);
            labelTest.Name = "labelTest";
            labelTest.Size = new Size(54, 15);
            labelTest.TabIndex = 9;
            labelTest.Text = "test label";
            // 
            // checkBoxMainFoodCols
            // 
            checkBoxMainFoodCols.AutoSize = true;
            checkBoxMainFoodCols.Location = new Point(23, 18);
            checkBoxMainFoodCols.Name = "checkBoxMainFoodCols";
            checkBoxMainFoodCols.Size = new Size(161, 19);
            checkBoxMainFoodCols.TabIndex = 8;
            checkBoxMainFoodCols.Text = "Only show main columns";
            checkBoxMainFoodCols.UseVisualStyleBackColor = true;
            checkBoxMainFoodCols.CheckedChanged += checkBoxMainFoodCols_CheckedChanged;
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.BackColor = Color.LightCyan;
            labelFilter.Location = new Point(164, 58);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(59, 15);
            labelFilter.TabIndex = 3;
            labelFilter.Text = "Unfiltered";
            // 
            // textBoxFilter
            // 
            textBoxFilter.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxFilter.AutoCompleteSource = AutoCompleteSource.HistoryList;
            textBoxFilter.Location = new Point(23, 55);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.PlaceholderText = "Enter food filter text";
            textBoxFilter.Size = new Size(135, 23);
            textBoxFilter.TabIndex = 2;
            textBoxFilter.WordWrap = false;
            textBoxFilter.Enter += textBoxFilter_Enter;
            textBoxFilter.KeyDown += textBoxFilter_KeyDown;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(1122, 35);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // dataGridViewFoods
            // 
            dataGridViewFoods.AllowUserToAddRows = false;
            dataGridViewFoods.AllowUserToOrderColumns = true;
            dataGridViewFoods.AllowUserToResizeColumns = false;
            dataGridViewFoods.AllowUserToResizeRows = false;
            dataGridViewFoods.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewFoods.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Azure;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewFoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFoods.Columns.AddRange(new DataGridViewColumn[] { FoodIdDataGridViewTextBoxColumn, foodDescriptionDataGridViewTextBoxColumn, energyDataGridViewTextBoxColumn, proteinDataGridViewTextBoxColumn, fatTotalDataGridViewTextBoxColumn, saturatedFatDataGridViewTextBoxColumn, transFatDataGridViewTextBoxColumn, polyunsaturatedFatDataGridViewTextBoxColumn, monounsaturatedFatDataGridViewTextBoxColumn, carbohydrateDataGridViewTextBoxColumn, sugarsDataGridViewTextBoxColumn, dietaryFibreDataGridViewTextBoxColumn, sodiumNaDataGridViewTextBoxColumn, calciumCaDataGridViewTextBoxColumn, potassiumKDataGridViewTextBoxColumn, thiaminB1DataGridViewTextBoxColumn, riboflavinB2DataGridViewTextBoxColumn, niacinB3DataGridViewTextBoxColumn, folateDataGridViewTextBoxColumn, ironFeDataGridViewTextBoxColumn, magnesiumMgDataGridViewTextBoxColumn, vitaminCDataGridViewTextBoxColumn, caffeineDataGridViewTextBoxColumn, cholesterolDataGridViewTextBoxColumn, alcoholDataGridViewTextBoxColumn });
            dataGridViewFoods.DataSource = foodBindingSource;
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = SystemColors.Info;
            dataGridViewCellStyle27.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle27.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = DataGridViewTriState.False;
            dataGridViewFoods.DefaultCellStyle = dataGridViewCellStyle27;
            dataGridViewFoods.EnableHeadersVisualStyles = false;
            dataGridViewFoods.Location = new Point(3, 99);
            dataGridViewFoods.MultiSelect = false;
            dataGridViewFoods.Name = "dataGridViewFoods";
            dataGridViewFoods.ReadOnly = true;
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle28.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = Color.White;
            dataGridViewCellStyle28.WrapMode = DataGridViewTriState.True;
            dataGridViewFoods.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            dataGridViewFoods.RowHeadersWidth = 49;
            dataGridViewFoods.RowTemplate.Height = 25;
            dataGridViewFoods.ShowCellToolTips = false;
            dataGridViewFoods.ShowEditingIcon = false;
            dataGridViewFoods.Size = new Size(1333, 502);
            dataGridViewFoods.TabIndex = 4;
            dataGridViewFoods.CellDoubleClick += dataGridViewFoods_CellDoubleClick;
            dataGridViewFoods.UserDeletingRow += dataGridViewFoods_UserDeletingRow;
            dataGridViewFoods.KeyDown += dataGridViewFoods_KeyDown;
            // 
            // FoodIdDataGridViewTextBoxColumn
            // 
            FoodIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            FoodIdDataGridViewTextBoxColumn.DataPropertyName = "FoodId";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            FoodIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            FoodIdDataGridViewTextBoxColumn.HeaderText = "Id";
            FoodIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            FoodIdDataGridViewTextBoxColumn.Name = "FoodIdDataGridViewTextBoxColumn";
            FoodIdDataGridViewTextBoxColumn.ReadOnly = true;
            FoodIdDataGridViewTextBoxColumn.Width = 42;
            // 
            // foodDescriptionDataGridViewTextBoxColumn
            // 
            foodDescriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            foodDescriptionDataGridViewTextBoxColumn.DataPropertyName = "FoodDescription";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            foodDescriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            foodDescriptionDataGridViewTextBoxColumn.HeaderText = "Food description";
            foodDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            foodDescriptionDataGridViewTextBoxColumn.Name = "foodDescriptionDataGridViewTextBoxColumn";
            foodDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            foodDescriptionDataGridViewTextBoxColumn.Width = 111;
            // 
            // energyDataGridViewTextBoxColumn
            // 
            energyDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            energyDataGridViewTextBoxColumn.DataPropertyName = "Energy";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            energyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            energyDataGridViewTextBoxColumn.HeaderText = "Energy (kJ)";
            energyDataGridViewTextBoxColumn.MinimumWidth = 8;
            energyDataGridViewTextBoxColumn.Name = "energyDataGridViewTextBoxColumn";
            energyDataGridViewTextBoxColumn.ReadOnly = true;
            energyDataGridViewTextBoxColumn.Width = 82;
            // 
            // proteinDataGridViewTextBoxColumn
            // 
            proteinDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            proteinDataGridViewTextBoxColumn.DataPropertyName = "Protein";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N1";
            dataGridViewCellStyle5.NullValue = "0";
            proteinDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            proteinDataGridViewTextBoxColumn.HeaderText = "Protein (g)";
            proteinDataGridViewTextBoxColumn.MinimumWidth = 6;
            proteinDataGridViewTextBoxColumn.Name = "proteinDataGridViewTextBoxColumn";
            proteinDataGridViewTextBoxColumn.ReadOnly = true;
            proteinDataGridViewTextBoxColumn.Width = 81;
            // 
            // fatTotalDataGridViewTextBoxColumn
            // 
            fatTotalDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            fatTotalDataGridViewTextBoxColumn.DataPropertyName = "FatTotal";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N1";
            dataGridViewCellStyle6.NullValue = "0";
            fatTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            fatTotalDataGridViewTextBoxColumn.HeaderText = "Fat Total (g)";
            fatTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            fatTotalDataGridViewTextBoxColumn.Name = "fatTotalDataGridViewTextBoxColumn";
            fatTotalDataGridViewTextBoxColumn.ReadOnly = true;
            fatTotalDataGridViewTextBoxColumn.Width = 87;
            // 
            // saturatedFatDataGridViewTextBoxColumn
            // 
            saturatedFatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            saturatedFatDataGridViewTextBoxColumn.DataPropertyName = "SaturatedFat";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0";
            saturatedFatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            saturatedFatDataGridViewTextBoxColumn.HeaderText = "-Saturated Fat (g)";
            saturatedFatDataGridViewTextBoxColumn.MinimumWidth = 6;
            saturatedFatDataGridViewTextBoxColumn.Name = "saturatedFatDataGridViewTextBoxColumn";
            saturatedFatDataGridViewTextBoxColumn.ReadOnly = true;
            saturatedFatDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            saturatedFatDataGridViewTextBoxColumn.Width = 81;
            // 
            // transFatDataGridViewTextBoxColumn
            // 
            transFatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            transFatDataGridViewTextBoxColumn.DataPropertyName = "TransFat";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0";
            transFatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            transFatDataGridViewTextBoxColumn.HeaderText = "-Trans Fat (mg)";
            transFatDataGridViewTextBoxColumn.MinimumWidth = 6;
            transFatDataGridViewTextBoxColumn.Name = "transFatDataGridViewTextBoxColumn";
            transFatDataGridViewTextBoxColumn.ReadOnly = true;
            transFatDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            transFatDataGridViewTextBoxColumn.Width = 60;
            // 
            // polyunsaturatedFatDataGridViewTextBoxColumn
            // 
            polyunsaturatedFatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            polyunsaturatedFatDataGridViewTextBoxColumn.DataPropertyName = "PolyunsaturatedFat";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = "0";
            polyunsaturatedFatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            polyunsaturatedFatDataGridViewTextBoxColumn.HeaderText = "-Polyunsaturated Fat (g)";
            polyunsaturatedFatDataGridViewTextBoxColumn.MinimumWidth = 6;
            polyunsaturatedFatDataGridViewTextBoxColumn.Name = "polyunsaturatedFatDataGridViewTextBoxColumn";
            polyunsaturatedFatDataGridViewTextBoxColumn.ReadOnly = true;
            polyunsaturatedFatDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            polyunsaturatedFatDataGridViewTextBoxColumn.Width = 114;
            // 
            // monounsaturatedFatDataGridViewTextBoxColumn
            // 
            monounsaturatedFatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            monounsaturatedFatDataGridViewTextBoxColumn.DataPropertyName = "MonounsaturatedFat";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = "0";
            monounsaturatedFatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            monounsaturatedFatDataGridViewTextBoxColumn.HeaderText = "-Monounsaturated Fat (g)";
            monounsaturatedFatDataGridViewTextBoxColumn.MinimumWidth = 6;
            monounsaturatedFatDataGridViewTextBoxColumn.Name = "monounsaturatedFatDataGridViewTextBoxColumn";
            monounsaturatedFatDataGridViewTextBoxColumn.ReadOnly = true;
            monounsaturatedFatDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            monounsaturatedFatDataGridViewTextBoxColumn.Width = 122;
            // 
            // carbohydrateDataGridViewTextBoxColumn
            // 
            carbohydrateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            carbohydrateDataGridViewTextBoxColumn.DataPropertyName = "Carbohydrate";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N1";
            dataGridViewCellStyle11.NullValue = "0";
            carbohydrateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            carbohydrateDataGridViewTextBoxColumn.HeaderText = "Carbohydrate (g)";
            carbohydrateDataGridViewTextBoxColumn.MinimumWidth = 6;
            carbohydrateDataGridViewTextBoxColumn.Name = "carbohydrateDataGridViewTextBoxColumn";
            carbohydrateDataGridViewTextBoxColumn.ReadOnly = true;
            carbohydrateDataGridViewTextBoxColumn.Width = 112;
            // 
            // sugarsDataGridViewTextBoxColumn
            // 
            sugarsDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sugarsDataGridViewTextBoxColumn.DataPropertyName = "Sugars";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N1";
            dataGridViewCellStyle12.NullValue = "0";
            sugarsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            sugarsDataGridViewTextBoxColumn.HeaderText = "-Sugars (g)";
            sugarsDataGridViewTextBoxColumn.MinimumWidth = 6;
            sugarsDataGridViewTextBoxColumn.Name = "sugarsDataGridViewTextBoxColumn";
            sugarsDataGridViewTextBoxColumn.ReadOnly = true;
            sugarsDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            sugarsDataGridViewTextBoxColumn.Width = 64;
            // 
            // dietaryFibreDataGridViewTextBoxColumn
            // 
            dietaryFibreDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dietaryFibreDataGridViewTextBoxColumn.DataPropertyName = "DietaryFibre";
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N1";
            dataGridViewCellStyle13.NullValue = "0";
            dietaryFibreDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            dietaryFibreDataGridViewTextBoxColumn.HeaderText = "Dietary Fibre (g)";
            dietaryFibreDataGridViewTextBoxColumn.MinimumWidth = 6;
            dietaryFibreDataGridViewTextBoxColumn.Name = "dietaryFibreDataGridViewTextBoxColumn";
            dietaryFibreDataGridViewTextBoxColumn.ReadOnly = true;
            dietaryFibreDataGridViewTextBoxColumn.Width = 93;
            // 
            // sodiumNaDataGridViewTextBoxColumn
            // 
            sodiumNaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sodiumNaDataGridViewTextBoxColumn.DataPropertyName = "SodiumNa";
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N0";
            dataGridViewCellStyle14.NullValue = "0";
            sodiumNaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            sodiumNaDataGridViewTextBoxColumn.HeaderText = "Sodium Na (mg)";
            sodiumNaDataGridViewTextBoxColumn.MinimumWidth = 6;
            sodiumNaDataGridViewTextBoxColumn.Name = "sodiumNaDataGridViewTextBoxColumn";
            sodiumNaDataGridViewTextBoxColumn.ReadOnly = true;
            sodiumNaDataGridViewTextBoxColumn.Width = 87;
            // 
            // calciumCaDataGridViewTextBoxColumn
            // 
            calciumCaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            calciumCaDataGridViewTextBoxColumn.DataPropertyName = "CalciumCa";
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N0";
            dataGridViewCellStyle15.NullValue = "0";
            calciumCaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            calciumCaDataGridViewTextBoxColumn.HeaderText = "Calcium Ca (mg)";
            calciumCaDataGridViewTextBoxColumn.MinimumWidth = 6;
            calciumCaDataGridViewTextBoxColumn.Name = "calciumCaDataGridViewTextBoxColumn";
            calciumCaDataGridViewTextBoxColumn.ReadOnly = true;
            calciumCaDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            calciumCaDataGridViewTextBoxColumn.Width = 69;
            // 
            // potassiumKDataGridViewTextBoxColumn
            // 
            potassiumKDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            potassiumKDataGridViewTextBoxColumn.DataPropertyName = "PotassiumK";
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N0";
            dataGridViewCellStyle16.NullValue = "0";
            potassiumKDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            potassiumKDataGridViewTextBoxColumn.HeaderText = "Potassium K (mg)";
            potassiumKDataGridViewTextBoxColumn.MinimumWidth = 6;
            potassiumKDataGridViewTextBoxColumn.Name = "potassiumKDataGridViewTextBoxColumn";
            potassiumKDataGridViewTextBoxColumn.ReadOnly = true;
            potassiumKDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            potassiumKDataGridViewTextBoxColumn.Width = 73;
            // 
            // thiaminB1DataGridViewTextBoxColumn
            // 
            thiaminB1DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            thiaminB1DataGridViewTextBoxColumn.DataPropertyName = "ThiaminB1";
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N3";
            dataGridViewCellStyle17.NullValue = "0";
            thiaminB1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            thiaminB1DataGridViewTextBoxColumn.HeaderText = "Thiamin B1 (mg)";
            thiaminB1DataGridViewTextBoxColumn.MinimumWidth = 6;
            thiaminB1DataGridViewTextBoxColumn.Name = "thiaminB1DataGridViewTextBoxColumn";
            thiaminB1DataGridViewTextBoxColumn.ReadOnly = true;
            thiaminB1DataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            thiaminB1DataGridViewTextBoxColumn.Width = 68;
            // 
            // riboflavinB2DataGridViewTextBoxColumn
            // 
            riboflavinB2DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            riboflavinB2DataGridViewTextBoxColumn.DataPropertyName = "RiboflavinB2";
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N3";
            dataGridViewCellStyle18.NullValue = "0";
            riboflavinB2DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            riboflavinB2DataGridViewTextBoxColumn.HeaderText = "Riboflavin B2 (mg)";
            riboflavinB2DataGridViewTextBoxColumn.MinimumWidth = 6;
            riboflavinB2DataGridViewTextBoxColumn.Name = "riboflavinB2DataGridViewTextBoxColumn";
            riboflavinB2DataGridViewTextBoxColumn.ReadOnly = true;
            riboflavinB2DataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            riboflavinB2DataGridViewTextBoxColumn.Width = 77;
            // 
            // niacinB3DataGridViewTextBoxColumn
            // 
            niacinB3DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            niacinB3DataGridViewTextBoxColumn.DataPropertyName = "NiacinB3";
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N2";
            dataGridViewCellStyle19.NullValue = "0";
            niacinB3DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle19;
            niacinB3DataGridViewTextBoxColumn.HeaderText = "Niacin B3 (mg)";
            niacinB3DataGridViewTextBoxColumn.MinimumWidth = 6;
            niacinB3DataGridViewTextBoxColumn.Name = "niacinB3DataGridViewTextBoxColumn";
            niacinB3DataGridViewTextBoxColumn.ReadOnly = true;
            niacinB3DataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            niacinB3DataGridViewTextBoxColumn.Width = 60;
            // 
            // folateDataGridViewTextBoxColumn
            // 
            folateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            folateDataGridViewTextBoxColumn.DataPropertyName = "Folate";
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "N0";
            dataGridViewCellStyle20.NullValue = "0";
            folateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle20;
            folateDataGridViewTextBoxColumn.HeaderText = "Folate (ug)";
            folateDataGridViewTextBoxColumn.MinimumWidth = 6;
            folateDataGridViewTextBoxColumn.Name = "folateDataGridViewTextBoxColumn";
            folateDataGridViewTextBoxColumn.ReadOnly = true;
            folateDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            folateDataGridViewTextBoxColumn.Width = 63;
            // 
            // ironFeDataGridViewTextBoxColumn
            // 
            ironFeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ironFeDataGridViewTextBoxColumn.DataPropertyName = "IronFe";
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "N2";
            dataGridViewCellStyle21.NullValue = "0";
            ironFeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle21;
            ironFeDataGridViewTextBoxColumn.HeaderText = "Iron Fe (mg)";
            ironFeDataGridViewTextBoxColumn.MinimumWidth = 6;
            ironFeDataGridViewTextBoxColumn.Name = "ironFeDataGridViewTextBoxColumn";
            ironFeDataGridViewTextBoxColumn.ReadOnly = true;
            ironFeDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            ironFeDataGridViewTextBoxColumn.Width = 70;
            // 
            // magnesiumMgDataGridViewTextBoxColumn
            // 
            magnesiumMgDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            magnesiumMgDataGridViewTextBoxColumn.DataPropertyName = "MagnesiumMg";
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "N0";
            dataGridViewCellStyle22.NullValue = "0";
            magnesiumMgDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle22;
            magnesiumMgDataGridViewTextBoxColumn.HeaderText = "Magnesium Mg (mg)";
            magnesiumMgDataGridViewTextBoxColumn.MinimumWidth = 6;
            magnesiumMgDataGridViewTextBoxColumn.Name = "magnesiumMgDataGridViewTextBoxColumn";
            magnesiumMgDataGridViewTextBoxColumn.ReadOnly = true;
            magnesiumMgDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            magnesiumMgDataGridViewTextBoxColumn.Width = 90;
            // 
            // vitaminCDataGridViewTextBoxColumn
            // 
            vitaminCDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            vitaminCDataGridViewTextBoxColumn.DataPropertyName = "VitaminC";
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Format = "N0";
            dataGridViewCellStyle23.NullValue = "0";
            vitaminCDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle23;
            vitaminCDataGridViewTextBoxColumn.HeaderText = "Vitamin C (mg)";
            vitaminCDataGridViewTextBoxColumn.MinimumWidth = 6;
            vitaminCDataGridViewTextBoxColumn.Name = "vitaminCDataGridViewTextBoxColumn";
            vitaminCDataGridViewTextBoxColumn.ReadOnly = true;
            vitaminCDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            vitaminCDataGridViewTextBoxColumn.Width = 61;
            // 
            // caffeineDataGridViewTextBoxColumn
            // 
            caffeineDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            caffeineDataGridViewTextBoxColumn.DataPropertyName = "Caffeine";
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.Format = "N0";
            dataGridViewCellStyle24.NullValue = "0";
            caffeineDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle24;
            caffeineDataGridViewTextBoxColumn.HeaderText = "Caffeine (mg)";
            caffeineDataGridViewTextBoxColumn.MinimumWidth = 6;
            caffeineDataGridViewTextBoxColumn.Name = "caffeineDataGridViewTextBoxColumn";
            caffeineDataGridViewTextBoxColumn.ReadOnly = true;
            caffeineDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            caffeineDataGridViewTextBoxColumn.Width = 78;
            // 
            // cholesterolDataGridViewTextBoxColumn
            // 
            cholesterolDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            cholesterolDataGridViewTextBoxColumn.DataPropertyName = "Cholesterol";
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle25.Format = "N0";
            dataGridViewCellStyle25.NullValue = "0";
            cholesterolDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle25;
            cholesterolDataGridViewTextBoxColumn.HeaderText = "Cholesterol (mg)";
            cholesterolDataGridViewTextBoxColumn.MinimumWidth = 6;
            cholesterolDataGridViewTextBoxColumn.Name = "cholesterolDataGridViewTextBoxColumn";
            cholesterolDataGridViewTextBoxColumn.ReadOnly = true;
            cholesterolDataGridViewTextBoxColumn.Width = 111;
            // 
            // alcoholDataGridViewTextBoxColumn
            // 
            alcoholDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            alcoholDataGridViewTextBoxColumn.DataPropertyName = "Alcohol";
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "N1";
            dataGridViewCellStyle26.NullValue = "0";
            alcoholDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle26;
            alcoholDataGridViewTextBoxColumn.HeaderText = "Alcohol (g)";
            alcoholDataGridViewTextBoxColumn.MinimumWidth = 6;
            alcoholDataGridViewTextBoxColumn.Name = "alcoholDataGridViewTextBoxColumn";
            alcoholDataGridViewTextBoxColumn.ReadOnly = true;
            alcoholDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            alcoholDataGridViewTextBoxColumn.Width = 65;
            // 
            // foodBindingSource
            // 
            foodBindingSource.DataSource = typeof(Food);
            // 
            // tabPageEaten
            // 
            tabPageEaten.Controls.Add(checkBoxMainCols);
            tabPageEaten.Controls.Add(checkBoxDailyTotals);
            tabPageEaten.Controls.Add(checkBoxDateFilter);
            tabPageEaten.Controls.Add(dataGridViewEaten);
            tabPageEaten.Location = new Point(4, 27);
            tabPageEaten.Name = "tabPageEaten";
            tabPageEaten.Padding = new Padding(3);
            tabPageEaten.Size = new Size(1339, 604);
            tabPageEaten.TabIndex = 1;
            tabPageEaten.Text = "Eaten";
            tabPageEaten.UseVisualStyleBackColor = true;
            // 
            // checkBoxMainCols
            // 
            checkBoxMainCols.AutoSize = true;
            checkBoxMainCols.Location = new Point(23, 18);
            checkBoxMainCols.Name = "checkBoxMainCols";
            checkBoxMainCols.Size = new Size(161, 19);
            checkBoxMainCols.TabIndex = 7;
            checkBoxMainCols.Text = "Only show main columns";
            checkBoxMainCols.UseVisualStyleBackColor = true;
            checkBoxMainCols.CheckedChanged += checkBoxMainCols_CheckedChanged;
            // 
            // checkBoxDailyTotals
            // 
            checkBoxDailyTotals.AutoSize = true;
            checkBoxDailyTotals.Location = new Point(23, 43);
            checkBoxDailyTotals.Name = "checkBoxDailyTotals";
            checkBoxDailyTotals.Size = new Size(124, 19);
            checkBoxDailyTotals.TabIndex = 6;
            checkBoxDailyTotals.Text = "Display daily totals";
            checkBoxDailyTotals.UseVisualStyleBackColor = true;
            checkBoxDailyTotals.CheckedChanged += checkBoxDailyTotals_CheckedChanged;
            // 
            // checkBoxDateFilter
            // 
            checkBoxDateFilter.AutoSize = true;
            checkBoxDateFilter.Location = new Point(23, 68);
            checkBoxDateFilter.Name = "checkBoxDateFilter";
            checkBoxDateFilter.Size = new Size(135, 19);
            checkBoxDateFilter.TabIndex = 5;
            checkBoxDateFilter.Text = "Filter by today's date";
            checkBoxDateFilter.UseVisualStyleBackColor = true;
            checkBoxDateFilter.CheckedChanged += checkBoxDateFilter_CheckedChanged;
            // 
            // dataGridViewEaten
            // 
            dataGridViewEaten.AllowUserToAddRows = false;
            dataGridViewEaten.AllowUserToResizeColumns = false;
            dataGridViewEaten.AllowUserToResizeRows = false;
            dataGridViewEaten.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewEaten.AutoGenerateColumns = false;
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = SystemColors.Control;
            dataGridViewCellStyle29.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle29.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = DataGridViewTriState.True;
            dataGridViewEaten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewEaten.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEaten.Columns.AddRange(new DataGridViewColumn[] { EatenId, DateEaten, TimeEaten, amountEatenDataGridViewTextBoxColumn, foodDescriptionDataGridViewTextBoxColumn1, energyDataGridViewTextBoxColumn1, proteinDataGridViewTextBoxColumn1, fatTotalDataGridViewTextBoxColumn1, saturatedFatDataGridViewTextBoxColumn1, transFatDataGridViewTextBoxColumn1, polyunsaturatedFatDataGridViewTextBoxColumn1, monounsaturatedFatDataGridViewTextBoxColumn1, carbohydrateDataGridViewTextBoxColumn1, sugarsDataGridViewTextBoxColumn1, dietaryFibreDataGridViewTextBoxColumn1, sodiumNaDataGridViewTextBoxColumn1, calciumCaDataGridViewTextBoxColumn1, potassiumKDataGridViewTextBoxColumn1, thiaminB1DataGridViewTextBoxColumn1, riboflavinB2DataGridViewTextBoxColumn1, niacinB3DataGridViewTextBoxColumn1, folateDataGridViewTextBoxColumn1, ironFeDataGridViewTextBoxColumn1, magnesiumMgDataGridViewTextBoxColumn1, vitaminCDataGridViewTextBoxColumn1, caffeineDataGridViewTextBoxColumn1, cholesterolDataGridViewTextBoxColumn1, alcoholDataGridViewTextBoxColumn1 });
            dataGridViewEaten.DataSource = eatenBindingSource;
            dataGridViewCellStyle58.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle58.BackColor = SystemColors.Window;
            dataGridViewCellStyle58.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle58.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle58.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle58.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle58.WrapMode = DataGridViewTriState.False;
            dataGridViewEaten.DefaultCellStyle = dataGridViewCellStyle58;
            dataGridViewEaten.Location = new Point(3, 99);
            dataGridViewEaten.MultiSelect = false;
            dataGridViewEaten.Name = "dataGridViewEaten";
            dataGridViewEaten.RowHeadersWidth = 49;
            dataGridViewEaten.RowTemplate.Height = 25;
            dataGridViewEaten.Size = new Size(1333, 502);
            dataGridViewEaten.TabIndex = 0;
            dataGridViewEaten.UserDeletingRow += dataGridViewEaten_UserDeletingRow;
            // 
            // EatenId
            // 
            EatenId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EatenId.DataPropertyName = "EatenId";
            dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle30.Format = "N0";
            dataGridViewCellStyle30.NullValue = "0";
            EatenId.DefaultCellStyle = dataGridViewCellStyle30;
            EatenId.HeaderText = "Id";
            EatenId.MinimumWidth = 8;
            EatenId.Name = "EatenId";
            EatenId.ReadOnly = true;
            EatenId.SortMode = DataGridViewColumnSortMode.NotSortable;
            EatenId.Width = 23;
            // 
            // DateEaten
            // 
            DateEaten.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DateEaten.DataPropertyName = "DateEaten";
            dataGridViewCellStyle31.Alignment = DataGridViewContentAlignment.MiddleRight;
            DateEaten.DefaultCellStyle = dataGridViewCellStyle31;
            DateEaten.HeaderText = "Date";
            DateEaten.MinimumWidth = 8;
            DateEaten.Name = "DateEaten";
            DateEaten.ReadOnly = true;
            DateEaten.SortMode = DataGridViewColumnSortMode.NotSortable;
            DateEaten.Width = 37;
            // 
            // TimeEaten
            // 
            TimeEaten.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TimeEaten.DataPropertyName = "TimeEaten";
            dataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleLeft;
            TimeEaten.DefaultCellStyle = dataGridViewCellStyle32;
            TimeEaten.HeaderText = "Time";
            TimeEaten.MinimumWidth = 8;
            TimeEaten.Name = "TimeEaten";
            TimeEaten.ReadOnly = true;
            TimeEaten.SortMode = DataGridViewColumnSortMode.NotSortable;
            TimeEaten.Width = 39;
            // 
            // amountEatenDataGridViewTextBoxColumn
            // 
            amountEatenDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            amountEatenDataGridViewTextBoxColumn.DataPropertyName = "AmountEaten";
            dataGridViewCellStyle33.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle33.Format = "N0";
            dataGridViewCellStyle33.NullValue = "0";
            amountEatenDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle33;
            amountEatenDataGridViewTextBoxColumn.HeaderText = "Amount (g or mL)";
            amountEatenDataGridViewTextBoxColumn.MinimumWidth = 6;
            amountEatenDataGridViewTextBoxColumn.Name = "amountEatenDataGridViewTextBoxColumn";
            amountEatenDataGridViewTextBoxColumn.ReadOnly = true;
            amountEatenDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            amountEatenDataGridViewTextBoxColumn.Width = 67;
            // 
            // foodDescriptionDataGridViewTextBoxColumn1
            // 
            foodDescriptionDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            foodDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "FoodDescription";
            dataGridViewCellStyle34.Alignment = DataGridViewContentAlignment.MiddleLeft;
            foodDescriptionDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle34;
            foodDescriptionDataGridViewTextBoxColumn1.HeaderText = "Food description";
            foodDescriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            foodDescriptionDataGridViewTextBoxColumn1.Name = "foodDescriptionDataGridViewTextBoxColumn1";
            foodDescriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            foodDescriptionDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            foodDescriptionDataGridViewTextBoxColumn1.Width = 92;
            // 
            // energyDataGridViewTextBoxColumn1
            // 
            energyDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            energyDataGridViewTextBoxColumn1.DataPropertyName = "Energy";
            dataGridViewCellStyle35.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle35.Format = "N0";
            dataGridViewCellStyle35.NullValue = "0";
            energyDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle35;
            energyDataGridViewTextBoxColumn1.HeaderText = "Energy (kJ)";
            energyDataGridViewTextBoxColumn1.MinimumWidth = 6;
            energyDataGridViewTextBoxColumn1.Name = "energyDataGridViewTextBoxColumn1";
            energyDataGridViewTextBoxColumn1.ReadOnly = true;
            energyDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            energyDataGridViewTextBoxColumn1.Width = 63;
            // 
            // proteinDataGridViewTextBoxColumn1
            // 
            proteinDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            proteinDataGridViewTextBoxColumn1.DataPropertyName = "Protein";
            dataGridViewCellStyle36.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle36.Format = "N1";
            dataGridViewCellStyle36.NullValue = "0";
            proteinDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle36;
            proteinDataGridViewTextBoxColumn1.HeaderText = "Protein (g)";
            proteinDataGridViewTextBoxColumn1.MinimumWidth = 6;
            proteinDataGridViewTextBoxColumn1.Name = "proteinDataGridViewTextBoxColumn1";
            proteinDataGridViewTextBoxColumn1.ReadOnly = true;
            proteinDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            proteinDataGridViewTextBoxColumn1.Width = 62;
            // 
            // fatTotalDataGridViewTextBoxColumn1
            // 
            fatTotalDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            fatTotalDataGridViewTextBoxColumn1.DataPropertyName = "FatTotal";
            dataGridViewCellStyle37.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle37.Format = "N1";
            dataGridViewCellStyle37.NullValue = "0";
            fatTotalDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle37;
            fatTotalDataGridViewTextBoxColumn1.HeaderText = "Fat Total (g)";
            fatTotalDataGridViewTextBoxColumn1.MinimumWidth = 6;
            fatTotalDataGridViewTextBoxColumn1.Name = "fatTotalDataGridViewTextBoxColumn1";
            fatTotalDataGridViewTextBoxColumn1.ReadOnly = true;
            fatTotalDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            fatTotalDataGridViewTextBoxColumn1.Width = 68;
            // 
            // saturatedFatDataGridViewTextBoxColumn1
            // 
            saturatedFatDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            saturatedFatDataGridViewTextBoxColumn1.DataPropertyName = "SaturatedFat";
            dataGridViewCellStyle38.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle38.Format = "N2";
            dataGridViewCellStyle38.NullValue = "0";
            saturatedFatDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle38;
            saturatedFatDataGridViewTextBoxColumn1.HeaderText = "-Saturated Fat (g)";
            saturatedFatDataGridViewTextBoxColumn1.MinimumWidth = 6;
            saturatedFatDataGridViewTextBoxColumn1.Name = "saturatedFatDataGridViewTextBoxColumn1";
            saturatedFatDataGridViewTextBoxColumn1.ReadOnly = true;
            saturatedFatDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            saturatedFatDataGridViewTextBoxColumn1.Width = 81;
            // 
            // transFatDataGridViewTextBoxColumn1
            // 
            transFatDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            transFatDataGridViewTextBoxColumn1.DataPropertyName = "TransFat";
            dataGridViewCellStyle39.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle39.Format = "N2";
            dataGridViewCellStyle39.NullValue = "0";
            transFatDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle39;
            transFatDataGridViewTextBoxColumn1.HeaderText = "-Trans Fat (mg)";
            transFatDataGridViewTextBoxColumn1.MinimumWidth = 6;
            transFatDataGridViewTextBoxColumn1.Name = "transFatDataGridViewTextBoxColumn1";
            transFatDataGridViewTextBoxColumn1.ReadOnly = true;
            transFatDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            transFatDataGridViewTextBoxColumn1.Width = 60;
            // 
            // polyunsaturatedFatDataGridViewTextBoxColumn1
            // 
            polyunsaturatedFatDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            polyunsaturatedFatDataGridViewTextBoxColumn1.DataPropertyName = "PolyunsaturatedFat";
            dataGridViewCellStyle40.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle40.Format = "N2";
            dataGridViewCellStyle40.NullValue = "0";
            polyunsaturatedFatDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle40;
            polyunsaturatedFatDataGridViewTextBoxColumn1.HeaderText = "-Polyunsaturated Fat (g)";
            polyunsaturatedFatDataGridViewTextBoxColumn1.MinimumWidth = 6;
            polyunsaturatedFatDataGridViewTextBoxColumn1.Name = "polyunsaturatedFatDataGridViewTextBoxColumn1";
            polyunsaturatedFatDataGridViewTextBoxColumn1.ReadOnly = true;
            polyunsaturatedFatDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            polyunsaturatedFatDataGridViewTextBoxColumn1.Width = 114;
            // 
            // monounsaturatedFatDataGridViewTextBoxColumn1
            // 
            monounsaturatedFatDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            monounsaturatedFatDataGridViewTextBoxColumn1.DataPropertyName = "MonounsaturatedFat";
            dataGridViewCellStyle41.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle41.Format = "N2";
            dataGridViewCellStyle41.NullValue = "0";
            monounsaturatedFatDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle41;
            monounsaturatedFatDataGridViewTextBoxColumn1.HeaderText = "-Monounsaturated Fat (g)";
            monounsaturatedFatDataGridViewTextBoxColumn1.MinimumWidth = 6;
            monounsaturatedFatDataGridViewTextBoxColumn1.Name = "monounsaturatedFatDataGridViewTextBoxColumn1";
            monounsaturatedFatDataGridViewTextBoxColumn1.ReadOnly = true;
            monounsaturatedFatDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            monounsaturatedFatDataGridViewTextBoxColumn1.Width = 122;
            // 
            // carbohydrateDataGridViewTextBoxColumn1
            // 
            carbohydrateDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            carbohydrateDataGridViewTextBoxColumn1.DataPropertyName = "Carbohydrate";
            dataGridViewCellStyle42.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle42.Format = "N1";
            dataGridViewCellStyle42.NullValue = "0";
            carbohydrateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle42;
            carbohydrateDataGridViewTextBoxColumn1.HeaderText = "Carbohydrate (g)";
            carbohydrateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            carbohydrateDataGridViewTextBoxColumn1.Name = "carbohydrateDataGridViewTextBoxColumn1";
            carbohydrateDataGridViewTextBoxColumn1.ReadOnly = true;
            carbohydrateDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            carbohydrateDataGridViewTextBoxColumn1.Width = 93;
            // 
            // sugarsDataGridViewTextBoxColumn1
            // 
            sugarsDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sugarsDataGridViewTextBoxColumn1.DataPropertyName = "Sugars";
            dataGridViewCellStyle43.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle43.Format = "N1";
            dataGridViewCellStyle43.NullValue = "0";
            sugarsDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle43;
            sugarsDataGridViewTextBoxColumn1.HeaderText = "-Sugars (g)";
            sugarsDataGridViewTextBoxColumn1.MinimumWidth = 6;
            sugarsDataGridViewTextBoxColumn1.Name = "sugarsDataGridViewTextBoxColumn1";
            sugarsDataGridViewTextBoxColumn1.ReadOnly = true;
            sugarsDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            sugarsDataGridViewTextBoxColumn1.Width = 64;
            // 
            // dietaryFibreDataGridViewTextBoxColumn1
            // 
            dietaryFibreDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dietaryFibreDataGridViewTextBoxColumn1.DataPropertyName = "DietaryFibre";
            dataGridViewCellStyle44.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle44.Format = "N1";
            dataGridViewCellStyle44.NullValue = "0";
            dietaryFibreDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle44;
            dietaryFibreDataGridViewTextBoxColumn1.HeaderText = "Dietary Fibre (g)";
            dietaryFibreDataGridViewTextBoxColumn1.MinimumWidth = 6;
            dietaryFibreDataGridViewTextBoxColumn1.Name = "dietaryFibreDataGridViewTextBoxColumn1";
            dietaryFibreDataGridViewTextBoxColumn1.ReadOnly = true;
            dietaryFibreDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dietaryFibreDataGridViewTextBoxColumn1.Width = 74;
            // 
            // sodiumNaDataGridViewTextBoxColumn1
            // 
            sodiumNaDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sodiumNaDataGridViewTextBoxColumn1.DataPropertyName = "SodiumNa";
            dataGridViewCellStyle45.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle45.Format = "N0";
            dataGridViewCellStyle45.NullValue = "0";
            sodiumNaDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle45;
            sodiumNaDataGridViewTextBoxColumn1.HeaderText = "Sodium Na (mg)";
            sodiumNaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            sodiumNaDataGridViewTextBoxColumn1.Name = "sodiumNaDataGridViewTextBoxColumn1";
            sodiumNaDataGridViewTextBoxColumn1.ReadOnly = true;
            sodiumNaDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            sodiumNaDataGridViewTextBoxColumn1.Width = 68;
            // 
            // calciumCaDataGridViewTextBoxColumn1
            // 
            calciumCaDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            calciumCaDataGridViewTextBoxColumn1.DataPropertyName = "CalciumCa";
            dataGridViewCellStyle46.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle46.Format = "N0";
            dataGridViewCellStyle46.NullValue = "0";
            calciumCaDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle46;
            calciumCaDataGridViewTextBoxColumn1.HeaderText = "Calcium Ca (mg)";
            calciumCaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            calciumCaDataGridViewTextBoxColumn1.Name = "calciumCaDataGridViewTextBoxColumn1";
            calciumCaDataGridViewTextBoxColumn1.ReadOnly = true;
            calciumCaDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            calciumCaDataGridViewTextBoxColumn1.Width = 69;
            // 
            // potassiumKDataGridViewTextBoxColumn1
            // 
            potassiumKDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            potassiumKDataGridViewTextBoxColumn1.DataPropertyName = "PotassiumK";
            dataGridViewCellStyle47.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle47.Format = "N0";
            dataGridViewCellStyle47.NullValue = "0";
            potassiumKDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle47;
            potassiumKDataGridViewTextBoxColumn1.HeaderText = "Potassium K (mg)";
            potassiumKDataGridViewTextBoxColumn1.MinimumWidth = 6;
            potassiumKDataGridViewTextBoxColumn1.Name = "potassiumKDataGridViewTextBoxColumn1";
            potassiumKDataGridViewTextBoxColumn1.ReadOnly = true;
            potassiumKDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            potassiumKDataGridViewTextBoxColumn1.Width = 73;
            // 
            // thiaminB1DataGridViewTextBoxColumn1
            // 
            thiaminB1DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            thiaminB1DataGridViewTextBoxColumn1.DataPropertyName = "ThiaminB1";
            dataGridViewCellStyle48.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle48.Format = "N3";
            dataGridViewCellStyle48.NullValue = "0";
            thiaminB1DataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle48;
            thiaminB1DataGridViewTextBoxColumn1.HeaderText = "Thiamin B1 (mg)";
            thiaminB1DataGridViewTextBoxColumn1.MinimumWidth = 6;
            thiaminB1DataGridViewTextBoxColumn1.Name = "thiaminB1DataGridViewTextBoxColumn1";
            thiaminB1DataGridViewTextBoxColumn1.ReadOnly = true;
            thiaminB1DataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            thiaminB1DataGridViewTextBoxColumn1.Width = 68;
            // 
            // riboflavinB2DataGridViewTextBoxColumn1
            // 
            riboflavinB2DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            riboflavinB2DataGridViewTextBoxColumn1.DataPropertyName = "RiboflavinB2";
            dataGridViewCellStyle49.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle49.Format = "N3";
            dataGridViewCellStyle49.NullValue = "0";
            riboflavinB2DataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle49;
            riboflavinB2DataGridViewTextBoxColumn1.HeaderText = "Riboflavin B2 (mg)";
            riboflavinB2DataGridViewTextBoxColumn1.MinimumWidth = 6;
            riboflavinB2DataGridViewTextBoxColumn1.Name = "riboflavinB2DataGridViewTextBoxColumn1";
            riboflavinB2DataGridViewTextBoxColumn1.ReadOnly = true;
            riboflavinB2DataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            riboflavinB2DataGridViewTextBoxColumn1.Width = 77;
            // 
            // niacinB3DataGridViewTextBoxColumn1
            // 
            niacinB3DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            niacinB3DataGridViewTextBoxColumn1.DataPropertyName = "NiacinB3";
            dataGridViewCellStyle50.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle50.Format = "N2";
            dataGridViewCellStyle50.NullValue = "0";
            niacinB3DataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle50;
            niacinB3DataGridViewTextBoxColumn1.HeaderText = "Niacin B3 (mg)";
            niacinB3DataGridViewTextBoxColumn1.MinimumWidth = 6;
            niacinB3DataGridViewTextBoxColumn1.Name = "niacinB3DataGridViewTextBoxColumn1";
            niacinB3DataGridViewTextBoxColumn1.ReadOnly = true;
            niacinB3DataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            niacinB3DataGridViewTextBoxColumn1.Width = 60;
            // 
            // folateDataGridViewTextBoxColumn1
            // 
            folateDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            folateDataGridViewTextBoxColumn1.DataPropertyName = "Folate";
            dataGridViewCellStyle51.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle51.Format = "N0";
            dataGridViewCellStyle51.NullValue = "0";
            folateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle51;
            folateDataGridViewTextBoxColumn1.HeaderText = "Folate (ug)";
            folateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            folateDataGridViewTextBoxColumn1.Name = "folateDataGridViewTextBoxColumn1";
            folateDataGridViewTextBoxColumn1.ReadOnly = true;
            folateDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            folateDataGridViewTextBoxColumn1.Width = 63;
            // 
            // ironFeDataGridViewTextBoxColumn1
            // 
            ironFeDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ironFeDataGridViewTextBoxColumn1.DataPropertyName = "IronFe";
            dataGridViewCellStyle52.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle52.Format = "N2";
            dataGridViewCellStyle52.NullValue = "0";
            ironFeDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle52;
            ironFeDataGridViewTextBoxColumn1.HeaderText = "Iron Fe (mg)";
            ironFeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            ironFeDataGridViewTextBoxColumn1.Name = "ironFeDataGridViewTextBoxColumn1";
            ironFeDataGridViewTextBoxColumn1.ReadOnly = true;
            ironFeDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            ironFeDataGridViewTextBoxColumn1.Width = 70;
            // 
            // magnesiumMgDataGridViewTextBoxColumn1
            // 
            magnesiumMgDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            magnesiumMgDataGridViewTextBoxColumn1.DataPropertyName = "MagnesiumMg";
            dataGridViewCellStyle53.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle53.Format = "N0";
            dataGridViewCellStyle53.NullValue = "0";
            magnesiumMgDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle53;
            magnesiumMgDataGridViewTextBoxColumn1.HeaderText = "Magnesium Mg (mg)";
            magnesiumMgDataGridViewTextBoxColumn1.MinimumWidth = 6;
            magnesiumMgDataGridViewTextBoxColumn1.Name = "magnesiumMgDataGridViewTextBoxColumn1";
            magnesiumMgDataGridViewTextBoxColumn1.ReadOnly = true;
            magnesiumMgDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            magnesiumMgDataGridViewTextBoxColumn1.Width = 90;
            // 
            // vitaminCDataGridViewTextBoxColumn1
            // 
            vitaminCDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            vitaminCDataGridViewTextBoxColumn1.DataPropertyName = "VitaminC";
            dataGridViewCellStyle54.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle54.Format = "N0";
            dataGridViewCellStyle54.NullValue = "0";
            vitaminCDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle54;
            vitaminCDataGridViewTextBoxColumn1.HeaderText = "Vitamin C (mg)";
            vitaminCDataGridViewTextBoxColumn1.MinimumWidth = 6;
            vitaminCDataGridViewTextBoxColumn1.Name = "vitaminCDataGridViewTextBoxColumn1";
            vitaminCDataGridViewTextBoxColumn1.ReadOnly = true;
            vitaminCDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            vitaminCDataGridViewTextBoxColumn1.Width = 61;
            // 
            // caffeineDataGridViewTextBoxColumn1
            // 
            caffeineDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            caffeineDataGridViewTextBoxColumn1.DataPropertyName = "Caffeine";
            dataGridViewCellStyle55.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle55.Format = "N0";
            dataGridViewCellStyle55.NullValue = "0";
            caffeineDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle55;
            caffeineDataGridViewTextBoxColumn1.HeaderText = "Caffeine (mg)";
            caffeineDataGridViewTextBoxColumn1.MinimumWidth = 6;
            caffeineDataGridViewTextBoxColumn1.Name = "caffeineDataGridViewTextBoxColumn1";
            caffeineDataGridViewTextBoxColumn1.ReadOnly = true;
            caffeineDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            caffeineDataGridViewTextBoxColumn1.Width = 78;
            // 
            // cholesterolDataGridViewTextBoxColumn1
            // 
            cholesterolDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            cholesterolDataGridViewTextBoxColumn1.DataPropertyName = "Cholesterol";
            dataGridViewCellStyle56.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle56.Format = "N0";
            dataGridViewCellStyle56.NullValue = "0";
            cholesterolDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle56;
            cholesterolDataGridViewTextBoxColumn1.HeaderText = "Cholesterol (mg)";
            cholesterolDataGridViewTextBoxColumn1.MinimumWidth = 6;
            cholesterolDataGridViewTextBoxColumn1.Name = "cholesterolDataGridViewTextBoxColumn1";
            cholesterolDataGridViewTextBoxColumn1.ReadOnly = true;
            cholesterolDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            cholesterolDataGridViewTextBoxColumn1.Width = 92;
            // 
            // alcoholDataGridViewTextBoxColumn1
            // 
            alcoholDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            alcoholDataGridViewTextBoxColumn1.DataPropertyName = "Alcohol";
            dataGridViewCellStyle57.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle57.Format = "N1";
            dataGridViewCellStyle57.NullValue = "0";
            alcoholDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle57;
            alcoholDataGridViewTextBoxColumn1.HeaderText = "Alcohol (g)";
            alcoholDataGridViewTextBoxColumn1.MinimumWidth = 6;
            alcoholDataGridViewTextBoxColumn1.Name = "alcoholDataGridViewTextBoxColumn1";
            alcoholDataGridViewTextBoxColumn1.ReadOnly = true;
            alcoholDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            alcoholDataGridViewTextBoxColumn1.Width = 65;
            // 
            // eatenBindingSource
            // 
            eatenBindingSource.DataSource = typeof(Eaten);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 637);
            Controls.Add(tabControlMain);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Diet Sentry";
            tabControl1.ResumeLayout(false);
            tabControlMain.ResumeLayout(false);
            tabPageFood.ResumeLayout(false);
            tabPageFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFoods).EndInit();
            ((System.ComponentModel.ISupportInitialize)foodBindingSource).EndInit();
            tabPageEaten.ResumeLayout(false);
            tabPageEaten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEaten).EndInit();
            ((System.ComponentModel.ISupportInitialize)eatenBindingSource).EndInit();
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
        private TextBox textBoxFilter;
        private Label labelFilter;
        private DataGridView dataGridViewEaten;
        private BindingSource eatenBindingSource;
        private DataGridViewTextBoxColumn FoodIdDataGridViewTextBoxColumn;
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
        private DataGridViewTextBoxColumn EatenId;
        private DataGridViewTextBoxColumn DateEaten;
        private DataGridViewTextBoxColumn TimeEaten;
        private DataGridViewTextBoxColumn amountEatenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn foodDescriptionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn energyDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn proteinDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fatTotalDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn saturatedFatDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn transFatDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn polyunsaturatedFatDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn monounsaturatedFatDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn carbohydrateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn sugarsDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dietaryFibreDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn sodiumNaDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn calciumCaDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn potassiumKDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn thiaminB1DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn riboflavinB2DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn niacinB3DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn folateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ironFeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn magnesiumMgDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn vitaminCDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn caffeineDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cholesterolDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn alcoholDataGridViewTextBoxColumn1;
        private CheckBox checkBoxDateFilter;
        private CheckBox checkBoxDailyTotals;
        private CheckBox checkBoxMainCols;
        private CheckBox checkBoxMainFoodCols;
        private Label labelTest;
    }
}