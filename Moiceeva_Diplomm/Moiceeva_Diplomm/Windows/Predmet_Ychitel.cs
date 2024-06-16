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
    public partial class Predmet_Ychitel : Form
    {
        public Predmet_Ychitel()
        {
            InitializeComponent();
            Dt_Ychitel(); Load_Predmet(); Load_Ychitel();
            Bt_Insert.Click += (s, a) => Insert_Pred_Ychitel();
            Bt_Update.Click += (s, a) => Update_Pred();
            Bt_Delete.Click += (s, a) => Delete_Predmet();
            Cb_Pred.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Ychitel.DropDownStyle = ComboBoxStyle.DropDownList;
            Dt_Predmet.ReadOnly = true;
        }
        public void Dt_Ychitel()
        {
            string sqlQuery = @"SELECT 
    CONCAT([Famile], ' ', [Ima], ' ', [Otch]) as 'ФИО', 
    [Nazvanie] as 'Название предмета',[Kod_Pred_Ych]
FROM 
    [dbo].[Ycitel],
    [dbo].[Predmet],
    [dbo].[Predmet_Ychitel] 
WHERE 
    [Kod_Ychitel] = [Kod_Ycitel] 
    AND [dbo].[Predmet].Kod_Predmeta = [Kod_Predmet] 
    AND [dbo].[Predmet].Del = 'no' 
    AND [dbo].[Ycitel].Del = 'no'
	AND [dbo].[Predmet_Ychitel].[Del] = 'no';";

            Dt_Predmet.DataSource = CORE.Database.Query(sqlQuery);
            Dt_Predmet.Columns[2].Visible = false;
            Dt_Predmet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Dt_Predmet.AutoResizeColumns();
            Dt_Predmet.DefaultCellStyle.ForeColor = Color.Black;
        }
        private void Load_Predmet()
        {
            String sqltext = "select * from  [dbo].[Predmet] where [Del] = 'no'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqltext, Database.constr);
            DataTable table = new System.Data.DataTable();

            sqlDataAdapter.Fill(table);

            Cb_Pred.DataSource = table;
            Cb_Pred.DisplayMember = "Nazvanie";
            Cb_Pred.ValueMember = "Kod_Predmeta";

        }
        private void Load_Ychitel()
        {
            String sqltext = "SELECT CONCAT([Famile], ' ', [Ima], ' ', [Otch]) as 'ФИО',Kod_Ycitel FROM [dbo].[Ycitel] WHERE DEL = 'no'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqltext, Database.constr);
            DataTable table = new System.Data.DataTable();

            sqlDataAdapter.Fill(table);

            Cb_Ychitel.DataSource = table;
            Cb_Ychitel.DisplayMember = "ФИО";
            Cb_Ychitel.ValueMember = "Kod_Ycitel";

        }
        public void Insert_Pred_Ychitel()
        {
            string sql = @"INSERT INTO [dbo].[Predmet_Ychitel] (Kod_Ychitel,Kod_Predmet)
                VALUES (@Kod_Ychitel,@Kod_Predmet)";

            SqlCommand cmd = new SqlCommand(sql, Database.con);

            cmd.Parameters.AddWithValue("@Kod_Ychitel", Cb_Ychitel.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@Kod_Predmet", Cb_Pred.SelectedValue.ToString());


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
        public void Update_Pred()
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
                    string sql = $@"UPDATE [dbo].[Predmet_Ychitel] SET 
                        Kod_Ychitel ='{Cb_Ychitel.SelectedValue}',
                        Kod_Predmet ='{Cb_Pred.SelectedValue}'
                        where Kod_Pred_Ych = " + Dt_Predmet.CurrentRow.Cells[2].Value;


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

        private void Dt_Predmet_DoubleClick(object sender, EventArgs e)
        {
            Cb_Ychitel.Text = Dt_Predmet.CurrentRow.Cells[0].Value.ToString();
            Cb_Pred.Text = Dt_Predmet.CurrentRow.Cells[1].Value.ToString();
        }
        public void Delete_Predmet()
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление записей", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    string sql = @"UPDATE Predmet_Ychitel SET Predmet_Ychitel.Del = 'yes' WHERE Kod_Pred_Ych = @Kod_Pred_Ych";

                    using (SqlCommand cmd = new SqlCommand(sql, Database.con))
                    {
                        cmd.Parameters.AddWithValue("@Kod_Pred_Ych", Dt_Predmet.CurrentRow.Cells[2].Value);
                        Database.Open();

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

    }
}
