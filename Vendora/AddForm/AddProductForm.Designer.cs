namespace Vendora.AddForm
{
    partial class AddProductForm
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
            label1 = new Label();
            label2 = new Label();
            jj = new MaterialSkin.Controls.MaterialLabel();
            Description = new TextBox();
            Name = new TextBox();
            BARCODE = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Brand = new TextBox();
            Category = new TextBox();
            Price = new TextBox();
            Reorder = new TextBox();
            ProductConfirmButton = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 133);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Barcode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 233);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 3;
            label2.Text = "Prodcut Name";
            // 
            // jj
            // 
            jj.AutoSize = true;
            jj.Depth = 0;
            jj.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            jj.Location = new Point(84, 314);
            jj.MouseState = MaterialSkin.MouseState.HOVER;
            jj.Name = "jj";
            jj.Size = new Size(81, 19);
            jj.TabIndex = 5;
            jj.Text = "Description";
            // 
            // Description
            // 
            Description.Location = new Point(186, 308);
            Description.MinimumSize = new Size(200, 100);
            Description.Name = "Description";
            Description.Size = new Size(200, 100);
            Description.TabIndex = 7;
            // 
            // Name
            // 
            Name.Location = new Point(226, 233);
            Name.Name = "Name";
            Name.Size = new Size(125, 27);
            Name.TabIndex = 8;
            Name.TextChanged += Name_TextChanged;
            // 
            // BARCODE
            // 
            BARCODE.Location = new Point(243, 143);
            BARCODE.Name = "BARCODE";
            BARCODE.Size = new Size(125, 27);
            BARCODE.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(510, 122);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 10;
            label3.Text = "Brand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(510, 178);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 11;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(510, 236);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 12;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(510, 297);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 13;
            label6.Text = "Re-Order Level";
            // 
            // Brand
            // 
            Brand.Location = new Point(631, 119);
            Brand.Name = "Brand";
            Brand.Size = new Size(125, 27);
            Brand.TabIndex = 14;
            // 
            // Category
            // 
            Category.Location = new Point(631, 175);
            Category.Name = "Category";
            Category.Size = new Size(125, 27);
            Category.TabIndex = 15;
            // 
            // Price
            // 
            Price.Location = new Point(631, 226);
            Price.Name = "Price";
            Price.Size = new Size(125, 27);
            Price.TabIndex = 16;
            // 
            // Reorder
            // 
            Reorder.Location = new Point(631, 290);
            Reorder.Name = "Reorder";
            Reorder.Size = new Size(125, 27);
            Reorder.TabIndex = 17;
            // 
            // ProductConfirmButton
            // 
            ProductConfirmButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ProductConfirmButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ProductConfirmButton.Depth = 0;
            ProductConfirmButton.HighEmphasis = true;
            ProductConfirmButton.Icon = null;
            ProductConfirmButton.Location = new Point(598, 382);
            ProductConfirmButton.Margin = new Padding(4, 6, 4, 6);
            ProductConfirmButton.MouseState = MaterialSkin.MouseState.HOVER;
            ProductConfirmButton.Name = "ProductConfirmButton";
            ProductConfirmButton.NoAccentTextColor = Color.Empty;
            ProductConfirmButton.Size = new Size(86, 36);
            ProductConfirmButton.TabIndex = 18;
            ProductConfirmButton.Text = "Confirm";
            ProductConfirmButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ProductConfirmButton.UseAccentColor = false;
            ProductConfirmButton.UseVisualStyleBackColor = true;
            ProductConfirmButton.Click += ProductConfirmButton_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProductConfirmButton);
            Controls.Add(Reorder);
            Controls.Add(Price);
            Controls.Add(Category);
            Controls.Add(Brand);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(BARCODE);
            Controls.Add(Name);
            Controls.Add(Description);
            Controls.Add(jj);
            Controls.Add(label2);
            Controls.Add(label1);
            Text = "AddProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaterialSkin.Controls.MaterialLabel jj;
        private TextBox Description;
        private TextBox Name;
        private TextBox BARCODE;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Brand;
        private TextBox Category;
        private TextBox Price;
        private TextBox Reorder;
        private MaterialSkin.Controls.MaterialButton ProductConfirmButton;
    }
}