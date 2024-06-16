using Moiceeva_Diplomm.Classes;
using Moiceeva_Diplomm.Control;
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

namespace Moiceeva_Diplomm.Windows
{
    public partial class Main : Form
    {
        private readonly Avtorizacia parentForm;

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PanelConteiner.Controls.Clear();
            PanelConteiner.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public void Klient_bt()
        {
            Glavna_Ctranica glavna_Ctranica = new Glavna_Ctranica();
            AddUserControl(glavna_Ctranica);
        }
        public void User_Reg_bt()
        {
            Regestr_Control regestr_Control = new Regestr_Control();
            AddUserControl(regestr_Control);
        }
        public void Ychenik_Create()
        {
            Yceniki yceniki = new Yceniki();
            AddUserControl(yceniki);
        }
        public void Ychitel_Create()
        {
            
            Ychitel ychitel = new Ychitel();
            AddUserControl(ychitel);
        }
        public void Attest_Create()
        {
            Control_attest control_attest = new Control_attest(parentForm, parentForm.GetUserPassword());
            AddUserControl(control_attest);
        }
        public void Otchet_Create()
        {
            Otchet_control otchet_control = new Otchet_control();
            AddUserControl(otchet_control);
        }
        public void Otchet_Create_Uchenik()
        {
            User_Uchenik user_Uchenik = new User_Uchenik(parentForm, parentForm.GetUserPassword());
            AddUserControl(user_Uchenik);
        }
        public Main(Avtorizacia parentForm, string userPassword)
        {          
            InitializeComponent();
            this.MinimumSize = this.MaximumSize = new Size(1200, 700);
            this.parentForm = parentForm;

            // Устанавливаем изображение в PictureBox
            if (parentForm?.UserAvatarBytes != null && parentForm.UserAvatarBytes.Length > 0)
            {
                using (var ms = new MemoryStream(parentForm.UserAvatarBytes))
                {
                    Avatar.Image = Image.FromStream(ms);
                }
            }

            // Получаем текущего пользователя
            DataRow currentUser = CORE.Database.GetCurrentUser(parentForm.name_user, userPassword);

            if (currentUser != null)
            {
                int role = Convert.ToInt32(currentUser["Kod_roli"]);

                // Открываем нужное окно в зависимости от роли пользователя
                if (role == 4) // Администратор
                {
                    User_Reg_bt();
                }
                else if (role == 1) // Учитель
                {
                    Otchet_Create();
                }
                else if (role == 3) // Ученик
                {
                    Otchet_Create_Uchenik();
                }
            }

            // Привязываем события к кнопкам
            Bt_Create_User.Click += (s, a) => User_Reg_bt();
            Bt_Insert_Ychenik.Click += (s, a) => Ychenik_Create();
            Bt_Ychitel.Click += (s, a) => Ychitel_Create();
            Bt_Attect.Click += (s, a) => Attest_Create();
            Bt_Otchet.Click += (s, a) => Otchet_Create();
            Bt_Att_Uchenik.Click += (s, a) => Otchet_Create_Uchenik();

            SeeAdmin(userPassword);

            this.FormClosing += Main_FormClosing;
        }
        public string name_user;
        private void SeeAdmin(string userPassword)
        {
            DataRow currentUser = CORE.Database.GetCurrentUser(parentForm.name_user, userPassword); // Используем переданный пароль

            if (currentUser != null)
            {
                string teacherFamile = currentUser["TeacherFamile"] as string;
                string teacherIma = currentUser["TeacherIma"] as string;
                string studentFamile = currentUser["StudentFamile"] as string;
                string studentIma = currentUser["StudentIma"] as string;
                int role = Convert.ToInt32(currentUser["Kod_roli"]);

                // Установите имя и фамилию в Lb_User_Name
                if (role == 4)
                {
                    Lb_User_Name.Text = "Администратор";
                }
                else
                {
                    Lb_User_Name.Text = $"{teacherFamile} {teacherIma} {studentFamile} {studentIma}";
                }

                // Управление видимостью кнопки в зависимости от роли для ученика

                // Управление видимостью кнопки в зависимости от роли для учителя
                Bt_Attect.Visible = role != 3;
                Bt_Otchet.Visible = role != 3;

                if (role == 3) // Ученик
                {
                    Bt_Create_User.Visible = false;
                    Bt_Insert_Ychenik.Visible = false;
                    Bt_Ychitel.Visible = false;
                    Bt_Att_Uchenik.Visible = true;
                }
                else if (role == 1) // Учитель
                {
                    Bt_Create_User.Visible = false;
                    Bt_Insert_Ychenik.Visible = false;
                    Bt_Ychitel.Visible = false;
                }
                else if (role == 4)
                {
                    Bt_Attect.Visible = false;
                    Bt_Otchet.Visible = false;

                }
            }
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Отменяем стандартное закрытие формы
            e.Cancel = true;

            // Выводим MessageBox с вопросом
            DialogResult result = MessageBox.Show("Хотите выйти из аккаунта?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Если выбрано "Да", закрываем текущее окно и открываем окно авторизации
                this.Hide();
                parentForm.Show();
            }
        }
    }
}
