using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectEF
{
    public partial class Transfer : Form
    {
        Model1 ent = new Model1();
        public Transfer()
        {
            InitializeComponent();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            foreach (var item in ent.Products)
            {
                comboBox1.Items.Add(item.Code);
            }
            foreach (var item in ent.Warehouses)
            {
                comboBox3.Items.Add(item.Name);
            }
            foreach (var item in ent.Suppliers)
            {
                comboBox4.Items.Add(item.Name);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Product pr = ent.Products.Find(int.Parse(comboBox1.Text));
            if (pr != null)
            {

                dateTimePicker1.Value = (DateTime)pr.Prod_date;
                dateTimePicker2.Value = (DateTime)pr.Expire_date;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Request r2 = new Request();
            if (textBox1.Text != "" && textBox2.Text != "" && dateTimePicker1.Text != "12/31/9998" && dateTimePicker2.Text != "12/31/9998" && dateTimePicker3.Text != "12/31/9998")
            {
                Request req = ent.Requests.Find(int.Parse(textBox1.Text));
                if (req == null)
                {

                    r2.Req_No_ = int.Parse(textBox1.Text);
                    r2.Quantity = int.Parse(textBox2.Text);
                    r2.ReqDate = dateTimePicker3.Value;
                    r2.P_code = int.Parse(comboBox1.Text);
                    r2.W_name = comboBox3.Text;
                    r2.S_name = comboBox4.Text;
                    r2.Type = "Transfer";
                    ent.Requests.Add(r2);
                    ent.SaveChanges();

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("already availabl req.no");
                }
                
            }
            else
            {
                MessageBox.Show("please write all the info");
            }
        }
    }
}