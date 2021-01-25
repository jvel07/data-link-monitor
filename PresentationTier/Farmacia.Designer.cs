namespace PresentationTier
{
    partial class Farmacia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Farmacia));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIpFarm = new System.Windows.Forms.TextBox();
            this.txtNombFarm = new System.Windows.Forms.TextBox();
            this.txtIdFarm = new System.Windows.Forms.TextBox();
            this.dgvFarm = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnAbrirPathRec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "IP Farmacia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre Farmacia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Farmacia";
            // 
            // txtIpFarm
            // 
            this.txtIpFarm.Location = new System.Drawing.Point(158, 83);
            this.txtIpFarm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIpFarm.Name = "txtIpFarm";
            this.txtIpFarm.Size = new System.Drawing.Size(235, 22);
            this.txtIpFarm.TabIndex = 14;
            // 
            // txtNombFarm
            // 
            this.txtNombFarm.Location = new System.Drawing.Point(158, 52);
            this.txtNombFarm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombFarm.Name = "txtNombFarm";
            this.txtNombFarm.Size = new System.Drawing.Size(235, 22);
            this.txtNombFarm.TabIndex = 13;
            // 
            // txtIdFarm
            // 
            this.txtIdFarm.Location = new System.Drawing.Point(158, 19);
            this.txtIdFarm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdFarm.Name = "txtIdFarm";
            this.txtIdFarm.Size = new System.Drawing.Size(235, 22);
            this.txtIdFarm.TabIndex = 12;
            // 
            // dgvFarm
            // 
            this.dgvFarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFarm.Location = new System.Drawing.Point(155, 167);
            this.dgvFarm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvFarm.Name = "dgvFarm";
            this.dgvFarm.Size = new System.Drawing.Size(420, 265);
            this.dgvFarm.TabIndex = 11;
            this.dgvFarm.SelectionChanged += new System.EventHandler(this.dgvFarm_SelectionChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(-8, 193);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 28);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(-8, 158);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(87, 28);
            this.btnInsertar.TabIndex = 9;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(-8, 229);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(87, 28);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 381);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 45);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(35, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "por Jóse Egas López";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.Location = new System.Drawing.Point(559, -2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.TabIndex = 52;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Rec Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(158, 115);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(326, 22);
            this.txtPath.TabIndex = 54;
            // 
            // btnAbrirPathRec
            // 
            this.btnAbrirPathRec.Location = new System.Drawing.Point(490, 112);
            this.btnAbrirPathRec.Name = "btnAbrirPathRec";
            this.btnAbrirPathRec.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirPathRec.TabIndex = 55;
            this.btnAbrirPathRec.Text = "Abrir";
            this.btnAbrirPathRec.UseVisualStyleBackColor = true;
            this.btnAbrirPathRec.Click += new System.EventHandler(this.btnAbrirPathRec_Click);
            // 
            // Farmacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(577, 438);
            this.Controls.Add(this.btnAbrirPathRec);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIpFarm);
            this.Controls.Add(this.txtNombFarm);
            this.Controls.Add(this.txtIdFarm);
            this.Controls.Add(this.dgvFarm);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Farmacia";
            this.Text = "Farmacia";
            this.Load += new System.EventHandler(this.Farmacia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIpFarm;
        private System.Windows.Forms.TextBox txtNombFarm;
        private System.Windows.Forms.TextBox txtIdFarm;
        private System.Windows.Forms.DataGridView dgvFarm;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnAbrirPathRec;
    }
}