using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Collections.Generic;

namespace SchoolMangementSystem
{
    public partial class AddStudentForm : UserControl
    {
        //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\WINDOWS 10\Documents\school.mdf;Integrated Security=True;Connect Timeout=30");

        private ReadDBFConfig dsconfig = new ReadDBFConfig();
        public AddStudentForm()
        {
            InitializeComponent();
        }
        private void student_updateBtn_Click(object sender, EventArgs e)
        {
            if (student_id.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<SearchMemberModel> listData = new List<SearchMemberModel>();
                DataSet dataSet = dsconfig.readDBFFile("C:\\Users\\arshb\\", $"SELECT * FROM DTEMNEW WHERE MEM_CODE = '{student_id.Text}' AND (CRCDS IS NOT NULL OR DBCDS IS NOT NULL) order by W_E_F desc"
);

                foreach (DataRow dr in dataSet.Tables[0].Rows)
                {
                    SearchMemberModel allData = new SearchMemberModel();
                    if (!String.IsNullOrEmpty(dr["W_E_F"].ToString()))
                    {
                        DateTime date = Convert.ToDateTime(dr["W_E_F"]);
                        allData.Date = date.ToShortDateString();
                    }
                    else
                    {
                        allData.Date = "";
                    }
                    if ((dr["MTH"].ToString() != string.Empty) && (dr["MTH"].ToString() != "0"))
                    {
                        int monthNumber = Convert.ToInt32(dr["MTH"]);
                        allData.Particulars = new DateTime(1, monthNumber, 1).ToString("MMMM");
                    }
                    else
                    {
                        allData.Particulars = dr["DRFNO"].ToString();
                    }
                    allData.Credit = dr["CRCDS"].ToString();
                    allData.Debit = dr["DBCDS"].ToString();
                    listData.Add(allData);
                }
                student_studentData.DataSource = listData;
            }
        }

        private void student_studentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void student_deleteBtn_Click(object sender, EventArgs e)
        {
            if (student_id.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<SearchMemberModel> listData = new List<SearchMemberModel>();
                DataSet dataSet = dsconfig.readDBFFile("C:\\Users\\arshb\\", $"SELECT * FROM DTEMNEW WHERE MEM_CODE = '{student_id.Text}' AND (CRLOAN IS NOT NULL OR DBLOAN IS NOT NULL) order by W_E_F desc"
);

                foreach (DataRow dr in dataSet.Tables[0].Rows)
                {
                    SearchMemberModel allData = new SearchMemberModel();
                    if (!String.IsNullOrEmpty(dr["W_E_F"].ToString()))
                    {
                        DateTime date = Convert.ToDateTime(dr["W_E_F"]);
                        allData.Date = date.ToShortDateString();
                    }
                    else
                    {
                        allData.Date = "";
                    }
                    if ((dr["MTH"].ToString() != string.Empty) && (dr["MTH"].ToString() != "0"))
                    {
                        int monthNumber = Convert.ToInt32(dr["MTH"]);
                        allData.Particulars = new DateTime(1, monthNumber, 1).ToString("MMMM");
                    }
                    else
                    {
                        allData.Particulars = dr["DRFNO"].ToString();
                    }
                    allData.Credit = dr["CRLOAN"].ToString();
                    allData.Debit = dr["DBLOAN"].ToString();
                    listData.Add(allData);
                }
                student_studentData.DataSource = listData;
            }
        }

        private void student_addBtn_Click(object sender, EventArgs e)
        {
            if (student_id.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<SearchMemberModel> listData = new List<SearchMemberModel>();
                DataSet dataSet = dsconfig.readDBFFile("C:\\Users\\arshb\\", $"SELECT * FROM DTEMNEW WHERE MEM_CODE = '{student_id.Text}' AND (CRLOAN IS NOT NULL OR DBLOAN IS NOT NULL) order by W_E_F desc"
);

                foreach (DataRow dr in dataSet.Tables[0].Rows)
                {
                    SearchMemberModel allData = new SearchMemberModel();
                    if (!String.IsNullOrEmpty(dr["W_E_F"].ToString()))
                    {
                        DateTime date = Convert.ToDateTime(dr["W_E_F"]);
                        allData.Date = date.ToShortDateString();
                    }
                    else
                    {
                        allData.Date = "";
                    }
                    if ((dr["MTH"].ToString() != string.Empty) && (dr["MTH"].ToString() != "0"))
                    {
                        int monthNumber = Convert.ToInt32(dr["MTH"]);
                        allData.Particulars = new DateTime(1, monthNumber, 1).ToString("MMMM");
                    }
                    else
                    {
                        allData.Particulars = dr["DRFNO"].ToString();
                    }
                    allData.Credit = dr["CRLOAN"].ToString();
                    allData.Debit = dr["DBLOAN"].ToString();
                    listData.Add(allData);
                }
                student_studentData.DataSource = listData;
            }
        }

        private void student_clearBtn_Click(object sender, EventArgs e)
        {
            if (student_id.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<SearchMemberModel> listData = new List<SearchMemberModel>();
                DataSet dataSet = dsconfig.readDBFFile("C:\\Users\\arshb\\", $"SELECT * FROM DTEMNEW WHERE MEM_CODE = '{student_id.Text}' AND (CRSM IS NOT NULL OR DBSM IS NOT NULL) order by W_E_F desc"
);

                foreach (DataRow dr in dataSet.Tables[0].Rows)
                {
                    SearchMemberModel allData = new SearchMemberModel();
                    if (!String.IsNullOrEmpty(dr["W_E_F"].ToString()))
                    {
                        DateTime date = Convert.ToDateTime(dr["W_E_F"]);
                        allData.Date = date.ToShortDateString();
                    }
                    else
                    {
                        allData.Date = "";
                    }
                    if ((dr["MTH"].ToString() != string.Empty) && (dr["MTH"].ToString() != "0"))
                    {
                        int monthNumber = Convert.ToInt32(dr["MTH"]);
                        allData.Particulars = new DateTime(1, monthNumber, 1).ToString("MMMM");
                    }
                    else
                    {
                        allData.Particulars = dr["DRFNO"].ToString();
                    }
                    allData.Credit = dr["CRSM"].ToString();
                    allData.Debit = dr["DBSM"].ToString();
                    listData.Add(allData);
                }
                student_studentData.DataSource = listData;
            }
        }
    }
}
