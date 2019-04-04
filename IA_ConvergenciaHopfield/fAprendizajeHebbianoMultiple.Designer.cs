namespace IA_ConvergenciaHopfield
{
    partial class fAprendizajeHebbianoMultiple
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCantidadPerceptrones = new System.Windows.Forms.TextBox();
            this.btGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Perceptrones: ";
            // 
            // tbCantidadPerceptrones
            // 
            this.tbCantidadPerceptrones.Location = new System.Drawing.Point(230, 36);
            this.tbCantidadPerceptrones.Name = "tbCantidadPerceptrones";
            this.tbCantidadPerceptrones.Size = new System.Drawing.Size(100, 26);
            this.tbCantidadPerceptrones.TabIndex = 1;
            this.tbCantidadPerceptrones.Text = "2";
            this.tbCantidadPerceptrones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btGenerar
            // 
            this.btGenerar.Location = new System.Drawing.Point(364, 25);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(262, 49);
            this.btGenerar.TabIndex = 2;
            this.btGenerar.Text = "Generar para llenado manual";
            this.btGenerar.UseVisualStyleBackColor = true;
            this.btGenerar.Click += new System.EventHandler(this.btGenerar_Click);
            // 
            // fAprendizajeHebbianoMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 96);
            this.Controls.Add(this.btGenerar);
            this.Controls.Add(this.tbCantidadPerceptrones);
            this.Controls.Add(this.label1);
            this.Name = "fAprendizajeHebbianoMultiple";
            this.Text = "Aprendizaje Hebbiano para Multiples Perceptrones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCantidadPerceptrones;
        private System.Windows.Forms.Button btGenerar;
    }
}