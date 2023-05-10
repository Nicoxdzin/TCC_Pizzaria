namespace TCC_Pizzaria
{
    partial class Listar_Usuario
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgViewUsuario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.dtgViewUsuario);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(776, 426);
            this.guna2Panel1.TabIndex = 0;
            // 
            // dtgViewUsuario
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgViewUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgViewUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgViewUsuario.ColumnHeadersHeight = 4;
            this.dtgViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgViewUsuario.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgViewUsuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgViewUsuario.Location = new System.Drawing.Point(27, 17);
            this.dtgViewUsuario.Name = "dtgViewUsuario";
            this.dtgViewUsuario.RowHeadersVisible = false;
            this.dtgViewUsuario.Size = new System.Drawing.Size(723, 392);
            this.dtgViewUsuario.TabIndex = 1;
            this.dtgViewUsuario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgViewUsuario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgViewUsuario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgViewUsuario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgViewUsuario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgViewUsuario.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgViewUsuario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgViewUsuario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgViewUsuario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgViewUsuario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgViewUsuario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgViewUsuario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgViewUsuario.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgViewUsuario.ThemeStyle.ReadOnly = false;
            this.dtgViewUsuario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgViewUsuario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgViewUsuario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgViewUsuario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgViewUsuario.ThemeStyle.RowsStyle.Height = 22;
            this.dtgViewUsuario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgViewUsuario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Listar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listar_Usuario";
            this.Text = "Listar_Usuario";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgViewUsuario;
    }
}