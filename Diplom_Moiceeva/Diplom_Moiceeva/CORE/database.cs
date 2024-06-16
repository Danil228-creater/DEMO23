using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom_Moiceeva.CORE
{
    class database
    {
        public static string constr = @"Data Source=62.78.81.19;Initial Catalog=DP_Moiceeva;User ID=stud;Password=123456789";

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
            catch (Exception ex)
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
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обращения к БД!\nПроверьте вводимые данные.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public static void open()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }
        public static void close()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }
}
