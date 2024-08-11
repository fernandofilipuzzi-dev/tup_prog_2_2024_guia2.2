
namespace Ejercicio2
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
            this.btnIniciarEmbarque = new System.Windows.Forms.Button();
            this.gbInforme = new System.Windows.Forms.GroupBox();
            this.btnListadoEmbarques = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEmbarquePorNumero = new System.Windows.Forms.Button();
            this.tbNumeroEmbBusq = new System.Windows.Forms.TextBox();
            this.btnEmbarqueMayor = new System.Windows.Forms.Button();
            this.ltbInforme = new System.Windows.Forms.ListBox();
            this.btnRecaudacion = new System.Windows.Forms.Button();
            this.gbInforme.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarEmbarque
            // 
            this.btnIniciarEmbarque.Location = new System.Drawing.Point(282, 11);
            this.btnIniciarEmbarque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIniciarEmbarque.Name = "btnIniciarEmbarque";
            this.btnIniciarEmbarque.Size = new System.Drawing.Size(244, 63);
            this.btnIniciarEmbarque.TabIndex = 3;
            this.btnIniciarEmbarque.Text = "Alta Embarque";
            this.btnIniciarEmbarque.UseVisualStyleBackColor = true;
            this.btnIniciarEmbarque.Click += new System.EventHandler(this.btnIniciarEmbarque_Click);
            // 
            // gbInforme
            // 
            this.gbInforme.Controls.Add(this.btnListadoEmbarques);
            this.gbInforme.Controls.Add(this.groupBox5);
            this.gbInforme.Controls.Add(this.btnEmbarqueMayor);
            this.gbInforme.Controls.Add(this.ltbInforme);
            this.gbInforme.Controls.Add(this.btnRecaudacion);
            this.gbInforme.Enabled = false;
            this.gbInforme.Location = new System.Drawing.Point(18, 74);
            this.gbInforme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInforme.Name = "gbInforme";
            this.gbInforme.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInforme.Size = new System.Drawing.Size(819, 428);
            this.gbInforme.TabIndex = 2;
            this.gbInforme.TabStop = false;
            this.gbInforme.Text = "Informe";
            // 
            // btnListadoEmbarques
            // 
            this.btnListadoEmbarques.Location = new System.Drawing.Point(698, 263);
            this.btnListadoEmbarques.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListadoEmbarques.Name = "btnListadoEmbarques";
            this.btnListadoEmbarques.Size = new System.Drawing.Size(112, 55);
            this.btnListadoEmbarques.TabIndex = 14;
            this.btnListadoEmbarques.Text = "Todos los embarues";
            this.btnListadoEmbarques.UseVisualStyleBackColor = true;
            this.btnListadoEmbarques.Click += new System.EventHandler(this.btnListadoEmbarques_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.btnEmbarquePorNumero);
            this.groupBox5.Controls.Add(this.tbNumeroEmbBusq);
            this.groupBox5.Location = new System.Drawing.Point(9, 29);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(801, 86);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ver Embarque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número embarque";
            // 
            // btnEmbarquePorNumero
            // 
            this.btnEmbarquePorNumero.Location = new System.Drawing.Point(554, 23);
            this.btnEmbarquePorNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmbarquePorNumero.Name = "btnEmbarquePorNumero";
            this.btnEmbarquePorNumero.Size = new System.Drawing.Size(225, 48);
            this.btnEmbarquePorNumero.TabIndex = 10;
            this.btnEmbarquePorNumero.Text = "Buscar Embarque";
            this.btnEmbarquePorNumero.UseVisualStyleBackColor = true;
            this.btnEmbarquePorNumero.Click += new System.EventHandler(this.btnEmbarquePorNumero_Click);
            // 
            // tbNumeroEmbBusq
            // 
            this.tbNumeroEmbBusq.Location = new System.Drawing.Point(176, 32);
            this.tbNumeroEmbBusq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNumeroEmbBusq.Name = "tbNumeroEmbBusq";
            this.tbNumeroEmbBusq.Size = new System.Drawing.Size(344, 26);
            this.tbNumeroEmbBusq.TabIndex = 9;
            // 
            // btnEmbarqueMayor
            // 
            this.btnEmbarqueMayor.Location = new System.Drawing.Point(698, 198);
            this.btnEmbarqueMayor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmbarqueMayor.Name = "btnEmbarqueMayor";
            this.btnEmbarqueMayor.Size = new System.Drawing.Size(112, 55);
            this.btnEmbarqueMayor.TabIndex = 13;
            this.btnEmbarqueMayor.Text = "Embarque Mayor";
            this.btnEmbarqueMayor.UseVisualStyleBackColor = true;
            this.btnEmbarqueMayor.Click += new System.EventHandler(this.btnEmbarqueMayor_Click);
            // 
            // ltbInforme
            // 
            this.ltbInforme.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbInforme.FormattingEnabled = true;
            this.ltbInforme.ItemHeight = 16;
            this.ltbInforme.Location = new System.Drawing.Point(9, 134);
            this.ltbInforme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ltbInforme.Name = "ltbInforme";
            this.ltbInforme.Size = new System.Drawing.Size(678, 260);
            this.ltbInforme.TabIndex = 11;
            // 
            // btnRecaudacion
            // 
            this.btnRecaudacion.Location = new System.Drawing.Point(698, 134);
            this.btnRecaudacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecaudacion.Name = "btnRecaudacion";
            this.btnRecaudacion.Size = new System.Drawing.Size(112, 55);
            this.btnRecaudacion.TabIndex = 12;
            this.btnRecaudacion.Text = "Resumen del día";
            this.btnRecaudacion.UseVisualStyleBackColor = true;
            this.btnRecaudacion.Click += new System.EventHandler(this.btnRecaudacion_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 509);
            this.Controls.Add(this.gbInforme);
            this.Controls.Add(this.btnIniciarEmbarque);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi concesionaria";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.gbInforme.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIniciarEmbarque;
        private System.Windows.Forms.GroupBox gbInforme;
        private System.Windows.Forms.Button btnListadoEmbarques;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnEmbarquePorNumero;
        private System.Windows.Forms.TextBox tbNumeroEmbBusq;
        private System.Windows.Forms.Button btnEmbarqueMayor;
        private System.Windows.Forms.ListBox ltbInforme;
        private System.Windows.Forms.Button btnRecaudacion;
        private System.Windows.Forms.Label label5;
    }
}

