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

namespace DBP_UI
{
    public partial class FindnearestHospital : Form
    {
        public FindnearestHospital()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-GCUT589\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";

        private void Disease_label_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form8().ShowDialog();
            this.Close();

        }

        private void Areas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hospitals.Items.Clear();
            using (SqlConnection con = new SqlConnection(conString))
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = $"Select hname from Hospital where area='{Areas.SelectedItem}' and exists( Select roomno from HospitalHasRoom where HospitalHasRoom.hname=Hospital.hname and exists(Select RoomNo from Room where (select count(*) from Patient where RoomNo=Room.RoomNo)< (select count(BedID) from Bed where RoomNo=Room.RoomNo) and HospitalHasRoom.RoomNo = Room.RoomNo));";
                con.Open();
                // int result = command.ExecuteNonQuery();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Hospitals.Items.Add(reader[0]);
                        //Console.WriteLine("\t{0}",);
                    }

                }
            }
        }

        private void FindnearestHospital_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "Select distinct area from Hospital";
                con.Open();
                // int result = command.ExecuteNonQuery();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Areas.Items.Add(reader[0]);
                        //Console.WriteLine("\t{0}",);
                    }

                }
            }
        }
    }
}
