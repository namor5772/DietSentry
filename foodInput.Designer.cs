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
            textBoxSugars = new TextBox();
            labelSugars = new Label();
            textBoxDietaryFibre = new TextBox();
            labelDietaryFibre = new Label();
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
            buttonAddFood.Location = new Point(224, 868);
            buttonAddFood.Name = "buttonAddFood";
            buttonAddFood.Size = new Size(111, 23);
            buttonAddFood.TabIndex = 5;
            buttonAddFood.Text = "Add food";
            buttonAddFood.UseVisualStyleBackColor = true;
            buttonAddFood.Click += buttonAddFood_Click;
            // 
            // buttonCancelAddFood
            // 
            buttonCancelAddFood.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCancelAddFood.Location = new Point(341, 868);
            buttonCancelAddFood.Name = "buttonCancelAddFood";
            buttonCancelAddFood.Size = new Size(110, 23);
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
            tabControlAddType.Size = new Size(765, 812);
            tabControlAddType.SizeMode = TabSizeMode.Fixed;
            tabControlAddType.TabIndex = 5;
            tabControlAddType.TabStop = false;
            // 
            // tabPageNonRecipie
            // 
            tabPageNonRecipie.BackColor = Color.Silver;
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
            tabPageNonRecipie.Size = new Size(757, 794);
            tabPageNonRecipie.TabIndex = 0;
            tabPageNonRecipie.Text = "Add Non Recipie";
            // 
            // textBoxCarbohydrate
            // 
            textBoxCarbohydrate.Location = new Point(183, 233);
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
            textBoxMonounsaturatedFat.Location = new Point(183, 206);
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
            textBoxPolyunsaturatedFat.Location = new Point(183, 179);
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
            textBoxTransFat.Location = new Point(183, 152);
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
            textBoxSaturatedFat.Location = new Point(183, 125);
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
            textBoxFatTotal.Location = new Point(183, 98);
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
            textBoxProtein.Location = new Point(183, 71);
            textBoxProtein.Name = "textBoxProtein";
            textBoxProtein.Size = new Size(78, 23);
            textBoxProtein.TabIndex = 5;
            textBoxProtein.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxEnergy
            // 
            textBoxEnergy.Location = new Point(183, 44);
            textBoxEnergy.Name = "textBoxEnergy";
            textBoxEnergy.Size = new Size(78, 23);
            textBoxEnergy.TabIndex = 4;
            textBoxEnergy.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxFoodDescription
            // 
            textBoxFoodDescription.Location = new Point(183, 17);
            textBoxFoodDescription.Name = "textBoxFoodDescription";
            textBoxFoodDescription.Size = new Size(546, 23);
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
            tabPageRecipie.Size = new Size(757, 794);
            tabPageRecipie.TabIndex = 1;
            tabPageRecipie.Text = "Add Recipie";
            // 
            // textBoxSugars
            // 
            textBoxSugars.Location = new Point(183, 260);
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
            // textBoxDietaryFibre
            // 
            textBoxDietaryFibre.Location = new Point(183, 287);
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
            // foodInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(765, 903);
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
    }
}