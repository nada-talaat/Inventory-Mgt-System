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
    public partial class Addrequest : Form
    {
        Model1 ent = new Model1();
        public Addrequest()
        {
            InitializeComponent();
        }

        private void Addrequest_Load(object sender, EventArgs e)
        {
            foreach (var item in ent.Products)
            {
                comboBox1.Items.Add(item.Code);
            }
            foreach (var item in ent.Warehouses)
            {
                comboBox2.Items.Add(item.Name);
            }
            foreach (var item in ent.Suppliers)
            {
                comboBox3.Items.Add(item.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != ""&& dateTimePicker1.Text != "12/31/9998")
            {
                Request r2= new Request();
                Request req=ent.Requests.Find(int.Parse(textBox1.Text));
                if (req == null) 
                {
                    if(radioButton1.Checked==true)
                    {
                        r2.Type= radioButton1.Text;
                    }
                    else
                    {
                        r2.Type= radioButton2.Text;
                    }
                    r2.Req_No_ = int.Parse(textBox1.Text);
                    r2.Quantity= int.Parse(textBox2.Text);
                    r2.ReqDate= dateTimePicker1.Value;
                    r2.P_code = int.Parse(comboBox1.Text);
                    r2 .W_name = comboBox2.Text;
                    r2.S_name= comboBox3.Text;
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
