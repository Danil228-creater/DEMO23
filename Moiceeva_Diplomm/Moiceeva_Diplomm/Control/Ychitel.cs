using Moiceeva_Diplomm.CORE;
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

namespace Moiceeva_Diplomm.Control
{
    public partial class Ychitel : UserControl
    {
        public Ychitel()
        {
            InitializeComponent();
            Dt_Ychitel(); Load_User();
            Bt_Insert.Click += (s, a) => Insert_Yhitel();
            Bt_Update.Click += (s, a) => Update_Yhitel();
            Bt_Delete.Click += (s, a) => Delete();
            Bt_Predmet.Click += (s, a) => Perexod();
            Cb_User.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void Dt_Ychitel()
        {
            string sqlQuery = @"select [Kod_Ycitel],[Famile] as 'Фамилия',[Ima] as 'Имя',[Otch] as 'Отчетсво',[Username] as 'Имя пользователя' from [dbo].[Users],[dbo].[Ycitel] where
[dbo].[Users].[Kod_Usera]=[dbo].[Ycitel].[FK_USER_Ychitel] and [dbo].[Ycitel].Del = 'No'
and [Kod_roli] = 1";

            Dt_Ychittel.DataSource = CORE.Database.Query(sqlQuery);
            Dt_Ychittel.Columns[0].Visible = false;
            Dt_Ychittel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Dt_Ychittel.AutoResizeColumns();
            Dt_Ychittel.DefaultCellStyle.ForeColor = Color.Black;
        }
        private void Load_User()
        {
            String sqltext = "select * from  [dbo].[Users] where [Kod_roli] = 1 and [Del] = 'no'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqltext, Database.constr);
            DataTable table = new System.Data.DataTable();

            sqlDataAdapter.Fill(table);

            Cb_User.DataSource = table;
            Cb_User.DisplayMember = "Username";
            Cb_User.ValueMember = "Kod_Usera";

        }
        public void Insert_Yhitel()
        {
            string sql = @"INSERT INTO [dbo].[Ycitel] (FK_USER_Ychitel,Famile,Ima,Otch)
                VALUES (@FK_USER_Ychitel,@Famile,@Ima,@Otch)";

            SqlCommand cmd = new SqlCommand(sql, Database.con);


            cmd.Parameters.AddWithValue("@FK_USER_Ychitel", Cb_User.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@Famile", Tx_Fam.Text);
            cmd.Parameters.AddWithValue("@Ima", Tx_Ima.Text);
            cmd.Parameters.AddWithValue("@Otch", Tx_Otch.Text);

            DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Продолжить добавление записи
                Database.Open();

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись добавлена");
                    Dt_Ychitel();
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

        private void Dt_Ychittel_DoubleClick(object sender, EventArgs e)
        {
            Tx_Fam.Text = Dt_Ychittel.CurrentRow.Cells[1].Value.ToString();
            Tx_Ima.Text = Dt_Ychittel.CurrentRow.Cells[2].Value.ToString();
            Tx_Otch.Text = Dt_Ychittel.CurrentRow.Cells[3].Value.ToString();
            Cb_User.Text = Dt_Ychittel.CurrentRow.Cells[4].Value.ToString();
        }
        public void Update_Yhitel()
        {
            DialogResult result = MessageBox.Show("Изменить запись?",
               "Сообщение",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                try
                {
                    string sql = $@"UPDATE [dbo].[Ycitel] SET 
                        FK_USER_Ychitel ='{Cb_User.SelectedValue}', 
                        Famile ='{Tx_Fam.Text}', 
                        Ima ='{Tx_Ima.Text}', 
                        Otch ='{Tx_Otch.Text}'
                        where Kod_Ycitel = " + Dt_Ychittel.CurrentRow.Cells[0].Value;


                    SqlCommand cmd = new SqlCommand(sql, Database.con);
                    Database.Open();

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Запись обновлена");
                        Dt_Ychitel();
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
        private void Delete()
        {
            try
            {
                int Kod_ychenik = Convert.ToInt32(Dt_Ychittel.CurrentRow.Cells[0].Value);

                // Запрос для получения имени и фамилии ученика
                string getInfoSql = $"SELECT Ima, Famile FROM [dbo].[Ycitel] WHERE [Kod_Ycitel] = {Kod_ychenik}";

                using (SqlCommand getInfoCmd = new SqlCommand(getInfoSql, Database.con))
                {
                    Database.Open();

                    SqlDataReader reader = getInfoCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string firstName = reader["Ima"].ToString();
                        string lastName = reader["Famile"].ToString();

                        // Закрытие DataReader сразу после получения информации
                        reader.Close();

                        // Вопрос для подтверждения удаления с указанием имени и фамилии ученика
                        DialogResult result = MessageBox.Show($"Вы действительно хотите удалить запись учителя {firstName} {lastName}?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Запрос на удаление
                            string deleteSql = $"UPDATE [dbo].[Ycitel] SET [dbo].[Ycitel].Del = 'yes' WHERE [Kod_Ycitel] = {Kod_ychenik}";

                            using (SqlCommand cmd = new SqlCommand(deleteSql, Database.con))
                            {
                                if (cmd.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("Запись удалена");
                                    Dt_Ychitel();
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
        public void Perexod()
        {
            Predmet klas = new Predmet();
            klas.Show();
        }

        private void Tx_Ima_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли введенный символ буквой или управляющей клавишей (например, Backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Если введенный символ не является буквой и не является управляющей клавишей, отменяем ввод
                e.Handled = true;
            }
            // Проверяем, является ли нажатая клавиша символом или управляющей клавишей (например, Backspace)
            if (!char.IsControl(e.KeyChar) && Tx_Ima.Text.Length >= 25)
            {
                // Если длина текста достигла максимальной длины (25 символов), и нажата не управляющая клавиша,
                // то запрещаем дальнейший ввод символов
                e.Handled = true;
            }
        }

        private void Tx_Fam_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли введенный символ буквой или управляющей клавишей (например, Backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Если введенный символ не является буквой и не является управляющей клавишей, отменяем ввод
                e.Handled = true;
            }
            // Проверяем, является ли нажатая клавиша символом или управляющей клавишей (например, Backspace)
            if (!char.IsControl(e.KeyChar) && Tx_Fam.Text.Length >= 25)
            {
                // Если длина текста достигла максимальной длины (25 символов), и нажата не управляющая клавиша,
                // то запрещаем дальнейший ввод символов
                e.Handled = true;
            }
        }

        private void Tx_Otch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли введенный символ буквой или управляющей клавишей (например, Backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Если введенный символ не является буквой и не является управляющей клавишей, отменяем ввод
                e.Handled = true;
            }
            // Проверяем, является ли нажатая клавиша символом или управляющей клавишей (например, Backspace)
            if (!char.IsControl(e.KeyChar) && Tx_Otch.Text.Length >= 25)
            {
                // Если длина текста достигла максимальной длины (25 символов), и нажата не управляющая клавиша,
                // то запрещаем дальнейший ввод символов
                e.Handled = true;
            }
        }
    }
}
