using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SchoolMangementSystem
{
    class AddStudentData
    {
        //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\WINDOWS 10\Documents\school.mdf;Integrated Security=True;Connect Timeout=30");
        //public int ID { set; get; }
        //public string StudentID { set; get; }
        //public string StudentName { set; get; }
        //public string StudentGender { set; get; }
        //public string StudentAddress { set; get; }
        //public string StudentGrade { set; get; }
        //public string StudentSection { set; get; }
        //public string StudentImage { set; get; }
        //public string Status { set; get; }
        //public string DateInsert { set; get; }

        private ReadDBFConfig dsconfig = new ReadDBFConfig();

        public string Name { get; set; }
        public string AccountNo { get; set; }
        public string Branch_Code { get; set; }
        public string Branch { get; set; }

        public List<AddStudentData> studentData()
        {
            List<AddStudentData> listData = new List<AddStudentData>();
            try
            {
                DataSet dataSet = dsconfig.readDBFFile("C:\\Users\\arshb\\", "SELECT * from BIO");

                foreach (DataRow dr in dataSet.Tables[0].Rows)
                {
                    AddStudentData allData = new AddStudentData();
                    allData.Name = dr["Name"].ToString();
                    allData.AccountNo = dr["MEM_CODE"].ToString();
                    allData.Branch_Code = dr["BR_CODE"].ToString();
                    allData.Branch = dr["OADD"].ToString();
                    //addSD.ID = (int)reader["id"];
                    //addSD.StudentID = reader["student_id"].ToString();
                    //addSD.StudentName = reader["student_name"].ToString();
                    //addSD.StudentGender = reader["student_gender"].ToString();
                    //addSD.StudentAddress = reader["student_address"].ToString();
                    //addSD.StudentGrade = reader["student_grade"].ToString();
                    //addSD.StudentSection = reader["student_section"].ToString();
                    //addSD.StudentImage = reader["student_image"].ToString();
                    //addSD.Status = reader["student_status"].ToString();
                    //addSD.DateInsert = reader["date_insert"].ToString();

                    listData.Add(allData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting Database: " + ex);
            }
            return listData;

        }

        public List<AddStudentData> dashboardStudentData(string query)
        {
            List<AddStudentData> listData = new List<AddStudentData>();
            try
            { 
                DataSet dataSet = dsconfig.readDBFFile("C:\\Users\\arshb\\", query);

                foreach (DataRow dr in dataSet.Tables[0].Rows)
                {
                    AddStudentData allData = new AddStudentData();
                    allData.Name = dr["Name"].ToString();
                    allData.AccountNo = dr["MEM_CODE"].ToString();
                    allData.Branch_Code = dr["BR_CODE"].ToString();
                    allData.Branch = dr["OADD"].ToString();
                    //addSD.ID = (int)reader["id"];
                    //addSD.StudentID = reader["student_id"].ToString();
                    //addSD.StudentName = reader["student_name"].ToString();
                    //addSD.StudentGender = reader["student_gender"].ToString();
                    //addSD.StudentAddress = reader["student_address"].ToString();
                    //addSD.StudentGrade = reader["student_grade"].ToString();
                    //addSD.StudentSection = reader["student_section"].ToString();
                    //addSD.StudentImage = reader["student_image"].ToString();
                    //addSD.Status = reader["student_status"].ToString();
                    //addSD.DateInsert = reader["date_insert"].ToString();

                    listData.Add(allData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting Database: " + ex);
            }
            return listData;
        }
    }
}
