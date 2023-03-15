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
    public partial class Updateclient : Form
    {
        Model1 ent = new Model1();
        public Updateclient()
        {
            InitializeComponent();
        }

        private void Updateclient_Load(object sender, EventArgs e)
        {
            foreach (var item in ent.Clients)
            {
                comboBox1.Items.Add(item.Id);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client cl = ent.Clients.Find(int.Parse(comboBox1.Text));
            if (cl != null)
            {
                textBox1.Text= cl.Name;
                textBox3.Text = cl.Mobile.ToString();
                textBox4.Text = cl.Fax.ToString();
                textBox5.Text = cl.Email.ToString();
                textBox6.Text = cl.Website.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client cl = ent.Clients.Find(int.Parse(comboBox1.Text));
            if (cl != null)
            {
                cl.Name = textBox1.Text;
                cl.Mobile = int.Parse(textBox3.Text);
                cl.Fax = int.Parse(textBox4.Text);
                cl.Email = textBox5.Text;
                cl.Website = textBox6.Text;

                ent.SaveChanges();


                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }
    }
}
