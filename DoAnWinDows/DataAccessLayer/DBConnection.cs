using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DoAnWinDows.BusinessLayer.Models;

namespace DoAnWinDows.DataAccessLayer
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnStr);
        public void OpenConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable DanhSach(string SqlStr)
        {
            DataTable temp = new DataTable();
            try
            {
                this.OpenConnection();
                SqlDataAdapter hienthi = new SqlDataAdapter(SqlStr, conn);
                hienthi.Fill(temp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.CloseConnection();
            }
            return temp;
        }

        public bool ThucThi(string SqlStr)
        {
            try
            {
                this.OpenConnection();
                SqlCommand thucthi = new SqlCommand(SqlStr, conn);
                if (thucthi.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                this.CloseConnection() ;
            }
            return false;
        }

        public bool checkDataTransaction(string SqlStr, SqlTransaction transaction)
        {
            try
            {
                SqlCommand command = new SqlCommand(SqlStr, transaction.Connection, transaction);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return false;
        }

        public bool IsExist(string strSql)
        {
            try
            {
                this.OpenConnection();
                SqlCommand command = new SqlCommand(strSql, conn);
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public SqlDataReader GetDataReader(string strSql)
        {
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd = new SqlCommand(strSql, conn);
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return reader;
        }
    }
}