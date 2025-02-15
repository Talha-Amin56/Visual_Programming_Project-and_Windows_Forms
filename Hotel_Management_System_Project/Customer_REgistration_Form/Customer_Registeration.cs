using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Management_System.All_User_Control
{
    public partial class UC_CustomerRegisteration : UserControl
    {
        function fn = new function();
        string query;
        public UC_CustomerRegisteration()
        {
            InitializeComponent();
        }
        public void setComboBox(string query,ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while(sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));

                }
               
            }
            sdr.Close();
        }


        private void UC_CustomerRegisteration_Load(object sender, EventArgs e)
        {

        }

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
            query = "Select roomNo from rooms where bed= '"+txtBed.Text+"'and roomType='"+txtRoomType.Text+"'and booked='No'";
            setComboBox(query, txtRoomNo);
        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.SelectedIndex = -1;
            txtRoomType.SelectedIndex = -1;

        }
        int rid;
        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                query = "select price,roomid from rooms where roomNo='" + txtRoomNo.Text + "'";
                DataSet ds = fn.getData(query);
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
                rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAlloteRoom_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtName.Text != "" && txtContact.Text != "" && txtNationality.Text != "" && txtDob.Text != "" && txtGender.Text != "" && txtIdProof.Text != "" && txtAddress.Text != "" && txtPrice.Text != "" && txtBed.Text != "" && txtRoomType.Text != "" && txtRoomNo.Text != "" && txtCheckin.Text != "")
                {
                    string name = txtName.Text;
                    Int64 mobile = Int64.Parse(txtContact.Text);
                    string national = txtNationality.Text;
                    string gender = txtGender.Text;
                    string dob = txtDob.Text;
                    string idproof = txtIdProof.Text;
                    string address = txtAddress.Text;
                    string checkin = txtCheckin.Text;

                    query = "insert into customer(cname,mobile,nationality,gender,dob,idproof,addres,checkin,roomid) values ('" + name + "'," + mobile + ",'" + national + "','" + gender + "','" + dob + "','" + idproof + "','" + address + "','" + checkin + "'," + rid + ") update rooms set booked='Yes' where roomNo='" + txtRoomNo.Text + "'";
                    fn.setData(query, "Room No " + txtRoomNo.Text + " Allocation Successfull.");
                }
                else
                {
                    MessageBox.Show("Fill all the fields.", "Warning!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            clear();
                
        }
        public void clear()
        {
            txtName.Clear();
            txtContact.Clear();
            txtNationality.Clear();
            txtGender.SelectedIndex = -1;
            txtIdProof.Clear();
            txtPrice.Clear();
            txtAddress.Clear();
            txtIdProof.Clear();
            txtBed.SelectedIndex = -1;
            txtRoomType.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
        }

        private void UC_CustomerRegisteration_Leave(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer_registeration_report crp = new customer_registeration_report();
            crp.Show();
            this.Hide();
        }
    }
}
