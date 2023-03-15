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
    public partial class Updatewarehouse : Form
    {
        Model1 ent = new Model1();
        public Updatewarehouse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update warehouse
            Warehouse w1=ent.Warehouses.Find(comboBox1.Text);
            if (w1!=null)
            {
                w1.Adress = textBox1.Text;
                w1.Supervisor= textBox2.Text;
                ent.SaveChanges();
                textBox1.Text = textBox2.Text = "";
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Updatewarehouse_Load(object sender, EventArgs e)
        {
            foreach(var w in ent.Warehouses)
            {
                comboBox1.Items.Add(w.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Warehouse w1 = ent.Warehouses.Find(comboBox1.Text);
            if (w1!=null)
            {
                textBox1.Text= w1.Adress;
                textBox2.Text= w1.Supervisor;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
