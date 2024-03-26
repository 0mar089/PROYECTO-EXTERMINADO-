namespace SimuladorForms
{
    partial class Form1
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
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            hToolStripMenuItem = new ToolStripMenuItem();
            CargarFichero = new ToolStripMenuItem();
            guardarFicheroToolStripMenuItem = new ToolStripMenuItem();
            cargarSectorToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1130, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // hToolStripMenuItem
            // 
            hToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CargarFichero, guardarFicheroToolStripMenuItem, cargarSectorToolStripMenuItem });
            hToolStripMenuItem.Name = "hToolStripMenuItem";
            hToolStripMenuItem.Size = new Size(60, 24);
            hToolStripMenuItem.Text = "Menú";
            // 
            // CargarFichero
            // 
            CargarFichero.Name = "CargarFichero";
            CargarFichero.Size = new Size(310, 26);
            CargarFichero.Text = "Cargar del Fichero los aviones";
            CargarFichero.Click += CargarFichero_Click;
            // 
            // guardarFicheroToolStripMenuItem
            // 
            guardarFicheroToolStripMenuItem.Name = "guardarFicheroToolStripMenuItem";
            guardarFicheroToolStripMenuItem.Size = new Size(310, 26);
            guardarFicheroToolStripMenuItem.Text = "Guardar los aviones en el Fichero";
            guardarFicheroToolStripMenuItem.Click += guardarFicheroToolStripMenuItem_Click;
            // 
            // cargarSectorToolStripMenuItem
            // 
            cargarSectorToolStripMenuItem.Name = "cargarSectorToolStripMenuItem";
            cargarSectorToolStripMenuItem.Size = new Size(310, 26);
            cargarSectorToolStripMenuItem.Text = "Cargar del Fichero el Sector";
            cargarSectorToolStripMenuItem.Click += cargarSectorToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 444);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 523);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "FormPrincipal";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hToolStripMenuItem;
        private ToolStripMenuItem CargarFichero;
        private Panel panel1;
        private ToolStripMenuItem guardarFicheroToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem cargarSectorToolStripMenuItem;
    }
}
