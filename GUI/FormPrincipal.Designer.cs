namespace GUI
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amigosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desejosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarDesejoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarDesejosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.desejosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.amigosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // amigosToolStripMenuItem
            // 
            this.amigosToolStripMenuItem.Name = "amigosToolStripMenuItem";
            this.amigosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.amigosToolStripMenuItem.Text = "Amigos";
            // 
            // desejosToolStripMenuItem
            // 
            this.desejosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitarDesejoToolStripMenuItem,
            this.consultarDesejosToolStripMenuItem});
            this.desejosToolStripMenuItem.Name = "desejosToolStripMenuItem";
            this.desejosToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.desejosToolStripMenuItem.Text = "Desejos";
            // 
            // solicitarDesejoToolStripMenuItem
            // 
            this.solicitarDesejoToolStripMenuItem.Name = "solicitarDesejoToolStripMenuItem";
            this.solicitarDesejoToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.solicitarDesejoToolStripMenuItem.Text = "Solicitar Desejo";
            this.solicitarDesejoToolStripMenuItem.Click += new System.EventHandler(this.solicitarDesejoToolStripMenuItem_Click);
            // 
            // consultarDesejosToolStripMenuItem
            // 
            this.consultarDesejosToolStripMenuItem.Name = "consultarDesejosToolStripMenuItem";
            this.consultarDesejosToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.consultarDesejosToolStripMenuItem.Text = "Consultar Desejos Solicitados";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Lista de Desejos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amigosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desejosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarDesejoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarDesejosToolStripMenuItem;
    }
}

