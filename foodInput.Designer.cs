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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            textBox3 = new TextBox();
            labelIronFe = new Label();
            textBox2 = new TextBox();
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
            groupBoxFoodTypes.SuspendLayout();
            tabControlAddType.SuspendLayout();
            tabPageNonRecipie.SuspendLayout();
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
            radioButtonRecipie.Size = new Size(65, 19);
            radioButtonRecipie.TabIndex = 3;
            radioButtonRecipie.TabStop = true;
            radioButtonRecipie.Text = "RECIPIE";
            radioButtonRecipie.UseVisualStyleBackColor = true;
            radioButtonRecipie.CheckedChanged += radioButtonRecipie_CheckedChanged;
            // 
            // radioButtonLiquid
            // 
            radioButtonLiquid.AutoSize = true;
            radioButtonLiquid.Location = new Point(73, 23);
            radioButtonLiquid.Name = "radioButtonLiquid";
            radioButtonLiquid.Size = new Size(62, 19);
            radioButtonLiquid.TabIndex = 2;
            radioButtonLiquid.TabStop = true;
            radioButtonLiquid.Text = "LIQUID";
            radioButtonLiquid.UseVisualStyleBackColor = true;
            radioButtonLiquid.CheckedChanged += radioButtonLiquid_CheckedChanged;
            // 
            // radioButtonSolid
            // 
            radioButtonSolid.AutoSize = true;
            radioButtonSolid.Location = new Point(10, 23);
            radioButtonSolid.Name = "radioButtonSolid";
            radioButtonSolid.Size = new Size(57, 19);
            radioButtonSolid.TabIndex = 1;
            radioButtonSolid.TabStop = true;
            radioButtonSolid.Text = "SOLID";
            radioButtonSolid.UseVisualStyleBackColor = true;
            radioButtonSolid.CheckedChanged += radioButtonSolid_CheckedChanged;
            // 
            // buttonAddFood
            // 
            buttonAddFood.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddFood.Location = new Point(203, 745);
            buttonAddFood.Name = "buttonAddFood";
            buttonAddFood.Size = new Size(80, 23);
            buttonAddFood.TabIndex = 5;
            buttonAddFood.Text = "Add food";
            buttonAddFood.UseVisualStyleBackColor = true;
            buttonAddFood.Click += buttonAddFood_Click;
            // 
            // buttonCancelAddFood
            // 
            buttonCancelAddFood.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCancelAddFood.Location = new Point(289, 745);
            buttonCancelAddFood.Name = "buttonCancelAddFood";
            buttonCancelAddFood.Size = new Size(80, 23);
            buttonCancelAddFood.TabIndex = 6;
            buttonCancelAddFood.Text = "Cancel";
            buttonCancelAddFood.UseVisualStyleBackColor = true;
            buttonCancelAddFood.Click += buttonCancelAddFood_Click;
            // 
            // labelState
            // 
            labelState.AutoSize = true;
            labelState.Location = new Point(272, 28);
            labelState.Name = "labelState";
            labelState.Size = new Size(109, 15);
            labelState.TabIndex = 4;
            labelState.Text = "Adding SOLID food";
            // 
            // tabControlAddType
            // 
            tabControlAddType.Controls.Add(tabPageNonRecipie);
            tabControlAddType.Controls.Add(tabPageRecipie);
            tabControlAddType.ItemSize = new Size(100, 10);
            tabControlAddType.Location = new Point(0, 50);
            tabControlAddType.Margin = new Padding(0);
            tabControlAddType.Name = "tabControlAddType";
            tabControlAddType.Padding = new Point(0, 0);
            tabControlAddType.SelectedIndex = 0;
            tabControlAddType.Size = new Size(765, 688);
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
            tabPageNonRecipie.Controls.Add(textBox3);
            tabPageNonRecipie.Controls.Add(labelIronFe);
            tabPageNonRecipie.Controls.Add(textBox2);
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
            tabPageNonRecipie.Size = new Size(757, 670);
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
            // textBox3
            // 
            textBox3.Location = new Point(201, 503);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(78, 23);
            textBox3.TabIndex = 37;
            textBox3.TextAlign = HorizontalAlignment.Right;
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
            // textBox2
            // 
            textBox2.Location = new Point(201, 476);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(78, 23);
            textBox2.TabIndex = 35;
            textBox2.TextAlign = HorizontalAlignment.Right;
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
            // 
            // textBoxEnergy
            // 
            textBoxEnergy.Location = new Point(201, 44);
            textBoxEnergy.Name = "textBoxEnergy";
            textBoxEnergy.Size = new Size(78, 23);
            textBoxEnergy.TabIndex = 4;
            textBoxEnergy.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxFoodDescription
            // 
            textBoxFoodDescription.Location = new Point(201, 17);
            textBoxFoodDescription.Name = "textBoxFoodDescription";
            textBoxFoodDescription.Size = new Size(536, 23);
            textBoxFoodDescription.TabIndex = 3;
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
            tabPageRecipie.BackColor = Color.LightSalmon;
            tabPageRecipie.Location = new Point(4, 14);
            tabPageRecipie.Margin = new Padding(0);
            tabPageRecipie.Name = "tabPageRecipie";
            tabPageRecipie.Size = new Size(757, 670);
            tabPageRecipie.TabIndex = 1;
            tabPageRecipie.Text = "Add Recipie";
            // 
            // foodInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(765, 780);
            Controls.Add(tabControlAddType);
            Controls.Add(labelState);
            Controls.Add(buttonCancelAddFood);
            Controls.Add(buttonAddFood);
            Controls.Add(groupBoxFoodTypes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "foodInputForm";
            Text = "Form for adding a food to the database";
            groupBoxFoodTypes.ResumeLayout(false);
            groupBoxFoodTypes.PerformLayout();
            tabControlAddType.ResumeLayout(false);
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
        private TextBox textBox3;
        private Label labelIronFe;
        private TextBox textBox2;
        private Label labelFolate;
        private TextBox textBoxNiacinB3;
        private Label labelNiacinB3;
        private TextBox textBoxAlcohol;
        private Label labelAlcohol;
        private TextBox textBoxCholesterol;
        private Label labelCholesterol;
    }
}