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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-GCUT589\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        List<int> Depratments_avaliable_Dno = new List<int>();
        List<int> Depratments_Selected_Dno = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form8().ShowDialog();
            this.Close();

        }

        private void DoRecord_button_Click(object sender, EventArgs e)
        {
            if (Departments.Items.Count == 0 ||
                DODoctorName_textBox.TextLength == 0
               )
            {
                MessageBox.Show("please fill all the data");
            }
            else
            {
                int docID = 0;
                using (SqlConnection con = new SqlConnection(conString))
                using (SqlCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = $"insert into Doctor (name) OUTPUT Inserted.DocID values ('{DODoctorName_textBox.Text}');";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            docID = int.Parse(reader[0].ToString());
                            //Console.WriteLine("\t{0}",);
                        }

                    }
                    //DocIsInDep insert into Doctor (name) values ('Teddie Muddiman');

                    cmd.ExecuteNonQuery();
                    //docID insert into DocIsInDep (docid, dno) values (25, 1);

                    cmd.CommandText = $"insert into DocIsInDep" +
                                "(docid, dno) values ";
                    for (int i = 0; i < Departments.Items.Count; i++)
                    {
                        cmd.CommandText += $" ( {docID}," +
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
                    DODoctorName_textBox.Text = "";
                    MessageBox.Show("Doctor added");
                }
            }
        }

        private void Doctor_Load(object sender, EventArgs e)
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

        private void Depratments_avaliable_names_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
