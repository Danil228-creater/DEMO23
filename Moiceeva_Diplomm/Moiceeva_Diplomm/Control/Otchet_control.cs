using Microsoft.Office.Interop.Excel;
using Moiceeva_Diplomm.CORE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;

namespace Moiceeva_Diplomm.Control
{
    public partial class Otchet_control : UserControl
    {
        public Otchet_control()
        {
            InitializeComponent(); Load_Klass(); Load_Klassi();
            bt_Otchet_Ycheniki.Click += (s, a) => Otchet();
            Bt_Otchet_Uchenik.Click += (s, a) => Otchet_Ychenik();
            Cb_Classi.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Klass.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Uchenik.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Load_Klass()
        {
            string sqlQuery = @"select Kod_klass,ClassName as 'Название класса',Del from [dbo].[Classes] where Del = 'no'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, Database.constr);
            System.Data.DataTable table = new System.Data.DataTable();

            sqlDataAdapter.Fill(table);

            Cb_Klass.DataSource = table;
            Cb_Klass.DisplayMember = "Название класса";
            Cb_Klass.ValueMember = "Kod_klass";
        }

        private void Otchet()
        {
            // Получение выбранного класса и его названия из ComboBox
            string selectedClass = Cb_Klass.SelectedValue.ToString();
            string className = Cb_Klass.Text;

            // Запрос SQL для получения данных из базы данных с учетом выбранного класса
            string sqlQuery = $@"
SELECT CONCAT([Ychenik].[Famile], ' ', [Ychenik].[Ima], ' ', [Ychenik].[Otch]) AS 'ФИО'
FROM [dbo].[Ychenik]
WHERE [Kod_Klassa] = {selectedClass}
AND [Del] = 'no'
ORDER BY [Ychenik].[Famile]";
            ;

            // Создание подключения и выполнение запроса
            using (SqlConnection connection = new SqlConnection(Database.constr))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Открытие подключения
                    connection.Open();

                    // Создание адаптера данных
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    // Заполнение DataTable данными из базы данных
                    adapter.Fill(dataTable);

                    // Создание объектов Excel
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    Workbook workbook = excel.Workbooks.Add();
                    Worksheet sheet1 = (Worksheet)workbook.Sheets[1];

                    // Установка имени листа
                    sheet1.Name = "Отчёт";

                    // Добавляем надпись перед таблицей
                    Range classListTitleRange = (Range)sheet1.Cells[1, 1];
                    classListTitleRange.Value = $"Список учеников {className} класса";
                    classListTitleRange.Font.Name = "Times New Roman";
                    classListTitleRange.Font.Size = 14;
                    classListTitleRange.Font.Bold = true;
                    classListTitleRange.Font.Color = Color.Black;

                    // Объединяем ячейки для надписи
                    Range classListHeaderRange = sheet1.Range[sheet1.Cells[1, 1], sheet1.Cells[1, 2]];
                    classListHeaderRange.Merge();
                    classListHeaderRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    // Задаем ширину столбца и добавляем рамку для заголовка
                    Range headerRange = (Range)sheet1.Cells[3, 1];
                    headerRange.Value = "ФИО";
                    SetCellStyleWithBorders(headerRange);

                    // Заполнение данных и добавление рамок
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        Range cellRange = (Range)sheet1.Cells[i + 4, 1];
                        cellRange.Value = dataTable.Rows[i]["ФИО"].ToString();
                        SetCellStyleWithBorders(cellRange);
                    }
                    // Получаем текущую дату и время
                    DateTime currentDate = DateTime.Now;

                    // Форматируем дату и время в нужный формат
                    string reportDate = currentDate.ToString("dd.MM.yyyy");

                    // Добавляем дату создания отчета
                    sheet1.Cells[dataTable.Rows.Count + 6, 1] = "Дата создания отчета: " + reportDate;
                    Range reportDateRange = sheet1.Range[sheet1.Cells[dataTable.Rows.Count + 6, 1], sheet1.Cells[dataTable.Rows.Count + 6, 1]];
                    SetCellStyleWithBorders(reportDateRange, false);
                    reportDateRange.Font.Bold = true;
                    // Автоматическое расширение столбца
                    sheet1.Columns[1].AutoFit();

                    // Отображение Excel
                    excel.Visible = true;

                    // Освобождение ресурсов
                    Marshal.ReleaseComObject(sheet1);
                    Marshal.ReleaseComObject(workbook);
                    Marshal.ReleaseComObject(excel);
                }
            }
        }

        private void SetCellStyleWithBorders(Range cellRange, bool includeBorders = true)
        {
            cellRange.Font.Name = "Times New Roman";
            cellRange.Font.Size = 12;
            cellRange.Font.Color = Color.Black;

            if (includeBorders)
            {
                cellRange.Borders.get_Item(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlContinuous;
                cellRange.Borders.get_Item(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlContinuous;
                cellRange.Borders.get_Item(XlBordersIndex.xlEdgeTop).LineStyle = XlLineStyle.xlContinuous;
                cellRange.Borders.get_Item(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous;
            }
        }

        private void AddBordersForTable(Worksheet sheet, int startColumn, int startRow, int endRow, int columnCount)
        {
            Range tableRange = sheet.Range[sheet.Cells[startRow, startColumn], sheet.Cells[endRow, startColumn + columnCount - 1]];
            tableRange.Borders.get_Item(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlContinuous;
            tableRange.Borders.get_Item(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlContinuous;
            tableRange.Borders.get_Item(XlBordersIndex.xlEdgeTop).LineStyle = XlLineStyle.xlContinuous;
            tableRange.Borders.get_Item(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous;
        }
        public void Load_Klassi()
        {
            String sqltext = "select * from Classes where Del = 'no'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqltext, Database.constr);
            System.Data.DataTable table = new System.Data.DataTable();

            sqlDataAdapter.Fill(table);

            Cb_Classi.DataSource = table;
            Cb_Classi.DisplayMember = "ClassName";
            Cb_Classi.ValueMember = "Kod_klass";
        }
        private void FilterStudentsByClass(int selectedClass)
        {

            if (Cb_Uchenik.SelectedValue != null)
            {

                int selectedStudent = Convert.ToInt32(Cb_Uchenik.SelectedValue);
                string sqltext = $"SELECT Kod_Klassa FROM Ychenik WHERE Kod_Ychenik = {selectedStudent}";
                System.Data.DataTable classTable = new System.Data.DataTable();
                CORE.Database.ExecuteSqlCommand(sqltext, classTable);

                if (classTable.Rows.Count > 0)
                {
                    int studentClass = Convert.ToInt32(classTable.Rows[0]["Kod_Klassa"]);


                    if (studentClass != selectedClass)
                    {
                        Cb_Classi.SelectedValue = studentClass;
                    }
                }
            }


            string filterStudentsQuery = $@"
 SELECT Kod_Ychenik, CONCAT([Ychenik].[Famile], ' ', [Ychenik].[Ima], ' ', [Ychenik].[Otch]) as 'ФИО' FROM Ychenik
 WHERE Kod_Klassa = {selectedClass} and Del = 'no'";

            System.Data.DataTable studentsTable = new System.Data.DataTable();
            CORE.Database.ExecuteSqlCommand(filterStudentsQuery, studentsTable);

            Cb_Uchenik.DataSource = studentsTable;
            Cb_Uchenik.DisplayMember = "ФИО";
            Cb_Uchenik.ValueMember = "Kod_Ychenik";
        }

        private void Cb_Classi_SelectedIndexChanged(object sender, EventArgs e)
        {

            Cb_Uchenik.DataSource = null;

            string selectedClassStr = Cb_Classi.SelectedValue?.ToString();

            if (int.TryParse(selectedClassStr, out int selectedClass))
            {
                FilterStudentsByClass(selectedClass);
            }
        }
        private void Otchet_Ychenik()
        {
            if (Cb_Uchenik.SelectedValue == null)
            {
                MessageBox.Show("Нет данных для создания отчета.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedStudent = Cb_Uchenik.SelectedValue.ToString();
            string studentName = Cb_Uchenik.Text;
            string selectedClass = Cb_Klass.Text;

            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            string sqlQuery = $@"
    SELECT 
        [Predmet].[Nazvanie] AS 'Предмет',
        [Otcenki].[Otmetka] AS 'Оценка',
        [Otcenki].[Data_Victavlenie] AS 'Дата выставления'
    FROM 
        [Predmet]
    LEFT JOIN
        [Otcenki] ON [Predmet].[Kod_Predmeta] = [Otcenki].[Kod_Predmeta]
    WHERE
        [Otcenki].[Kod_Ycenika] = {selectedStudent} AND [Otcenki].[Del] = 'no' AND
        [Otcenki].[Data_Victavlenie] BETWEEN '{startDate.ToString("yyyy-MM-dd")}' AND '{endDate.ToString("yyyy-MM-dd")}'";

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = excel.Workbooks.Add();
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];

            sheet1.Name = "Отчет";

            int startRow = 4; // Изменяем начало таблицы на четвертую строку

            // Убираем пустую строку между заголовком и таблицей
            startRow--;

            int startColumn = 1;

            using (SqlConnection connection = new SqlConnection(Database.constr))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    int rowCount = dataTable.Rows.Count;
                    int columnCount = dataTable.Columns.Count;

                    if (rowCount == 0 || columnCount == 0)
                    {
                        MessageBox.Show("Нет данных для отображения в таблице.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    object[,] dataArray = new object[rowCount, columnCount];

                    for (int i = 0; i < rowCount; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {
                            dataArray[i, j] = dataTable.Rows[i][j];
                        }
                    }

                    // Устанавливаем рамку для столбцов "Предмет", "Оценка" и "Дата выставления"
                    Range headerRange = sheet1.Range[sheet1.Cells[startRow - 1, startColumn], sheet1.Cells[startRow - 1, startColumn + 2]];
                    headerRange.Borders.LineStyle = XlLineStyle.xlContinuous;

                    Range topLeftCell = sheet1.Cells[startRow, startColumn];
                    Range bottomRightCell = sheet1.Cells[startRow + rowCount - 1, startColumn + columnCount - 1];
                    Range tableRange = sheet1.Range[topLeftCell, bottomRightCell];

                    tableRange.Value = dataArray;

                    tableRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                    tableRange.Font.Name = "Times New Roman";
                    tableRange.Font.Size = 12;

                    Range dateColumn = (Range)sheet1.Columns[startColumn + 2];
                    dateColumn.NumberFormat = "dd MMMM";

                    sheet1.Cells[startRow - 1, startColumn].Value = "Предмет";
                    sheet1.Cells[startRow - 1, startColumn + 1].Value = "Оценка";
                    sheet1.Cells[startRow - 1, startColumn + 2].Value = "Дата выставления";

                    Range headerCell = sheet1.Cells[1, 10];
                    headerCell.Value = "Ведомость успеваемости ученика " + studentName + " " + selectedClass + " класса, за период с " + startDate.ToString("dd.MM.yyyy") + " по " + endDate.ToString("dd.MM.yyyy");
                    headerCell.Font.Bold = true;
                    headerCell.Font.Size = 16;
                    headerCell.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    // Увеличиваем отступ после заголовка
                    headerCell.Offset[2, 0].RowHeight = 30;

                    Range infoRange = sheet1.Range[sheet1.Cells[startRow - 2, startColumn + columnCount + 2], sheet1.Cells[startRow - 1, startColumn + columnCount + 3]];
                    infoRange.Font.Name = "Times New Roman";
                    infoRange.Font.Size = 12;

                    tableRange.Columns.AutoFit();

                    for (int j = 0; j < columnCount; j++)
                    {
                        Range columnRange = sheet1.Columns[startColumn + j];
                        columnRange.Columns.AutoFit();
                        columnRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    }
                    // Добавляем строку после таблицы
                    int endRow = startRow + rowCount + 1;
                    sheet1.Cells[endRow, startColumn].Value = "Средние оценки по предметам:";

                    // Настройка форматирования для ячейки с текстом "Средние оценки по предметам:"
                    Range averageHeaderCell = sheet1.Cells[endRow, startColumn];
                    averageHeaderCell.Font.Name = "Times New Roman";
                    averageHeaderCell.Font.Size = 12;
                    averageHeaderCell.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    averageHeaderCell.EntireColumn.AutoFit(); // Автоматическая подгонка ширины столбца

                    // Получаем уникальные предметы из таблицы
                    var uniquePredmets = dataTable.AsEnumerable()
                        .Select(row => row.Field<string>("Предмет"))
                        .Distinct();

                    int currentRow = endRow + 1;

                    foreach (var predmet in uniquePredmets)
                    {
                        // Выбираем строки таблицы, относящиеся к текущему предмету
                        var rowsForPredmet = dataTable.AsEnumerable()
                            .Where(row => row.Field<string>("Предмет") == predmet && row["Оценка"] != DBNull.Value);

                        // Проверяем, есть ли значения оценок для данного предмета
                        if (rowsForPredmet.Any())
                        {
                            // Вычисляем среднюю оценку для текущего предмета
                            double sum = 0;
                            int count = 0;
                            foreach (var row in rowsForPredmet)
                            {
                                if (double.TryParse(row["Оценка"].ToString(), out double value))
                                {
                                    sum += value;
                                    count++;
                                }
                            }
                            if (count > 0)
                            {
                                double avgOcenka = sum / count;
                                // Округляем среднюю оценку до двух знаков после запятой
                                avgOcenka = Math.Round(avgOcenka, 2);

                                // Выводим название предмета и среднюю оценку в таблицу
                                sheet1.Cells[currentRow, startColumn].Value = predmet;
                                sheet1.Cells[currentRow, startColumn + 1].Value = avgOcenka;

                                // Устанавливаем шрифт и размер для ячеек средних оценок
                                sheet1.Cells[currentRow, startColumn].Font.Name = "Times New Roman";
                                sheet1.Cells[currentRow, startColumn].Font.Size = 12;
                                sheet1.Cells[currentRow, startColumn + 1].Font.Name = "Times New Roman";
                                sheet1.Cells[currentRow, startColumn + 1].Font.Size = 12;

                                currentRow++;
                            }
                        }
                    }
                    // Устанавливаем рамку для ячеек с таблицей средних оценок
                    Range avgTableRange = sheet1.Range[sheet1.Cells[endRow, startColumn], sheet1.Cells[currentRow - 1, startColumn + 1]];
                    avgTableRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                    // Устанавливаем шрифт и размер шрифта для всех ячеек
                    sheet1.Range[sheet1.Cells[startRow - 1, startColumn], sheet1.Cells[endRow + currentRow - 1, startColumn + columnCount - 1]].Font.Name = "Times New Roman";
                    sheet1.Range[sheet1.Cells[startRow - 1, startColumn], sheet1.Cells[endRow + currentRow - 1, startColumn + columnCount - 1]].Font.Size = 12;
                    // Устанавливаем ширину столбца "Предмет" и "Оценка" в таблице средних оценок
                    sheet1.Columns[startColumn].AutoFit();
                    sheet1.Columns[startColumn + 1].AutoFit();
                }
            }
            excel.Visible = true;
            Marshal.ReleaseComObject(sheet1);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(excel);    
    }
    private void SetCellStyleWithBorders1(Range cellRange, bool includeBorders = true)
        {
            cellRange.Font.Name = "Times New Roman";
            cellRange.Font.Size = 12;
            cellRange.Font.Color = Color.Black;

            if (includeBorders)
            {
                cellRange.Borders.get_Item(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlContinuous;
                cellRange.Borders.get_Item(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlContinuous;
                cellRange.Borders.get_Item(XlBordersIndex.xlEdgeTop).LineStyle = XlLineStyle.xlContinuous;
                cellRange.Borders.get_Item(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous;
            }
        }

    }
}
