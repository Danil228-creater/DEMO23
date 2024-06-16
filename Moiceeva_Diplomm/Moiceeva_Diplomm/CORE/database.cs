using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moiceeva_Diplomm.CORE
{
    class Database
    {
        public static string constr = @"Data Source=62.78.81.19;Initial Catalog=DP_Moiceeva;User ID=stud;Password=123456789;TrustServerCertificate=True";


        public static SqlConnection con = new SqlConnection(constr);
        public static DataTable Query(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, constr);
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка обращения к БД!\nПроверьте вводимые данные", "Уведомление", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return dt;
            }
        }
        static public bool ExecuteSqlCommand(string sql, DataTable toFill)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, constr);
                adapter.Fill(toFill);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка обращения к БД!\nПроверьте вводимые данные.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public static void Open()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }
        public static void Close()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
        // В классе CORE.database
        public static DataRow GetCurrentUser(string username, string password)
        {
            DataTable tb = new DataTable();

            bool authSuccess = ExecuteSqlCommand($@"SELECT Users.*, 
                                            Ycitel.Famile AS TeacherFamile, Ycitel.Ima AS TeacherIma, 
                                            Ychenik.Famile AS StudentFamile, Ychenik.Ima AS StudentIma ,Ycitel.Kod_Ycitel
                                        FROM Users
                                        LEFT JOIN Ycitel ON Users.Kod_Usera = Ycitel.FK_USER_Ychitel
                                        LEFT JOIN Ychenik ON Users.Kod_Usera = Ychenik.FK_User
                                        WHERE (Users.Username = N'{username}') 
                                        AND (Users.Passwordi = N'{password}' AND Users.del = 'no')", tb) && tb.Rows.Count > 0;

            if (authSuccess)
            {
                return tb.Rows[0];
            }
            return null;
        }
        public static DataRow GetCurrentUchenik(string username, string password)
        {
            DataTable tb = new DataTable();

            bool authSuccess = ExecuteSqlCommand($@"SELECT Users.*, 
                                            Ycitel.Famile AS TeacherFamile, Ycitel.Ima AS TeacherIma, 
                                            Ychenik.Famile AS StudentFamile, Ychenik.Ima AS StudentIma ,Ychenik.Kod_Ychenik
                                        FROM Users
                                        LEFT JOIN Ycitel ON Users.Kod_Usera = Ycitel.FK_USER_Ychitel
                                        LEFT JOIN Ychenik ON Users.Kod_Usera = Ychenik.FK_User
                                        WHERE (Users.Username = N'{username}') 
                                        AND (Users.Passwordi = N'{password}' AND Users.del = 'no')", tb) && tb.Rows.Count > 0;

            if (authSuccess)
            {
                return tb.Rows[0];
            }
            return null;
        }
    }
}
