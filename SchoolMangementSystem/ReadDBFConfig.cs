using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMangementSystem
{
    public class ReadDBFConfig
    {
        public DataSet readDBFFile(string filepath, string query)
        {
            try
            {
                string configDS = $"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = {filepath};Extended Properties = dBase IV; User ID =; Password=";
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = configDS;
                conn.Open();

                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);

                DataSet ds = new DataSet();

                adapter.Fill(ds);
                conn.Close();
                Console.WriteLine("Row Count: " + ds.Tables[0].Rows.Count);
                Console.WriteLine("Column Count: " + ds.Tables[0].Columns.Count);

                return ds;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error", ex.Message);
                throw;
            }
        }
    }
}
