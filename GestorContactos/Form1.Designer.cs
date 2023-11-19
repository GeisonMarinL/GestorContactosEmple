namespace GestorContactos
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            picFotografia = new PictureBox();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnBorrar = new Button();
            btnLimpiar = new Button();
            txtNumeroOficina = new TextBox();
            txtTelefonoMovil = new TextBox();
            txtCargo = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtDocumento = new TextBox();
            btnExaminarImg = new Button();
            ((System.ComponentModel.ISupportInitialize)picFotografia).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(327, 48);
            label1.Name = "label1";
            label1.Size = new Size(126, 30);
            label1.TabIndex = 0;
            label1.Text = "Documento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(327, 94);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(327, 142);
            label3.Name = "label3";
            label3.Size = new Size(93, 30);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(327, 192);
            label4.Name = "label4";
            label4.Size = new Size(72, 30);
            label4.TabIndex = 3;
            label4.Text = "Cargo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(327, 237);
            label5.Name = "label5";
            label5.Size = new Size(169, 30);
            label5.TabIndex = 4;
            label5.Text = "Numero-Oficina";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(327, 286);
            label6.Name = "label6";
            label6.Size = new Size(160, 30);
            label6.TabIndex = 5;
            label6.Text = "Telefono-Movil";
            // 
            // picFotografia
            // 
            picFotografia.BorderStyle = BorderStyle.FixedSingle;
            picFotografia.Location = new Point(54, 54);
            picFotografia.Margin = new Padding(3, 2, 3, 2);
            picFotografia.Name = "picFotografia";
            picFotografia.Size = new Size(210, 262);
            picFotografia.SizeMode = PictureBoxSizeMode.StretchImage;
            picFotografia.TabIndex = 6;
            picFotografia.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Image = Properties.Resources.Guardar;
            btnGuardar.Location = new Point(300, 338);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 42);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.Image = Properties.Resources.Actualiza_r;
            btnActualizar.Location = new Point(435, 338);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(134, 42);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Cursor = Cursors.Hand;
            btnBorrar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrar.Image = Properties.Resources.Borrar;
            btnBorrar.Location = new Point(583, 338);
            btnBorrar.Margin = new Padding(3, 2, 3, 2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(102, 42);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "Borrar";
            btnBorrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Image = Properties.Resources.Limpiar;
            btnLimpiar.Location = new Point(707, 338);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(113, 42);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtNumeroOficina
            // 
            txtNumeroOficina.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumeroOficina.Location = new Point(540, 236);
            txtNumeroOficina.Margin = new Padding(3, 2, 3, 2);
            txtNumeroOficina.Name = "txtNumeroOficina";
            txtNumeroOficina.Size = new Size(280, 36);
            txtNumeroOficina.TabIndex = 12;
            // 
            // txtTelefonoMovil
            // 
            txtTelefonoMovil.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefonoMovil.Location = new Point(540, 283);
            txtTelefonoMovil.Margin = new Padding(3, 2, 3, 2);
            txtTelefonoMovil.Name = "txtTelefonoMovil";
            txtTelefonoMovil.Size = new Size(280, 36);
            txtTelefonoMovil.TabIndex = 13;
            // 
            // txtCargo
            // 
            txtCargo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtCargo.Location = new Point(540, 187);
            txtCargo.Margin = new Padding(3, 2, 3, 2);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(280, 36);
            txtCargo.TabIndex = 14;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(540, 137);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(280, 36);
            txtApellido.TabIndex = 15;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(540, 89);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(280, 36);
            txtNombre.TabIndex = 16;
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocumento.Location = new Point(540, 43);
            txtDocumento.Margin = new Padding(3, 2, 3, 2);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(280, 36);
            txtDocumento.TabIndex = 17;
            // 
            // btnExaminarImg
            // 
            btnExaminarImg.Cursor = Cursors.Hand;
            btnExaminarImg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExaminarImg.Image = Properties.Resources.Examinar;
            btnExaminarImg.Location = new Point(92, 338);
            btnExaminarImg.Margin = new Padding(3, 2, 3, 2);
            btnExaminarImg.Name = "btnExaminarImg";
            btnExaminarImg.Size = new Size(124, 42);
            btnExaminarImg.TabIndex = 18;
            btnExaminarImg.Text = "Examinar";
            btnExaminarImg.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExaminarImg.UseVisualStyleBackColor = true;
            btnExaminarImg.Click += btnExaminarImg_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 395);
            Controls.Add(btnExaminarImg);
            Controls.Add(txtDocumento);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtCargo);
            Controls.Add(txtTelefonoMovil);
            Controls.Add(txtNumeroOficina);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBorrar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(picFotografia);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Datos Empleados";
            ((System.ComponentModel.ISupportInitialize)picFotografia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox picFotografia;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnBorrar;
        private Button btnLimpiar;
        private TextBox txtNumeroOficina;
        private TextBox txtTelefonoMovil;
        private TextBox txtCargo;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtDocumento;
        private Button btnExaminarImg;
    }
}