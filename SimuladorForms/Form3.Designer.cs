namespace SimuladorForms
{
    partial class Form3
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
            matriz = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)matriz).BeginInit();
            SuspendLayout();
            // 
            // matriz
            // 
            matriz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matriz.Location = new Point(99, 39);
            matriz.Name = "matriz";
            matriz.RowHeadersWidth = 51;
            matriz.RowTemplate.Height = 29;
            matriz.Size = new Size(549, 128);
            matriz.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(matriz);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)matriz).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView matriz;
    }
}