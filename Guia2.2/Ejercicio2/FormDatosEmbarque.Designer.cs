
namespace Ejercicio2
{
    partial class FormDatosEmbarque
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
            this.gbVehiculo = new System.Windows.Forms.GroupBox();
            this.btnIngresarVehiculo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMontoFabricacion = new System.Windows.Forms.TextBox();
            this.tbAñoFabricacion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbAltaEmbarque = new System.Windows.Forms.GroupBox();
            this.btnIniciarEmbarque = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNroEmbarque = new System.Windows.Forms.TextBox();
            this.gbVehiculo.SuspendLayout();
            this.gbAltaEmbarque.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVehiculo
            // 
            this.gbVehiculo.Controls.Add(this.btnIngresarVehiculo);
            this.gbVehiculo.Controls.Add(this.label4);
            this.gbVehiculo.Controls.Add(this.label3);
            this.gbVehiculo.Controls.Add(this.tbMontoFabricacion);
            this.gbVehiculo.Controls.Add(this.tbAñoFabricacion);
            this.gbVehiculo.Enabled = false;
            this.gbVehiculo.Location = new System.Drawing.Point(18, 132);
            this.gbVehiculo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbVehiculo.Name = "gbVehiculo";
            this.gbVehiculo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbVehiculo.Size = new System.Drawing.Size(495, 118);
            this.gbVehiculo.TabIndex = 4;
            this.gbVehiculo.TabStop = false;
            this.gbVehiculo.Text = "Vehículo del embarque";
            // 
            // btnIngresarVehiculo
            // 
            this.btnIngresarVehiculo.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnIngresarVehiculo.Location = new System.Drawing.Point(338, 26);
            this.btnIngresarVehiculo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresarVehiculo.Name = "btnIngresarVehiculo";
            this.btnIngresarVehiculo.Size = new System.Drawing.Size(141, 72);
            this.btnIngresarVehiculo.TabIndex = 6;
            this.btnIngresarVehiculo.Text = "Ingresar Vehiculo del embarque ingresante";
            this.btnIngresarVehiculo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monto de fabricación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Año de fabricación";
            // 
            // tbMontoFabricacion
            // 
            this.tbMontoFabricacion.Location = new System.Drawing.Point(178, 68);
            this.tbMontoFabricacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMontoFabricacion.Name = "tbMontoFabricacion";
            this.tbMontoFabricacion.Size = new System.Drawing.Size(148, 26);
            this.tbMontoFabricacion.TabIndex = 5;
            // 
            // tbAñoFabricacion
            // 
            this.tbAñoFabricacion.Location = new System.Drawing.Point(178, 29);
            this.tbAñoFabricacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAñoFabricacion.Name = "tbAñoFabricacion";
            this.tbAñoFabricacion.Size = new System.Drawing.Size(148, 26);
            this.tbAñoFabricacion.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(62, 260);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(178, 62);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar y Terminar Proceso";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(298, 260);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(170, 62);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gbAltaEmbarque
            // 
            this.gbAltaEmbarque.Controls.Add(this.btnIniciarEmbarque);
            this.gbAltaEmbarque.Controls.Add(this.label2);
            this.gbAltaEmbarque.Controls.Add(this.tbNroEmbarque);
            this.gbAltaEmbarque.Location = new System.Drawing.Point(18, 18);
            this.gbAltaEmbarque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAltaEmbarque.Name = "gbAltaEmbarque";
            this.gbAltaEmbarque.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAltaEmbarque.Size = new System.Drawing.Size(495, 105);
            this.gbAltaEmbarque.TabIndex = 11;
            this.gbAltaEmbarque.TabStop = false;
            this.gbAltaEmbarque.Text = "Datos del embarque ingresante";
            // 
            // btnIniciarEmbarque
            // 
            this.btnIniciarEmbarque.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnIniciarEmbarque.Location = new System.Drawing.Point(338, 29);
            this.btnIniciarEmbarque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIniciarEmbarque.Name = "btnIniciarEmbarque";
            this.btnIniciarEmbarque.Size = new System.Drawing.Size(141, 63);
            this.btnIniciarEmbarque.TabIndex = 4;
            this.btnIniciarEmbarque.Text = "Alta Embarque";
            this.btnIniciarEmbarque.UseVisualStyleBackColor = true;
            this.btnIniciarEmbarque.Click += new System.EventHandler(this.btnIniciarEmbarque_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número embarque";
            // 
            // tbNroEmbarque
            // 
            this.tbNroEmbarque.Location = new System.Drawing.Point(178, 46);
            this.tbNroEmbarque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNroEmbarque.Name = "tbNroEmbarque";
            this.tbNroEmbarque.Size = new System.Drawing.Size(148, 26);
            this.tbNroEmbarque.TabIndex = 2;
            // 
            // FormDatosEmbarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 334);
            this.Controls.Add(this.gbAltaEmbarque);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbVehiculo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDatosEmbarque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ingresando embarque a la concesionaria";
            this.gbVehiculo.ResumeLayout(false);
            this.gbVehiculo.PerformLayout();
            this.gbAltaEmbarque.ResumeLayout(false);
            this.gbAltaEmbarque.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbMontoFabricacion;
        public System.Windows.Forms.TextBox tbAñoFabricacion;
        public System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnIngresarVehiculo;
        private System.Windows.Forms.GroupBox gbAltaEmbarque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIniciarEmbarque;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox tbNroEmbarque;
    }
}