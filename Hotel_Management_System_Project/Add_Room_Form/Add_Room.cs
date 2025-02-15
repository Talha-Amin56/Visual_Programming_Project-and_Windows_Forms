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
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        string query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtRoomNo.Text!=""&&txtType.Text!=""&&txtBed.Text!=""&&txtPrice.Text!="")
            {
                string roomno = txtRoomNo.Text;
                string type = txtType.Text;
                string bed = txtBed.Text;
                Int64 price = Int64.Parse(txtPrice.Text);

                query = "insert into rooms(roomNo,roomType,bed,price) values ('" + roomno + "','" + type + "','" + bed + "'," + price + ")";
                fn.setData(query, "Room Added");
                UC_AddRoom_Load(this, null);
                clear();
            }
            else
            {
                MessageBox.Show("Fill all the fields.","Warning!!");
            }
        }
        public void clear()
        {
            txtRoomNo.Clear();
            txtType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPrice.Clear();

        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RoomReport r = new RoomReport();
            r.Show();
            this.Hide();
        }
    }
}
