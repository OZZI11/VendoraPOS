using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendora.AddForm;
using Vendora.Data;
using InfastructureLayer.Repositories;

namespace Vendora
{
    public partial class AdminProduct : Form
    {
        public readonly IOnhandRepository? context;
        public DomainLayer.Models.OnhandProducts OnhandProductsEntity;

        public AdminProduct(IOnhandRepository context)
        {
            InitializeComponent();
            this.context = context;

        }

        public void getProducts()
        {
           
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm(context);
            addProductForm.AdminProduct = this;

            addProductForm.ShowDialog();

        }

        private void AdminProduct_Load(object sender, EventArgs e)
        {
            getProducts();
        }
    }
}
