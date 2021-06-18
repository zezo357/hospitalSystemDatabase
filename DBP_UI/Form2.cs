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
    public partial class Hospital : Form
    {
        public Hospital()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-GCUT589\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        List<String> RoomsTypes = new List<String>();
        List<int> RoomsMaxCapacity = new List<int>();

        List<int> RoomsNumbers = new List<int>();
        List<int> Depratments_avaliable_Dno = new List<int>();
        List<int> Depratments_Selected_Dno = new List<int>();
        private void HRecord_button_Click(object sender, EventArgs e)
        {
            if (Rooms.Items.Count == 0 ||
                Departments.Items.Count == 0 ||
                City.SelectedIndex == -1 ||
                Area.SelectedIndex == -1||
                HHName_textBox.TextLength==0
               )
            {
                MessageBox.Show("please fill all the data");
            }
            else
            {
                //try{
                    using (SqlConnection con = new SqlConnection(conString))
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                       //PBType_textBox needs to select from specfic values
                       cmd.CommandText = $"insert into Hospital" +
                            "(hname, city, area) values(" +
                            $" '{HHName_textBox.Text}'," +
                            $" '{City.SelectedItem}'," +
                            $" '{Area.SelectedItem}' );";
                        con.Open();
                        cmd.ExecuteNonQuery();

                        //add HospitalHasDep
                        cmd.CommandText = $"insert into HospitalHasDep" +
                            "(hname, dno) values ";
                        for (int i = 0; i < Departments.Items.Count; i++)
                        {
                            cmd.CommandText += $" ( '{HHName_textBox.Text}'," +
                            $" {Depratments_Selected_Dno[i]}),";
                            if (i == Departments.Items.Count - 1)
                            {
                                cmd.CommandText = cmd.CommandText.Remove(cmd.CommandText.Length - 1, 1);
                                cmd.CommandText += ";";
                            }
                        }
                        //con.Open();
                        if (Departments.Items.Count != 0)
                        {
                            cmd.ExecuteNonQuery();
                        }
                        //create rooms and store the keys for them
                        //RoomsTypes
                        //RoomsNumbers
                        
       
                        for (int i=0;i<Rooms.Items.Count;i++) {
                            cmd.CommandText = $"insert into Room (roomtype) OUTPUT Inserted.roomNo values ('{RoomsTypes[i]}')";
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    RoomsNumbers.Add(int.Parse(reader[0].ToString()));
                                    //Console.WriteLine("\t{0}",);
                                }

                            }
                            for (int x = 0; x < RoomsMaxCapacity[i]; x++)
                            {
                                cmd.CommandText = $"insert into Bed (roomno) values ({RoomsNumbers[RoomsNumbers.Count-1]})";
                            cmd.ExecuteNonQuery();
                        }

                    }
                   
                    //insert into HospitalHasRoom (disease, patientid) 
                    cmd.CommandText = $"insert into HospitalHasRoom" +"(hname, roomno) values";
                        for (int i = 0; i < Rooms.Items.Count; i++)
                        {
                            cmd.CommandText += $" ( '{HHName_textBox.Text}'," +
                            $" {RoomsNumbers[i]}),";
                            if (i == Rooms.Items.Count - 1)
                            {
                                cmd.CommandText = cmd.CommandText.Remove(cmd.CommandText.Length - 1, 1);
                                cmd.CommandText += ";";
                            }
                        }
                        //con.Open();
                        if (Rooms.Items.Count != 0)
                        {
                            cmd.ExecuteNonQuery();
                        }
                        HHName_textBox.Text = "";
                    MessageBox.Show("Hospital added ");

                        //con.Open();
                        con.Close();
                    }
                /*}
                
                catch (SqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 102:
                            MessageBox.Show(ex.Message);
                            MessageBox.Show("please fill all the data");
                            break;
                        case 2601:
                            MessageBox.Show(ex.Message);
                            break;
                        default:
                            MessageBox.Show(ex.Number.ToString());
                            MessageBox.Show(ex.Message);
                            throw;
                    }
                }*/
            }
        }

        private void Disease_label_Click(object sender, EventArgs e)
        {

        }

        private void Disease_Click(object sender, EventArgs e)
        {
            RoomsMaxCapacity.Add((int)numberOfBeds.Value);
            RoomsTypes.Add(RoomType_textBox.Text);
            Rooms.Items.Add(RoomType_textBox.Text + " (" + numberOfBeds.Value.ToString() + ")");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Rooms.Items.Count != 0 && Rooms.SelectedIndex != -1)
            {
                RoomsMaxCapacity.RemoveAt(Rooms.SelectedIndex);
                RoomsTypes.RemoveAt(Rooms.SelectedIndex);
                Rooms.Items.RemoveAt(Rooms.SelectedIndex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Departments.Items.Add(Depratments_avaliable_names.SelectedItem);
            Depratments_Selected_Dno.Add(Depratments_avaliable_Dno[Depratments_avaliable_names.SelectedIndex]);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (Departments.Items.Count != 0 && Departments.SelectedIndex != -1)
            {
                Depratments_Selected_Dno.RemoveAt(Departments.SelectedIndex);
                Departments.Items.RemoveAt(Departments.SelectedIndex);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form8().ShowDialog();
            this.Close();
            
        }

        private void Hospital_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "Select distinct dname,dno from Department";

                // int result = command.ExecuteNonQuery();
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        Depratments_avaliable_names.Items.Add(reader[0].ToString());
                        Depratments_avaliable_Dno.Add(int.Parse(reader[1].ToString()));
                    }

                }
            }
        }
    }
}
