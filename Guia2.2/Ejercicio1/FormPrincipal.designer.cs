
namespace Ej1_Encuesta
{
    partial class FormPrincipal
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
            this.btnRegistroDeEncuesta = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.btnListadoContactables = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistroDeEncuesta
            // 
            this.btnRegistroDeEncuesta.Location = new System.Drawing.Point(90, 39);
            this.btnRegistroDeEncuesta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistroDeEncuesta.Name = "btnRegistroDeEncuesta";
            this.btnRegistroDeEncuesta.Size = new System.Drawing.Size(274, 58);
            this.btnRegistroDeEncuesta.TabIndex = 0;
            this.btnRegistroDeEncuesta.Text = "Registro De Encuesta";
            this.btnRegistroDeEncuesta.UseVisualStyleBackColor = true;
            this.btnRegistroDeEncuesta.Click += new System.EventHandler(this.btnRegistroDeEncuesta_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(90, 107);
            this.btnInforme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(274, 58);
            this.btnInforme.TabIndex = 1;
            this.btnInforme.Text = "Resultados";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // btnListadoContactables
            // 
            this.btnListadoContactables.Location = new System.Drawing.Point(90, 174);
            this.btnListadoContactables.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListadoContactables.Name = "btnListadoContactables";
            this.btnListadoContactables.Size = new System.Drawing.Size(274, 58);
            this.btnListadoContactables.TabIndex = 2;
            this.btnListadoContactables.Text = "Listado contactables";
            this.btnListadoContactables.UseVisualStyleBackColor = true;
            this.btnListadoContactables.Click += new System.EventHandler(this.btnListadoContactables_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 266);
            this.Controls.Add(this.btnListadoContactables);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnRegistroDeEncuesta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secretaría de transporte de su magestad!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistroDeEncuesta;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button btnListadoContactables;
    }
}

