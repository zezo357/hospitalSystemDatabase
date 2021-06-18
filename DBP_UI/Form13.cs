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
    public partial class UpdateDoctor : Form
    {
        public UpdateDoctor()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-GCUT589\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";
        List<int> Depratments_avaliable_Dno = new List<int>();
        List<int> Depratments_Selected_Dno = new List<int>();
        private void UpdateDoctor_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = $"Select DocID from Doctor";
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

                cmd.CommandText = "Select distinct dname,dno from Department";
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        Depratments_avaliable_names.Items.Add(reader[0].ToString());
                        Depratments_avaliable_Dno.Add(int.Parse(reader[1].ToString()));
                    }

                }

            }
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (
                textBox1.Text.Length == 0
               )
            {
                MessageBox.Show("please fill all the data");
            }
            else
            {
                Departments.Items.Clear();
                using (SqlConnection con = new SqlConnection(conString))
                using (SqlCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = $"select Name from Doctor where docID={textBox1.Text};";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            textBox2.Text = reader[0].ToString();
                            //Console.WriteLine("\t{0}",);
                        }

                    }
                    //DocIsInDep insert into Doctor (name) values ('Teddie Muddiman');
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = $"select Dno from DocIsInDep where docID={textBox1.Text};";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Depratments_Selected_Dno.Add(int.Parse(reader[0].ToString()));
                            Departments.Items.Add(Depratments_avaliable_names.Items[Depratments_avaliable_Dno.IndexOf(int.Parse(reader[0].ToString()))]);
                            //Depratments_avaliable_names.Items.Add(reader[0].ToString());
                            //Depratments_avaliable_Dno.Add(int.Parse(reader[1].ToString()));
                            //Console.WriteLine("\t{0}",);
                        }

                    }
                    //DocIsInDep insert into Doctor (name) values ('Teddie Muddiman');
                    cmd.ExecuteNonQuery();


                }
            }
        }

        private void Depratments_avaliable_names_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!Departments.Items.Contains(Depratments_avaliable_names.SelectedItem)) {
                Departments.Items.Add(Depratments_avaliable_names.SelectedItem);
                Depratments_Selected_Dno.Add(Depratments_avaliable_Dno[Depratments_avaliable_names.SelectedIndex]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Departments.Items.Count != 0 && Departments.SelectedIndex != -1)
            {
                Depratments_Selected_Dno.RemoveAt(Departments.SelectedIndex);
                Departments.Items.RemoveAt(Departments.SelectedIndex);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form8().ShowDialog();
            this.Close();
        }

        private void BiRecord_button_Click(object sender, EventArgs e)
        {
            if (Departments.Items.Count == 0 ||
                textBox1.TextLength == 0
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
                    
                    //docID insert into DocIsInDep (docid, dno) values (25, 1);
 
                    cmd.CommandText = $"update Doctor set name='{textBox2.Text}' where docID={textBox1.Text}";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = $"delete from DocIsInDep where docID={textBox1.Text}";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = $"insert into DocIsInDep" +
                                "(docid, dno) values ";
                    for (int i = 0; i < Depratments_Selected_Dno.Count; i++)
                    {
                        cmd.CommandText += $" ( {textBox1.Text}," +
                        $" {Depratments_Selected_Dno[i]}),";
                        if (i == Depratments_Selected_Dno.Count - 1)
                        {
                            cmd.CommandText = cmd.CommandText.Remove(cmd.CommandText.Length - 1, 1);
                            cmd.CommandText += ";";
                        }
                    }
                    //con.Open();
                    if (Depratments_Selected_Dno.Count != 0)
                    {
                        cmd.ExecuteNonQuery();
                    }
                    textBox1.Text = "";
                    MessageBox.Show("Doctor Updated");
                }
            }
        }
    }
}
