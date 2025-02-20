using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.All_User_Control
{
    public partial class UC_Employee : UserControl
    {
        function fn = new function();
        string query;
        public UC_Employee()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEmployee.SelectedIndex == 1)
            {
                setEmployee(dataGridView1);
            }
            else if (tabEmployee.SelectedIndex == 2)
            {
                setEmployee(dataGridView2);
            }
        }
         private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtID.Text!="")
            {
                if(MessageBox.Show("Are You Sure?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    query="delete from employee where eid = '"+txtID.Text+"'";
                    fn.setData(query, "Record Deleted.");
                    tabEmployee_SelectedIndexChanged(this, null);
                }
            }
        }
        

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMaxID();
        }
     //************************************Request method*********************************
        public void getMaxID()
        {
            query = "select max(eid)from employee";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSet.Text = (num + 1).ToString();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtName.Text!=""&& txtMobile.Text!=""&& txtGender.Text!=""&& txtEmail.Text!=""&& txtUsername.Text!=""&&txtPassword.Text!="")
            {
                string name = txtName.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                string gender = txtGender.Text;
                string email = txtEmail.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                query = "insert into employee (ename,mobile,gender,emailid,username,pass) values ('" + name + "'," + mobile + ",'" + gender + "','" + email + "','" + username + "','" + password + "')";
                fn.setData(query, "Employee Registered.");

                clearAll();
                getMaxID();
            }
            else
            {
                MessageBox.Show("Fill All the Fields");
            }
        }
        public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();

        }

        public void setEmployee(DataGridView dgv)
        {
            query = "select * from employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource= ds.Tables[0];
        }

        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_Report er = new Employee_Report();
            er.Show();
            this.Hide();
        }
    }
}
