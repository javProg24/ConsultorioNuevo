namespace ConsultorioPrivado.Vista
{
    partial class Asignar_Turno_form
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
            label1 = new Label();
            cbx_Especialidad = new ComboBox();
            label2 = new Label();
            txt_Cedula = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_Direccion = new TextBox();
            txt_Telefono = new TextBox();
            txtt_Correo = new TextBox();
            txt_Apelidos = new TextBox();
            txt_Nombres = new TextBox();
            btn_Buscar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(426, 178);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Especialidad";
            // 
            // cbx_Especialidad
            // 
            cbx_Especialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_Especialidad.FormattingEnabled = true;
            cbx_Especialidad.Location = new Point(539, 171);
            cbx_Especialidad.Name = "cbx_Especialidad";
            cbx_Especialidad.Size = new Size(250, 28);
            cbx_Especialidad.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 38);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "Cedula";
            // 
            // txt_Cedula
            // 
            txt_Cedula.Location = new Point(137, 35);
            txt_Cedula.Name = "txt_Cedula";
            txt_Cedula.Size = new Size(250, 27);
            txt_Cedula.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 85);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(416, 85);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 5;
            label4.Text = "Apelidos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 131);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 6;
            label5.Text = "Correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(417, 127);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 7;
            label6.Text = "Telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 178);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 8;
            label7.Text = "Direccion";
            // 
            // txt_Direccion
            // 
            txt_Direccion.Location = new Point(137, 171);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(250, 27);
            txt_Direccion.TabIndex = 10;
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(504, 124);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(250, 27);
            txt_Telefono.TabIndex = 11;
            // 
            // txtt_Correo
            // 
            txtt_Correo.Location = new Point(137, 124);
            txtt_Correo.Name = "txtt_Correo";
            txtt_Correo.Size = new Size(250, 27);
            txtt_Correo.TabIndex = 12;
            // 
            // txt_Apelidos
            // 
            txt_Apelidos.Location = new Point(504, 78);
            txt_Apelidos.Name = "txt_Apelidos";
            txt_Apelidos.Size = new Size(250, 27);
            txt_Apelidos.TabIndex = 13;
            // 
            // txt_Nombres
            // 
            txt_Nombres.Location = new Point(137, 78);
            txt_Nombres.Name = "txt_Nombres";
            txt_Nombres.Size = new Size(250, 27);
            txt_Nombres.TabIndex = 14;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(416, 33);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(150, 29);
            btn_Buscar.TabIndex = 15;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Asignar_Turno_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 583);
            Controls.Add(btn_Buscar);
            Controls.Add(txt_Nombres);
            Controls.Add(txt_Apelidos);
            Controls.Add(txtt_Correo);
            Controls.Add(txt_Telefono);
            Controls.Add(txt_Direccion);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_Cedula);
            Controls.Add(label2);
            Controls.Add(cbx_Especialidad);
            Controls.Add(label1);
            Name = "Asignar_Turno_form";
            Text = "Asignar Turno";
            Load += TurnoEspecialidad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbx_Especialidad;
        private Label label2;
        private TextBox txt_Cedula;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_Direccion;
        private TextBox txt_Telefono;
        private TextBox txtt_Correo;
        private TextBox txt_Apelidos;
        private TextBox txt_Nombres;
        private Button btn_Buscar;
    }
}