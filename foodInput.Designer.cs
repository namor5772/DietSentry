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
        public float amountOfFoodInRecipe = 0.0F; // in "units" of 100 g or mL

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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddToRecipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foodBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBoxFoodTypes
            // 
            groupBoxFoodTypes.Controls.Add(radioButtonRecipie);
            groupBoxFoodTypes.Controls.Add(radioButtonLiquid);
            groupBoxFoodTypes.Controls.Add(radioButtonSolid);
            groupBoxFoodTypes.Location = new Point(1, 3);
            groupBoxFoodTypes.Name = "groupBoxFoodTypes";
            groupBoxFoodTypes.Size = new Size(215, 55);
            groupBoxFoodTypes.TabIndex = 0;
            groupBoxFoodTypes.TabStop = false;
            groupBoxFoodTypes.Text = "Select type";
            // 
            // radioButtonRecipie
            // 
            radioButtonRecipie.AutoSize = true;
            radioButtonRecipie.Location = new Point(141, 23);
            radioButtonRecipie.Name = "radioButtonRecipie";
            radioButtonRecipie.Size = new Size(60, 19);
            radioButtonRecipie.TabIndex = 3;
            radioButtonRecipie.Text = "Recipe";
            radioButtonRecipie.UseVisualStyleBackColor = true;
            radioButtonRecipie.CheckedChanged += radioButtonRecipie_CheckedChanged;
            // 
            // radioButtonLiquid
            // 
            radioButtonLiquid.AutoSize = true;
            radioButtonLiquid.Location = new Point(73, 23);
            radioButtonLiquid.Name = "radioButtonLiquid";
            radioButtonLiquid.Size = new Size(58, 19);
            radioButtonLiquid.TabIndex = 2;
            radioButtonLiquid.Text = "Liquid";
            radioButtonLiquid.UseVisualStyleBackColor = true;
            radioButtonLiquid.CheckedChanged += radioButtonLiquid_CheckedChanged;
            // 
            // radioButtonSolid
            // 
            radioButtonSolid.AutoSize = true;
            radioButtonSolid.Checked = true;
            radioButtonSolid.Location = new Point(10, 23);
            radioButtonSolid.Name = "radioButtonSolid";
            radioButtonSolid.Size = new Size(51, 19);
            radioButtonSolid.TabIndex = 1;
            radioButtonSolid.TabStop = true;
            radioButtonSolid.Text = "Solid";
            radioButtonSolid.UseVisualStyleBackColor = true;
            radioButtonSolid.CheckedChanged += radioButtonSolid_CheckedChanged;
            // 
            // buttonAddFood
            // 
            buttonAddFood.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddFood.Location = new Point(208, 773);
            buttonAddFood.Name = "buttonAddFood";
            buttonAddFood.Size = new Size(75, 23);
            buttonAddFood.TabIndex = 5;
            buttonAddFood.Text = "Add food";
            buttonAddFood.UseVisualStyleBackColor = true;
            buttonAddFood.Click += buttonAddFood_Click;
            // 
            // buttonCancelAddFood
            // 
            buttonCancelAddFood.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCancelAddFood.Location = new Point(306, 773);
            buttonCancelAddFood.Name = "buttonCancelAddFood";
            buttonCancelAddFood.Size = new Size(75, 23);
            buttonCancelAddFood.TabIndex = 6;
            buttonCancelAddFood.Text = "Cancel";
            buttonCancelAddFood.UseVisualStyleBackColor = true;
            buttonCancelAddFood.Click += buttonCancelAddFood_Click;
            // 
            // labelState
            // 
            labelState.AutoSize = true;
            labelState.Location = new Point(222, 28);
            labelState.Name = "labelState";
            labelState.Size = new Size(216, 15);
            labelState.TabIndex = 4;
            labelState.Text = "Nutrition information per 100 grams (g)";
            // 
            // tabControlAddType
            // 
            tabControlAddType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabControlAddType.Controls.Add(tabPageNonRecipie);
            tabControlAddType.Controls.Add(tabPageRecipie);
            tabControlAddType.ItemSize = new Size(50, 10);
            tabControlAddType.Location = new Point(0, 50);
            tabControlAddType.Margin = new Padding(0);
            tabControlAddType.Name = "tabControlAddType";
            tabControlAddType.Padding = new Point(0, 0);
            tabControlAddType.SelectedIndex = 0;
            tabControlAddType.Size = new Size(1159, 711);
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
            tabPageNonRecipie.Size = new Size(1151, 693);
            tabPageNonRecipie.TabIndex = 0;
            tabPageNonRecipie.Text = "Add Non Recipie";
            // 
            // textBoxAlcohol
            // 
            textBoxAlcohol.Location = new Point(201, 638);
            textBoxAlcohol.Name = "textBoxAlcohol";
            textBoxAlcohol.Size = new Size(78, 23);
            textBoxAlcohol.TabIndex = 47;
            textBoxAlcohol.TextAlign = HorizontalAlignment.Right;
            textBoxAlcohol.KeyDown += textBoxAlcohol_KeyDown;
            textBoxAlcohol.Leave += textBoxAlcohol_Leave;
            // 
            // labelAlcohol
            // 
            labelAlcohol.AutoSize = true;
            labelAlcohol.Location = new Point(26, 641);
            labelAlcohol.Name = "labelAlcohol";
            labelAlcohol.Size = new Size(66, 15);
            labelAlcohol.TabIndex = 46;
            labelAlcohol.Text = "Alcohol (g)";
            // 
            // textBoxCholesterol
            // 
            textBoxCholesterol.Location = new Point(201, 611);
            textBoxCholesterol.Name = "textBoxCholesterol";
            textBoxCholesterol.Size = new Size(78, 23);
            textBoxCholesterol.TabIndex = 45;
            textBoxCholesterol.TextAlign = HorizontalAlignment.Right;
            textBoxCholesterol.KeyDown += textBoxCholesterol_KeyDown;
            textBoxCholesterol.Leave += textBoxCholesterol_Leave;
            // 
            // labelCholesterol
            // 
            labelCholesterol.AutoSize = true;
            labelCholesterol.Location = new Point(26, 614);
            labelCholesterol.Name = "labelCholesterol";
            labelCholesterol.Size = new Size(96, 15);
            labelCholesterol.TabIndex = 44;
            labelCholesterol.Text = "Cholesterol (mg)";
            // 
            // textBoxCaffeine
            // 
            textBoxCaffeine.Location = new Point(201, 584);
            textBoxCaffeine.Name = "textBoxCaffeine";
            textBoxCaffeine.Size = new Size(78, 23);
            textBoxCaffeine.TabIndex = 43;
            textBoxCaffeine.TextAlign = HorizontalAlignment.Right;
            textBoxCaffeine.KeyDown += textBoxCaffeine_KeyDown;
            textBoxCaffeine.Leave += textBoxCaffeine_Leave;
            // 
            // labelCaffeine
            // 
            labelCaffeine.AutoSize = true;
            labelCaffeine.Location = new Point(26, 587);
            labelCaffeine.Name = "labelCaffeine";
            labelCaffeine.Size = new Size(80, 15);
            labelCaffeine.TabIndex = 42;
            labelCaffeine.Text = "Caffeine (mg)";
            // 
            // textBoxVitaminC
            // 
            textBoxVitaminC.Location = new Point(201, 557);
            textBoxVitaminC.Name = "textBoxVitaminC";
            textBoxVitaminC.Size = new Size(78, 23);
            textBoxVitaminC.TabIndex = 41;
            textBoxVitaminC.TextAlign = HorizontalAlignment.Right;
            textBoxVitaminC.KeyDown += textBoxVitaminC_KeyDown;
            textBoxVitaminC.Leave += textBoxVitaminC_Leave;
            // 
            // labelVitaminC
            // 
            labelVitaminC.AutoSize = true;
            labelVitaminC.Location = new Point(26, 560);
            labelVitaminC.Name = "labelVitaminC";
            labelVitaminC.Size = new Size(88, 15);
            labelVitaminC.TabIndex = 40;
            labelVitaminC.Text = "Vitamin C (mg)";
            // 
            // textBoxMagnesiumMg
            // 
            textBoxMagnesiumMg.Location = new Point(201, 530);
            textBoxMagnesiumMg.Name = "textBoxMagnesiumMg";
            textBoxMagnesiumMg.Size = new Size(78, 23);
            textBoxMagnesiumMg.TabIndex = 39;
            textBoxMagnesiumMg.TextAlign = HorizontalAlignment.Right;
            textBoxMagnesiumMg.KeyDown += textBoxMagnesiumMg_KeyDown;
            textBoxMagnesiumMg.Leave += textBoxMagnesiumMg_Leave;
            // 
            // labelMagnesiumMg
            // 
            labelMagnesiumMg.AutoSize = true;
            labelMagnesiumMg.Location = new Point(26, 533);
            labelMagnesiumMg.Name = "labelMagnesiumMg";
            labelMagnesiumMg.Size = new Size(120, 15);
            labelMagnesiumMg.TabIndex = 38;
            labelMagnesiumMg.Text = "Magnesium Mg (mg)";
            // 
            // textBoxIronFe
            // 
            textBoxIronFe.Location = new Point(201, 503);
            textBoxIronFe.Name = "textBoxIronFe";
            textBoxIronFe.Size = new Size(78, 23);
            textBoxIronFe.TabIndex = 37;
            textBoxIronFe.TextAlign = HorizontalAlignment.Right;
            textBoxIronFe.KeyDown += textBoxIronFe_KeyDown;
            textBoxIronFe.Leave += textBoxIronFe_Leave;
            // 
            // labelIronFe
            // 
            labelIronFe.AutoSize = true;
            labelIronFe.Location = new Point(26, 506);
            labelIronFe.Name = "labelIronFe";
            labelIronFe.Size = new Size(72, 15);
            labelIronFe.TabIndex = 36;
            labelIronFe.Text = "Iron Fe (mg)";
            // 
            // textBoxFolate
            // 
            textBoxFolate.Location = new Point(201, 476);
            textBoxFolate.Name = "textBoxFolate";
            textBoxFolate.Size = new Size(78, 23);
            textBoxFolate.TabIndex = 35;
            textBoxFolate.TextAlign = HorizontalAlignment.Right;
            textBoxFolate.KeyDown += textBoxFolate_KeyDown;
            textBoxFolate.Leave += textBoxFolate_Leave;
            // 
            // labelFolate
            // 
            labelFolate.AutoSize = true;
            labelFolate.Location = new Point(26, 479);
            labelFolate.Name = "labelFolate";
            labelFolate.Size = new Size(64, 15);
            labelFolate.TabIndex = 34;
            labelFolate.Text = "Folate (ug)";
            // 
            // textBoxNiacinB3
            // 
            textBoxNiacinB3.Location = new Point(201, 449);
            textBoxNiacinB3.Name = "textBoxNiacinB3";
            textBoxNiacinB3.Size = new Size(78, 23);
            textBoxNiacinB3.TabIndex = 33;
            textBoxNiacinB3.TextAlign = HorizontalAlignment.Right;
            textBoxNiacinB3.KeyDown += textBoxNiacinB3_KeyDown;
            textBoxNiacinB3.Leave += textBoxNiacinB3_Leave;
            // 
            // labelNiacinB3
            // 
            labelNiacinB3.AutoSize = true;
            labelNiacinB3.Location = new Point(26, 452);
            labelNiacinB3.Name = "labelNiacinB3";
            labelNiacinB3.Size = new Size(86, 15);
            labelNiacinB3.TabIndex = 32;
            labelNiacinB3.Text = "Niacin B3 (mg)";
            // 
            // textBoxRiboflavinB2
            // 
            textBoxRiboflavinB2.Location = new Point(201, 422);
            textBoxRiboflavinB2.Name = "textBoxRiboflavinB2";
            textBoxRiboflavinB2.Size = new Size(78, 23);
            textBoxRiboflavinB2.TabIndex = 31;
            textBoxRiboflavinB2.TextAlign = HorizontalAlignment.Right;
            textBoxRiboflavinB2.KeyDown += textBoxRiboflavinB2_KeyDown;
            textBoxRiboflavinB2.Leave += textBoxRiboflavinB2_Leave;
            // 
            // labelRiboflavinB2
            // 
            labelRiboflavinB2.AutoSize = true;
            labelRiboflavinB2.Location = new Point(26, 425);
            labelRiboflavinB2.Name = "labelRiboflavinB2";
            labelRiboflavinB2.Size = new Size(105, 15);
            labelRiboflavinB2.TabIndex = 30;
            labelRiboflavinB2.Text = "Riboflavin B2 (mg)";
            // 
            // textBoxThiaminB1
            // 
            textBoxThiaminB1.Location = new Point(201, 395);
            textBoxThiaminB1.Name = "textBoxThiaminB1";
            textBoxThiaminB1.Size = new Size(78, 23);
            textBoxThiaminB1.TabIndex = 29;
            textBoxThiaminB1.TextAlign = HorizontalAlignment.Right;
            textBoxThiaminB1.KeyDown += textBoxThiaminB1_KeyDown;
            textBoxThiaminB1.Leave += textBoxThiaminB1_Leave;
            // 
            // labelThiaminB1
            // 
            labelThiaminB1.AutoSize = true;
            labelThiaminB1.Location = new Point(26, 398);
            labelThiaminB1.Name = "labelThiaminB1";
            labelThiaminB1.Size = new Size(95, 15);
            labelThiaminB1.TabIndex = 28;
            labelThiaminB1.Text = "Thiamin B1 (mg)";
            // 
            // textBoxPotassiumK
            // 
            textBoxPotassiumK.Location = new Point(201, 368);
            textBoxPotassiumK.Name = "textBoxPotassiumK";
            textBoxPotassiumK.Size = new Size(78, 23);
            textBoxPotassiumK.TabIndex = 27;
            textBoxPotassiumK.TextAlign = HorizontalAlignment.Right;
            textBoxPotassiumK.KeyDown += textBoxPotassiumK_KeyDown;
            textBoxPotassiumK.Leave += textBoxPotassiumK_Leave;
            // 
            // labelPotassiumK
            // 
            labelPotassiumK.AutoSize = true;
            labelPotassiumK.Location = new Point(26, 371);
            labelPotassiumK.Name = "labelPotassiumK";
            labelPotassiumK.Size = new Size(101, 15);
            labelPotassiumK.TabIndex = 26;
            labelPotassiumK.Text = "Potassium K (mg)";
            // 
            // textBoxCalciumCa
            // 
            textBoxCalciumCa.Location = new Point(201, 341);
            textBoxCalciumCa.Name = "textBoxCalciumCa";
            textBoxCalciumCa.Size = new Size(78, 23);
            textBoxCalciumCa.TabIndex = 25;
            textBoxCalciumCa.TextAlign = HorizontalAlignment.Right;
            textBoxCalciumCa.KeyDown += textBoxCalciumCa_KeyDown;
            textBoxCalciumCa.Leave += textBoxCalciumCa_Leave;
            // 
            // labelCalciumCa
            // 
            labelCalciumCa.AutoSize = true;
            labelCalciumCa.Location = new Point(26, 344);
            labelCalciumCa.Name = "labelCalciumCa";
            labelCalciumCa.Size = new Size(97, 15);
            labelCalciumCa.TabIndex = 24;
            labelCalciumCa.Text = "Calcium Ca (mg)";
            // 
            // textBoxSodiumNa
            // 
            textBoxSodiumNa.Location = new Point(201, 314);
            textBoxSodiumNa.Name = "textBoxSodiumNa";
            textBoxSodiumNa.Size = new Size(78, 23);
            textBoxSodiumNa.TabIndex = 23;
            textBoxSodiumNa.TextAlign = HorizontalAlignment.Right;
            textBoxSodiumNa.KeyDown += textBoxSodiumNa_KeyDown;
            textBoxSodiumNa.Leave += textBoxSodiumNa_Leave;
            // 
            // labelSodiumNa
            // 
            labelSodiumNa.AutoSize = true;
            labelSodiumNa.Location = new Point(26, 317);
            labelSodiumNa.Name = "labelSodiumNa";
            labelSodiumNa.Size = new Size(95, 15);
            labelSodiumNa.TabIndex = 22;
            labelSodiumNa.Text = "Sodium Na (mg)";
            // 
            // textBoxDietaryFibre
            // 
            textBoxDietaryFibre.Location = new Point(201, 287);
            textBoxDietaryFibre.Name = "textBoxDietaryFibre";
            textBoxDietaryFibre.Size = new Size(78, 23);
            textBoxDietaryFibre.TabIndex = 21;
            textBoxDietaryFibre.TextAlign = HorizontalAlignment.Right;
            textBoxDietaryFibre.KeyDown += textBoxDietaryFibre_KeyDown;
            textBoxDietaryFibre.Leave += textBoxDietaryFibre_Leave;
            // 
            // labelDietaryFibre
            // 
            labelDietaryFibre.AutoSize = true;
            labelDietaryFibre.Location = new Point(26, 290);
            labelDietaryFibre.Name = "labelDietaryFibre";
            labelDietaryFibre.Size = new Size(91, 15);
            labelDietaryFibre.TabIndex = 20;
            labelDietaryFibre.Text = "Dietary Fibre (g)";
            // 
            // textBoxSugars
            // 
            textBoxSugars.Location = new Point(201, 260);
            textBoxSugars.Name = "textBoxSugars";
            textBoxSugars.Size = new Size(78, 23);
            textBoxSugars.TabIndex = 19;
            textBoxSugars.TextAlign = HorizontalAlignment.Right;
            textBoxSugars.KeyDown += textBoxSugars_KeyDown;
            textBoxSugars.Leave += textBoxSugars_Leave;
            // 
            // labelSugars
            // 
            labelSugars.AutoSize = true;
            labelSugars.Location = new Point(26, 263);
            labelSugars.Name = "labelSugars";
            labelSugars.Size = new Size(77, 15);
            labelSugars.TabIndex = 18;
            labelSugars.Text = "   - Sugars (g)";
            // 
            // textBoxCarbohydrate
            // 
            textBoxCarbohydrate.Location = new Point(201, 233);
            textBoxCarbohydrate.Name = "textBoxCarbohydrate";
            textBoxCarbohydrate.Size = new Size(78, 23);
            textBoxCarbohydrate.TabIndex = 17;
            textBoxCarbohydrate.TextAlign = HorizontalAlignment.Right;
            textBoxCarbohydrate.KeyDown += textBoxCarbohydrate_KeyDown;
            textBoxCarbohydrate.Leave += textBoxCarbohydrate_Leave;
            // 
            // labelCarbohydrate
            // 
            labelCarbohydrate.AutoSize = true;
            labelCarbohydrate.Location = new Point(26, 236);
            labelCarbohydrate.Name = "labelCarbohydrate";
            labelCarbohydrate.Size = new Size(97, 15);
            labelCarbohydrate.TabIndex = 16;
            labelCarbohydrate.Text = "Carbohydrate (g)";
            // 
            // textBoxMonounsaturatedFat
            // 
            textBoxMonounsaturatedFat.Location = new Point(201, 206);
            textBoxMonounsaturatedFat.Name = "textBoxMonounsaturatedFat";
            textBoxMonounsaturatedFat.Size = new Size(78, 23);
            textBoxMonounsaturatedFat.TabIndex = 15;
            textBoxMonounsaturatedFat.TextAlign = HorizontalAlignment.Right;
            textBoxMonounsaturatedFat.KeyDown += textBoxMonounsaturatedFat_KeyDown;
            textBoxMonounsaturatedFat.Leave += textBoxMonounsaturatedFat_Leave;
            // 
            // labelMonounsaturatedFat
            // 
            labelMonounsaturatedFat.AutoSize = true;
            labelMonounsaturatedFat.Location = new Point(26, 209);
            labelMonounsaturatedFat.Name = "labelMonounsaturatedFat";
            labelMonounsaturatedFat.Size = new Size(156, 15);
            labelMonounsaturatedFat.TabIndex = 14;
            labelMonounsaturatedFat.Text = "   - Monounsaturated Fat (g)";
            // 
            // textBoxPolyunsaturatedFat
            // 
            textBoxPolyunsaturatedFat.Location = new Point(201, 179);
            textBoxPolyunsaturatedFat.Name = "textBoxPolyunsaturatedFat";
            textBoxPolyunsaturatedFat.Size = new Size(78, 23);
            textBoxPolyunsaturatedFat.TabIndex = 13;
            textBoxPolyunsaturatedFat.TextAlign = HorizontalAlignment.Right;
            textBoxPolyunsaturatedFat.KeyDown += textBoxPolyunsaturatedFat_KeyDown;
            textBoxPolyunsaturatedFat.Leave += textBoxPolyunsaturatedFat_Leave;
            // 
            // labelPolyunsaturatedFat
            // 
            labelPolyunsaturatedFat.AutoSize = true;
            labelPolyunsaturatedFat.Location = new Point(26, 182);
            labelPolyunsaturatedFat.Name = "labelPolyunsaturatedFat";
            labelPolyunsaturatedFat.Size = new Size(147, 15);
            labelPolyunsaturatedFat.TabIndex = 12;
            labelPolyunsaturatedFat.Text = "   - Polyunsaturated Fat (g)";
            // 
            // textBoxTransFat
            // 
            textBoxTransFat.Location = new Point(201, 152);
            textBoxTransFat.Name = "textBoxTransFat";
            textBoxTransFat.Size = new Size(78, 23);
            textBoxTransFat.TabIndex = 11;
            textBoxTransFat.TextAlign = HorizontalAlignment.Right;
            textBoxTransFat.KeyDown += textBoxTransFat_KeyDown;
            textBoxTransFat.Leave += textBoxTransFat_Leave;
            // 
            // labelTransFat
            // 
            labelTransFat.AutoSize = true;
            labelTransFat.Location = new Point(26, 155);
            labelTransFat.Name = "labelTransFat";
            labelTransFat.Size = new Size(99, 15);
            labelTransFat.TabIndex = 10;
            labelTransFat.Text = "   - Trans Fat (mg)";
            // 
            // textBoxSaturatedFat
            // 
            textBoxSaturatedFat.Location = new Point(201, 125);
            textBoxSaturatedFat.Name = "textBoxSaturatedFat";
            textBoxSaturatedFat.Size = new Size(78, 23);
            textBoxSaturatedFat.TabIndex = 9;
            textBoxSaturatedFat.TextAlign = HorizontalAlignment.Right;
            textBoxSaturatedFat.KeyDown += textBoxSaturatedFat_KeyDown;
            textBoxSaturatedFat.Leave += textBoxSaturatedFat_Leave;
            // 
            // labelSaturatedFat
            // 
            labelSaturatedFat.AutoSize = true;
            labelSaturatedFat.Location = new Point(26, 128);
            labelSaturatedFat.Name = "labelSaturatedFat";
            labelSaturatedFat.Size = new Size(111, 15);
            labelSaturatedFat.TabIndex = 8;
            labelSaturatedFat.Text = "   - Saturated Fat (g)";
            // 
            // textBoxFatTotal
            // 
            textBoxFatTotal.Location = new Point(201, 98);
            textBoxFatTotal.Name = "textBoxFatTotal";
            textBoxFatTotal.Size = new Size(78, 23);
            textBoxFatTotal.TabIndex = 7;
            textBoxFatTotal.TextAlign = HorizontalAlignment.Right;
            textBoxFatTotal.KeyDown += textBoxFatTotal_KeyDown;
            textBoxFatTotal.Leave += textBoxFatTotal_Leave;
            // 
            // labelFatTotal
            // 
            labelFatTotal.AutoSize = true;
            labelFatTotal.Location = new Point(26, 101);
            labelFatTotal.Name = "labelFatTotal";
            labelFatTotal.Size = new Size(69, 15);
            labelFatTotal.TabIndex = 6;
            labelFatTotal.Text = "Fat Total (g)";
            // 
            // textBoxProtein
            // 
            textBoxProtein.Location = new Point(201, 71);
            textBoxProtein.Name = "textBoxProtein";
            textBoxProtein.Size = new Size(78, 23);
            textBoxProtein.TabIndex = 5;
            textBoxProtein.TextAlign = HorizontalAlignment.Right;
            textBoxProtein.KeyDown += textBoxProtein_KeyDown;
            textBoxProtein.Leave += textBoxProtein_Leave;
            // 
            // textBoxEnergy
            // 
            textBoxEnergy.Location = new Point(201, 44);
            textBoxEnergy.Name = "textBoxEnergy";
            textBoxEnergy.Size = new Size(78, 23);
            textBoxEnergy.TabIndex = 4;
            textBoxEnergy.TextAlign = HorizontalAlignment.Right;
            textBoxEnergy.KeyDown += textBoxEnergy_KeyDown;
            textBoxEnergy.Leave += textBoxEnergy_Leave;
            // 
            // textBoxFoodDescription
            // 
            textBoxFoodDescription.Location = new Point(201, 17);
            textBoxFoodDescription.Name = "textBoxFoodDescription";
            textBoxFoodDescription.Size = new Size(538, 23);
            textBoxFoodDescription.TabIndex = 3;
            textBoxFoodDescription.KeyDown += textBoxFoodDescription_KeyDown;
            textBoxFoodDescription.Leave += textBoxFoodDescription_Leave;
            // 
            // labelProtein
            // 
            labelProtein.AutoSize = true;
            labelProtein.Location = new Point(26, 74);
            labelProtein.Name = "labelProtein";
            labelProtein.Size = new Size(63, 15);
            labelProtein.TabIndex = 2;
            labelProtein.Text = "Protein (g)";
            // 
            // labelEnergy
            // 
            labelEnergy.AutoSize = true;
            labelEnergy.Location = new Point(26, 47);
            labelEnergy.Name = "labelEnergy";
            labelEnergy.Size = new Size(64, 15);
            labelEnergy.TabIndex = 1;
            labelEnergy.Text = "Energy (kJ)";
            // 
            // labelFoodDescription
            // 
            labelFoodDescription.AutoSize = true;
            labelFoodDescription.Location = new Point(26, 20);
            labelFoodDescription.Name = "labelFoodDescription";
            labelFoodDescription.Size = new Size(96, 15);
            labelFoodDescription.TabIndex = 0;
            labelFoodDescription.Text = "Food description";
            // 
            // tabPageRecipie
            // 
            tabPageRecipie.BackColor = Color.Silver;
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
            tabPageRecipie.Size = new Size(1151, 693);
            tabPageRecipie.TabIndex = 1;
            tabPageRecipie.Text = "Add Recipie";
            // 
            // labelFilterRecipe
            // 
            labelFilterRecipe.AutoSize = true;
            labelFilterRecipe.BackColor = Color.LightCyan;
            labelFilterRecipe.Location = new Point(154, 98);
            labelFilterRecipe.Name = "labelFilterRecipe";
            labelFilterRecipe.Size = new Size(59, 15);
            labelFilterRecipe.TabIndex = 10;
            labelFilterRecipe.Text = "Unfiltered";
            // 
            // textBoxFilterRecipe
            // 
            textBoxFilterRecipe.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxFilterRecipe.AutoCompleteSource = AutoCompleteSource.HistoryList;
            textBoxFilterRecipe.Location = new Point(13, 95);
            textBoxFilterRecipe.Name = "textBoxFilterRecipe";
            textBoxFilterRecipe.PlaceholderText = "Enter food filter text";
            textBoxFilterRecipe.Size = new Size(135, 23);
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Azure;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewAddToRecipe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewAddToRecipe.ColumnHeadersHeight = 30;
            dataGridViewAddToRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewAddToRecipe.Columns.AddRange(new DataGridViewColumn[] { foodDescriptionDataGridViewTextBoxColumn });
            dataGridViewAddToRecipe.DataSource = foodBindingSource;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Info;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewAddToRecipe.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewAddToRecipe.EnableHeadersVisualStyles = false;
            dataGridViewAddToRecipe.Location = new Point(8, 139);
            dataGridViewAddToRecipe.Margin = new Padding(0);
            dataGridViewAddToRecipe.MultiSelect = false;
            dataGridViewAddToRecipe.Name = "dataGridViewAddToRecipe";
            dataGridViewAddToRecipe.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewAddToRecipe.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewAddToRecipe.RowHeadersVisible = false;
            dataGridViewAddToRecipe.RowTemplate.Height = 25;
            dataGridViewAddToRecipe.ScrollBars = ScrollBars.Vertical;
            dataGridViewAddToRecipe.ShowCellErrors = false;
            dataGridViewAddToRecipe.ShowEditingIcon = false;
            dataGridViewAddToRecipe.ShowRowErrors = false;
            dataGridViewAddToRecipe.Size = new Size(453, 546);
            dataGridViewAddToRecipe.TabIndex = 8;
            dataGridViewAddToRecipe.CellDoubleClick += dataGridViewAddToRecipe_CellDoubleClick;
            dataGridViewAddToRecipe.KeyDown += dataGridViewAddToRecipe_KeyDown;
            // 
            // foodDescriptionDataGridViewTextBoxColumn
            // 
            foodDescriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foodDescriptionDataGridViewTextBoxColumn.DataPropertyName = "FoodDescription";
            foodDescriptionDataGridViewTextBoxColumn.HeaderText = "Select food for recipe";
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
            textBox2.Location = new Point(725, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(377, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(725, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(377, 23);
            textBox1.TabIndex = 6;
            // 
            // textBoxRecipeFoodDescription
            // 
            textBoxRecipeFoodDescription.Location = new Point(138, 17);
            textBoxRecipeFoodDescription.Name = "textBoxRecipeFoodDescription";
            textBoxRecipeFoodDescription.Size = new Size(538, 23);
            textBoxRecipeFoodDescription.TabIndex = 5;
            textBoxRecipeFoodDescription.Leave += textBoxRecipeFoodDescription_Leave;
            // 
            // labelRecipeFoodDescription
            // 
            labelRecipeFoodDescription.AutoSize = true;
            labelRecipeFoodDescription.Location = new Point(26, 20);
            labelRecipeFoodDescription.Name = "labelRecipeFoodDescription";
            labelRecipeFoodDescription.Size = new Size(96, 15);
            labelRecipeFoodDescription.TabIndex = 4;
            labelRecipeFoodDescription.Text = "Food description";
            // 
            // foodInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 808);
            ControlBox = false;
            Controls.Add(tabControlAddType);
            Controls.Add(labelState);
            Controls.Add(buttonCancelAddFood);
            Controls.Add(buttonAddFood);
            Controls.Add(groupBoxFoodTypes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
    }
}