
namespace Moiceeva_Diplomm.Windows
{
    partial class Predmet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Bt_Delete = new System.Windows.Forms.Button();
            this.Bt_Insert = new System.Windows.Forms.Button();
            this.Bt_Update = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tx_Klass = new System.Windows.Forms.TextBox();
            this.Bt_Perexod = new System.Windows.Forms.Button();
            this.Dt_Predmet = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Predmet)).BeginInit();
            this.SuspendLayout();
            // 
            // Bt_Delete
            // 
            this.Bt_Delete.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bt_Delete.Location = new System.Drawing.Point(17, 284);
            this.Bt_Delete.Name = "Bt_Delete";
            this.Bt_Delete.Size = new System.Drawing.Size(236, 44);
            this.Bt_Delete.TabIndex = 30;
            this.Bt_Delete.Text = "Удалить запись";
            this.Bt_Delete.UseVisualStyleBackColor = true;
            // 
            // Bt_Insert
            // 
            this.Bt_Insert.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bt_Insert.Location = new System.Drawing.Point(17, 184);
            this.Bt_Insert.Name = "Bt_Insert";
            this.Bt_Insert.Size = new System.Drawing.Size(236, 44);
            this.Bt_Insert.TabIndex = 28;
            this.Bt_Insert.Text = "Добавить запись";
            this.Bt_Insert.UseVisualStyleBackColor = true;
            // 
            // Bt_Update
            // 
            this.Bt_Update.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bt_Update.Location = new System.Drawing.Point(17, 234);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(236, 44);
            this.Bt_Update.TabIndex = 29;
            this.Bt_Update.Text = "Изменить запись";
            this.Bt_Update.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(11, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 31);
            this.label7.TabIndex = 47;
            this.label7.Text = "Добавление предмета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(8, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Введите название предмета";
            // 
            // Tx_Klass
            // 
            this.Tx_Klass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.Tx_Klass.Location = new System.Drawing.Point(12, 119);
            this.Tx_Klass.Name = "Tx_Klass";
            this.Tx_Klass.Size = new System.Drawing.Size(355, 28);
            this.Tx_Klass.TabIndex = 45;
            this.Tx_Klass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tx_Klass_KeyPress);
            // 
            // Bt_Perexod
            // 
            this.Bt_Perexod.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bt_Perexod.Location = new System.Drawing.Point(12, 357);
            this.Bt_Perexod.Name = "Bt_Perexod";
            this.Bt_Perexod.Size = new System.Drawing.Size(355, 44);
            this.Bt_Perexod.TabIndex = 48;
            this.Bt_Perexod.Text = "Назначить преподавателя и предмет";
            this.Bt_Perexod.UseVisualStyleBackColor = true;
            // 
            // Dt_Predmet
            // 
            this.Dt_Predmet.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Dt_Predmet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dt_Predmet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dt_Predmet.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dt_Predmet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dt_Predmet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dt_Predmet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dt_Predmet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dt_Predmet.ColumnHeadersHeight = 40;
            this.Dt_Predmet.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.Dt_Predmet.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Dt_Predmet.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Dt_Predmet.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.Dt_Predmet.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Dt_Predmet.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.Dt_Predmet.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Dt_Predmet.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.Dt_Predmet.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.Dt_Predmet.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Dt_Predmet.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.Dt_Predmet.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.Dt_Predmet.CurrentTheme.Name = null;
            this.Dt_Predmet.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Dt_Predmet.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Dt_Predmet.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Dt_Predmet.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.Dt_Predmet.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dt_Predmet.DefaultCellStyle = dataGridViewCellStyle6;
            this.Dt_Predmet.EnableHeadersVisualStyles = false;
            this.Dt_Predmet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Dt_Predmet.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.Dt_Predmet.HeaderBgColor = System.Drawing.Color.Empty;
            this.Dt_Predmet.HeaderForeColor = System.Drawing.Color.White;
            this.Dt_Predmet.Location = new System.Drawing.Point(380, 12);
            this.Dt_Predmet.Name = "Dt_Predmet";
            this.Dt_Predmet.RowHeadersVisible = false;
            this.Dt_Predmet.RowHeadersWidth = 51;
            this.Dt_Predmet.RowTemplate.Height = 40;
            this.Dt_Predmet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dt_Predmet.Size = new System.Drawing.Size(478, 437);
            this.Dt_Predmet.TabIndex = 49;
            this.Dt_Predmet.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.Dt_Predmet.DoubleClick += new System.EventHandler(this.Dt_Predmet_DoubleClick);
            // 
            // Predmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 461);
            this.Controls.Add(this.Dt_Predmet);
            this.Controls.Add(this.Bt_Perexod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tx_Klass);
            this.Controls.Add(this.Bt_Delete);
            this.Controls.Add(this.Bt_Insert);
            this.Controls.Add(this.Bt_Update);
            this.Name = "Predmet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Предметы";
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Predmet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Delete;
        private System.Windows.Forms.Button Bt_Insert;
        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tx_Klass;
        private System.Windows.Forms.Button Bt_Perexod;
        private Bunifu.UI.WinForms.BunifuDataGridView Dt_Predmet;
    }
}