namespace TCC_Pizzaria
{
    partial class FormLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMinimized = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonClose.BackgroundImage = global::TCC_Pizzaria.Properties.Resources.cross__1_;
            resources.ApplyResources(this.buttonClose, "buttonClose");
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonMinimized
            // 
            this.buttonMinimized.BackgroundImage = global::TCC_Pizzaria.Properties.Resources.minimizar__1_;
            resources.ApplyResources(this.buttonMinimized, "buttonMinimized");
            this.buttonMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimized.ForeColor = System.Drawing.Color.White;
            this.buttonMinimized.Name = "buttonMinimized";
            this.buttonMinimized.UseVisualStyleBackColor = true;
            this.buttonMinimized.Click += new System.EventHandler(this.buttonMinimized_Click);
            // 
            // FormLogin
            // 
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.buttonMinimized);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimized;
    }
}

