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
            components = new System.ComponentModel.Container();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            hToolStripMenuItem = new ToolStripMenuItem();
            CargarFichero = new ToolStripMenuItem();
            guardarFicheroToolStripMenuItem = new ToolStripMenuItem();
            cargarSectorToolStripMenuItem = new ToolStripMenuItem();
            listarVuelosToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            saveFileDialog1 = new SaveFileDialog();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(989, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // hToolStripMenuItem
            // 
            hToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CargarFichero, guardarFicheroToolStripMenuItem, cargarSectorToolStripMenuItem, listarVuelosToolStripMenuItem });
            hToolStripMenuItem.Name = "hToolStripMenuItem";
            hToolStripMenuItem.Size = new Size(50, 20);
            hToolStripMenuItem.Text = "Menú";
            // 
            // CargarFichero
            // 
            CargarFichero.Name = "CargarFichero";
            CargarFichero.Size = new Size(247, 22);
            CargarFichero.Text = "Cargar del Fichero los aviones";
            CargarFichero.Click += CargarFichero_Click;
            // 
            // guardarFicheroToolStripMenuItem
            // 
            guardarFicheroToolStripMenuItem.Name = "guardarFicheroToolStripMenuItem";
            guardarFicheroToolStripMenuItem.Size = new Size(247, 22);
            guardarFicheroToolStripMenuItem.Text = "Guardar los aviones en el Fichero";
            guardarFicheroToolStripMenuItem.Click += guardarFicheroToolStripMenuItem_Click;
            // 
            // cargarSectorToolStripMenuItem
            // 
            cargarSectorToolStripMenuItem.Name = "cargarSectorToolStripMenuItem";
            cargarSectorToolStripMenuItem.Size = new Size(247, 22);
            cargarSectorToolStripMenuItem.Text = "Cargar del Fichero el Sector";
            cargarSectorToolStripMenuItem.Click += cargarSectorToolStripMenuItem_Click;
            // 
            // listarVuelosToolStripMenuItem
            // 
            listarVuelosToolStripMenuItem.Name = "listarVuelosToolStripMenuItem";
            listarVuelosToolStripMenuItem.Size = new Size(247, 22);
            listarVuelosToolStripMenuItem.Text = "Listar Vuelos";
            listarVuelosToolStripMenuItem.Click += listarVuelosToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(10, 23);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(710, 333);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(770, 88);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(146, 45);
            button1.TabIndex = 2;
            button1.Text = "SIMULAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(770, 238);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 23);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(780, 208);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 4;
            label1.Text = "Tiempo en segundos";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 392);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
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
        private ToolStripMenuItem listarVuelosToolStripMenuItem;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
