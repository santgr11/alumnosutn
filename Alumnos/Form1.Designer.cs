﻿namespace Alumnos
{
    partial class frmAlumnos
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
            this.boxNota1 = new System.Windows.Forms.TextBox();
            this.boxNota2 = new System.Windows.Forms.TextBox();
            this.boxNota3 = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.Label();
            this.boxPromedio = new System.Windows.Forms.Label();
            this.txtAprueba = new System.Windows.Forms.Label();
            this.boxAprueba = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxNombre = new System.Windows.Forms.TextBox();
            this.boxLegajo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.boxCantidad = new System.Windows.Forms.Label();
            this.lblProGeneral = new System.Windows.Forms.Label();
            this.lblProCurso = new System.Windows.Forms.Label();
            this.lblLibres = new System.Windows.Forms.Label();
            this.lblRegulares = new System.Windows.Forms.Label();
            this.lblPromocionados = new System.Windows.Forms.Label();
            this.lblLibresTotal = new System.Windows.Forms.Label();
            this.lblRegularesTotal = new System.Windows.Forms.Label();
            this.lblPromocionadosTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxNota1
            // 
            this.boxNota1.Location = new System.Drawing.Point(152, 93);
            this.boxNota1.Name = "boxNota1";
            this.boxNota1.Size = new System.Drawing.Size(100, 20);
            this.boxNota1.TabIndex = 2;
            // 
            // boxNota2
            // 
            this.boxNota2.Location = new System.Drawing.Point(152, 134);
            this.boxNota2.Name = "boxNota2";
            this.boxNota2.Size = new System.Drawing.Size(100, 20);
            this.boxNota2.TabIndex = 3;
            // 
            // boxNota3
            // 
            this.boxNota3.Location = new System.Drawing.Point(152, 175);
            this.boxNota3.Name = "boxNota3";
            this.boxNota3.Size = new System.Drawing.Size(100, 20);
            this.boxNota3.TabIndex = 4;
            // 
            // txtNota1
            // 
            this.txtNota1.AutoSize = true;
            this.txtNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota1.Location = new System.Drawing.Point(31, 93);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(69, 25);
            this.txtNota1.TabIndex = 3;
            this.txtNota1.Text = "Nota 1";
            this.txtNota1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNota3
            // 
            this.txtNota3.AutoSize = true;
            this.txtNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota3.Location = new System.Drawing.Point(31, 177);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(69, 25);
            this.txtNota3.TabIndex = 6;
            this.txtNota3.Text = "Nota 3";
            // 
            // txtNota2
            // 
            this.txtNota2.AutoSize = true;
            this.txtNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota2.Location = new System.Drawing.Point(31, 135);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(69, 25);
            this.txtNota2.TabIndex = 7;
            this.txtNota2.Text = "Nota 2";
            // 
            // txtPromedio
            // 
            this.txtPromedio.AutoSize = true;
            this.txtPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedio.Location = new System.Drawing.Point(31, 219);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(95, 25);
            this.txtPromedio.TabIndex = 8;
            this.txtPromedio.Text = "Promedio";
            // 
            // boxPromedio
            // 
            this.boxPromedio.AutoSize = true;
            this.boxPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPromedio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boxPromedio.Location = new System.Drawing.Point(173, 216);
            this.boxPromedio.Name = "boxPromedio";
            this.boxPromedio.Size = new System.Drawing.Size(59, 25);
            this.boxPromedio.TabIndex = 9;
            this.boxPromedio.Text = "None";
            // 
            // txtAprueba
            // 
            this.txtAprueba.AutoSize = true;
            this.txtAprueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAprueba.Location = new System.Drawing.Point(31, 261);
            this.txtAprueba.Name = "txtAprueba";
            this.txtAprueba.Size = new System.Drawing.Size(100, 25);
            this.txtAprueba.TabIndex = 10;
            this.txtAprueba.Text = "Condicion";
            // 
            // boxAprueba
            // 
            this.boxAprueba.AutoSize = true;
            this.boxAprueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxAprueba.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boxAprueba.Location = new System.Drawing.Point(173, 262);
            this.boxAprueba.Name = "boxAprueba";
            this.boxAprueba.Size = new System.Drawing.Size(59, 25);
            this.boxAprueba.TabIndex = 11;
            this.boxAprueba.Text = "None";
            this.boxAprueba.Click += new System.EventHandler(this.boxAprueba_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(36, 346);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(95, 23);
            this.btnRegistro.TabIndex = 5;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Legajo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // boxNombre
            // 
            this.boxNombre.Location = new System.Drawing.Point(152, 52);
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.Size = new System.Drawing.Size(100, 20);
            this.boxNombre.TabIndex = 1;
            // 
            // boxLegajo
            // 
            this.boxLegajo.Location = new System.Drawing.Point(152, 11);
            this.boxLegajo.Name = "boxLegajo";
            this.boxLegajo.Size = new System.Drawing.Size(100, 20);
            this.boxLegajo.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(157, 346);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // boxCantidad
            // 
            this.boxCantidad.AutoSize = true;
            this.boxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCantidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boxCantidad.Location = new System.Drawing.Point(173, 301);
            this.boxCantidad.Name = "boxCantidad";
            this.boxCantidad.Size = new System.Drawing.Size(86, 25);
            this.boxCantidad.TabIndex = 14;
            this.boxCantidad.Text = "cantidad";
            // 
            // lblProGeneral
            // 
            this.lblProGeneral.AutoSize = true;
            this.lblProGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProGeneral.Location = new System.Drawing.Point(200, 403);
            this.lblProGeneral.Name = "lblProGeneral";
            this.lblProGeneral.Size = new System.Drawing.Size(59, 25);
            this.lblProGeneral.TabIndex = 15;
            this.lblProGeneral.Text = "None";
            // 
            // lblProCurso
            // 
            this.lblProCurso.AutoSize = true;
            this.lblProCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProCurso.Location = new System.Drawing.Point(12, 403);
            this.lblProCurso.Name = "lblProCurso";
            this.lblProCurso.Size = new System.Drawing.Size(169, 25);
            this.lblProCurso.TabIndex = 16;
            this.lblProCurso.Text = "Promedio General";
            // 
            // lblLibres
            // 
            this.lblLibres.AutoSize = true;
            this.lblLibres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLibres.Location = new System.Drawing.Point(12, 438);
            this.lblLibres.Name = "lblLibres";
            this.lblLibres.Size = new System.Drawing.Size(65, 25);
            this.lblLibres.TabIndex = 17;
            this.lblLibres.Text = "Libres";
            // 
            // lblRegulares
            // 
            this.lblRegulares.AutoSize = true;
            this.lblRegulares.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegulares.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRegulares.Location = new System.Drawing.Point(12, 473);
            this.lblRegulares.Name = "lblRegulares";
            this.lblRegulares.Size = new System.Drawing.Size(100, 25);
            this.lblRegulares.TabIndex = 18;
            this.lblRegulares.Text = "Regulares";
            // 
            // lblPromocionados
            // 
            this.lblPromocionados.AutoSize = true;
            this.lblPromocionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromocionados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPromocionados.Location = new System.Drawing.Point(12, 508);
            this.lblPromocionados.Name = "lblPromocionados";
            this.lblPromocionados.Size = new System.Drawing.Size(148, 25);
            this.lblPromocionados.TabIndex = 19;
            this.lblPromocionados.Text = "Promocionados";
            // 
            // lblLibresTotal
            // 
            this.lblLibresTotal.AutoSize = true;
            this.lblLibresTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibresTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLibresTotal.Location = new System.Drawing.Point(200, 438);
            this.lblLibresTotal.Name = "lblLibresTotal";
            this.lblLibresTotal.Size = new System.Drawing.Size(86, 25);
            this.lblLibresTotal.TabIndex = 20;
            this.lblLibresTotal.Text = "cantidad";
            // 
            // lblRegularesTotal
            // 
            this.lblRegularesTotal.AutoSize = true;
            this.lblRegularesTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegularesTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRegularesTotal.Location = new System.Drawing.Point(200, 473);
            this.lblRegularesTotal.Name = "lblRegularesTotal";
            this.lblRegularesTotal.Size = new System.Drawing.Size(86, 25);
            this.lblRegularesTotal.TabIndex = 21;
            this.lblRegularesTotal.Text = "cantidad";
            // 
            // lblPromocionadosTotal
            // 
            this.lblPromocionadosTotal.AutoSize = true;
            this.lblPromocionadosTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromocionadosTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPromocionadosTotal.Location = new System.Drawing.Point(200, 508);
            this.lblPromocionadosTotal.Name = "lblPromocionadosTotal";
            this.lblPromocionadosTotal.Size = new System.Drawing.Size(86, 25);
            this.lblPromocionadosTotal.TabIndex = 22;
            this.lblPromocionadosTotal.Text = "cantidad";
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(303, 552);
            this.Controls.Add(this.lblPromocionadosTotal);
            this.Controls.Add(this.lblRegularesTotal);
            this.Controls.Add(this.lblLibresTotal);
            this.Controls.Add(this.lblPromocionados);
            this.Controls.Add(this.lblRegulares);
            this.Controls.Add(this.lblLibres);
            this.Controls.Add(this.lblProCurso);
            this.Controls.Add(this.lblProGeneral);
            this.Controls.Add(this.boxCantidad);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.boxLegajo);
            this.Controls.Add(this.boxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.boxAprueba);
            this.Controls.Add(this.txtAprueba);
            this.Controls.Add(this.boxPromedio);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.boxNota3);
            this.Controls.Add(this.boxNota2);
            this.Controls.Add(this.boxNota1);
            this.Name = "frmAlumnos";
            this.Text = "1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxNota1;
        private System.Windows.Forms.TextBox boxNota2;
        private System.Windows.Forms.TextBox boxNota3;
        private System.Windows.Forms.Label txtNota1;
        private System.Windows.Forms.Label txtNota3;
        private System.Windows.Forms.Label txtNota2;
        private System.Windows.Forms.Label txtPromedio;
        private System.Windows.Forms.Label boxPromedio;
        private System.Windows.Forms.Label txtAprueba;
        private System.Windows.Forms.Label boxAprueba;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxNombre;
        private System.Windows.Forms.TextBox boxLegajo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label boxCantidad;
        private System.Windows.Forms.Label lblProGeneral;
        private System.Windows.Forms.Label lblProCurso;
        private System.Windows.Forms.Label lblLibres;
        private System.Windows.Forms.Label lblRegulares;
        private System.Windows.Forms.Label lblPromocionados;
        private System.Windows.Forms.Label lblLibresTotal;
        private System.Windows.Forms.Label lblRegularesTotal;
        private System.Windows.Forms.Label lblPromocionadosTotal;
    }
}
