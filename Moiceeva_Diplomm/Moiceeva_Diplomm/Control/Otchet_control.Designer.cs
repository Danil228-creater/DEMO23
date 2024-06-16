
namespace Moiceeva_Diplomm.Control
{
    partial class Otchet_control
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
            this.bt_Otchet_Ycheniki = new System.Windows.Forms.Button();
            this.Cb_Klass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Cb_Uchenik = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cb_Classi = new System.Windows.Forms.ComboBox();
            this.Bt_Otchet_Uchenik = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Otchet_Ycheniki
            // 
            this.bt_Otchet_Ycheniki.Location = new System.Drawing.Point(91, 175);
            this.bt_Otchet_Ycheniki.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Otchet_Ycheniki.Name = "bt_Otchet_Ycheniki";
            this.bt_Otchet_Ycheniki.Size = new System.Drawing.Size(247, 43);
            this.bt_Otchet_Ycheniki.TabIndex = 6;
            this.bt_Otchet_Ycheniki.Text = "Отчет о учениках";
            this.bt_Otchet_Ycheniki.UseVisualStyleBackColor = true;
            // 
            // Cb_Klass
            // 
            this.Cb_Klass.FormattingEnabled = true;
            this.Cb_Klass.Location = new System.Drawing.Point(27, 107);
            this.Cb_Klass.Name = "Cb_Klass";
            this.Cb_Klass.Size = new System.Drawing.Size(347, 28);
            this.Cb_Klass.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Выберете класс";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cb_Klass);
            this.groupBox1.Controls.Add(this.bt_Otchet_Ycheniki);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(19, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 443);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ученики";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Cb_Uchenik);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Cb_Classi);
            this.groupBox2.Controls.Add(this.Bt_Otchet_Uchenik);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(628, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(913, 443);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ученик";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Выберете период";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(435, 203);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(458, 27);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 203);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(363, 27);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Выберете ученика";
            // 
            // Cb_Uchenik
            // 
            this.Cb_Uchenik.FormattingEnabled = true;
            this.Cb_Uchenik.Location = new System.Drawing.Point(435, 107);
            this.Cb_Uchenik.Name = "Cb_Uchenik";
            this.Cb_Uchenik.Size = new System.Drawing.Size(458, 28);
            this.Cb_Uchenik.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Выберете класс";
            // 
            // Cb_Classi
            // 
            this.Cb_Classi.FormattingEnabled = true;
            this.Cb_Classi.Location = new System.Drawing.Point(6, 107);
            this.Cb_Classi.Name = "Cb_Classi";
            this.Cb_Classi.Size = new System.Drawing.Size(364, 28);
            this.Cb_Classi.TabIndex = 9;
            this.Cb_Classi.SelectedIndexChanged += new System.EventHandler(this.Cb_Classi_SelectedIndexChanged);
            // 
            // Bt_Otchet_Uchenik
            // 
            this.Bt_Otchet_Uchenik.Location = new System.Drawing.Point(230, 303);
            this.Bt_Otchet_Uchenik.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Otchet_Uchenik.Name = "Bt_Otchet_Uchenik";
            this.Bt_Otchet_Uchenik.Size = new System.Drawing.Size(340, 43);
            this.Bt_Otchet_Uchenik.TabIndex = 6;
            this.Bt_Otchet_Uchenik.Text = "Отчет об успеваемости";
            this.Bt_Otchet_Uchenik.UseVisualStyleBackColor = true;
            // 
            // Otchet_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Otchet_control";
            this.Size = new System.Drawing.Size(1688, 738);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Otchet_Ycheniki;
        private System.Windows.Forms.ComboBox Cb_Klass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cb_Uchenik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cb_Classi;
        private System.Windows.Forms.Button Bt_Otchet_Uchenik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
