namespace Food_and_Beverage.UserControls
{
    partial class SavedRecipesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SavedBeverageBox = new System.Windows.Forms.ListBox();
            this.mealPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ingredientsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.instructionTextBox = new System.Windows.Forms.TextBox();
            this.SavedMealBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mealPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SavedBeverageBox
            // 
            this.SavedBeverageBox.FormattingEnabled = true;
            this.SavedBeverageBox.ItemHeight = 20;
            this.SavedBeverageBox.Location = new System.Drawing.Point(0, 31);
            this.SavedBeverageBox.Name = "SavedBeverageBox";
            this.SavedBeverageBox.Size = new System.Drawing.Size(175, 144);
            this.SavedBeverageBox.TabIndex = 5;
            // 
            // mealPictureBox
            // 
            this.mealPictureBox.Image = global::Food_and_Beverage.Properties.Resources.imageLoad;
            this.mealPictureBox.Location = new System.Drawing.Point(175, 0);
            this.mealPictureBox.Name = "mealPictureBox";
            this.mealPictureBox.Size = new System.Drawing.Size(384, 384);
            this.mealPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mealPictureBox.TabIndex = 7;
            this.mealPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Saved Beverages";
            // 
            // ingredientsListBox
            // 
            this.ingredientsListBox.BackColor = System.Drawing.Color.White;
            this.ingredientsListBox.FormattingEnabled = true;
            this.ingredientsListBox.ItemHeight = 20;
            this.ingredientsListBox.Location = new System.Drawing.Point(621, 40);
            this.ingredientsListBox.Name = "ingredientsListBox";
            this.ingredientsListBox.Size = new System.Drawing.Size(250, 144);
            this.ingredientsListBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(621, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Instructions";
            // 
            // instructionTextBox
            // 
            this.instructionTextBox.Location = new System.Drawing.Point(621, 227);
            this.instructionTextBox.Multiline = true;
            this.instructionTextBox.Name = "instructionTextBox";
            this.instructionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.instructionTextBox.Size = new System.Drawing.Size(250, 134);
            this.instructionTextBox.TabIndex = 12;
            // 
            // SavedMealBox
            // 
            this.SavedMealBox.FormattingEnabled = true;
            this.SavedMealBox.ItemHeight = 20;
            this.SavedMealBox.Location = new System.Drawing.Point(0, 220);
            this.SavedMealBox.Name = "SavedMealBox";
            this.SavedMealBox.Size = new System.Drawing.Size(175, 144);
            this.SavedMealBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Saved Meals";
            // 
            // SavedRecipesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SavedMealBox);
            this.Controls.Add(this.instructionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ingredientsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mealPictureBox);
            this.Controls.Add(this.SavedBeverageBox);
            this.Name = "SavedRecipesControl";
            this.Size = new System.Drawing.Size(936, 384);
            ((System.ComponentModel.ISupportInitialize)(this.mealPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox SavedBeverageBox;
        private PictureBox mealPictureBox;
        private Label label1;
        private ListBox ingredientsListBox;
        private Label label2;
        private TextBox instructionTextBox;
        private ListBox SavedMealBox;
        private Label label3;
    }
}
