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
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);
            this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = listBox1.SelectedIndex;
        }
    }
}
