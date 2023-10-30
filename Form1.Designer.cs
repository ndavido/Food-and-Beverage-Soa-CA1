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
            this.BeveragesListBox = new System.Windows.Forms.ListBox();
            this.FoodListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BeveragesListBox
            // 
            this.BeveragesListBox.FormattingEnabled = true;
            this.BeveragesListBox.ItemHeight = 20;
            this.BeveragesListBox.Location = new System.Drawing.Point(12, 12);
            this.BeveragesListBox.Name = "BeveragesListBox";
            this.BeveragesListBox.Size = new System.Drawing.Size(137, 464);
            this.BeveragesListBox.TabIndex = 2;
            // 
            // FoodListBox
            // 
            this.FoodListBox.FormattingEnabled = true;
            this.FoodListBox.ItemHeight = 20;
            this.FoodListBox.Location = new System.Drawing.Point(155, 12);
            this.FoodListBox.Name = "FoodListBox";
            this.FoodListBox.Size = new System.Drawing.Size(137, 464);
            this.FoodListBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 503);
            this.Controls.Add(this.FoodListBox);
            this.Controls.Add(this.BeveragesListBox);
            this.Name = "Form1";
            this.Text = "Food & Bevarage Selector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox BeveragesListBox;
        private ListBox FoodListBox;
    }
}