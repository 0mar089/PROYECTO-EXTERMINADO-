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
            label3 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            button4 = new Button();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 444);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(684, 333);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 0;
            label3.Text = "Identificador:";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(880, 48);
            button1.Name = "button1";
            button1.Size = new Size(167, 60);
            button1.TabIndex = 2;
            button1.Text = "SIMULACIÓN AUTO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(880, 232);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 27);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(891, 209);
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
            button2.Location = new Point(903, 347);
            button2.Name = "button2";
            button2.Size = new Size(125, 39);
            button2.TabIndex = 5;
            button2.Text = "REINICIAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(880, 114);
            button3.Name = "button3";
            button3.Size = new Size(167, 60);
            button3.TabIndex = 6;
            button3.Text = "SIMULACIÓN MANUAL";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(880, 300);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 27);
            textBox2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(935, 277);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 8;
            label2.Text = "Ciclos";
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // button4
            // 
            button4.Location = new Point(903, 430);
            button4.Name = "button4";
            button4.Size = new Size(125, 37);
            button4.TabIndex = 9;
            button4.Text = "DESHACER";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(684, 367);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 1;
            label4.Text = "Capacidad: ";
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 523);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button3);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button button3;
        private TextBox textBox2;
        private Label label2;
        private System.Windows.Forms.Timer timer2;
        private Button button4;
        private Label label3;
        private Label label4;
    }
}
