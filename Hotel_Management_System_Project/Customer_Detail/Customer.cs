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
    public partial class CustomerDetails : UserControl
    {
        function fn = new function();
        string query;
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtSearchBy.SelectedIndex==0)
            {
                query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,customer.checkout,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid=rooms.roomid";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if(txtSearchBy.SelectedIndex==1)
            {
                query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,customer.checkout,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid=rooms.roomid where checkout is null";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtSearchBy.SelectedIndex == 2)
            {
                query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,customer.checkout,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid=rooms.roomid where checkout is not null";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
