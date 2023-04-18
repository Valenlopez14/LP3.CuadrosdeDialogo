
namespace Clase._18._04.LP3
{
    partial class Form1
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
            this.btnCambiarColor = new System.Windows.Forms.Button();
            this.CDcolor = new System.Windows.Forms.ColorDialog();
            this.FDfuente = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCambioFuente = new System.Windows.Forms.Button();
            this.btnElegirCarpeta = new System.Windows.Forms.Button();
            this.FBcarpeta = new System.Windows.Forms.FolderBrowserDialog();
            this.OFarchivo = new System.Windows.Forms.OpenFileDialog();
            this.btnElegirarchivo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SFGuardar = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnCambiarColor
            // 
            this.btnCambiarColor.Location = new System.Drawing.Point(12, 415);
            this.btnCambiarColor.Name = "btnCambiarColor";
            this.btnCambiarColor.Size = new System.Drawing.Size(105, 23);
            this.btnCambiarColor.TabIndex = 0;
            this.btnCambiarColor.Text = "Cambiar color";
            this.btnCambiarColor.UseVisualStyleBackColor = true;
            this.btnCambiarColor.Click += new System.EventHandler(this.btnCambiarColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prueba de cambio de fuente y colores";
            // 
            // btnCambioFuente
            // 
            this.btnCambioFuente.Location = new System.Drawing.Point(150, 415);
            this.btnCambioFuente.Name = "btnCambioFuente";
            this.btnCambioFuente.Size = new System.Drawing.Size(96, 23);
            this.btnCambioFuente.TabIndex = 2;
            this.btnCambioFuente.Text = "Cambiar Fuente";
            this.btnCambioFuente.UseVisualStyleBackColor = true;
            this.btnCambioFuente.Click += new System.EventHandler(this.btnCambioFuente_Click);
            // 
            // btnElegirCarpeta
            // 
            this.btnElegirCarpeta.Location = new System.Drawing.Point(285, 414);
            this.btnElegirCarpeta.Name = "btnElegirCarpeta";
            this.btnElegirCarpeta.Size = new System.Drawing.Size(86, 23);
            this.btnElegirCarpeta.TabIndex = 3;
            this.btnElegirCarpeta.Text = "Elegir Carpeta";
            this.btnElegirCarpeta.UseVisualStyleBackColor = true;
            this.btnElegirCarpeta.Click += new System.EventHandler(this.btnElegirCarpeta_Click);
            // 
            // OFarchivo
            // 
            this.OFarchivo.FileName = "openFileDialog1";
            // 
            // btnElegirarchivo
            // 
            this.btnElegirarchivo.Location = new System.Drawing.Point(415, 415);
            this.btnElegirarchivo.Name = "btnElegirarchivo";
            this.btnElegirarchivo.Size = new System.Drawing.Size(86, 23);
            this.btnElegirarchivo.TabIndex = 4;
            this.btnElegirarchivo.Text = "Elegir Archivo";
            this.btnElegirarchivo.UseVisualStyleBackColor = true;
            this.btnElegirarchivo.Click += new System.EventHandler(this.btnElegirarchivo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(536, 415);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnElegirarchivo);
            this.Controls.Add(this.btnElegirCarpeta);
            this.Controls.Add(this.btnCambioFuente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCambiarColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCambiarColor;
        private System.Windows.Forms.ColorDialog CDcolor;
        private System.Windows.Forms.FontDialog FDfuente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCambioFuente;
        private System.Windows.Forms.Button btnElegirCarpeta;
        private System.Windows.Forms.FolderBrowserDialog FBcarpeta;
        private System.Windows.Forms.OpenFileDialog OFarchivo;
        private System.Windows.Forms.Button btnElegirarchivo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.SaveFileDialog SFGuardar;
    }
}

