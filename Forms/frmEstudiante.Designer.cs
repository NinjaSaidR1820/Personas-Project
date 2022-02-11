namespace Forms
{
    partial class frmEstudiante
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
            this.lblCarnet = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUniversidad = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.lblNotas = new System.Windows.Forms.Label();
            this.lblCUM = new System.Windows.Forms.Label();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.lblHorasT = new System.Windows.Forms.Label();
            this.lblHoraC = new System.Windows.Forms.Label();
            this.dgvPersona = new System.Windows.Forms.DataGridView();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtNombreyApellido = new System.Windows.Forms.TextBox();
            this.txtUniversidad = new System.Windows.Forms.TextBox();
            this.cbNivelAcademico = new System.Windows.Forms.ComboBox();
            this.cbCarrera = new System.Windows.Forms.ComboBox();
            this.cbMateriasInscritas = new System.Windows.Forms.ComboBox();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.txtCUM = new System.Windows.Forms.TextBox();
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.txtHoraTotales = new System.Windows.Forms.TextBox();
            this.txtHoraCompletadas = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarnet.Location = new System.Drawing.Point(68, 113);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(100, 16);
            this.lblCarnet.TabIndex = 0;
            this.lblCarnet.Text = "Nº de Carnet:";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(34, 141);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(134, 16);
            this.lblNivel.TabIndex = 1;
            this.lblNivel.Text = "Nivel de Estudios:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(40, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(128, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre y Apellido:";
            // 
            // lblUniversidad
            // 
            this.lblUniversidad.AutoSize = true;
            this.lblUniversidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniversidad.Location = new System.Drawing.Point(81, 187);
            this.lblUniversidad.Name = "lblUniversidad";
            this.lblUniversidad.Size = new System.Drawing.Size(87, 15);
            this.lblUniversidad.TabIndex = 4;
            this.lblUniversidad.Text = "Universidad:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(104, 215);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(64, 16);
            this.lblCarrera.TabIndex = 5;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterias.Location = new System.Drawing.Point(34, 245);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(134, 16);
            this.lblMaterias.TabIndex = 6;
            this.lblMaterias.Text = "Materias Inscritas:";
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotas.Location = new System.Drawing.Point(115, 275);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(53, 16);
            this.lblNotas.TabIndex = 7;
            this.lblNotas.Text = "Notas:";
            // 
            // lblCUM
            // 
            this.lblCUM.AutoSize = true;
            this.lblCUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUM.Location = new System.Drawing.Point(123, 303);
            this.lblCUM.Name = "lblCUM";
            this.lblCUM.Size = new System.Drawing.Size(45, 16);
            this.lblCUM.TabIndex = 8;
            this.lblCUM.Text = "CUM:";
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyecto.Location = new System.Drawing.Point(7, 362);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(161, 16);
            this.lblProyecto.TabIndex = 9;
            this.lblProyecto.Text = "Nombre Del Proyecto:";
            // 
            // lblHorasT
            // 
            this.lblHorasT.AutoSize = true;
            this.lblHorasT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasT.Location = new System.Drawing.Point(57, 390);
            this.lblHorasT.Name = "lblHorasT";
            this.lblHorasT.Size = new System.Drawing.Size(111, 16);
            this.lblHorasT.TabIndex = 10;
            this.lblHorasT.Text = "Horas Totales:";
            // 
            // lblHoraC
            // 
            this.lblHoraC.AutoSize = true;
            this.lblHoraC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraC.Location = new System.Drawing.Point(18, 418);
            this.lblHoraC.Name = "lblHoraC";
            this.lblHoraC.Size = new System.Drawing.Size(150, 16);
            this.lblHoraC.TabIndex = 11;
            this.lblHoraC.Text = "Horas Completadas:";
            // 
            // dgvPersona
            // 
            this.dgvPersona.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersona.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvPersona.Location = new System.Drawing.Point(286, 12);
            this.dgvPersona.Name = "dgvPersona";
            this.dgvPersona.Size = new System.Drawing.Size(596, 345);
            this.dgvPersona.TabIndex = 12;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnet.Location = new System.Drawing.Point(180, 110);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(100, 22);
            this.txtCarnet.TabIndex = 13;
            // 
            // txtNombreyApellido
            // 
            this.txtNombreyApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreyApellido.Location = new System.Drawing.Point(180, 12);
            this.txtNombreyApellido.Name = "txtNombreyApellido";
            this.txtNombreyApellido.Size = new System.Drawing.Size(100, 22);
            this.txtNombreyApellido.TabIndex = 14;
            // 
            // txtUniversidad
            // 
            this.txtUniversidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUniversidad.Location = new System.Drawing.Point(180, 184);
            this.txtUniversidad.Name = "txtUniversidad";
            this.txtUniversidad.Size = new System.Drawing.Size(100, 22);
            this.txtUniversidad.TabIndex = 16;
            // 
            // cbNivelAcademico
            // 
            this.cbNivelAcademico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivelAcademico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivelAcademico.FormattingEnabled = true;
            this.cbNivelAcademico.Items.AddRange(new object[] {
            "Basico",
            "Intermedio",
            "Avanzado"});
            this.cbNivelAcademico.Location = new System.Drawing.Point(180, 138);
            this.cbNivelAcademico.Name = "cbNivelAcademico";
            this.cbNivelAcademico.Size = new System.Drawing.Size(100, 24);
            this.cbNivelAcademico.TabIndex = 17;
            // 
            // cbCarrera
            // 
            this.cbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarrera.FormattingEnabled = true;
            this.cbCarrera.Items.AddRange(new object[] {
            "Ingenieria",
            "Medicina",
            "Arquitectura"});
            this.cbCarrera.Location = new System.Drawing.Point(180, 212);
            this.cbCarrera.Name = "cbCarrera";
            this.cbCarrera.Size = new System.Drawing.Size(100, 24);
            this.cbCarrera.TabIndex = 18;
            // 
            // cbMateriasInscritas
            // 
            this.cbMateriasInscritas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateriasInscritas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMateriasInscritas.FormattingEnabled = true;
            this.cbMateriasInscritas.Items.AddRange(new object[] {
            "Calculo",
            "Ingles",
            "Programacion"});
            this.cbMateriasInscritas.Location = new System.Drawing.Point(180, 242);
            this.cbMateriasInscritas.Name = "cbMateriasInscritas";
            this.cbMateriasInscritas.Size = new System.Drawing.Size(100, 24);
            this.cbMateriasInscritas.TabIndex = 19;
            // 
            // txtNotas
            // 
            this.txtNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotas.Location = new System.Drawing.Point(180, 272);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(100, 22);
            this.txtNotas.TabIndex = 20;
            // 
            // txtCUM
            // 
            this.txtCUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCUM.Location = new System.Drawing.Point(180, 300);
            this.txtCUM.Name = "txtCUM";
            this.txtCUM.Size = new System.Drawing.Size(100, 22);
            this.txtCUM.TabIndex = 21;
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProyecto.Location = new System.Drawing.Point(180, 356);
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(100, 22);
            this.txtNombreProyecto.TabIndex = 22;
            // 
            // txtHoraTotales
            // 
            this.txtHoraTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraTotales.Location = new System.Drawing.Point(180, 384);
            this.txtHoraTotales.Name = "txtHoraTotales";
            this.txtHoraTotales.Size = new System.Drawing.Size(100, 22);
            this.txtHoraTotales.TabIndex = 23;
            // 
            // txtHoraCompletadas
            // 
            this.txtHoraCompletadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraCompletadas.Location = new System.Drawing.Point(180, 412);
            this.txtHoraCompletadas.Name = "txtHoraCompletadas";
            this.txtHoraCompletadas.Size = new System.Drawing.Size(100, 22);
            this.txtHoraCompletadas.TabIndex = 24;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Green;
            this.btnRegistrar.Location = new System.Drawing.Point(74, 482);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 30);
            this.btnRegistrar.TabIndex = 25;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Blue;
            this.btnSalir.Location = new System.Drawing.Point(180, 482);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(119, 40);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(49, 16);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(180, 40);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 22);
            this.txtEdad.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Segs:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox1.Location = new System.Drawing.Point(180, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 28;
            // 
            // frmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 525);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtHoraCompletadas);
            this.Controls.Add(this.txtHoraTotales);
            this.Controls.Add(this.txtNombreProyecto);
            this.Controls.Add(this.txtCUM);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.cbMateriasInscritas);
            this.Controls.Add(this.cbCarrera);
            this.Controls.Add(this.cbNivelAcademico);
            this.Controls.Add(this.txtUniversidad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombreyApellido);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.dgvPersona);
            this.Controls.Add(this.lblHoraC);
            this.Controls.Add(this.lblHorasT);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.lblCUM);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.lblMaterias);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblUniversidad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblCarnet);
            this.Name = "frmEstudiante";
            this.Text = "Estudiantes";
            this.Load += new System.EventHandler(this.frmEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUniversidad;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.Label lblCUM;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.Label lblHorasT;
        private System.Windows.Forms.Label lblHoraC;
        private System.Windows.Forms.DataGridView dgvPersona;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtNombreyApellido;
        private System.Windows.Forms.TextBox txtUniversidad;
        private System.Windows.Forms.ComboBox cbNivelAcademico;
        private System.Windows.Forms.ComboBox cbCarrera;
        private System.Windows.Forms.ComboBox cbMateriasInscritas;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.TextBox txtCUM;
        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.TextBox txtHoraTotales;
        private System.Windows.Forms.TextBox txtHoraCompletadas;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

