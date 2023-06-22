namespace TCC_Pizzaria
{
    partial class AtualizaCliente
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
            this.btnCancelarCliente = new Guna.UI2.WinForms.Guna2Button();
            this.btnAttCliente = new Guna.UI2.WinForms.Guna2Button();
            this.txtAttCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAttCpf = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAttNumeroTel = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAttCep = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAttNumeroCasa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAttReferencia = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelAttCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarCliente
            // 
            this.btnCancelarCliente.BorderRadius = 10;
            this.btnCancelarCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelarCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelarCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelarCliente.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCliente.Location = new System.Drawing.Point(548, 383);
            this.btnCancelarCliente.Name = "btnCancelarCliente";
            this.btnCancelarCliente.Size = new System.Drawing.Size(117, 55);
            this.btnCancelarCliente.TabIndex = 82;
            this.btnCancelarCliente.Text = "Cancelar";
            this.btnCancelarCliente.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnAttCliente
            // 
            this.btnAttCliente.BorderRadius = 10;
            this.btnAttCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAttCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAttCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAttCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAttCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAttCliente.ForeColor = System.Drawing.Color.White;
            this.btnAttCliente.Location = new System.Drawing.Point(671, 383);
            this.btnAttCliente.Name = "btnAttCliente";
            this.btnAttCliente.Size = new System.Drawing.Size(117, 55);
            this.btnAttCliente.TabIndex = 83;
            this.btnAttCliente.Text = "Atualizar Cliente";
            this.btnAttCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // txtAttCliente
            // 
            this.txtAttCliente.BackColor = System.Drawing.Color.Transparent;
            this.txtAttCliente.BorderColor = System.Drawing.Color.Gray;
            this.txtAttCliente.BorderRadius = 5;
            this.txtAttCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAttCliente.DefaultText = "";
            this.txtAttCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAttCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAttCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAttCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAttCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAttCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAttCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAttCliente.Location = new System.Drawing.Point(124, 76);
            this.txtAttCliente.Name = "txtAttCliente";
            this.txtAttCliente.PasswordChar = '\0';
            this.txtAttCliente.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAttCliente.PlaceholderText = "Nome do cliente";
            this.txtAttCliente.SelectedText = "";
            this.txtAttCliente.Size = new System.Drawing.Size(238, 36);
            this.txtAttCliente.TabIndex = 84;
            this.txtAttCliente.TextChanged += new System.EventHandler(this.txtAttCliente_TextChanged);
            // 
            // txtAttCpf
            // 
            this.txtAttCpf.BackColor = System.Drawing.Color.Transparent;
            this.txtAttCpf.BorderColor = System.Drawing.Color.Gray;
            this.txtAttCpf.BorderRadius = 5;
            this.txtAttCpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAttCpf.DefaultText = "";
            this.txtAttCpf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAttCpf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAttCpf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAttCpf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAttCpf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAttCpf.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAttCpf.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAttCpf.Location = new System.Drawing.Point(124, 118);
            this.txtAttCpf.Name = "txtAttCpf";
            this.txtAttCpf.PasswordChar = '\0';
            this.txtAttCpf.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAttCpf.PlaceholderText = "000.000.000-00";
            this.txtAttCpf.SelectedText = "";
            this.txtAttCpf.Size = new System.Drawing.Size(238, 36);
            this.txtAttCpf.TabIndex = 85;
            // 
            // txtAttNumeroTel
            // 
            this.txtAttNumeroTel.BackColor = System.Drawing.Color.Transparent;
            this.txtAttNumeroTel.BorderColor = System.Drawing.Color.Gray;
            this.txtAttNumeroTel.BorderRadius = 5;
            this.txtAttNumeroTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAttNumeroTel.DefaultText = "";
            this.txtAttNumeroTel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAttNumeroTel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAttNumeroTel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAttNumeroTel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAttNumeroTel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAttNumeroTel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttNumeroTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAttNumeroTel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAttNumeroTel.Location = new System.Drawing.Point(124, 160);
            this.txtAttNumeroTel.Name = "txtAttNumeroTel";
            this.txtAttNumeroTel.PasswordChar = '\0';
            this.txtAttNumeroTel.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAttNumeroTel.PlaceholderText = "(00) 90000-0000";
            this.txtAttNumeroTel.SelectedText = "";
            this.txtAttNumeroTel.Size = new System.Drawing.Size(238, 36);
            this.txtAttNumeroTel.TabIndex = 86;
            // 
            // txtAttCep
            // 
            this.txtAttCep.BackColor = System.Drawing.Color.Transparent;
            this.txtAttCep.BorderColor = System.Drawing.Color.Gray;
            this.txtAttCep.BorderRadius = 5;
            this.txtAttCep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAttCep.DefaultText = "";
            this.txtAttCep.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAttCep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAttCep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAttCep.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAttCep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAttCep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttCep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAttCep.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAttCep.Location = new System.Drawing.Point(124, 202);
            this.txtAttCep.Name = "txtAttCep";
            this.txtAttCep.PasswordChar = '\0';
            this.txtAttCep.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAttCep.PlaceholderText = "00000-000";
            this.txtAttCep.SelectedText = "";
            this.txtAttCep.Size = new System.Drawing.Size(238, 36);
            this.txtAttCep.TabIndex = 87;
            // 
            // txtAttNumeroCasa
            // 
            this.txtAttNumeroCasa.BackColor = System.Drawing.Color.Transparent;
            this.txtAttNumeroCasa.BorderColor = System.Drawing.Color.Gray;
            this.txtAttNumeroCasa.BorderRadius = 5;
            this.txtAttNumeroCasa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAttNumeroCasa.DefaultText = "";
            this.txtAttNumeroCasa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAttNumeroCasa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAttNumeroCasa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAttNumeroCasa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAttNumeroCasa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAttNumeroCasa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttNumeroCasa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAttNumeroCasa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAttNumeroCasa.Location = new System.Drawing.Point(124, 244);
            this.txtAttNumeroCasa.Name = "txtAttNumeroCasa";
            this.txtAttNumeroCasa.PasswordChar = '\0';
            this.txtAttNumeroCasa.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAttNumeroCasa.PlaceholderText = "1234";
            this.txtAttNumeroCasa.SelectedText = "";
            this.txtAttNumeroCasa.Size = new System.Drawing.Size(238, 36);
            this.txtAttNumeroCasa.TabIndex = 88;
            // 
            // txtAttReferencia
            // 
            this.txtAttReferencia.BackColor = System.Drawing.Color.Transparent;
            this.txtAttReferencia.BorderColor = System.Drawing.Color.Gray;
            this.txtAttReferencia.BorderRadius = 5;
            this.txtAttReferencia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAttReferencia.DefaultText = "";
            this.txtAttReferencia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAttReferencia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAttReferencia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAttReferencia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAttReferencia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAttReferencia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAttReferencia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAttReferencia.Location = new System.Drawing.Point(124, 286);
            this.txtAttReferencia.Name = "txtAttReferencia";
            this.txtAttReferencia.PasswordChar = '\0';
            this.txtAttReferencia.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAttReferencia.PlaceholderText = "Casa, Apartamento...";
            this.txtAttReferencia.SelectedText = "";
            this.txtAttReferencia.Size = new System.Drawing.Size(238, 36);
            this.txtAttReferencia.TabIndex = 89;
            // 
            // labelAttCliente
            // 
            this.labelAttCliente.AutoSize = true;
            this.labelAttCliente.Location = new System.Drawing.Point(440, 105);
            this.labelAttCliente.Name = "labelAttCliente";
            this.labelAttCliente.Size = new System.Drawing.Size(29, 13);
            this.labelAttCliente.TabIndex = 90;
            this.labelAttCliente.Text = "label";
            // 
            // AtualizaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAttCliente);
            this.Controls.Add(this.txtAttReferencia);
            this.Controls.Add(this.txtAttNumeroCasa);
            this.Controls.Add(this.txtAttCep);
            this.Controls.Add(this.txtAttNumeroTel);
            this.Controls.Add(this.txtAttCpf);
            this.Controls.Add(this.txtAttCliente);
            this.Controls.Add(this.btnAttCliente);
            this.Controls.Add(this.btnCancelarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AtualizaCliente";
            this.Text = "AtualizaCliente";
            this.Load += new System.EventHandler(this.AtualizaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCancelarCliente;
        private Guna.UI2.WinForms.Guna2Button btnAttCliente;
        private Guna.UI2.WinForms.Guna2TextBox txtAttCliente;
        private Guna.UI2.WinForms.Guna2TextBox txtAttCpf;
        private Guna.UI2.WinForms.Guna2TextBox txtAttNumeroTel;
        private Guna.UI2.WinForms.Guna2TextBox txtAttCep;
        private Guna.UI2.WinForms.Guna2TextBox txtAttNumeroCasa;
        private Guna.UI2.WinForms.Guna2TextBox txtAttReferencia;
        private System.Windows.Forms.Label labelAttCliente;
    }
}