namespace Food_and_Beverage
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Beverages = new System.Windows.Forms.TextBox();
            this.Food = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Beverages
            // 
            this.Beverages.Location = new System.Drawing.Point(107, 56);
            this.Beverages.Multiline = true;
            this.Beverages.Name = "Beverages";
            this.Beverages.Size = new System.Drawing.Size(379, 402);
            this.Beverages.TabIndex = 0;
            this.Beverages.TextChanged += new System.EventHandler(this.Beverages_TextChanged);
            // 
            // Food
            // 
            this.Food.Location = new System.Drawing.Point(626, 56);
            this.Food.Multiline = true;
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(379, 402);
            this.Food.TabIndex = 1;
            this.Food.TextChanged += new System.EventHandler(this.Food_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 503);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.Beverages);
            this.Name = "Form1";
            this.Text = "Food & Bevarage Selector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Beverages;
        private TextBox Food;
    }
}