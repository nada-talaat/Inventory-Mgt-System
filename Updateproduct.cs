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
    public partial class Updateproduct : Form
    {
        Model1 ent = new Model1();
        public Updateproduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

        }

        private void Updateproduct_Load(object sender, EventArgs e)
        {
            foreach (var item in ent.Products)
            {
                comboBox1.Items.Add(item.Code);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product pr = ent.Products.Find(int.Parse(comboBox1.Text));
            if (pr!=null)
            {
                textBox1.Text= pr.Name;
                textBox2.Text = pr.Measuring_unit;
                dateTimePicker1.Value =(DateTime) pr.Prod_date;
                dateTimePicker2.Value = (DateTime)pr.Prod_date;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Product pr = ent.Products.Find(int.Parse(comboBox1.Text));
            if (pr != null)
            {
                pr.Name = textBox1.Text;
                pr.Measuring_unit = textBox2.Text;
                pr.Prod_date = dateTimePicker1.Value;
                pr.Expire_date = dateTimePicker2.Value;
                ent.SaveChanges();


                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }
    }
}
