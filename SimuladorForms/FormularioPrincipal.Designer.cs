namespace SimuladorForms
{
    partial class FormularioPrincipal
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
            button2 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1130, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // hToolStripMenuItem
            // 
            hToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CargarFichero, guardarFicheroToolStripMenuItem, cargarSectorToolStripMenuItem, listarVuelosToolStripMenuItem });
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
            // listarVuelosToolStripMenuItem
            // 
            listarVuelosToolStripMenuItem.Name = "listarVuelosToolStripMenuItem";
            listarVuelosToolStripMenuItem.Size = new Size(310, 26);
            listarVuelosToolStripMenuItem.Text = "Listar Vuelos";
            listarVuelosToolStripMenuItem.Click += listarVuelosToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 444);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(880, 48);
            button1.Name = "button1";
            button1.Size = new Size(167, 60);
            button1.TabIndex = 2;
            button1.Text = "SIMULAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(880, 185);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 27);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(891, 162);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 4;
            label1.Text = "Tiempo en minutos";
            label1.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.Location = new Point(891, 397);
            button2.Name = "button2";
            button2.Size = new Size(137, 48);
            button2.TabIndex = 5;
            button2.Text = "REINICIAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 523);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormularioPrincipal";
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
        private Button button2;
    }
}
