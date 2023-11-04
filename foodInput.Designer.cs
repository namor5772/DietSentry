namespace DietSentry
{
    partial class FoodInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        // flag to prevent recreation of recipe record
        public Boolean recordExists = false;

        // Id of created recipe's record 
        public int recordID = 0;

        /* flags whether any pre close form actions have already been performed,
         * so that they are not repeated when the {x} button is pressed */
        public Boolean actOnClose = true;

        /* A variable  which stores data collected from the FoodInputForm
         * in grams (g), since mL measured foods not accepted n*/
        public float amountOfFoodInRecipe = 0.0F; // in grams (g), since mL measured foods not accepted

        // A string describing the eaten food selected
        public string FoodDescriptionRecipe = "BLANK";

        // *********************************************************



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            groupBoxFoodTypes = new GroupBox();
            radioButtonRecipie = new RadioButton();
            radioButtonLiquid = new RadioButton();
            radioButtonSolid = new RadioButton();
            labelHelpAddEditFood = new Label();
            buttonAddFood = new Button();
            buttonCancelAddFood = new Button();
            labelState = new Label();
            tabControlAddType = new TabControl();
            tabPageRecipie = new TabPage();
            labelHelpAddEditIngredients = new Label();
            labelHelpAddEditDescription = new Label();
            labelHelpAddEditIngredient = new Label();
            labelHelpAddEditFilter = new Label();
            labelHelpAddEditRecipe = new Label();
            labelIngredients = new Label();
            dataGridViewRecipe = new DataGridView();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Energy = new DataGridViewTextBoxColumn();
            FatTotal = new DataGridViewTextBoxColumn();
            DietaryFibre = new DataGridViewTextBoxColumn();
            foodDescriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            recipeBindingSource = new BindingSource(components);
            labelFilterRecipe = new Label();
            textBoxFilterRecipe = new TextBox();
            dataGridViewAddToRecipe = new DataGridView();
            foodDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            foodBindingSource = new BindingSource(components);
            textBoxRecipeFoodDescription = new TextBox();
            labelRecipeFoodDescription = new Label();
            tabPageNonRecipie = new TabPage();
            labelHelpAddEditNonRecipe = new Label();
            textBoxAlcohol = new TextBox();
            labelAlcohol = new Label();
            textBoxCholesterol = new TextBox();
            labelCholesterol = new Label();
            textBoxCaffeine = new TextBox();
            labelCaffeine = new Label();
            textBoxVitaminC = new TextBox();
            labelVitaminC = new Label();
            textBoxMagnesiumMg = new TextBox();
            labelMagnesiumMg = new Label();
            textBoxIronFe = new TextBox();
            labelIronFe = new Label();
            textBoxFolate = new TextBox();
            labelFolate = new Label();
            textBoxNiacinB3 = new TextBox();
            labelNiacinB3 = new Label();
            textBoxRiboflavinB2 = new TextBox();
            labelRiboflavinB2 = new Label();
            textBoxThiaminB1 = new TextBox();
            labelThiaminB1 = new Label();
            textBoxPotassiumK = new TextBox();
            labelPotassiumK = new Label();
            textBoxCalciumCa = new TextBox();
            labelCalciumCa = new Label();
            textBoxSodiumNa = new TextBox();
            labelSodiumNa = new Label();
            textBoxDietaryFibre = new TextBox();
            labelDietaryFibre = new Label();
            textBoxSugars = new TextBox();
            labelSugars = new Label();
            textBoxCarbohydrate = new TextBox();
            labelCarbohydrate = new Label();
            textBoxMonounsaturatedFat = new TextBox();
            labelMonounsaturatedFat = new Label();
            textBoxPolyunsaturatedFat = new TextBox();
            labelPolyunsaturatedFat = new Label();
            textBoxTransFat = new TextBox();
            labelTransFat = new Label();
            textBoxSaturatedFat = new TextBox();
            labelSaturatedFat = new Label();
            textBoxFatTotal = new TextBox();
            labelFatTotal = new Label();
            textBoxProtein = new TextBox();
            textBoxEnergy = new TextBox();
            textBoxFoodDescription = new TextBox();
            labelProtein = new Label();
            labelEnergy = new Label();
            labelFoodDescription = new Label();
            groupBoxFoodTypes.SuspendLayout();
            tabControlAddType.SuspendLayout();
            tabPageRecipie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddToRecipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foodBindingSource).BeginInit();
            tabPageNonRecipie.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxFoodTypes
            // 
            groupBoxFoodTypes.Controls.Add(radioButtonRecipie);
            groupBoxFoodTypes.Controls.Add(radioButtonLiquid);
            groupBoxFoodTypes.Controls.Add(radioButtonSolid);
            groupBoxFoodTypes.Location = new Point(21, 3);
            groupBoxFoodTypes.Name = "groupBoxFoodTypes";
            groupBoxFoodTypes.Size = new Size(215, 55);
            groupBoxFoodTypes.TabIndex = 27;
            groupBoxFoodTypes.TabStop = false;
            groupBoxFoodTypes.Text = "Select type";
            // 
            // radioButtonRecipie
            // 
            radioButtonRecipie.AutoSize = true;
            radioButtonRecipie.Location = new Point(141, 23);
            radioButtonRecipie.Name = "radioButtonRecipie";
            radioButtonRecipie.Size = new Size(60, 19);
            radioButtonRecipie.TabIndex = 29;
            radioButtonRecipie.Text = "Recipe";
            radioButtonRecipie.UseVisualStyleBackColor = true;
            radioButtonRecipie.CheckedChanged += RadioButtonRecipie_CheckedChanged;
            // 
            // radioButtonLiquid
            // 
            radioButtonLiquid.AutoSize = true;
            radioButtonLiquid.Location = new Point(73, 23);
            radioButtonLiquid.Name = "radioButtonLiquid";
            radioButtonLiquid.Size = new Size(58, 19);
            radioButtonLiquid.TabIndex = 28;
            radioButtonLiquid.Text = "Liquid";
            radioButtonLiquid.UseVisualStyleBackColor = true;
            radioButtonLiquid.CheckedChanged += RadioButtonLiquid_CheckedChanged;
            // 
            // radioButtonSolid
            // 
            radioButtonSolid.AutoSize = true;
            radioButtonSolid.Checked = true;
            radioButtonSolid.Location = new Point(10, 23);
            radioButtonSolid.Name = "radioButtonSolid";
            radioButtonSolid.Size = new Size(51, 19);
            radioButtonSolid.TabIndex = 27;
            radioButtonSolid.TabStop = true;
            radioButtonSolid.Text = "Solid";
            radioButtonSolid.UseVisualStyleBackColor = true;
            radioButtonSolid.CheckedChanged += RadioButtonSolid_CheckedChanged;
            // 
            // labelHelpAddEditFood
            // 
            labelHelpAddEditFood.BackColor = Color.YellowGreen;
            labelHelpAddEditFood.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelHelpAddEditFood.ForeColor = SystemColors.ButtonHighlight;
            labelHelpAddEditFood.Location = new Point(4, 3);
            labelHelpAddEditFood.Name = "labelHelpAddEditFood";
            labelHelpAddEditFood.Size = new Size(14, 15);
            labelHelpAddEditFood.TabIndex = 0;
            labelHelpAddEditFood.Text = "?";
            labelHelpAddEditFood.MouseHover += LabelHelpAddEditFood_MouseHover;
            // 
            // buttonAddFood
            // 
            buttonAddFood.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddFood.Location = new Point(208, 741);
            buttonAddFood.Name = "buttonAddFood";
            buttonAddFood.Size = new Size(75, 34);
            buttonAddFood.TabIndex = 25;
            buttonAddFood.Text = "Add food";
            buttonAddFood.UseVisualStyleBackColor = true;
            buttonAddFood.Click += ButtonAddFood_Click;
            // 
            // buttonCancelAddFood
            // 
            buttonCancelAddFood.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCancelAddFood.Location = new Point(306, 741);
            buttonCancelAddFood.Name = "buttonCancelAddFood";
            buttonCancelAddFood.Size = new Size(75, 34);
            buttonCancelAddFood.TabIndex = 26;
            buttonCancelAddFood.Text = "Cancel";
            buttonCancelAddFood.UseVisualStyleBackColor = true;
            buttonCancelAddFood.Click += ButtonCancelAddFood_Click;
            // 
            // labelState
            // 
            labelState.AutoSize = true;
            labelState.Location = new Point(267, 28);
            labelState.Name = "labelState";
            labelState.Size = new Size(216, 15);
            labelState.TabIndex = 0;
            labelState.Text = "Nutrition information per 100 grams (g)";
            // 
            // tabControlAddType
            // 
            tabControlAddType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabControlAddType.Controls.Add(tabPageRecipie);
            tabControlAddType.Controls.Add(tabPageNonRecipie);
            tabControlAddType.ItemSize = new Size(0, 1);
            tabControlAddType.Location = new Point(0, 50);
            tabControlAddType.Margin = new Padding(0);
            tabControlAddType.Name = "tabControlAddType";
            tabControlAddType.Padding = new Point(0, 0);
            tabControlAddType.SelectedIndex = 0;
            tabControlAddType.Size = new Size(1420, 688);
            tabControlAddType.SizeMode = TabSizeMode.Fixed;
            tabControlAddType.TabIndex = 5;
            tabControlAddType.TabStop = false;
            // 
            // tabPageRecipie
            // 
            tabPageRecipie.BackColor = SystemColors.ControlLight;
            tabPageRecipie.Controls.Add(labelHelpAddEditIngredients);
            tabPageRecipie.Controls.Add(labelHelpAddEditDescription);
            tabPageRecipie.Controls.Add(labelHelpAddEditIngredient);
            tabPageRecipie.Controls.Add(labelHelpAddEditFilter);
            tabPageRecipie.Controls.Add(labelHelpAddEditRecipe);
            tabPageRecipie.Controls.Add(labelIngredients);
            tabPageRecipie.Controls.Add(dataGridViewRecipe);
            tabPageRecipie.Controls.Add(labelFilterRecipe);
            tabPageRecipie.Controls.Add(textBoxFilterRecipe);
            tabPageRecipie.Controls.Add(dataGridViewAddToRecipe);
            tabPageRecipie.Controls.Add(textBoxRecipeFoodDescription);
            tabPageRecipie.Controls.Add(labelRecipeFoodDescription);
            tabPageRecipie.Location = new Point(4, 5);
            tabPageRecipie.Margin = new Padding(0);
            tabPageRecipie.Name = "tabPageRecipie";
            tabPageRecipie.Size = new Size(1412, 679);
            tabPageRecipie.TabIndex = 1;
            tabPageRecipie.Text = "Add Recipie";
            tabPageRecipie.Enter += TabPageRecipie_Enter;
            // 
            // labelHelpAddEditIngredients
            // 
            labelHelpAddEditIngredients.BackColor = Color.YellowGreen;
            labelHelpAddEditIngredients.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelHelpAddEditIngredients.ForeColor = SystemColors.ButtonHighlight;
            labelHelpAddEditIngredients.Location = new Point(478, 78);
            labelHelpAddEditIngredients.Name = "labelHelpAddEditIngredients";
            labelHelpAddEditIngredients.Size = new Size(14, 15);
            labelHelpAddEditIngredients.TabIndex = 0;
            labelHelpAddEditIngredients.Text = "?";
            labelHelpAddEditIngredients.MouseHover += LabelHelpAddEditIngredients_MouseHover;
            // 
            // labelHelpAddEditDescription
            // 
            labelHelpAddEditDescription.BackColor = Color.YellowGreen;
            labelHelpAddEditDescription.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelHelpAddEditDescription.ForeColor = SystemColors.ButtonHighlight;
            labelHelpAddEditDescription.Location = new Point(461, 26);
            labelHelpAddEditDescription.Name = "labelHelpAddEditDescription";
            labelHelpAddEditDescription.Size = new Size(14, 15);
            labelHelpAddEditDescription.TabIndex = 0;
            labelHelpAddEditDescription.Text = "?";
            labelHelpAddEditDescription.MouseHover += LabelHelpAddEditDescription_MouseHover;
            // 
            // labelHelpAddEditIngredient
            // 
            labelHelpAddEditIngredient.BackColor = Color.YellowGreen;
            labelHelpAddEditIngredient.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelHelpAddEditIngredient.ForeColor = SystemColors.ButtonHighlight;
            labelHelpAddEditIngredient.Location = new Point(8, 78);
            labelHelpAddEditIngredient.Name = "labelHelpAddEditIngredient";
            labelHelpAddEditIngredient.Size = new Size(14, 15);
            labelHelpAddEditIngredient.TabIndex = 0;
            labelHelpAddEditIngredient.Text = "?";
            labelHelpAddEditIngredient.MouseHover += LabelHelpAddEditIngredient_MouseHover;
            // 
            // labelHelpAddEditFilter
            // 
            labelHelpAddEditFilter.BackColor = Color.YellowGreen;
            labelHelpAddEditFilter.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelHelpAddEditFilter.ForeColor = SystemColors.ButtonHighlight;
            labelHelpAddEditFilter.Location = new Point(7, 26);
            labelHelpAddEditFilter.Name = "labelHelpAddEditFilter";
            labelHelpAddEditFilter.Size = new Size(14, 15);
            labelHelpAddEditFilter.TabIndex = 0;
            labelHelpAddEditFilter.Text = "?";
            labelHelpAddEditFilter.MouseHover += LabelHelpAddEditFilter_MouseHover;
            // 
            // labelHelpAddEditRecipe
            // 
            labelHelpAddEditRecipe.BackColor = Color.YellowGreen;
            labelHelpAddEditRecipe.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelHelpAddEditRecipe.ForeColor = SystemColors.ButtonHighlight;
            labelHelpAddEditRecipe.Location = new Point(0, 0);
            labelHelpAddEditRecipe.Name = "labelHelpAddEditRecipe";
            labelHelpAddEditRecipe.Size = new Size(14, 15);
            labelHelpAddEditRecipe.TabIndex = 0;
            labelHelpAddEditRecipe.Text = "?";
            labelHelpAddEditRecipe.MouseHover += LabelHelpAddEditRecipe_MouseHover;
            // 
            // labelIngredients
            // 
            labelIngredients.AutoSize = true;
            labelIngredients.Location = new Point(478, 60);
            labelIngredients.Name = "labelIngredients";
            labelIngredients.Size = new Size(66, 15);
            labelIngredients.TabIndex = 0;
            labelIngredients.Text = "Ingredients";
            // 
            // dataGridViewRecipe
            // 
            dataGridViewRecipe.AllowUserToAddRows = false;
            dataGridViewRecipe.AllowUserToResizeColumns = false;
            dataGridViewRecipe.AllowUserToResizeRows = false;
            dataGridViewRecipe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewRecipe.AutoGenerateColumns = false;
            dataGridViewRecipe.BorderStyle = BorderStyle.None;
            dataGridViewRecipe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Azure;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Azure;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewRecipe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewRecipe.ColumnHeadersHeight = 28;
            dataGridViewRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewRecipe.Columns.AddRange(new DataGridViewColumn[] { amountDataGridViewTextBoxColumn, Energy, FatTotal, DietaryFibre, foodDescriptionDataGridViewTextBoxColumn1 });
            dataGridViewRecipe.DataSource = recipeBindingSource;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridViewRecipe.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewRecipe.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridViewRecipe.EnableHeadersVisualStyles = false;
            dataGridViewRecipe.Location = new Point(478, 78);
            dataGridViewRecipe.MultiSelect = false;
            dataGridViewRecipe.Name = "dataGridViewRecipe";
            dataGridViewRecipe.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewRecipe.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewRecipe.RowHeadersVisible = false;
            dataGridViewRecipe.RowHeadersWidth = 62;
            dataGridViewRecipe.RowTemplate.Height = 25;
            dataGridViewRecipe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRecipe.Size = new Size(926, 590);
            dataGridViewRecipe.StandardTab = true;
            dataGridViewRecipe.TabIndex = 4;
            dataGridViewRecipe.UserDeletingRow += DataGridViewRecipe_UserDeletingRow;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            amountDataGridViewTextBoxColumn.HeaderText = "    Amount (g)";
            amountDataGridViewTextBoxColumn.MinimumWidth = 8;
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            amountDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            amountDataGridViewTextBoxColumn.Width = 105;
            // 
            // Energy
            // 
            Energy.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Energy.DataPropertyName = "Energy";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            Energy.DefaultCellStyle = dataGridViewCellStyle3;
            Energy.HeaderText = "Energy (kJ)";
            Energy.Name = "Energy";
            Energy.ReadOnly = true;
            Energy.Width = 88;
            // 
            // FatTotal
            // 
            FatTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            FatTotal.DataPropertyName = "FatTotal";
            dataGridViewCellStyle4.Format = "N1";
            dataGridViewCellStyle4.NullValue = "0";
            FatTotal.DefaultCellStyle = dataGridViewCellStyle4;
            FatTotal.HeaderText = "Fat (g)";
            FatTotal.Name = "FatTotal";
            FatTotal.ReadOnly = true;
            FatTotal.Width = 65;
            // 
            // DietaryFibre
            // 
            DietaryFibre.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DietaryFibre.DataPropertyName = "DietaryFibre";
            dataGridViewCellStyle5.Format = "N1";
            dataGridViewCellStyle5.NullValue = "0";
            DietaryFibre.DefaultCellStyle = dataGridViewCellStyle5;
            DietaryFibre.HeaderText = "Fibre (g)";
            DietaryFibre.Name = "DietaryFibre";
            DietaryFibre.ReadOnly = true;
            DietaryFibre.Width = 75;
            // 
            // foodDescriptionDataGridViewTextBoxColumn1
            // 
            foodDescriptionDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foodDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "FoodDescription";
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            foodDescriptionDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            foodDescriptionDataGridViewTextBoxColumn1.HeaderText = "Food description";
            foodDescriptionDataGridViewTextBoxColumn1.MinimumWidth = 8;
            foodDescriptionDataGridViewTextBoxColumn1.Name = "foodDescriptionDataGridViewTextBoxColumn1";
            foodDescriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            foodDescriptionDataGridViewTextBoxColumn1.ToolTipText = "Hello world";
            // 
            // recipeBindingSource
            // 
            recipeBindingSource.DataSource = typeof(Recipe);
            // 
            // labelFilterRecipe
            // 
            labelFilterRecipe.AutoSize = true;
            labelFilterRecipe.BackColor = Color.LightCyan;
            labelFilterRecipe.Location = new Point(173, 26);
            labelFilterRecipe.Name = "labelFilterRecipe";
            labelFilterRecipe.Size = new Size(59, 15);
            labelFilterRecipe.TabIndex = 0;
            labelFilterRecipe.Text = "Unfiltered";
            // 
            // textBoxFilterRecipe
            // 
            textBoxFilterRecipe.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxFilterRecipe.AutoCompleteSource = AutoCompleteSource.HistoryList;
            textBoxFilterRecipe.Location = new Point(28, 23);
            textBoxFilterRecipe.Name = "textBoxFilterRecipe";
            textBoxFilterRecipe.PlaceholderText = "Enter food filter text";
            textBoxFilterRecipe.Size = new Size(135, 23);
            textBoxFilterRecipe.TabIndex = 2;
            textBoxFilterRecipe.WordWrap = false;
            textBoxFilterRecipe.KeyDown += TextBoxFilterRecipe_KeyDown;
            // 
            // dataGridViewAddToRecipe
            // 
            dataGridViewAddToRecipe.AllowUserToAddRows = false;
            dataGridViewAddToRecipe.AllowUserToDeleteRows = false;
            dataGridViewAddToRecipe.AllowUserToResizeColumns = false;
            dataGridViewAddToRecipe.AllowUserToResizeRows = false;
            dataGridViewAddToRecipe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewAddToRecipe.AutoGenerateColumns = false;
            dataGridViewAddToRecipe.BorderStyle = BorderStyle.None;
            dataGridViewAddToRecipe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.Azure;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridViewAddToRecipe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewAddToRecipe.ColumnHeadersHeight = 28;
            dataGridViewAddToRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewAddToRecipe.Columns.AddRange(new DataGridViewColumn[] { foodDescriptionDataGridViewTextBoxColumn });
            dataGridViewAddToRecipe.DataSource = foodBindingSource;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Info;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridViewAddToRecipe.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewAddToRecipe.EnableHeadersVisualStyles = false;
            dataGridViewAddToRecipe.Location = new Point(8, 78);
            dataGridViewAddToRecipe.Margin = new Padding(0);
            dataGridViewAddToRecipe.MultiSelect = false;
            dataGridViewAddToRecipe.Name = "dataGridViewAddToRecipe";
            dataGridViewAddToRecipe.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridViewAddToRecipe.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewAddToRecipe.RowHeadersVisible = false;
            dataGridViewAddToRecipe.RowHeadersWidth = 62;
            dataGridViewAddToRecipe.RowTemplate.Height = 25;
            dataGridViewAddToRecipe.ScrollBars = ScrollBars.Vertical;
            dataGridViewAddToRecipe.ShowCellErrors = false;
            dataGridViewAddToRecipe.ShowEditingIcon = false;
            dataGridViewAddToRecipe.ShowRowErrors = false;
            dataGridViewAddToRecipe.Size = new Size(444, 590);
            dataGridViewAddToRecipe.StandardTab = true;
            dataGridViewAddToRecipe.TabIndex = 3;
            dataGridViewAddToRecipe.CellDoubleClick += DataGridViewAddToRecipe_CellDoubleClick;
            dataGridViewAddToRecipe.KeyDown += DataGridViewAddToRecipe_KeyDown;
            // 
            // foodDescriptionDataGridViewTextBoxColumn
            // 
            foodDescriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foodDescriptionDataGridViewTextBoxColumn.DataPropertyName = "FoodDescription";
            foodDescriptionDataGridViewTextBoxColumn.HeaderText = "          Select food for recipe";
            foodDescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            foodDescriptionDataGridViewTextBoxColumn.Name = "foodDescriptionDataGridViewTextBoxColumn";
            foodDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            foodDescriptionDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            // 
            // foodBindingSource
            // 
            foodBindingSource.DataSource = typeof(Food);
            // 
            // textBoxRecipeFoodDescription
            // 
            textBoxRecipeFoodDescription.Location = new Point(559, 23);
            textBoxRecipeFoodDescription.Name = "textBoxRecipeFoodDescription";
            textBoxRecipeFoodDescription.Size = new Size(845, 23);
            textBoxRecipeFoodDescription.TabIndex = 1;
            textBoxRecipeFoodDescription.KeyDown += TextBoxRecipeFoodDescription_KeyDown;
            textBoxRecipeFoodDescription.Leave += TextBoxRecipeFoodDescription_Leave;
            // 
            // labelRecipeFoodDescription
            // 
            labelRecipeFoodDescription.AutoSize = true;
            labelRecipeFoodDescription.Location = new Point(478, 26);
            labelRecipeFoodDescription.Name = "labelRecipeFoodDescription";
            labelRecipeFoodDescription.Size = new Size(67, 15);
            labelRecipeFoodDescription.TabIndex = 0;
            labelRecipeFoodDescription.Text = "Description";
            // 
            // tabPageNonRecipie
            // 
            tabPageNonRecipie.BackColor = SystemColors.ControlLight;
            tabPageNonRecipie.Controls.Add(labelHelpAddEditNonRecipe);
            tabPageNonRecipie.Controls.Add(textBoxAlcohol);
            tabPageNonRecipie.Controls.Add(labelAlcohol);
            tabPageNonRecipie.Controls.Add(textBoxCholesterol);
            tabPageNonRecipie.Controls.Add(labelCholesterol);
            tabPageNonRecipie.Controls.Add(textBoxCaffeine);
            tabPageNonRecipie.Controls.Add(labelCaffeine);
            tabPageNonRecipie.Controls.Add(textBoxVitaminC);
            tabPageNonRecipie.Controls.Add(labelVitaminC);
            tabPageNonRecipie.Controls.Add(textBoxMagnesiumMg);
            tabPageNonRecipie.Controls.Add(labelMagnesiumMg);
            tabPageNonRecipie.Controls.Add(textBoxIronFe);
            tabPageNonRecipie.Controls.Add(labelIronFe);
            tabPageNonRecipie.Controls.Add(textBoxFolate);
            tabPageNonRecipie.Controls.Add(labelFolate);
            tabPageNonRecipie.Controls.Add(textBoxNiacinB3);
            tabPageNonRecipie.Controls.Add(labelNiacinB3);
            tabPageNonRecipie.Controls.Add(textBoxRiboflavinB2);
            tabPageNonRecipie.Controls.Add(labelRiboflavinB2);
            tabPageNonRecipie.Controls.Add(textBoxThiaminB1);
            tabPageNonRecipie.Controls.Add(labelThiaminB1);
            tabPageNonRecipie.Controls.Add(textBoxPotassiumK);
            tabPageNonRecipie.Controls.Add(labelPotassiumK);
            tabPageNonRecipie.Controls.Add(textBoxCalciumCa);
            tabPageNonRecipie.Controls.Add(labelCalciumCa);
            tabPageNonRecipie.Controls.Add(textBoxSodiumNa);
            tabPageNonRecipie.Controls.Add(labelSodiumNa);
            tabPageNonRecipie.Controls.Add(textBoxDietaryFibre);
            tabPageNonRecipie.Controls.Add(labelDietaryFibre);
            tabPageNonRecipie.Controls.Add(textBoxSugars);
            tabPageNonRecipie.Controls.Add(labelSugars);
            tabPageNonRecipie.Controls.Add(textBoxCarbohydrate);
            tabPageNonRecipie.Controls.Add(labelCarbohydrate);
            tabPageNonRecipie.Controls.Add(textBoxMonounsaturatedFat);
            tabPageNonRecipie.Controls.Add(labelMonounsaturatedFat);
            tabPageNonRecipie.Controls.Add(textBoxPolyunsaturatedFat);
            tabPageNonRecipie.Controls.Add(labelPolyunsaturatedFat);
            tabPageNonRecipie.Controls.Add(textBoxTransFat);
            tabPageNonRecipie.Controls.Add(labelTransFat);
            tabPageNonRecipie.Controls.Add(textBoxSaturatedFat);
            tabPageNonRecipie.Controls.Add(labelSaturatedFat);
            tabPageNonRecipie.Controls.Add(textBoxFatTotal);
            tabPageNonRecipie.Controls.Add(labelFatTotal);
            tabPageNonRecipie.Controls.Add(textBoxProtein);
            tabPageNonRecipie.Controls.Add(textBoxEnergy);
            tabPageNonRecipie.Controls.Add(textBoxFoodDescription);
            tabPageNonRecipie.Controls.Add(labelProtein);
            tabPageNonRecipie.Controls.Add(labelEnergy);
            tabPageNonRecipie.Controls.Add(labelFoodDescription);
            tabPageNonRecipie.Location = new Point(4, 5);
            tabPageNonRecipie.Margin = new Padding(0);
            tabPageNonRecipie.Name = "tabPageNonRecipie";
            tabPageNonRecipie.Size = new Size(1412, 679);
            tabPageNonRecipie.TabIndex = 0;
            tabPageNonRecipie.Text = "Add Non Recipie";
            tabPageNonRecipie.Click += tabPageNonRecipie_Click;
            // 
            // labelHelpAddEditNonRecipe
            // 
            labelHelpAddEditNonRecipe.BackColor = Color.YellowGreen;
            labelHelpAddEditNonRecipe.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelHelpAddEditNonRecipe.ForeColor = SystemColors.ButtonHighlight;
            labelHelpAddEditNonRecipe.Location = new Point(0, 0);
            labelHelpAddEditNonRecipe.Name = "labelHelpAddEditNonRecipe";
            labelHelpAddEditNonRecipe.Size = new Size(14, 15);
            labelHelpAddEditNonRecipe.TabIndex = 47;
            labelHelpAddEditNonRecipe.Text = "?";
            labelHelpAddEditNonRecipe.MouseHover += LabelHelpAddEditNonRecipe_MouseHover;
            // 
            // textBoxAlcohol
            // 
            textBoxAlcohol.Location = new Point(300, 638);
            textBoxAlcohol.Name = "textBoxAlcohol";
            textBoxAlcohol.Size = new Size(78, 23);
            textBoxAlcohol.TabIndex = 24;
            textBoxAlcohol.TextAlign = HorizontalAlignment.Right;
            textBoxAlcohol.KeyDown += TextBoxAlcohol_KeyDown;
            textBoxAlcohol.Leave += TextBoxAlcohol_Leave;
            // 
            // labelAlcohol
            // 
            labelAlcohol.AutoSize = true;
            labelAlcohol.Location = new Point(413, 641);
            labelAlcohol.Name = "labelAlcohol";
            labelAlcohol.Size = new Size(66, 15);
            labelAlcohol.TabIndex = 46;
            labelAlcohol.Text = "Alcohol (g)";
            // 
            // textBoxCholesterol
            // 
            textBoxCholesterol.Location = new Point(300, 611);
            textBoxCholesterol.Name = "textBoxCholesterol";
            textBoxCholesterol.Size = new Size(78, 23);
            textBoxCholesterol.TabIndex = 23;
            textBoxCholesterol.TextAlign = HorizontalAlignment.Right;
            textBoxCholesterol.KeyDown += TextBoxCholesterol_KeyDown;
            textBoxCholesterol.Leave += TextBoxCholesterol_Leave;
            // 
            // labelCholesterol
            // 
            labelCholesterol.AutoSize = true;
            labelCholesterol.Location = new Point(413, 614);
            labelCholesterol.Name = "labelCholesterol";
            labelCholesterol.Size = new Size(96, 15);
            labelCholesterol.TabIndex = 44;
            labelCholesterol.Text = "Cholesterol (mg)";
            // 
            // textBoxCaffeine
            // 
            textBoxCaffeine.Location = new Point(300, 584);
            textBoxCaffeine.Name = "textBoxCaffeine";
            textBoxCaffeine.Size = new Size(78, 23);
            textBoxCaffeine.TabIndex = 22;
            textBoxCaffeine.TextAlign = HorizontalAlignment.Right;
            textBoxCaffeine.KeyDown += TextBoxCaffeine_KeyDown;
            textBoxCaffeine.Leave += TextBoxCaffeine_Leave;
            // 
            // labelCaffeine
            // 
            labelCaffeine.AutoSize = true;
            labelCaffeine.Location = new Point(413, 587);
            labelCaffeine.Name = "labelCaffeine";
            labelCaffeine.Size = new Size(80, 15);
            labelCaffeine.TabIndex = 42;
            labelCaffeine.Text = "Caffeine (mg)";
            // 
            // textBoxVitaminC
            // 
            textBoxVitaminC.Location = new Point(300, 557);
            textBoxVitaminC.Name = "textBoxVitaminC";
            textBoxVitaminC.Size = new Size(78, 23);
            textBoxVitaminC.TabIndex = 21;
            textBoxVitaminC.TextAlign = HorizontalAlignment.Right;
            textBoxVitaminC.KeyDown += TextBoxVitaminC_KeyDown;
            textBoxVitaminC.Leave += TextBoxVitaminC_Leave;
            // 
            // labelVitaminC
            // 
            labelVitaminC.AutoSize = true;
            labelVitaminC.Location = new Point(413, 560);
            labelVitaminC.Name = "labelVitaminC";
            labelVitaminC.Size = new Size(88, 15);
            labelVitaminC.TabIndex = 40;
            labelVitaminC.Text = "Vitamin C (mg)";
            // 
            // textBoxMagnesiumMg
            // 
            textBoxMagnesiumMg.Location = new Point(300, 530);
            textBoxMagnesiumMg.Name = "textBoxMagnesiumMg";
            textBoxMagnesiumMg.Size = new Size(78, 23);
            textBoxMagnesiumMg.TabIndex = 20;
            textBoxMagnesiumMg.TextAlign = HorizontalAlignment.Right;
            textBoxMagnesiumMg.KeyDown += TextBoxMagnesiumMg_KeyDown;
            textBoxMagnesiumMg.Leave += TextBoxMagnesiumMg_Leave;
            // 
            // labelMagnesiumMg
            // 
            labelMagnesiumMg.AutoSize = true;
            labelMagnesiumMg.Location = new Point(413, 533);
            labelMagnesiumMg.Name = "labelMagnesiumMg";
            labelMagnesiumMg.Size = new Size(120, 15);
            labelMagnesiumMg.TabIndex = 38;
            labelMagnesiumMg.Text = "Magnesium Mg (mg)";
            // 
            // textBoxIronFe
            // 
            textBoxIronFe.Location = new Point(300, 503);
            textBoxIronFe.Name = "textBoxIronFe";
            textBoxIronFe.Size = new Size(78, 23);
            textBoxIronFe.TabIndex = 19;
            textBoxIronFe.TextAlign = HorizontalAlignment.Right;
            textBoxIronFe.KeyDown += TextBoxIronFe_KeyDown;
            textBoxIronFe.Leave += TextBoxIronFe_Leave;
            // 
            // labelIronFe
            // 
            labelIronFe.AutoSize = true;
            labelIronFe.Location = new Point(413, 506);
            labelIronFe.Name = "labelIronFe";
            labelIronFe.Size = new Size(72, 15);
            labelIronFe.TabIndex = 36;
            labelIronFe.Text = "Iron Fe (mg)";
            // 
            // textBoxFolate
            // 
            textBoxFolate.Location = new Point(300, 476);
            textBoxFolate.Name = "textBoxFolate";
            textBoxFolate.Size = new Size(78, 23);
            textBoxFolate.TabIndex = 18;
            textBoxFolate.TextAlign = HorizontalAlignment.Right;
            textBoxFolate.KeyDown += TextBoxFolate_KeyDown;
            textBoxFolate.Leave += TextBoxFolate_Leave;
            // 
            // labelFolate
            // 
            labelFolate.AutoSize = true;
            labelFolate.Location = new Point(413, 479);
            labelFolate.Name = "labelFolate";
            labelFolate.Size = new Size(64, 15);
            labelFolate.TabIndex = 34;
            labelFolate.Text = "Folate (ug)";
            // 
            // textBoxNiacinB3
            // 
            textBoxNiacinB3.Location = new Point(300, 449);
            textBoxNiacinB3.Name = "textBoxNiacinB3";
            textBoxNiacinB3.Size = new Size(78, 23);
            textBoxNiacinB3.TabIndex = 17;
            textBoxNiacinB3.TextAlign = HorizontalAlignment.Right;
            textBoxNiacinB3.KeyDown += TextBoxNiacinB3_KeyDown;
            textBoxNiacinB3.Leave += TextBoxNiacinB3_Leave;
            // 
            // labelNiacinB3
            // 
            labelNiacinB3.AutoSize = true;
            labelNiacinB3.Location = new Point(413, 452);
            labelNiacinB3.Name = "labelNiacinB3";
            labelNiacinB3.Size = new Size(86, 15);
            labelNiacinB3.TabIndex = 32;
            labelNiacinB3.Text = "Niacin B3 (mg)";
            // 
            // textBoxRiboflavinB2
            // 
            textBoxRiboflavinB2.Location = new Point(300, 422);
            textBoxRiboflavinB2.Name = "textBoxRiboflavinB2";
            textBoxRiboflavinB2.Size = new Size(78, 23);
            textBoxRiboflavinB2.TabIndex = 16;
            textBoxRiboflavinB2.TextAlign = HorizontalAlignment.Right;
            textBoxRiboflavinB2.KeyDown += TextBoxRiboflavinB2_KeyDown;
            textBoxRiboflavinB2.Leave += TextBoxRiboflavinB2_Leave;
            // 
            // labelRiboflavinB2
            // 
            labelRiboflavinB2.AutoSize = true;
            labelRiboflavinB2.Location = new Point(413, 425);
            labelRiboflavinB2.Name = "labelRiboflavinB2";
            labelRiboflavinB2.Size = new Size(105, 15);
            labelRiboflavinB2.TabIndex = 30;
            labelRiboflavinB2.Text = "Riboflavin B2 (mg)";
            // 
            // textBoxThiaminB1
            // 
            textBoxThiaminB1.Location = new Point(300, 395);
            textBoxThiaminB1.Name = "textBoxThiaminB1";
            textBoxThiaminB1.Size = new Size(78, 23);
            textBoxThiaminB1.TabIndex = 15;
            textBoxThiaminB1.TextAlign = HorizontalAlignment.Right;
            textBoxThiaminB1.KeyDown += TextBoxThiaminB1_KeyDown;
            textBoxThiaminB1.Leave += TextBoxThiaminB1_Leave;
            // 
            // labelThiaminB1
            // 
            labelThiaminB1.AutoSize = true;
            labelThiaminB1.Location = new Point(413, 398);
            labelThiaminB1.Name = "labelThiaminB1";
            labelThiaminB1.Size = new Size(95, 15);
            labelThiaminB1.TabIndex = 28;
            labelThiaminB1.Text = "Thiamin B1 (mg)";
            // 
            // textBoxPotassiumK
            // 
            textBoxPotassiumK.Location = new Point(300, 368);
            textBoxPotassiumK.Name = "textBoxPotassiumK";
            textBoxPotassiumK.Size = new Size(78, 23);
            textBoxPotassiumK.TabIndex = 14;
            textBoxPotassiumK.TextAlign = HorizontalAlignment.Right;
            textBoxPotassiumK.KeyDown += TextBoxPotassiumK_KeyDown;
            textBoxPotassiumK.Leave += TextBoxPotassiumK_Leave;
            // 
            // labelPotassiumK
            // 
            labelPotassiumK.AutoSize = true;
            labelPotassiumK.Location = new Point(413, 371);
            labelPotassiumK.Name = "labelPotassiumK";
            labelPotassiumK.Size = new Size(101, 15);
            labelPotassiumK.TabIndex = 26;
            labelPotassiumK.Text = "Potassium K (mg)";
            // 
            // textBoxCalciumCa
            // 
            textBoxCalciumCa.Location = new Point(300, 341);
            textBoxCalciumCa.Name = "textBoxCalciumCa";
            textBoxCalciumCa.Size = new Size(78, 23);
            textBoxCalciumCa.TabIndex = 13;
            textBoxCalciumCa.TextAlign = HorizontalAlignment.Right;
            textBoxCalciumCa.KeyDown += TextBoxCalciumCa_KeyDown;
            textBoxCalciumCa.Leave += TextBoxCalciumCa_Leave;
            // 
            // labelCalciumCa
            // 
            labelCalciumCa.AutoSize = true;
            labelCalciumCa.Location = new Point(413, 344);
            labelCalciumCa.Name = "labelCalciumCa";
            labelCalciumCa.Size = new Size(97, 15);
            labelCalciumCa.TabIndex = 24;
            labelCalciumCa.Text = "Calcium Ca (mg)";
            // 
            // textBoxSodiumNa
            // 
            textBoxSodiumNa.Location = new Point(201, 206);
            textBoxSodiumNa.Name = "textBoxSodiumNa";
            textBoxSodiumNa.Size = new Size(78, 23);
            textBoxSodiumNa.TabIndex = 8;
            textBoxSodiumNa.TextAlign = HorizontalAlignment.Right;
            textBoxSodiumNa.KeyDown += TextBoxSodiumNa_KeyDown;
            textBoxSodiumNa.Leave += TextBoxSodiumNa_Leave;
            // 
            // labelSodiumNa
            // 
            labelSodiumNa.AutoSize = true;
            labelSodiumNa.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSodiumNa.Location = new Point(26, 206);
            labelSodiumNa.Name = "labelSodiumNa";
            labelSodiumNa.Size = new Size(121, 20);
            labelSodiumNa.TabIndex = 0;
            labelSodiumNa.Text = "Sodium Na (mg)";
            // 
            // textBoxDietaryFibre
            // 
            textBoxDietaryFibre.Location = new Point(300, 314);
            textBoxDietaryFibre.Name = "textBoxDietaryFibre";
            textBoxDietaryFibre.Size = new Size(78, 23);
            textBoxDietaryFibre.TabIndex = 12;
            textBoxDietaryFibre.TextAlign = HorizontalAlignment.Right;
            textBoxDietaryFibre.KeyDown += TextBoxDietaryFibre_KeyDown;
            textBoxDietaryFibre.Leave += TextBoxDietaryFibre_Leave;
            // 
            // labelDietaryFibre
            // 
            labelDietaryFibre.AutoSize = true;
            labelDietaryFibre.Location = new Point(413, 317);
            labelDietaryFibre.Name = "labelDietaryFibre";
            labelDietaryFibre.Size = new Size(91, 15);
            labelDietaryFibre.TabIndex = 20;
            labelDietaryFibre.Text = "Dietary Fibre (g)";
            // 
            // textBoxSugars
            // 
            textBoxSugars.Location = new Point(201, 179);
            textBoxSugars.Name = "textBoxSugars";
            textBoxSugars.Size = new Size(78, 23);
            textBoxSugars.TabIndex = 7;
            textBoxSugars.TextAlign = HorizontalAlignment.Right;
            textBoxSugars.KeyDown += TextBoxSugars_KeyDown;
            textBoxSugars.Leave += TextBoxSugars_Leave;
            // 
            // labelSugars
            // 
            labelSugars.AutoSize = true;
            labelSugars.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSugars.Location = new Point(26, 179);
            labelSugars.Name = "labelSugars";
            labelSugars.Size = new Size(100, 20);
            labelSugars.TabIndex = 0;
            labelSugars.Text = "   - Sugars (g)";
            // 
            // textBoxCarbohydrate
            // 
            textBoxCarbohydrate.Location = new Point(201, 152);
            textBoxCarbohydrate.Name = "textBoxCarbohydrate";
            textBoxCarbohydrate.Size = new Size(78, 23);
            textBoxCarbohydrate.TabIndex = 6;
            textBoxCarbohydrate.TextAlign = HorizontalAlignment.Right;
            textBoxCarbohydrate.KeyDown += TextBoxCarbohydrate_KeyDown;
            textBoxCarbohydrate.Leave += TextBoxCarbohydrate_Leave;
            // 
            // labelCarbohydrate
            // 
            labelCarbohydrate.AutoSize = true;
            labelCarbohydrate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCarbohydrate.Location = new Point(26, 152);
            labelCarbohydrate.Name = "labelCarbohydrate";
            labelCarbohydrate.Size = new Size(126, 20);
            labelCarbohydrate.TabIndex = 0;
            labelCarbohydrate.Text = "Carbohydrate (g)";
            // 
            // textBoxMonounsaturatedFat
            // 
            textBoxMonounsaturatedFat.Location = new Point(300, 287);
            textBoxMonounsaturatedFat.Name = "textBoxMonounsaturatedFat";
            textBoxMonounsaturatedFat.Size = new Size(78, 23);
            textBoxMonounsaturatedFat.TabIndex = 11;
            textBoxMonounsaturatedFat.TextAlign = HorizontalAlignment.Right;
            textBoxMonounsaturatedFat.KeyDown += TextBoxMonounsaturatedFat_KeyDown;
            textBoxMonounsaturatedFat.Leave += TextBoxMonounsaturatedFat_Leave;
            // 
            // labelMonounsaturatedFat
            // 
            labelMonounsaturatedFat.AutoSize = true;
            labelMonounsaturatedFat.Location = new Point(410, 290);
            labelMonounsaturatedFat.Name = "labelMonounsaturatedFat";
            labelMonounsaturatedFat.Size = new Size(156, 15);
            labelMonounsaturatedFat.TabIndex = 0;
            labelMonounsaturatedFat.Text = "   - Monounsaturated Fat (g)";
            // 
            // textBoxPolyunsaturatedFat
            // 
            textBoxPolyunsaturatedFat.Location = new Point(300, 260);
            textBoxPolyunsaturatedFat.Name = "textBoxPolyunsaturatedFat";
            textBoxPolyunsaturatedFat.Size = new Size(78, 23);
            textBoxPolyunsaturatedFat.TabIndex = 10;
            textBoxPolyunsaturatedFat.TextAlign = HorizontalAlignment.Right;
            textBoxPolyunsaturatedFat.KeyDown += TextBoxPolyunsaturatedFat_KeyDown;
            textBoxPolyunsaturatedFat.Leave += TextBoxPolyunsaturatedFat_Leave;
            // 
            // labelPolyunsaturatedFat
            // 
            labelPolyunsaturatedFat.AutoSize = true;
            labelPolyunsaturatedFat.Location = new Point(410, 263);
            labelPolyunsaturatedFat.Name = "labelPolyunsaturatedFat";
            labelPolyunsaturatedFat.Size = new Size(147, 15);
            labelPolyunsaturatedFat.TabIndex = 0;
            labelPolyunsaturatedFat.Text = "   - Polyunsaturated Fat (g)";
            // 
            // textBoxTransFat
            // 
            textBoxTransFat.Location = new Point(300, 233);
            textBoxTransFat.Name = "textBoxTransFat";
            textBoxTransFat.Size = new Size(78, 23);
            textBoxTransFat.TabIndex = 9;
            textBoxTransFat.TextAlign = HorizontalAlignment.Right;
            textBoxTransFat.KeyDown += TextBoxTransFat_KeyDown;
            textBoxTransFat.Leave += TextBoxTransFat_Leave;
            // 
            // labelTransFat
            // 
            labelTransFat.AutoSize = true;
            labelTransFat.Location = new Point(410, 236);
            labelTransFat.Name = "labelTransFat";
            labelTransFat.Size = new Size(99, 15);
            labelTransFat.TabIndex = 0;
            labelTransFat.Text = "   - Trans Fat (mg)";
            // 
            // textBoxSaturatedFat
            // 
            textBoxSaturatedFat.Location = new Point(201, 125);
            textBoxSaturatedFat.Name = "textBoxSaturatedFat";
            textBoxSaturatedFat.Size = new Size(78, 23);
            textBoxSaturatedFat.TabIndex = 5;
            textBoxSaturatedFat.TextAlign = HorizontalAlignment.Right;
            textBoxSaturatedFat.KeyDown += TextBoxSaturatedFat_KeyDown;
            textBoxSaturatedFat.Leave += TextBoxSaturatedFat_Leave;
            // 
            // labelSaturatedFat
            // 
            labelSaturatedFat.AutoSize = true;
            labelSaturatedFat.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSaturatedFat.Location = new Point(26, 127);
            labelSaturatedFat.Name = "labelSaturatedFat";
            labelSaturatedFat.Size = new Size(144, 20);
            labelSaturatedFat.TabIndex = 0;
            labelSaturatedFat.Text = "   - Saturated Fat (g)";
            // 
            // textBoxFatTotal
            // 
            textBoxFatTotal.Location = new Point(201, 98);
            textBoxFatTotal.Name = "textBoxFatTotal";
            textBoxFatTotal.Size = new Size(78, 23);
            textBoxFatTotal.TabIndex = 4;
            textBoxFatTotal.TextAlign = HorizontalAlignment.Right;
            textBoxFatTotal.KeyDown += TextBoxFatTotal_KeyDown;
            textBoxFatTotal.Leave += TextBoxFatTotal_Leave;
            // 
            // labelFatTotal
            // 
            labelFatTotal.AutoSize = true;
            labelFatTotal.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelFatTotal.Location = new Point(26, 100);
            labelFatTotal.Name = "labelFatTotal";
            labelFatTotal.Size = new Size(89, 20);
            labelFatTotal.TabIndex = 0;
            labelFatTotal.Text = "Fat Total (g)";
            // 
            // textBoxProtein
            // 
            textBoxProtein.Location = new Point(201, 71);
            textBoxProtein.Name = "textBoxProtein";
            textBoxProtein.Size = new Size(78, 23);
            textBoxProtein.TabIndex = 3;
            textBoxProtein.TextAlign = HorizontalAlignment.Right;
            textBoxProtein.KeyDown += TextBoxProtein_KeyDown;
            textBoxProtein.Leave += TextBoxProtein_Leave;
            // 
            // textBoxEnergy
            // 
            textBoxEnergy.Location = new Point(201, 44);
            textBoxEnergy.Name = "textBoxEnergy";
            textBoxEnergy.Size = new Size(78, 23);
            textBoxEnergy.TabIndex = 2;
            textBoxEnergy.TextAlign = HorizontalAlignment.Right;
            textBoxEnergy.KeyDown += TextBoxEnergy_KeyDown;
            textBoxEnergy.Leave += TextBoxEnergy_Leave;
            // 
            // textBoxFoodDescription
            // 
            textBoxFoodDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFoodDescription.Location = new Point(201, 17);
            textBoxFoodDescription.Name = "textBoxFoodDescription";
            textBoxFoodDescription.Size = new Size(1182, 23);
            textBoxFoodDescription.TabIndex = 1;
            textBoxFoodDescription.KeyDown += TextBoxFoodDescription_KeyDown;
            textBoxFoodDescription.Leave += TextBoxFoodDescription_Leave;
            // 
            // labelProtein
            // 
            labelProtein.AutoSize = true;
            labelProtein.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelProtein.Location = new Point(26, 73);
            labelProtein.Name = "labelProtein";
            labelProtein.Size = new Size(82, 20);
            labelProtein.TabIndex = 0;
            labelProtein.Text = "Protein (g)";
            // 
            // labelEnergy
            // 
            labelEnergy.AutoSize = true;
            labelEnergy.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelEnergy.Location = new Point(26, 46);
            labelEnergy.Name = "labelEnergy";
            labelEnergy.Size = new Size(85, 20);
            labelEnergy.TabIndex = 0;
            labelEnergy.Text = "Energy (kJ)";
            // 
            // labelFoodDescription
            // 
            labelFoodDescription.AutoSize = true;
            labelFoodDescription.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelFoodDescription.Location = new Point(26, 19);
            labelFoodDescription.Name = "labelFoodDescription";
            labelFoodDescription.Size = new Size(124, 20);
            labelFoodDescription.TabIndex = 0;
            labelFoodDescription.Text = "Food description";
            // 
            // FoodInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            CancelButton = buttonCancelAddFood;
            ClientSize = new Size(1420, 787);
            Controls.Add(labelHelpAddEditFood);
            Controls.Add(tabControlAddType);
            Controls.Add(labelState);
            Controls.Add(buttonCancelAddFood);
            Controls.Add(buttonAddFood);
            Controls.Add(groupBoxFoodTypes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FoodInputForm";
            ShowIcon = false;
            Text = "Form for adding a food to the database";
            FormClosing += FoodInputForm_FormClosing;
            Shown += FoodInputForm_Shown;
            groupBoxFoodTypes.ResumeLayout(false);
            groupBoxFoodTypes.PerformLayout();
            tabControlAddType.ResumeLayout(false);
            tabPageRecipie.ResumeLayout(false);
            tabPageRecipie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddToRecipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)foodBindingSource).EndInit();
            tabPageNonRecipie.ResumeLayout(false);
            tabPageNonRecipie.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxFoodTypes;
        private RadioButton radioButtonLiquid;
        private RadioButton radioButtonSolid;
        private RadioButton radioButtonRecipie;
        private Button buttonAddFood;
        private Button buttonCancelAddFood;
        private Label labelState;
        private TabControl tabControlAddType;
        private TabPage tabPageNonRecipie;
        private TabPage tabPageRecipie;
        private Label labelFoodDescription;
        private Label labelProtein;
        private Label labelEnergy;
        private TextBox textBoxFoodDescription;
        private TextBox textBoxFatTotal;
        private Label labelFatTotal;
        private TextBox textBoxProtein;
        private TextBox textBoxEnergy;
        private TextBox textBoxSaturatedFat;
        private Label labelSaturatedFat;
        private TextBox textBoxTransFat;
        private Label labelTransFat;
        private TextBox textBoxPolyunsaturatedFat;
        private Label labelPolyunsaturatedFat;
        private TextBox textBoxCarbohydrate;
        private Label labelCarbohydrate;
        private TextBox textBoxMonounsaturatedFat;
        private Label labelMonounsaturatedFat;
        private TextBox textBoxSugars;
        private Label labelSugars;
        private TextBox textBoxDietaryFibre;
        private Label labelDietaryFibre;
        private TextBox textBoxSodiumNa;
        private Label labelSodiumNa;
        private TextBox textBoxCalciumCa;
        private Label labelCalciumCa;
        private TextBox textBoxRiboflavinB2;
        private Label labelRiboflavinB2;
        private TextBox textBoxThiaminB1;
        private Label labelThiaminB1;
        private TextBox textBoxPotassiumK;
        private Label labelPotassiumK;
        private TextBox textBoxCaffeine;
        private Label labelCaffeine;
        private TextBox textBoxVitaminC;
        private Label labelVitaminC;
        private TextBox textBoxMagnesiumMg;
        private Label labelMagnesiumMg;
        private TextBox textBoxIronFe;
        private Label labelIronFe;
        private TextBox textBoxFolate;
        private Label labelFolate;
        private TextBox textBoxNiacinB3;
        private Label labelNiacinB3;
        private TextBox textBoxAlcohol;
        private Label labelAlcohol;
        private TextBox textBoxCholesterol;
        private Label labelCholesterol;
        private TextBox textBoxRecipeFoodDescription;
        private Label labelRecipeFoodDescription;
        private DataGridView dataGridViewAddToRecipe;
        private BindingSource foodBindingSource;
        private TextBox textBoxFilterRecipe;
        private Label labelFilterRecipe;
        private DataGridView dataGridViewRecipe;
        private BindingSource recipeBindingSource;
        private Label labelIngredients;
        private Label labelHelpAddEditFood;
        private Label labelHelpAddEditIngredients;
        private Label labelHelpAddEditDescription;
        private Label labelHelpAddEditIngredient;
        private Label labelHelpAddEditFilter;
        private Label labelHelpAddEditRecipe;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Energy;
        private DataGridViewTextBoxColumn FatTotal;
        private DataGridViewTextBoxColumn DietaryFibre;
        private DataGridViewTextBoxColumn foodDescriptionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn foodDescriptionDataGridViewTextBoxColumn;
        private Label labelHelpAddEditNonRecipe;
    }
}