using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms; // For MessageBox

namespace DatabaseProject
{
    class DbConnections : IDisposable
    {
        private static SqlConnection connection = new SqlConnection();
        private static SqlCommand command = new SqlCommand();
        private static SqlDataReader DbReader;
        private static SqlDataAdapter adapter = new SqlDataAdapter();
        public SqlTransaction DbTran;
        private static string strConnString = "Data Source=DESKTOP-8TM8KGG\\SQLEXPRESS;Initial Catalog=DB_Hotel_Management;Integrated Security=True;Trust Server Certificate=True";

        public void createConn()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = strConnString;
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error establishing database connection: " + ex.Message);
                throw;
            }
        }

        public void closeConn()
        {
            if (connection != null && connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        // Implement IDisposable
        public void Dispose()
        {
            if (connection != null)
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
                connection.Dispose();
            }
        }

        public int executeDataAdapter(DataTable tblName, string strSelectSql)
        {
            try
            {
                if (connection.State == 0)
                {
                    createConn();
                }

                adapter.SelectCommand.CommandText = strSelectSql;
                adapter.SelectCommand.CommandType = CommandType.Text;

                SqlCommandBuilder DbCommandBuilder = new SqlCommandBuilder(adapter);

                string insert = DbCommandBuilder.GetInsertCommand().CommandText.ToString();
                string update = DbCommandBuilder.GetUpdateCommand().CommandText.ToString();
                string delete = DbCommandBuilder.GetDeleteCommand().CommandText.ToString();

                return adapter.Update(tblName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                throw;
            }
        }

        public void readDatathroughAdapter(string query, DataTable tblName)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                adapter = new SqlDataAdapter(command);
                adapter.Fill(tblName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                throw;
            }
        }

        internal int executeQuery(SqlCommand insertCommand)
        {
            int rowsAffected = 0;
            try
            {
                createConn();
                insertCommand.Connection = connection;
                rowsAffected = insertCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            finally
            {
                closeConn();
            }
            return rowsAffected;
        }

        internal void executeQuery(string deleteQuery)
        {
            try
            {
                createConn();
                using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message);
                throw;
            }
            finally
            {
                closeConn();
            }
        }

        public int InsertBooking(
            int room_id,
            string guest_name,
            string phone_number,
            string email,
            int age,
            string gender,
            string method,
            decimal amount,
            int advance_payment,
            string stay_type,
            DateTime checkin_date,
            DateTime checkout_date,
            int no_guest)
        {
            int rowsAffected = 0;
            try
            {
                createConn();

                string insertQuery = @"
                INSERT INTO tbl_Booking 
                (room_id, guest_name, phone_number, email, age, gender, method, amount, advance_payment, stay_type, checkin_date, checkout_date, no_guest)
                VALUES
                (@room_id, @guest_name, @phone_number, @email, @age, @gender, @method, @amount, @advance_payment, @stay_type, @checkin_date, @checkout_date, @no_guest)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@room_id", room_id);
                    cmd.Parameters.AddWithValue("@guest_name", guest_name);
                    cmd.Parameters.AddWithValue("@phone_number", phone_number);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@method", method);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@advance_payment", advance_payment);
                    cmd.Parameters.AddWithValue("@stay_type", stay_type);
                    cmd.Parameters.AddWithValue("@checkin_date", checkin_date);
                    cmd.Parameters.AddWithValue("@checkout_date", checkout_date);
                    cmd.Parameters.AddWithValue("@no_guest", no_guest);

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error inserting booking: " + ex.Message);
            }
            finally
            {
                closeConn();
            }
            return rowsAffected;
        }

        public void UpdateRoomStatus(int room_id, string newStatus)
        {
            string query = $"UPDATE tbl_Room SET status = @status WHERE room_id = @room_id";

            try
            {
                createConn();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@room_id", room_id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error updating room status: " + ex.Message);
            }
            finally
            {
                closeConn();
            }
        }
    }
}