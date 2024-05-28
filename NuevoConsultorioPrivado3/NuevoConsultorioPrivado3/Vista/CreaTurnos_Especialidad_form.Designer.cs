namespace ConsultorioPrivado.Vista
{
    partial class CreaTurnos_Especialidad_form
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
            components = new System.ComponentModel.Container();
            cbx_Especialidad = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmb_Dia = new ComboBox();
            txt_Numero_Turno = new TextBox();
            label4 = new Label();
            cmb_Jornada = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            btn_Agregar = new Button();
            btn_Cancelar = new Button();
            label7 = new Label();
            cmb_Estado = new ComboBox();
            label5 = new Label();
            cmb_Doctor = new ComboBox();
            SuspendLayout();
            // 
            // cbx_Especialidad
            // 
            cbx_Especialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_Especialidad.FormattingEnabled = true;
            cbx_Especialidad.Location = new Point(486, 25);
            cbx_Especialidad.Name = "cbx_Especialidad";
            cbx_Especialidad.Size = new Size(250, 28);
            cbx_Especialidad.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 33);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 2;
            label1.Text = "Especialidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 91);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 4;
            label2.Text = "Cantidad de turnos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 136);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 6;
            label3.Text = "Dia";
            // 
            // cmb_Dia
            // 
            cmb_Dia.FormattingEnabled = true;
            cmb_Dia.Location = new Point(208, 128);
            cmb_Dia.Name = "cmb_Dia";
            cmb_Dia.Size = new Size(235, 28);
            cmb_Dia.TabIndex = 7;
            // 
            // txt_Numero_Turno
            // 
            txt_Numero_Turno.Location = new Point(208, 84);
            txt_Numero_Turno.Name = "txt_Numero_Turno";
            txt_Numero_Turno.Size = new Size(125, 27);
            txt_Numero_Turno.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 196);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 10;
            label4.Text = "Jornada";
            // 
            // cmb_Jornada
            // 
            cmb_Jornada.FormattingEnabled = true;
            cmb_Jornada.Location = new Point(208, 188);
            cmb_Jornada.Name = "cmb_Jornada";
            cmb_Jornada.Size = new Size(235, 28);
            cmb_Jornada.TabIndex = 11;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(197, 392);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(94, 29);
            btn_Agregar.TabIndex = 16;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(384, 392);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(94, 29);
            btn_Cancelar.TabIndex = 17;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Canelar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(111, 254);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 18;
            label7.Text = "Estado";
            // 
            // cmb_Estado
            // 
            cmb_Estado.FormattingEnabled = true;
            cmb_Estado.Items.AddRange(new object[] { "Disponible", "Ocupado", "Finalizado" });
            cmb_Estado.Location = new Point(208, 246);
            cmb_Estado.Name = "cmb_Estado";
            cmb_Estado.Size = new Size(235, 28);
            cmb_Estado.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 38);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 20;
            label5.Text = "Doctor";
            // 
            // cmb_Doctor
            // 
            cmb_Doctor.FormattingEnabled = true;
            cmb_Doctor.Location = new Point(143, 30);
            cmb_Doctor.Name = "cmb_Doctor";
            cmb_Doctor.Size = new Size(219, 28);
            cmb_Doctor.TabIndex = 21;
            // 
            // CreaTurnos_Especialidad_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 533);
            Controls.Add(cmb_Doctor);
            Controls.Add(label5);
            Controls.Add(cmb_Estado);
            Controls.Add(label7);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Agregar);
            Controls.Add(cmb_Jornada);
            Controls.Add(label4);
            Controls.Add(txt_Numero_Turno);
            Controls.Add(cmb_Dia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbx_Especialidad);
            Controls.Add(label1);
            Name = "CreaTurnos_Especialidad_form";
            Text = "CreaTurnos_Especialidad";
            Load += CreaTurnos_Especialidad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbx_Especialidad;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmb_Dia;
        private TextBox txt_Numero_Turno;
        private Label label4;
        private ComboBox cmb_Jornada;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Button btn_Agregar;
        private Button btn_Cancelar;
        private Label label7;
        private ComboBox cmb_Estado;
        private Label label5;
        private ComboBox cmb_Doctor;
    }
}