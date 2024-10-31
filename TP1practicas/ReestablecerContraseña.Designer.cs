namespace TP1practicas
{
    partial class ReestablecerContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReestablecerContraseña));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkNuevaContra = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtConfirm2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReestablecer = new System.Windows.Forms.Button();
            this.pcbMostrar1 = new System.Windows.Forms.PictureBox();
            this.pcbOcultar1 = new System.Windows.Forms.PictureBox();
            this.pcbMostrar = new System.Windows.Forms.PictureBox();
            this.pcbOcultar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMinizar2 = new System.Windows.Forms.Button();
            this.btnCerrar2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMostrar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOcultar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOcultar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnMinizar2);
            this.panel1.Controls.Add(this.btnCerrar2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 45);
            this.panel1.TabIndex = 55;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Reestablecer Contraseña";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lnkNuevaContra
            // 
            this.lnkNuevaContra.AutoSize = true;
            this.lnkNuevaContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkNuevaContra.Location = new System.Drawing.Point(28, 68);
            this.lnkNuevaContra.Name = "lnkNuevaContra";
            this.lnkNuevaContra.Size = new System.Drawing.Size(176, 25);
            this.lnkNuevaContra.TabIndex = 56;
            this.lnkNuevaContra.Text = "Nueva Contraseña";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.Location = new System.Drawing.Point(257, 66);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(167, 30);
            this.txtConfirm.TabIndex = 1;
            this.txtConfirm.TextChanged += new System.EventHandler(this.txtConfirm_TextChanged);
            // 
            // txtConfirm2
            // 
            this.txtConfirm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm2.Location = new System.Drawing.Point(257, 114);
            this.txtConfirm2.Name = "txtConfirm2";
            this.txtConfirm2.PasswordChar = '*';
            this.txtConfirm2.Size = new System.Drawing.Size(167, 30);
            this.txtConfirm2.TabIndex = 2;
            this.txtConfirm2.TextChanged += new System.EventHandler(this.txtConfirm2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "Confirme Contraseña";
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReestablecer.Location = new System.Drawing.Point(33, 162);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(429, 40);
            this.btnReestablecer.TabIndex = 3;
            this.btnReestablecer.Text = "Reestablecer";
            this.btnReestablecer.UseVisualStyleBackColor = true;
            this.btnReestablecer.Click += new System.EventHandler(this.btnReestablecer_Click);
            // 
            // pcbMostrar1
            // 
            this.pcbMostrar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbMostrar1.Image = global::TP1practicas.Properties.Resources.mostrar2;
            this.pcbMostrar1.Location = new System.Drawing.Point(432, 114);
            this.pcbMostrar1.Name = "pcbMostrar1";
            this.pcbMostrar1.Size = new System.Drawing.Size(30, 30);
            this.pcbMostrar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbMostrar1.TabIndex = 64;
            this.pcbMostrar1.TabStop = false;
            this.pcbMostrar1.Click += new System.EventHandler(this.pcbMostrar1_Click_1);
            // 
            // pcbOcultar1
            // 
            this.pcbOcultar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbOcultar1.Image = global::TP1practicas.Properties.Resources.ocultar5;
            this.pcbOcultar1.Location = new System.Drawing.Point(432, 114);
            this.pcbOcultar1.Name = "pcbOcultar1";
            this.pcbOcultar1.Size = new System.Drawing.Size(30, 30);
            this.pcbOcultar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbOcultar1.TabIndex = 63;
            this.pcbOcultar1.TabStop = false;
            this.pcbOcultar1.Click += new System.EventHandler(this.pcbOcultar1_Click_1);
            // 
            // pcbMostrar
            // 
            this.pcbMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbMostrar.Image = global::TP1practicas.Properties.Resources.mostrar2;
            this.pcbMostrar.Location = new System.Drawing.Point(432, 66);
            this.pcbMostrar.Name = "pcbMostrar";
            this.pcbMostrar.Size = new System.Drawing.Size(30, 30);
            this.pcbMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbMostrar.TabIndex = 62;
            this.pcbMostrar.TabStop = false;
            this.pcbMostrar.Click += new System.EventHandler(this.pcbMostrar_Click);
            // 
            // pcbOcultar
            // 
            this.pcbOcultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbOcultar.Image = global::TP1practicas.Properties.Resources.ocultar5;
            this.pcbOcultar.Location = new System.Drawing.Point(432, 66);
            this.pcbOcultar.Name = "pcbOcultar";
            this.pcbOcultar.Size = new System.Drawing.Size(30, 30);
            this.pcbOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbOcultar.TabIndex = 61;
            this.pcbOcultar.TabStop = false;
            this.pcbOcultar.Click += new System.EventHandler(this.pcbOcultar_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(302, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 61;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(397, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 36);
            this.button2.TabIndex = 60;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMinizar2
            // 
            this.btnMinizar2.BackColor = System.Drawing.Color.LightCyan;
            this.btnMinizar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinizar2.Image = ((System.Drawing.Image)(resources.GetObject("btnMinizar2.Image")));
            this.btnMinizar2.Location = new System.Drawing.Point(632, 3);
            this.btnMinizar2.Name = "btnMinizar2";
            this.btnMinizar2.Size = new System.Drawing.Size(89, 36);
            this.btnMinizar2.TabIndex = 52;
            this.btnMinizar2.TabStop = false;
            this.btnMinizar2.UseVisualStyleBackColor = false;
            // 
            // btnCerrar2
            // 
            this.btnCerrar2.BackColor = System.Drawing.Color.MistyRose;
            this.btnCerrar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrar2.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar2.Image")));
            this.btnCerrar2.Location = new System.Drawing.Point(727, 3);
            this.btnCerrar2.Name = "btnCerrar2";
            this.btnCerrar2.Size = new System.Drawing.Size(89, 36);
            this.btnCerrar2.TabIndex = 51;
            this.btnCerrar2.TabStop = false;
            this.btnCerrar2.UseVisualStyleBackColor = false;
            // 
            // ReestablecerContraseña
            // 
            this.AcceptButton = this.btnReestablecer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(490, 223);
            this.ControlBox = false;
            this.Controls.Add(this.pcbMostrar1);
            this.Controls.Add(this.pcbOcultar1);
            this.Controls.Add(this.pcbMostrar);
            this.Controls.Add(this.pcbOcultar);
            this.Controls.Add(this.btnReestablecer);
            this.Controls.Add(this.txtConfirm2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.lnkNuevaContra);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReestablecerContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reestablecer Contraseña";
            this.Load += new System.EventHandler(this.ReestablecerContraseña_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMostrar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOcultar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOcultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinizar2;
        private System.Windows.Forms.Button btnCerrar2;
        private System.Windows.Forms.Label lnkNuevaContra;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.TextBox txtConfirm2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReestablecer;
        private System.Windows.Forms.PictureBox pcbMostrar;
        private System.Windows.Forms.PictureBox pcbOcultar;
        private System.Windows.Forms.PictureBox pcbMostrar1;
        private System.Windows.Forms.PictureBox pcbOcultar1;
    }
}