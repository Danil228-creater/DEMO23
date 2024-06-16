
namespace Moiceeva_Diplomm.Control
{
    partial class Control_attest
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
            this.groupBoxStudent = new System.Windows.Forms.GroupBox();
            this.Cb_Otmetka = new System.Windows.Forms.ComboBox();
            this.Tx_Primechanie = new System.Windows.Forms.TextBox();
            this.Cb_Pricyt = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cb_Prichina = new System.Windows.Forms.ComboBox();
            this.Dt_Date = new System.Windows.Forms.DateTimePicker();
            this.Cb_Predmet = new System.Windows.Forms.ComboBox();
            this.Cb_Ychenik = new System.Windows.Forms.ComboBox();
            this.Cb_Classs = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Bt_otchet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Cb_Klass = new System.Windows.Forms.ComboBox();
            this.Cb_Predmet_Filter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.groupBoxStudent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxStudent
            // 
            this.groupBoxStudent.Controls.Add(this.Cb_Otmetka);
            this.groupBoxStudent.Controls.Add(this.Tx_Primechanie);
            this.groupBoxStudent.Controls.Add(this.Cb_Pricyt);
            this.groupBoxStudent.Controls.Add(this.label12);
            this.groupBoxStudent.Controls.Add(this.label10);
            this.groupBoxStudent.Controls.Add(this.label9);
            this.groupBoxStudent.Controls.Add(this.label8);
            this.groupBoxStudent.Controls.Add(this.label7);
            this.groupBoxStudent.Controls.Add(this.label4);
            this.groupBoxStudent.Controls.Add(this.label3);
            this.groupBoxStudent.Controls.Add(this.label2);
            this.groupBoxStudent.Controls.Add(this.Cb_Prichina);
            this.groupBoxStudent.Controls.Add(this.Dt_Date);
            this.groupBoxStudent.Controls.Add(this.Cb_Predmet);
            this.groupBoxStudent.Controls.Add(this.Cb_Ychenik);
            this.groupBoxStudent.Controls.Add(this.Cb_Classs);
            this.groupBoxStudent.Controls.Add(this.buttonDelete);
            this.groupBoxStudent.Controls.Add(this.buttonEdit);
            this.groupBoxStudent.Controls.Add(this.buttonAdd);
            this.groupBoxStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxStudent.Location = new System.Drawing.Point(15, 4);
            this.groupBoxStudent.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxStudent.Name = "groupBoxStudent";
            this.groupBoxStudent.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxStudent.Size = new System.Drawing.Size(466, 706);
            this.groupBoxStudent.TabIndex = 55;
            this.groupBoxStudent.TabStop = false;
            this.groupBoxStudent.Text = "Отметки";
            // 
            // Cb_Otmetka
            // 
            this.Cb_Otmetka.FormattingEnabled = true;
            this.Cb_Otmetka.Items.AddRange(new object[] {
            "2,00",
            "3,00",
            "4,00",
            "5,00"});
            this.Cb_Otmetka.Location = new System.Drawing.Point(7, 273);
            this.Cb_Otmetka.Name = "Cb_Otmetka";
            this.Cb_Otmetka.Size = new System.Drawing.Size(430, 26);
            this.Cb_Otmetka.TabIndex = 75;
            // 
            // Tx_Primechanie
            // 
            this.Tx_Primechanie.Location = new System.Drawing.Point(7, 518);
            this.Tx_Primechanie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tx_Primechanie.MaxLength = 200;
            this.Tx_Primechanie.Multiline = true;
            this.Tx_Primechanie.Name = "Tx_Primechanie";
            this.Tx_Primechanie.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tx_Primechanie.Size = new System.Drawing.Size(430, 154);
            this.Tx_Primechanie.TabIndex = 74;
            this.Tx_Primechanie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tx_Primechanie_KeyPress);
            // 
            // Cb_Pricyt
            // 
            this.Cb_Pricyt.FormattingEnabled = true;
            this.Cb_Pricyt.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.Cb_Pricyt.Location = new System.Drawing.Point(7, 395);
            this.Cb_Pricyt.Name = "Cb_Pricyt";
            this.Cb_Pricyt.Size = new System.Drawing.Size(430, 26);
            this.Cb_Pricyt.TabIndex = 73;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 486);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 18);
            this.label12.TabIndex = 72;
            this.label12.Text = "Примечанние";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 424);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(244, 18);
            this.label10.TabIndex = 68;
            this.label10.Text = "Выберите причину отсутствия";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 18);
            this.label9.TabIndex = 67;
            this.label9.Text = "Присутствие ученика";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 18);
            this.label8.TabIndex = 66;
            this.label8.Text = "Выберите дату выставления";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 18);
            this.label7.TabIndex = 65;
            this.label7.Text = "Выберите отметку";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 18);
            this.label4.TabIndex = 64;
            this.label4.Text = "Выбирите предмет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 63;
            this.label3.Text = "Выберите ученика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 62;
            this.label2.Text = "Выберите класс";
            // 
            // Cb_Prichina
            // 
            this.Cb_Prichina.FormattingEnabled = true;
            this.Cb_Prichina.Items.AddRange(new object[] {
            "Н",
            "УП",
            "Б",
            "П"});
            this.Cb_Prichina.Location = new System.Drawing.Point(7, 449);
            this.Cb_Prichina.Name = "Cb_Prichina";
            this.Cb_Prichina.Size = new System.Drawing.Size(432, 26);
            this.Cb_Prichina.TabIndex = 61;
            // 
            // Dt_Date
            // 
            this.Dt_Date.Location = new System.Drawing.Point(7, 336);
            this.Dt_Date.Name = "Dt_Date";
            this.Dt_Date.Size = new System.Drawing.Size(432, 24);
            this.Dt_Date.TabIndex = 58;
            // 
            // Cb_Predmet
            // 
            this.Cb_Predmet.FormattingEnabled = true;
            this.Cb_Predmet.Location = new System.Drawing.Point(7, 220);
            this.Cb_Predmet.Name = "Cb_Predmet";
            this.Cb_Predmet.Size = new System.Drawing.Size(433, 26);
            this.Cb_Predmet.TabIndex = 57;
            // 
            // Cb_Ychenik
            // 
            this.Cb_Ychenik.FormattingEnabled = true;
            this.Cb_Ychenik.Location = new System.Drawing.Point(7, 164);
            this.Cb_Ychenik.Name = "Cb_Ychenik";
            this.Cb_Ychenik.Size = new System.Drawing.Size(433, 26);
            this.Cb_Ychenik.TabIndex = 56;
            // 
            // Cb_Classs
            // 
            this.Cb_Classs.FormattingEnabled = true;
            this.Cb_Classs.Location = new System.Drawing.Point(7, 110);
            this.Cb_Classs.Name = "Cb_Classs";
            this.Cb_Classs.Size = new System.Drawing.Size(433, 26);
            this.Cb_Classs.TabIndex = 55;
            this.Cb_Classs.SelectedIndexChanged += new System.EventHandler(this.Cb_Classs_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(294, 43);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(125, 28);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(165, 43);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(121, 28);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(40, 43);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 28);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.Bt_otchet);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Cb_Klass);
            this.groupBox1.Controls.Add(this.Cb_Predmet_Filter);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(488, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1047, 184);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтрация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(209, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 19);
            this.label1.TabIndex = 52;
            this.label1.Text = "Выберите период времени ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(549, 133);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(309, 27);
            this.dateTimePicker2.TabIndex = 51;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(213, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(309, 27);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // Bt_otchet
            // 
            this.Bt_otchet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bt_otchet.Location = new System.Drawing.Point(32, 59);
            this.Bt_otchet.Name = "Bt_otchet";
            this.Bt_otchet.Size = new System.Drawing.Size(124, 34);
            this.Bt_otchet.TabIndex = 49;
            this.Bt_otchet.Text = "Отчет";
            this.Bt_otchet.UseVisualStyleBackColor = true;
            this.Bt_otchet.Click += new System.EventHandler(this.Bt_otchet_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(889, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 34);
            this.button1.TabIndex = 48;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Cb_Klass
            // 
            this.Cb_Klass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cb_Klass.FormattingEnabled = true;
            this.Cb_Klass.Location = new System.Drawing.Point(213, 69);
            this.Cb_Klass.Name = "Cb_Klass";
            this.Cb_Klass.Size = new System.Drawing.Size(309, 24);
            this.Cb_Klass.TabIndex = 47;
            // 
            // Cb_Predmet_Filter
            // 
            this.Cb_Predmet_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cb_Predmet_Filter.FormattingEnabled = true;
            this.Cb_Predmet_Filter.Location = new System.Drawing.Point(549, 69);
            this.Cb_Predmet_Filter.Name = "Cb_Predmet_Filter";
            this.Cb_Predmet_Filter.Size = new System.Drawing.Size(309, 24);
            this.Cb_Predmet_Filter.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(545, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 19);
            this.label6.TabIndex = 45;
            this.label6.Text = "Выберите предмет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(209, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "Выберите класс ";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 40;
            this.dataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView.CurrentTheme.Name = null;
            this.dataGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(489, 206);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 40;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1046, 504);
            this.dataGridView.TabIndex = 57;
            this.dataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridView.DoubleClick += new System.EventHandler(this.DataGridView_DoubleClick);
            // 
            // Control_attest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBoxStudent);
            this.Controls.Add(this.groupBox1);
            this.Name = "Control_attest";
            this.Size = new System.Drawing.Size(1688, 738);
            this.groupBoxStudent.ResumeLayout(false);
            this.groupBoxStudent.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxStudent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cb_Prichina;
        private System.Windows.Forms.DateTimePicker Dt_Date;
        private System.Windows.Forms.ComboBox Cb_Predmet;
        private System.Windows.Forms.ComboBox Cb_Ychenik;
        private System.Windows.Forms.ComboBox Cb_Classs;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Cb_Klass;
        private System.Windows.Forms.ComboBox Cb_Predmet_Filter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Cb_Pricyt;
        private System.Windows.Forms.Button Bt_otchet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridView;
        private System.Windows.Forms.TextBox Tx_Primechanie;
        private System.Windows.Forms.ComboBox Cb_Otmetka;
    }
}
