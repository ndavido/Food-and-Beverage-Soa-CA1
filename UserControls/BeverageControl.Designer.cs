namespace Food_and_Beverage
{
    partial class BeverageControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.BeveragesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(181, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Beverage Page";
            // 
            // BeveragesListBox
            // 
            this.BeveragesListBox.FormattingEnabled = true;
            this.BeveragesListBox.ItemHeight = 20;
            this.BeveragesListBox.Location = new System.Drawing.Point(0, 0);
            this.BeveragesListBox.Name = "BeveragesListBox";
            this.BeveragesListBox.Size = new System.Drawing.Size(175, 384);
            this.BeveragesListBox.TabIndex = 3;
            // 
            // BeverageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BeveragesListBox);
            this.Controls.Add(this.label1);
            this.Name = "BeverageControl";
            this.Size = new System.Drawing.Size(936, 384);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox BeveragesListBox;
    }
}
