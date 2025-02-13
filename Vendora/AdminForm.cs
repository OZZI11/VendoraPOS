using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Vendora.AdminClassExtension;
using InfastructureLayer.Repositories;

namespace Vendora
{
    public partial class AdminForm : MaterialForm
    {
        public readonly IOnhandRepository? context;
        public AdminForm()
        {

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.materialTabControl1.SelectedIndexChanged += new EventHandler(materialTabControl1_SelectedIndexChanged);
        }



        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedTab == productTab)
            {
                LoadProductForm();
            }
            else if (materialTabControl1.SelectedTab == vendorTab)
            {
                LoadVendorForm();
            }
            else if (materialTabControl1.SelectedTab == stockEntryTab)
            {
                LoadstockEntryForm();
            }
            else if (materialTabControl1.SelectedTab == stockAdjustmentTab)
            {
                LoadstockAdjustmentForm();
            }
            else if (materialTabControl1.SelectedTab == brandsCategoryTab)
            {
                LoadbrandsCategoryForm();
            }
            else if (materialTabControl1.SelectedTab == recordsTab)
            {
                LoadrecordsTabForm();
            }
            else if (materialTabControl1.SelectedTab == salesHistoryTab)
            {
                LoadSalesHistoryTabForm();
            }
            else if (materialTabControl1.SelectedTab == userAccountsTab)
            {
                LoadUserAccountForm();
            }

        }


        private void LoadProductForm()
        {
            panel1.Controls.Clear();
            AdminProduct adminProduct = new AdminProduct(context);
            adminProduct.TopLevel = false;
            adminProduct.FormBorderStyle = FormBorderStyle.None;
            adminProduct.Dock = DockStyle.Fill;
            panel1.Controls.Add(adminProduct);
            adminProduct.Show();
        }

        private void LoadVendorForm()
        {
            panel2.Controls.Clear();
            VendorForm vendorForm = new VendorForm();
            vendorForm.TopLevel = false;
            vendorForm.FormBorderStyle = FormBorderStyle.None;
            vendorForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(vendorForm);
            vendorForm.Show();
        }
        private void LoadstockEntryForm()
        {
            panel3.Controls.Clear();
            StockEntryForm stockEntryForm = new StockEntryForm();
            stockEntryForm.TopLevel = false;
            stockEntryForm.FormBorderStyle = FormBorderStyle.None;
            stockEntryForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(stockEntryForm);
            stockEntryForm.Show();
        }
        private void LoadstockAdjustmentForm()
        {
            panel4.Controls.Clear();
            StockAdjustmentForm stockAdjustmentForm = new StockAdjustmentForm();
            stockAdjustmentForm.TopLevel = false;
            stockAdjustmentForm.FormBorderStyle = FormBorderStyle.None;
            stockAdjustmentForm.Dock = DockStyle.Fill;
            panel4.Controls.Add(stockAdjustmentForm);
            stockAdjustmentForm.Show();
        }
        private void LoadbrandsCategoryForm()
        {
            panel5.Controls.Clear();
            BrandsCategoryForm brandsCategoryForm = new BrandsCategoryForm();
            brandsCategoryForm.TopLevel = false;
            brandsCategoryForm.FormBorderStyle = FormBorderStyle.None;
            brandsCategoryForm.Dock = DockStyle.Fill;
            panel5.Controls.Add(brandsCategoryForm);
            brandsCategoryForm.Show();
        }
        private void LoadrecordsTabForm()
        {
            panel6.Controls.Clear();
            RecordsForm recordsForm = new RecordsForm();
            recordsForm.TopLevel = false;
            recordsForm.FormBorderStyle = FormBorderStyle.None;
            recordsForm.Dock = DockStyle.Fill;
            panel6.Controls.Add(recordsForm);
            recordsForm.Show();
        }
        private void LoadSalesHistoryTabForm()
        {
            panel7.Controls.Clear();
            SalesHistoryForm salesHistoryForm = new SalesHistoryForm();
            salesHistoryForm.TopLevel = false;
            salesHistoryForm.FormBorderStyle = FormBorderStyle.None;
            salesHistoryForm.Dock = DockStyle.Fill;
            panel7.Controls.Add(salesHistoryForm);
            salesHistoryForm.Show();
        }
        private void LoadUserAccountForm()
        {
            panel8.Controls.Clear();
            UserAccountForm userAccountForm = new UserAccountForm();
            userAccountForm.TopLevel = false;
            userAccountForm.FormBorderStyle = FormBorderStyle.None;
            userAccountForm.Dock = DockStyle.Fill;
            panel8.Controls.Add(userAccountForm);
            userAccountForm.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
