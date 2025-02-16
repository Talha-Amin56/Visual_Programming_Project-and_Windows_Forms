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
    public partial class UC_CustomerCheckOut : UserControl
    {
        function fn = new function();
        string query;
        public UC_CustomerCheckOut()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_CustomerCheckOut_Load(object sender, EventArgs e)
        {
            query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid=rooms.roomid where chekout='No'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
          
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid=rooms.roomid where cname like '"+txtName.Text+"%' and chekout='No'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        int id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoom.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if(txtCName.Text!="" )
            {
                if(MessageBox.Show("Are You Sure?","COnfirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
                {
                    string date = txtCheckOutDate.Text;
                    query = "update customer set chekout='Yes',checkout='" + txtCheckOutDate.Text + "' where cid = "+id+" update rooms set booked='No' where roomNo='"+txtRoom.Text+"'";
                    fn.setData(query, "Check Out Successfull.");
                    UC_CustomerCheckOut_Load(this, null);
                    clearAll();
                }

            }
            else
            {
                MessageBox.Show("No Customer selected");
            }
        }
        public void clearAll()
        {
            txtRoom.Clear();
            txtName.Clear();
            txtCName.Clear();
            txtCheckOutDate.ResetText();
        }

        private void UC_CustomerCheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

    }
}
