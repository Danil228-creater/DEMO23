
namespace Moiceeva_Diplomm.Windows
{
    partial class Predmet_Ychitel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cb_Ychitel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cb_Pred = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_Delete = new System.Windows.Forms.Button();
            this.Bt_Update = new System.Windows.Forms.Button();
            this.Bt_Insert = new System.Windows.Forms.Button();
            this.Dt_Predmet = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Predmet)).BeginInit();
            this.SuspendLayout();
            // 
            // Cb_Ychitel
            // 
            this.Cb_Ychitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.Cb_Ychitel.FormattingEnabled = true;
            this.Cb_Ychitel.Location = new System.Drawing.Point(16, 76);
            this.Cb_Ychitel.Name = "Cb_Ychitel";
            this.Cb_Ychitel.Size = new System.Drawing.Size(364, 30);
            this.Cb_Ychitel.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(11, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Выберите учителя";
            // 
            // Cb_Pred
            // 
            this.Cb_Pred.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.Cb_Pred.FormattingEnabled = true;
            this.Cb_Pred.Location = new System.Drawing.Point(16, 158);
            this.Cb_Pred.Name = "Cb_Pred";
            this.Cb_Pred.Size = new System.Drawing.Size(364, 30);
            this.Cb_Pred.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Выберите предмет";
            // 
            // Bt_Delete
            // 
            this.Bt_Delete.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bt_Delete.Location = new System.Drawing.Point(17, 325);
            this.Bt_Delete.Name = "Bt_Delete";
            this.Bt_Delete.Size = new System.Drawing.Size(240, 44);
            this.Bt_Delete.TabIndex = 46;
            this.Bt_Delete.Text = "Удалить запись";
            this.Bt_Delete.UseVisualStyleBackColor = true;
            // 
            // Bt_Update
            // 
            this.Bt_Update.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bt_Update.Location = new System.Drawing.Point(17, 275);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(240, 44);
            this.Bt_Update.TabIndex = 45;
            this.Bt_Update.Text = "Изменить запись";
            this.Bt_Update.UseVisualStyleBackColor = true;
            // 
            // Bt_Insert
            // 
            this.Bt_Insert.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bt_Insert.Location = new System.Drawing.Point(17, 225);
            this.Bt_Insert.Name = "Bt_Insert";
            this.Bt_Insert.Size = new System.Drawing.Size(237, 44);
            this.Bt_Insert.TabIndex = 44;
            this.Bt_Insert.Text = "Добавить запись";
            this.Bt_Insert.UseVisualStyleBackColor = true;
            // 
            // Dt_Predmet
            // 
            this.Dt_Predmet.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Dt_Predmet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dt_Predmet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dt_Predmet.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dt_Predmet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dt_Predmet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dt_Predmet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dt_Predmet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dt_Predmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dt_Predmet.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dt_Predmet.EnableHeadersVisualStyles = false;
            this.Dt_Predmet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Dt_Predmet.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.Dt_Predmet.HeaderBgColor = System.Drawing.Color.Empty;
            this.Dt_Predmet.HeaderForeColor = System.Drawing.Color.White;
            this.Dt_Predmet.Location = new System.Drawing.Point(427, 25);
            this.Dt_Predmet.Name = "Dt_Predmet";
            this.Dt_Predmet.RowHeadersVisible = false;
            this.Dt_Predmet.RowHeadersWidth = 51;
            this.Dt_Predmet.RowTemplate.Height = 40;
            this.Dt_Predmet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dt_Predmet.Size = new System.Drawing.Size(837, 469);
            this.Dt_Predmet.TabIndex = 47;
            this.Dt_Predmet.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.Dt_Predmet.DoubleClick += new System.EventHandler(this.Dt_Predmet_DoubleClick);
            // 
            // Predmet_Ychitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 527);
            this.Controls.Add(this.Dt_Predmet);
            this.Controls.Add(this.Bt_Delete);
            this.Controls.Add(this.Bt_Update);
            this.Controls.Add(this.Bt_Insert);
            this.Controls.Add(this.Cb_Pred);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cb_Ychitel);
            this.Controls.Add(this.label4);
            this.Name = "Predmet_Ychitel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Предметы учителей";
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Predmet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Cb_Ychitel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cb_Pred;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_Delete;
        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.Button Bt_Insert;
        private Bunifu.UI.WinForms.BunifuDataGridView Dt_Predmet;
    }
}