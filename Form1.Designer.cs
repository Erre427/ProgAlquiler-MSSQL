namespace ALQUILER
{
    partial class Form1
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
            this.Empresa = new System.Windows.Forms.Panel();
            this.idempresa = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.giro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.altaEmpresa = new System.Windows.Forms.Button();
            this.Empresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // Empresa
            // 
            this.Empresa.Controls.Add(this.altaEmpresa);
            this.Empresa.Controls.Add(this.label4);
            this.Empresa.Controls.Add(this.telefono);
            this.Empresa.Controls.Add(this.label3);
            this.Empresa.Controls.Add(this.giro);
            this.Empresa.Controls.Add(this.label2);
            this.Empresa.Controls.Add(this.direccion);
            this.Empresa.Controls.Add(this.label1);
            this.Empresa.Controls.Add(this.nombre);
            this.Empresa.Controls.Add(this.lbl1);
            this.Empresa.Controls.Add(this.idempresa);
            this.Empresa.Location = new System.Drawing.Point(-1, -2);
            this.Empresa.Name = "Empresa";
            this.Empresa.Size = new System.Drawing.Size(806, 458);
            this.Empresa.TabIndex = 0;
            // 
            // idempresa
            // 
            this.idempresa.Location = new System.Drawing.Point(204, 94);
            this.idempresa.Name = "idempresa";
            this.idempresa.Size = new System.Drawing.Size(100, 20);
            this.idempresa.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(139, 97);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(59, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "IDEmpresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(204, 120);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Direccion";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(204, 146);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(100, 20);
            this.direccion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giro";
            // 
            // giro
            // 
            this.giro.Location = new System.Drawing.Point(204, 172);
            this.giro.Name = "giro";
            this.giro.Size = new System.Drawing.Size(100, 20);
            this.giro.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefono";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(204, 198);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 8;
            // 
            // altaEmpresa
            // 
            this.altaEmpresa.Location = new System.Drawing.Point(380, 113);
            this.altaEmpresa.Name = "altaEmpresa";
            this.altaEmpresa.Size = new System.Drawing.Size(75, 23);
            this.altaEmpresa.TabIndex = 10;
            this.altaEmpresa.Text = "Registrar";
            this.altaEmpresa.UseVisualStyleBackColor = true;
            this.altaEmpresa.Click += new System.EventHandler(this.altaEmpresa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Empresa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Empresa.ResumeLayout(false);
            this.Empresa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Empresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox idempresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox giro;
        private System.Windows.Forms.Button altaEmpresa;
    }
}

