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
    public partial class Updatesupplier : Form
    {
        Model1 ent = new Model1();
        public Updatesupplier()
        {
            InitializeComponent();
        }

        private void Updatesupplier_Load(object sender, EventArgs e)
        {
            foreach (var item in ent.Suppliers)
            {
                comboBox1.Items.Add(item.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Supplier sp = ent.Suppliers.Find(comboBox1.Text);
            if (sp != null)
            {
                textBox1.Text = sp.Mobile.ToString();
                textBox3.Text = sp.Fax.ToString();
                textBox4.Text= sp.Email.ToString();
                textBox5.Text=sp.Website.ToString();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supplier sp = ent.Suppliers.Find(comboBox1.Text);
            if (sp != null)
            {
                sp.Mobile = int.Parse(textBox1.Text);
                sp.Fax = int.Parse(textBox3.Text);
                sp.Email = textBox4.Text;
                sp.Website = textBox5.Text;

                ent.SaveChanges();


                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
