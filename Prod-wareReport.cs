using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectEF
{
    public partial class Prod_wareReport : Form
    {
        Model1 ent = new Model1();
        public Prod_wareReport()
        {
            InitializeComponent();
        }

        private void Prod_wareReport_Load(object sender, EventArgs e)
        {
            foreach (var item in ent.Warehouses)
            {
                comboBox1.Items.Add(item.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string str1 =comboBox1.Text;
            DateTime d1 = dateTimePicker1.Value;
            DateTime d2 = dateTimePicker2.Value;
            sqlConnection1.Open();
            SqlDataReader dreader;
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
            }
            this.sqlCommand1.CommandText = "select product.Code,Product.Name,W_name,[Entry date] from Product\r\ninner join Request \r\non Product.Code=Request.P_code  and [Entry date] between '"+d1+"' and '"+d2+ "' and W_name= '"+ str1+"'";
            
            dreader = sqlCommand1.ExecuteReader();
            while (dreader.Read())
            {
                string str = ((int)dreader[0]).ToString() + "\t" + dreader[1].ToString() + "\t" + dreader[2].ToString() + "\t" + dreader[3].ToString() ;
                listBox1.Items.Add(str);
            }
            dreader.Close();
            sqlConnection1.Close();
        }
    }
}
