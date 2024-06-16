using Diplom_Moiceeva.Classes;
using Diplom_Moiceeva.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom_Moiceeva
{
    public partial class Avtorizacia : Form
    {
        public byte[] UserAvatarBytes { get; private set; }
        public Avtorizacia()
        {
            InitializeComponent();
            Txt_password.PasswordChar = '*';
            Bt_avto.Click += (sender, e) => Avto();
            txt_Login.MaxLength = 15;
            Txt_password.MaxLength = 10;
        } 
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Txt_password.UseSystemPasswordChar = false; // Показать текст (отключить маскирование пароля)
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Txt_password.UseSystemPasswordChar = true; // Показать текст (отключить маскирование пароля)
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }
        private void Avto()
        {
            DataTable tb = new DataTable();

            bool authSuccess = CORE.database.ExecuteSqlCommand($@"SELECT Username,Passwordi
                                                FROM Users WHERE (Username = N'{txt_Login.Text}') AND (Passwordi = N'{Txt_password.Text}' and Users.del = 'no')", tb) && tb.Rows.Count > 0;

            if (!authSuccess)
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Cheked();

            // Получаем массив байтов изображения
            UserAvatarBytes = GetUserAvatarBytes(txt_Login.Text);

            new Main(this).Show();
            this.Hide();
        }
        public void Cheked()
        {
            User.user = txt_Login.Text;
        }
        private byte[] GetUserAvatarBytes(string login)
        {
            using (SqlConnection con = new SqlConnection(CORE.database.constr))
            {
                con.Open();

                string sql = @"SELECT Image FROM users WHERE Username = @Username AND del = 'no'";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Username", login);
                    return cmd.ExecuteScalar() as byte[];
                }
            }
        }

    }
}
