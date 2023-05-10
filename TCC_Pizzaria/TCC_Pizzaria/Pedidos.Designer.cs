namespace TCC_Pizzaria
{
    partial class Pedidos
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
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlPedidos = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Button7
            // 
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.guna2Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button7.ForeColor = System.Drawing.Color.Black;
            this.guna2Button7.Location = new System.Drawing.Point(666, 0);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(447, 49);
            this.guna2Button7.TabIndex = 1;
            this.guna2Button7.Text = "Lista de pedidos";
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // guna2Button6
            // 
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.guna2Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.Black;
            this.guna2Button6.Location = new System.Drawing.Point(210, 0);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(458, 49);
            this.guna2Button6.TabIndex = 0;
            this.guna2Button6.Text = " + Novo Pedido";
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2Button7);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Button6);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(-213, 2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1335, 53);
            this.guna2ShadowPanel1.TabIndex = 1;
            // 
            // pnlPedidos
            // 
            this.pnlPedidos.Location = new System.Drawing.Point(-3, 55);
            this.pnlPedidos.Name = "pnlPedidos";
            this.pnlPedidos.Size = new System.Drawing.Size(903, 515);
            this.pnlPedidos.TabIndex = 2;
            this.pnlPedidos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPedidos_Paint);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 572);
            this.Controls.Add(this.pnlPedidos);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Panel pnlPedidos;
    }
}