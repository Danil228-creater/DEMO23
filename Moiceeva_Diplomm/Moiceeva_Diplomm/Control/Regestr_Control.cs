using Moiceeva_Diplomm.CORE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moiceeva_Diplomm.Control
{
    public partial class Regestr_Control : UserControl
    {
        public Regestr_Control()
        {           
            InitializeComponent();           
            Bt_Avatar.Click += (s, a) => SelectImage_Click();
            Bt_Insert.Click += (s, a) => Insert_User();
            Bt_Update.Click += (s, a) => Update_User();
            Bt_Delete.Click += (s, a) => Delete_User();
            Dt_Users(); Load_Rol();
           // Dt_User.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
           // Dt_User.AutoResizeColumns();
            Tx_User_Name.MaxLength = 15;
            Tx_User_Pasword.MaxLength = 10;
            Dt_User.ReadOnly = true;
            Cb_Rol.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void Dt_Users()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.constr))
                {
                    connection.Open();
                    string sql = "Select Kod_Usera,Username,Passwordi,Del,Image,Nazvanie from Users,Roli where Del = 'no' and [dbo].[Roli].Kod_roli=[dbo].[Users].Kod_roli";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, connection);
                    DataTable table = new DataTable();
                    sqlDataAdapter.Fill(table);

                    Dt_User.DataSource = table;
                    Dt_User.Columns[0].HeaderText = "Код пользователя";
                    Dt_User.Columns[1].HeaderText = "Имя пользователя";
                    Dt_User.Columns[2].HeaderText = "Пароль";
                    Dt_User.Columns[3].HeaderText = "Дел";
                    Dt_User.Columns[4].HeaderText = "Фотография";
                    Dt_User.Columns[5].HeaderText = "Роль";

                    Dt_User.Columns[0].Visible = false;
                    Dt_User.Columns[3].Visible = false;
                    Dt_User.Columns[4].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Insert_User()
        {
            byte[] imageBytes;

            if (Avatar.Tag != null)
            {
                string filePath = Avatar.Tag.ToString();
                imageBytes = File.ReadAllBytes(filePath);
            }
            else
            {
                // Загрузка изображения по умолчанию из ресурсов
                System.Drawing.Image defaultImage = Properties.Resources.Standart;
                using (MemoryStream ms = new MemoryStream())
                {
                    defaultImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imageBytes = ms.ToArray();
                }
            }

            string sql = @"INSERT INTO Users (Username, Passwordi, Image, Kod_roli) VALUES (@Username, 
            @Passwordi, @Image, @Kod_roli)";

            if (string.IsNullOrWhiteSpace(Tx_User_Name.Text) || string.IsNullOrWhiteSpace(Tx_User_Pasword.Text))
            {
                MessageBox.Show("Не все записи добавлены");
                return;
            }

            DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, Database.con))
                    {
                        cmd.Parameters.AddWithValue("@Username", Tx_User_Name.Text);
                        cmd.Parameters.AddWithValue("@Passwordi", Tx_User_Pasword.Text);
                        cmd.Parameters.AddWithValue("@Image", imageBytes);
                        cmd.Parameters.AddWithValue("@Kod_roli", Cb_Rol.SelectedValue.ToString());

                        Database.con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 1)
                        {
                            MessageBox.Show("Запись добавлена");
                            Dt_Users();
                        }
                        else
                        {
                            MessageBox.Show("Запись не добавлена");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
                finally
                {
                    Database.con.Close();
                }
            }
            else
            {
                MessageBox.Show("Добавление записи отменено");
            }
        }

        private void SelectImage_Click()
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = dlg.FileName;
                    Avatar.Image = new Bitmap(imagePath);
                    // Сохраняем путь к изображению в Tag элемента PictureBox
                    Avatar.Tag = imagePath;
                }
            }
        }
        public void Load_Rol()
        {
            String sqltext = "select * from Roli";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqltext, Database.constr);
            System.Data.DataTable table = new System.Data.DataTable();

            sqlDataAdapter.Fill(table);

            Cb_Rol.DataSource = table;
            Cb_Rol.DisplayMember = "Nazvanie";
            Cb_Rol.ValueMember = "Kod_roli";
        }

        private void Cb_Rol_TextUpdate(object sender, EventArgs e)
        {
            if (!Cb_Rol.Items.Contains(Cb_Rol.Text))
            {
                Cb_Rol.Text = "";
                MessageBox.Show("Пожалуйста, выберите значение из списка.");
            }
        }

        private void Dt_User_DoubleClick(object sender, EventArgs e)
        {
            Tx_User_Name.Text = Dt_User.CurrentRow.Cells[1].Value.ToString();
            Tx_User_Pasword.Text = Dt_User.CurrentRow.Cells[2].Value.ToString();
            Cb_Rol.Text = Dt_User.CurrentRow.Cells[5].Value.ToString();

            if (Dt_User.CurrentRow.Cells[4].Value != DBNull.Value)
            {
                byte[] imageData = (byte[])Dt_User.CurrentRow.Cells[4].Value;

                // Конвертация бинарных данных в изображение и отображение в PictureBox
                if (imageData != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Avatar.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Если ячейка содержит NULL, оставляем текущую фотографию (например, изображение по умолчанию)
                    Avatar.Image = Image.FromFile("C:/Users/beloc/source/repos/Moiceeva_Diplomm/Moiceeva_Diplomm/Resources/Енот.png");
                }
            }
            else
            {
                // Если ячейка не содержит данных, загружаем изображение по умолчанию
                Avatar.Image = Image.FromFile("C:/Users/beloc/source/repos/Moiceeva_Diplomm/Moiceeva_Diplomm/Resources/Енот.png");
            }
        }
        public void Update_User()
        {
            // Check if textboxes are not empty
            if (string.IsNullOrEmpty(Tx_User_Name.Text) || string.IsNullOrEmpty(Tx_User_Pasword.Text))
            {
                MessageBox.Show("Введите имя пользователя и пароль");
                return;
            }

            // Confirmation dialog
            DialogResult result = MessageBox.Show("Вы уверены, что хотите обновить запись?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return; // User chose not to update
            }

            string sql = @"UPDATE Users SET 
        Username = @Username, 
        Passwordi = @Passwordi,
        Kod_roli = @Kod_roli,
        Image = @Image
        WHERE Kod_Usera = @Kod_Usera";

            SqlCommand cmd = new SqlCommand(sql, Database.con);

            // Задание параметров запроса
            cmd.Parameters.AddWithValue("@Username", Tx_User_Name.Text);
            cmd.Parameters.AddWithValue("@Passwordi", Tx_User_Pasword.Text);
            cmd.Parameters.AddWithValue("@Kod_roli", Cb_Rol.SelectedValue.ToString());

            if (Avatar.Tag != null)
            {
                // Создаем копию изображения из PictureBox
                Image copiedImage = new Bitmap(Avatar.Image);

                // Конвертируем изображение в байты
                byte[] imageBytes = ImageToByteArray(copiedImage);
                cmd.Parameters.Add("@Image", SqlDbType.VarBinary, -1).Value = imageBytes;
            }
            else
            {
                // Получение текущего изображения из PictureBox
                Image currentImage = Avatar.Image;

                // Если есть текущее изображение, создаем копию и конвертируем его в байты
                if (currentImage != null)
                {
                    Image copiedImage = new Bitmap(currentImage);
                    byte[] imageBytes = ImageToByteArray(copiedImage);
                    cmd.Parameters.Add("@Image", SqlDbType.VarBinary, -1).Value = imageBytes;
                }
                else
                {
                    // Если текущего изображения нет, сохраняем NULL в базу данных
                    cmd.Parameters.Add("@Image", SqlDbType.VarBinary, -1).Value = DBNull.Value;
                }
            }

            cmd.Parameters.AddWithValue("@Kod_Usera", Dt_User.CurrentRow.Cells[0].Value);

            Database.Open();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Запись обновлена");
                Database.con.Close();
                Dt_Users();
            }
            else
            {
                MessageBox.Show("Запись не обновлена");
            }
        }

        // Метод для конвертации изображения в байты
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public void Delete_User()
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление записей", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    string sql = @"UPDATE Users SET Users.del = 'yes' WHERE Kod_Usera = @Kod_Usera";

                    using (SqlCommand cmd = new SqlCommand(sql, Database.con))
                    {
                        cmd.Parameters.AddWithValue("@Kod_Usera", Dt_User.CurrentRow.Cells[0].Value);
                        Database.Open();

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Запись удалена");
                            Dt_Users();
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
