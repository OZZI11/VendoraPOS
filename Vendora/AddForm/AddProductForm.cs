    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using InfastructureLayer.Repositories;
using Vendora.Data;

namespace Vendora.AddForm
{


    public partial class AddProductForm : Form
    {
        public readonly IOnhandRepository? context;
        internal AdminProduct AdminProduct;

        public AddProductForm(IOnhandRepository? context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {


        }

        private void ProductConfirmButton_Click(object sender, EventArgs e)
        {
            var entity = AdminProduct.OnhandProductsEntity;
            entity = new DomainLayer.Models.OnhandProducts
            {
                BARCODE = BARCODE.Text,
                Name = Name.Text,
                Description = Description.Text,
                Brand = Brand.Text,
                Category = Category.Text,
                Price = double.TryParse(Price.Text, out var priceValue) ? priceValue : 0,
                Reorder = int.TryParse(Reorder.Text, out var reorderValue) ? reorderValue : 0
            };
            context.Add(entity);
            context.Save();

            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AdminProduct.getProducts();

        }
    }

}
      




