namespace TCC_Pizzaria
{
    partial class ListaPedido
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
            this.pnlListaPedido = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNovo = new Guna.UI2.WinForms.Guna2Button();
            this.dtPickerData = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtPesquisaNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDeletar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAtualizar = new Guna.UI2.WinForms.Guna2Button();
            this.dtgView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlListaPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlListaPedido
            // 
            this.pnlListaPedido.BorderRadius = 10;
            this.pnlListaPedido.Controls.Add(this.btnNovo);
            this.pnlListaPedido.Controls.Add(this.dtPickerData);
            this.pnlListaPedido.Controls.Add(this.txtPesquisaNome);
            this.pnlListaPedido.Controls.Add(this.btnDeletar);
            this.pnlListaPedido.Controls.Add(this.btnAtualizar);
            this.pnlListaPedido.Controls.Add(this.dtgView1);
            this.pnlListaPedido.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlListaPedido.Location = new System.Drawing.Point(21, 23);
            this.pnlListaPedido.Name = "pnlListaPedido";
            this.pnlListaPedido.Size = new System.Drawing.Size(860, 527);
            this.pnlListaPedido.TabIndex = 4;
            this.pnlListaPedido.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel4_Paint);
            // 
            // btnNovo
            // 
            this.btnNovo.BorderRadius = 10;
            this.btnNovo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNovo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNovo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNovo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(691, 198);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(137, 55);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Cadastrar Pedido";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dtPickerData
            // 
            this.dtPickerData.Checked = true;
            this.dtPickerData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtPickerData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtPickerData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerData.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dtPickerData.Location = new System.Drawing.Point(544, 22);
            this.dtPickerData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPickerData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPickerData.Name = "dtPickerData";
            this.dtPickerData.Size = new System.Drawing.Size(123, 27);
            this.dtPickerData.TabIndex = 5;
            this.dtPickerData.Value = new System.DateTime(2023, 5, 24, 15, 41, 0, 19);
            this.dtPickerData.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.BorderRadius = 8;
            this.txtPesquisaNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisaNome.DefaultText = "";
            this.txtPesquisaNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesquisaNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesquisaNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisaNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisaNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisaNome.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.txtPesquisaNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisaNome.Location = new System.Drawing.Point(30, 22);
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.PasswordChar = '\0';
            this.txtPesquisaNome.PlaceholderText = "Pesquisar Nome";
            this.txtPesquisaNome.SelectedText = "";
            this.txtPesquisaNome.Size = new System.Drawing.Size(496, 27);
            this.txtPesquisaNome.TabIndex = 3;
            this.txtPesquisaNome.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BorderRadius = 10;
            this.btnDeletar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeletar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeletar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeletar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeletar.ForeColor = System.Drawing.Color.White;
            this.btnDeletar.Location = new System.Drawing.Point(691, 125);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(137, 55);
            this.btnDeletar.TabIndex = 2;
            this.btnDeletar.Text = "Deletar Pedido";
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BorderRadius = 10;
            this.btnAtualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAtualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAtualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAtualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(691, 55);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(137, 55);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar Pedido";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dtgView1
            // 
            this.dtgView1.AllowDrop = true;
            this.dtgView1.AllowUserToAddRows = false;
            this.dtgView1.AllowUserToDeleteRows = false;
            this.dtgView1.AllowUserToOrderColumns = true;
            this.dtgView1.AllowUserToResizeColumns = false;
            this.dtgView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dtgView1.Location = new System.Drawing.Point(30, 55);
            this.dtgView1.Name = "dtgView1";
            this.dtgView1.RowHeadersVisible = false;
            this.dtgView1.Size = new System.Drawing.Size(637, 446);
            this.dtgView1.TabIndex = 0;
            this.dtgView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dtgView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dtgView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dtgView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgView1.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgView1.ThemeStyle.ReadOnly = false;
            this.dtgView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgView1.ThemeStyle.RowsStyle.Height = 22;
            this.dtgView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dtgView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlListaPedido);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 573);
            this.panel1.TabIndex = 5;
            // 
            // ListaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 572);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaPedido";
            this.Load += new System.EventHandler(this.ListaPedido_Load);
            this.pnlListaPedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlListaPedido;
        private Guna.UI2.WinForms.Guna2DataGridView dtgView1;
        private Guna.UI2.WinForms.Guna2Button btnDeletar;
        private Guna.UI2.WinForms.Guna2Button btnAtualizar;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisaNome;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtPickerData;
        private Guna.UI2.WinForms.Guna2Button btnNovo;
        private System.Windows.Forms.Panel panel1;
    }
}