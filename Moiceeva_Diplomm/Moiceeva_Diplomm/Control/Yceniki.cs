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
    public partial class Yceniki : UserControl
    {
        public Yceniki()
        {
            InitializeComponent();
            Dt_Ycheniki(); Load_Klass(); Load_User();
            Bt_Insert.Click += (s, a) => Insert_Ychactniki();
            Bt_Update.Click += (s, a) => Update_Ychenik();
            Bt_Delete.Click += (s, a) => Delete_Yhenik();
            Bt_Insert_Klass.Click += (s, a) => Perexod();
            Bt_Obnova.Click += (s, a) => Dt_Ycheniki(); Load_Klass_Poick();
            Dt_Ucheniki.ReadOnly = true;
            Cb_Klass.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Poick.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_User.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void Dt_Ycheniki()
        {
            string sqlQuery = @"select [Kod_Ychenik], [Famile] as 'Фамилия',[Ima] as 'Имя',[Otch] as 
            'Отчество',Ychenik.Del,[Username] as 'Имя пользователя',[ClassName] as 'Название класса' from [dbo].[Classes],[dbo].[Users],[dbo].[Ychenik] 
             where [dbo].[Ychenik].[FK_User] = 
             [dbo].[Users].Kod_Usera and [dbo].[Ychenik].Kod_Klassa = [dbo].[Classes].Kod_klass and [dbo].[Ychenik].[Del] = 'no'and [dbo].[Classes].[Del] = 'no' ";

            Dt_Ucheniki.DataSource = CORE.Database.Query(sqlQuery);
            Dt_Ucheniki.Columns[0].Visible = false;
            Dt_Ucheniki.Columns[4].Visible = false;
            Dt_Ucheniki.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Dt_Ucheniki.AutoResizeColumns();
            Dt_Ucheniki.DefaultCellStyle.ForeColor = Color.Black;
        }
        public void Insert_Ychactniki()
        {
            try
            {
                // Проверка на заполненность всех полей
                if (string.IsNullOrWhiteSpace(Tx_Fam.Text) || string.IsNullOrWhiteSpace(Tx_Ima.Text) || string.IsNullOrWhiteSpace(Tx_Otch.Text) ||
                    Cb_User.SelectedValue == null || Cb_Klass.SelectedValue == null)
                {
                    MessageBox.Show("Пожалуйста, заполните все поля перед добавлением записи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sql = @"INSERT INTO [dbo].[Ychenik] (FK_User,Famile,Ima,Otch,Kod_Klassa)
             VALUES (@FK_User,@Famile,@Ima,@Otch,@Kod_Klassa)";

                SqlCommand cmd = new SqlCommand(sql, Database.con);

                cmd.Parameters.AddWithValue("@FK_User", Cb_User.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@Famile", Tx_Fam.Text);
                cmd.Parameters.AddWithValue("@Ima", Tx_Ima.Text);
                cmd.Parameters.AddWithValue("@Otch", Tx_Otch.Text);
                cmd.Parameters.AddWithValue("@Kod_Klassa", Cb_Klass.SelectedValue.ToString());

                DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Продолжить добавление записи
                    Database.Open();

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Запись добавлена");
                        Dt_Ycheniki();
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
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Load_Klass()
        {
            String sqltext = "select * from Classes where Del='no'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqltext, Database.constr);
            DataTable table = new System.Data.DataTable();

            sqlDataAdapter.Fill(table);

            Cb_Klass.DataSource = table;
            Cb_Klass.DisplayMember = "ClassName";
            Cb_Klass.ValueMember = "Kod_klass";

        }
        private void Load_Klass_Poick()
        {
            String sqltext = "select * from Classes where Del='no'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqltext, Database.constr);
            DataTable table = new System.Data.DataTable();

            sqlDataAdapter.Fill(table);

            CB_Poick.DataSource = table;
            CB_Poick.DisplayMember = "ClassName";
            CB_Poick.ValueMember = "Kod_klass";
        }
        private void Load_User()
        {
            String sqltext = "select * from  [dbo].[Users] where [Kod_roli] = 3 and [Del] = 'no'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqltext, Database.constr);
            DataTable table = new System.Data.DataTable();

            sqlDataAdapter.Fill(table);

            Cb_User.DataSource = table;
            Cb_User.DisplayMember = "Username";
            Cb_User.ValueMember = "Kod_Usera";

        }

        private void Dt_Ucheniki_DoubleClick(object sender, EventArgs e)
        {
            Tx_Fam.Text = Dt_Ucheniki.CurrentRow.Cells[1].Value.ToString();
            Tx_Ima.Text = Dt_Ucheniki.CurrentRow.Cells[2].Value.ToString();
            Tx_Otch.Text = Dt_Ucheniki.CurrentRow.Cells[3].Value.ToString();
            Cb_User.Text = Dt_Ucheniki.CurrentRow.Cells[5].Value.ToString();
            Cb_Klass.Text = Dt_Ucheniki.CurrentRow.Cells[6].Value.ToString();
        }
        public void Update_Ychenik()
        {
            // Проверка на заполненность всех полей
            if (string.IsNullOrWhiteSpace(Tx_Fam.Text) || string.IsNullOrWhiteSpace(Tx_Ima.Text) || string.IsNullOrWhiteSpace(Tx_Otch.Text) ||
                Cb_User.SelectedValue == null || Cb_Klass.SelectedValue == null)
            {
                MessageBox.Show("Пожалуйста, заполните все поля перед изменением записи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string sql = $@"UPDATE [dbo].[Ychenik] SET 
                        FK_User ='{Cb_User.SelectedValue}', 
                        Famile ='{Tx_Fam.Text}', 
                        Ima ='{Tx_Ima.Text}', 
                        Otch ='{Tx_Otch.Text}', 
                        Kod_Klassa ='{Cb_Klass.SelectedValue}'
                        where Kod_Ychenik = " + Dt_Ucheniki.CurrentRow.Cells[0].Value;


                    SqlCommand cmd = new SqlCommand(sql, Database.con);
                    Database.Open();

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Запись обновлена");
                        Dt_Ycheniki();
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
        private void Delete_Yhenik()
        {
            try
            {
                int kodYchenik = Convert.ToInt32(Dt_Ucheniki.CurrentRow.Cells[0].Value);

                // Запрос для получения имени и фамилии ученика
                string getInfoSql = $"SELECT Ima, Famile FROM [dbo].[Ychenik] WHERE [Kod_Ychenik] = {kodYchenik}";

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
                        DialogResult result = MessageBox.Show($"Вы действительно хотите удалить запись ученика {firstName} {lastName}?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Запрос на удаление
                            string deleteSql = $"UPDATE [dbo].[Ychenik] SET [dbo].[Ychenik].Del = 'yes' WHERE [Kod_Ychenik] = {kodYchenik}";

                            using (SqlCommand cmd = new SqlCommand(deleteSql, Database.con))
                            {
                                if (cmd.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("Запись удалена");
                                    Dt_Ycheniki();
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
            Klass klas = new Klass();
            klas.Show();
        }

        private void CB_Poick_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CB_Poick.SelectedItem != null)
                {
                    DataRowView selectedRow = (DataRowView)CB_Poick.SelectedItem;

                    // Получаем значение выбранного класса из колонки "Kod_klass" (используйте правильное имя колонки)
                    string selectedClass = selectedRow["Kod_klass"].ToString();

                    // Выполняем параметризированный запрос к базе данных, используя выбранный класс
                    string sqltext = @"
                SELECT [Kod_Ychenik], [Famile] as 'Фамилия', [Ima] as 'Имя', [Otch] as 'Отчество', Ychenik.Del,
                       [Username] as 'Имя пользователя', [ClassName] as 'Название класса'
                FROM [dbo].[Classes], [dbo].[Users], [dbo].[Ychenik]
                WHERE [dbo].[Ychenik].[FK_User] = [dbo].[Users].Kod_Usera 
                    AND [dbo].[Ychenik].Kod_Klassa = [dbo].[Classes].Kod_klass 
                    AND [dbo].[Ychenik].[Del] = 'no' 
                    AND [dbo].[Classes].[Del] = 'no' 
                    AND [dbo].[Classes].[Kod_klass] = @SelectedClass";

                    using (SqlCommand cmd = new SqlCommand(sqltext, Database.con))
                    {
                        cmd.Parameters.AddWithValue("@SelectedClass", selectedClass);
                        cmd.CommandType = CommandType.Text;

                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        sqlDataAdapter.Fill(table);

                        // Обновляем DataSource для DataGridView
                        Dt_Ucheniki.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
