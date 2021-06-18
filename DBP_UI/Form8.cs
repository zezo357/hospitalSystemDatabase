using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_UI
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Patient().ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Hospital().ShowDialog();
            this.Close();
            
        }

        private void Patient_Report_Click(object sender, EventArgs e)
        {
            new Form10().ShowDialog();
        }

        private void Add_doctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Doctor().ShowDialog();
            this.Close();
        }

        private void Add_Department_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Department().ShowDialog();
            this.Close();
        }

        private void Get_patient_Bill_Click(object sender, EventArgs e)
        {
            new Form9().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void CreateBill_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BILL().ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form12().ShowDialog();
        }

        private void HospitalReport_Click(object sender, EventArgs e)
        {
            new Form11().ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new FindnearestHospital().ShowDialog();
            this.Close();
        }

        private void UpdateDoctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateDoctor().ShowDialog();
            this.Close();
        }
    }
}
