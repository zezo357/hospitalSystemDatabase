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
    public partial class BILL : Form
    {
        public BILL()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-GCUT589\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        //List<int> treatmentPrices = new List<int>();
        //List<String> treatmentsNames = new List<String>();
        private void BiPatientID_label_Click(object sender, EventArgs e)
        {

        }

        private void BiPatientID_textBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form8().ShowDialog();
            this.Close();
        }

        private void BILL_Load(object sender, EventArgs e)
        {
                using (SqlConnection con = new SqlConnection(conString))
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = $"Select PatientID from Patient";
                    AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
                    // int result = command.ExecuteNonQuery();
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Collection.Add(int.Parse(reader[0].ToString()).ToString());
                        }
                        textBox1.AutoCompleteCustomSource = Collection;
                    }
                
            }
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void SearchByID_Click(object sender, EventArgs e)
        {
            if (
                textBox1.Text.Length == 0
               )
            {
                MessageBox.Show("please fill all the data");
            }
            else
            {
                Treatments.Items.Clear();
                using (SqlConnection con = new SqlConnection(conString))
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = $"Select AddedDate from Patient where PatientID={textBox1.Text}";
                    // int result = command.ExecuteNonQuery();
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            label3.Text = (DateTime.Now - DateTime.Parse(reader[0].ToString())).Days.ToString();
                        }
                    }

                    cmd.CommandText = $"select price,Treatment from Patient_treatment where PatientID={textBox1.Text}";
                    int sum = 0;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                                { 
                            //treatmentsNames.Add(reader[1].ToString());
                            //treatmentPrices.Add(int.Parse(reader[0].ToString()));
                            Treatments.Items.Add(reader[1].ToString() + " (" + int.Parse(reader[0].ToString()) + ") ");
                            //Bill_Price.Text = int.Parse(reader[0].ToString()) + (int.Parse(label3.Text) * 200).ToString();
                            sum = sum + int.Parse(reader[0].ToString());
                        }
                    }
                    Treatments.Items.Add("Days price" + " (" + (int.Parse(label3.Text) * 200).ToString() + ")");
                    sum = sum + (int.Parse(label3.Text) * 200);
                    Bill_Price.Text = sum.ToString();
                    Treatments.Items.Add("Total "+ " (" + (sum) + ")");
                    cmd.CommandText = $"select Fname+' '+Lname from Patient where PatientID={textBox1.Text}";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            patientName.Text = reader[0].ToString();
                        }
                    }
                   

                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BiRecord_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            using (SqlCommand cmd = con.CreateCommand())
            {
                //PBType_textBox needs to select from specfic valuesinsert into Bill ( bill_price, patientid) values ( 
                cmd.CommandText = $"insert into Bill" +
                     "( bill_price, patientid) values ( " +
                     $" {Bill_Price.Text}," +
                     $" {textBox1.Text} );";
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("bill added");
            }
            }
    }
}
