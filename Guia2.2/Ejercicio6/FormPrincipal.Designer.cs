
namespace Ejercicio6
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
            this.gbInformes = new System.Windows.Forms.GroupBox();
            this.btnListadoPagoEnLugar = new System.Windows.Forms.Button();
            this.btnRegistrarActa = new System.Windows.Forms.Button();
            this.btnMayorMonto = new System.Windows.Forms.Button();
            this.lbxInforme = new System.Windows.Forms.ListBox();
            this.btnRecaudacion = new System.Windows.Forms.Button();
            this.gbInformes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInformes
            // 
            this.gbInformes.Controls.Add(this.btnListadoPagoEnLugar);
            this.gbInformes.Controls.Add(this.btnRegistrarActa);
            this.gbInformes.Controls.Add(this.btnMayorMonto);
            this.gbInformes.Controls.Add(this.lbxInforme);
            this.gbInformes.Controls.Add(this.btnRecaudacion);
            this.gbInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformes.Location = new System.Drawing.Point(18, 11);
            this.gbInformes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInformes.Name = "gbInformes";
            this.gbInformes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInformes.Size = new System.Drawing.Size(679, 465);
            this.gbInformes.TabIndex = 2;
            this.gbInformes.TabStop = false;
            this.gbInformes.Text = "Menu";
            // 
            // btnListadoPagoEnLugar
            // 
            this.btnListadoPagoEnLugar.Location = new System.Drawing.Point(520, 28);
            this.btnListadoPagoEnLugar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListadoPagoEnLugar.Name = "btnListadoPagoEnLugar";
            this.btnListadoPagoEnLugar.Size = new System.Drawing.Size(144, 80);
            this.btnListadoPagoEnLugar.TabIndex = 4;
            this.btnListadoPagoEnLugar.Text = "Pagos En el lugar";
            this.btnListadoPagoEnLugar.UseVisualStyleBackColor = true;
            this.btnListadoPagoEnLugar.Click += new System.EventHandler(this.btnListadoPagoEnLugar_Click);
            // 
            // btnRegistrarActa
            // 
            this.btnRegistrarActa.Location = new System.Drawing.Point(21, 28);
            this.btnRegistrarActa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrarActa.Name = "btnRegistrarActa";
            this.btnRegistrarActa.Size = new System.Drawing.Size(158, 80);
            this.btnRegistrarActa.TabIndex = 1;
            this.btnRegistrarActa.Text = "Registrar Acta";
            this.btnRegistrarActa.UseVisualStyleBackColor = true;
            this.btnRegistrarActa.Click += new System.EventHandler(this.btnRegistrarActa_Click);
            // 
            // btnMayorMonto
            // 
            this.btnMayorMonto.Location = new System.Drawing.Point(356, 28);
            this.btnMayorMonto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMayorMonto.Name = "btnMayorMonto";
            this.btnMayorMonto.Size = new System.Drawing.Size(156, 80);
            this.btnMayorMonto.TabIndex = 3;
            this.btnMayorMonto.Text = "Mayor monto";
            this.btnMayorMonto.UseVisualStyleBackColor = true;
            this.btnMayorMonto.Click += new System.EventHandler(this.btnMayorMonto_Click);
            // 
            // lbxInforme
            // 
            this.lbxInforme.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxInforme.FormattingEnabled = true;
            this.lbxInforme.ItemHeight = 16;
            this.lbxInforme.Location = new System.Drawing.Point(9, 115);
            this.lbxInforme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxInforme.Name = "lbxInforme";
            this.lbxInforme.Size = new System.Drawing.Size(655, 340);
            this.lbxInforme.TabIndex = 2;
            // 
            // btnRecaudacion
            // 
            this.btnRecaudacion.Location = new System.Drawing.Point(188, 28);
            this.btnRecaudacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecaudacion.Name = "btnRecaudacion";
            this.btnRecaudacion.Size = new System.Drawing.Size(159, 78);
            this.btnRecaudacion.TabIndex = 1;
            this.btnRecaudacion.Text = "Recaudacion";
            this.btnRecaudacion.UseVisualStyleBackColor = true;
            this.btnRecaudacion.Click += new System.EventHandler(this.btnRecaudacion_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 483);
            this.Controls.Add(this.gbInformes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de infracciones";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.gbInformes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbInformes;
        private System.Windows.Forms.Button btnListadoPagoEnLugar;
        private System.Windows.Forms.Button btnMayorMonto;
        private System.Windows.Forms.ListBox lbxInforme;
        private System.Windows.Forms.Button btnRecaudacion;
        private System.Windows.Forms.Button btnRegistrarActa;
    }
}

