namespace Moiceeva_Diplomm.Control
{
    partial class User_Uchenik
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Bt_Dolwot_danie = new System.Windows.Forms.Button();
            this.Bt_Otchet = new System.Windows.Forms.Button();
            this.Dt_User = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_User)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(280, 28);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(16, 124);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(280, 28);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dt_User);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Bt_Dolwot_danie);
            this.groupBox1.Controls.Add(this.Bt_Otchet);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(18, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1326, 715);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отчет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 22);
            this.label2.TabIndex = 41;
            this.label2.Text = "Выбирите период";
            // 
            // Bt_Dolwot_danie
            // 
            this.Bt_Dolwot_danie.Location = new System.Drawing.Point(324, 70);
            this.Bt_Dolwot_danie.Name = "Bt_Dolwot_danie";
            this.Bt_Dolwot_danie.Size = new System.Drawing.Size(201, 35);
            this.Bt_Dolwot_danie.TabIndex = 38;
            this.Bt_Dolwot_danie.Text = "Загрузить данные";
            this.Bt_Dolwot_danie.UseVisualStyleBackColor = true;
            this.Bt_Dolwot_danie.Click += new System.EventHandler(this.Bt_Dolwot_danie_Click);
            // 
            // Bt_Otchet
            // 
            this.Bt_Otchet.Location = new System.Drawing.Point(324, 123);
            this.Bt_Otchet.Name = "Bt_Otchet";
            this.Bt_Otchet.Size = new System.Drawing.Size(201, 35);
            this.Bt_Otchet.TabIndex = 2;
            this.Bt_Otchet.Text = "Вывести отчет";
            this.Bt_Otchet.UseVisualStyleBackColor = true;
            this.Bt_Otchet.Click += new System.EventHandler(this.Bt_Otchet_Click);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dt_User.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dt_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.Dt_User.Location = new System.Drawing.Point(16, 173);
            this.Dt_User.Name = "Dt_User";
            this.Dt_User.RowHeadersVisible = false;
            this.Dt_User.RowHeadersWidth = 51;
            this.Dt_User.RowTemplate.Height = 40;
            this.Dt_User.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dt_User.Size = new System.Drawing.Size(1304, 509);
            this.Dt_User.TabIndex = 42;
            this.Dt_User.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // User_Uchenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "User_Uchenik";
            this.Size = new System.Drawing.Size(1688, 738);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bt_Otchet;
        private System.Windows.Forms.Button Bt_Dolwot_danie;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuDataGridView Dt_User;
    }
}
