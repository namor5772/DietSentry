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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabControlMain = new TabControl();
            tabPageFood = new TabPage();
            textBoxFilter = new TextBox();
            buttonSetFilter = new Button();
            buttonClearFilter = new Button();
            buttonSave = new Button();
            dataGridViewFoods = new DataGridView();
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
            foodBindingSource = new BindingSource(components);
            tabPageEaten = new TabPage();
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
            tabControlMain.Multiline = true;
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1106, 813);
            tabControlMain.TabIndex = 1;
            // 
            // tabPageFood
            // 
            tabPageFood.Controls.Add(textBoxFilter);
            tabPageFood.Controls.Add(buttonSetFilter);
            tabPageFood.Controls.Add(buttonClearFilter);
            tabPageFood.Controls.Add(buttonSave);
            tabPageFood.Controls.Add(dataGridViewFoods);
            tabPageFood.Location = new Point(4, 24);
            tabPageFood.Name = "tabPageFood";
            tabPageFood.Padding = new Padding(3);
            tabPageFood.Size = new Size(1098, 785);
            tabPageFood.TabIndex = 0;
            tabPageFood.Text = "Food";
            tabPageFood.UseVisualStyleBackColor = true;
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new Point(170, 6);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(135, 23);
            textBoxFilter.TabIndex = 4;
            textBoxFilter.Enter += textBoxFilter_Enter;
            textBoxFilter.KeyDown += textBoxFilter_KeyDown;
            // 
            // buttonSetFilter
            // 
            buttonSetFilter.Location = new Point(89, 6);
            buttonSetFilter.Name = "buttonSetFilter";
            buttonSetFilter.Size = new Size(75, 23);
            buttonSetFilter.TabIndex = 3;
            buttonSetFilter.Text = "Set filter";
            buttonSetFilter.UseVisualStyleBackColor = true;
            buttonSetFilter.Click += buttonSetFilter_Click;
            // 
            // buttonClearFilter
            // 
            buttonClearFilter.Location = new Point(8, 6);
            buttonClearFilter.Name = "buttonClearFilter";
            buttonClearFilter.Size = new Size(75, 23);
            buttonClearFilter.TabIndex = 2;
            buttonClearFilter.Text = "Clear filter";
            buttonClearFilter.UseVisualStyleBackColor = true;
            buttonClearFilter.Click += buttonClearFilter_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(8, 581);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // dataGridViewFoods
            // 
            dataGridViewFoods.AllowUserToResizeColumns = false;
            dataGridViewFoods.AllowUserToResizeRows = false;
            dataGridViewFoods.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridViewFoods.Columns.AddRange(new DataGridViewColumn[] { foodIdDataGridViewTextBoxColumn, foodDescriptionDataGridViewTextBoxColumn, energyDataGridViewTextBoxColumn, proteinDataGridViewTextBoxColumn, fatTotalDataGridViewTextBoxColumn, saturatedFatDataGridViewTextBoxColumn, transFatDataGridViewTextBoxColumn, polyunsaturatedFatDataGridViewTextBoxColumn, monounsaturatedFatDataGridViewTextBoxColumn, carbohydrateDataGridViewTextBoxColumn, sugarsDataGridViewTextBoxColumn, dietaryFibreDataGridViewTextBoxColumn, sodiumNaDataGridViewTextBoxColumn, calciumCaDataGridViewTextBoxColumn, potassiumKDataGridViewTextBoxColumn, thiaminB1DataGridViewTextBoxColumn, riboflavinB2DataGridViewTextBoxColumn, niacinB3DataGridViewTextBoxColumn, folateDataGridViewTextBoxColumn, ironFeDataGridViewTextBoxColumn, magnesiumMgDataGridViewTextBoxColumn, vitaminCDataGridViewTextBoxColumn, caffeineDataGridViewTextBoxColumn, cholesterolDataGridViewTextBoxColumn, alcoholDataGridViewTextBoxColumn });
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
            dataGridViewFoods.Location = new Point(0, 35);
            dataGridViewFoods.Name = "dataGridViewFoods";
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle28.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = Color.White;
            dataGridViewCellStyle28.WrapMode = DataGridViewTriState.True;
            dataGridViewFoods.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            dataGridViewFoods.RowTemplate.Height = 25;
            dataGridViewFoods.Size = new Size(1098, 540);
            dataGridViewFoods.TabIndex = 0;
            // 
            // foodIdDataGridViewTextBoxColumn
            // 
            foodIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            foodIdDataGridViewTextBoxColumn.DataPropertyName = "FoodId";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            foodIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            foodIdDataGridViewTextBoxColumn.HeaderText = "Id";
            foodIdDataGridViewTextBoxColumn.Name = "foodIdDataGridViewTextBoxColumn";
            foodIdDataGridViewTextBoxColumn.ReadOnly = true;
            foodIdDataGridViewTextBoxColumn.Width = 42;
            // 
            // foodDescriptionDataGridViewTextBoxColumn
            // 
            foodDescriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            foodDescriptionDataGridViewTextBoxColumn.DataPropertyName = "FoodDescription";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            foodDescriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            foodDescriptionDataGridViewTextBoxColumn.HeaderText = "Food description";
            foodDescriptionDataGridViewTextBoxColumn.Name = "foodDescriptionDataGridViewTextBoxColumn";
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
            energyDataGridViewTextBoxColumn.Name = "energyDataGridViewTextBoxColumn";
            energyDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            energyDataGridViewTextBoxColumn.Width = 63;
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
            proteinDataGridViewTextBoxColumn.Name = "proteinDataGridViewTextBoxColumn";
            proteinDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            proteinDataGridViewTextBoxColumn.Width = 62;
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
            fatTotalDataGridViewTextBoxColumn.Name = "fatTotalDataGridViewTextBoxColumn";
            fatTotalDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            fatTotalDataGridViewTextBoxColumn.Width = 68;
            // 
            // saturatedFatDataGridViewTextBoxColumn
            // 
            saturatedFatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            saturatedFatDataGridViewTextBoxColumn.DataPropertyName = "SaturatedFat";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N1";
            dataGridViewCellStyle7.NullValue = "0";
            saturatedFatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            saturatedFatDataGridViewTextBoxColumn.HeaderText = "-Saturated Fat (g)";
            saturatedFatDataGridViewTextBoxColumn.Name = "saturatedFatDataGridViewTextBoxColumn";
            saturatedFatDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            saturatedFatDataGridViewTextBoxColumn.Width = 81;
            // 
            // transFatDataGridViewTextBoxColumn
            // 
            transFatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            transFatDataGridViewTextBoxColumn.DataPropertyName = "TransFat";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N1";
            dataGridViewCellStyle8.NullValue = "0";
            transFatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            transFatDataGridViewTextBoxColumn.HeaderText = "-Trans Fat (g)";
            transFatDataGridViewTextBoxColumn.Name = "transFatDataGridViewTextBoxColumn";
            transFatDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            transFatDataGridViewTextBoxColumn.Width = 60;
            // 
            // polyunsaturatedFatDataGridViewTextBoxColumn
            // 
            polyunsaturatedFatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            polyunsaturatedFatDataGridViewTextBoxColumn.DataPropertyName = "PolyunsaturatedFat";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N1";
            dataGridViewCellStyle9.NullValue = "0";
            polyunsaturatedFatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            polyunsaturatedFatDataGridViewTextBoxColumn.HeaderText = "-Polyunsaturated Fat (g)";
            polyunsaturatedFatDataGridViewTextBoxColumn.Name = "polyunsaturatedFatDataGridViewTextBoxColumn";
            polyunsaturatedFatDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            polyunsaturatedFatDataGridViewTextBoxColumn.Width = 114;
            // 
            // monounsaturatedFatDataGridViewTextBoxColumn
            // 
            monounsaturatedFatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            monounsaturatedFatDataGridViewTextBoxColumn.DataPropertyName = "MonounsaturatedFat";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N1";
            dataGridViewCellStyle10.NullValue = "0";
            monounsaturatedFatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            monounsaturatedFatDataGridViewTextBoxColumn.HeaderText = "-Monounsaturated Fat (g)";
            monounsaturatedFatDataGridViewTextBoxColumn.Name = "monounsaturatedFatDataGridViewTextBoxColumn";
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
            carbohydrateDataGridViewTextBoxColumn.Name = "carbohydrateDataGridViewTextBoxColumn";
            carbohydrateDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            carbohydrateDataGridViewTextBoxColumn.Width = 93;
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
            sugarsDataGridViewTextBoxColumn.Name = "sugarsDataGridViewTextBoxColumn";
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
            dietaryFibreDataGridViewTextBoxColumn.Name = "dietaryFibreDataGridViewTextBoxColumn";
            dietaryFibreDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            dietaryFibreDataGridViewTextBoxColumn.Width = 74;
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
            sodiumNaDataGridViewTextBoxColumn.Name = "sodiumNaDataGridViewTextBoxColumn";
            sodiumNaDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            sodiumNaDataGridViewTextBoxColumn.Width = 68;
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
            calciumCaDataGridViewTextBoxColumn.Name = "calciumCaDataGridViewTextBoxColumn";
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
            potassiumKDataGridViewTextBoxColumn.Name = "potassiumKDataGridViewTextBoxColumn";
            potassiumKDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            potassiumKDataGridViewTextBoxColumn.Width = 73;
            // 
            // thiaminB1DataGridViewTextBoxColumn
            // 
            thiaminB1DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            thiaminB1DataGridViewTextBoxColumn.DataPropertyName = "ThiaminB1";
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N1";
            dataGridViewCellStyle17.NullValue = "0";
            thiaminB1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            thiaminB1DataGridViewTextBoxColumn.HeaderText = "Thiamin B1 (mg)";
            thiaminB1DataGridViewTextBoxColumn.Name = "thiaminB1DataGridViewTextBoxColumn";
            thiaminB1DataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            thiaminB1DataGridViewTextBoxColumn.Width = 68;
            // 
            // riboflavinB2DataGridViewTextBoxColumn
            // 
            riboflavinB2DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            riboflavinB2DataGridViewTextBoxColumn.DataPropertyName = "RiboflavinB2";
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N1";
            dataGridViewCellStyle18.NullValue = "0";
            riboflavinB2DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            riboflavinB2DataGridViewTextBoxColumn.HeaderText = "Riboflavin B2 (mg)";
            riboflavinB2DataGridViewTextBoxColumn.Name = "riboflavinB2DataGridViewTextBoxColumn";
            riboflavinB2DataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            riboflavinB2DataGridViewTextBoxColumn.Width = 77;
            // 
            // niacinB3DataGridViewTextBoxColumn
            // 
            niacinB3DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            niacinB3DataGridViewTextBoxColumn.DataPropertyName = "NiacinB3";
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N1";
            dataGridViewCellStyle19.NullValue = "0";
            niacinB3DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle19;
            niacinB3DataGridViewTextBoxColumn.HeaderText = "Niacin B3 (mg)";
            niacinB3DataGridViewTextBoxColumn.Name = "niacinB3DataGridViewTextBoxColumn";
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
            folateDataGridViewTextBoxColumn.Name = "folateDataGridViewTextBoxColumn";
            folateDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            folateDataGridViewTextBoxColumn.Width = 63;
            // 
            // ironFeDataGridViewTextBoxColumn
            // 
            ironFeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ironFeDataGridViewTextBoxColumn.DataPropertyName = "IronFe";
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "N1";
            dataGridViewCellStyle21.NullValue = "0";
            ironFeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle21;
            ironFeDataGridViewTextBoxColumn.HeaderText = "Iron Fe (mg)";
            ironFeDataGridViewTextBoxColumn.Name = "ironFeDataGridViewTextBoxColumn";
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
            magnesiumMgDataGridViewTextBoxColumn.Name = "magnesiumMgDataGridViewTextBoxColumn";
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
            vitaminCDataGridViewTextBoxColumn.Name = "vitaminCDataGridViewTextBoxColumn";
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
            caffeineDataGridViewTextBoxColumn.Name = "caffeineDataGridViewTextBoxColumn";
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
            cholesterolDataGridViewTextBoxColumn.Name = "cholesterolDataGridViewTextBoxColumn";
            cholesterolDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            cholesterolDataGridViewTextBoxColumn.Width = 92;
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
            alcoholDataGridViewTextBoxColumn.Name = "alcoholDataGridViewTextBoxColumn";
            alcoholDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            alcoholDataGridViewTextBoxColumn.Width = 65;
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
            tabPageEaten.Size = new Size(1098, 785);
            tabPageEaten.TabIndex = 1;
            tabPageEaten.Text = "Eaten";
            tabPageEaten.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 813);
            Controls.Add(tabControlMain);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Diet Sentry";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabControlMain.ResumeLayout(false);
            tabPageFood.ResumeLayout(false);
            tabPageFood.PerformLayout();
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
        private Button buttonSetFilter;
        private Button buttonClearFilter;
        private TextBox textBoxFilter;
    }
}