namespace Vendora
{
    partial class AdminProduct
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
            AddProductButton = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // AddProductButton
            // 
            AddProductButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddProductButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            AddProductButton.Depth = 0;
            AddProductButton.HighEmphasis = true;
            AddProductButton.Icon = null;
            AddProductButton.Location = new Point(481, 47);
            AddProductButton.Margin = new Padding(4, 6, 4, 6);
            AddProductButton.MouseState = MaterialSkin.MouseState.HOVER;
            AddProductButton.Name = "AddProductButton";
            AddProductButton.NoAccentTextColor = Color.Empty;
            AddProductButton.Size = new Size(158, 36);
            AddProductButton.TabIndex = 0;
            AddProductButton.Text = "Add Product";
            AddProductButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            AddProductButton.UseAccentColor = false;
            AddProductButton.UseVisualStyleBackColor = true;
            // 
            // AdminProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddProductButton);
            Name = "AdminProduct";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton AddProductButton;
    }
}