namespace Prueba
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
            this.boxdos = new System.Windows.Forms.TextBox();
            this.buno = new System.Windows.Forms.Button();
            this.boxuno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boxdos
            // 
            this.boxdos.Location = new System.Drawing.Point(299, 185);
            this.boxdos.Name = "boxdos";
            this.boxdos.Size = new System.Drawing.Size(202, 22);
            this.boxdos.TabIndex = 5;
            // 
            // buno
            // 
            this.buno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buno.Location = new System.Drawing.Point(299, 230);
            this.buno.Name = "buno";
            this.buno.Size = new System.Drawing.Size(202, 76);
            this.buno.TabIndex = 4;
            this.buno.Text = "Calcular:";
            this.buno.UseVisualStyleBackColor = false;
            this.buno.Click += new System.EventHandler(this.buno_Click);
            // 
            // boxuno
            // 
            this.boxuno.Location = new System.Drawing.Point(299, 145);
            this.boxuno.Name = "boxuno";
            this.boxuno.Size = new System.Drawing.Size(202, 22);
            this.boxuno.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxdos);
            this.Controls.Add(this.buno);
            this.Controls.Add(this.boxuno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxdos;
        private System.Windows.Forms.Button buno;
        private System.Windows.Forms.TextBox boxuno;
    }
}

