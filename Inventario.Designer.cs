namespace proyecto_parcial
{
    partial class Inventario
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
            cmbJugadores = new ComboBox();
            btnFiltrar = new Button();
            dataGridView1 = new DataGridView();
            btnExportarCsv = new Button();
            btnSiguiente = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbJugadores
            // 
            cmbJugadores.FormattingEnabled = true;
            cmbJugadores.Location = new Point(268, 31);
            cmbJugadores.Name = "cmbJugadores";
            cmbJugadores.Size = new Size(211, 23);
            cmbJugadores.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(317, 69);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(112, 27);
            btnFiltrar.TabIndex = 1;
            btnFiltrar.Text = "Ver inventario";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(174, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(423, 261);
            dataGridView1.TabIndex = 2;
            // 
            // btnExportarCsv
            // 
            btnExportarCsv.Location = new Point(329, 398);
            btnExportarCsv.Name = "btnExportarCsv";
            btnExportarCsv.Size = new Size(110, 23);
            btnExportarCsv.TabIndex = 3;
            btnExportarCsv.Text = "Exportar CSV";
            btnExportarCsv.UseVisualStyleBackColor = true;
            btnExportarCsv.Click += btnExportarCsv_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(735, 414);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(64, 35);
            btnSiguiente.TabIndex = 10;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 414);
            button1.Name = "button1";
            button1.Size = new Size(64, 35);
            button1.TabIndex = 12;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnSiguiente);
            Controls.Add(btnExportarCsv);
            Controls.Add(dataGridView1);
            Controls.Add(btnFiltrar);
            Controls.Add(cmbJugadores);
            Name = "Inventario";
            Text = "Inventario";
            Load += Inventario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbJugadores;
        private Button btnFiltrar;
        private DataGridView dataGridView1;
        private Button btnExportarCsv;
        private Button btnSiguiente;
        private Button button1;
    }
}