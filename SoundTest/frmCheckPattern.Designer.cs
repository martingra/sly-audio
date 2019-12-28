namespace SoundTest
{
    partial class frmCheckPattern
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
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lblPatron = new System.Windows.Forms.Label();
            this.lblContenedor = new System.Windows.Forms.Label();
            this.txtPatron = new System.Windows.Forms.TextBox();
            this.txtContenedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadOcurrencias = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpResultados = new System.Windows.Forms.GroupBox();
            this.txtMatchLength = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMatchStartsAt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstimatedCoverage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCoverage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfidence = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpResultados.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(498, 58);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 0;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPatron
            // 
            this.lblPatron.AutoSize = true;
            this.lblPatron.Location = new System.Drawing.Point(76, 22);
            this.lblPatron.Name = "lblPatron";
            this.lblPatron.Size = new System.Drawing.Size(38, 13);
            this.lblPatron.TabIndex = 1;
            this.lblPatron.Text = "Patron";
            // 
            // lblContenedor
            // 
            this.lblContenedor.AutoSize = true;
            this.lblContenedor.Location = new System.Drawing.Point(52, 63);
            this.lblContenedor.Name = "lblContenedor";
            this.lblContenedor.Size = new System.Drawing.Size(62, 13);
            this.lblContenedor.TabIndex = 2;
            this.lblContenedor.Text = "Contenedor";
            // 
            // txtPatron
            // 
            this.txtPatron.Location = new System.Drawing.Point(134, 19);
            this.txtPatron.Name = "txtPatron";
            this.txtPatron.Size = new System.Drawing.Size(341, 20);
            this.txtPatron.TabIndex = 3;
            this.txtPatron.Text = "F:\\AI\\Projects\\DATASETS\\mp3\\patron.wav";
            // 
            // txtContenedor
            // 
            this.txtContenedor.Location = new System.Drawing.Point(134, 60);
            this.txtContenedor.Name = "txtContenedor";
            this.txtContenedor.Size = new System.Drawing.Size(341, 20);
            this.txtContenedor.TabIndex = 4;
            this.txtContenedor.Text = "F:\\AI\\Projects\\DATASETS\\mp3\\ejemplo.wav";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad de ocurrencias";
            // 
            // txtCantidadOcurrencias
            // 
            this.txtCantidadOcurrencias.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtCantidadOcurrencias.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCantidadOcurrencias.Location = new System.Drawing.Point(157, 28);
            this.txtCantidadOcurrencias.Name = "txtCantidadOcurrencias";
            this.txtCantidadOcurrencias.Size = new System.Drawing.Size(93, 20);
            this.txtCantidadOcurrencias.TabIndex = 6;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(498, 16);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(134, 99);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(109, 20);
            this.txtDesde.TabIndex = 9;
            this.txtDesde.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Desde";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(316, 99);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(159, 20);
            this.txtDuracion.TabIndex = 11;
            this.txtDuracion.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Duración";
            // 
            // grpResultados
            // 
            this.grpResultados.Controls.Add(this.txtMatchLength);
            this.grpResultados.Controls.Add(this.label8);
            this.grpResultados.Controls.Add(this.txtMatchStartsAt);
            this.grpResultados.Controls.Add(this.label7);
            this.grpResultados.Controls.Add(this.txtEstimatedCoverage);
            this.grpResultados.Controls.Add(this.label6);
            this.grpResultados.Controls.Add(this.txtCoverage);
            this.grpResultados.Controls.Add(this.label5);
            this.grpResultados.Controls.Add(this.txtConfidence);
            this.grpResultados.Controls.Add(this.label4);
            this.grpResultados.Controls.Add(this.txtCantidadOcurrencias);
            this.grpResultados.Controls.Add(this.label1);
            this.grpResultados.Location = new System.Drawing.Point(34, 190);
            this.grpResultados.Name = "grpResultados";
            this.grpResultados.Size = new System.Drawing.Size(618, 143);
            this.grpResultados.TabIndex = 12;
            this.grpResultados.TabStop = false;
            this.grpResultados.Text = "Resultados";
            // 
            // txtMatchLength
            // 
            this.txtMatchLength.Location = new System.Drawing.Point(422, 63);
            this.txtMatchLength.Name = "txtMatchLength";
            this.txtMatchLength.Size = new System.Drawing.Size(93, 20);
            this.txtMatchLength.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Match Length";
            // 
            // txtMatchStartsAt
            // 
            this.txtMatchStartsAt.Location = new System.Drawing.Point(422, 28);
            this.txtMatchStartsAt.Name = "txtMatchStartsAt";
            this.txtMatchStartsAt.Size = new System.Drawing.Size(93, 20);
            this.txtMatchStartsAt.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Match Starts at";
            // 
            // txtEstimatedCoverage
            // 
            this.txtEstimatedCoverage.Location = new System.Drawing.Point(422, 101);
            this.txtEstimatedCoverage.Name = "txtEstimatedCoverage";
            this.txtEstimatedCoverage.Size = new System.Drawing.Size(93, 20);
            this.txtEstimatedCoverage.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estimated Coverage";
            // 
            // txtCoverage
            // 
            this.txtCoverage.Location = new System.Drawing.Point(157, 101);
            this.txtCoverage.Name = "txtCoverage";
            this.txtCoverage.Size = new System.Drawing.Size(93, 20);
            this.txtCoverage.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Coverage";
            // 
            // txtConfidence
            // 
            this.txtConfidence.Location = new System.Drawing.Point(157, 63);
            this.txtConfidence.Name = "txtConfidence";
            this.txtConfidence.Size = new System.Drawing.Size(93, 20);
            this.txtConfidence.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confidence";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.button1);
            this.grpDatos.Controls.Add(this.txtPatron);
            this.grpDatos.Controls.Add(this.btnProcesar);
            this.grpDatos.Controls.Add(this.txtDuracion);
            this.grpDatos.Controls.Add(this.lblPatron);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.lblContenedor);
            this.grpDatos.Controls.Add(this.txtDesde);
            this.grpDatos.Controls.Add(this.txtContenedor);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.btnCargar);
            this.grpDatos.Location = new System.Drawing.Point(34, 34);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(618, 137);
            this.grpDatos.TabIndex = 13;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Detalles";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmCheckPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 375);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.grpResultados);
            this.Name = "frmCheckPattern";
            this.Text = "Check Pattern";
            this.grpResultados.ResumeLayout(false);
            this.grpResultados.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label lblPatron;
        private System.Windows.Forms.Label lblContenedor;
        private System.Windows.Forms.TextBox txtPatron;
        private System.Windows.Forms.TextBox txtContenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadOcurrencias;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpResultados;
        private System.Windows.Forms.TextBox txtMatchLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMatchStartsAt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEstimatedCoverage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCoverage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfidence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Button button1;
    }
}

