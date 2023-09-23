namespace DietSentry
{
    partial class foodInputForm
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

        public Boolean recordExists = false; // flag to prevent recreation of recipe record
        public int recordID = 0; // Id of created recipe record 

        // A variable  which stores data collected from the foodInputForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBoxFoodTypes = new GroupBox();
            radioButtonRecipie = new RadioButton();
            radioButtonLiquid = new RadioButton();
            radioButtonSolid = new RadioButton();
            buttonAddFood = new Button();
            buttonCancelAddFood = new Button();
            labelState = new Label();
            tabControlAddType = new TabControl();
            tabPageNonRecipie = new TabPage();
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
            tabPageRecipie = new TabPage();
            dataGridViewRecipe = new DataGridView();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            foodDescriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            recipeBindingSource = new BindingSource(components);
            labelFilterRecipe = new Label();
            textBoxFilterRecipe = new TextBox();
            dataGridViewAddToRecipe = new DataGridView();
            foodDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            foodBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBoxRecipeFoodDescription = new TextBox();
            labelRecipeFoodDescription = new Label();
            groupBoxFoodTypes.SuspendLayout();
            tabControlAddType.SuspendLayout();
            tabPageNonRecipie.SuspendLayout();
            tabPageRecipie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddToRecipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foodBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBoxFoodTypes
            // 
            groupBoxFoodTypes.Controls.Add(radioButtonRecipie);
            groupBoxFoodTypes.Controls.Add(radioButtonLiquid);
            groupBoxFoodTypes.Controls.Add(radioButtonSolid);
            groupBoxFoodTypes.Location = new Point(1, 5);
            groupBoxFoodTypes.Margin = new Padding(4, 5, 4, 5);
            groupBoxFoodTypes.Name = "groupBoxFoodTypes";
            groupBoxFoodTypes.Padding = new Padding(4, 5, 4, 5);
            groupBoxFoodTypes.Size = new Size(307, 92);
            groupBoxFoodTypes.TabIndex = 0;
            groupBoxFoodTypes.TabStop = false;
            groupBoxFoodTypes.Text = "Select type";
            // 
            // radioButtonRecipie
            // 
            radioButtonRecipie.AutoSize = true;
            radioButtonRecipie.Location = new Point(201, 38);
            radioButtonRecipie.Margin = new Padding(4, 5, 4, 5);
            radioButtonRecipie.Name = "radioButtonRecipie";
            radioButtonRecipie.Size = new Size(88, 29);
            radioButtonRecipie.TabIndex = 3;
            radioButtonRecipie.Text = "Recipe";
            radioButtonRecipie.UseVisualStyleBackColor = true;
            radioButtonRecipie.CheckedChanged += radioButtonRecipie_CheckedChanged;
            // 
            // radioButtonLiquid
            // 
            radioButtonLiquid.AutoSize = true;
            radioButtonLiquid.Location = new Point(104, 38);
            radioButtonLiquid.Margin = new Padding(4, 5, 4, 5);
            radioButtonLiquid.Name = "radioButtonLiquid";
            radioButtonLiquid.Size = new Size(85, 29);
            radioButtonLiquid.TabIndex = 2;
            radioButtonLiquid.Text = "Liquid";
            radioButtonLiquid.UseVisualStyleBackColor = true;
            radioButtonLiquid.CheckedChanged += radioButtonLiquid_CheckedChanged;
            // 
            // radioButtonSolid
            // 
            radioButtonSolid.AutoSize = true;
            radioButtonSolid.Checked = true;
            radioButtonSolid.Location = new Point(14, 38);
            radioButtonSolid.Margin = new Padding(4, 5, 4, 5);
            radioButtonSolid.Name = "radioButtonSolid";
            radioButtonSolid.Size = new Size(77, 29);
            radioButtonSolid.TabIndex = 1;
            radioButtonSolid.TabStop = true;
            radioButtonSolid.Text = "Solid";
            radioButtonSolid.UseVisualStyleBackColor = true;
            radioButtonSolid.CheckedChanged += radioButtonSolid_CheckedChanged;
            // 
            // buttonAddFood
            // 
            buttonAddFood.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddFood.Location = new Point(297, 1288);
            buttonAddFood.Margin = new Padding(4, 5, 4, 5);
            buttonAddFood.Name = "buttonAddFood";
            buttonAddFood.Size = new Size(107, 38);
            buttonAddFood.TabIndex = 5;
            buttonAddFood.Text = "Add food";
            buttonAddFood.UseVisualStyleBackColor = true;
            buttonAddFood.Click += buttonAddFood_Click;
            // 
            // buttonCancelAddFood
            // 
            buttonCancelAddFood.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCancelAddFood.Location = new Point(437, 1288);
            buttonCancelAddFood.Margin = new Padding(4, 5, 4, 5);
            buttonCancelAddFood.Name = "buttonCancelAddFood";
            buttonCancelAddFood.Size = new Size(107, 38);
            buttonCancelAddFood.TabIndex = 6;
            buttonCancelAddFood.Text = "Cancel";
            buttonCancelAddFood.UseVisualStyleBackColor = true;
            buttonCancelAddFood.Click += buttonCancelAddFood_Click;
            // 
            // labelState
            // 
            labelState.AutoSize = true;
            labelState.Location = new Point(317, 47);
            labelState.Margin = new Padding(4, 0, 4, 0);
            labelState.Name = "labelState";
            labelState.Size = new Size(327, 25);
            labelState.TabIndex = 4;
            labelState.Text = "Nutrition information per 100 grams (g)";
            // 
            // tabControlAddType
            // 
            tabControlAddType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabControlAddType.Controls.Add(tabPageNonRecipie);
            tabControlAddType.Controls.Add(tabPageRecipie);
            tabControlAddType.ItemSize = new Size(50, 10);
            tabControlAddType.Location = new Point(0, 83);
            tabControlAddType.Margin = new Padding(0);
            tabControlAddType.Name = "tabControlAddType";
            tabControlAddType.Padding = new Point(0, 0);
            tabControlAddType.SelectedIndex = 0;
            tabControlAddType.Size = new Size(1656, 1185);
            tabControlAddType.SizeMode = TabSizeMode.Fixed;
            tabControlAddType.TabIndex = 5;
            tabControlAddType.TabStop = false;
            // 
            // tabPageNonRecipie
            // 
            tabPageNonRecipie.BackColor = Color.Silver;
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
            tabPageNonRecipie.Location = new Point(4, 14);
            tabPageNonRecipie.Margin = new Padding(0);
            tabPageNonRecipie.Name = "tabPageNonRecipie";
            tabPageNonRecipie.Size = new Size(1648, 1167);
            tabPageNonRecipie.TabIndex = 0;
            tabPageNonRecipie.Text = "Add Non Recipie";
            // 
            // textBoxAlcohol
            // 
            textBoxAlcohol.Location = new Point(287, 1063);
            textBoxAlcohol.Margin = new Padding(4, 5, 4, 5);
            textBoxAlcohol.Name = "textBoxAlcohol";
            textBoxAlcohol.Size = new Size(110, 31);
            textBoxAlcohol.TabIndex = 47;
            textBoxAlcohol.TextAlign = HorizontalAlignment.Right;
            textBoxAlcohol.KeyDown += textBoxAlcohol_KeyDown;
            textBoxAlcohol.Leave += textBoxAlcohol_Leave;
            // 
            // labelAlcohol
            // 
            labelAlcohol.AutoSize = true;
            labelAlcohol.Location = new Point(37, 1068);
            labelAlcohol.Margin = new Padding(4, 0, 4, 0);
            labelAlcohol.Name = "labelAlcohol";
            labelAlcohol.Size = new Size(98, 25);
            labelAlcohol.TabIndex = 46;
            labelAlcohol.Text = "Alcohol (g)";
            // 
            // textBoxCholesterol
            // 
            textBoxCholesterol.Location = new Point(287, 1018);
            textBoxCholesterol.Margin = new Padding(4, 5, 4, 5);
            textBoxCholesterol.Name = "textBoxCholesterol";
            textBoxCholesterol.Size = new Size(110, 31);
            textBoxCholesterol.TabIndex = 45;
            textBoxCholesterol.TextAlign = HorizontalAlignment.Right;
            textBoxCholesterol.KeyDown += textBoxCholesterol_KeyDown;
            textBoxCholesterol.Leave += textBoxCholesterol_Leave;
            // 
            // labelCholesterol
            // 
            labelCholesterol.AutoSize = true;
            labelCholesterol.Location = new Point(37, 1023);
            labelCholesterol.Margin = new Padding(4, 0, 4, 0);
            labelCholesterol.Name = "labelCholesterol";
            labelCholesterol.Size = new Size(143, 25);
            labelCholesterol.TabIndex = 44;
            labelCholesterol.Text = "Cholesterol (mg)";
            // 
            // textBoxCaffeine
            // 
            textBoxCaffeine.Location = new Point(287, 973);
            textBoxCaffeine.Margin = new Padding(4, 5, 4, 5);
            textBoxCaffeine.Name = "textBoxCaffeine";
            textBoxCaffeine.Size = new Size(110, 31);
            textBoxCaffeine.TabIndex = 43;
            textBoxCaffeine.TextAlign = HorizontalAlignment.Right;
            textBoxCaffeine.KeyDown += textBoxCaffeine_KeyDown;
            textBoxCaffeine.Leave += textBoxCaffeine_Leave;
            // 
            // labelCaffeine
            // 
            labelCaffeine.AutoSize = true;
            labelCaffeine.Location = new Point(37, 978);
            labelCaffeine.Margin = new Padding(4, 0, 4, 0);
            labelCaffeine.Name = "labelCaffeine";
            labelCaffeine.Size = new Size(118, 25);
            labelCaffeine.TabIndex = 42;
            labelCaffeine.Text = "Caffeine (mg)";
            // 
            // textBoxVitaminC
            // 
            textBoxVitaminC.Location = new Point(287, 928);
            textBoxVitaminC.Margin = new Padding(4, 5, 4, 5);
            textBoxVitaminC.Name = "textBoxVitaminC";
            textBoxVitaminC.Size = new Size(110, 31);
            textBoxVitaminC.TabIndex = 41;
            textBoxVitaminC.TextAlign = HorizontalAlignment.Right;
            textBoxVitaminC.KeyDown += textBoxVitaminC_KeyDown;
            textBoxVitaminC.Leave += textBoxVitaminC_Leave;
            // 
            // labelVitaminC
            // 
            labelVitaminC.AutoSize = true;
            labelVitaminC.Location = new Point(37, 933);
            labelVitaminC.Margin = new Padding(4, 0, 4, 0);
            labelVitaminC.Name = "labelVitaminC";
            labelVitaminC.Size = new Size(130, 25);
            labelVitaminC.TabIndex = 40;
            labelVitaminC.Text = "Vitamin C (mg)";
            // 
            // textBoxMagnesiumMg
            // 
            textBoxMagnesiumMg.Location = new Point(287, 883);
            textBoxMagnesiumMg.Margin = new Padding(4, 5, 4, 5);
            textBoxMagnesiumMg.Name = "textBoxMagnesiumMg";
            textBoxMagnesiumMg.Size = new Size(110, 31);
            textBoxMagnesiumMg.TabIndex = 39;
            textBoxMagnesiumMg.TextAlign = HorizontalAlignment.Right;
            textBoxMagnesiumMg.KeyDown += textBoxMagnesiumMg_KeyDown;
            textBoxMagnesiumMg.Leave += textBoxMagnesiumMg_Leave;
            // 
            // labelMagnesiumMg
            // 
            labelMagnesiumMg.AutoSize = true;
            labelMagnesiumMg.Location = new Point(37, 888);
            labelMagnesiumMg.Margin = new Padding(4, 0, 4, 0);
            labelMagnesiumMg.Name = "labelMagnesiumMg";
            labelMagnesiumMg.Size = new Size(179, 25);
            labelMagnesiumMg.TabIndex = 38;
            labelMagnesiumMg.Text = "Magnesium Mg (mg)";
            // 
            // textBoxIronFe
            // 
            textBoxIronFe.Location = new Point(287, 838);
            textBoxIronFe.Margin = new Padding(4, 5, 4, 5);
            textBoxIronFe.Name = "textBoxIronFe";
            textBoxIronFe.Size = new Size(110, 31);
            textBoxIronFe.TabIndex = 37;
            textBoxIronFe.TextAlign = HorizontalAlignment.Right;
            textBoxIronFe.KeyDown += textBoxIronFe_KeyDown;
            textBoxIronFe.Leave += textBoxIronFe_Leave;
            // 
            // labelIronFe
            // 
            labelIronFe.AutoSize = true;
            labelIronFe.Location = new Point(37, 843);
            labelIronFe.Margin = new Padding(4, 0, 4, 0);
            labelIronFe.Name = "labelIronFe";
            labelIronFe.Size = new Size(109, 25);
            labelIronFe.TabIndex = 36;
            labelIronFe.Text = "Iron Fe (mg)";
            // 
            // textBoxFolate
            // 
            textBoxFolate.Location = new Point(287, 793);
            textBoxFolate.Margin = new Padding(4, 5, 4, 5);
            textBoxFolate.Name = "textBoxFolate";
            textBoxFolate.Size = new Size(110, 31);
            textBoxFolate.TabIndex = 35;
            textBoxFolate.TextAlign = HorizontalAlignment.Right;
            textBoxFolate.KeyDown += textBoxFolate_KeyDown;
            textBoxFolate.Leave += textBoxFolate_Leave;
            // 
            // labelFolate
            // 
            labelFolate.AutoSize = true;
            labelFolate.Location = new Point(37, 798);
            labelFolate.Margin = new Padding(4, 0, 4, 0);
            labelFolate.Name = "labelFolate";
            labelFolate.Size = new Size(96, 25);
            labelFolate.TabIndex = 34;
            labelFolate.Text = "Folate (ug)";
            // 
            // textBoxNiacinB3
            // 
            textBoxNiacinB3.Location = new Point(287, 748);
            textBoxNiacinB3.Margin = new Padding(4, 5, 4, 5);
            textBoxNiacinB3.Name = "textBoxNiacinB3";
            textBoxNiacinB3.Size = new Size(110, 31);
            textBoxNiacinB3.TabIndex = 33;
            textBoxNiacinB3.TextAlign = HorizontalAlignment.Right;
            textBoxNiacinB3.KeyDown += textBoxNiacinB3_KeyDown;
            textBoxNiacinB3.Leave += textBoxNiacinB3_Leave;
            // 
            // labelNiacinB3
            // 
            labelNiacinB3.AutoSize = true;
            labelNiacinB3.Location = new Point(37, 753);
            labelNiacinB3.Margin = new Padding(4, 0, 4, 0);
            labelNiacinB3.Name = "labelNiacinB3";
            labelNiacinB3.Size = new Size(127, 25);
            labelNiacinB3.TabIndex = 32;
            labelNiacinB3.Text = "Niacin B3 (mg)";
            // 
            // textBoxRiboflavinB2
            // 
            textBoxRiboflavinB2.Location = new Point(287, 703);
            textBoxRiboflavinB2.Margin = new Padding(4, 5, 4, 5);
            textBoxRiboflavinB2.Name = "textBoxRiboflavinB2";
            textBoxRiboflavinB2.Size = new Size(110, 31);
            textBoxRiboflavinB2.TabIndex = 31;
            textBoxRiboflavinB2.TextAlign = HorizontalAlignment.Right;
            textBoxRiboflavinB2.KeyDown += textBoxRiboflavinB2_KeyDown;
            textBoxRiboflavinB2.Leave += textBoxRiboflavinB2_Leave;
            // 
            // labelRiboflavinB2
            // 
            labelRiboflavinB2.AutoSize = true;
            labelRiboflavinB2.Location = new Point(37, 708);
            labelRiboflavinB2.Margin = new Padding(4, 0, 4, 0);
            labelRiboflavinB2.Name = "labelRiboflavinB2";
            labelRiboflavinB2.Size = new Size(158, 25);
            labelRiboflavinB2.TabIndex = 30;
            labelRiboflavinB2.Text = "Riboflavin B2 (mg)";
            // 
            // textBoxThiaminB1
            // 
            textBoxThiaminB1.Location = new Point(287, 658);
            textBoxThiaminB1.Margin = new Padding(4, 5, 4, 5);
            textBoxThiaminB1.Name = "textBoxThiaminB1";
            textBoxThiaminB1.Size = new Size(110, 31);
            textBoxThiaminB1.TabIndex = 29;
            textBoxThiaminB1.TextAlign = HorizontalAlignment.Right;
            textBoxThiaminB1.KeyDown += textBoxThiaminB1_KeyDown;
            textBoxThiaminB1.Leave += textBoxThiaminB1_Leave;
            // 
            // labelThiaminB1
            // 
            labelThiaminB1.AutoSize = true;
            labelThiaminB1.Location = new Point(37, 663);
            labelThiaminB1.Margin = new Padding(4, 0, 4, 0);
            labelThiaminB1.Name = "labelThiaminB1";
            labelThiaminB1.Size = new Size(141, 25);
            labelThiaminB1.TabIndex = 28;
            labelThiaminB1.Text = "Thiamin B1 (mg)";
            // 
            // textBoxPotassiumK
            // 
            textBoxPotassiumK.Location = new Point(287, 613);
            textBoxPotassiumK.Margin = new Padding(4, 5, 4, 5);
            textBoxPotassiumK.Name = "textBoxPotassiumK";
            textBoxPotassiumK.Size = new Size(110, 31);
            textBoxPotassiumK.TabIndex = 27;
            textBoxPotassiumK.TextAlign = HorizontalAlignment.Right;
            textBoxPotassiumK.KeyDown += textBoxPotassiumK_KeyDown;
            textBoxPotassiumK.Leave += textBoxPotassiumK_Leave;
            // 
            // labelPotassiumK
            // 
            labelPotassiumK.AutoSize = true;
            labelPotassiumK.Location = new Point(37, 618);
            labelPotassiumK.Margin = new Padding(4, 0, 4, 0);
            labelPotassiumK.Name = "labelPotassiumK";
            labelPotassiumK.Size = new Size(150, 25);
            labelPotassiumK.TabIndex = 26;
            labelPotassiumK.Text = "Potassium K (mg)";
            // 
            // textBoxCalciumCa
            // 
            textBoxCalciumCa.Location = new Point(287, 568);
            textBoxCalciumCa.Margin = new Padding(4, 5, 4, 5);
            textBoxCalciumCa.Name = "textBoxCalciumCa";
            textBoxCalciumCa.Size = new Size(110, 31);
            textBoxCalciumCa.TabIndex = 25;
            textBoxCalciumCa.TextAlign = HorizontalAlignment.Right;
            textBoxCalciumCa.KeyDown += textBoxCalciumCa_KeyDown;
            textBoxCalciumCa.Leave += textBoxCalciumCa_Leave;
            // 
            // labelCalciumCa
            // 
            labelCalciumCa.AutoSize = true;
            labelCalciumCa.Location = new Point(37, 573);
            labelCalciumCa.Margin = new Padding(4, 0, 4, 0);
            labelCalciumCa.Name = "labelCalciumCa";
            labelCalciumCa.Size = new Size(141, 25);
            labelCalciumCa.TabIndex = 24;
            labelCalciumCa.Text = "Calcium Ca (mg)";
            // 
            // textBoxSodiumNa
            // 
            textBoxSodiumNa.Location = new Point(287, 523);
            textBoxSodiumNa.Margin = new Padding(4, 5, 4, 5);
            textBoxSodiumNa.Name = "textBoxSodiumNa";
            textBoxSodiumNa.Size = new Size(110, 31);
            textBoxSodiumNa.TabIndex = 23;
            textBoxSodiumNa.TextAlign = HorizontalAlignment.Right;
            textBoxSodiumNa.KeyDown += textBoxSodiumNa_KeyDown;
            textBoxSodiumNa.Leave += textBoxSodiumNa_Leave;
            // 
            // labelSodiumNa
            // 
            labelSodiumNa.AutoSize = true;
            labelSodiumNa.Location = new Point(37, 528);
            labelSodiumNa.Margin = new Padding(4, 0, 4, 0);
            labelSodiumNa.Name = "labelSodiumNa";
            labelSodiumNa.Size = new Size(143, 25);
            labelSodiumNa.TabIndex = 22;
            labelSodiumNa.Text = "Sodium Na (mg)";
            // 
            // textBoxDietaryFibre
            // 
            textBoxDietaryFibre.Location = new Point(287, 478);
            textBoxDietaryFibre.Margin = new Padding(4, 5, 4, 5);
            textBoxDietaryFibre.Name = "textBoxDietaryFibre";
            textBoxDietaryFibre.Size = new Size(110, 31);
            textBoxDietaryFibre.TabIndex = 21;
            textBoxDietaryFibre.TextAlign = HorizontalAlignment.Right;
            textBoxDietaryFibre.KeyDown += textBoxDietaryFibre_KeyDown;
            textBoxDietaryFibre.Leave += textBoxDietaryFibre_Leave;
            // 
            // labelDietaryFibre
            // 
            labelDietaryFibre.AutoSize = true;
            labelDietaryFibre.Location = new Point(37, 483);
            labelDietaryFibre.Margin = new Padding(4, 0, 4, 0);
            labelDietaryFibre.Name = "labelDietaryFibre";
            labelDietaryFibre.Size = new Size(138, 25);
            labelDietaryFibre.TabIndex = 20;
            labelDietaryFibre.Text = "Dietary Fibre (g)";
            // 
            // textBoxSugars
            // 
            textBoxSugars.Location = new Point(287, 433);
            textBoxSugars.Margin = new Padding(4, 5, 4, 5);
            textBoxSugars.Name = "textBoxSugars";
            textBoxSugars.Size = new Size(110, 31);
            textBoxSugars.TabIndex = 19;
            textBoxSugars.TextAlign = HorizontalAlignment.Right;
            textBoxSugars.KeyDown += textBoxSugars_KeyDown;
            textBoxSugars.Leave += textBoxSugars_Leave;
            // 
            // labelSugars
            // 
            labelSugars.AutoSize = true;
            labelSugars.Location = new Point(37, 438);
            labelSugars.Margin = new Padding(4, 0, 4, 0);
            labelSugars.Name = "labelSugars";
            labelSugars.Size = new Size(119, 25);
            labelSugars.TabIndex = 18;
            labelSugars.Text = "   - Sugars (g)";
            // 
            // textBoxCarbohydrate
            // 
            textBoxCarbohydrate.Location = new Point(287, 388);
            textBoxCarbohydrate.Margin = new Padding(4, 5, 4, 5);
            textBoxCarbohydrate.Name = "textBoxCarbohydrate";
            textBoxCarbohydrate.Size = new Size(110, 31);
            textBoxCarbohydrate.TabIndex = 17;
            textBoxCarbohydrate.TextAlign = HorizontalAlignment.Right;
            textBoxCarbohydrate.KeyDown += textBoxCarbohydrate_KeyDown;
            textBoxCarbohydrate.Leave += textBoxCarbohydrate_Leave;
            // 
            // labelCarbohydrate
            // 
            labelCarbohydrate.AutoSize = true;
            labelCarbohydrate.Location = new Point(37, 393);
            labelCarbohydrate.Margin = new Padding(4, 0, 4, 0);
            labelCarbohydrate.Name = "labelCarbohydrate";
            labelCarbohydrate.Size = new Size(146, 25);
            labelCarbohydrate.TabIndex = 16;
            labelCarbohydrate.Text = "Carbohydrate (g)";
            // 
            // textBoxMonounsaturatedFat
            // 
            textBoxMonounsaturatedFat.Location = new Point(287, 343);
            textBoxMonounsaturatedFat.Margin = new Padding(4, 5, 4, 5);
            textBoxMonounsaturatedFat.Name = "textBoxMonounsaturatedFat";
            textBoxMonounsaturatedFat.Size = new Size(110, 31);
            textBoxMonounsaturatedFat.TabIndex = 15;
            textBoxMonounsaturatedFat.TextAlign = HorizontalAlignment.Right;
            textBoxMonounsaturatedFat.KeyDown += textBoxMonounsaturatedFat_KeyDown;
            textBoxMonounsaturatedFat.Leave += textBoxMonounsaturatedFat_Leave;
            // 
            // labelMonounsaturatedFat
            // 
            labelMonounsaturatedFat.AutoSize = true;
            labelMonounsaturatedFat.Location = new Point(37, 348);
            labelMonounsaturatedFat.Margin = new Padding(4, 0, 4, 0);
            labelMonounsaturatedFat.Name = "labelMonounsaturatedFat";
            labelMonounsaturatedFat.Size = new Size(235, 25);
            labelMonounsaturatedFat.TabIndex = 14;
            labelMonounsaturatedFat.Text = "   - Monounsaturated Fat (g)";
            // 
            // textBoxPolyunsaturatedFat
            // 
            textBoxPolyunsaturatedFat.Location = new Point(287, 298);
            textBoxPolyunsaturatedFat.Margin = new Padding(4, 5, 4, 5);
            textBoxPolyunsaturatedFat.Name = "textBoxPolyunsaturatedFat";
            textBoxPolyunsaturatedFat.Size = new Size(110, 31);
            textBoxPolyunsaturatedFat.TabIndex = 13;
            textBoxPolyunsaturatedFat.TextAlign = HorizontalAlignment.Right;
            textBoxPolyunsaturatedFat.KeyDown += textBoxPolyunsaturatedFat_KeyDown;
            textBoxPolyunsaturatedFat.Leave += textBoxPolyunsaturatedFat_Leave;
            // 
            // labelPolyunsaturatedFat
            // 
            labelPolyunsaturatedFat.AutoSize = true;
            labelPolyunsaturatedFat.Location = new Point(37, 303);
            labelPolyunsaturatedFat.Margin = new Padding(4, 0, 4, 0);
            labelPolyunsaturatedFat.Name = "labelPolyunsaturatedFat";
            labelPolyunsaturatedFat.Size = new Size(220, 25);
            labelPolyunsaturatedFat.TabIndex = 12;
            labelPolyunsaturatedFat.Text = "   - Polyunsaturated Fat (g)";
            // 
            // textBoxTransFat
            // 
            textBoxTransFat.Location = new Point(287, 253);
            textBoxTransFat.Margin = new Padding(4, 5, 4, 5);
            textBoxTransFat.Name = "textBoxTransFat";
            textBoxTransFat.Size = new Size(110, 31);
            textBoxTransFat.TabIndex = 11;
            textBoxTransFat.TextAlign = HorizontalAlignment.Right;
            textBoxTransFat.KeyDown += textBoxTransFat_KeyDown;
            textBoxTransFat.Leave += textBoxTransFat_Leave;
            // 
            // labelTransFat
            // 
            labelTransFat.AutoSize = true;
            labelTransFat.Location = new Point(37, 258);
            labelTransFat.Margin = new Padding(4, 0, 4, 0);
            labelTransFat.Name = "labelTransFat";
            labelTransFat.Size = new Size(149, 25);
            labelTransFat.TabIndex = 10;
            labelTransFat.Text = "   - Trans Fat (mg)";
            // 
            // textBoxSaturatedFat
            // 
            textBoxSaturatedFat.Location = new Point(287, 208);
            textBoxSaturatedFat.Margin = new Padding(4, 5, 4, 5);
            textBoxSaturatedFat.Name = "textBoxSaturatedFat";
            textBoxSaturatedFat.Size = new Size(110, 31);
            textBoxSaturatedFat.TabIndex = 9;
            textBoxSaturatedFat.TextAlign = HorizontalAlignment.Right;
            textBoxSaturatedFat.KeyDown += textBoxSaturatedFat_KeyDown;
            textBoxSaturatedFat.Leave += textBoxSaturatedFat_Leave;
            // 
            // labelSaturatedFat
            // 
            labelSaturatedFat.AutoSize = true;
            labelSaturatedFat.Location = new Point(37, 213);
            labelSaturatedFat.Margin = new Padding(4, 0, 4, 0);
            labelSaturatedFat.Name = "labelSaturatedFat";
            labelSaturatedFat.Size = new Size(169, 25);
            labelSaturatedFat.TabIndex = 8;
            labelSaturatedFat.Text = "   - Saturated Fat (g)";
            // 
            // textBoxFatTotal
            // 
            textBoxFatTotal.Location = new Point(287, 163);
            textBoxFatTotal.Margin = new Padding(4, 5, 4, 5);
            textBoxFatTotal.Name = "textBoxFatTotal";
            textBoxFatTotal.Size = new Size(110, 31);
            textBoxFatTotal.TabIndex = 7;
            textBoxFatTotal.TextAlign = HorizontalAlignment.Right;
            textBoxFatTotal.KeyDown += textBoxFatTotal_KeyDown;
            textBoxFatTotal.Leave += textBoxFatTotal_Leave;
            // 
            // labelFatTotal
            // 
            labelFatTotal.AutoSize = true;
            labelFatTotal.Location = new Point(37, 168);
            labelFatTotal.Margin = new Padding(4, 0, 4, 0);
            labelFatTotal.Name = "labelFatTotal";
            labelFatTotal.Size = new Size(103, 25);
            labelFatTotal.TabIndex = 6;
            labelFatTotal.Text = "Fat Total (g)";
            // 
            // textBoxProtein
            // 
            textBoxProtein.Location = new Point(287, 118);
            textBoxProtein.Margin = new Padding(4, 5, 4, 5);
            textBoxProtein.Name = "textBoxProtein";
            textBoxProtein.Size = new Size(110, 31);
            textBoxProtein.TabIndex = 5;
            textBoxProtein.TextAlign = HorizontalAlignment.Right;
            textBoxProtein.KeyDown += textBoxProtein_KeyDown;
            textBoxProtein.Leave += textBoxProtein_Leave;
            // 
            // textBoxEnergy
            // 
            textBoxEnergy.Location = new Point(287, 73);
            textBoxEnergy.Margin = new Padding(4, 5, 4, 5);
            textBoxEnergy.Name = "textBoxEnergy";
            textBoxEnergy.Size = new Size(110, 31);
            textBoxEnergy.TabIndex = 4;
            textBoxEnergy.TextAlign = HorizontalAlignment.Right;
            textBoxEnergy.KeyDown += textBoxEnergy_KeyDown;
            textBoxEnergy.Leave += textBoxEnergy_Leave;
            // 
            // textBoxFoodDescription
            // 
            textBoxFoodDescription.Location = new Point(287, 28);
            textBoxFoodDescription.Margin = new Padding(4, 5, 4, 5);
            textBoxFoodDescription.Name = "textBoxFoodDescription";
            textBoxFoodDescription.Size = new Size(767, 31);
            textBoxFoodDescription.TabIndex = 3;
            textBoxFoodDescription.KeyDown += textBoxFoodDescription_KeyDown;
            textBoxFoodDescription.Leave += textBoxFoodDescription_Leave;
            // 
            // labelProtein
            // 
            labelProtein.AutoSize = true;
            labelProtein.Location = new Point(37, 123);
            labelProtein.Margin = new Padding(4, 0, 4, 0);
            labelProtein.Name = "labelProtein";
            labelProtein.Size = new Size(94, 25);
            labelProtein.TabIndex = 2;
            labelProtein.Text = "Protein (g)";
            // 
            // labelEnergy
            // 
            labelEnergy.AutoSize = true;
            labelEnergy.Location = new Point(37, 78);
            labelEnergy.Margin = new Padding(4, 0, 4, 0);
            labelEnergy.Name = "labelEnergy";
            labelEnergy.Size = new Size(96, 25);
            labelEnergy.TabIndex = 1;
            labelEnergy.Text = "Energy (kJ)";
            // 
            // labelFoodDescription
            // 
            labelFoodDescription.AutoSize = true;
            labelFoodDescription.Location = new Point(37, 33);
            labelFoodDescription.Margin = new Padding(4, 0, 4, 0);
            labelFoodDescription.Name = "labelFoodDescription";
            labelFoodDescription.Size = new Size(147, 25);
            labelFoodDescription.TabIndex = 0;
            labelFoodDescription.Text = "Food description";
            // 
            // tabPageRecipie
            // 
            tabPageRecipie.BackColor = Color.Silver;
            tabPageRecipie.Controls.Add(dataGridViewRecipe);
            tabPageRecipie.Controls.Add(labelFilterRecipe);
            tabPageRecipie.Controls.Add(textBoxFilterRecipe);
            tabPageRecipie.Controls.Add(dataGridViewAddToRecipe);
            tabPageRecipie.Controls.Add(textBox2);
            tabPageRecipie.Controls.Add(textBox1);
            tabPageRecipie.Controls.Add(textBoxRecipeFoodDescription);
            tabPageRecipie.Controls.Add(labelRecipeFoodDescription);
            tabPageRecipie.Location = new Point(4, 14);
            tabPageRecipie.Margin = new Padding(0);
            tabPageRecipie.Name = "tabPageRecipie";
            tabPageRecipie.Size = new Size(1648, 1167);
            tabPageRecipie.TabIndex = 1;
            tabPageRecipie.Text = "Add Recipie";
            tabPageRecipie.Enter += tabPageRecipie_Enter;
            // 
            // dataGridViewRecipe
            // 
            dataGridViewRecipe.AllowUserToAddRows = false;
            dataGridViewRecipe.AllowUserToResizeColumns = false;
            dataGridViewRecipe.AllowUserToResizeRows = false;
            dataGridViewRecipe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewRecipe.AutoGenerateColumns = false;
            dataGridViewRecipe.BorderStyle = BorderStyle.None;
            dataGridViewRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecipe.Columns.AddRange(new DataGridViewColumn[] { amountDataGridViewTextBoxColumn, foodDescriptionDataGridViewTextBoxColumn1 });
            dataGridViewRecipe.DataSource = recipeBindingSource;
            dataGridViewRecipe.Location = new Point(684, 232);
            dataGridViewRecipe.Margin = new Padding(4, 5, 4, 5);
            dataGridViewRecipe.Name = "dataGridViewRecipe";
            dataGridViewRecipe.RowHeadersWidth = 62;
            dataGridViewRecipe.RowTemplate.Height = 25;
            dataGridViewRecipe.Size = new Size(949, 910);
            dataGridViewRecipe.TabIndex = 11;
            dataGridViewRecipe.UserDeletingRow += dataGridViewRecipe_UserDeletingRow;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Amount (g)";
            amountDataGridViewTextBoxColumn.MinimumWidth = 8;
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.Width = 150;
            // 
            // foodDescriptionDataGridViewTextBoxColumn1
            // 
            foodDescriptionDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foodDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "FoodDescription";
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
            labelFilterRecipe.Location = new Point(220, 163);
            labelFilterRecipe.Margin = new Padding(4, 0, 4, 0);
            labelFilterRecipe.Name = "labelFilterRecipe";
            labelFilterRecipe.Size = new Size(89, 25);
            labelFilterRecipe.TabIndex = 10;
            labelFilterRecipe.Text = "Unfiltered";
            // 
            // textBoxFilterRecipe
            // 
            textBoxFilterRecipe.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxFilterRecipe.AutoCompleteSource = AutoCompleteSource.HistoryList;
            textBoxFilterRecipe.Location = new Point(19, 158);
            textBoxFilterRecipe.Margin = new Padding(4, 5, 4, 5);
            textBoxFilterRecipe.Name = "textBoxFilterRecipe";
            textBoxFilterRecipe.PlaceholderText = "Enter food filter text";
            textBoxFilterRecipe.Size = new Size(191, 31);
            textBoxFilterRecipe.TabIndex = 9;
            textBoxFilterRecipe.WordWrap = false;
            textBoxFilterRecipe.KeyDown += textBoxFilterRecipe_KeyDown;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Azure;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAddToRecipe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAddToRecipe.ColumnHeadersHeight = 30;
            dataGridViewAddToRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewAddToRecipe.Columns.AddRange(new DataGridViewColumn[] { foodDescriptionDataGridViewTextBoxColumn });
            dataGridViewAddToRecipe.DataSource = foodBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Info;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewAddToRecipe.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAddToRecipe.EnableHeadersVisualStyles = false;
            dataGridViewAddToRecipe.Location = new Point(11, 232);
            dataGridViewAddToRecipe.Margin = new Padding(0);
            dataGridViewAddToRecipe.MultiSelect = false;
            dataGridViewAddToRecipe.Name = "dataGridViewAddToRecipe";
            dataGridViewAddToRecipe.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewAddToRecipe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewAddToRecipe.RowHeadersVisible = false;
            dataGridViewAddToRecipe.RowHeadersWidth = 62;
            dataGridViewAddToRecipe.RowTemplate.Height = 25;
            dataGridViewAddToRecipe.ScrollBars = ScrollBars.Vertical;
            dataGridViewAddToRecipe.ShowCellErrors = false;
            dataGridViewAddToRecipe.ShowEditingIcon = false;
            dataGridViewAddToRecipe.ShowRowErrors = false;
            dataGridViewAddToRecipe.Size = new Size(647, 910);
            dataGridViewAddToRecipe.TabIndex = 8;
            dataGridViewAddToRecipe.CellDoubleClick += dataGridViewAddToRecipe_CellDoubleClick;
            dataGridViewAddToRecipe.KeyDown += dataGridViewAddToRecipe_KeyDown;
            // 
            // foodDescriptionDataGridViewTextBoxColumn
            // 
            foodDescriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foodDescriptionDataGridViewTextBoxColumn.DataPropertyName = "FoodDescription";
            foodDescriptionDataGridViewTextBoxColumn.HeaderText = "Select food for recipe";
            foodDescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            foodDescriptionDataGridViewTextBoxColumn.Name = "foodDescriptionDataGridViewTextBoxColumn";
            foodDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            foodDescriptionDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            // 
            // foodBindingSource
            // 
            foodBindingSource.DataSource = typeof(Food);
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1036, 77);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(537, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1036, 28);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(537, 31);
            textBox1.TabIndex = 6;
            // 
            // textBoxRecipeFoodDescription
            // 
            textBoxRecipeFoodDescription.Location = new Point(197, 28);
            textBoxRecipeFoodDescription.Margin = new Padding(4, 5, 4, 5);
            textBoxRecipeFoodDescription.Name = "textBoxRecipeFoodDescription";
            textBoxRecipeFoodDescription.Size = new Size(767, 31);
            textBoxRecipeFoodDescription.TabIndex = 5;
            textBoxRecipeFoodDescription.Leave += textBoxRecipeFoodDescription_Leave;
            // 
            // labelRecipeFoodDescription
            // 
            labelRecipeFoodDescription.AutoSize = true;
            labelRecipeFoodDescription.Location = new Point(37, 33);
            labelRecipeFoodDescription.Margin = new Padding(4, 0, 4, 0);
            labelRecipeFoodDescription.Name = "labelRecipeFoodDescription";
            labelRecipeFoodDescription.Size = new Size(147, 25);
            labelRecipeFoodDescription.TabIndex = 4;
            labelRecipeFoodDescription.Text = "Food description";
            // 
            // foodInputForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1656, 1347);
            ControlBox = false;
            Controls.Add(tabControlAddType);
            Controls.Add(labelState);
            Controls.Add(buttonCancelAddFood);
            Controls.Add(buttonAddFood);
            Controls.Add(groupBoxFoodTypes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "foodInputForm";
            Text = "Form for adding a food to the database";
            Shown += foodInputForm_Shown;
            groupBoxFoodTypes.ResumeLayout(false);
            groupBoxFoodTypes.PerformLayout();
            tabControlAddType.ResumeLayout(false);
            tabPageNonRecipie.ResumeLayout(false);
            tabPageNonRecipie.PerformLayout();
            tabPageRecipie.ResumeLayout(false);
            tabPageRecipie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddToRecipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)foodBindingSource).EndInit();
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
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridViewAddToRecipe;
        private BindingSource foodBindingSource;
        private DataGridViewTextBoxColumn foodDescriptionDataGridViewTextBoxColumn;
        private TextBox textBoxFilterRecipe;
        private Label labelFilterRecipe;
        private DataGridView dataGridViewRecipe;
        private BindingSource recipeBindingSource;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn foodDescriptionDataGridViewTextBoxColumn1;
    }
}