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

namespace Hotel_Management_System
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Form1()
        {
            InitializeComponent();
        }
        private void connect()
        {
            try
            {
                con.ConnectionString = "data source=DESKTOP-IPD12LT;Initial Catalog=myHotel;integrated security=True";
                con.Open();
                cmd.Connection = con;
                MessageBox.Show("connect");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void insert()
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please fill the fields Username and Password");
                }
                else
                {
                    cmd.CommandText = "insert into signup (username , pass) values('" + txtUsername.Text + "' , '" + txtPassword.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void match()
        {
            try
            {
                cmd.CommandText = "select * from signup where username = '" + txtUsername.Text + "' and pass='" + txtPassword.Text + "'";
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dt.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    this.Hide();
                    Dashboard dd = new Dashboard();
                    dd.ShowDialog();
                }
                else
                {
                    labelError.Visible = true;
                   // MessageBox.Show("Incorrect Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            match();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clear();
            connect();

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert();
            clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Signup_Report s = new Signup_Report();
            s.Show();
            this.Hide();
        }
    }
}
