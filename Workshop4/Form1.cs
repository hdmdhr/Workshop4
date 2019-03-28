/**
 * Author: : Louise Acosta
 * Date: March 27, 2019
 **/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel_Experts;

namespace Workshop4
{
    public partial class Form1 : Form
    {
        List<Package> packages = PackageDB.GetPackages();
        List<Products> products = ProductsDB.GetProducts(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            packageBindingSource.DataSource = packages;
        }

        private void packageBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (cmbPackageId.Text == "") { return; }

            var productsList = new List<Products>(); 

            // add to list
            foreach (var product in products)
            {
                if (product.ProductId == Convert.ToInt32(cmbPackageId.Text))
                    productsList.Add(product);
            }

            productBindingSource.DataSource = productsList;  // bind order detail textboxes

            // display order total amount
            int orderID = Convert.ToInt32(cmbPackageId.Text);
        }
    }
}
