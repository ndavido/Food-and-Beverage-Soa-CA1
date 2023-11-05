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
            this.components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.BeveragesListBox = new System.Windows.Forms.ListBox();
            this.beveragePictureBox = new System.Windows.Forms.PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.ingredientsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.instructionTextBox = new System.Windows.Forms.TextBox();
            this.savedBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.beveragePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(621, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Ingredients";
            // 
            // BeveragesListBox
            // 
            this.BeveragesListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BeveragesListBox.FormattingEnabled = true;
            this.BeveragesListBox.ItemHeight = 20;
            this.BeveragesListBox.Location = new System.Drawing.Point(0, 0);
            this.BeveragesListBox.Name = "BeveragesListBox";
            this.BeveragesListBox.Size = new System.Drawing.Size(175, 324);
            this.BeveragesListBox.TabIndex = 3;
            // 
            // beveragePictureBox
            // 
            this.beveragePictureBox.Image = global::Food_and_Beverage.Properties.Resources.imageLoad;
            this.beveragePictureBox.Location = new System.Drawing.Point(175, 0);
            this.beveragePictureBox.Name = "beveragePictureBox";
            this.beveragePictureBox.Size = new System.Drawing.Size(384, 384);
            this.beveragePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.beveragePictureBox.TabIndex = 5;
            this.beveragePictureBox.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // ingredientsListBox
            // 
            this.ingredientsListBox.BackColor = System.Drawing.Color.White;
            this.ingredientsListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ingredientsListBox.FormattingEnabled = true;
            this.ingredientsListBox.ItemHeight = 20;
            this.ingredientsListBox.Location = new System.Drawing.Point(621, 40);
            this.ingredientsListBox.Name = "ingredientsListBox";
            this.ingredientsListBox.Size = new System.Drawing.Size(250, 144);
            this.ingredientsListBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(621, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Instructions";
            // 
            // instructionTextBox
            // 
            this.instructionTextBox.Location = new System.Drawing.Point(621, 227);
            this.instructionTextBox.Multiline = true;
            this.instructionTextBox.Name = "instructionTextBox";
            this.instructionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.instructionTextBox.Size = new System.Drawing.Size(250, 134);
            this.instructionTextBox.TabIndex = 9;
            // 
            // savedBtn
            // 
            this.savedBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.savedBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.savedBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.savedBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.savedBtn.CustomizableEdges = customizableEdges1;
            this.savedBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.savedBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.savedBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.savedBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.savedBtn.FillColor = System.Drawing.Color.White;
            this.savedBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.savedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.savedBtn.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.savedBtn.Location = new System.Drawing.Point(0, 326);
            this.savedBtn.Name = "savedBtn";
            this.savedBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.savedBtn.Size = new System.Drawing.Size(175, 58);
            this.savedBtn.TabIndex = 12;
            this.savedBtn.Text = "Saved Recipes";
            // 
            // BeverageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.savedBtn);
            this.Controls.Add(this.instructionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ingredientsListBox);
            this.Controls.Add(this.beveragePictureBox);
            this.Controls.Add(this.BeveragesListBox);
            this.Controls.Add(this.label1);
            this.Name = "BeverageControl";
            this.Size = new System.Drawing.Size(936, 384);
            ((System.ComponentModel.ISupportInitialize)(this.beveragePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox BeveragesListBox;
        private PictureBox beveragePictureBox;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private ListBox ingredientsListBox;
        private Label label2;
        private TextBox instructionTextBox;
        private Guna.UI2.WinForms.Guna2Button savedBtn;
    }
}
