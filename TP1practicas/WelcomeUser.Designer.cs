namespace TP1practicas
{
    partial class WelcomeUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinizar2 = new System.Windows.Forms.Button();
            this.btnCerrar2 = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTipoUser = new System.Windows.Forms.Label();
            this.btnSubirArchivo = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pctUser = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMinizar2);
            this.panel1.Controls.Add(this.btnCerrar2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 37);
            this.panel1.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Cliente";
            // 
            // btnMinizar2
            // 
            this.btnMinizar2.BackColor = System.Drawing.Color.LightCyan;
            this.btnMinizar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinizar2.Image = ((System.Drawing.Image)(resources.GetObject("btnMinizar2.Image")));
            this.btnMinizar2.Location = new System.Drawing.Point(314, 4);
            this.btnMinizar2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinizar2.Name = "btnMinizar2";
            this.btnMinizar2.Size = new System.Drawing.Size(67, 29);
            this.btnMinizar2.TabIndex = 52;
            this.btnMinizar2.TabStop = false;
            this.btnMinizar2.UseVisualStyleBackColor = false;
            this.btnMinizar2.Click += new System.EventHandler(this.btnMinizar2_Click);
            // 
            // btnCerrar2
            // 
            this.btnCerrar2.BackColor = System.Drawing.Color.MistyRose;
            this.btnCerrar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrar2.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar2.Image")));
            this.btnCerrar2.Location = new System.Drawing.Point(386, 4);
            this.btnCerrar2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar2.Name = "btnCerrar2";
            this.btnCerrar2.Size = new System.Drawing.Size(67, 29);
            this.btnCerrar2.TabIndex = 51;
            this.btnCerrar2.TabStop = false;
            this.btnCerrar2.UseVisualStyleBackColor = false;
            this.btnCerrar2.Click += new System.EventHandler(this.btnCerrar2_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(161, 41);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(295, 31);
            this.lblWelcome.TabIndex = 61;
            this.lblWelcome.Text = "¡Bienvenido, \"USER\"!";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // lblTipoUser
            // 
            this.lblTipoUser.AutoSize = true;
            this.lblTipoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUser.Location = new System.Drawing.Point(217, 83);
            this.lblTipoUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoUser.Name = "lblTipoUser";
            this.lblTipoUser.Size = new System.Drawing.Size(151, 20);
            this.lblTipoUser.TabIndex = 60;
            this.lblTipoUser.Text = "Usuario tipo: Cliente";
            this.lblTipoUser.Click += new System.EventHandler(this.lblTipoUser_Click);
            // 
            // btnSubirArchivo
            // 
            this.btnSubirArchivo.BackColor = System.Drawing.Color.White;
            this.btnSubirArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirArchivo.Location = new System.Drawing.Point(294, 178);
            this.btnSubirArchivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubirArchivo.Name = "btnSubirArchivo";
            this.btnSubirArchivo.Size = new System.Drawing.Size(131, 26);
            this.btnSubirArchivo.TabIndex = 1;
            this.btnSubirArchivo.Text = "Subir archivo";
            this.btnSubirArchivo.UseVisualStyleBackColor = false;
            this.btnSubirArchivo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(158, 178);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(131, 26);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pctUser
            // 
            this.pctUser.Image = global::TP1practicas.Properties.Resources.usuario;
            this.pctUser.Location = new System.Drawing.Point(4, 41);
            this.pctUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pctUser.Name = "pctUser";
            this.pctUser.Size = new System.Drawing.Size(150, 162);
            this.pctUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUser.TabIndex = 65;
            this.pctUser.TabStop = false;
            // 
            // WelcomeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(458, 210);
            this.ControlBox = false;
            this.Controls.Add(this.pctUser);
            this.Controls.Add(this.btnSubirArchivo);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblTipoUser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinizar2;
        private System.Windows.Forms.Button btnCerrar2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTipoUser;
        private System.Windows.Forms.Button btnSubirArchivo;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox pctUser;
    }
}