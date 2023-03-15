using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectEF
{
    public partial class Addsupplier : Form
    {
        Model1 ent=new Model1();
        public Addsupplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supplier cl = new Supplier();

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                Supplier sup = ent.Suppliers.Find(textBox1.Text);
                if (sup == null)
                {
                    
                    cl.Name = textBox1.Text;
                    cl.Mobile = int.Parse(textBox2.Text);
                    cl.Fax = int.Parse(textBox3.Text);
                    cl.Email = textBox4.Text;
                    cl.Website = textBox5.Text;
                    ent.Suppliers.Add(cl);
                    ent.SaveChanges();
                    textBox1.Text = textBox2.Text = textBox3.Text =textBox4.Text=textBox5.Text= "";


                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("already added supplier");
                }

            }
            else
            {
                MessageBox.Show("please write all the required info ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
