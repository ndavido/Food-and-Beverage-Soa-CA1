namespace Food_and_Beverage
{
    partial class MealControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.FoodListBox = new System.Windows.Forms.ListBox();
            this.mealPictureBox = new System.Windows.Forms.PictureBox();
            this.ingredientsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.instructionTextBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.mealPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FoodListBox
            // 
            this.FoodListBox.FormattingEnabled = true;
            this.FoodListBox.ItemHeight = 20;
            this.FoodListBox.Location = new System.Drawing.Point(0, 0);
            this.FoodListBox.Name = "FoodListBox";
            this.FoodListBox.Size = new System.Drawing.Size(175, 324);
            this.FoodListBox.TabIndex = 4;
            // 
            // mealPictureBox
            // 
            this.mealPictureBox.Image = global::Food_and_Beverage.Properties.Resources.imageLoad;
            this.mealPictureBox.Location = new System.Drawing.Point(175, 0);
            this.mealPictureBox.Name = "mealPictureBox";
            this.mealPictureBox.Size = new System.Drawing.Size(384, 384);
            this.mealPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mealPictureBox.TabIndex = 6;
            this.mealPictureBox.TabStop = false;
            // 
            // ingredientsListBox
            // 
            this.ingredientsListBox.BackColor = System.Drawing.Color.White;
            this.ingredientsListBox.FormattingEnabled = true;
            this.ingredientsListBox.ItemHeight = 20;
            this.ingredientsListBox.Location = new System.Drawing.Point(621, 40);
            this.ingredientsListBox.Name = "ingredientsListBox";
            this.ingredientsListBox.Size = new System.Drawing.Size(250, 144);
            this.ingredientsListBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(621, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "List of Ingredients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(621, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Instructions";
            // 
            // instructionTextBox
            // 
            this.instructionTextBox.Location = new System.Drawing.Point(621, 227);
            this.instructionTextBox.Multiline = true;
            this.instructionTextBox.Name = "instructionTextBox";
            this.instructionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.instructionTextBox.Size = new System.Drawing.Size(250, 134);
            this.instructionTextBox.TabIndex = 10;
            // 
            // saveBtn
            // 
            this.saveBtn.CheckedState.CustomBorderColor = System.Drawing.Color.DarkSlateBlue;
            this.saveBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.saveBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.saveBtn.CustomizableEdges = customizableEdges1;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.FillColor = System.Drawing.Color.White;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveBtn.HoverState.CustomBorderColor = System.Drawing.Color.DarkSlateBlue;
            this.saveBtn.Location = new System.Drawing.Point(0, 326);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.saveBtn.Size = new System.Drawing.Size(175, 58);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Save Recipe";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // MealControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.instructionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingredientsListBox);
            this.Controls.Add(this.mealPictureBox);
            this.Controls.Add(this.FoodListBox);
            this.Name = "MealControl";
            this.Size = new System.Drawing.Size(936, 384);
            ((System.ComponentModel.ISupportInitialize)(this.mealPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox FoodListBox;
        private PictureBox mealPictureBox;
        private ListBox ingredientsListBox;
        private Label label1;
        private Label label2;
        private TextBox instructionTextBox;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
    }
}
