using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void packagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.packagesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelExpertsDataSet);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products_Suppliers' table. You can move, or remove it, as needed.
            this.products_SuppliersTableAdapter.Fill(this.travelExpertsDataSet.Products_Suppliers);
            this.suppliersTableAdapter.Fill(this.travelExpertsDataSet.Suppliers);
            this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);
            this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = listBox1.SelectedIndex;
        }

        private bool isExpand = false;

        private void btnShowProduct_Click(object sender, EventArgs e)
        {
            // change UI
            if (!isExpand)
            {
                tblChild.Visible = true;
                this.Width = 1100;
                splitContainer1.SplitterDistance = 170;
                btnShowProduct.Text = "<";
            }
            else
            {
                tblChild.Visible = false;
                this.Width = 710;
                btnShowProduct.Text = ">";
            }

            isExpand = !isExpand;
        }

        private void packagesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //var current = (TravelExpertsDataSet.PackagesRow)((DataRowView)packagesBindingSource.Current).Row;

            //Console.WriteLine(current.PackageId); 
            ////var currentId = current.Row.ItemArray[0];
            //var rows = travelExpertsDataSet.Packages_Products_Suppliers.Rows;
            //var ppsRows = new List<TravelExpertsDataSet.Packages_Products_SuppliersRow>();
            //foreach (TravelExpertsDataSet.Packages_Products_SuppliersRow row in rows)
            //{
            //    ppsRows.Add(row);
            //}

            //var ppsCurrent = ppsRows.SkipWhile(pps => pps.PackageId != current.PackageId).ToList();
            //products_SuppliersBindingSource.DataSource = ppsCurrent;

            //var PSIdList = new List<int>();
            //foreach (DataRow row in rows)
            //{
            //    if(((TravelExpertsDataSet.Packages_Products_SuppliersRow)row).PackageId == current.PackageId)
            //        PSIdList.Add(((TravelExpertsDataSet.Packages_Products_SuppliersRow)row).PackageId);
            //}

            //var psRows = travelExpertsDataSet.Products_Suppliers.Rows;
            //var currentProdRows = new List<TravelExpertsDataSet.Products_SuppliersRow>();
            //foreach (var psid in PSIdList)
            //{
            //    foreach (DataRow psRow in psRows)
            //    {
            //        if (((TravelExpertsDataSet.Products_SuppliersRow)psRow).ProductSupplierId == psid)
            //            currentProdRows.Add(((TravelExpertsDataSet.Products_SuppliersRow)psRow));
            //    }
            //}

            //products_SuppliersBindingSource.DataSource = currentProdRows;


        }
    }
}
