using Moiceeva_Diplomm.Classes;
using Moiceeva_Diplomm.Control;
using Moiceeva_Diplomm.Windows;
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

namespace Moiceeva_Diplomm
{
    public partial class Avtorizacia : Form
    {
        public byte[] UserAvatarBytes { get; private set; }
        public string name_user { get; private set; }
        public Avtorizacia()
        {
            InitializeComponent();
            Txt_password.PasswordChar = '*';
            Bt_avto.Click += (sender, e) => Avto();
            txt_Login.MaxLength = 20;
            Txt_password.MaxLength = 20;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Txt_password.UseSystemPasswordChar = false; // Показать текст (отключить маскирование пароля)
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Txt_password.UseSystemPasswordChar = true; // Показать текст (отключить маскирование пароля)
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }
        private void Avto()
        {
            DataTable tb = new DataTable();

            bool authSuccess = CORE.Database.ExecuteSqlCommand($@"SELECT Username, Passwordi
                                            FROM Users WHERE (Username = N'{txt_Login.Text}') AND 
                                            (Passwordi = N'{Txt_password.Text}' and Users.del = 'no')", tb) && tb.Rows.Count > 0;

            if (!authSuccess)
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем массив байтов изображения
            UserAvatarBytes = GetUserAvatarBytes(txt_Login.Text);

            name_user = txt_Login.Text;

            new Main(this, Txt_password.Text).Show();
            this.Hide();
        }

        public void Cheked()
        {
            User.user = txt_Login.Text;
        }
        private byte[] GetUserAvatarBytes(string login)
        {
            using (SqlConnection con = new SqlConnection(CORE.Database.constr))
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
        public string GetUserPassword()
        {
            return Txt_password.Text;
        }

        private void txt_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли нажатая клавиша символом или управляющей клавишей (например, Backspace)
            if (!char.IsControl(e.KeyChar) && txt_Login.Text.Length >= 60)
            {
                // Если длина текста достигла максимальной длины (25 символов), и нажата не управляющая клавиша,
                // то запрещаем дальнейший ввод символов
                e.Handled = true;
            }
        }

        private void Txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли нажатая клавиша символом или управляющей клавишей (например, Backspace)
            if (!char.IsControl(e.KeyChar) && Txt_password.Text.Length >= 40)
            {
                // Если длина текста достигла максимальной длины (25 символов), и нажата не управляющая клавиша,
                // то запрещаем дальнейший ввод символов
                e.Handled = true;
            }
        }
    }
}
