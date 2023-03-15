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
    public partial class Addproduct : Form
    {
        Model1 ent=new Model1();
        public Addproduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product pr = new Product();

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && dateTimePicker1.Text != "12/31/9998" && dateTimePicker2.Text != "12/31/9998" && dateTimePicker3.Text != "12/31/9998")
            {
                Product pro = ent.Products.Find(int.Parse(textBox1.Text));
                if (pro == null)
                {
                    pr.Code = int.Parse(textBox1.Text);
                    pr.Name = textBox2.Text;
                    pr.Measuring_unit = textBox3.Text;
                    pr.Prod_date=dateTimePicker1.Value;
                    pr.Expire_date = dateTimePicker2.Value;
                    pr.Entry_date=dateTimePicker3.Value;
                    ent.Products.Add(pr);
                    ent.SaveChanges();
                    textBox1.Text = textBox2.Text = textBox3.Text = "";
                    dateTimePicker1.Text = dateTimePicker2 .Text= "12/31/9998";

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("already added product");
                }

            }
            else
            {
                MessageBox.Show("please write all the info");
            }
           
        }
    }
}
