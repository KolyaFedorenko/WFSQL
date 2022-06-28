using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFSQL
{
    public class Database
    {
        private string connectionString;

        /// <summary>
        /// Creates a new instance of the Database class
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public Database(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Fills in the DataGridView passed to the method as a parameter
        /// </summary>
        /// <param name="sqlQuery">SQL query with SELECT</param>
        /// <param name="dgvToFill">DataGridView to be filled in</param>
        /// <returns>If the DataGridView is filled in successfully, it returns true, otherwise it returns false</returns>
        public bool FillDataGridView(string sqlQuery, DataGridView dgvToFill)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvToFill.DataSource = ds.Tables[0];
                    connection.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error occurred when filling in the DataGridView:\n{e}");
                return false;
            }
        }

        /// <summary>
        /// Fills in the ComboBox passed to the method as a parameter
        /// </summary>
        /// <param name="sqlQuery">SQL query with SELECT</param>
        /// <param name="cbToFill">DataGridView to be filled in</param>
        /// <param name="valueMember">The primary key of the table (most often - ID)</param>
        /// <param name="displayMember">The field to be displayed</param>
        /// <returns>If the ComboBox is filled in successfully, it returns true, otherwise it returns false</returns>
        public bool FillComboBox(string sqlQuery, ComboBox cbToFill, string valueMember, string displayMember)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cbToFill.DataSource = dt;
                    cbToFill.ValueMember = valueMember;
                    cbToFill.DisplayMember = displayMember;
                    connection.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error occurred when filling in the ComboBox:\n{e}");
                return false;
            }
        }

        /// <summary>
        /// Executes an SQL query to the database (recommended for queries involving INSERT, DELETE, or UPDATE)
        /// </summary>
        /// <param name="sqlQuery">SQL query with INSERT, DELETE, UPDATE or something else</param>
        /// <returns>If the SQL query was executed successfully, it returns true, otherwise it returns false</returns>
        public bool ExecuteSqlQuery(string sqlQuery)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error occurred while executing a query to the database:\n{e}");
                return false;
            }
        }
    }
}
