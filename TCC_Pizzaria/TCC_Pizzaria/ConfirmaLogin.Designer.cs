namespace TCC_Pizzaria
{
    partial class ConfirmaLogin
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtCPF = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.entrar = new Guna.UI2.WinForms.Guna2Button();
            this.msgSenhaIncorreta = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtCPF
            // 
            this.txtCPF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCPF.DefaultText = "";
            this.txtCPF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCPF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCPF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCPF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCPF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCPF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCPF.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCPF.Location = new System.Drawing.Point(222, 61);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.PasswordChar = '\0';
            this.txtCPF.PlaceholderText = "";
            this.txtCPF.SelectedText = "";
            this.txtCPF.Size = new System.Drawing.Size(200, 36);
            this.txtCPF.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.DefaultText = "";
            this.txtSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenha.Location = new System.Drawing.Point(222, 140);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.PlaceholderText = "";
            this.txtSenha.SelectedText = "";
            this.txtSenha.Size = new System.Drawing.Size(200, 36);
            this.txtSenha.TabIndex = 1;
            // 
            // entrar
            // 
            this.entrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.entrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.entrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.entrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.entrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.entrar.ForeColor = System.Drawing.Color.White;
            this.entrar.Location = new System.Drawing.Point(233, 219);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(180, 45);
            this.entrar.TabIndex = 2;
            this.entrar.Text = "guna2Button1";
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // msgSenhaIncorreta
            // 
            this.msgSenhaIncorreta.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgSenhaIncorreta.Caption = null;
            this.msgSenhaIncorreta.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.msgSenhaIncorreta.Parent = null;
            this.msgSenhaIncorreta.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.msgSenhaIncorreta.Text = null;
            // 
            // ConfirmaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 320);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtCPF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmaLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GraficoPedido";
            this.Load += new System.EventHandler(this.GraficoPedido_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtCPF;
        private Guna.UI2.WinForms.Guna2Button entrar;
        private Guna.UI2.WinForms.Guna2MessageDialog msgSenhaIncorreta;
    }
}