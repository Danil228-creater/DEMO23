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
    public partial class Klass : Form
    {
        public Klass()
        {
            InitializeComponent();
            Dt_Klas();
            Bt_Insert.Click += (s, a) => Insert_Klass();
            Bt_Update.Click += (s, a) => Update_Klass();
            Bt_Delete.Click += (s, a) => Delete_Klass();
            this.MinimumSize = this.MaximumSize = new Size(600, 500);
        }
        public void Dt_Klas()
        {
            string sqlQuery = @"select Kod_klass,ClassName as 'Название класса',Del from [dbo].[Classes] where Del = 'no'";

            Dt_Klass.DataSource = CORE.Database.Query(sqlQuery);
            Dt_Klass.Columns[0].Visible = false;
            Dt_Klass.Columns[2].Visible = false;
            Dt_Klass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Dt_Klass.AutoResizeColumns();
            Dt_Klass.DefaultCellStyle.ForeColor = Color.Black;
        }
        public void Insert_Klass()
        {
            // Проверка на заполненность всех полей
            if (string.IsNullOrWhiteSpace(Tx_Klass.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля перед добавлением записи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql = @"INSERT INTO [dbo].[Classes] (ClassName)
                VALUES (@ClassName)";

            SqlCommand cmd = new SqlCommand(sql, Database.con);

            cmd.Parameters.AddWithValue("@ClassName", Tx_Klass.Text);


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

        private void Dt_Klass_DoubleClick(object sender, EventArgs e)
        {
            Tx_Klass.Text = Dt_Klass.CurrentRow.Cells[1].Value.ToString();
        }
        public void Update_Klass()
        {
            // Проверка на заполненность всех полей
            if (string.IsNullOrWhiteSpace(Tx_Klass.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля перед обновлением записей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string sql = $@"UPDATE [dbo].[Classes] SET 
                        ClassName ='{Tx_Klass.Text}'
                        where Kod_klass = " + Dt_Klass.CurrentRow.Cells[0].Value;


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
                int Kodklass = Convert.ToInt32(Dt_Klass.CurrentRow.Cells[0].Value);

                string getInfoSql = $"select Kod_klass,ClassName,Del from [dbo].[Classes] where Del = 'no' and [Kod_klass] = {Kodklass}";

                using (SqlCommand getInfoCmd = new SqlCommand(getInfoSql, Database.con))
                {
                    Database.Open();

                    SqlDataReader reader = getInfoCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string firstName = reader["ClassName"].ToString();
                        
                        // Закрытие DataReader сразу после получения информации
                        reader.Close();

                        // Вопрос для подтверждения удаления с указанием имени и фамилии ученика
                        DialogResult result = MessageBox.Show($"Вы действительно хотите удалить класс: {firstName}?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Запрос на удаление
                            string deleteSql = $"UPDATE [dbo].[Classes] SET [dbo].[Classes].Del = 'yes' WHERE [Kod_klass] = {Kodklass}";

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
                        MessageBox.Show("Не удалось получить информацию об ученике", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при удалении записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tx_Klass_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли нажатая клавиша символом или управляющей клавишей (например, Backspace)
            if (!char.IsControl(e.KeyChar) && Tx_Klass.Text.Length >= 15)
            {
                // Если длина текста достигла максимальной длины (25 символов), и нажата не управляющая клавиша,
                // то запрещаем дальнейший ввод символов
                e.Handled = true;
            }
        }
    }
}
