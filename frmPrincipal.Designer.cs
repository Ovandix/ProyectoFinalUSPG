namespace ProyectoFinalUSPG
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasEnlazadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doblementeEnlazadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circularSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaHashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listasEnlazadasToolStripMenuItem,
            this.doblementeEnlazadaToolStripMenuItem,
            this.circularSimpleToolStripMenuItem,
            this.colasToolStripMenuItem,
            this.pilasToolStripMenuItem,
            this.tablaHashToolStripMenuItem});
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.listasToolStripMenuItem.Text = "Listas";
            // 
            // listasEnlazadasToolStripMenuItem
            // 
            this.listasEnlazadasToolStripMenuItem.Name = "listasEnlazadasToolStripMenuItem";
            this.listasEnlazadasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.listasEnlazadasToolStripMenuItem.Text = "Enlazada simple";
            this.listasEnlazadasToolStripMenuItem.Click += new System.EventHandler(this.listasEnlazadasToolStripMenuItem_Click);
            // 
            // doblementeEnlazadaToolStripMenuItem
            // 
            this.doblementeEnlazadaToolStripMenuItem.Name = "doblementeEnlazadaToolStripMenuItem";
            this.doblementeEnlazadaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.doblementeEnlazadaToolStripMenuItem.Text = "Doblemente Enlazada";
            this.doblementeEnlazadaToolStripMenuItem.Click += new System.EventHandler(this.doblementeEnlazadaToolStripMenuItem_Click);
            // 
            // circularSimpleToolStripMenuItem
            // 
            this.circularSimpleToolStripMenuItem.Name = "circularSimpleToolStripMenuItem";
            this.circularSimpleToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.circularSimpleToolStripMenuItem.Text = "Circular simple";
            this.circularSimpleToolStripMenuItem.Click += new System.EventHandler(this.circularSimpleToolStripMenuItem_Click);
            // 
            // colasToolStripMenuItem
            // 
            this.colasToolStripMenuItem.Name = "colasToolStripMenuItem";
            this.colasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.colasToolStripMenuItem.Text = "Colas";
            this.colasToolStripMenuItem.Click += new System.EventHandler(this.colasToolStripMenuItem_Click);
            // 
            // pilasToolStripMenuItem
            // 
            this.pilasToolStripMenuItem.Name = "pilasToolStripMenuItem";
            this.pilasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.pilasToolStripMenuItem.Text = "Pilas";
            this.pilasToolStripMenuItem.Click += new System.EventHandler(this.pilasToolStripMenuItem_Click);
            // 
            // tablaHashToolStripMenuItem
            // 
            this.tablaHashToolStripMenuItem.Name = "tablaHashToolStripMenuItem";
            this.tablaHashToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.tablaHashToolStripMenuItem.Text = "TablaHash";
            this.tablaHashToolStripMenuItem.Click += new System.EventHandler(this.tablaHashToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem listasToolStripMenuItem;
        private ToolStripMenuItem listasEnlazadasToolStripMenuItem;
        private ToolStripMenuItem doblementeEnlazadaToolStripMenuItem;
        private ToolStripMenuItem circularSimpleToolStripMenuItem;
        private ToolStripMenuItem colasToolStripMenuItem;
        private ToolStripMenuItem pilasToolStripMenuItem;
        private ToolStripMenuItem tablaHashToolStripMenuItem;
    }
}