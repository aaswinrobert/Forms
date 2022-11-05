using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem1
{
    public partial class Form4 : Form
    {
        DataTable dt = new DataTable();
        public Form4()
        {

            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
        public void createnewrow()
        {
            string s1 = Form3.p1;
            string s2 = Form3.p2;
            string s3 = Form3.p3;
            string s4 = Form3.p4;
            if (dt.Rows.Count <= 0)
            {

                DataColumn dc1 = new DataColumn("Product Id", typeof(int));
                DataColumn dc2 = new DataColumn("Product Name", typeof(string));
                DataColumn dc3 = new DataColumn("Product Description", typeof(string));
                DataColumn dc4 = new DataColumn("QOH", typeof(int));

                dt.Columns.Add(dc1);
                dt.Columns.Add(dc2);
                dt.Columns.Add(dc3);
                dt.Columns.Add(dc4);

                dt.Rows.Add(Convert.ToInt32(s1), s2, s3, Convert.ToInt32(s4));
                dataGridView1.DataSource = dt;

            }
            else
            {
                dt.Rows.Add(Convert.ToInt32(s1), s2, s3, Convert.ToInt32(s4));
                dataGridView1.DataSource = dt;

            }
        }

            private void button1_Click(object sender, EventArgs e)
            {
                createnewrow();
            }
    }
}
