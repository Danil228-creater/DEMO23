
namespace Moiceeva_Diplomm.Windows
{
    partial class Klass
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
            this.label3 = new System.Windows.Forms.Label();
            this.Tx_Klass = new System.Windows.Forms.TextBox();
            this.Bt_Delete = new System.Windows.Forms.Button();
            this.Bt_Update = new System.Windows.Forms.Button();
            this.Bt_Insert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Dt_Klass = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Klass)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Введите название класса";
            // 
            // Tx_Klass
            // 
            this.Tx_Klass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.Tx_Klass.Location = new System.Drawing.Point(16, 176);
            this.Tx_Klass.Name = "Tx_Klass";
            this.Tx_Klass.Size = new System.Drawing.Size(309, 28);
            this.Tx_Klass.TabIndex = 39;
            this.Tx_Klass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tx_Klass_KeyPress);
            // 
            // Bt_Delete
            // 
            this.Bt_Delete.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bt_Delete.Location = new System.Drawing.Point(48, 414);
            this.Bt_Delete.Name = "Bt_Delete";
            this.Bt_Delete.Size = new System.Drawing.Size(240, 44);
            this.Bt_Delete.TabIndex = 43;
            this.Bt_Delete.Text = "Удалить запись";
            this.Bt_Delete.UseVisualStyleBackColor = true;
            // 
            // Bt_Update
            // 
            this.Bt_Update.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bt_Update.Location = new System.Drawing.Point(48, 364);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(240, 44);
            this.Bt_Update.TabIndex = 42;
            this.Bt_Update.Text = "Изменить запись";
            this.Bt_Update.UseVisualStyleBackColor = true;
            // 
            // Bt_Insert
            // 
            this.Bt_Insert.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bt_Insert.Location = new System.Drawing.Point(48, 314);
            this.Bt_Insert.Name = "Bt_Insert";
            this.Bt_Insert.Size = new System.Drawing.Size(237, 44);
            this.Bt_Insert.TabIndex = 41;
            this.Bt_Insert.Text = "Добавить запись";
            this.Bt_Insert.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 31);
            this.label7.TabIndex = 44;
            this.label7.Text = "Добавление класса";
            // 
            // Dt_Klass
            // 
            this.Dt_Klass.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Dt_Klass.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dt_Klass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dt_Klass.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dt_Klass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dt_Klass.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dt_Klass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dt_Klass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dt_Klass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dt_Klass.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.Dt_Klass.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Dt_Klass.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Dt_Klass.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.Dt_Klass.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Dt_Klass.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.Dt_Klass.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Dt_Klass.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.Dt_Klass.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.Dt_Klass.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Dt_Klass.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.Dt_Klass.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.Dt_Klass.CurrentTheme.Name = null;
            this.Dt_Klass.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Dt_Klass.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Dt_Klass.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Dt_Klass.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.Dt_Klass.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dt_Klass.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dt_Klass.EnableHeadersVisualStyles = false;
            this.Dt_Klass.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Dt_Klass.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.Dt_Klass.HeaderBgColor = System.Drawing.Color.Empty;
            this.Dt_Klass.HeaderForeColor = System.Drawing.Color.White;
            this.Dt_Klass.Location = new System.Drawing.Point(363, 31);
            this.Dt_Klass.Name = "Dt_Klass";
            this.Dt_Klass.RowHeadersVisible = false;
            this.Dt_Klass.RowHeadersWidth = 51;
            this.Dt_Klass.RowTemplate.Height = 40;
            this.Dt_Klass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dt_Klass.Size = new System.Drawing.Size(398, 465);
            this.Dt_Klass.TabIndex = 45;
            this.Dt_Klass.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.Dt_Klass.DoubleClick += new System.EventHandler(this.Dt_Klass_DoubleClick);
            // 
            // Klass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(773, 508);
            this.Controls.Add(this.Dt_Klass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Bt_Delete);
            this.Controls.Add(this.Bt_Update);
            this.Controls.Add(this.Bt_Insert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tx_Klass);
            this.Name = "Klass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Класс";
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Klass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tx_Klass;
        private System.Windows.Forms.Button Bt_Delete;
        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.Button Bt_Insert;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuDataGridView Dt_Klass;
    }
}