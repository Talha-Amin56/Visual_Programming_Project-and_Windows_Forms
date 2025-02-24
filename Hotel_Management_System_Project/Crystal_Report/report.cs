using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Crystal_Report
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        CrystalReport2 rpt = new CrystalReport2();
        public Form1()
        {
            InitializeComponent();
        }
        private void ConnectDb()
        {
            try
            {
                con.ConnectionString = "Data Source=DESKTOP-IPD12LT;Initial Catalog=CrystalDb;Integrated Security=True";
                con.Open();
                cmd.Connection = con;
                MessageBox.Show("Connected");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillReport()
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from Crystalreport", con);
                sda.Fill(dt);
                rpt.SetDataSource(dt);
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectDb();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillReport();
        }
    }
}
