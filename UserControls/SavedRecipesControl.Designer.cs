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
            this.SavedRecipeBox = new System.Windows.Forms.ListBox();
            this.mealPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ingredientsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.instructionTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mealPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SavedRecipeBox
            // 
            this.SavedRecipeBox.FormattingEnabled = true;
            this.SavedRecipeBox.ItemHeight = 20;
            this.SavedRecipeBox.Location = new System.Drawing.Point(0, 0);
            this.SavedRecipeBox.Name = "SavedRecipeBox";
            this.SavedRecipeBox.Size = new System.Drawing.Size(175, 384);
            this.SavedRecipeBox.TabIndex = 5;
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(621, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "List of Ingredients";
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
            // SavedRecipesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.instructionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ingredientsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mealPictureBox);
            this.Controls.Add(this.SavedRecipeBox);
            this.Name = "SavedRecipesControl";
            this.Size = new System.Drawing.Size(936, 384);
            ((System.ComponentModel.ISupportInitialize)(this.mealPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox SavedRecipeBox;
        private PictureBox mealPictureBox;
        private Label label1;
        private ListBox ingredientsListBox;
        private Label label2;
        private TextBox instructionTextBox;
    }
}
