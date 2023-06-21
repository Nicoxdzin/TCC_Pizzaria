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
            this.pnlCliente1 = new System.Windows.Forms.Panel();
            this.pnlCliente2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCadastroNovoCliente = new Guna.UI2.WinForms.Guna2Button();
            this.txtPesquisaNomeCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDeletarCliente = new Guna.UI2.WinForms.Guna2Button();
            this.btnAtualizarCliente = new Guna.UI2.WinForms.Guna2Button();
            this.dtgViewCliente = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlCliente1.SuspendLayout();
            this.pnlCliente2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCliente1
            // 
            this.pnlCliente1.Controls.Add(this.pnlCliente2);
            this.pnlCliente1.Location = new System.Drawing.Point(-1, -1);
            this.pnlCliente1.Name = "pnlCliente1";
            this.pnlCliente1.Size = new System.Drawing.Size(902, 573);
            this.pnlCliente1.TabIndex = 6;
            // 
            // pnlCliente2
            // 
            this.pnlCliente2.BorderRadius = 10;
            this.pnlCliente2.Controls.Add(this.btnCadastroNovoCliente);
            this.pnlCliente2.Controls.Add(this.txtPesquisaNomeCliente);
            this.pnlCliente2.Controls.Add(this.btnDeletarCliente);
            this.pnlCliente2.Controls.Add(this.btnAtualizarCliente);
            this.pnlCliente2.Controls.Add(this.dtgViewCliente);
            this.pnlCliente2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlCliente2.Location = new System.Drawing.Point(21, 23);
            this.pnlCliente2.Name = "pnlCliente2";
            this.pnlCliente2.Size = new System.Drawing.Size(860, 527);
            this.pnlCliente2.TabIndex = 4;
            // 
            // btnCadastroNovoCliente
            // 
            this.btnCadastroNovoCliente.BorderRadius = 10;
            this.btnCadastroNovoCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastroNovoCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastroNovoCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadastroNovoCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadastroNovoCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCadastroNovoCliente.ForeColor = System.Drawing.Color.White;
            this.btnCadastroNovoCliente.Location = new System.Drawing.Point(691, 198);
            this.btnCadastroNovoCliente.Name = "btnCadastroNovoCliente";
            this.btnCadastroNovoCliente.Size = new System.Drawing.Size(137, 55);
            this.btnCadastroNovoCliente.TabIndex = 6;
            this.btnCadastroNovoCliente.Text = "Cadastrar Cliente";
            this.btnCadastroNovoCliente.Click += new System.EventHandler(this.btnCadastroNovoCliente_Click);
            // 
            // txtPesquisaNomeCliente
            // 
            this.txtPesquisaNomeCliente.BorderRadius = 8;
            this.txtPesquisaNomeCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisaNomeCliente.DefaultText = "";
            this.txtPesquisaNomeCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesquisaNomeCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesquisaNomeCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisaNomeCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisaNomeCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisaNomeCliente.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.txtPesquisaNomeCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisaNomeCliente.Location = new System.Drawing.Point(30, 22);
            this.txtPesquisaNomeCliente.Name = "txtPesquisaNomeCliente";
            this.txtPesquisaNomeCliente.PasswordChar = '\0';
            this.txtPesquisaNomeCliente.PlaceholderText = "Pesquisar Nome";
            this.txtPesquisaNomeCliente.SelectedText = "";
            this.txtPesquisaNomeCliente.Size = new System.Drawing.Size(496, 27);
            this.txtPesquisaNomeCliente.TabIndex = 3;
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
            this.btnDeletarCliente.Location = new System.Drawing.Point(691, 125);
            this.btnDeletarCliente.Name = "btnDeletarCliente";
            this.btnDeletarCliente.Size = new System.Drawing.Size(137, 55);
            this.btnDeletarCliente.TabIndex = 2;
            this.btnDeletarCliente.Text = "Deletar Cliente";
            this.btnDeletarCliente.Click += new System.EventHandler(this.btnDeletarCliente_Click);
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
            this.btnAtualizarCliente.Location = new System.Drawing.Point(691, 55);
            this.btnAtualizarCliente.Name = "btnAtualizarCliente";
            this.btnAtualizarCliente.Size = new System.Drawing.Size(137, 55);
            this.btnAtualizarCliente.TabIndex = 1;
            this.btnAtualizarCliente.Text = "Atualizar Cliente";
            // 
            // dtgViewCliente
            // 
            this.dtgViewCliente.AllowDrop = true;
            this.dtgViewCliente.AllowUserToAddRows = false;
            this.dtgViewCliente.AllowUserToDeleteRows = false;
            this.dtgViewCliente.AllowUserToOrderColumns = true;
            this.dtgViewCliente.AllowUserToResizeColumns = false;
            this.dtgViewCliente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgViewCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgViewCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgViewCliente.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgViewCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgViewCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgViewCliente.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgViewCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgViewCliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgViewCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dtgViewCliente.Location = new System.Drawing.Point(30, 55);
            this.dtgViewCliente.Name = "dtgViewCliente";
            this.dtgViewCliente.RowHeadersVisible = false;
            this.dtgViewCliente.Size = new System.Drawing.Size(637, 446);
            this.dtgViewCliente.TabIndex = 0;
            this.dtgViewCliente.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dtgViewCliente.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgViewCliente.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgViewCliente.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgViewCliente.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgViewCliente.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgViewCliente.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgViewCliente.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dtgViewCliente.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dtgViewCliente.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgViewCliente.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgViewCliente.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgViewCliente.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgViewCliente.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgViewCliente.ThemeStyle.ReadOnly = false;
            this.dtgViewCliente.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgViewCliente.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgViewCliente.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgViewCliente.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgViewCliente.ThemeStyle.RowsStyle.Height = 22;
            this.dtgViewCliente.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dtgViewCliente.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 572);
            this.Controls.Add(this.pnlCliente1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaCliente";
            this.Text = "Listar_Usuario";
            this.Load += new System.EventHandler(this.ListaCliente_Load);
            this.pnlCliente1.ResumeLayout(false);
            this.pnlCliente2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCliente1;
        private Guna.UI2.WinForms.Guna2Panel pnlCliente2;
        private Guna.UI2.WinForms.Guna2Button btnCadastroNovoCliente;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisaNomeCliente;
        private Guna.UI2.WinForms.Guna2Button btnDeletarCliente;
        private Guna.UI2.WinForms.Guna2Button btnAtualizarCliente;
        private Guna.UI2.WinForms.Guna2DataGridView dtgViewCliente;
    }
}