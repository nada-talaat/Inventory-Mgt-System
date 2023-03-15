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
    public partial class Updaterequest : Form
    {
        Model1 ent = new Model1();
        public Updaterequest()
        {
            InitializeComponent();
        }

        private void Updaterequest_Load(object sender, EventArgs e)
        {
            Request r1= new Request();

            foreach (var item in ent.Products)
            {
                comboBox2.Items.Add(item.Code);
            }
            foreach (var item in ent.Warehouses)
            {
                comboBox3.Items.Add(item.Name);
            }
            foreach (var item in ent.Suppliers)
            {
                comboBox4.Items.Add(item.Name);
            }
            foreach (var item in ent.Requests)
            {
               comboBox1.Items.Add(item.Req_No_);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Request re = ent.Requests.Find(int.Parse(comboBox1.Text));
            if (re!=null)
            {
                re.Quantity = int.Parse(textBox1.Text);
                re.ReqDate= dateTimePicker1.Value;
                re.P_code = int.Parse(comboBox2.Text);
                re.W_name=comboBox3.Text;
                re.S_name=comboBox4.Text;

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Request rr=ent.Requests.Find(int.Parse(comboBox1.Text));
            if (rr != null)
            {
                if (rr.Type=="import")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                textBox1.Text=rr.Quantity.ToString();
                dateTimePicker1.Value=(DateTime)rr.ReqDate;
                comboBox2.Text=rr.P_code.ToString();
                comboBox3.Text = rr.W_name;
                comboBox4.Text = rr.S_name;
            }
            

        }
    }
}
