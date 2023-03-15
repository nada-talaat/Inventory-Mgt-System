﻿using System;
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
    public partial class WareReport : Form
    {
        Model1 ent = new Model1();
        public WareReport()
        {
            InitializeComponent();
        }

        private void WareReport_Load(object sender, EventArgs e)
        {
            foreach (var item in ent.Warehouses)
            {
                comboBox1.Items.Add(item.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = comboBox1.Text;
            DateTime d1 = dateTimePicker1.Value;
            DateTime d2 = dateTimePicker2.Value;
            sqlConnection1.Open();
            SqlDataReader dreader;
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
            }
            this.sqlCommand1.CommandText = "select Warehouse.*,Product.Name,Product.[Entry date]\r\nfrom Warehouse inner join Request\r\non  Warehouse.Name=Request.W_name\r\ninner join Product\r\non Product.Code=Request.P_code and [Entry date] between '" + d1 + "' and '" + d2 + "' and W_name= '" + str1 + "'";

            dreader = sqlCommand1.ExecuteReader();
            while (dreader.Read())
            {
                string str = dreader[0].ToString() + "\t" + dreader[1].ToString() + "\t" + dreader[2].ToString() + "\t" + dreader[3].ToString() ;
                listBox1.Items.Add(str);
            }
            dreader.Close();
            sqlConnection1.Close();
        }
    }
}
