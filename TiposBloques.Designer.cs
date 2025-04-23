namespace proyecto_parcial
{
    partial class TiposBloques
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
            comboBoxBloques = new ComboBox();
            btnFiltral = new Button();
            Lista_Bloques = new ListBox();
            btnSiguiente = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBoxBloques
            // 
            comboBoxBloques.FormattingEnabled = true;
            comboBoxBloques.Location = new Point(239, 38);
            comboBoxBloques.Name = "comboBoxBloques";
            comboBoxBloques.Size = new Size(259, 23);
            comboBoxBloques.TabIndex = 0;
            // 
            // btnFiltral
            // 
            btnFiltral.Location = new Point(333, 67);
            btnFiltral.Name = "btnFiltral";
            btnFiltral.Size = new Size(82, 26);
            btnFiltral.TabIndex = 1;
            btnFiltral.Text = "Filtrar";
            btnFiltral.UseVisualStyleBackColor = true;
            btnFiltral.Click += btnFiltral_Click;
            // 
            // Lista_Bloques
            // 
            Lista_Bloques.FormattingEnabled = true;
            Lista_Bloques.Location = new Point(215, 116);
            Lista_Bloques.Name = "Lista_Bloques";
            Lista_Bloques.Size = new Size(310, 199);
            Lista_Bloques.TabIndex = 2;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(735, 415);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(64, 35);
            btnSiguiente.TabIndex = 11;
            btnSiguiente.Text = "Cerrar";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 415);
            button1.Name = "button1";
            button1.Size = new Size(64, 35);
            button1.TabIndex = 13;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TiposBloques
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnSiguiente);
            Controls.Add(Lista_Bloques);
            Controls.Add(btnFiltral);
            Controls.Add(comboBoxBloques);
            Name = "TiposBloques";
            Text = "TiposBloques";
            Load += TiposBloques_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxBloques;
        private Button btnFiltral;
        private ListBox Lista_Bloques;
        private Button btnSiguiente;
        private Button button1;
    }
}