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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-GCUT589\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        List<int> treatmentPrices = new List<int>();
        List<String> treatmentsNames= new List<String>();
        List<String> DoctorsNames = new List<String>();
        List<int> DoctorsIDS = new List<int>();
        int patientID = 0;
        private void Patient_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "Select DocID,Name from Doctor";

                // int result = command.ExecuteNonQuery();
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DoctorsIDS.Add(int.Parse(reader[0].ToString()));
                        DoctorsNames.Add(reader[1].ToString());
                        Doctors.Items.Add(reader[0].ToString()+"  "+ reader[1].ToString());
                      
                    }

                }
               
                cmd.CommandText = "Select distinct city from Hospital";

                // int result = command.ExecuteNonQuery();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cities.Items.Add(reader[0]);
                        //Console.WriteLine("\t{0}",);
                    }

                }
                cmd.CommandText = "Select distinct area from Hospital";

                // int result = command.ExecuteNonQuery();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Areas.Items.Add(reader[0]);
                        //Console.WriteLine("\t{0}",);
                    }

                }
                cmd.CommandText = "SELECT IDENT_CURRENT('Patient')";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        patientID= int.Parse(reader[0].ToString()) + 1;
                        PatientIDNum.Text = (int.Parse(reader[0].ToString()) + 1).ToString();
                        //Console.WriteLine("\t{0}",);
                    }

                }

            }
        }

        private void PRecord_button_Click(object sender, EventArgs e)
        {/*
            SqlConnection con = new SqlConnection(conString);

            SqlCommand cmd = con.CreateCommand();

            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into person values(ID,Fname,Lname,age) values('" + ID_textbox.Text.ToString() + "', '" + Fname_textbox.Text.ToString() + "', '" + Lname_textbox.Text.ToString() + "', '" + age_textbox.Text.ToString() + "')";
                //SqlCommand cmd = new SqlCommand(, con);
                cmd.CommandText = q;
                //cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("data entered :)");
                cmd.Connection.Close();
            }*/
            /*
            
            PatientID int not null,
	Height int ,
    BType varChar(10),
	Fname varChar(40),
	Lname varChar(40),
	Weight int,
    Area varChar(40),
	City varChar(40),
	DaysNO int,
    PStatus varChar(40),
	Gender varChar(10),
	DocID int,
    BedID int,
    RoomNo int,
    age int,*/
            if (Rooms.SelectedIndex==-1||
                Beds.SelectedIndex == -1 || 
                Doctors.SelectedIndex == -1 || 
                Genders.SelectedIndex == -1 || 
                PatientStatus.SelectedIndex == -1 || 
                Cities.SelectedIndex == -1 || 
                Areas.SelectedIndex == -1 || 
                BloodType.SelectedIndex == -1|| 
                PFName_textBox.Text.Length==0||
                PLName_textBox.Text.Length == 0||
                PHeight_textBox.Value==0||
                PWeight_textBox.Value==0||
                Page_textBox.Value==0
                ) {
                MessageBox.Show("please fill all the data"); 
            }
            else {
                try{
                    using (SqlConnection con = new SqlConnection(conString))
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                       
                        //PBType_textBox needs to select from specfic values
                        cmd.CommandText = $"insert into Patient" +
                            "(height,HName, btype, fname, lname, weight, area, city, AddedDate, pstatus, gender, docid, bedid, roomno, age) values(" +
                            $" {PHeight_textBox.Value}," +
                            $" '{Hospitals.SelectedItem}'," +
                            $" '{BloodType.SelectedItem}'," +
                            $" '{PFName_textBox.Text}'," +
                            $"'{PLName_textBox.Text}' ," +
                            $" {PWeight_textBox.Value}," +
                            $" '{Areas.SelectedItem}'," +
                            $" '{Cities.SelectedItem}'," +
                            $" '{dateTimePicker1.Value}' ," +
                            $" '{PatientStatus.SelectedItem}' ," +
                            $" '{Genders.SelectedItem}' , " +
                            $" {DoctorsIDS[Doctors.SelectedIndex]}, " +
                            $" {Beds.SelectedItem}, " +
                            $" {Rooms.SelectedItem}," +
                            $" {Page_textBox.Value} );";
                        con.Open();
                        cmd.ExecuteNonQuery();

                        //add phoneNumbers
                        cmd.CommandText = $"insert into Patient_PhoneNo" +
                            "(phoneno, patientid) values";
                        for (int i = 0; i < PhoneNumbers.Items.Count; i++)
                        {
                            cmd.CommandText += $" ( {PhoneNumbers.Items[i]}," +
                            $" {PatientIDNum.Text}),";
                            if (i == (PhoneNumbers.Items.Count - 1))
                            {
                                   cmd.CommandText=cmd.CommandText.Remove(cmd.CommandText.Length - 1, 1);
                                cmd.CommandText += ";";
                            }
                        }
                        //con.Open();
                        if (PhoneNumbers.Items.Count!=0) {
                            cmd.ExecuteNonQuery(); 
                        }
                        //add Disease insert into Patient_Disease (disease, patientid) 
                        cmd.CommandText = $"insert into Patient_Disease" +
                            "(disease, patientid) values";
                        for (int i = 0; i < Diseases.Items.Count; i++)
                        {
                            cmd.CommandText += $" ( '{Diseases.Items[i]}'," +
                            $" {PatientIDNum.Text}),";
                            if (i == Diseases.Items.Count - 1)
                            {
                            cmd.CommandText = cmd.CommandText.Remove(cmd.CommandText.Length - 1, 1);
                            cmd.CommandText += ";";
                            }
                        }
                        if (Diseases.Items.Count != 0)
                        {
                            cmd.ExecuteNonQuery();
                        }
                        //con.Open();
                        //add Treatment insert into Patient_treatment (treatment, price, patientid) values
                        cmd.CommandText = $"insert into Patient_treatment" +
                            "(treatment, price, patientid) values";
                        for (int i = 0; i < treatmentsNames.Count; i++)
                        {
                            cmd.CommandText +=
                                $" ( '{treatmentsNames[i]}'," +
                            $" {treatmentPrices[i]}," +
                            $" {PatientIDNum.Text}),";
                            if (i == treatmentsNames.Count - 1)
                            {
                            cmd.CommandText = cmd.CommandText.Remove(cmd.CommandText.Length - 1, 1);
                            cmd.CommandText += ";";
                            }
                        }
                        if (treatmentsNames.Count != 0)
                        {
                            cmd.ExecuteNonQuery();
                        }
                       
                        
                    patientID = patientID + 1;
                    PatientIDNum.Text = (patientID).ToString();

                    Beds.Items.Clear();
                    MessageBox.Show("Patient added");
                    //con.Open();
                    con.Close();
                    }
                }
                catch (SqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 102:
                            MessageBox.Show(ex.Message);
                            MessageBox.Show(ex.Number.ToString());
                            MessageBox.Show("Please fill all the data");
                            break;
                        case 2601:
                            MessageBox.Show(ex.Message);
                            break;
                        default:
                            MessageBox.Show(ex.Number.ToString());
                            MessageBox.Show(ex.Message);
                            throw;
                    }
                } 
            }
            
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddPhoneNumber_Click(object sender, EventArgs e)
        {
            PhoneNumbers.Items.Add(WrittenPhoneNumber.Value);
        }

        private void DeleteSelectedPhoneNumber_Click(object sender, EventArgs e)
        {
            if (PhoneNumbers.Items.Count != 0 && PhoneNumbers.SelectedIndex != -1)
            {
                PhoneNumbers.Items.RemoveAt(PhoneNumbers.SelectedIndex);
            }
        }

        private void Treatment_label_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            treatmentsNames.Add(PTreatment_textBox.Text);
            treatmentPrices.Add((int)TreatmentPrice.Value);
            Treatments.Items.Add(PTreatment_textBox.Text + " ("+TreatmentPrice.Value.ToString() + ")");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Treatments.Items.Count != 0 && Treatments.SelectedIndex!=-1)
            {
                treatmentsNames.RemoveAt(Treatments.SelectedIndex);
                treatmentPrices.RemoveAt(Treatments.SelectedIndex);
                Treatments.Items.RemoveAt(Treatments.SelectedIndex);
            }



        }

        private void Disease_Click(object sender, EventArgs e)
        {
            Diseases.Items.Add(PDisease_textBox.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Diseases.Items.Count != 0 && Diseases.SelectedIndex != -1)
            {
                Diseases.Items.RemoveAt(Diseases.SelectedIndex);
            }
        }

        private void Rooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            Beds.Items.Clear();
            using (SqlConnection con = new SqlConnection(conString))
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = $"Select BedID from Bed where not exists (select * from Patient where Patient.BedID=bed.BedID and Bed.RoomNo=Patient.RoomNo) and Bed.RoomNo={Rooms.Items[Rooms.SelectedIndex]}";
                con.Open();
                // int result = command.ExecuteNonQuery();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Beds.Items.Add(reader[0]);
                        //Console.WriteLine("\t{0}",);
                    }

                }
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Areas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Beds.Items.Clear();
            Rooms.Items.Clear();
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

        private void Hospitals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Hospitals.SelectedIndex!=-1) {
                Rooms.Items.Clear();
                Beds.Items.Clear();
                using (SqlConnection con = new SqlConnection(conString))
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = $"Select roomno from HospitalHasRoom where HospitalHasRoom.hname = '{Hospitals.SelectedItem}' and exists(Select RoomNo from Room where (select count(*) from Patient where RoomNo= Room.RoomNo)< (select count(BedID) from Bed where RoomNo = Room.RoomNo) and HospitalHasRoom.RoomNo = Room.RoomNo);";
                    con.Open();
                    // int result = command.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rooms.Items.Add(reader[0]);
                            //Console.WriteLine("\t{0}",);
                        }

                    }
                } 
            }
        }

        private void listBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form8().ShowDialog();
            this.Close();

        }
    }
}
