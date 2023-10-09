﻿using System.Runtime.CompilerServices;
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

        // date filter for Eaten foods (in Eaten tab)
        public DateTime dateEatenFilter;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle31 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle57 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle58 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle56 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle55 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle54 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle53 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle52 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle51 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle50 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle49 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle48 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle47 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle46 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle45 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle44 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle43 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle40 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle39 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle38 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle37 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle36 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle35 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle34 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle33 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle32 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            foodBindingSource = new BindingSource(components);
            eatenBindingSource = new BindingSource(components);
            recipeBindingSource = new BindingSource(components);
            aTimer = new System.Windows.Forms.Timer(components);
            tabPageEaten = new TabPage();
            dataGridViewEaten = new DataGridView();
            alcoholDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            cholesterolDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            caffeineDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            vitaminCDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            magnesiumMgDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ironFeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            folateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            niacinB3DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            riboflavinB2DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            thiaminB1DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            potassiumKDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            calciumCaDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            sodiumNaDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dietaryFibreDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            sugarsDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            carbohydrateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            monounsaturatedFatDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            polyunsaturatedFatDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            transFatDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            saturatedFatDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            fatTotalDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            proteinDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            energyDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            foodDescriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            amountEatenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            EatenTs = new DataGridViewTextBoxColumn();
            TimeEaten = new DataGridViewTextBoxColumn();
            DateEaten = new DataGridViewTextBoxColumn();
            EatenId = new DataGridViewTextBoxColumn();
            checkBoxDateFilter = new CheckBox();
            checkBoxDailyTotals = new CheckBox();
            checkBoxMainCols = new CheckBox();
            dateTimePickerEaten = new DateTimePicker();
            tabPageFood = new TabPage();
            dataGridViewFoods = new DataGridView();
            alcoholDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cholesterolDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            caffeineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vitaminCDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            magnesiumMgDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ironFeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            folateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            niacinB3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            riboflavinB2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            thiaminB1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            potassiumKDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            calciumCaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sodiumNaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dietaryFibreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sugarsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carbohydrateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            monounsaturatedFatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            polyunsaturatedFatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transFatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saturatedFatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fatTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            proteinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            energyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            foodDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            FoodIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            textBoxFilter = new TextBox();
            labelFilter = new Label();
            checkBoxMainFoodCols = new CheckBox();
            labelInfo = new Label();
            tabControlMain = new TabControl();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)foodBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eatenBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).BeginInit();
            tabPageEaten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEaten).BeginInit();
            tabPageFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFoods).BeginInit();
            tabControlMain.SuspendLayout();
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
            // foodBindingSource
            // 
            foodBindingSource.DataSource = typeof(Food);
            // 
            // eatenBindingSource
            // 
            eatenBindingSource.DataSource = typeof(Eaten);
            // 
            // recipeBindingSource
            // 
            recipeBindingSource.DataSource = typeof(Recipe);
            // 
            // aTimer
            // 
            aTimer.Enabled = true;
            aTimer.Tick += ATimer_Tick;
            // 
            // tabPageEaten
            // 
            tabPageEaten.Controls.Add(dateTimePickerEaten);
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
            tabPageEaten.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Azure;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Azure;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewEaten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewEaten.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEaten.Columns.AddRange(new DataGridViewColumn[] { EatenId, DateEaten, TimeEaten, EatenTs, amountEatenDataGridViewTextBoxColumn, foodDescriptionDataGridViewTextBoxColumn1, energyDataGridViewTextBoxColumn1, proteinDataGridViewTextBoxColumn1, fatTotalDataGridViewTextBoxColumn1, saturatedFatDataGridViewTextBoxColumn1, transFatDataGridViewTextBoxColumn1, polyunsaturatedFatDataGridViewTextBoxColumn1, monounsaturatedFatDataGridViewTextBoxColumn1, carbohydrateDataGridViewTextBoxColumn1, sugarsDataGridViewTextBoxColumn1, dietaryFibreDataGridViewTextBoxColumn1, sodiumNaDataGridViewTextBoxColumn1, calciumCaDataGridViewTextBoxColumn1, potassiumKDataGridViewTextBoxColumn1, thiaminB1DataGridViewTextBoxColumn1, riboflavinB2DataGridViewTextBoxColumn1, niacinB3DataGridViewTextBoxColumn1, folateDataGridViewTextBoxColumn1, ironFeDataGridViewTextBoxColumn1, magnesiumMgDataGridViewTextBoxColumn1, vitaminCDataGridViewTextBoxColumn1, caffeineDataGridViewTextBoxColumn1, cholesterolDataGridViewTextBoxColumn1, alcoholDataGridViewTextBoxColumn1 });
            dataGridViewEaten.DataSource = eatenBindingSource;
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = SystemColors.Window;
            dataGridViewCellStyle29.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle29.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = DataGridViewTriState.False;
            dataGridViewEaten.DefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewEaten.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridViewEaten.EnableHeadersVisualStyles = false;
            dataGridViewEaten.Location = new Point(6, 99);
            dataGridViewEaten.MultiSelect = false;
            dataGridViewEaten.Name = "dataGridViewEaten";
            dataGridViewEaten.ReadOnly = true;
            dataGridViewEaten.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = SystemColors.Control;
            dataGridViewCellStyle30.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle30.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle30.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle30.WrapMode = DataGridViewTriState.True;
            dataGridViewEaten.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            dataGridViewEaten.RowHeadersVisible = false;
            dataGridViewEaten.RowHeadersWidth = 40;
            dataGridViewEaten.RowTemplate.Height = 25;
            dataGridViewEaten.RowTemplate.ReadOnly = true;
            dataGridViewEaten.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEaten.ShowCellToolTips = false;
            dataGridViewEaten.Size = new Size(1398, 652);
            dataGridViewEaten.TabIndex = 0;
            dataGridViewEaten.UserDeletingRow += DataGridViewEaten_UserDeletingRow;
            // 
            // alcoholDataGridViewTextBoxColumn1
            // 
            alcoholDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            alcoholDataGridViewTextBoxColumn1.DataPropertyName = "Alcohol";
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle28.Format = "N1";
            dataGridViewCellStyle28.NullValue = "0";
            alcoholDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle28;
            alcoholDataGridViewTextBoxColumn1.HeaderText = "Alcohol (g)";
            alcoholDataGridViewTextBoxColumn1.MinimumWidth = 6;
            alcoholDataGridViewTextBoxColumn1.Name = "alcoholDataGridViewTextBoxColumn1";
            alcoholDataGridViewTextBoxColumn1.ReadOnly = true;
            alcoholDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            alcoholDataGridViewTextBoxColumn1.Width = 64;
            // 
            // cholesterolDataGridViewTextBoxColumn1
            // 
            cholesterolDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            cholesterolDataGridViewTextBoxColumn1.DataPropertyName = "Cholesterol";
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle27.Format = "N0";
            dataGridViewCellStyle27.NullValue = "0";
            cholesterolDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle27;
            cholesterolDataGridViewTextBoxColumn1.HeaderText = "Cholesterol (mg)";
            cholesterolDataGridViewTextBoxColumn1.MinimumWidth = 6;
            cholesterolDataGridViewTextBoxColumn1.Name = "cholesterolDataGridViewTextBoxColumn1";
            cholesterolDataGridViewTextBoxColumn1.ReadOnly = true;
            cholesterolDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            cholesterolDataGridViewTextBoxColumn1.Width = 91;
            // 
            // caffeineDataGridViewTextBoxColumn1
            // 
            caffeineDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            caffeineDataGridViewTextBoxColumn1.DataPropertyName = "Caffeine";
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "N0";
            dataGridViewCellStyle26.NullValue = "0";
            caffeineDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle26;
            caffeineDataGridViewTextBoxColumn1.HeaderText = "Caffeine (mg)";
            caffeineDataGridViewTextBoxColumn1.MinimumWidth = 6;
            caffeineDataGridViewTextBoxColumn1.Name = "caffeineDataGridViewTextBoxColumn1";
            caffeineDataGridViewTextBoxColumn1.ReadOnly = true;
            caffeineDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            caffeineDataGridViewTextBoxColumn1.Width = 77;
            // 
            // vitaminCDataGridViewTextBoxColumn1
            // 
            vitaminCDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            vitaminCDataGridViewTextBoxColumn1.DataPropertyName = "VitaminC";
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle25.Format = "N0";
            dataGridViewCellStyle25.NullValue = "0";
            vitaminCDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle25;
            vitaminCDataGridViewTextBoxColumn1.HeaderText = "Vitamin C (mg)";
            vitaminCDataGridViewTextBoxColumn1.MinimumWidth = 6;
            vitaminCDataGridViewTextBoxColumn1.Name = "vitaminCDataGridViewTextBoxColumn1";
            vitaminCDataGridViewTextBoxColumn1.ReadOnly = true;
            vitaminCDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            vitaminCDataGridViewTextBoxColumn1.Width = 60;
            // 
            // magnesiumMgDataGridViewTextBoxColumn1
            // 
            magnesiumMgDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            magnesiumMgDataGridViewTextBoxColumn1.DataPropertyName = "MagnesiumMg";
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.Format = "N0";
            dataGridViewCellStyle24.NullValue = "0";
            magnesiumMgDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle24;
            magnesiumMgDataGridViewTextBoxColumn1.HeaderText = "Magnesium Mg (mg)";
            magnesiumMgDataGridViewTextBoxColumn1.MinimumWidth = 6;
            magnesiumMgDataGridViewTextBoxColumn1.Name = "magnesiumMgDataGridViewTextBoxColumn1";
            magnesiumMgDataGridViewTextBoxColumn1.ReadOnly = true;
            magnesiumMgDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            magnesiumMgDataGridViewTextBoxColumn1.Width = 89;
            // 
            // ironFeDataGridViewTextBoxColumn1
            // 
            ironFeDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ironFeDataGridViewTextBoxColumn1.DataPropertyName = "IronFe";
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Format = "N1";
            dataGridViewCellStyle23.NullValue = "0";
            ironFeDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle23;
            ironFeDataGridViewTextBoxColumn1.HeaderText = "Iron Fe (mg)";
            ironFeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            ironFeDataGridViewTextBoxColumn1.Name = "ironFeDataGridViewTextBoxColumn1";
            ironFeDataGridViewTextBoxColumn1.ReadOnly = true;
            ironFeDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            ironFeDataGridViewTextBoxColumn1.Width = 69;
            // 
            // folateDataGridViewTextBoxColumn1
            // 
            folateDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            folateDataGridViewTextBoxColumn1.DataPropertyName = "Folate";
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "N0";
            dataGridViewCellStyle22.NullValue = "0";
            folateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle22;
            folateDataGridViewTextBoxColumn1.HeaderText = "Folate (ug)";
            folateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            folateDataGridViewTextBoxColumn1.Name = "folateDataGridViewTextBoxColumn1";
            folateDataGridViewTextBoxColumn1.ReadOnly = true;
            folateDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            folateDataGridViewTextBoxColumn1.Width = 62;
            // 
            // niacinB3DataGridViewTextBoxColumn1
            // 
            niacinB3DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            niacinB3DataGridViewTextBoxColumn1.DataPropertyName = "NiacinB3";
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "N1";
            dataGridViewCellStyle21.NullValue = "0";
            niacinB3DataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle21;
            niacinB3DataGridViewTextBoxColumn1.HeaderText = "Niacin B3 (mg)";
            niacinB3DataGridViewTextBoxColumn1.MinimumWidth = 6;
            niacinB3DataGridViewTextBoxColumn1.Name = "niacinB3DataGridViewTextBoxColumn1";
            niacinB3DataGridViewTextBoxColumn1.ReadOnly = true;
            niacinB3DataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            niacinB3DataGridViewTextBoxColumn1.Width = 59;
            // 
            // riboflavinB2DataGridViewTextBoxColumn1
            // 
            riboflavinB2DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            riboflavinB2DataGridViewTextBoxColumn1.DataPropertyName = "RiboflavinB2";
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "N1";
            dataGridViewCellStyle20.NullValue = "0";
            riboflavinB2DataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle20;
            riboflavinB2DataGridViewTextBoxColumn1.HeaderText = "Riboflavin B2 (mg)";
            riboflavinB2DataGridViewTextBoxColumn1.MinimumWidth = 6;
            riboflavinB2DataGridViewTextBoxColumn1.Name = "riboflavinB2DataGridViewTextBoxColumn1";
            riboflavinB2DataGridViewTextBoxColumn1.ReadOnly = true;
            riboflavinB2DataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            riboflavinB2DataGridViewTextBoxColumn1.Width = 76;
            // 
            // thiaminB1DataGridViewTextBoxColumn1
            // 
            thiaminB1DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            thiaminB1DataGridViewTextBoxColumn1.DataPropertyName = "ThiaminB1";
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N1";
            dataGridViewCellStyle19.NullValue = "0";
            thiaminB1DataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle19;
            thiaminB1DataGridViewTextBoxColumn1.HeaderText = "Thiamin B1 (mg)";
            thiaminB1DataGridViewTextBoxColumn1.MinimumWidth = 6;
            thiaminB1DataGridViewTextBoxColumn1.Name = "thiaminB1DataGridViewTextBoxColumn1";
            thiaminB1DataGridViewTextBoxColumn1.ReadOnly = true;
            thiaminB1DataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            thiaminB1DataGridViewTextBoxColumn1.Width = 67;
            // 
            // potassiumKDataGridViewTextBoxColumn1
            // 
            potassiumKDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            potassiumKDataGridViewTextBoxColumn1.DataPropertyName = "PotassiumK";
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N0";
            dataGridViewCellStyle18.NullValue = "0";
            potassiumKDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle18;
            potassiumKDataGridViewTextBoxColumn1.HeaderText = "Potassium K (mg)";
            potassiumKDataGridViewTextBoxColumn1.MinimumWidth = 6;
            potassiumKDataGridViewTextBoxColumn1.Name = "potassiumKDataGridViewTextBoxColumn1";
            potassiumKDataGridViewTextBoxColumn1.ReadOnly = true;
            potassiumKDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            potassiumKDataGridViewTextBoxColumn1.Width = 72;
            // 
            // calciumCaDataGridViewTextBoxColumn1
            // 
            calciumCaDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            calciumCaDataGridViewTextBoxColumn1.DataPropertyName = "CalciumCa";
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N0";
            dataGridViewCellStyle17.NullValue = "0";
            calciumCaDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle17;
            calciumCaDataGridViewTextBoxColumn1.HeaderText = "Calcium Ca (mg)";
            calciumCaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            calciumCaDataGridViewTextBoxColumn1.Name = "calciumCaDataGridViewTextBoxColumn1";
            calciumCaDataGridViewTextBoxColumn1.ReadOnly = true;
            calciumCaDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            calciumCaDataGridViewTextBoxColumn1.Width = 68;
            // 
            // sodiumNaDataGridViewTextBoxColumn1
            // 
            sodiumNaDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sodiumNaDataGridViewTextBoxColumn1.DataPropertyName = "SodiumNa";
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N0";
            dataGridViewCellStyle16.NullValue = "0";
            sodiumNaDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle16;
            sodiumNaDataGridViewTextBoxColumn1.HeaderText = "Sodium Na (mg)";
            sodiumNaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            sodiumNaDataGridViewTextBoxColumn1.Name = "sodiumNaDataGridViewTextBoxColumn1";
            sodiumNaDataGridViewTextBoxColumn1.ReadOnly = true;
            sodiumNaDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            sodiumNaDataGridViewTextBoxColumn1.Width = 67;
            // 
            // dietaryFibreDataGridViewTextBoxColumn1
            // 
            dietaryFibreDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dietaryFibreDataGridViewTextBoxColumn1.DataPropertyName = "DietaryFibre";
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N1";
            dataGridViewCellStyle15.NullValue = "0";
            dietaryFibreDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle15;
            dietaryFibreDataGridViewTextBoxColumn1.HeaderText = "Dietary Fibre (g)";
            dietaryFibreDataGridViewTextBoxColumn1.MinimumWidth = 6;
            dietaryFibreDataGridViewTextBoxColumn1.Name = "dietaryFibreDataGridViewTextBoxColumn1";
            dietaryFibreDataGridViewTextBoxColumn1.ReadOnly = true;
            dietaryFibreDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dietaryFibreDataGridViewTextBoxColumn1.Width = 73;
            // 
            // sugarsDataGridViewTextBoxColumn1
            // 
            sugarsDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sugarsDataGridViewTextBoxColumn1.DataPropertyName = "Sugars";
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N1";
            dataGridViewCellStyle14.NullValue = "0";
            sugarsDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle14;
            sugarsDataGridViewTextBoxColumn1.HeaderText = "-Sugars (g)";
            sugarsDataGridViewTextBoxColumn1.MinimumWidth = 6;
            sugarsDataGridViewTextBoxColumn1.Name = "sugarsDataGridViewTextBoxColumn1";
            sugarsDataGridViewTextBoxColumn1.ReadOnly = true;
            sugarsDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            sugarsDataGridViewTextBoxColumn1.Width = 63;
            // 
            // carbohydrateDataGridViewTextBoxColumn1
            // 
            carbohydrateDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            carbohydrateDataGridViewTextBoxColumn1.DataPropertyName = "Carbohydrate";
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N1";
            dataGridViewCellStyle13.NullValue = "0";
            carbohydrateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle13;
            carbohydrateDataGridViewTextBoxColumn1.HeaderText = "Carbohydrate (g)";
            carbohydrateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            carbohydrateDataGridViewTextBoxColumn1.Name = "carbohydrateDataGridViewTextBoxColumn1";
            carbohydrateDataGridViewTextBoxColumn1.ReadOnly = true;
            carbohydrateDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            carbohydrateDataGridViewTextBoxColumn1.Width = 92;
            // 
            // monounsaturatedFatDataGridViewTextBoxColumn1
            // 
            monounsaturatedFatDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            monounsaturatedFatDataGridViewTextBoxColumn1.DataPropertyName = "MonounsaturatedFat";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N1";
            dataGridViewCellStyle12.NullValue = "0";
            monounsaturatedFatDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle12;
            monounsaturatedFatDataGridViewTextBoxColumn1.HeaderText = "-Monounsaturated Fat (g)";
            monounsaturatedFatDataGridViewTextBoxColumn1.MinimumWidth = 6;
            monounsaturatedFatDataGridViewTextBoxColumn1.Name = "monounsaturatedFatDataGridViewTextBoxColumn1";
            monounsaturatedFatDataGridViewTextBoxColumn1.ReadOnly = true;
            monounsaturatedFatDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            monounsaturatedFatDataGridViewTextBoxColumn1.Width = 121;
            // 
            // polyunsaturatedFatDataGridViewTextBoxColumn1
            // 
            polyunsaturatedFatDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            polyunsaturatedFatDataGridViewTextBoxColumn1.DataPropertyName = "PolyunsaturatedFat";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N1";
            dataGridViewCellStyle11.NullValue = "0";
            polyunsaturatedFatDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            polyunsaturatedFatDataGridViewTextBoxColumn1.HeaderText = "-Polyunsaturated Fat (g)";
            polyunsaturatedFatDataGridViewTextBoxColumn1.MinimumWidth = 6;
            polyunsaturatedFatDataGridViewTextBoxColumn1.Name = "polyunsaturatedFatDataGridViewTextBoxColumn1";
            polyunsaturatedFatDataGridViewTextBoxColumn1.ReadOnly = true;
            polyunsaturatedFatDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            polyunsaturatedFatDataGridViewTextBoxColumn1.Width = 113;
            // 
            // transFatDataGridViewTextBoxColumn1
            // 
            transFatDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            transFatDataGridViewTextBoxColumn1.DataPropertyName = "TransFat";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N1";
            dataGridViewCellStyle10.NullValue = "0";
            transFatDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle10;
            transFatDataGridViewTextBoxColumn1.HeaderText = "-Trans Fat (mg)";
            transFatDataGridViewTextBoxColumn1.MinimumWidth = 6;
            transFatDataGridViewTextBoxColumn1.Name = "transFatDataGridViewTextBoxColumn1";
            transFatDataGridViewTextBoxColumn1.ReadOnly = true;
            transFatDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            transFatDataGridViewTextBoxColumn1.Width = 59;
            // 
            // saturatedFatDataGridViewTextBoxColumn1
            // 
            saturatedFatDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            saturatedFatDataGridViewTextBoxColumn1.DataPropertyName = "SaturatedFat";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N1";
            dataGridViewCellStyle9.NullValue = "0";
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            saturatedFatDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            saturatedFatDataGridViewTextBoxColumn1.HeaderText = "-Saturated Fat (g)";
            saturatedFatDataGridViewTextBoxColumn1.MinimumWidth = 6;
            saturatedFatDataGridViewTextBoxColumn1.Name = "saturatedFatDataGridViewTextBoxColumn1";
            saturatedFatDataGridViewTextBoxColumn1.ReadOnly = true;
            saturatedFatDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            saturatedFatDataGridViewTextBoxColumn1.Width = 80;
            // 
            // fatTotalDataGridViewTextBoxColumn1
            // 
            fatTotalDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            fatTotalDataGridViewTextBoxColumn1.DataPropertyName = "FatTotal";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N1";
            dataGridViewCellStyle8.NullValue = "0";
            fatTotalDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            fatTotalDataGridViewTextBoxColumn1.HeaderText = "Fat Total (g)";
            fatTotalDataGridViewTextBoxColumn1.MinimumWidth = 6;
            fatTotalDataGridViewTextBoxColumn1.Name = "fatTotalDataGridViewTextBoxColumn1";
            fatTotalDataGridViewTextBoxColumn1.ReadOnly = true;
            fatTotalDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            fatTotalDataGridViewTextBoxColumn1.Width = 67;
            // 
            // proteinDataGridViewTextBoxColumn1
            // 
            proteinDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            proteinDataGridViewTextBoxColumn1.DataPropertyName = "Protein";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N1";
            dataGridViewCellStyle7.NullValue = "0";
            proteinDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            proteinDataGridViewTextBoxColumn1.HeaderText = "Protein (g)";
            proteinDataGridViewTextBoxColumn1.MinimumWidth = 6;
            proteinDataGridViewTextBoxColumn1.Name = "proteinDataGridViewTextBoxColumn1";
            proteinDataGridViewTextBoxColumn1.ReadOnly = true;
            proteinDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            proteinDataGridViewTextBoxColumn1.Width = 61;
            // 
            // energyDataGridViewTextBoxColumn1
            // 
            energyDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            energyDataGridViewTextBoxColumn1.DataPropertyName = "Energy";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N1";
            dataGridViewCellStyle6.NullValue = "0";
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            energyDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            energyDataGridViewTextBoxColumn1.HeaderText = "Energy (kJ)";
            energyDataGridViewTextBoxColumn1.MinimumWidth = 6;
            energyDataGridViewTextBoxColumn1.Name = "energyDataGridViewTextBoxColumn1";
            energyDataGridViewTextBoxColumn1.ReadOnly = true;
            energyDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            energyDataGridViewTextBoxColumn1.Width = 62;
            // 
            // foodDescriptionDataGridViewTextBoxColumn1
            // 
            foodDescriptionDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            foodDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "FoodDescription";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            foodDescriptionDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            foodDescriptionDataGridViewTextBoxColumn1.HeaderText = "Food description";
            foodDescriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            foodDescriptionDataGridViewTextBoxColumn1.Name = "foodDescriptionDataGridViewTextBoxColumn1";
            foodDescriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            foodDescriptionDataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            foodDescriptionDataGridViewTextBoxColumn1.Width = 91;
            // 
            // amountEatenDataGridViewTextBoxColumn
            // 
            amountEatenDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            amountEatenDataGridViewTextBoxColumn.DataPropertyName = "AmountEaten";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N1";
            dataGridViewCellStyle4.NullValue = "0";
            amountEatenDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            amountEatenDataGridViewTextBoxColumn.HeaderText = "Amount (g or mL)";
            amountEatenDataGridViewTextBoxColumn.MinimumWidth = 6;
            amountEatenDataGridViewTextBoxColumn.Name = "amountEatenDataGridViewTextBoxColumn";
            amountEatenDataGridViewTextBoxColumn.ReadOnly = true;
            amountEatenDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            amountEatenDataGridViewTextBoxColumn.Width = 66;
            // 
            // EatenTs
            // 
            EatenTs.DataPropertyName = "EatenTs";
            EatenTs.HeaderText = "EatenTs";
            EatenTs.Name = "EatenTs";
            EatenTs.ReadOnly = true;
            // 
            // TimeEaten
            // 
            TimeEaten.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TimeEaten.DataPropertyName = "TimeEaten";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            TimeEaten.DefaultCellStyle = dataGridViewCellStyle3;
            TimeEaten.HeaderText = "Time";
            TimeEaten.MinimumWidth = 8;
            TimeEaten.Name = "TimeEaten";
            TimeEaten.ReadOnly = true;
            TimeEaten.SortMode = DataGridViewColumnSortMode.NotSortable;
            TimeEaten.Width = 38;
            // 
            // DateEaten
            // 
            DateEaten.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DateEaten.DataPropertyName = "DateEaten";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            DateEaten.DefaultCellStyle = dataGridViewCellStyle2;
            DateEaten.HeaderText = "Date";
            DateEaten.MinimumWidth = 8;
            DateEaten.Name = "DateEaten";
            DateEaten.ReadOnly = true;
            DateEaten.SortMode = DataGridViewColumnSortMode.NotSortable;
            DateEaten.Width = 36;
            // 
            // EatenId
            // 
            EatenId.DataPropertyName = "EatenId";
            EatenId.HeaderText = "Id";
            EatenId.Name = "EatenId";
            EatenId.ReadOnly = true;
            EatenId.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // checkBoxDateFilter
            // 
            checkBoxDateFilter.AutoSize = true;
            checkBoxDateFilter.Checked = true;
            checkBoxDateFilter.CheckState = CheckState.Checked;
            checkBoxDateFilter.Location = new Point(23, 68);
            checkBoxDateFilter.Name = "checkBoxDateFilter";
            checkBoxDateFilter.Size = new Size(68, 19);
            checkBoxDateFilter.TabIndex = 5;
            checkBoxDateFilter.Text = "Filter by";
            checkBoxDateFilter.UseVisualStyleBackColor = true;
            checkBoxDateFilter.CheckedChanged += CheckBoxDateFilter_CheckedChanged;
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
            // dateTimePickerEaten
            // 
            dateTimePickerEaten.CustomFormat = "  dd-MMM-yyyy";
            dateTimePickerEaten.Format = DateTimePickerFormat.Custom;
            dateTimePickerEaten.Location = new Point(91, 66);
            dateTimePickerEaten.MaxDate = new DateTime(2123, 1, 1, 0, 0, 0, 0);
            dateTimePickerEaten.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dateTimePickerEaten.Name = "dateTimePickerEaten";
            dateTimePickerEaten.Size = new Size(128, 23);
            dateTimePickerEaten.TabIndex = 8;
            dateTimePickerEaten.KeyDown += dateTimePickerEaten_KeyDown;
            dateTimePickerEaten.Leave += dateTimePickerEaten_Leave;
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
            tabPageFood.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle31.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = Color.Azure;
            dataGridViewCellStyle31.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle31.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = Color.Azure;
            dataGridViewCellStyle31.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle31.WrapMode = DataGridViewTriState.True;
            dataGridViewFoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            dataGridViewFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFoods.Columns.AddRange(new DataGridViewColumn[] { FoodIdDataGridViewTextBoxColumn, foodDescriptionDataGridViewTextBoxColumn, energyDataGridViewTextBoxColumn, proteinDataGridViewTextBoxColumn, fatTotalDataGridViewTextBoxColumn, saturatedFatDataGridViewTextBoxColumn, transFatDataGridViewTextBoxColumn, polyunsaturatedFatDataGridViewTextBoxColumn, monounsaturatedFatDataGridViewTextBoxColumn, carbohydrateDataGridViewTextBoxColumn, sugarsDataGridViewTextBoxColumn, dietaryFibreDataGridViewTextBoxColumn, sodiumNaDataGridViewTextBoxColumn, calciumCaDataGridViewTextBoxColumn, potassiumKDataGridViewTextBoxColumn, thiaminB1DataGridViewTextBoxColumn, riboflavinB2DataGridViewTextBoxColumn, niacinB3DataGridViewTextBoxColumn, folateDataGridViewTextBoxColumn, ironFeDataGridViewTextBoxColumn, magnesiumMgDataGridViewTextBoxColumn, vitaminCDataGridViewTextBoxColumn, caffeineDataGridViewTextBoxColumn, cholesterolDataGridViewTextBoxColumn, alcoholDataGridViewTextBoxColumn });
            dataGridViewFoods.DataSource = foodBindingSource;
            dataGridViewCellStyle57.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle57.BackColor = SystemColors.Info;
            dataGridViewCellStyle57.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle57.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle57.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle57.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle57.WrapMode = DataGridViewTriState.False;
            dataGridViewFoods.DefaultCellStyle = dataGridViewCellStyle57;
            dataGridViewFoods.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridViewFoods.EnableHeadersVisualStyles = false;
            dataGridViewFoods.Location = new Point(6, 99);
            dataGridViewFoods.MultiSelect = false;
            dataGridViewFoods.Name = "dataGridViewFoods";
            dataGridViewFoods.ReadOnly = true;
            dataGridViewFoods.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle58.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle58.BackColor = SystemColors.Control;
            dataGridViewCellStyle58.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle58.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle58.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle58.SelectionForeColor = Color.White;
            dataGridViewCellStyle58.WrapMode = DataGridViewTriState.True;
            dataGridViewFoods.RowHeadersDefaultCellStyle = dataGridViewCellStyle58;
            dataGridViewFoods.RowHeadersVisible = false;
            dataGridViewFoods.RowHeadersWidth = 40;
            dataGridViewFoods.RowTemplate.Height = 25;
            dataGridViewFoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFoods.ShowCellToolTips = false;
            dataGridViewFoods.Size = new Size(1398, 652);
            dataGridViewFoods.TabIndex = 4;
            dataGridViewFoods.CellDoubleClick += DataGridViewFoods_CellDoubleClick;
            dataGridViewFoods.UserDeletingRow += DataGridViewFoods_UserDeletingRow;
            dataGridViewFoods.KeyDown += DataGridViewFoods_KeyDown;
            // 
            // alcoholDataGridViewTextBoxColumn
            // 
            alcoholDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            alcoholDataGridViewTextBoxColumn.DataPropertyName = "Alcohol";
            dataGridViewCellStyle56.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle56.Format = "N1";
            dataGridViewCellStyle56.NullValue = "0";
            alcoholDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle56;
            alcoholDataGridViewTextBoxColumn.HeaderText = "Alcohol (g)";
            alcoholDataGridViewTextBoxColumn.MinimumWidth = 6;
            alcoholDataGridViewTextBoxColumn.Name = "alcoholDataGridViewTextBoxColumn";
            alcoholDataGridViewTextBoxColumn.ReadOnly = true;
            alcoholDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            alcoholDataGridViewTextBoxColumn.Width = 64;
            // 
            // cholesterolDataGridViewTextBoxColumn
            // 
            cholesterolDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            cholesterolDataGridViewTextBoxColumn.DataPropertyName = "Cholesterol";
            dataGridViewCellStyle55.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle55.Format = "N0";
            dataGridViewCellStyle55.NullValue = "0";
            cholesterolDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle55;
            cholesterolDataGridViewTextBoxColumn.HeaderText = "Cholesterol (mg)";
            cholesterolDataGridViewTextBoxColumn.MinimumWidth = 6;
            cholesterolDataGridViewTextBoxColumn.Name = "cholesterolDataGridViewTextBoxColumn";
            cholesterolDataGridViewTextBoxColumn.ReadOnly = true;
            cholesterolDataGridViewTextBoxColumn.Width = 110;
            // 
            // caffeineDataGridViewTextBoxColumn
            // 
            caffeineDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            caffeineDataGridViewTextBoxColumn.DataPropertyName = "Caffeine";
            dataGridViewCellStyle54.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle54.Format = "N0";
            dataGridViewCellStyle54.NullValue = "0";
            caffeineDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle54;
            caffeineDataGridViewTextBoxColumn.HeaderText = "Caffeine (mg)";
            caffeineDataGridViewTextBoxColumn.MinimumWidth = 6;
            caffeineDataGridViewTextBoxColumn.Name = "caffeineDataGridViewTextBoxColumn";
            caffeineDataGridViewTextBoxColumn.ReadOnly = true;
            caffeineDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            caffeineDataGridViewTextBoxColumn.Width = 77;
            // 
            // vitaminCDataGridViewTextBoxColumn
            // 
            vitaminCDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            vitaminCDataGridViewTextBoxColumn.DataPropertyName = "VitaminC";
            dataGridViewCellStyle53.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle53.Format = "N0";
            dataGridViewCellStyle53.NullValue = "0";
            vitaminCDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle53;
            vitaminCDataGridViewTextBoxColumn.HeaderText = "Vitamin C (mg)";
            vitaminCDataGridViewTextBoxColumn.MinimumWidth = 6;
            vitaminCDataGridViewTextBoxColumn.Name = "vitaminCDataGridViewTextBoxColumn";
            vitaminCDataGridViewTextBoxColumn.ReadOnly = true;
            vitaminCDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            vitaminCDataGridViewTextBoxColumn.Width = 60;
            // 
            // magnesiumMgDataGridViewTextBoxColumn
            // 
            magnesiumMgDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            magnesiumMgDataGridViewTextBoxColumn.DataPropertyName = "MagnesiumMg";
            dataGridViewCellStyle52.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle52.Format = "N0";
            dataGridViewCellStyle52.NullValue = "0";
            magnesiumMgDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle52;
            magnesiumMgDataGridViewTextBoxColumn.HeaderText = "Magnesium Mg (mg)";
            magnesiumMgDataGridViewTextBoxColumn.MinimumWidth = 6;
            magnesiumMgDataGridViewTextBoxColumn.Name = "magnesiumMgDataGridViewTextBoxColumn";
            magnesiumMgDataGridViewTextBoxColumn.ReadOnly = true;
            magnesiumMgDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            magnesiumMgDataGridViewTextBoxColumn.Width = 89;
            // 
            // ironFeDataGridViewTextBoxColumn
            // 
            ironFeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ironFeDataGridViewTextBoxColumn.DataPropertyName = "IronFe";
            dataGridViewCellStyle51.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle51.Format = "N1";
            dataGridViewCellStyle51.NullValue = "0";
            ironFeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle51;
            ironFeDataGridViewTextBoxColumn.HeaderText = "Iron Fe (mg)";
            ironFeDataGridViewTextBoxColumn.MinimumWidth = 6;
            ironFeDataGridViewTextBoxColumn.Name = "ironFeDataGridViewTextBoxColumn";
            ironFeDataGridViewTextBoxColumn.ReadOnly = true;
            ironFeDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            ironFeDataGridViewTextBoxColumn.Width = 69;
            // 
            // folateDataGridViewTextBoxColumn
            // 
            folateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            folateDataGridViewTextBoxColumn.DataPropertyName = "Folate";
            dataGridViewCellStyle50.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle50.Format = "N0";
            dataGridViewCellStyle50.NullValue = "0";
            folateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle50;
            folateDataGridViewTextBoxColumn.HeaderText = "Folate (ug)";
            folateDataGridViewTextBoxColumn.MinimumWidth = 6;
            folateDataGridViewTextBoxColumn.Name = "folateDataGridViewTextBoxColumn";
            folateDataGridViewTextBoxColumn.ReadOnly = true;
            folateDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            folateDataGridViewTextBoxColumn.Width = 62;
            // 
            // niacinB3DataGridViewTextBoxColumn
            // 
            niacinB3DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            niacinB3DataGridViewTextBoxColumn.DataPropertyName = "NiacinB3";
            dataGridViewCellStyle49.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle49.Format = "N1";
            dataGridViewCellStyle49.NullValue = "0";
            niacinB3DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle49;
            niacinB3DataGridViewTextBoxColumn.HeaderText = "Niacin B3 (mg)";
            niacinB3DataGridViewTextBoxColumn.MinimumWidth = 6;
            niacinB3DataGridViewTextBoxColumn.Name = "niacinB3DataGridViewTextBoxColumn";
            niacinB3DataGridViewTextBoxColumn.ReadOnly = true;
            niacinB3DataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            niacinB3DataGridViewTextBoxColumn.Width = 59;
            // 
            // riboflavinB2DataGridViewTextBoxColumn
            // 
            riboflavinB2DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            riboflavinB2DataGridViewTextBoxColumn.DataPropertyName = "RiboflavinB2";
            dataGridViewCellStyle48.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle48.Format = "N1";
            dataGridViewCellStyle48.NullValue = "0";
            riboflavinB2DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle48;
            riboflavinB2DataGridViewTextBoxColumn.HeaderText = "Riboflavin B2 (mg)";
            riboflavinB2DataGridViewTextBoxColumn.MinimumWidth = 6;
            riboflavinB2DataGridViewTextBoxColumn.Name = "riboflavinB2DataGridViewTextBoxColumn";
            riboflavinB2DataGridViewTextBoxColumn.ReadOnly = true;
            riboflavinB2DataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            riboflavinB2DataGridViewTextBoxColumn.Width = 76;
            // 
            // thiaminB1DataGridViewTextBoxColumn
            // 
            thiaminB1DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            thiaminB1DataGridViewTextBoxColumn.DataPropertyName = "ThiaminB1";
            dataGridViewCellStyle47.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle47.Format = "N1";
            dataGridViewCellStyle47.NullValue = "0";
            thiaminB1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle47;
            thiaminB1DataGridViewTextBoxColumn.HeaderText = "Thiamin B1 (mg)";
            thiaminB1DataGridViewTextBoxColumn.MinimumWidth = 6;
            thiaminB1DataGridViewTextBoxColumn.Name = "thiaminB1DataGridViewTextBoxColumn";
            thiaminB1DataGridViewTextBoxColumn.ReadOnly = true;
            thiaminB1DataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            thiaminB1DataGridViewTextBoxColumn.Width = 67;
            // 
            // potassiumKDataGridViewTextBoxColumn
            // 
            potassiumKDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            potassiumKDataGridViewTextBoxColumn.DataPropertyName = "PotassiumK";
            dataGridViewCellStyle46.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle46.Format = "N0";
            dataGridViewCellStyle46.NullValue = "0";
            potassiumKDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle46;
            potassiumKDataGridViewTextBoxColumn.HeaderText = "Potassium K (mg)";
            potassiumKDataGridViewTextBoxColumn.MinimumWidth = 6;
            potassiumKDataGridViewTextBoxColumn.Name = "potassiumKDataGridViewTextBoxColumn";
            potassiumKDataGridViewTextBoxColumn.ReadOnly = true;
            potassiumKDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            potassiumKDataGridViewTextBoxColumn.Width = 72;
            // 
            // calciumCaDataGridViewTextBoxColumn
            // 
            calciumCaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            calciumCaDataGridViewTextBoxColumn.DataPropertyName = "CalciumCa";
            dataGridViewCellStyle45.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle45.Format = "N0";
            dataGridViewCellStyle45.NullValue = "0";
            calciumCaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle45;
            calciumCaDataGridViewTextBoxColumn.HeaderText = "Calcium Ca (mg)";
            calciumCaDataGridViewTextBoxColumn.MinimumWidth = 6;
            calciumCaDataGridViewTextBoxColumn.Name = "calciumCaDataGridViewTextBoxColumn";
            calciumCaDataGridViewTextBoxColumn.ReadOnly = true;
            calciumCaDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            calciumCaDataGridViewTextBoxColumn.Width = 68;
            // 
            // sodiumNaDataGridViewTextBoxColumn
            // 
            sodiumNaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sodiumNaDataGridViewTextBoxColumn.DataPropertyName = "SodiumNa";
            dataGridViewCellStyle44.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle44.Format = "N0";
            dataGridViewCellStyle44.NullValue = "0";
            sodiumNaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle44;
            sodiumNaDataGridViewTextBoxColumn.HeaderText = "Sodium Na (mg)";
            sodiumNaDataGridViewTextBoxColumn.MinimumWidth = 6;
            sodiumNaDataGridViewTextBoxColumn.Name = "sodiumNaDataGridViewTextBoxColumn";
            sodiumNaDataGridViewTextBoxColumn.ReadOnly = true;
            sodiumNaDataGridViewTextBoxColumn.Width = 86;
            // 
            // dietaryFibreDataGridViewTextBoxColumn
            // 
            dietaryFibreDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dietaryFibreDataGridViewTextBoxColumn.DataPropertyName = "DietaryFibre";
            dataGridViewCellStyle43.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle43.Format = "N1";
            dataGridViewCellStyle43.NullValue = "0";
            dietaryFibreDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle43;
            dietaryFibreDataGridViewTextBoxColumn.HeaderText = "Dietary Fibre (g)";
            dietaryFibreDataGridViewTextBoxColumn.MinimumWidth = 6;
            dietaryFibreDataGridViewTextBoxColumn.Name = "dietaryFibreDataGridViewTextBoxColumn";
            dietaryFibreDataGridViewTextBoxColumn.ReadOnly = true;
            dietaryFibreDataGridViewTextBoxColumn.Width = 92;
            // 
            // sugarsDataGridViewTextBoxColumn
            // 
            sugarsDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sugarsDataGridViewTextBoxColumn.DataPropertyName = "Sugars";
            dataGridViewCellStyle42.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle42.Format = "N1";
            dataGridViewCellStyle42.NullValue = "0";
            sugarsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle42;
            sugarsDataGridViewTextBoxColumn.HeaderText = "-Sugars (g)";
            sugarsDataGridViewTextBoxColumn.MinimumWidth = 6;
            sugarsDataGridViewTextBoxColumn.Name = "sugarsDataGridViewTextBoxColumn";
            sugarsDataGridViewTextBoxColumn.ReadOnly = true;
            sugarsDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            sugarsDataGridViewTextBoxColumn.Width = 63;
            // 
            // carbohydrateDataGridViewTextBoxColumn
            // 
            carbohydrateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            carbohydrateDataGridViewTextBoxColumn.DataPropertyName = "Carbohydrate";
            dataGridViewCellStyle41.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle41.Format = "N1";
            dataGridViewCellStyle41.NullValue = "0";
            carbohydrateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle41;
            carbohydrateDataGridViewTextBoxColumn.HeaderText = "Carbohydrate (g)";
            carbohydrateDataGridViewTextBoxColumn.MinimumWidth = 6;
            carbohydrateDataGridViewTextBoxColumn.Name = "carbohydrateDataGridViewTextBoxColumn";
            carbohydrateDataGridViewTextBoxColumn.ReadOnly = true;
            carbohydrateDataGridViewTextBoxColumn.Width = 111;
            // 
            // monounsaturatedFatDataGridViewTextBoxColumn
            // 
            monounsaturatedFatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            monounsaturatedFatDataGridViewTextBoxColumn.DataPropertyName = "MonounsaturatedFat";
            dataGridViewCellStyle40.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle40.Format = "N1";
            dataGridViewCellStyle40.NullValue = "0";
            monounsaturatedFatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle40;
            monounsaturatedFatDataGridViewTextBoxColumn.HeaderText = "-Monounsaturated Fat (g)";
            monounsaturatedFatDataGridViewTextBoxColumn.MinimumWidth = 6;
            monounsaturatedFatDataGridViewTextBoxColumn.Name = "monounsaturatedFatDataGridViewTextBoxColumn";
            monounsaturatedFatDataGridViewTextBoxColumn.ReadOnly = true;
            monounsaturatedFatDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            monounsaturatedFatDataGridViewTextBoxColumn.Width = 121;
            // 
            // polyunsaturatedFatDataGridViewTextBoxColumn
            // 
            polyunsaturatedFatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            polyunsaturatedFatDataGridViewTextBoxColumn.DataPropertyName = "PolyunsaturatedFat";
            dataGridViewCellStyle39.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle39.Format = "N1";
            dataGridViewCellStyle39.NullValue = "0";
            polyunsaturatedFatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle39;
            polyunsaturatedFatDataGridViewTextBoxColumn.HeaderText = "-Polyunsaturated Fat (g)";
            polyunsaturatedFatDataGridViewTextBoxColumn.MinimumWidth = 6;
            polyunsaturatedFatDataGridViewTextBoxColumn.Name = "polyunsaturatedFatDataGridViewTextBoxColumn";
            polyunsaturatedFatDataGridViewTextBoxColumn.ReadOnly = true;
            polyunsaturatedFatDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            polyunsaturatedFatDataGridViewTextBoxColumn.Width = 113;
            // 
            // transFatDataGridViewTextBoxColumn
            // 
            transFatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            transFatDataGridViewTextBoxColumn.DataPropertyName = "TransFat";
            dataGridViewCellStyle38.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle38.Format = "N1";
            dataGridViewCellStyle38.NullValue = "0";
            transFatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle38;
            transFatDataGridViewTextBoxColumn.HeaderText = "-Trans Fat (mg)";
            transFatDataGridViewTextBoxColumn.MinimumWidth = 6;
            transFatDataGridViewTextBoxColumn.Name = "transFatDataGridViewTextBoxColumn";
            transFatDataGridViewTextBoxColumn.ReadOnly = true;
            transFatDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            transFatDataGridViewTextBoxColumn.Width = 59;
            // 
            // saturatedFatDataGridViewTextBoxColumn
            // 
            saturatedFatDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            saturatedFatDataGridViewTextBoxColumn.DataPropertyName = "SaturatedFat";
            dataGridViewCellStyle37.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle37.Format = "N1";
            dataGridViewCellStyle37.NullValue = "0";
            dataGridViewCellStyle37.WrapMode = DataGridViewTriState.True;
            saturatedFatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle37;
            saturatedFatDataGridViewTextBoxColumn.HeaderText = "-Saturated Fat (g)";
            saturatedFatDataGridViewTextBoxColumn.MinimumWidth = 6;
            saturatedFatDataGridViewTextBoxColumn.Name = "saturatedFatDataGridViewTextBoxColumn";
            saturatedFatDataGridViewTextBoxColumn.ReadOnly = true;
            saturatedFatDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            saturatedFatDataGridViewTextBoxColumn.Width = 80;
            // 
            // fatTotalDataGridViewTextBoxColumn
            // 
            fatTotalDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            fatTotalDataGridViewTextBoxColumn.DataPropertyName = "FatTotal";
            dataGridViewCellStyle36.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle36.Format = "N1";
            dataGridViewCellStyle36.NullValue = "0";
            fatTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle36;
            fatTotalDataGridViewTextBoxColumn.HeaderText = "Fat Total (g)";
            fatTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            fatTotalDataGridViewTextBoxColumn.Name = "fatTotalDataGridViewTextBoxColumn";
            fatTotalDataGridViewTextBoxColumn.ReadOnly = true;
            fatTotalDataGridViewTextBoxColumn.Width = 86;
            // 
            // proteinDataGridViewTextBoxColumn
            // 
            proteinDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            proteinDataGridViewTextBoxColumn.DataPropertyName = "Protein";
            dataGridViewCellStyle35.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle35.Format = "N1";
            dataGridViewCellStyle35.NullValue = "0";
            proteinDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle35;
            proteinDataGridViewTextBoxColumn.HeaderText = "Protein (g)";
            proteinDataGridViewTextBoxColumn.MinimumWidth = 6;
            proteinDataGridViewTextBoxColumn.Name = "proteinDataGridViewTextBoxColumn";
            proteinDataGridViewTextBoxColumn.ReadOnly = true;
            proteinDataGridViewTextBoxColumn.Width = 80;
            // 
            // energyDataGridViewTextBoxColumn
            // 
            energyDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            energyDataGridViewTextBoxColumn.DataPropertyName = "Energy";
            dataGridViewCellStyle34.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle34.Format = "N1";
            dataGridViewCellStyle34.NullValue = "0";
            energyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle34;
            energyDataGridViewTextBoxColumn.HeaderText = "Energy (kJ)";
            energyDataGridViewTextBoxColumn.MinimumWidth = 8;
            energyDataGridViewTextBoxColumn.Name = "energyDataGridViewTextBoxColumn";
            energyDataGridViewTextBoxColumn.ReadOnly = true;
            energyDataGridViewTextBoxColumn.Width = 81;
            // 
            // foodDescriptionDataGridViewTextBoxColumn
            // 
            foodDescriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            foodDescriptionDataGridViewTextBoxColumn.DataPropertyName = "FoodDescription";
            dataGridViewCellStyle33.Alignment = DataGridViewContentAlignment.MiddleLeft;
            foodDescriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle33;
            foodDescriptionDataGridViewTextBoxColumn.HeaderText = "Food description";
            foodDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            foodDescriptionDataGridViewTextBoxColumn.Name = "foodDescriptionDataGridViewTextBoxColumn";
            foodDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            foodDescriptionDataGridViewTextBoxColumn.Width = 110;
            // 
            // FoodIdDataGridViewTextBoxColumn
            // 
            FoodIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            FoodIdDataGridViewTextBoxColumn.DataPropertyName = "FoodId";
            dataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle32.Format = "N0";
            dataGridViewCellStyle32.NullValue = "0";
            FoodIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle32;
            FoodIdDataGridViewTextBoxColumn.HeaderText = "Id";
            FoodIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            FoodIdDataGridViewTextBoxColumn.Name = "FoodIdDataGridViewTextBoxColumn";
            FoodIdDataGridViewTextBoxColumn.ReadOnly = true;
            FoodIdDataGridViewTextBoxColumn.ToolTipText = "TEST";
            FoodIdDataGridViewTextBoxColumn.Width = 41;
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
            textBoxFilter.Enter += TextBoxFilter_Enter;
            textBoxFilter.KeyDown += TextBoxFilter_KeyDown;
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
            checkBoxMainFoodCols.UseVisualStyleBackColor = true;
            checkBoxMainFoodCols.CheckedChanged += CheckBoxMainFoodCols_CheckedChanged;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(288, 19);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(0, 15);
            labelInfo.TabIndex = 9;
            // 
            // tabControlMain
            // 
            tabControlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlMain.Controls.Add(tabPageFood);
            tabControlMain.Controls.Add(tabPageEaten);
            tabControlMain.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Multiline = true;
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1418, 785);
            tabControlMain.TabIndex = 1;
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
            Text = "Diet Sentry 2.0";
            TransparencyKey = Color.Lime;
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)foodBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)eatenBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).EndInit();
            tabPageEaten.ResumeLayout(false);
            tabPageEaten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEaten).EndInit();
            tabPageFood.ResumeLayout(false);
            tabPageFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFoods).EndInit();
            tabControlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private BindingSource eatenBindingSource;
        public BindingSource foodBindingSource;
        private BindingSource recipeBindingSource;
        private System.Windows.Forms.Timer aTimer;
        private TabPage tabPageEaten;
        private DateTimePicker dateTimePickerEaten;
        private CheckBox checkBoxMainCols;
        private CheckBox checkBoxDailyTotals;
        private CheckBox checkBoxDateFilter;
        private DataGridView dataGridViewEaten;
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
        private TabPage tabPageFood;
        private Label labelInfo;
        private CheckBox checkBoxMainFoodCols;
        private Label labelFilter;
        private TextBox textBoxFilter;
        private DataGridView dataGridViewFoods;
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
        private TabControl tabControlMain;
    }
}