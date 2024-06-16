
namespace Moiceeva_Diplomm.Control
{
    partial class Regestr_Control
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dt_User = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Bt_Delete = new System.Windows.Forms.Button();
            this.Bt_Insert = new System.Windows.Forms.Button();
            this.Bt_Update = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Tx_User_Pasword = new System.Windows.Forms.TextBox();
            this.Cb_Rol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Bt_Avatar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tx_User_Name = new System.Windows.Forms.TextBox();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_User)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Dt_User);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(730, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 738);
            this.panel1.TabIndex = 7;
            // 
            // Dt_User
            // 
            this.Dt_User.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Dt_User.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dt_User.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dt_User.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dt_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dt_User.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dt_User.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dt_User.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dt_User.ColumnHeadersHeight = 40;
            this.Dt_User.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.Dt_User.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Dt_User.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Dt_User.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.Dt_User.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Dt_User.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.Dt_User.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Dt_User.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.Dt_User.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.Dt_User.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Dt_User.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.Dt_User.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.Dt_User.CurrentTheme.Name = null;
            this.Dt_User.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Dt_User.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Dt_User.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Dt_User.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.Dt_User.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dt_User.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dt_User.EnableHeadersVisualStyles = false;
            this.Dt_User.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Dt_User.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.Dt_User.HeaderBgColor = System.Drawing.Color.Empty;
            this.Dt_User.HeaderForeColor = System.Drawing.Color.White;
            this.Dt_User.Location = new System.Drawing.Point(109, 128);
            this.Dt_User.Name = "Dt_User";
            this.Dt_User.RowHeadersVisible = false;
            this.Dt_User.RowHeadersWidth = 51;
            this.Dt_User.RowTemplate.Height = 40;
            this.Dt_User.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dt_User.Size = new System.Drawing.Size(725, 490);
            this.Dt_User.TabIndex = 40;
            this.Dt_User.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.Dt_User.DoubleClick += new System.EventHandler(this.Dt_User_DoubleClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(859, 101);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(99, 548);
            this.flowLayoutPanel1.TabIndex = 39;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 649);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(958, 89);
            this.panel4.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Bt_Delete);
            this.panel3.Controls.Add(this.Bt_Insert);
            this.panel3.Controls.Add(this.Bt_Update);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(958, 101);
            this.panel3.TabIndex = 37;
            // 
            // Bt_Delete
            // 
            this.Bt_Delete.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bt_Delete.Location = new System.Drawing.Point(547, 46);
            this.Bt_Delete.Name = "Bt_Delete";
            this.Bt_Delete.Size = new System.Drawing.Size(241, 44);
            this.Bt_Delete.TabIndex = 24;
            this.Bt_Delete.Text = "Удалить";
            this.Bt_Delete.UseVisualStyleBackColor = true;
            // 
            // Bt_Insert
            // 
            this.Bt_Insert.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bt_Insert.Location = new System.Drawing.Point(109, 46);
            this.Bt_Insert.Name = "Bt_Insert";
            this.Bt_Insert.Size = new System.Drawing.Size(197, 44);
            this.Bt_Insert.TabIndex = 19;
            this.Bt_Insert.Text = "Добавить запись";
            this.Bt_Insert.UseVisualStyleBackColor = true;
            // 
            // Bt_Update
            // 
            this.Bt_Update.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bt_Update.Location = new System.Drawing.Point(312, 46);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(229, 44);
            this.Bt_Update.TabIndex = 23;
            this.Bt_Update.Text = "Изменить запись";
            this.Bt_Update.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Tx_User_Pasword);
            this.panel2.Controls.Add(this.Cb_Rol);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Bt_Avatar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Tx_User_Name);
            this.panel2.Controls.Add(this.Avatar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 738);
            this.panel2.TabIndex = 8;
            // 
            // Tx_User_Pasword
            // 
            this.Tx_User_Pasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Tx_User_Pasword.Location = new System.Drawing.Point(108, 120);
            this.Tx_User_Pasword.Name = "Tx_User_Pasword";
            this.Tx_User_Pasword.Size = new System.Drawing.Size(458, 27);
            this.Tx_User_Pasword.TabIndex = 22;
            // 
            // Cb_Rol
            // 
            this.Cb_Rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Cb_Rol.FormattingEnabled = true;
            this.Cb_Rol.Location = new System.Drawing.Point(108, 183);
            this.Cb_Rol.Name = "Cb_Rol";
            this.Cb_Rol.Size = new System.Drawing.Size(458, 28);
            this.Cb_Rol.TabIndex = 21;
            this.Cb_Rol.TextUpdate += new System.EventHandler(this.Cb_Rol_TextUpdate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(104, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Выберите роль пользователя";
            // 
            // Bt_Avatar
            // 
            this.Bt_Avatar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bt_Avatar.Location = new System.Drawing.Point(244, 596);
            this.Bt_Avatar.Name = "Bt_Avatar";
            this.Bt_Avatar.Size = new System.Drawing.Size(185, 35);
            this.Bt_Avatar.TabIndex = 18;
            this.Bt_Avatar.Text = "Загрузить аватарку";
            this.Bt_Avatar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(104, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Введите пароль пользователя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(104, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Введите имя пользователя";
            // 
            // Tx_User_Name
            // 
            this.Tx_User_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Tx_User_Name.Location = new System.Drawing.Point(108, 55);
            this.Tx_User_Name.Name = "Tx_User_Name";
            this.Tx_User_Name.Size = new System.Drawing.Size(458, 27);
            this.Tx_User_Name.TabIndex = 15;
            // 
            // Avatar
            // 
            this.Avatar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Avatar.ErrorImage = null;
            this.Avatar.Location = new System.Drawing.Point(108, 260);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(458, 317);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar.TabIndex = 14;
            this.Avatar.TabStop = false;
            // 
            // Regestr_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Regestr_Control";
            this.Size = new System.Drawing.Size(1688, 738);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dt_User)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Bt_Delete;
        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.TextBox Tx_User_Pasword;
        private System.Windows.Forms.ComboBox Cb_Rol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bt_Insert;
        private System.Windows.Forms.Button Bt_Avatar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tx_User_Name;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuDataGridView Dt_User;
    }
}
