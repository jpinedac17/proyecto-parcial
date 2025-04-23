namespace proyecto_parcial
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
            label1 = new Label();
            label2 = new Label();
            textBoxNombre = new TextBox();
            textBoxNivel = new TextBox();
            label3 = new Label();
            textBoxId = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnSiguiente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 62);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 130);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Nivel:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(216, 80);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(253, 23);
            textBoxNombre.TabIndex = 2;
            // 
            // textBoxNivel
            // 
            textBoxNivel.Location = new Point(216, 148);
            textBoxNivel.Name = "textBoxNivel";
            textBoxNivel.Size = new Size(253, 23);
            textBoxNivel.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 200);
            label3.Name = "label3";
            label3.Size = new Size(294, 15);
            label3.TabIndex = 4;
            label3.Text = "Id (ingresar solo para actualizar o eliminar un jugador):";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(216, 218);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(253, 23);
            textBoxId.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(216, 358);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(325, 358);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(435, 358);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(736, 414);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(64, 35);
            btnSiguiente.TabIndex = 9;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSiguiente);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(textBoxId);
            Controls.Add(label3);
            Controls.Add(textBoxNivel);
            Controls.Add(textBoxNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Gestionar jugadores";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxNombre;
        private TextBox textBoxNivel;
        private Label label3;
        private TextBox textBoxId;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnSiguiente;
    }
}
