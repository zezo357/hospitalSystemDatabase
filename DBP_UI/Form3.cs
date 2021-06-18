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
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-GCUT589\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True";

        private void DRecord_button_Click(object sender, EventArgs e)
        {
            //DDName_textBox
            if (
                DDName_textBox.Text.Length == 0
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

                    //insert into Department ( dname) values ( 'Oncology');
                    cmd.CommandText = $"if not exists (select 1 from Department where Department.Dname='{DDName_textBox.Text}') insert into Department(Dname) values('{DDName_textBox.Text}');";
                    con.Open();
                    cmd.ExecuteNonQuery();
                    if (!Depratments_avaliable_names.Items.Contains(DDName_textBox.Text)) {
                       Depratments_avaliable_names.Items.Add(DDName_textBox.Text);
                    }
                    DDName_textBox.Text = "";
                    MessageBox.Show("Deparment added");
                }
                
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form8().ShowDialog();
            this.Close();

        }
        void loadDepartments() {
        using (SqlConnection con = new SqlConnection(conString))
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "Select distinct dname from Department";

                // int result = command.ExecuteNonQuery();
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        Depratments_avaliable_names.Items.Add(reader[0].ToString());
                    }

                }
                con.Close();
            }
        }
        private void Department_Load(object sender, EventArgs e)
        {
            loadDepartments();
        }
    }
}
