namespace Form_unidad_4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDePersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversorDeDivisasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serieDeFibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDePersonasToolStripMenuItem,
            this.conversorDeDivisasToolStripMenuItem,
            this.serieDeFibonacciToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // registroDePersonasToolStripMenuItem
            // 
            this.registroDePersonasToolStripMenuItem.Name = "registroDePersonasToolStripMenuItem";
            this.registroDePersonasToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registroDePersonasToolStripMenuItem.Text = "Registro de Personas";
            this.registroDePersonasToolStripMenuItem.Click += new System.EventHandler(this.registroDePersonasToolStripMenuItem_Click);
            // 
            // conversorDeDivisasToolStripMenuItem
            // 
            this.conversorDeDivisasToolStripMenuItem.Name = "conversorDeDivisasToolStripMenuItem";
            this.conversorDeDivisasToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.conversorDeDivisasToolStripMenuItem.Text = "Conversor de Divisas";
            this.conversorDeDivisasToolStripMenuItem.Click += new System.EventHandler(this.conversorDeDivisasToolStripMenuItem_Click);
            // 
            // serieDeFibonacciToolStripMenuItem
            // 
            this.serieDeFibonacciToolStripMenuItem.Name = "serieDeFibonacciToolStripMenuItem";
            this.serieDeFibonacciToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.serieDeFibonacciToolStripMenuItem.Text = "Serie de Fibonacci";
            this.serieDeFibonacciToolStripMenuItem.Click += new System.EventHandler(this.serieDeFibonacciToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sistema Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDePersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversorDeDivisasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serieDeFibonacciToolStripMenuItem;
    }
}

