using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SchoolMangementSystem
{
    public partial class DashboardForm : UserControl
    {
        //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\WINDOWS 10\Documents\school.mdf;Integrated Security=True;Connect Timeout=30");

        private ReadDBFConfig dsconfig = new ReadDBFConfig();
        public DashboardForm()
        {
            InitializeComponent();
            displayTotalTM();
            displayEnrolledStudentToday();
        }

        public void displayTotalTM()
        {
            try
            {
                DataSet dataSet = dsconfig.readDBFFile("C:\\Users\\arshb\\", "SELECT * from BIO");
                total_TM.Text = dataSet.Tables[0].Rows.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error to connect Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void displayEnrolledStudentToday()
        {
            AddStudentData asData = new AddStudentData();

            dataGridView1.DataSource = asData.dashboardStudentData("SELECT * from BIO");
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == string.Empty)
            {
                MessageBox.Show("Please select item first", "Error Message"
    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string filterby = comboBox1.SelectedItem.ToString() == "AccountNo" ? "MEM_CODE" : comboBox1.SelectedItem.ToString();
                AddStudentData asData = new AddStudentData();
                dataGridView1.DataSource = asData.dashboardStudentData($"SELECT * from BIO where {filterby} LIKE '%{textBox1.Text.Trim()}%'");
            }
        }
    }
}
