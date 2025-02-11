namespace Vendora
{
    partial class LoginForm
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
            Proceed = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // Proceed
            // 
            Proceed.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Proceed.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Proceed.Depth = 0;
            Proceed.HighEmphasis = true;
            Proceed.Icon = null;
            Proceed.Location = new Point(298, 201);
            Proceed.Margin = new Padding(4, 6, 4, 6);
            Proceed.MouseState = MaterialSkin.MouseState.HOVER;
            Proceed.Name = "Proceed";
            Proceed.NoAccentTextColor = Color.Empty;
            Proceed.Size = new Size(158, 36);
            Proceed.TabIndex = 0;
            Proceed.Text = "GO";
            Proceed.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Proceed.UseAccentColor = false;
            Proceed.UseVisualStyleBackColor = true;
            Proceed.Click += materialButton1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Proceed);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton Proceed;
    }
}
