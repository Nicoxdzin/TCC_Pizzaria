namespace TCC_Pizzaria
{
    partial class CadastroCliente
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
            this.pnlNovoCliente = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReferencia = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCadastrarCliente = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumero_Casa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCep = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero_Telefone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCpf = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.msgErro = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgSucesso = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.btnVoltarListaCliente = new Guna.UI2.WinForms.Guna2Button();
            this.pnlNovoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNovoCliente
            // 
            this.pnlNovoCliente.BorderRadius = 10;
            this.pnlNovoCliente.Controls.Add(this.btnVoltarListaCliente);
            this.pnlNovoCliente.Controls.Add(this.label4);
            this.pnlNovoCliente.Controls.Add(this.txtReferencia);
            this.pnlNovoCliente.Controls.Add(this.btnCadastrarCliente);
            this.pnlNovoCliente.Controls.Add(this.label7);
            this.pnlNovoCliente.Controls.Add(this.txtNumero_Casa);
            this.pnlNovoCliente.Controls.Add(this.txtCep);
            this.pnlNovoCliente.Controls.Add(this.label1);
            this.pnlNovoCliente.Controls.Add(this.label2);
            this.pnlNovoCliente.Controls.Add(this.txtNumero_Telefone);
            this.pnlNovoCliente.Controls.Add(this.txtCpf);
            this.pnlNovoCliente.Controls.Add(this.label6);
            this.pnlNovoCliente.Controls.Add(this.label3);
            this.pnlNovoCliente.Controls.Add(this.txtNome);
            this.pnlNovoCliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlNovoCliente.Location = new System.Drawing.Point(21, 23);
            this.pnlNovoCliente.Name = "pnlNovoCliente";
            this.pnlNovoCliente.Size = new System.Drawing.Size(860, 527);
            this.pnlNovoCliente.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(426, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Referências";
            // 
            // txtReferencia
            // 
            this.txtReferencia.BackColor = System.Drawing.Color.Transparent;
            this.txtReferencia.BorderColor = System.Drawing.Color.Gray;
            this.txtReferencia.BorderRadius = 5;
            this.txtReferencia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReferencia.DefaultText = "";
            this.txtReferencia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReferencia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReferencia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReferencia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReferencia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtReferencia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReferencia.Location = new System.Drawing.Point(426, 209);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.PasswordChar = '\0';
            this.txtReferencia.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtReferencia.PlaceholderText = "Casa, Apartamento...";
            this.txtReferencia.SelectedText = "";
            this.txtReferencia.Size = new System.Drawing.Size(238, 34);
            this.txtReferencia.TabIndex = 40;
            this.txtReferencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReferencia_KeyDown);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.BorderRadius = 10;
            this.btnCadastrarCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrarCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadastrarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCadastrarCliente.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(316, 282);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(215, 55);
            this.btnCadastrarCliente.TabIndex = 39;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente";
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(426, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "N° da Casa";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtNumero_Casa
            // 
            this.txtNumero_Casa.BackColor = System.Drawing.Color.Transparent;
            this.txtNumero_Casa.BorderColor = System.Drawing.Color.Gray;
            this.txtNumero_Casa.BorderRadius = 5;
            this.txtNumero_Casa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumero_Casa.DefaultText = "";
            this.txtNumero_Casa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumero_Casa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumero_Casa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumero_Casa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumero_Casa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumero_Casa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNumero_Casa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumero_Casa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumero_Casa.Location = new System.Drawing.Point(426, 153);
            this.txtNumero_Casa.Name = "txtNumero_Casa";
            this.txtNumero_Casa.PasswordChar = '\0';
            this.txtNumero_Casa.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNumero_Casa.PlaceholderText = "1234";
            this.txtNumero_Casa.SelectedText = "";
            this.txtNumero_Casa.Size = new System.Drawing.Size(238, 34);
            this.txtNumero_Casa.TabIndex = 37;
            this.txtNumero_Casa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero_Casa_KeyDown);
            // 
            // txtCep
            // 
            this.txtCep.BackColor = System.Drawing.Color.Transparent;
            this.txtCep.BorderColor = System.Drawing.Color.Gray;
            this.txtCep.BorderRadius = 5;
            this.txtCep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCep.DefaultText = "";
            this.txtCep.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCep.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCep.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCep.Location = new System.Drawing.Point(426, 97);
            this.txtCep.Name = "txtCep";
            this.txtCep.PasswordChar = '\0';
            this.txtCep.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCep.PlaceholderText = "00000-000";
            this.txtCep.SelectedText = "";
            this.txtCep.Size = new System.Drawing.Size(238, 34);
            this.txtCep.TabIndex = 36;
            this.txtCep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCep_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(426, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "CEP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(182, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "N° de Telefone";
            // 
            // txtNumero_Telefone
            // 
            this.txtNumero_Telefone.BackColor = System.Drawing.Color.Transparent;
            this.txtNumero_Telefone.BorderColor = System.Drawing.Color.Gray;
            this.txtNumero_Telefone.BorderRadius = 5;
            this.txtNumero_Telefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumero_Telefone.DefaultText = "";
            this.txtNumero_Telefone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumero_Telefone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumero_Telefone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumero_Telefone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumero_Telefone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumero_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNumero_Telefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumero_Telefone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumero_Telefone.Location = new System.Drawing.Point(182, 209);
            this.txtNumero_Telefone.Name = "txtNumero_Telefone";
            this.txtNumero_Telefone.PasswordChar = '\0';
            this.txtNumero_Telefone.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNumero_Telefone.PlaceholderText = "(00) 90000-0000";
            this.txtNumero_Telefone.SelectedText = "";
            this.txtNumero_Telefone.Size = new System.Drawing.Size(238, 34);
            this.txtNumero_Telefone.TabIndex = 33;
            this.txtNumero_Telefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero_Telefone_KeyDown);
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.Transparent;
            this.txtCpf.BorderColor = System.Drawing.Color.Gray;
            this.txtCpf.BorderRadius = 5;
            this.txtCpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCpf.DefaultText = "";
            this.txtCpf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCpf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCpf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCpf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCpf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCpf.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCpf.Location = new System.Drawing.Point(182, 153);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.PasswordChar = '\0';
            this.txtCpf.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCpf.PlaceholderText = "000.000.000-00";
            this.txtCpf.SelectedText = "";
            this.txtCpf.Size = new System.Drawing.Size(238, 34);
            this.txtCpf.TabIndex = 32;
            this.txtCpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCpf_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(182, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(182, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Transparent;
            this.txtNome.BorderColor = System.Drawing.Color.Gray;
            this.txtNome.BorderRadius = 5;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.DefaultText = "";
            this.txtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.Location = new System.Drawing.Point(182, 96);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNome.PlaceholderText = "Nome do cliente";
            this.txtNome.SelectedText = "";
            this.txtNome.Size = new System.Drawing.Size(238, 34);
            this.txtNome.TabIndex = 29;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // msgErro
            // 
            this.msgErro.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgErro.Caption = null;
            this.msgErro.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.msgErro.Parent = null;
            this.msgErro.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msgErro.Text = null;
            // 
            // msgSucesso
            // 
            this.msgSucesso.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgSucesso.Caption = null;
            this.msgSucesso.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.msgSucesso.Parent = null;
            this.msgSucesso.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msgSucesso.Text = null;
            // 
            // btnVoltarListaCliente
            // 
            this.btnVoltarListaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnVoltarListaCliente.BackgroundImage = global::TCC_Pizzaria.Properties.Resources.botao_voltar;
            this.btnVoltarListaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltarListaCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltarListaCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltarListaCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVoltarListaCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVoltarListaCliente.FillColor = System.Drawing.Color.Transparent;
            this.btnVoltarListaCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVoltarListaCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnVoltarListaCliente.Location = new System.Drawing.Point(3, 3);
            this.btnVoltarListaCliente.Name = "btnVoltarListaCliente";
            this.btnVoltarListaCliente.Size = new System.Drawing.Size(30, 32);
            this.btnVoltarListaCliente.TabIndex = 60;
            this.btnVoltarListaCliente.Click += new System.EventHandler(this.btnVoltarListaCliente_Click);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 572);
            this.Controls.Add(this.pnlNovoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroCliente";
            this.Text = "Cadastro_Usuario";
            this.Load += new System.EventHandler(this.Cadastro_Usuario_Load);
            this.pnlNovoCliente.ResumeLayout(false);
            this.pnlNovoCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlNovoCliente;
        private Guna.UI2.WinForms.Guna2MessageDialog msgErro;
        private Guna.UI2.WinForms.Guna2MessageDialog msgSucesso;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtNumero_Casa;
        private Guna.UI2.WinForms.Guna2TextBox txtCep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtNumero_Telefone;
        private Guna.UI2.WinForms.Guna2Button btnCadastrarCliente;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtReferencia;
        private Guna.UI2.WinForms.Guna2Button btnVoltarListaCliente;
    }
}