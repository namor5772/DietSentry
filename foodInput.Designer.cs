﻿namespace DietSentry
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
            groupBoxFoodTypes.SuspendLayout();
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
            groupBoxFoodTypes.Text = "Select type of food to add";
            // 
            // radioButtonRecipie
            // 
            radioButtonRecipie.AutoSize = true;
            radioButtonRecipie.Location = new Point(141, 23);
            radioButtonRecipie.Name = "radioButtonRecipie";
            radioButtonRecipie.Size = new Size(65, 19);
            radioButtonRecipie.TabIndex = 2;
            radioButtonRecipie.TabStop = true;
            radioButtonRecipie.Text = "RECIPIE";
            radioButtonRecipie.UseVisualStyleBackColor = true;
            // 
            // radioButtonLiquid
            // 
            radioButtonLiquid.AutoSize = true;
            radioButtonLiquid.Location = new Point(73, 23);
            radioButtonLiquid.Name = "radioButtonLiquid";
            radioButtonLiquid.Size = new Size(62, 19);
            radioButtonLiquid.TabIndex = 1;
            radioButtonLiquid.TabStop = true;
            radioButtonLiquid.Text = "LIQUID";
            radioButtonLiquid.UseVisualStyleBackColor = true;
            // 
            // radioButtonSolid
            // 
            radioButtonSolid.AutoSize = true;
            radioButtonSolid.Location = new Point(10, 23);
            radioButtonSolid.Name = "radioButtonSolid";
            radioButtonSolid.Size = new Size(57, 19);
            radioButtonSolid.TabIndex = 0;
            radioButtonSolid.TabStop = true;
            radioButtonSolid.Text = "SOLID";
            radioButtonSolid.UseVisualStyleBackColor = true;
            // 
            // foodInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 848);
            Controls.Add(groupBoxFoodTypes);
            Name = "foodInputForm";
            Text = "Form for adding a food to the database";
            groupBoxFoodTypes.ResumeLayout(false);
            groupBoxFoodTypes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxFoodTypes;
        private RadioButton radioButtonLiquid;
        private RadioButton radioButtonSolid;
        private RadioButton radioButtonRecipie;
    }
}