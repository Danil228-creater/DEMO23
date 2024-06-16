using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom_Moiceeva.Windows
{
    public partial class Main : Form
    {
        private Avtorizacia parentForm;
        public Main(Avtorizacia parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            // Устанавливаем изображение в PictureBox
            if (parentForm?.UserAvatarBytes != null && parentForm.UserAvatarBytes.Length > 0)
            {
                using (var ms = new MemoryStream(parentForm.UserAvatarBytes))
                {
                    //Avatar.Image = Image.FromStream(ms);
                }
            }
        }
    }
}
