using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectEF
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addwarehouse Dbox= new Addwarehouse();

            DialogResult dresult;
            dresult = Dbox.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Updatewarehouse Dbox= new Updatewarehouse();

            DialogResult dresult;
            dresult = Dbox.ShowDialog();

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addproduct Dbox= new Addproduct();

            DialogResult dresult;
            dresult = Dbox.ShowDialog();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Updateproduct Dbox=new Updateproduct();

            DialogResult dresult;
            dresult = Dbox.ShowDialog();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Addclient Dbox= new Addclient();

            DialogResult dresult;
            dresult = Dbox.ShowDialog();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Addsupplier Dbox= new Addsupplier();

            DialogResult dresult;
            dresult = Dbox.ShowDialog();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Updatesupplier Dbox = new Updatesupplier();

            DialogResult dresult;
            dresult = Dbox.ShowDialog();
        }

        private void updateToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Updateclient Dbox = new Updateclient();

            DialogResult dresult;
            dresult = Dbox.ShowDialog();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Addrequest Dbox=new Addrequest();

            DialogResult dresult;
            dresult = Dbox.ShowDialog();
        }

        private void updateToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Updaterequest Dbox= new Updaterequest();
            
            DialogResult dresult;
            dresult = Dbox.ShowDialog();
        }

        private void transerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transfer Dbox = new Transfer();

            DialogResult dresult;
            dresult = Dbox.ShowDialog();
        }

        private void expiryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expiryreport Dbox= new Expiryreport();

            DialogResult dresult;
            dresult = Dbox.ShowDialog();
        }

        private void productReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productreport Dbox=new Productreport();

            DialogResult dresult;
            dresult = Dbox.ShowDialog();
        }

        private void productWarehouseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prod_wareReport Dbox= new Prod_wareReport();

            DialogResult dresult;
            dresult = Dbox.ShowDialog();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WareReport Dbox= new WareReport();

            DialogResult dresult;
            dresult = Dbox.ShowDialog();
        }

        private void transferReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transferreport Dbox=new Transferreport();

            DialogResult dresult;
            dresult = Dbox.ShowDialog();
        }
    }
}
 