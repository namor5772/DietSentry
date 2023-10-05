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

        // MY "GLOBAL" VARIABLES ********* bad coding lol **********

        // counter for timer ticks
        private int iTick = 0;

        // variable which is set to true so that something specific can be done when MainForm is reactivated after InputForm is closed
        public Boolean actOnInputFormClose = false;

        // Variables in MainForm which store data collected from the InputForm
        public float amountOfFoodEaten = 0.0F; // in "units" of 100 g or mL
        public DateTime dateTimeEaten; // the time when a food was recorded as eaten

        // A string describing the eaten food selected
        public string eatenFoodDescription = "BLANK";

        // Declaring some Food item class instances
        public Food addedFoodItem = new Food();
        public Food editedFoodItem = new Food();

        /* variable which is set to true when new food item detailed in the foodinputForm is actually to be added to the database
         * after foodinputForm is closed, ignored otherwise. ie this "transmits" code behaviour of pressing the [Add] or [Cancel] buttons when
         * foodinput Form is closed */
        public Boolean actOnFoodAdded;

        // 0=Solid-Public, 1=Liquid-Public, 2=Recipe, 3=Solid-Private, 4=Liquid-Private
        public int foodType;

        // 0=Add, 1=Edit. Specifies behaviour in foodinput form depending on whether adding or editing a food item.
        public int inputType;

        // Id of edited recipe's record 
        public int recordID = 0;

        // a full food description of a selected recipe food
        public string fullFoodDescription = "BLANK";

        // *********************************************************



        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle59 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle85 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle86 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle60 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle61 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle62 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle63 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle64 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle65 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle66 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle67 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle68 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle69 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle70 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle71 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle72 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle73 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle74 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle75 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle76 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle77 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle78 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle79 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle80 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle81 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle82 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle83 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle84 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle87 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle115 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle116 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle88 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle89 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle90 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle91 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle92 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle93 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle94 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle95 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle96 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle97 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle98 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle99 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle100 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle101 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle102 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle103 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle104 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle105 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle106 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle107 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle108 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle109 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle110 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle111 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle112 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle113 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle114 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabControlMain = new TabControl();
            tabPageFood = new TabPage();
            labelInfo = new Label();
            checkBoxMainFoodCols = new CheckBox();
            labelFilter = new Label();
            textBoxFilter = new TextBox();
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
            EatenTs = new DataGridViewTextBoxColumn();
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
            tabPageHelp = new TabPage();
            recipeBindingSource = new BindingSource(components);
            helpProviderMainForm = new HelpProvider();
            toolTipMainForm = new ToolTip(components);
            aTimer = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabPageFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFoods).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foodBindingSource).BeginInit();
            tabPageEaten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEaten).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eatenBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).BeginInit();
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
            tabControlMain.Controls.Add(tabPageFood);
            tabControlMain.Controls.Add(tabPageEaten);
            tabControlMain.Controls.Add(tabPageHelp);
            tabControlMain.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Multiline = true;
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1418, 785);
            tabControlMain.TabIndex = 1;
            // 
            // tabPageFood
            // 
            tabPageFood.Controls.Add(labelInfo);
            tabPageFood.Controls.Add(checkBoxMainFoodCols);
            tabPageFood.Controls.Add(labelFilter);
            tabPageFood.Controls.Add(textBoxFilter);
            tabPageFood.Controls.Add(dataGridViewFoods);
            tabPageFood.Location = new Point(4, 24);
            tabPageFood.Name = "tabPageFood";
            tabPageFood.Padding = new Padding(3);
            tabPageFood.Size = new Size(1410, 757);
            tabPageFood.TabIndex = 0;
            tabPageFood.Text = "Food";
            toolTipMainForm.SetToolTip(tabPageFood, "Food Tab help");
            tabPageFood.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(288, 19);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(0, 15);
            labelInfo.TabIndex = 9;
            // 
            // checkBoxMainFoodCols
            // 
            checkBoxMainFoodCols.AutoSize = true;
            checkBoxMainFoodCols.Checked = true;
            checkBoxMainFoodCols.CheckState = CheckState.Checked;
            checkBoxMainFoodCols.Location = new Point(23, 18);
            checkBoxMainFoodCols.Name = "checkBoxMainFoodCols";
            checkBoxMainFoodCols.Size = new Size(161, 19);
            checkBoxMainFoodCols.TabIndex = 8;
            checkBoxMainFoodCols.Text = "Only show main columns";
            toolTipMainForm.SetToolTip(checkBoxMainFoodCols, resources.GetString("checkBoxMainFoodCols.ToolTip"));
            checkBoxMainFoodCols.UseVisualStyleBackColor = true;
            checkBoxMainFoodCols.CheckedChanged += CheckBoxMainFoodCols_CheckedChanged;
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
            toolTipMainForm.SetToolTip(labelFilter, "Displays the last filter applied to the Food table as\r\ndisplayed in the below DataGrid.\r\n\r\nIf data is unfiltered, the text \"Unfiltered\" will be displayed.");
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
            toolTipMainForm.SetToolTip(textBoxFilter, resources.GetString("textBoxFilter.ToolTip"));
            textBoxFilter.WordWrap = false;
            textBoxFilter.Enter += TextBoxFilter_Enter;
            textBoxFilter.KeyDown += TextBoxFilter_KeyDown;
            // 
            // dataGridViewFoods
            // 
            dataGridViewFoods.AllowUserToAddRows = false;
            dataGridViewFoods.AllowUserToResizeColumns = false;
            dataGridViewFoods.AllowUserToResizeRows = false;
            dataGridViewFoods.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewFoods.AutoGenerateColumns = false;
            dataGridViewFoods.BorderStyle = BorderStyle.None;
            dataGridViewFoods.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle59.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = Color.Azure;
            dataGridViewCellStyle59.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle59.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle59.SelectionBackColor = Color.Azure;
            dataGridViewCellStyle59.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle59.WrapMode = DataGridViewTriState.True;
            dataGridViewFoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle59;
            dataGridViewFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFoods.Columns.AddRange(new DataGridViewColumn[] { FoodIdDataGridViewTextBoxColumn, foodDescriptionDataGridViewTextBoxColumn, energyDataGridViewTextBoxColumn, proteinDataGridViewTextBoxColumn, fatTotalDataGridViewTextBoxColumn, saturatedFatDataGridViewTextBoxColumn, transFatDataGridViewTextBoxColumn, polyunsaturatedFatDataGridViewTextBoxColumn, monounsaturatedFatDataGridViewTextBoxColumn, carbohydrateDataGridViewTextBoxColumn, sugarsDataGridViewTextBoxColumn, dietaryFibreDataGridViewTextBoxColumn, sodiumNaDataGridViewTextBoxColumn, calciumCaDataGridViewTextBoxColumn, potassiumKDataGridViewTextBoxColumn, thiaminB1DataGridViewTextBoxColumn, riboflavinB2DataGridViewTextBoxColumn, niacinB3DataGridViewTextBoxColumn, folateDataGridViewTextBoxColumn, ironFeDataGridViewTextBoxColumn, magnesiumMgDataGridViewTextBoxColumn, vitaminCDataGridViewTextBoxColumn, caffeineDataGridViewTextBoxColumn, cholesterolDataGridViewTextBoxColumn, alcoholDataGridViewTextBoxColumn });
            dataGridViewFoods.DataSource = foodBindingSource;
            dataGridViewCellStyle85.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle85.BackColor = SystemColors.Info;
            dataGridViewCellStyle85.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle85.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle85.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle85.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle85.WrapMode = DataGridViewTriState.False;
            dataGridViewFoods.DefaultCellStyle = dataGridViewCellStyle85;
            dataGridViewFoods.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridViewFoods.EnableHeadersVisualStyles = false;
            dataGridViewFoods.Location = new Point(6, 99);
            dataGridViewFoods.MultiSelect = false;
            dataGridViewFoods.Name = "dataGridViewFoods";
            dataGridViewFoods.ReadOnly = true;
            dataGridViewFoods.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle86.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle86.BackColor = SystemColors.Control;
            dataGridViewCellStyle86.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle86.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle86.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle86.SelectionForeColor = Color.White;
            dataGridViewCellStyle86.WrapMode = DataGridViewTriState.True;
            dataGridViewFoods.RowHeadersDefaultCellStyle = dataGridViewCellStyle86;
            dataGridViewFoods.RowHeadersVisible = false;
            dataGridViewFoods.RowHeadersWidth = 40;
            dataGridViewFoods.RowTemplate.Height = 25;
            dataGridViewFoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFoods.Size = new Size(1398, 652);
            dataGridViewFoods.TabIndex = 4;
            toolTipMainForm.SetToolTip(dataGridViewFoods, "Hello world jkhjkhjkhjkhkjhjkjh\r\nhjgjhghjgjhghjghjh\r\njhgjhgjhgjhgjhgjhgjhjhgj");
            dataGridViewFoods.CellDoubleClick += DataGridViewFoods_CellDoubleClick;
            dataGridViewFoods.UserDeletingRow += DataGridViewFoods_UserDeletingRow;
            dataGridViewFoods.KeyDown += DataGridViewFoods_KeyDown;
            // 
            // FoodIdDataGridViewTextBoxColumn
            // 
            FoodIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            FoodIdDataGridViewTextBoxColumn.DataPropertyName = "FoodId";
            dataGridViewCellStyle60.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle60.Format = "N0";
            dataGridViewCellStyle60.NullValue = "0";
            FoodIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle60;
            FoodIdDataGridViewTextBoxColumn.HeaderText = "Id";
            FoodIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            FoodIdDataGridViewTextBoxColumn.Name = "FoodIdDataGridViewTextBoxColumn";
            FoodIdDataGridViewTextBoxColumn.ReadOnly = true;
            FoodIdDataGridViewTextBoxColumn.ToolTipText = "TEST";
            FoodIdDataGridViewTextBoxColumn.Width = 41;
            // 
            // foodDescriptionDataGridViewTextBoxColumn
            // 
            foodDescriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            foodDescriptionDataGridViewTextBoxColumn.DataPropertyName = "FoodDescription";
            dataGridViewCellStyle61.Alignment = DataGridViewContentAlignment.MiddleLeft;
            foodDescriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle61;
            foodDescriptionDataGridViewTextBoxColumn.HeaderText = "Food description";
            foodDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            foodDescriptionDataGridViewTextBoxColumn.Name = "foodDescriptionDataGridViewTextBoxColumn";
            foodDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            foodDescriptionDataGridViewTextBoxColumn.Width = 110;
            // 
            // energyDataGridViewTextBoxColumn
            // 
            energyDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            energyDataGridViewTextBoxColumn.DataPropertyName = "Energy";
            dataGridViewCellStyle62.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle62.Format = "N0";
            dataGridViewCellStyle62.NullValue = "0";
            energyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle62;
            energyDataGridViewTextBoxColumn.HeaderText = "Energy (kJ)";
            energyDataGridViewTextBoxColumn.MinimumWidth = 8;
            energyDataGridViewTextBoxColumn.Name = "energyDataGridViewTextBoxColumn";
            energyDataGridViewTextBoxColumn.ReadOnly = true;
            energyDataGridViewTextBoxColumn.Width = 81;
            // 
            // proteinDataGridViewTextBoxColumn
            // 
            proteinDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            proteinDataGridViewTextBoxColumn.DataPropertyName = "Protein";
            dataGridViewCellStyle63.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle63.Format = "N1";
            dataGridViewCellStyle63.NullValue = "0";
            proteinDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle63;
            proteinDataGridViewTextBoxColumn.HeaderText = "Protein (g)";
            proteinDataGridViewTextBoxColumn.MinimumWidth = 6;
            proteinDataGridViewTextBoxColumn.Name = "proteinDataGridViewTextBoxColumn";
            proteinDataGridViewTextBoxColumn.ReadOnly = true;
            proteinDataGridViewTextBoxColumn.Width = 80;
            // 
            // fatTotalDataGridViewTextBoxColumn
            // 
            fatTotalDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            fatTotalDataGridViewTextBoxColumn.DataPropertyName = "FatTotal";
            dataGridViewCellStyle64.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle64.Format = "N1";
            dataGridViewCellStyle64.NullValue = "0";
            fatTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle64;
            fatTotalDataGridViewTextBoxColumn.HeaderText = "Fat Total (g)";
            fatTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            fatTotalDataGridViewTextBoxColumn.Name = "fatTotalDataGridViewTextBoxColumn";
            fatTotalDataGridViewTextBoxColumn.ReadOnly = true;
            fatTotalDataGridViewTextBoxColumn.Width = 86;
            // 
            // saturatedFatDataGridViewTextBoxColumn
            // 
            saturatedFatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            saturatedFatDataGridViewTextBoxColumn.DataPropertyName = "SaturatedFat";
            dataGridViewCellStyle65.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle65.Format = "N1";
            dataGridViewCellStyle65.NullValue = "0";
            dataGridViewCellStyle65.WrapMode = DataGridViewTriState.True;
            saturatedFatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle65;
            saturatedFatDataGridViewTextBoxColumn.HeaderText = "-Saturated Fat (g)";
            saturatedFatDataGridViewTextBoxColumn.MinimumWidth = 6;
            saturatedFatDataGridViewTextBoxColumn.Name = "saturatedFatDataGridViewTextBoxColumn";
            saturatedFatDataGridViewTextBoxColumn.ReadOnly = true;
            saturatedFatDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            saturatedFatDataGridViewTextBoxColumn.Width = 80;
            // 
            // transFatDataGridViewTextBoxColumn
            // 
            transFatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            transFatDataGridViewTextBoxColumn.DataPropertyName = "TransFat";
            dataGridViewCellStyle66.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle66.Format = "N1";
            dataGridViewCellStyle66.NullValue = "0";
            transFatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle66;
            transFatDataGridViewTextBoxColumn.HeaderText = "-Trans Fat (mg)";
            transFatDataGridViewTextBoxColumn.MinimumWidth = 6;
            transFatDataGridViewTextBoxColumn.Name = "transFatDataGridViewTextBoxColumn";
            transFatDataGridViewTextBoxColumn.ReadOnly = true;
            transFatDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            transFatDataGridViewTextBoxColumn.Width = 59;
            // 
            // polyunsaturatedFatDataGridViewTextBoxColumn
            // 
            polyunsaturatedFatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            polyunsaturatedFatDataGridViewTextBoxColumn.DataPropertyName = "PolyunsaturatedFat";
            dataGridViewCellStyle67.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle67.Format = "N1";
            dataGridViewCellStyle67.NullValue = "0";
            polyunsaturatedFatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle67;
            polyunsaturatedFatDataGridViewTextBoxColumn.HeaderText = "-Polyunsaturated Fat (g)";
            polyunsaturatedFatDataGridViewTextBoxColumn.MinimumWidth = 6;
            polyunsaturatedFatDataGridViewTextBoxColumn.Name = "polyunsaturatedFatDataGridViewTextBoxColumn";
            polyunsaturatedFatDataGridViewTextBoxColumn.ReadOnly = true;
            polyunsaturatedFatDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            polyunsaturatedFatDataGridViewTextBoxColumn.Width = 113;
            // 
            // monounsaturatedFatDataGridViewTextBoxColumn
            // 
            monounsaturatedFatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            monounsaturatedFatDataGridViewTextBoxColumn.DataPropertyName = "MonounsaturatedFat";
            dataGridViewCellStyle68.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle68.Format = "N1";
            dataGridViewCellStyle68.NullValue = "0";
            monounsaturatedFatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle68;
            monounsaturatedFatDataGridViewTextBoxColumn.HeaderText = "-Monounsaturated Fat (g)";
            monounsaturatedFatDataGridViewTextBoxColumn.MinimumWidth = 6;
            monounsaturatedFatDataGridViewTextBoxColumn.Name = "monounsaturatedFatDataGridViewTextBoxColumn";
            monounsaturatedFatDataGridViewTextBoxColumn.ReadOnly = true;
            monounsaturatedFatDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            monounsaturatedFatDataGridViewTextBoxColumn.Width = 121;
            // 
            // carbohydrateDataGridViewTextBoxColumn
            // 
            carbohydrateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            carbohydrateDataGridViewTextBoxColumn.DataPropertyName = "Carbohydrate";
            dataGridViewCellStyle69.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle69.Format = "N1";
            dataGridViewCellStyle69.NullValue = "0";
            carbohydrateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle69;
            carbohydrateDataGridViewTextBoxColumn.HeaderText = "Carbohydrate (g)";
            carbohydrateDataGridViewTextBoxColumn.MinimumWidth = 6;
            carbohydrateDataGridViewTextBoxColumn.Name = "carbohydrateDataGridViewTextBoxColumn";
            carbohydrateDataGridViewTextBoxColumn.ReadOnly = true;
            carbohydrateDataGridViewTextBoxColumn.Width = 111;
            // 
            // sugarsDataGridViewTextBoxColumn
            // 
            sugarsDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sugarsDataGridViewTextBoxColumn.DataPropertyName = "Sugars";
            dataGridViewCellStyle70.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle70.Format = "N1";
            dataGridViewCellStyle70.NullValue = "0";
            sugarsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle70;
            sugarsDataGridViewTextBoxColumn.HeaderText = "-Sugars (g)";
            sugarsDataGridViewTextBoxColumn.MinimumWidth = 6;
            sugarsDataGridViewTextBoxColumn.Name = "sugarsDataGridViewTextBoxColumn";
            sugarsDataGridViewTextBoxColumn.ReadOnly = true;
            sugarsDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            sugarsDataGridViewTextBoxColumn.Width = 63;
            // 
            // dietaryFibreDataGridViewTextBoxColumn
            // 
            dietaryFibreDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dietaryFibreDataGridViewTextBoxColumn.DataPropertyName = "DietaryFibre";
            dataGridViewCellStyle71.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle71.Format = "N1";
            dataGridViewCellStyle71.NullValue = "0";
            dietaryFibreDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle71;
            dietaryFibreDataGridViewTextBoxColumn.HeaderText = "Dietary Fibre (g)";
            dietaryFibreDataGridViewTextBoxColumn.MinimumWidth = 6;
            dietaryFibreDataGridViewTextBoxColumn.Name = "dietaryFibreDataGridViewTextBoxColumn";
            dietaryFibreDataGridViewTextBoxColumn.ReadOnly = true;
            dietaryFibreDataGridViewTextBoxColumn.Width = 92;
            // 
            // sodiumNaDataGridViewTextBoxColumn
            // 
            sodiumNaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sodiumNaDataGridViewTextBoxColumn.DataPropertyName = "SodiumNa";
            dataGridViewCellStyle72.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle72.Format = "N0";
            dataGridViewCellStyle72.NullValue = "0";
            sodiumNaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle72;
            sodiumNaDataGridViewTextBoxColumn.HeaderText = "Sodium Na (mg)";
            sodiumNaDataGridViewTextBoxColumn.MinimumWidth = 6;
            sodiumNaDataGridViewTextBoxColumn.Name = "sodiumNaDataGridViewTextBoxColumn";
            sodiumNaDataGridViewTextBoxColumn.ReadOnly = true;
            sodiumNaDataGridViewTextBoxColumn.Width = 86;
            // 
            // calciumCaDataGridViewTextBoxColumn
            // 
            calciumCaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            calciumCaDataGridViewTextBoxColumn.DataPropertyName = "CalciumCa";
            dataGridViewCellStyle73.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle73.Format = "N0";
            dataGridViewCellStyle73.NullValue = "0";
            calciumCaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle73;
            calciumCaDataGridViewTextBoxColumn.HeaderText = "Calcium Ca (mg)";
            calciumCaDataGridViewTextBoxColumn.MinimumWidth = 6;
            calciumCaDataGridViewTextBoxColumn.Name = "calciumCaDataGridViewTextBoxColumn";
            calciumCaDataGridViewTextBoxColumn.ReadOnly = true;
            calciumCaDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            calciumCaDataGridViewTextBoxColumn.Width = 68;
            // 
            // potassiumKDataGridViewTextBoxColumn
            // 
            potassiumKDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            potassiumKDataGridViewTextBoxColumn.DataPropertyName = "PotassiumK";
            dataGridViewCellStyle74.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle74.Format = "N0";
            dataGridViewCellStyle74.NullValue = "0";
            potassiumKDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle74;
            potassiumKDataGridViewTextBoxColumn.HeaderText = "Potassium K (mg)";
            potassiumKDataGridViewTextBoxColumn.MinimumWidth = 6;
            potassiumKDataGridViewTextBoxColumn.Name = "potassiumKDataGridViewTextBoxColumn";
            potassiumKDataGridViewTextBoxColumn.ReadOnly = true;
            potassiumKDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            potassiumKDataGridViewTextBoxColumn.Width = 72;
            // 
            // thiaminB1DataGridViewTextBoxColumn
            // 
            thiaminB1DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            thiaminB1DataGridViewTextBoxColumn.DataPropertyName = "ThiaminB1";
            dataGridViewCellStyle75.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle75.Format = "N1";
            dataGridViewCellStyle75.NullValue = "0";
            thiaminB1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle75;
            thiaminB1DataGridViewTextBoxColumn.HeaderText = "Thiamin B1 (mg)";
            thiaminB1DataGridViewTextBoxColumn.MinimumWidth = 6;
            thiaminB1DataGridViewTextBoxColumn.Name = "thiaminB1DataGridViewTextBoxColumn";
            thiaminB1DataGridViewTextBoxColumn.ReadOnly = true;
            thiaminB1DataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            thiaminB1DataGridViewTextBoxColumn.Width = 67;
            // 
            // riboflavinB2DataGridViewTextBoxColumn
            // 
            riboflavinB2DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            riboflavinB2DataGridViewTextBoxColumn.DataPropertyName = "RiboflavinB2";
            dataGridViewCellStyle76.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle76.Format = "N1";
            dataGridViewCellStyle76.NullValue = "0";
            riboflavinB2DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle76;
            riboflavinB2DataGridViewTextBoxColumn.HeaderText = "Riboflavin B2 (mg)";
            riboflavinB2DataGridViewTextBoxColumn.MinimumWidth = 6;
            riboflavinB2DataGridViewTextBoxColumn.Name = "riboflavinB2DataGridViewTextBoxColumn";
            riboflavinB2DataGridViewTextBoxColumn.ReadOnly = true;
            riboflavinB2DataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            riboflavinB2DataGridViewTextBoxColumn.Width = 76;
            // 
            // niacinB3DataGridViewTextBoxColumn
            // 
            niacinB3DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            niacinB3DataGridViewTextBoxColumn.DataPropertyName = "NiacinB3";
            dataGridViewCellStyle77.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle77.Format = "N1";
            dataGridViewCellStyle77.NullValue = "0";
            niacinB3DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle77;
            niacinB3DataGridViewTextBoxColumn.HeaderText = "Niacin B3 (mg)";
            niacinB3DataGridViewTextBoxColumn.MinimumWidth = 6;
            niacinB3DataGridViewTextBoxColumn.Name = "niacinB3DataGridViewTextBoxColumn";
            niacinB3DataGridViewTextBoxColumn.ReadOnly = true;
            niacinB3DataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            niacinB3DataGridViewTextBoxColumn.Width = 59;
            // 
            // folateDataGridViewTextBoxColumn
            // 
            folateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            folateDataGridViewTextBoxColumn.DataPropertyName = "Folate";
            dataGridViewCellStyle78.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle78.Format = "N0";
            dataGridViewCellStyle78.NullValue = "0";
            folateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle78;
            folateDataGridViewTextBoxColumn.HeaderText = "Folate (ug)";
            folateDataGridViewTextBoxColumn.MinimumWidth = 6;
            folateDataGridViewTextBoxColumn.Name = "folateDataGridViewTextBoxColumn";
            folateDataGridViewTextBoxColumn.ReadOnly = true;
            folateDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            folateDataGridViewTextBoxColumn.Width = 62;
            // 
            // ironFeDataGridViewTextBoxColumn
            // 
            ironFeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ironFeDataGridViewTextBoxColumn.DataPropertyName = "IronFe";
            dataGridViewCellStyle79.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle79.Format = "N1";
            dataGridViewCellStyle79.NullValue = "0";
            ironFeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle79;
            ironFeDataGridViewTextBoxColumn.HeaderText = "Iron Fe (mg)";
            ironFeDataGridViewTextBoxColumn.MinimumWidth = 6;
            ironFeDataGridViewTextBoxColumn.Name = "ironFeDataGridViewTextBoxColumn";
            ironFeDataGridViewTextBoxColumn.ReadOnly = true;
            ironFeDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            ironFeDataGridViewTextBoxColumn.Width = 69;
            // 
            // magnesiumMgDataGridViewTextBoxColumn
            // 
            magnesiumMgDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            magnesiumMgDataGridViewTextBoxColumn.DataPropertyName = "MagnesiumMg";
            dataGridViewCellStyle80.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle80.Format = "N0";
            dataGridViewCellStyle80.NullValue = "0";
            magnesiumMgDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle80;
            magnesiumMgDataGridViewTextBoxColumn.HeaderText = "Magnesium Mg (mg)";
            magnesiumMgDataGridViewTextBoxColumn.MinimumWidth = 6;
            magnesiumMgDataGridViewTextBoxColumn.Name = "magnesiumMgDataGridViewTextBoxColumn";
            magnesiumMgDataGridViewTextBoxColumn.ReadOnly = true;
            magnesiumMgDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            magnesiumMgDataGridViewTextBoxColumn.Width = 89;
            // 
            // vitaminCDataGridViewTextBoxColumn
            // 
            vitaminCDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            vitaminCDataGridViewTextBoxColumn.DataPropertyName = "VitaminC";
            dataGridViewCellStyle81.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle81.Format = "N0";
            dataGridViewCellStyle81.NullValue = "0";
            vitaminCDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle81;
            vitaminCDataGridViewTextBoxColumn.HeaderText = "Vitamin C (mg)";
            vitaminCDataGridViewTextBoxColumn.MinimumWidth = 6;
            vitaminCDataGridViewTextBoxColumn.Name = "vitaminCDataGridViewTextBoxColumn";
            vitaminCDataGridViewTextBoxColumn.ReadOnly = true;
            vitaminCDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            vitaminCDataGridViewTextBoxColumn.Width = 60;
            // 
            // caffeineDataGridViewTextBoxColumn
            // 
            caffeineDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            caffeineDataGridViewTextBoxColumn.DataPropertyName = "Caffeine";
            dataGridViewCellStyle82.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle82.Format = "N0";
            dataGridViewCellStyle82.NullValue = "0";
            caffeineDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle82;
            caffeineDataGridViewTextBoxColumn.HeaderText = "Caffeine (mg)";
            caffeineDataGridViewTextBoxColumn.MinimumWidth = 6;
            caffeineDataGridViewTextBoxColumn.Name = "caffeineDataGridViewTextBoxColumn";
            caffeineDataGridViewTextBoxColumn.ReadOnly = true;
            caffeineDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            caffeineDataGridViewTextBoxColumn.Width = 77;
            // 
            // cholesterolDataGridViewTextBoxColumn
            // 
            cholesterolDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            cholesterolDataGridViewTextBoxColumn.DataPropertyName = "Cholesterol";
            dataGridViewCellStyle83.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle83.Format = "N0";
            dataGridViewCellStyle83.NullValue = "0";
            cholesterolDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle83;
            cholesterolDataGridViewTextBoxColumn.HeaderText = "Cholesterol (mg)";
            cholesterolDataGridViewTextBoxColumn.MinimumWidth = 6;
            cholesterolDataGridViewTextBoxColumn.Name = "cholesterolDataGridViewTextBoxColumn";
            cholesterolDataGridViewTextBoxColumn.ReadOnly = true;
            cholesterolDataGridViewTextBoxColumn.Width = 110;
            // 
            // alcoholDataGridViewTextBoxColumn
            // 
            alcoholDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            alcoholDataGridViewTextBoxColumn.DataPropertyName = "Alcohol";
            dataGridViewCellStyle84.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle84.Format = "N1";
            dataGridViewCellStyle84.NullValue = "0";
            alcoholDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle84;
            alcoholDataGridViewTextBoxColumn.HeaderText = "Alcohol (g)";
            alcoholDataGridViewTextBoxColumn.MinimumWidth = 6;
            alcoholDataGridViewTextBoxColumn.Name = "alcoholDataGridViewTextBoxColumn";
            alcoholDataGridViewTextBoxColumn.ReadOnly = true;
            alcoholDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            alcoholDataGridViewTextBoxColumn.Width = 64;
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
            tabPageEaten.Location = new Point(4, 24);
            tabPageEaten.Name = "tabPageEaten";
            tabPageEaten.Padding = new Padding(3);
            tabPageEaten.Size = new Size(1410, 757);
            tabPageEaten.TabIndex = 1;
            tabPageEaten.Text = "Eaten";
            toolTipMainForm.SetToolTip(tabPageEaten, "Eaten Tab Help");
            tabPageEaten.UseVisualStyleBackColor = true;
            // 
            // checkBoxMainCols
            // 
            checkBoxMainCols.AutoSize = true;
            checkBoxMainCols.Checked = true;
            checkBoxMainCols.CheckState = CheckState.Checked;
            checkBoxMainCols.Location = new Point(23, 18);
            checkBoxMainCols.Name = "checkBoxMainCols";
            checkBoxMainCols.Size = new Size(161, 19);
            checkBoxMainCols.TabIndex = 7;
            checkBoxMainCols.Text = "Only show main columns";
            checkBoxMainCols.UseVisualStyleBackColor = true;
            checkBoxMainCols.CheckedChanged += CheckBoxMainCols_CheckedChanged;
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
            checkBoxDailyTotals.CheckedChanged += CheckBoxDailyTotals_CheckedChanged;
            // 
            // checkBoxDateFilter
            // 
            checkBoxDateFilter.AutoSize = true;
            checkBoxDateFilter.Checked = true;
            checkBoxDateFilter.CheckState = CheckState.Checked;
            checkBoxDateFilter.Location = new Point(23, 68);
            checkBoxDateFilter.Name = "checkBoxDateFilter";
            checkBoxDateFilter.Size = new Size(135, 19);
            checkBoxDateFilter.TabIndex = 5;
            checkBoxDateFilter.Text = "Filter by today's date";
            checkBoxDateFilter.UseVisualStyleBackColor = true;
            checkBoxDateFilter.CheckedChanged += CheckBoxDateFilter_CheckedChanged;
            // 
            // dataGridViewEaten
            // 
            dataGridViewEaten.AllowUserToAddRows = false;
            dataGridViewEaten.AllowUserToResizeColumns = false;
            dataGridViewEaten.AllowUserToResizeRows = false;
            dataGridViewEaten.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewEaten.AutoGenerateColumns = false;
            dataGridViewEaten.BorderStyle = BorderStyle.None;
            dataGridViewEaten.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle87.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle87.BackColor = Color.Azure;
            dataGridViewCellStyle87.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle87.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle87.SelectionBackColor = Color.Azure;
            dataGridViewCellStyle87.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle87.WrapMode = DataGridViewTriState.True;
            dataGridViewEaten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle87;
            dataGridViewEaten.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEaten.Columns.AddRange(new DataGridViewColumn[] { EatenId, DateEaten, TimeEaten, EatenTs, amountEatenDataGridViewTextBoxColumn, foodDescriptionDataGridViewTextBoxColumn1, energyDataGridViewTextBoxColumn1, proteinDataGridViewTextBoxColumn1, fatTotalDataGridViewTextBoxColumn1, saturatedFatDataGridViewTextBoxColumn1, transFatDataGridViewTextBoxColumn1, polyunsaturatedFatDataGridViewTextBoxColumn1, monounsaturatedFatDataGridViewTextBoxColumn1, carbohydrateDataGridViewTextBoxColumn1, sugarsDataGridViewTextBoxColumn1, dietaryFibreDataGridViewTextBoxColumn1, sodiumNaDataGridViewTextBoxColumn1, calciumCaDataGridViewTextBoxColumn1, potassiumKDataGridViewTextBoxColumn1, thiaminB1DataGridViewTextBoxColumn1, riboflavinB2DataGridViewTextBoxColumn1, niacinB3DataGridViewTextBoxColumn1, folateDataGridViewTextBoxColumn1, ironFeDataGridViewTextBoxColumn1, magnesiumMgDataGridViewTextBoxColumn1, vitaminCDataGridViewTextBoxColumn1, caffeineDataGridViewTextBoxColumn1, cholesterolDataGridViewTextBoxColumn1, alcoholDataGridViewTextBoxColumn1 });
            dataGridViewEaten.DataSource = eatenBindingSource;
            dataGridViewCellStyle115.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle115.BackColor = SystemColors.Window;
            dataGridViewCellStyle115.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle115.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle115.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle115.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle115.WrapMode = DataGridViewTriState.False;
            dataGridViewEaten.DefaultCellStyle = dataGridViewCellStyle115;
            dataGridViewEaten.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridViewEaten.EnableHeadersVisualStyles = false;
            dataGridViewEaten.Location = new Point(6, 99);
            dataGridViewEaten.MultiSelect = false;
            dataGridViewEaten.Name = "dataGridViewEaten";
            dataGridViewEaten.ReadOnly = true;
            dataGridViewEaten.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle116.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle116.BackColor = SystemColors.Control;
            dataGridViewCellStyle116.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle116.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle116.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle116.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle116.WrapMode = DataGridViewTriState.True;
            dataGridViewEaten.RowHeadersDefaultCellStyle = dataGridViewCellStyle116;
            dataGridViewEaten.RowHeadersVisible = false;
            dataGridViewEaten.RowHeadersWidth = 40;
            dataGridViewEaten.RowTemplate.Height = 25;
            dataGridViewEaten.RowTemplate.ReadOnly = true;
            dataGridViewEaten.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEaten.Size = new Size(1398, 652);
            dataGridViewEaten.TabIndex = 0;
            dataGridViewEaten.UserDeletingRow += DataGridViewEaten_UserDeletingRow;
            // 
            // EatenId
            // 
            EatenId.DataPropertyName = "EatenId";
            EatenId.HeaderText = "Id";
            EatenId.Name = "EatenId";
            EatenId.ReadOnly = true;
            EatenId.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // DateEaten
            // 
            DateEaten.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DateEaten.DataPropertyName = "DateEaten";
            dataGridViewCellStyle88.Alignment = DataGridViewContentAlignment.MiddleRight;
            DateEaten.DefaultCellStyle = dataGridViewCellStyle88;
            DateEaten.HeaderText = "Date";
            DateEaten.MinimumWidth = 8;
            DateEaten.Name = "DateEaten";
            DateEaten.ReadOnly = true;
            DateEaten.SortMode = DataGridViewColumnSortMode.NotSortable;
            DateEaten.Width = 36;
            // 
            // TimeEaten
            // 
            TimeEaten.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TimeEaten.DataPropertyName = "TimeEaten";
            dataGridViewCellStyle89.Alignment = DataGridViewContentAlignment.MiddleLeft;
            TimeEaten.DefaultCellStyle = dataGridViewCellStyle89;
            TimeEaten.HeaderText = "Time";
            TimeEaten.MinimumWidth = 8;
            TimeEaten.Name = "TimeEaten";
            TimeEaten.ReadOnly = true;
            TimeEaten.SortMode = DataGridViewColumnSortMode.NotSortable;
            TimeEaten.Width = 38;
            // 
            // EatenTs
            // 
            EatenTs.DataPropertyName = "EatenTs";
            EatenTs.HeaderText = "EatenTs";
            EatenTs.Name = "EatenTs";
            EatenTs.ReadOnly = true;
            // 
            // amountEatenDataGridViewTextBoxColumn
            // 
            amountEatenDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            amountEatenDataGridViewTextBoxColumn.DataPropertyName = "AmountEaten";
            dataGridViewCellStyle90.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle90.Format = "N0";
            dataGridViewCellStyle90.NullValue = "0";
            amountEatenDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle90;
            amountEatenDataGridViewTextBoxColumn.HeaderText = "Amount (g or mL)";
            amountEatenDataGridViewTextBoxColumn.MinimumWidth = 6;
            amountEatenDataGridViewTextBoxColumn.Name = "amountEatenDataGridViewTextBoxColumn";
            amountEatenDataGridViewTextBoxColumn.ReadOnly = true;
            amountEatenDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            amountEatenDataGridViewTextBoxColumn.Width = 66;
            // 
            // foodDescriptionDataGridViewTextBoxColumn1
            // 
            foodDescriptionDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            foodDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "FoodDescription";
            dataGridViewCellStyle91.Alignment = DataGridViewContentAlignment.MiddleLeft;
            foodDescriptionDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle91;
            foodDescriptionDataGridViewTextBoxColumn1.HeaderText = "Food description";
            foodDescriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            foodDescriptionDataGridViewTextBoxColumn1.Name = "foodDescriptionDataGridViewTextBoxColumn1";
            foodDescriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            foodDescriptionDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            foodDescriptionDataGridViewTextBoxColumn1.Width = 91;
            // 
            // energyDataGridViewTextBoxColumn1
            // 
            energyDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            energyDataGridViewTextBoxColumn1.DataPropertyName = "Energy";
            dataGridViewCellStyle92.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle92.Format = "N0";
            dataGridViewCellStyle92.NullValue = "0";
            dataGridViewCellStyle92.WrapMode = DataGridViewTriState.True;
            energyDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle92;
            energyDataGridViewTextBoxColumn1.HeaderText = "Energy (kJ)";
            energyDataGridViewTextBoxColumn1.MinimumWidth = 6;
            energyDataGridViewTextBoxColumn1.Name = "energyDataGridViewTextBoxColumn1";
            energyDataGridViewTextBoxColumn1.ReadOnly = true;
            energyDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            energyDataGridViewTextBoxColumn1.Width = 62;
            // 
            // proteinDataGridViewTextBoxColumn1
            // 
            proteinDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            proteinDataGridViewTextBoxColumn1.DataPropertyName = "Protein";
            dataGridViewCellStyle93.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle93.Format = "N1";
            dataGridViewCellStyle93.NullValue = "0";
            proteinDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle93;
            proteinDataGridViewTextBoxColumn1.HeaderText = "Protein (g)";
            proteinDataGridViewTextBoxColumn1.MinimumWidth = 6;
            proteinDataGridViewTextBoxColumn1.Name = "proteinDataGridViewTextBoxColumn1";
            proteinDataGridViewTextBoxColumn1.ReadOnly = true;
            proteinDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            proteinDataGridViewTextBoxColumn1.Width = 61;
            // 
            // fatTotalDataGridViewTextBoxColumn1
            // 
            fatTotalDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            fatTotalDataGridViewTextBoxColumn1.DataPropertyName = "FatTotal";
            dataGridViewCellStyle94.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle94.Format = "N1";
            dataGridViewCellStyle94.NullValue = "0";
            fatTotalDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle94;
            fatTotalDataGridViewTextBoxColumn1.HeaderText = "Fat Total (g)";
            fatTotalDataGridViewTextBoxColumn1.MinimumWidth = 6;
            fatTotalDataGridViewTextBoxColumn1.Name = "fatTotalDataGridViewTextBoxColumn1";
            fatTotalDataGridViewTextBoxColumn1.ReadOnly = true;
            fatTotalDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            fatTotalDataGridViewTextBoxColumn1.Width = 67;
            // 
            // saturatedFatDataGridViewTextBoxColumn1
            // 
            saturatedFatDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            saturatedFatDataGridViewTextBoxColumn1.DataPropertyName = "SaturatedFat";
            dataGridViewCellStyle95.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle95.Format = "N1";
            dataGridViewCellStyle95.NullValue = "0";
            dataGridViewCellStyle95.WrapMode = DataGridViewTriState.True;
            saturatedFatDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle95;
            saturatedFatDataGridViewTextBoxColumn1.HeaderText = "-Saturated Fat (g)";
            saturatedFatDataGridViewTextBoxColumn1.MinimumWidth = 6;
            saturatedFatDataGridViewTextBoxColumn1.Name = "saturatedFatDataGridViewTextBoxColumn1";
            saturatedFatDataGridViewTextBoxColumn1.ReadOnly = true;
            saturatedFatDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            saturatedFatDataGridViewTextBoxColumn1.Width = 80;
            // 
            // transFatDataGridViewTextBoxColumn1
            // 
            transFatDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            transFatDataGridViewTextBoxColumn1.DataPropertyName = "TransFat";
            dataGridViewCellStyle96.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle96.Format = "N1";
            dataGridViewCellStyle96.NullValue = "0";
            transFatDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle96;
            transFatDataGridViewTextBoxColumn1.HeaderText = "-Trans Fat (mg)";
            transFatDataGridViewTextBoxColumn1.MinimumWidth = 6;
            transFatDataGridViewTextBoxColumn1.Name = "transFatDataGridViewTextBoxColumn1";
            transFatDataGridViewTextBoxColumn1.ReadOnly = true;
            transFatDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            transFatDataGridViewTextBoxColumn1.Width = 59;
            // 
            // polyunsaturatedFatDataGridViewTextBoxColumn1
            // 
            polyunsaturatedFatDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            polyunsaturatedFatDataGridViewTextBoxColumn1.DataPropertyName = "PolyunsaturatedFat";
            dataGridViewCellStyle97.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle97.Format = "N1";
            dataGridViewCellStyle97.NullValue = "0";
            polyunsaturatedFatDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle97;
            polyunsaturatedFatDataGridViewTextBoxColumn1.HeaderText = "-Polyunsaturated Fat (g)";
            polyunsaturatedFatDataGridViewTextBoxColumn1.MinimumWidth = 6;
            polyunsaturatedFatDataGridViewTextBoxColumn1.Name = "polyunsaturatedFatDataGridViewTextBoxColumn1";
            polyunsaturatedFatDataGridViewTextBoxColumn1.ReadOnly = true;
            polyunsaturatedFatDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            polyunsaturatedFatDataGridViewTextBoxColumn1.Width = 113;
            // 
            // monounsaturatedFatDataGridViewTextBoxColumn1
            // 
            monounsaturatedFatDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            monounsaturatedFatDataGridViewTextBoxColumn1.DataPropertyName = "MonounsaturatedFat";
            dataGridViewCellStyle98.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle98.Format = "N1";
            dataGridViewCellStyle98.NullValue = "0";
            monounsaturatedFatDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle98;
            monounsaturatedFatDataGridViewTextBoxColumn1.HeaderText = "-Monounsaturated Fat (g)";
            monounsaturatedFatDataGridViewTextBoxColumn1.MinimumWidth = 6;
            monounsaturatedFatDataGridViewTextBoxColumn1.Name = "monounsaturatedFatDataGridViewTextBoxColumn1";
            monounsaturatedFatDataGridViewTextBoxColumn1.ReadOnly = true;
            monounsaturatedFatDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            monounsaturatedFatDataGridViewTextBoxColumn1.Width = 121;
            // 
            // carbohydrateDataGridViewTextBoxColumn1
            // 
            carbohydrateDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            carbohydrateDataGridViewTextBoxColumn1.DataPropertyName = "Carbohydrate";
            dataGridViewCellStyle99.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle99.Format = "N1";
            dataGridViewCellStyle99.NullValue = "0";
            carbohydrateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle99;
            carbohydrateDataGridViewTextBoxColumn1.HeaderText = "Carbohydrate (g)";
            carbohydrateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            carbohydrateDataGridViewTextBoxColumn1.Name = "carbohydrateDataGridViewTextBoxColumn1";
            carbohydrateDataGridViewTextBoxColumn1.ReadOnly = true;
            carbohydrateDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            carbohydrateDataGridViewTextBoxColumn1.Width = 92;
            // 
            // sugarsDataGridViewTextBoxColumn1
            // 
            sugarsDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sugarsDataGridViewTextBoxColumn1.DataPropertyName = "Sugars";
            dataGridViewCellStyle100.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle100.Format = "N1";
            dataGridViewCellStyle100.NullValue = "0";
            sugarsDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle100;
            sugarsDataGridViewTextBoxColumn1.HeaderText = "-Sugars (g)";
            sugarsDataGridViewTextBoxColumn1.MinimumWidth = 6;
            sugarsDataGridViewTextBoxColumn1.Name = "sugarsDataGridViewTextBoxColumn1";
            sugarsDataGridViewTextBoxColumn1.ReadOnly = true;
            sugarsDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            sugarsDataGridViewTextBoxColumn1.Width = 63;
            // 
            // dietaryFibreDataGridViewTextBoxColumn1
            // 
            dietaryFibreDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dietaryFibreDataGridViewTextBoxColumn1.DataPropertyName = "DietaryFibre";
            dataGridViewCellStyle101.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle101.Format = "N1";
            dataGridViewCellStyle101.NullValue = "0";
            dietaryFibreDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle101;
            dietaryFibreDataGridViewTextBoxColumn1.HeaderText = "Dietary Fibre (g)";
            dietaryFibreDataGridViewTextBoxColumn1.MinimumWidth = 6;
            dietaryFibreDataGridViewTextBoxColumn1.Name = "dietaryFibreDataGridViewTextBoxColumn1";
            dietaryFibreDataGridViewTextBoxColumn1.ReadOnly = true;
            dietaryFibreDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dietaryFibreDataGridViewTextBoxColumn1.Width = 73;
            // 
            // sodiumNaDataGridViewTextBoxColumn1
            // 
            sodiumNaDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sodiumNaDataGridViewTextBoxColumn1.DataPropertyName = "SodiumNa";
            dataGridViewCellStyle102.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle102.Format = "N0";
            dataGridViewCellStyle102.NullValue = "0";
            sodiumNaDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle102;
            sodiumNaDataGridViewTextBoxColumn1.HeaderText = "Sodium Na (mg)";
            sodiumNaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            sodiumNaDataGridViewTextBoxColumn1.Name = "sodiumNaDataGridViewTextBoxColumn1";
            sodiumNaDataGridViewTextBoxColumn1.ReadOnly = true;
            sodiumNaDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            sodiumNaDataGridViewTextBoxColumn1.Width = 67;
            // 
            // calciumCaDataGridViewTextBoxColumn1
            // 
            calciumCaDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            calciumCaDataGridViewTextBoxColumn1.DataPropertyName = "CalciumCa";
            dataGridViewCellStyle103.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle103.Format = "N0";
            dataGridViewCellStyle103.NullValue = "0";
            calciumCaDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle103;
            calciumCaDataGridViewTextBoxColumn1.HeaderText = "Calcium Ca (mg)";
            calciumCaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            calciumCaDataGridViewTextBoxColumn1.Name = "calciumCaDataGridViewTextBoxColumn1";
            calciumCaDataGridViewTextBoxColumn1.ReadOnly = true;
            calciumCaDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            calciumCaDataGridViewTextBoxColumn1.Width = 68;
            // 
            // potassiumKDataGridViewTextBoxColumn1
            // 
            potassiumKDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            potassiumKDataGridViewTextBoxColumn1.DataPropertyName = "PotassiumK";
            dataGridViewCellStyle104.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle104.Format = "N0";
            dataGridViewCellStyle104.NullValue = "0";
            potassiumKDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle104;
            potassiumKDataGridViewTextBoxColumn1.HeaderText = "Potassium K (mg)";
            potassiumKDataGridViewTextBoxColumn1.MinimumWidth = 6;
            potassiumKDataGridViewTextBoxColumn1.Name = "potassiumKDataGridViewTextBoxColumn1";
            potassiumKDataGridViewTextBoxColumn1.ReadOnly = true;
            potassiumKDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            potassiumKDataGridViewTextBoxColumn1.Width = 72;
            // 
            // thiaminB1DataGridViewTextBoxColumn1
            // 
            thiaminB1DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            thiaminB1DataGridViewTextBoxColumn1.DataPropertyName = "ThiaminB1";
            dataGridViewCellStyle105.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle105.Format = "N1";
            dataGridViewCellStyle105.NullValue = "0";
            thiaminB1DataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle105;
            thiaminB1DataGridViewTextBoxColumn1.HeaderText = "Thiamin B1 (mg)";
            thiaminB1DataGridViewTextBoxColumn1.MinimumWidth = 6;
            thiaminB1DataGridViewTextBoxColumn1.Name = "thiaminB1DataGridViewTextBoxColumn1";
            thiaminB1DataGridViewTextBoxColumn1.ReadOnly = true;
            thiaminB1DataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            thiaminB1DataGridViewTextBoxColumn1.Width = 67;
            // 
            // riboflavinB2DataGridViewTextBoxColumn1
            // 
            riboflavinB2DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            riboflavinB2DataGridViewTextBoxColumn1.DataPropertyName = "RiboflavinB2";
            dataGridViewCellStyle106.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle106.Format = "N1";
            dataGridViewCellStyle106.NullValue = "0";
            riboflavinB2DataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle106;
            riboflavinB2DataGridViewTextBoxColumn1.HeaderText = "Riboflavin B2 (mg)";
            riboflavinB2DataGridViewTextBoxColumn1.MinimumWidth = 6;
            riboflavinB2DataGridViewTextBoxColumn1.Name = "riboflavinB2DataGridViewTextBoxColumn1";
            riboflavinB2DataGridViewTextBoxColumn1.ReadOnly = true;
            riboflavinB2DataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            riboflavinB2DataGridViewTextBoxColumn1.Width = 76;
            // 
            // niacinB3DataGridViewTextBoxColumn1
            // 
            niacinB3DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            niacinB3DataGridViewTextBoxColumn1.DataPropertyName = "NiacinB3";
            dataGridViewCellStyle107.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle107.Format = "N1";
            dataGridViewCellStyle107.NullValue = "0";
            niacinB3DataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle107;
            niacinB3DataGridViewTextBoxColumn1.HeaderText = "Niacin B3 (mg)";
            niacinB3DataGridViewTextBoxColumn1.MinimumWidth = 6;
            niacinB3DataGridViewTextBoxColumn1.Name = "niacinB3DataGridViewTextBoxColumn1";
            niacinB3DataGridViewTextBoxColumn1.ReadOnly = true;
            niacinB3DataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            niacinB3DataGridViewTextBoxColumn1.Width = 59;
            // 
            // folateDataGridViewTextBoxColumn1
            // 
            folateDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            folateDataGridViewTextBoxColumn1.DataPropertyName = "Folate";
            dataGridViewCellStyle108.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle108.Format = "N0";
            dataGridViewCellStyle108.NullValue = "0";
            folateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle108;
            folateDataGridViewTextBoxColumn1.HeaderText = "Folate (ug)";
            folateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            folateDataGridViewTextBoxColumn1.Name = "folateDataGridViewTextBoxColumn1";
            folateDataGridViewTextBoxColumn1.ReadOnly = true;
            folateDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            folateDataGridViewTextBoxColumn1.Width = 62;
            // 
            // ironFeDataGridViewTextBoxColumn1
            // 
            ironFeDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ironFeDataGridViewTextBoxColumn1.DataPropertyName = "IronFe";
            dataGridViewCellStyle109.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle109.Format = "N1";
            dataGridViewCellStyle109.NullValue = "0";
            ironFeDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle109;
            ironFeDataGridViewTextBoxColumn1.HeaderText = "Iron Fe (mg)";
            ironFeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            ironFeDataGridViewTextBoxColumn1.Name = "ironFeDataGridViewTextBoxColumn1";
            ironFeDataGridViewTextBoxColumn1.ReadOnly = true;
            ironFeDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            ironFeDataGridViewTextBoxColumn1.Width = 69;
            // 
            // magnesiumMgDataGridViewTextBoxColumn1
            // 
            magnesiumMgDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            magnesiumMgDataGridViewTextBoxColumn1.DataPropertyName = "MagnesiumMg";
            dataGridViewCellStyle110.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle110.Format = "N0";
            dataGridViewCellStyle110.NullValue = "0";
            magnesiumMgDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle110;
            magnesiumMgDataGridViewTextBoxColumn1.HeaderText = "Magnesium Mg (mg)";
            magnesiumMgDataGridViewTextBoxColumn1.MinimumWidth = 6;
            magnesiumMgDataGridViewTextBoxColumn1.Name = "magnesiumMgDataGridViewTextBoxColumn1";
            magnesiumMgDataGridViewTextBoxColumn1.ReadOnly = true;
            magnesiumMgDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            magnesiumMgDataGridViewTextBoxColumn1.Width = 89;
            // 
            // vitaminCDataGridViewTextBoxColumn1
            // 
            vitaminCDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            vitaminCDataGridViewTextBoxColumn1.DataPropertyName = "VitaminC";
            dataGridViewCellStyle111.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle111.Format = "N0";
            dataGridViewCellStyle111.NullValue = "0";
            vitaminCDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle111;
            vitaminCDataGridViewTextBoxColumn1.HeaderText = "Vitamin C (mg)";
            vitaminCDataGridViewTextBoxColumn1.MinimumWidth = 6;
            vitaminCDataGridViewTextBoxColumn1.Name = "vitaminCDataGridViewTextBoxColumn1";
            vitaminCDataGridViewTextBoxColumn1.ReadOnly = true;
            vitaminCDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            vitaminCDataGridViewTextBoxColumn1.Width = 60;
            // 
            // caffeineDataGridViewTextBoxColumn1
            // 
            caffeineDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            caffeineDataGridViewTextBoxColumn1.DataPropertyName = "Caffeine";
            dataGridViewCellStyle112.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle112.Format = "N0";
            dataGridViewCellStyle112.NullValue = "0";
            caffeineDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle112;
            caffeineDataGridViewTextBoxColumn1.HeaderText = "Caffeine (mg)";
            caffeineDataGridViewTextBoxColumn1.MinimumWidth = 6;
            caffeineDataGridViewTextBoxColumn1.Name = "caffeineDataGridViewTextBoxColumn1";
            caffeineDataGridViewTextBoxColumn1.ReadOnly = true;
            caffeineDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            caffeineDataGridViewTextBoxColumn1.Width = 77;
            // 
            // cholesterolDataGridViewTextBoxColumn1
            // 
            cholesterolDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            cholesterolDataGridViewTextBoxColumn1.DataPropertyName = "Cholesterol";
            dataGridViewCellStyle113.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle113.Format = "N0";
            dataGridViewCellStyle113.NullValue = "0";
            cholesterolDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle113;
            cholesterolDataGridViewTextBoxColumn1.HeaderText = "Cholesterol (mg)";
            cholesterolDataGridViewTextBoxColumn1.MinimumWidth = 6;
            cholesterolDataGridViewTextBoxColumn1.Name = "cholesterolDataGridViewTextBoxColumn1";
            cholesterolDataGridViewTextBoxColumn1.ReadOnly = true;
            cholesterolDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            cholesterolDataGridViewTextBoxColumn1.Width = 91;
            // 
            // alcoholDataGridViewTextBoxColumn1
            // 
            alcoholDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            alcoholDataGridViewTextBoxColumn1.DataPropertyName = "Alcohol";
            dataGridViewCellStyle114.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle114.Format = "N1";
            dataGridViewCellStyle114.NullValue = "0";
            alcoholDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle114;
            alcoholDataGridViewTextBoxColumn1.HeaderText = "Alcohol (g)";
            alcoholDataGridViewTextBoxColumn1.MinimumWidth = 6;
            alcoholDataGridViewTextBoxColumn1.Name = "alcoholDataGridViewTextBoxColumn1";
            alcoholDataGridViewTextBoxColumn1.ReadOnly = true;
            alcoholDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            alcoholDataGridViewTextBoxColumn1.Width = 64;
            // 
            // eatenBindingSource
            // 
            eatenBindingSource.DataSource = typeof(Eaten);
            // 
            // tabPageHelp
            // 
            tabPageHelp.Location = new Point(4, 24);
            tabPageHelp.Name = "tabPageHelp";
            tabPageHelp.Size = new Size(1410, 757);
            tabPageHelp.TabIndex = 2;
            tabPageHelp.Text = "Help";
            tabPageHelp.UseVisualStyleBackColor = true;
            // 
            // recipeBindingSource
            // 
            recipeBindingSource.DataSource = typeof(Recipe);
            // 
            // toolTipMainForm
            // 
            toolTipMainForm.IsBalloon = true;
            toolTipMainForm.ToolTipTitle = "Context Help";
            // 
            // aTimer
            // 
            aTimer.Enabled = true;
            aTimer.Tick += ATimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1420, 787);
            Controls.Add(tabControlMain);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
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
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).EndInit();
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
        private TextBox textBoxFilter;
        private Label labelFilter;
        private DataGridView dataGridViewEaten;
        private BindingSource eatenBindingSource;
        private CheckBox checkBoxDateFilter;
        private CheckBox checkBoxDailyTotals;
        private CheckBox checkBoxMainCols;
        private CheckBox checkBoxMainFoodCols;
        private Label labelInfo;
        public BindingSource foodBindingSource;
        private BindingSource recipeBindingSource;
        private HelpProvider helpProviderMainForm;
        private ToolTip toolTipMainForm;
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
        private System.Windows.Forms.Timer aTimer;
        private TabPage tabPageHelp;
        private DataGridViewTextBoxColumn EatenId;
        private DataGridViewTextBoxColumn DateEaten;
        private DataGridViewTextBoxColumn TimeEaten;
        private DataGridViewTextBoxColumn EatenTs;
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
    }
}