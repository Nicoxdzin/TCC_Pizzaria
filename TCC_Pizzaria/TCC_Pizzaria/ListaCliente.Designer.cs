namespace TCC_Pizzaria
{
    partial class ListaCliente
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgViewCliente = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDeletarCliente = new Guna.UI2.WinForms.Guna2Button();
            this.btnAtualizarCliente = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnAtualizarCliente);
            this.guna2Panel1.Controls.Add(this.btnDeletarCliente);
            this.guna2Panel1.Controls.Add(this.dtgViewCliente);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.guna2Panel1.Location = new System.Drawing.Point(20, 19);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(860, 484);
            this.guna2Panel1.TabIndex = 0;
            // 
            // dtgViewCliente
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgViewCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgViewCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgViewCliente.ColumnHeadersHeight = 4;
            this.dtgViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgViewCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgViewCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgViewCliente.Location = new System.Drawing.Point(30, 24);
            this.dtgViewCliente.Name = "dtgViewCliente";
            this.dtgViewCliente.RowHeadersVisible = false;
            this.dtgViewCliente.Size = new System.Drawing.Size(579, 437);
            this.dtgViewCliente.TabIndex = 1;
            this.dtgViewCliente.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgViewCliente.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgViewCliente.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgViewCliente.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgViewCliente.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgViewCliente.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgViewCliente.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgViewCliente.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgViewCliente.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgViewCliente.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgViewCliente.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgViewCliente.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgViewCliente.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgViewCliente.ThemeStyle.ReadOnly = false;
            this.dtgViewCliente.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgViewCliente.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgViewCliente.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgViewCliente.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgViewCliente.ThemeStyle.RowsStyle.Height = 22;
            this.dtgViewCliente.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgViewCliente.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgViewCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgViewUsuario_CellContentClick);
            // 
            // btnDeletarCliente
            // 
            this.btnDeletarCliente.BorderRadius = 10;
            this.btnDeletarCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeletarCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeletarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeletarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeletarCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeletarCliente.ForeColor = System.Drawing.Color.White;
            this.btnDeletarCliente.Location = new System.Drawing.Point(644, 93);
            this.btnDeletarCliente.Name = "btnDeletarCliente";
            this.btnDeletarCliente.Size = new System.Drawing.Size(180, 55);
            this.btnDeletarCliente.TabIndex = 40;
            this.btnDeletarCliente.Text = "Deletar Cliente";
            // 
            // btnAtualizarCliente
            // 
            this.btnAtualizarCliente.BorderRadius = 10;
            this.btnAtualizarCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAtualizarCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAtualizarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAtualizarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAtualizarCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAtualizarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarCliente.Location = new System.Drawing.Point(644, 24);
            this.btnAtualizarCliente.Name = "btnAtualizarCliente";
            this.btnAtualizarCliente.Size = new System.Drawing.Size(180, 55);
            this.btnAtualizarCliente.TabIndex = 41;
            this.btnAtualizarCliente.Text = "Atualizar Cliente";
            // 
            // ListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 522);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaCliente";
            this.Text = "Listar_Usuario";
            this.Load += new System.EventHandler(this.ListaCliente_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgViewCliente;
        private Guna.UI2.WinForms.Guna2Button btnAtualizarCliente;
        private Guna.UI2.WinForms.Guna2Button btnDeletarCliente;
    }
}