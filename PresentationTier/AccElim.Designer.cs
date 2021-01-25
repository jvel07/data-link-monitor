namespace PresentationTier
{
    partial class AccElim
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
            this.btnAceptarEl = new System.Windows.Forms.Button();
            this.btnCancelarEl = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptarEl
            // 
            this.btnAceptarEl.Location = new System.Drawing.Point(3, 63);
            this.btnAceptarEl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptarEl.Name = "btnAceptarEl";
            this.btnAceptarEl.Size = new System.Drawing.Size(87, 26);
            this.btnAceptarEl.TabIndex = 0;
            this.btnAceptarEl.Text = "Aceptar";
            this.btnAceptarEl.UseVisualStyleBackColor = true;
            this.btnAceptarEl.Click += new System.EventHandler(this.btnAceptarEl_Click);
            // 
            // btnCancelarEl
            // 
            this.btnCancelarEl.Location = new System.Drawing.Point(96, 63);
            this.btnCancelarEl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelarEl.Name = "btnCancelarEl";
            this.btnCancelarEl.Size = new System.Drawing.Size(87, 26);
            this.btnCancelarEl.TabIndex = 1;
            this.btnCancelarEl.Text = "Cancelar";
            this.btnCancelarEl.UseVisualStyleBackColor = true;
            this.btnCancelarEl.Click += new System.EventHandler(this.btnCancelarEl_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtContrasena.Location = new System.Drawing.Point(22, 31);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = 'o';
            this.txtContrasena.Size = new System.Drawing.Size(142, 24);
            this.txtContrasena.TabIndex = 2;
            this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña...";
            // 
            // AccElim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(185, 84);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.btnCancelarEl);
            this.Controls.Add(this.btnAceptarEl);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AccElim";
            this.Text = "Eliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarEl;
        private System.Windows.Forms.Button btnCancelarEl;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label1;
    }
}