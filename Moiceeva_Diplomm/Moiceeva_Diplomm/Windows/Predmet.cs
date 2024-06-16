using Moiceeva_Diplomm.CORE;
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

namespace Moiceeva_Diplomm.Windows
{
    public partial class Predmet : Form
    {
        public Predmet()
        {
            InitializeComponent();
            Dt_Klas();
            Bt_Insert.Click += (s, a) => Insert_Predmet();
            Bt_Update.Click += (s, a) => Update_Klass();
            Bt_Delete.Click += (s, a) => Delete_Klass();
            Bt_Perexod.Click += (s, a) => Perexod();
            this.MinimumSize = this.MaximumSize = new Size(670, 500);
        }
        public void Dt_Klas()
        {
            string sqlQuery = @"select [Kod_Predmeta],[Nazvanie] as 'Название предмета' from [dbo].[Predmet] where [Del] = 'no'";

            Dt_Predmet.DataSource = CORE.Database.Query(sqlQuery);
            Dt_Predmet.Columns[0].Visible = false;
            Dt_Predmet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Dt_Predmet.AutoResizeColumns();
            Dt_Predmet.DefaultCellStyle.ForeColor = Color.Black;
        }
        public void Insert_Predmet()
        {
            // Проверка на заполненность всех полей
            if (string.IsNullOrWhiteSpace(Tx_Klass.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля перед добавлением записи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = @"INSERT INTO [dbo].[Predmet] (Nazvanie)
                VALUES (@Nazvanie)";

            SqlCommand cmd = new SqlCommand(sql, Database.con);

            cmd.Parameters.AddWithValue("@Nazvanie", Tx_Klass.Text);


            DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Продолжить добавление записи
                Database.Open();

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись добавлена");
                    Dt_Klas();
                }
                else
                {
                    MessageBox.Show("Запись не добавлена");
                }
            }
            else
            {
                // Отмена добавления записи
                MessageBox.Show("Добавление записи отменено");
            }

        }
        public void Update_Klass()
        {
            // Проверка на заполненность всех полей
            if (string.IsNullOrWhiteSpace(Tx_Klass.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля перед обновлением записи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Изменить запись?",
               "Сообщение",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                try
                {
                    string sql = $@"UPDATE [dbo].[Predmet] SET 
                        Nazvanie ='{Tx_Klass.Text}'
                        where Kod_Predmeta = " + Dt_Predmet.CurrentRow.Cells[0].Value;


                    SqlCommand cmd = new SqlCommand(sql, Database.con);
                    Database.Open();

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Запись обновлена");
                        Dt_Klas();
                    }
                    else
                    {
                        MessageBox.Show("Запись не обновлена");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Запись обнавлена", "Обновление!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Delete_Klass()
        {
            try
            {
                int Kodklass = Convert.ToInt32(Dt_Predmet.CurrentRow.Cells[0].Value);

                string getInfoSql = $"select Kod_Predmeta,Nazvanie from [dbo].[Predmet] where Del = 'no' and [Kod_Predmeta] = {Kodklass}";

                using (SqlCommand getInfoCmd = new SqlCommand(getInfoSql, Database.con))
                {
                    Database.Open();

                    SqlDataReader reader = getInfoCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string firstName = reader["Nazvanie"].ToString();

                        // Закрытие DataReader сразу после получения информации
                        reader.Close();

                        // Вопрос для подтверждения удаления с указанием имени и фамилии ученика
                        DialogResult result = MessageBox.Show($"Вы действительно хотите удалить предмет :{firstName}?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Запрос на удаление
                            string deleteSql = $"UPDATE [dbo].[Predmet] SET [dbo].[Predmet].Del = 'yes' WHERE [Kod_Predmeta] = {Kodklass}";

                            using (SqlCommand cmd = new SqlCommand(deleteSql, Database.con))
                            {
                                if (cmd.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("Запись удалена");
                                    Dt_Klas();
                                }
                                else
                                {
                                    MessageBox.Show("Запись не удалена");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не удалось получить информацию об предмете", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при удалении записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dt_Predmet_DoubleClick(object sender, EventArgs e)
        {
            Tx_Klass.Text = Dt_Predmet.CurrentRow.Cells[1].Value.ToString();
        }
        public void Perexod()
        {
            Predmet_Ychitel predmet_Ychitel = new Predmet_Ychitel();
            predmet_Ychitel.Show();
        }

        private void Tx_Klass_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли нажатая клавиша символом или управляющей клавишей (например, Backspace)
            if (!char.IsControl(e.KeyChar) && Tx_Klass.Text.Length >= 20)
            {
                // Если длина текста достигла максимальной длины (25 символов), и нажата не управляющая клавиша,
                // то запрещаем дальнейший ввод символов
                e.Handled = true;
            }
            // Проверяем, является ли введенный символ буквой или управляющей клавишей (например, Backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Если введенный символ не является буквой и не является управляющей клавишей, отменяем ввод
                e.Handled = true;
            }
        }
    }
}
