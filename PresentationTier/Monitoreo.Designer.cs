namespace PresentationTier
{
    partial class Monitoreo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitoreo));
            this.lblIP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblRate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalPings = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPingErrors = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPing = new System.Windows.Forms.Button();
            this.dgvFarmacias = new System.Windows.Forms.DataGridView();
            this.idfarmaciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrefarmaciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipfarmaciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alerta_Rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoFarmaciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoEnlaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fKEstadoEnlaceInfoFarmaciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTasaErrorRef = new System.Windows.Forms.TextBox();
            this.estadoEnlaceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvEstado = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizarBase = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNombreFarmacia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarmacias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoFarmaciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoEnlaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEstadoEnlaceInfoFarmaciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoEnlaceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(-57, 151);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(14, 16);
            this.lblIP.TabIndex = 37;
            this.lblIP.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-62, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "IP";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnRefrescar.Location = new System.Drawing.Point(942, 39);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(55, 29);
            this.btnRefrescar.TabIndex = 35;
            this.btnRefrescar.Text = "Limpiar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click_1);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(532, 11);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(11, 16);
            this.lblEstado.TabIndex = 34;
            this.lblEstado.Text = ".";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(377, -18);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(74, 45);
            this.btnStop.TabIndex = 33;
            this.btnStop.Text = "Parar";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(623, 118);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(14, 16);
            this.lblRate.TabIndex = 32;
            this.lblRate.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(584, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Porcentaje de Error";
            // 
            // lblTotalPings
            // 
            this.lblTotalPings.AutoSize = true;
            this.lblTotalPings.Location = new System.Drawing.Point(287, 118);
            this.lblTotalPings.Name = "lblTotalPings";
            this.lblTotalPings.Size = new System.Drawing.Size(14, 16);
            this.lblTotalPings.TabIndex = 30;
            this.lblTotalPings.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Total de Pings";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(471, 63);
            this.txtTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(21, 22);
            this.txtTime.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tiempo (min):";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(502, 118);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(14, 16);
            this.lblCurrentTime.TabIndex = 26;
            this.lblCurrentTime.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tiempo Actual";
            // 
            // lblPingErrors
            // 
            this.lblPingErrors.AutoSize = true;
            this.lblPingErrors.Location = new System.Drawing.Point(392, 118);
            this.lblPingErrors.Name = "lblPingErrors";
            this.lblPingErrors.Size = new System.Drawing.Size(14, 16);
            this.lblPingErrors.TabIndex = 24;
            this.lblPingErrors.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Pings Fallidos";
            // 
            // btnPing
            // 
            this.btnPing.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPing.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPing.Location = new System.Drawing.Point(457, -18);
            this.btnPing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(69, 45);
            this.btnPing.TabIndex = 20;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = false;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // dgvFarmacias
            // 
            this.dgvFarmacias.AllowUserToAddRows = false;
            this.dgvFarmacias.AutoGenerateColumns = false;
            this.dgvFarmacias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFarmacias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfarmaciaDataGridViewTextBoxColumn,
            this.nombrefarmaciaDataGridViewTextBoxColumn,
            this.ipfarmaciaDataGridViewTextBoxColumn,
            this.alerta_Rec});
            this.dgvFarmacias.DataSource = this.infoFarmaciaBindingSource;
            this.dgvFarmacias.Location = new System.Drawing.Point(608, 184);
            this.dgvFarmacias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvFarmacias.Name = "dgvFarmacias";
            this.dgvFarmacias.Size = new System.Drawing.Size(402, 269);
            this.dgvFarmacias.TabIndex = 38;
            // 
            // idfarmaciaDataGridViewTextBoxColumn
            // 
            this.idfarmaciaDataGridViewTextBoxColumn.DataPropertyName = "id_farmacia";
            this.idfarmaciaDataGridViewTextBoxColumn.HeaderText = "id_farmacia";
            this.idfarmaciaDataGridViewTextBoxColumn.Name = "idfarmaciaDataGridViewTextBoxColumn";
            this.idfarmaciaDataGridViewTextBoxColumn.Width = 50;
            // 
            // nombrefarmaciaDataGridViewTextBoxColumn
            // 
            this.nombrefarmaciaDataGridViewTextBoxColumn.DataPropertyName = "nombre_farmacia";
            this.nombrefarmaciaDataGridViewTextBoxColumn.HeaderText = "nombre_farmacia";
            this.nombrefarmaciaDataGridViewTextBoxColumn.Name = "nombrefarmaciaDataGridViewTextBoxColumn";
            this.nombrefarmaciaDataGridViewTextBoxColumn.Width = 150;
            // 
            // ipfarmaciaDataGridViewTextBoxColumn
            // 
            this.ipfarmaciaDataGridViewTextBoxColumn.DataPropertyName = "ip_farmacia";
            this.ipfarmaciaDataGridViewTextBoxColumn.HeaderText = "ip_farmacia";
            this.ipfarmaciaDataGridViewTextBoxColumn.Name = "ipfarmaciaDataGridViewTextBoxColumn";
            // 
            // alerta_Rec
            // 
            this.alerta_Rec.DataPropertyName = "alerta_Rec";
            this.alerta_Rec.HeaderText = "alerta_Rec";
            this.alerta_Rec.Name = "alerta_Rec";
            // 
            // infoFarmaciaBindingSource
            // 
            this.infoFarmaciaBindingSource.DataMember = "Info_Farmacia";
            this.infoFarmaciaBindingSource.DataSource = typeof(DataEntityTier.intermitenciaDataSet);
            // 
            // estadoEnlaceBindingSource
            // 
            this.estadoEnlaceBindingSource.DataMember = "Estado_Enlace";
            this.estadoEnlaceBindingSource.DataSource = typeof(DataEntityTier.intermitenciaDataSet);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Ping en Ejecución (Estado Enlace)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(605, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "Base de Datos (Info Farmacias)";
            // 
            // timer1
            // 
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(914, 165);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 24);
            this.button1.TabIndex = 42;
            this.button1.Text = "Ir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(890, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "Insertar nueva farmacia";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-19, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 24);
            this.button2.TabIndex = 44;
            this.button2.Text = "Insertar 1ra Vez";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-15, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 25);
            this.button3.TabIndex = 45;
            this.button3.Text = "Eliminar Registros de Estado";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fKEstadoEnlaceInfoFarmaciaBindingSource
            // 
            this.fKEstadoEnlaceInfoFarmaciaBindingSource.DataMember = "FK_Estado_Enlace_Info_Farmacia";
            this.fKEstadoEnlaceInfoFarmaciaBindingSource.DataSource = this.infoFarmaciaBindingSource;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 460);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 45);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(69, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "por Jóse Egas López";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(966, 460);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 44);
            this.btnSalir.TabIndex = 50;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(190, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 16);
            this.label11.TabIndex = 53;
            this.label11.Text = "Tasa Error de Referencia";
            // 
            // txtTasaErrorRef
            // 
            this.txtTasaErrorRef.Location = new System.Drawing.Point(325, 66);
            this.txtTasaErrorRef.Name = "txtTasaErrorRef";
            this.txtTasaErrorRef.Size = new System.Drawing.Size(34, 22);
            this.txtTasaErrorRef.TabIndex = 54;
            // 
            // estadoEnlaceBindingSource1
            // 
            this.estadoEnlaceBindingSource1.DataMember = "Estado_Enlace";
            this.estadoEnlaceBindingSource1.DataSource = typeof(DataEntityTier.intermitenciaDataSet);
            // 
            // dgvEstado
            // 
            this.dgvEstado.AllowUserToAddRows = false;
            this.dgvEstado.AllowUserToDeleteRows = false;
            this.dgvEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvEstado.Location = new System.Drawing.Point(4, 183);
            this.dgvEstado.Name = "dgvEstado";
            this.dgvEstado.RowHeadersVisible = false;
            this.dgvEstado.Size = new System.Drawing.Size(598, 270);
            this.dgvEstado.TabIndex = 56;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "column1";
            this.Column1.HeaderText = "Id Estado";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "column2";
            this.Column2.HeaderText = "Tasa de Error";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "column3";
            this.Column3.HeaderText = "Tiempo";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "column4";
            this.Column4.HeaderText = "Id Farmacia";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "column5";
            this.Column5.HeaderText = "Ip";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "column6";
            this.Column6.HeaderText = "Nombre de Farmacia";
            this.Column6.Name = "Column6";
            // 
            // btnActualizarBase
            // 
            this.btnActualizarBase.Location = new System.Drawing.Point(4, 66);
            this.btnActualizarBase.Name = "btnActualizarBase";
            this.btnActualizarBase.Size = new System.Drawing.Size(106, 23);
            this.btnActualizarBase.TabIndex = 57;
            this.btnActualizarBase.Text = "Actualizar Base";
            this.btnActualizarBase.UseVisualStyleBackColor = true;
            this.btnActualizarBase.Click += new System.EventHandler(this.btnActualizarBase_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(724, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 58;
            this.label12.Text = "Farmacia";
            // 
            // lblNombreFarmacia
            // 
            this.lblNombreFarmacia.AutoSize = true;
            this.lblNombreFarmacia.Location = new System.Drawing.Point(737, 118);
            this.lblNombreFarmacia.Name = "lblNombreFarmacia";
            this.lblNombreFarmacia.Size = new System.Drawing.Size(14, 16);
            this.lblNombreFarmacia.TabIndex = 59;
            this.lblNombreFarmacia.Text = "0";
            // 
            // Monitoreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1013, 510);
            this.Controls.Add(this.lblNombreFarmacia);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnActualizarBase);
            this.Controls.Add(this.dgvEstado);
            this.Controls.Add(this.txtTasaErrorRef);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvFarmacias);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalPings);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPingErrors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPing);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Monitoreo";
            this.Text = "Monitoreo Intermitencias";
            this.Load += new System.EventHandler(this.Monitoreo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarmacias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoFarmaciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoEnlaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEstadoEnlaceInfoFarmaciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoEnlaceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalPings;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPingErrors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPing;
        public System.Windows.Forms.DataGridView dgvFarmacias;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource infoFarmaciaBindingSource;
        private System.Windows.Forms.BindingSource fKEstadoEnlaceInfoFarmaciaBindingSource;
        private System.Windows.Forms.BindingSource estadoEnlaceBindingSource;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfarmaciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrefarmaciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipfarmaciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource estadoEnlaceBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtTasaErrorRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn alerta_Rec;
        private System.Windows.Forms.DataGridView dgvEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnActualizarBase;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNombreFarmacia;
    }
}

