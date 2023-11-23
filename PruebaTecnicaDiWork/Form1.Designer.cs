namespace PruebaTecnicaDiWork
{
    partial class frmPresupuestador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pCliente = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pAuto = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numCantP = new System.Windows.Forms.NumericUpDown();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.pMoto = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.nCilindrada = new System.Windows.Forms.NumericUpDown();
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.chkMoto = new System.Windows.Forms.CheckBox();
            this.cbxRepuestos = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pDesperfecto = new System.Windows.Forms.Panel();
            this.nManoDeObra = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarDesp = new System.Windows.Forms.Button();
            this.nTiempo = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dgDesperfectos = new System.Windows.Forms.DataGridView();
            this.dgRepuestos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pCliente.SuspendLayout();
            this.pAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantP)).BeginInit();
            this.pMoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCilindrada)).BeginInit();
            this.pDesperfecto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nManoDeObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDesperfectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRepuestos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pCliente
            // 
            this.pCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCliente.Controls.Add(this.label6);
            this.pCliente.Controls.Add(this.label4);
            this.pCliente.Controls.Add(this.label3);
            this.pCliente.Controls.Add(this.txtEmail);
            this.pCliente.Controls.Add(this.txtApellido);
            this.pCliente.Controls.Add(this.txtNom);
            this.pCliente.Controls.Add(this.label2);
            this.pCliente.Location = new System.Drawing.Point(29, 44);
            this.pCliente.Name = "pCliente";
            this.pCliente.Size = new System.Drawing.Size(868, 70);
            this.pCliente.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(446, 32);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(260, 32);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(128, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(83, 32);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Datos Cliente";
            // 
            // pAuto
            // 
            this.pAuto.Controls.Add(this.label9);
            this.pAuto.Controls.Add(this.label8);
            this.pAuto.Controls.Add(this.numCantP);
            this.pAuto.Controls.Add(this.cbxTipo);
            this.pAuto.Location = new System.Drawing.Point(5, 90);
            this.pAuto.Name = "pAuto";
            this.pAuto.Size = new System.Drawing.Size(529, 49);
            this.pAuto.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(274, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Cantidad de puertas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tipo de automovil";
            // 
            // numCantP
            // 
            this.numCantP.Location = new System.Drawing.Point(437, 12);
            this.numCantP.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCantP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantP.Name = "numCantP";
            this.numCantP.Size = new System.Drawing.Size(61, 20);
            this.numCantP.TabIndex = 11;
            this.numCantP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(140, 15);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(119, 21);
            this.cbxTipo.TabIndex = 10;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // pMoto
            // 
            this.pMoto.Controls.Add(this.label10);
            this.pMoto.Controls.Add(this.nCilindrada);
            this.pMoto.Location = new System.Drawing.Point(585, 212);
            this.pMoto.Name = "pMoto";
            this.pMoto.Size = new System.Drawing.Size(303, 49);
            this.pMoto.TabIndex = 3;
            this.pMoto.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Cilindrada";
            // 
            // nCilindrada
            // 
            this.nCilindrada.Location = new System.Drawing.Point(110, 16);
            this.nCilindrada.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nCilindrada.Name = "nCilindrada";
            this.nCilindrada.Size = new System.Drawing.Size(120, 20);
            this.nCilindrada.TabIndex = 12;
            this.nCilindrada.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkAuto
            // 
            this.chkAuto.AutoCheck = false;
            this.chkAuto.AutoSize = true;
            this.chkAuto.Checked = true;
            this.chkAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAuto.Location = new System.Drawing.Point(463, 136);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(57, 20);
            this.chkAuto.TabIndex = 3;
            this.chkAuto.Text = "Auto";
            this.chkAuto.UseVisualStyleBackColor = true;
            this.chkAuto.Click += new System.EventHandler(this.chkAuto_Click);
            // 
            // chkMoto
            // 
            this.chkMoto.AutoSize = true;
            this.chkMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMoto.Location = new System.Drawing.Point(585, 136);
            this.chkMoto.Name = "chkMoto";
            this.chkMoto.Size = new System.Drawing.Size(60, 20);
            this.chkMoto.TabIndex = 4;
            this.chkMoto.Text = "Moto";
            this.chkMoto.UseVisualStyleBackColor = true;
            this.chkMoto.Click += new System.EventHandler(this.chkMoto_Click);
            // 
            // cbxRepuestos
            // 
            this.cbxRepuestos.FormattingEnabled = true;
            this.cbxRepuestos.Location = new System.Drawing.Point(391, 472);
            this.cbxRepuestos.Name = "cbxRepuestos";
            this.cbxRepuestos.Size = new System.Drawing.Size(185, 21);
            this.cbxRepuestos.TabIndex = 17;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(413, 499);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(149, 30);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar repuesto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Repuesto";
            // 
            // pDesperfecto
            // 
            this.pDesperfecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pDesperfecto.Controls.Add(this.label11);
            this.pDesperfecto.Controls.Add(this.nManoDeObra);
            this.pDesperfecto.Controls.Add(this.btnAgregarDesp);
            this.pDesperfecto.Controls.Add(this.nTiempo);
            this.pDesperfecto.Controls.Add(this.label14);
            this.pDesperfecto.Controls.Add(this.label15);
            this.pDesperfecto.Controls.Add(this.txtDesc);
            this.pDesperfecto.Controls.Add(this.label16);
            this.pDesperfecto.Location = new System.Drawing.Point(29, 289);
            this.pDesperfecto.Name = "pDesperfecto";
            this.pDesperfecto.Size = new System.Drawing.Size(867, 97);
            this.pDesperfecto.TabIndex = 4;
            // 
            // nManoDeObra
            // 
            this.nManoDeObra.Location = new System.Drawing.Point(182, 59);
            this.nManoDeObra.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nManoDeObra.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nManoDeObra.Name = "nManoDeObra";
            this.nManoDeObra.Size = new System.Drawing.Size(120, 20);
            this.nManoDeObra.TabIndex = 14;
            this.nManoDeObra.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregarDesp
            // 
            this.btnAgregarDesp.Location = new System.Drawing.Point(636, 36);
            this.btnAgregarDesp.Name = "btnAgregarDesp";
            this.btnAgregarDesp.Size = new System.Drawing.Size(149, 41);
            this.btnAgregarDesp.TabIndex = 16;
            this.btnAgregarDesp.Text = "Agregar desperfecto";
            this.btnAgregarDesp.UseVisualStyleBackColor = true;
            this.btnAgregarDesp.Click += new System.EventHandler(this.btnAgregarDesp_Click);
            // 
            // nTiempo
            // 
            this.nTiempo.Location = new System.Drawing.Point(460, 59);
            this.nTiempo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nTiempo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTiempo.Name = "nTiempo";
            this.nTiempo.Size = new System.Drawing.Size(120, 20);
            this.nTiempo.TabIndex = 15;
            this.nTiempo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(341, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "Timpo en dias";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 16);
            this.label15.TabIndex = 11;
            this.label15.Text = "Costo mano de obra $";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(120, 36);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(460, 20);
            this.txtDesc.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 16);
            this.label16.TabIndex = 10;
            this.label16.Text = "Descripcion";
            // 
            // dgDesperfectos
            // 
            this.dgDesperfectos.AllowUserToAddRows = false;
            this.dgDesperfectos.AllowUserToDeleteRows = false;
            this.dgDesperfectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDesperfectos.Location = new System.Drawing.Point(31, 428);
            this.dgDesperfectos.Name = "dgDesperfectos";
            this.dgDesperfectos.ReadOnly = true;
            this.dgDesperfectos.Size = new System.Drawing.Size(313, 163);
            this.dgDesperfectos.TabIndex = 8;
            this.dgDesperfectos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDesperfectos_CellClick);
            // 
            // dgRepuestos
            // 
            this.dgRepuestos.AllowUserToAddRows = false;
            this.dgRepuestos.AllowUserToDeleteRows = false;
            this.dgRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRepuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Precio});
            this.dgRepuestos.Location = new System.Drawing.Point(604, 428);
            this.dgRepuestos.Name = "dgRepuestos";
            this.dgRepuestos.ReadOnly = true;
            this.dgRepuestos.Size = new System.Drawing.Size(293, 163);
            this.dgRepuestos.TabIndex = 9;
            this.dgRepuestos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRepuestos_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Black;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenerar.Location = new System.Drawing.Point(400, 601);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(163, 30);
            this.btnGenerar.TabIndex = 19;
            this.btnGenerar.Text = "Generar presupuesto";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(218, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Que desea presupuestar ?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(94, 405);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Desperfectos asignados";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(615, 405);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(273, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "Repuestos asignados al desperfecto ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(570, 175);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 16);
            this.label17.TabIndex = 12;
            this.label17.Text = "Patente";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(401, 177);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 16);
            this.label18.TabIndex = 11;
            this.label18.Text = "Modelo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(232, 178);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 16);
            this.label19.TabIndex = 10;
            this.label19.Text = "Marca";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(628, 173);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 6;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(463, 174);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(288, 174);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Desperfectos";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Black;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(331, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(313, 24);
            this.label20.TabIndex = 7;
            this.label20.Text = "Presupuestador Taller mecanico";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pAuto);
            this.panel1.Location = new System.Drawing.Point(29, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 161);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vehiculo";
            // 
            // frmPresupuestador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(925, 643);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.pMoto);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.dgRepuestos);
            this.Controls.Add(this.dgDesperfectos);
            this.Controls.Add(this.pDesperfecto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbxRepuestos);
            this.Controls.Add(this.chkMoto);
            this.Controls.Add(this.chkAuto);
            this.Controls.Add(this.pCliente);
            this.Controls.Add(this.panel1);
            this.Name = "frmPresupuestador";
            this.Text = "Presupuestador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pCliente.ResumeLayout(false);
            this.pCliente.PerformLayout();
            this.pAuto.ResumeLayout(false);
            this.pAuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantP)).EndInit();
            this.pMoto.ResumeLayout(false);
            this.pMoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCilindrada)).EndInit();
            this.pDesperfecto.ResumeLayout(false);
            this.pDesperfecto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nManoDeObra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDesperfectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRepuestos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pCliente;
        private System.Windows.Forms.Panel pAuto;
        private System.Windows.Forms.Panel pMoto;
        private System.Windows.Forms.CheckBox chkAuto;
        private System.Windows.Forms.CheckBox chkMoto;
        private System.Windows.Forms.ComboBox cbxRepuestos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pDesperfecto;
        private System.Windows.Forms.DataGridView dgDesperfectos;
        private System.Windows.Forms.DataGridView dgRepuestos;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numCantP;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nCilindrada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nTiempo;
        private System.Windows.Forms.Button btnAgregarDesp;
        private System.Windows.Forms.NumericUpDown nManoDeObra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

