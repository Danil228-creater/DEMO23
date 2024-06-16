using Microsoft.Office.Interop.Excel;
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

namespace Moiceeva_Diplomm.Control
{
    public partial class User_Uchenik : UserControl
    {
        private readonly Avtorizacia parentForm;
        private readonly string userPassword;
        public User_Uchenik(Avtorizacia parentForm, string userPassword)
        {
            InitializeComponent();
            
            this.parentForm = parentForm;
            this.userPassword = userPassword;
            LoadDataToDataGridView();
            Dt_User.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Dt_User.AutoResizeColumns();
        }
        private void LoadDataToDataGridView()
        {

            DataRow currentUser = CORE.Database.GetCurrentUchenik(parentForm.name_user, userPassword);

            object kodYchitelObject = currentUser["Kod_Ychenik"];
            int KodYcenika = kodYchitelObject != DBNull.Value ? Convert.ToInt32(kodYchitelObject) : 0;

            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            string sqltext = $@"SELECT [Kod_Otcenki],Predmet.Nazvanie as 'Предмет',
 [Otcenki].[Otmetka] as 'Оценка', [Pocesaemoct] as 'Посещаемость', [Otcenki].[Data_Victavlenie] as 'Дата выставления',
 Prichina_Otcytv as 'Причина отсутствие', Premicanie as 'Примечание',[Classes].[Kod_klass] AS 'Kod_klass'
 FROM [dbo].[Otcenki]
 INNER JOIN [dbo].[Ychenik] ON [dbo].[Otcenki].[Kod_Ycenika] = [dbo].[Ychenik].[Kod_Ychenik]
 INNER JOIN [dbo].[Classes] ON [dbo].[Ychenik].[Kod_Klassa] = [dbo].[Classes].Kod_klass
 INNER JOIN [dbo].[Predmet] ON [dbo].[Otcenki].[Kod_Predmeta] = [dbo].[Predmet].[Kod_Predmeta]
 WHERE [dbo].[Otcenki].Kod_Ycenika = {KodYcenika}
 AND [Otcenki].Del = 'no'
 AND [Otcenki].[Data_Victavlenie] BETWEEN '{startDate.ToString("yyyy-MM-dd")}' AND '{endDate.ToString("yyyy-MM-dd")}'";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqltext, Database.constr);
            System.Data.DataTable table = new System.Data.DataTable();
            sqlDataAdapter.Fill(table);

            Dt_User.DataSource = table;
            Dt_User.Columns[0].Visible = false;
            Dt_User.Columns[7].Visible = false;
        }

        private void Bt_Dolwot_danie_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }
        public void Otchet(string studentName, DateTime startDate, DateTime endDate)
        {
            if (Dt_User.Rows.Count == 0)
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

            // Добавляем заголовок
            Range titleRange = (Range)sheet1.Cells[1, 1];
            titleRange.Value = $"Ведомость по успеваемости и посещаемости ученика {studentName} за период с {startDate.ToString("dd.MM.yyyy")} по {endDate.ToString("dd.MM.yyyy")}";
            titleRange.Font.Size = 14;
            titleRange.Font.Bold = false; // Шрифт не жирный
            sheet1.Range[sheet1.Cells[1, 1], sheet1.Cells[1, Dt_User.Columns.Count - 2]].Merge();
            SetCellStyleWithBorders(titleRange, false);

            int startColumn = 1;
            int endColumn = Dt_User.Columns.Count - 2;

            for (int j = startColumn; j <= endColumn; j++)
            {
                Range headerRange = (Range)sheet1.Cells[3, j];
                headerRange.Value = Dt_User.Columns[j].HeaderText.ToString();
                SetCellStyleWithBorders(headerRange);
            }

            for (int i = 0; i < Dt_User.RowCount; i++)
            {
                for (int j = startColumn; j <= endColumn; j++)
                {
                    Range cellRange = (Range)sheet1.Cells[i + 4, j];
                    object cellValue = Dt_User[j, i].Value;

                    // Проверяем, если значение ячейки является датой, то форматируем ее
                    if (Dt_User.Columns[j].HeaderText.ToString() == "Дата выставления" && cellValue is DateTime)
                    {
                        cellRange.Value = ((DateTime)cellValue).ToString("dd.MM.yyyy");
                    }
                    else
                    {
                        cellRange.Value = cellValue?.ToString() ?? "";
                    }

                    SetCellStyleWithBorders(cellRange);
                }
            }

            int rowCount = Dt_User.Rows.Count;
            sheet1.Cells[rowCount + 7, 5] = "Дата создания отчета: " + DateTime.Now.ToString("dd.MM.yyyy");
            Range dateRange = sheet1.Range[sheet1.Cells[rowCount + 7, 5], sheet1.Cells[rowCount + 7, 5]];
            SetCellStyleWithBorders(dateRange, false);

            for (int j = startColumn; j <= endColumn; j++)
            {
                sheet1.Columns[j].AutoFit();
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

        private void Bt_Otchet_Click(object sender, EventArgs e)
        {
            DataRow currentUser = CORE.Database.GetCurrentUchenik(parentForm.name_user, userPassword);
            if (currentUser != null)
            {
                string studentName = $"{currentUser["StudentFamile"]} {currentUser["StudentIma"]}";
                Otchet(studentName, dateTimePicker1.Value, dateTimePicker2.Value);
            }
            else
            {
                MessageBox.Show("Не удалось найти информацию о пользователе.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

