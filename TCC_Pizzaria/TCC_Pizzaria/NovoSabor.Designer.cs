namespace TCC_Pizzaria
{
    partial class NovoSabor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSabor = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnEntrar = new Guna.UI2.WinForms.Guna2Button();
            this.msgErroCampoBranco = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgSucessoCadastro = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgErroCadastro = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sabor";
            // 
            // txtSabor
            // 
            this.txtSabor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSabor.DefaultText = "";
            this.txtSabor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSabor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSabor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSabor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSabor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSabor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSabor.ForeColor = System.Drawing.Color.Gray;
            this.txtSabor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSabor.Location = new System.Drawing.Point(52, 54);
            this.txtSabor.Name = "txtSabor";
            this.txtSabor.PasswordChar = '\0';
            this.txtSabor.PlaceholderText = "";
            this.txtSabor.SelectedText = "";
            this.txtSabor.Size = new System.Drawing.Size(266, 41);
            this.txtSabor.TabIndex = 10;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(52, 143);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(130, 45);
            this.guna2Button1.TabIndex = 13;
            this.guna2Button1.Text = "Cancelar";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BorderRadius = 5;
            this.btnEntrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEntrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEntrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEntrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEntrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnEntrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(188, 143);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(130, 45);
            this.btnEntrar.TabIndex = 12;
            this.btnEntrar.Text = "Cadastrar";
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // msgErroCampoBranco
            // 
            this.msgErroCampoBranco.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgErroCampoBranco.Caption = null;
            this.msgErroCampoBranco.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.msgErroCampoBranco.Parent = null;
            this.msgErroCampoBranco.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.msgErroCampoBranco.Text = null;
            // 
            // msgSucessoCadastro
            // 
            this.msgSucessoCadastro.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgSucessoCadastro.Caption = null;
            this.msgSucessoCadastro.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.msgSucessoCadastro.Parent = null;
            this.msgSucessoCadastro.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.msgSucessoCadastro.Text = null;
            // 
            // msgErroCadastro
            // 
            this.msgErroCadastro.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgErroCadastro.Caption = null;
            this.msgErroCadastro.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.msgErroCadastro.Parent = null;
            this.msgErroCadastro.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.msgErroCadastro.Text = null;
            // 
            // NovoSabor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 200);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSabor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NovoSabor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovoSabor";
            this.Load += new System.EventHandler(this.NovoSabor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSabor;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnEntrar;
        private Guna.UI2.WinForms.Guna2MessageDialog msgErroCampoBranco;
        private Guna.UI2.WinForms.Guna2MessageDialog msgSucessoCadastro;
        private Guna.UI2.WinForms.Guna2MessageDialog msgErroCadastro;
    }
}