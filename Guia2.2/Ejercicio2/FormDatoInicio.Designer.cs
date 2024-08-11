
namespace Ejercicio2
{
    partial class FormDatoInicio
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
            this.gbInicio = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAñoActual = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInicio
            // 
            this.gbInicio.Controls.Add(this.label1);
            this.gbInicio.Controls.Add(this.tbAñoActual);
            this.gbInicio.Location = new System.Drawing.Point(16, 18);
            this.gbInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInicio.Name = "gbInicio";
            this.gbInicio.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInicio.Size = new System.Drawing.Size(378, 94);
            this.gbInicio.TabIndex = 1;
            this.gbInicio.TabStop = false;
            this.gbInicio.Text = "Inicio Sistema";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Año actual";
            // 
            // tbAñoActual
            // 
            this.tbAñoActual.Location = new System.Drawing.Point(207, 55);
            this.tbAñoActual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAñoActual.Name = "tbAñoActual";
            this.tbAñoActual.Size = new System.Drawing.Size(148, 26);
            this.tbAñoActual.TabIndex = 0;
            this.tbAñoActual.Text = "2023";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(243, 122);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 62);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(44, 122);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(116, 62);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // FormDatoInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 193);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbInicio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDatoInicio";
            this.Text = "Iniciando el sistema";
            this.gbInicio.ResumeLayout(false);
            this.gbInicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInicio;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbAñoActual;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnAceptar;
    }
}