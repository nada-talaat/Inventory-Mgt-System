using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectEF
{
    public partial class Addwarehouse : Form
    {
        Model1 ent = new Model1();
        public Addwarehouse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add warehouse
            Warehouse ware=new Warehouse();

            if(textBox1.Text!=""&& textBox2.Text!=""&& textBox3.Text != "")
            {
                Warehouse w1=ent.Warehouses.Find(textBox1.Text);
                if (w1 == null)
                {
                    ware.Name = textBox1.Text;
                    ware.Adress=textBox2.Text;
                    ware.Supervisor=textBox3.Text;
                    ent.Warehouses.Add(ware);
                    ent.SaveChanges();
                    textBox1.Text = textBox2.Text =textBox3.Text= "";

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("already added warehouse");
                }

            }
            else
            {
                MessageBox.Show("please write all the info");
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
