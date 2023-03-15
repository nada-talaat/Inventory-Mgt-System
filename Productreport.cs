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

namespace projectEF
{
    public partial class Productreport : Form
    {
        public Productreport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            sqlConnection1.Open();
            SqlDataReader dreader;
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
            }
            this.sqlCommand1.CommandText = "select Product. * ,w_name\r\nfrom Product inner join Request\r\non Product.Code=Request.P_code and DATEDIFF(day, GETDATE(), [Entry date])<" + str1;
            dreader = sqlCommand1.ExecuteReader();
            while (dreader.Read())
            {
                string str = ((int)dreader[0]).ToString() + "\t" + dreader[1].ToString() + "\t" + dreader[2].ToString() + "\t"+ dreader[3].ToString() + "\t" + dreader[4].ToString() + "\t" + dreader[5].ToString() + "\t" + dreader[6].ToString() + "\t";
                listBox1.Items.Add(str);
            }
            dreader.Close();
            sqlConnection1.Close();
        }
    }
}
