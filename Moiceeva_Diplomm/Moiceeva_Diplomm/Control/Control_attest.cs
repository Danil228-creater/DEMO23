using Moiceeva_Diplomm.CORE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace Moiceeva_Diplomm.Control
{
    public partial class Control_attest : UserControl
    {
        private readonly Avtorizacia parentForm;
        private readonly string userPassword;

        public Control_attest(Avtorizacia parentForm, string userPassword)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.userPassword = userPassword;
            LoadDataToDataGridView();
            Load_Klass();
            Load_Predmet(userPassword, parentForm);
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoResizeColumns();
            buttonAdd.Click += (s, a) => Insert_Attectacia();
            buttonEdit.Click += (s, a) => Update_Attectacia();
            buttonDelete.Click += (s, a) => Delete_Otmetka();
            LoadClasses(); LoadPredmetsForCurrentUser();
            Cb_Classs.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Ychenik.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Predmet.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Otmetka.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Pricyt.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Prichina.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Klass.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Predmet_Filter.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridView.ReadOnly = true;
        }
        public void Load_Klass()
        {
            String sqltext = "select * from Classes where Del = 'no'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqltext, Database.constr);
            System.Data.DataTable table = new System.Data.DataTable();

            sqlDataAdapter.Fill(table);

            Cb_Classs.DataSource = table;
            Cb_Classs.DisplayMember = "ClassName";
            Cb_Classs.ValueMember = "Kod_klass";
        }
        private void Load_Predmet(string userPassword, Avtorizacia parentForm)
        {

            DataRow currentUser = CORE.Database.GetCurrentUser(parentForm.name_user, userPassword);

            object kodYchitelObject = currentUser["Kod_Ycitel"];
            int kodYchitel = kodYchitelObject != DBNull.Value ? Convert.ToInt32(kodYchitelObject) : 0; 

            string sqltext = $@"SELECT [dbo].[Predmet].*
                        FROM [dbo].[Predmet_Ychitel]
                        INNER JOIN [dbo].[Predmet] ON [dbo].[Predmet_Ychitel].Kod_Predmet = [dbo].[Predmet].Kod_Predmeta
                        WHERE [dbo].[Predmet_Ychitel].Kod_Ychitel = {kodYchitel} AND [dbo].[Predmet].[Del] = 'no' and Predmet_Ychitel.Del = 'no'";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqltext, Database.constr);
            System.Data.DataTable table = new System.Data.DataTable();

            sqlDataAdapter.Fill(table);

            Cb_Predmet.DataSource = table;
            Cb_Predmet.DisplayMember = "Nazvanie";
            Cb_Predmet.ValueMember = "Kod_Predmeta";
        }

        private void FilterStudentsByClass(int selectedClass)
        {

            if (Cb_Ychenik.SelectedValue != null)
            {

                int selectedStudent = Convert.ToInt32(Cb_Ychenik.SelectedValue);
                string sqltext = $"SELECT Kod_Klassa FROM Ychenik WHERE Kod_Ychenik = {selectedStudent}";
                System.Data.DataTable classTable = new System.Data.DataTable();
                CORE.Database.ExecuteSqlCommand(sqltext, classTable);

                if (classTable.Rows.Count > 0)
                {
                    int studentClass = Convert.ToInt32(classTable.Rows[0]["Kod_Klassa"]);

                    if (studentClass != selectedClass)
                    {
                        Cb_Classs.SelectedValue = studentClass;
                    }
                }
            }

            string filterStudentsQuery = $@"
        SELECT Kod_Ychenik, CONCAT([Ychenik].[Famile], ' ', [Ychenik].[Ima], ' ', [Ychenik].[Otch]) as 'ФИО' FROM Ychenik
        WHERE Kod_Klassa = {selectedClass} and Del = 'no'";

            System.Data.DataTable studentsTable = new System.Data.DataTable();
            CORE.Database.ExecuteSqlCommand(filterStudentsQuery, studentsTable);

            Cb_Ychenik.DataSource = studentsTable;
            Cb_Ychenik.DisplayMember = "ФИО";
            Cb_Ychenik.ValueMember = "Kod_Ychenik";
        }
        public void Insert_Attectacia()
        {
            try
            {
                if (Cb_Ychenik.SelectedValue == null || Cb_Predmet.SelectedValue == null)
                {
                    MessageBox.Show("Пожалуйста, выберите ученика и предмет перед добавлением записи.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRow currentUser = CORE.Database.GetCurrentUser(parentForm.name_user, userPassword);

                int kodYchitel = currentUser.Field<int>("Kod_Ycitel");

                if (!int.TryParse(Cb_Ychenik.SelectedValue.ToString(), out int kodYcenika))
                {
                    MessageBox.Show("Ошибка при преобразовании Kod_Ycenika в число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(Cb_Predmet.SelectedValue.ToString(), out int kodPredmeta))
                {
                    MessageBox.Show("Ошибка при преобразовании Kod_Predmeta в число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(Cb_Otmetka.Text, out decimal otmetkaValue))
                {
                    MessageBox.Show("Ошибка при преобразовании Otmetka в число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sql = @"
        INSERT INTO [dbo].[Otcenki] (Kod_Ycenika, Kod_Predmeta, Kod_Ychitel, Otmetka, Data_Victavlenie,
                                     Prichina_Otcytv, Pocesaemoct, Premicanie)
        VALUES (@Kod_Ycenika, @Kod_Predmeta, @Kod_Ychitel, @Otmetka, @Data_Victavlenie,
                @Prichina_Otcytv, @Pocesaemoct, @Premicanie)";

                using (SqlCommand cmd = new SqlCommand(sql, Database.con))
                {
                    cmd.Parameters.AddWithValue("@Kod_Ycenika", kodYcenika);
                    cmd.Parameters.AddWithValue("@Kod_Predmeta", kodPredmeta);
                    cmd.Parameters.AddWithValue("@Kod_Ychitel", kodYchitel);
                    cmd.Parameters.AddWithValue("@Otmetka", otmetkaValue);
                    cmd.Parameters.AddWithValue("@Data_Victavlenie", Dt_Date.Value);
                    cmd.Parameters.AddWithValue("@Prichina_Otcytv", Cb_Prichina.Text);
                    cmd.Parameters.AddWithValue("@Pocesaemoct", Cb_Pricyt.Text);
                    cmd.Parameters.AddWithValue("@Premicanie", Tx_Primechanie.Text);

                    if (MessageBox.Show("Вы уверены, что хотите добавить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Database.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Запись добавлена");
                            }
                            else
                            {
                                MessageBox.Show("Запись не добавлена");
                            }
                        }
                        catch (SqlException sqlEx)
                        {
                            MessageBox.Show($"Ошибка SQL: {sqlEx.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при добавлении записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            Database.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Добавление записи отменено");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неизвестная ошибка: {ex.Message}\nСтек вызовов:\n{ex.StackTrace}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update_Attectacia()
        {
            if (Cb_Ychenik.SelectedValue == null || Cb_Predmet.SelectedValue == null)
            {
                MessageBox.Show("Пожалуйста, выберите ученика и предмет перед обновлением записи.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow currentUser = CORE.Database.GetCurrentUser(parentForm.name_user, userPassword);

            int kodYchitel = currentUser.Field<int>("Kod_Ycitel");

            if (!int.TryParse(Cb_Ychenik.SelectedValue.ToString(), out int kodYcenika))
            {
                MessageBox.Show("Ошибка при преобразовании Kod_Ycenika в число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(Cb_Otmetka.Text, out decimal otmetkaValue))
            {
                MessageBox.Show("Ошибка при преобразовании Otmetka в число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Вы действительно хотите обновить эту запись?", "Обновление записи", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string sql = @"
    UPDATE [dbo].[Otcenki] 
    SET Otmetka = @Otmetka,
        Data_Victavlenie = @Data_Victavlenie,
        Prichina_Otcytv = @Prichina_Otcytv,
        Pocesaemoct = @Pocesaemoct,
        Premicanie = @Premicanie,
        Kod_Predmeta = @Kod_Predmeta,
        Kod_Ychitel = @Kod_Ychitel,
        Kod_Ycenika = @Kod_Ycenika 
        WHERE Kod_Otcenki = @Kod_Otcenki";

                using (SqlCommand cmd = new SqlCommand(sql, Database.con))
                {
                    cmd.Parameters.AddWithValue("@Kod_Ycenika", kodYcenika);
                    cmd.Parameters.AddWithValue("@Kod_Predmeta", Cb_Predmet.SelectedValue?.ToString());
                    cmd.Parameters.AddWithValue("@Kod_Ychitel", kodYchitel);
                    cmd.Parameters.AddWithValue("@Otmetka", otmetkaValue);
                    cmd.Parameters.AddWithValue("@Data_Victavlenie", Dt_Date.Value);
                    cmd.Parameters.AddWithValue("@Prichina_Otcytv", Cb_Prichina.Text);
                    cmd.Parameters.AddWithValue("@Pocesaemoct", Cb_Pricyt.Text);
                    cmd.Parameters.AddWithValue("@Premicanie", Tx_Primechanie.Text);
                    cmd.Parameters.AddWithValue("@Kod_Otcenki", dataGridView.CurrentRow.Cells[0].Value);
                    try
                    {
                        Database.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Запись обновлена");
                        }
                        else
                        {
                            MessageBox.Show("Запись не обновлена");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при обновлении записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Database.Close();
                    }
                }
            }
        }

        public void LoadOtcenkiForCurrentUser()
        {
            DataRow currentUser = CORE.Database.GetCurrentUser(parentForm.name_user, userPassword);

            object kodYchitelObject = currentUser["Kod_Ycitel"];
            int kodYchitel = kodYchitelObject != DBNull.Value ? Convert.ToInt32(kodYchitelObject) : 0; 

            string sqltext = $@"
        SELECT [Kod_Otcenki], [Famile], [Ima], [Otch], [Nazvanie], [Otmetka], [Data_Victavlenie]
        FROM [dbo].[Otcenki]
        INNER JOIN [dbo].[Predmet] ON [dbo].[Otcenki].[Kod_Predmeta] = [dbo].[Predmet].[Kod_Predmeta]
        INNER JOIN [dbo].[Ychenik] ON [dbo].[Otcenki].[Kod_Ycenika] = [dbo].[Ychenik].[Kod_Ychenik]
        WHERE [dbo].[Otcenki].[Kod_Ychitel] = {kodYchitel}";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqltext, Database.constr);
            System.Data.DataTable table = new System.Data.DataTable();

            sqlDataAdapter.Fill(table);
            dataGridView.DataSource = table;
        }

        private void Cb_Classs_SelectedIndexChanged(object sender, EventArgs e)
        {

            Cb_Ychenik.DataSource = null;

            string selectedClassStr = Cb_Classs.SelectedValue?.ToString();

            if (int.TryParse(selectedClassStr, out int selectedClass))
            {
                FilterStudentsByClass(selectedClass);
            }
        }
        private void LoadClasses()
        {
            string sqltext = "SELECT * FROM Classes WHERE Del = 'no'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqltext, Database.constr);
            System.Data.DataTable table = new System.Data.DataTable();

            sqlDataAdapter.Fill(table);

            Cb_Klass.DataSource = table;
            Cb_Klass.DisplayMember = "ClassName";
            Cb_Klass.ValueMember = "Kod_klass";
        }

        private void LoadPredmetsForCurrentUser()
        {

            DataRow currentUser = CORE.Database.GetCurrentUser(parentForm.name_user, userPassword);


            object kodYchitelObject = currentUser["Kod_Ycitel"];
            int kodYchitel = kodYchitelObject != DBNull.Value ? Convert.ToInt32(kodYchitelObject) : 0; 

            string sqltext = $@"SELECT [dbo].[Predmet].*
                    FROM [dbo].[Predmet_Ychitel]
                    INNER JOIN [dbo].[Predmet] ON [dbo].[Predmet_Ychitel].Kod_Predmet = [dbo].[Predmet].Kod_Predmeta
                    WHERE [dbo].[Predmet_Ychitel].Kod_Ychitel = {kodYchitel} AND [dbo].[Predmet].[Del] = 'no' and Predmet_Ychitel.Del = 'no'";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqltext, Database.constr);
            System.Data.DataTable table = new System.Data.DataTable();

            sqlDataAdapter.Fill(table);

            Cb_Predmet_Filter.DataSource = table;
            Cb_Predmet_Filter.DisplayMember = "Nazvanie";
            Cb_Predmet_Filter.ValueMember = "Kod_Predmeta";
        }

        private void LoadDataToDataGridView()
        {
            DataRow currentUser = CORE.Database.GetCurrentUser(parentForm.name_user, userPassword);

            object kodYchitelObject = currentUser["Kod_Ycitel"];
            int kodYchitel = kodYchitelObject != DBNull.Value ? Convert.ToInt32(kodYchitelObject) : 0;

            if (string.IsNullOrEmpty(Cb_Predmet_Filter.SelectedValue?.ToString()) || string.IsNullOrEmpty(Cb_Klass.SelectedValue?.ToString()))
            {
                return;
            }

            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            string sqltext = $@"SELECT [Kod_Otcenki], CONCAT([Ychenik].[Famile], ' ', [Ychenik].[Ima], ' ', [Ychenik].[Otch]) AS 'ФИО',
[Otcenki].[Otmetka] as 'Оценка', [Pocesaemoct] as 'Посещаемость', [Otcenki].[Data_Victavlenie] as 'Дата выставления',
Prichina_Otcytv as 'Причина отсутствие', Premicanie as 'Примечание',[Classes].[Kod_klass] AS 'Kod_klass'
FROM [dbo].[Otcenki]
INNER JOIN [dbo].[Ychenik] ON [dbo].[Otcenki].[Kod_Ycenika] = [dbo].[Ychenik].[Kod_Ychenik]
INNER JOIN [dbo].[Classes] ON [dbo].[Ychenik].[Kod_Klassa] = [dbo].[Classes].Kod_klass
INNER JOIN [dbo].[Predmet] ON [dbo].[Otcenki].[Kod_Predmeta] = [dbo].[Predmet].[Kod_Predmeta]
WHERE Classes.Kod_klass = {Cb_Klass.SelectedValue}
AND [dbo].[Otcenki].[Kod_Predmeta] = {Cb_Predmet_Filter.SelectedValue}
AND [dbo].[Otcenki].[Kod_Ychitel] = {kodYchitel}
AND [Otcenki].Del = 'no'
AND [Otcenki].[Data_Victavlenie] BETWEEN '{startDate.ToString("yyyy-MM-dd")}' AND '{endDate.ToString("yyyy-MM-dd")}'";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqltext, Database.constr);
            System.Data.DataTable table = new System.Data.DataTable();
            sqlDataAdapter.Fill(table);

            dataGridView.DataSource = table;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[7].Visible = false;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }
        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {

                int selectedClass = Convert.ToInt32(dataGridView.CurrentRow.Cells["Kod_klass"].Value);
                string selectedYchenik = dataGridView.CurrentRow.Cells["ФИО"].Value.ToString();
                string selected = dataGridView.CurrentRow.Cells["Посещаемость"].Value.ToString();
                string selectedOtmetka = dataGridView.CurrentRow.Cells["Оценка"].Value.ToString();
                string selectedprimesanie = dataGridView.CurrentRow.Cells["Причина отсутствие"].Value.ToString();
                string selectedprimechan = dataGridView.CurrentRow.Cells["Примечание"].Value.ToString();
                DateTime selectedDate = Convert.ToDateTime(dataGridView.CurrentRow.Cells["Дата выставления"].Value);

                Cb_Classs.SelectedValue = selectedClass;

                FilterStudentsByClass(selectedClass);

                Cb_Ychenik.Text = selectedYchenik;
                Cb_Otmetka.Text = selectedOtmetka;
                Dt_Date.Value = selectedDate;
                Cb_Pricyt.Text = selected;
                Cb_Prichina.Text = selectedprimesanie;
                Tx_Primechanie.Text = selectedprimechan;
        }
        public void Delete_Otmetka()
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление записи", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    string sql = @"UPDATE [Otcenki] SET [Otcenki].[Del] = 'yes' WHERE Kod_Otcenki = @Kod_Otcenki";

                    using (SqlCommand cmd = new SqlCommand(sql, Database.con))
                    {
                        cmd.Parameters.AddWithValue("@Kod_Otcenki", dataGridView.CurrentRow.Cells[0].Value);
                        Database.Open();

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Запись удалена");
                        }
                        else
                        {
                            MessageBox.Show("Запись не удалена");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при удалении записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Database.con.Close();
                }
            }
        }


        private void Bt_otchet_Click(object sender, EventArgs e)
        {
            Otchet();
        }
        public void Otchet()
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для создания отчета.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application
            {
                Visible = true
            };
            Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];

            sheet1.Name = "Отчёт";

            int startColumn = 1;
            int endColumn = dataGridView.Columns.Count - 2;

            for (int j = startColumn; j <= endColumn; j++)
            {
                Range headerRange = (Range)sheet1.Cells[3, j];
                headerRange.Value = dataGridView.Columns[j].HeaderText.ToString();
                SetCellStyleWithBorders(headerRange);
            }

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = startColumn; j <= endColumn; j++)
                {
                    Range cellRange = (Range)sheet1.Cells[i + 4, j];
                    object cellValue = dataGridView[j, i].Value;

                    // Проверяем, является ли значение ячейки датой
                    if (dataGridView.Columns[j].HeaderText.ToString() == "Дата выставления" && cellValue is DateTime dateValue)
                    {
                        // Форматируем дату в строку "дд.MM.гггг"
                        cellRange.Value = dateValue.ToString("dd.MM.yyyy");
                    }
                    else
                    {
                        cellRange.Value = cellValue?.ToString() ?? "";
                    }

                    SetCellStyleWithBorders(cellRange);
                }
            }

            int rowCount = dataGridView.Rows.Count;
            sheet1.Cells[rowCount + 7, 5] = "Дата создания отчета: " + DateTime.Now.Date.ToString("dd.MM.yyyy");
            Range dateRange = sheet1.Range[sheet1.Cells[rowCount + 7, 5], sheet1.Cells[rowCount + 7, 5]];
            SetCellStyleWithBorders(dateRange, false);
            dateRange.Font.Bold = true; // Устанавливаем жирный шрифт

            for (int j = startColumn; j <= endColumn; j++)
            {
                sheet1.Columns[j].AutoFit();
            }

            // Добавляем надпись перед таблицей
            string headerText = "Ведомость успеваемости и посещаемости учеников " + Cb_Klass.Text + " по предмету " + Cb_Predmet_Filter.Text + " за период с " + dateTimePicker1.Text + " по " + dateTimePicker2.Text;
            Range headerRangeText = sheet1.Cells[1, 1];
            headerRangeText.Value = headerText;
            headerRangeText.Font.Size = 16;

            headerRangeText.Font.Bold = true;
            headerRangeText.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            Range headerRangeToMerge = sheet1.Range[sheet1.Cells[1, 1], sheet1.Cells[1, 12]]; // От A1 до L1
            headerRangeToMerge.Merge();
            headerRangeToMerge.WrapText = true; // Включаем перенос текста
            headerRangeToMerge.EntireRow.AutoFit(); // Автоматическое расширение строки по содержимому

            // Добавляем ФИО учителя внизу таблицы
            string teacherName = GetTeacherName(); // Функция для получения ФИО учителя
            sheet1.Cells[rowCount + 7, 1] = "Учитель: " + teacherName;
            Range teacherNameRange = sheet1.Range[sheet1.Cells[rowCount + 7, 1], sheet1.Cells[rowCount + 7, 1]];
            SetCellStyleWithBorders(teacherNameRange, false);
            teacherNameRange.Font.Bold = true; // Устанавливаем жирный шрифт
        }


        private string GetTeacherName()
        {
            // Получение текущего пользователя и ФИО учителя
            DataRow currentUser = CORE.Database.GetCurrentUser(parentForm.name_user, userPassword);
            // Получаем фамилию и имя преподавателя из currentUser
            string teacherSurname = currentUser["TeacherFamile"].ToString();
            string teacherName = currentUser["TeacherIma"].ToString();

            // Объединяем фамилию и имя в одну строку
            string fullName = $"{teacherSurname} {teacherName}";
            return fullName; // Здесь нужно вернуть fullName, а не teacherName
        }

        private void SetCellStyleWithBorders(Range range, bool setBold = true)
        {
            // Ваш код для установки стиля и границ ячеек
            if (setBold)
            {
                range.Font.Bold = true;
            }
            range.Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            range.Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            range.Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            range.Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
        }

        private void Tx_Primechanie_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли нажатая клавиша символом или управляющей клавишей (например, Backspace)
            if (!char.IsControl(e.KeyChar) && Tx_Primechanie.Text.Length >= 60)
            {
                // Если длина текста достигла максимальной длины (25 символов), и нажата не управляющая клавиша,
                // то запрещаем дальнейший ввод символов
                e.Handled = true;
            }
        }
    }
}