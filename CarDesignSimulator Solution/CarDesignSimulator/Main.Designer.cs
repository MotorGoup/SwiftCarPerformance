namespace CarDesignSimulator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modoAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerraSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(626, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoAdminToolStripMenuItem,
            this.modoUsuarioToolStripMenuItem,
            this.actualizarDatosToolStripMenuItem,
            this.eliminarDatosToolStripMenuItem,
            this.cerraSistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 238);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(626, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modoAdminToolStripMenuItem
            // 
            this.modoAdminToolStripMenuItem.Name = "modoAdminToolStripMenuItem";
            this.modoAdminToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.modoAdminToolStripMenuItem.Text = "Modo Admin";
            this.modoAdminToolStripMenuItem.Click += new System.EventHandler(this.modoAdminToolStripMenuItem_Click);
            // 
            // modoUsuarioToolStripMenuItem
            // 
            this.modoUsuarioToolStripMenuItem.Name = "modoUsuarioToolStripMenuItem";
            this.modoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.modoUsuarioToolStripMenuItem.Text = "Modo Usuario";
            this.modoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modoUsuarioToolStripMenuItem_Click);
            // 
            // actualizarDatosToolStripMenuItem
            // 
            this.actualizarDatosToolStripMenuItem.Name = "actualizarDatosToolStripMenuItem";
            this.actualizarDatosToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.actualizarDatosToolStripMenuItem.Text = "Actualizar Datos";
            // 
            // eliminarDatosToolStripMenuItem
            // 
            this.eliminarDatosToolStripMenuItem.Name = "eliminarDatosToolStripMenuItem";
            this.eliminarDatosToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.eliminarDatosToolStripMenuItem.Text = "Eliminar Datos";
            // 
            // cerraSistemaToolStripMenuItem
            // 
            this.cerraSistemaToolStripMenuItem.Name = "cerraSistemaToolStripMenuItem";
            this.cerraSistemaToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.cerraSistemaToolStripMenuItem.Text = "Cerra Sistema";
            this.cerraSistemaToolStripMenuItem.Click += new System.EventHandler(this.cerraSistemaToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 262);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "AutoMaK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modoAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerraSistemaToolStripMenuItem;
    }
}