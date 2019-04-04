namespace IA_ConvergenciaHopfield
{
    partial class fMenu
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
            this.label2 = new System.Windows.Forms.Label();
            this.btConvergenciaHopfield = new System.Windows.Forms.Button();
            this.btAprendizajeHebbianoUnP = new System.Windows.Forms.Button();
            this.btAprendizajeHebbianoMultipleP = new System.Windows.Forms.Button();
            this.btMadaline = new System.Windows.Forms.Button();
            this.btAdaline = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(116, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "INTELIGENCIA   ARTIFICIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(143, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "REDES   NEURONALES";
            // 
            // btConvergenciaHopfield
            // 
            this.btConvergenciaHopfield.Location = new System.Drawing.Point(24, 181);
            this.btConvergenciaHopfield.Name = "btConvergenciaHopfield";
            this.btConvergenciaHopfield.Size = new System.Drawing.Size(122, 219);
            this.btConvergenciaHopfield.TabIndex = 2;
            this.btConvergenciaHopfield.Text = "Verificador de Convergencia Hopfield";
            this.btConvergenciaHopfield.UseVisualStyleBackColor = true;
            this.btConvergenciaHopfield.Click += new System.EventHandler(this.btConvergenciaHopfield_Click);
            // 
            // btAprendizajeHebbianoUnP
            // 
            this.btAprendizajeHebbianoUnP.Location = new System.Drawing.Point(12, 42);
            this.btAprendizajeHebbianoUnP.Name = "btAprendizajeHebbianoUnP";
            this.btAprendizajeHebbianoUnP.Size = new System.Drawing.Size(205, 77);
            this.btAprendizajeHebbianoUnP.TabIndex = 3;
            this.btAprendizajeHebbianoUnP.Text = "Para un perceptron";
            this.btAprendizajeHebbianoUnP.UseVisualStyleBackColor = true;
            this.btAprendizajeHebbianoUnP.Click += new System.EventHandler(this.btAprendizajeHebbiano_Click);
            // 
            // btAprendizajeHebbianoMultipleP
            // 
            this.btAprendizajeHebbianoMultipleP.Location = new System.Drawing.Point(12, 125);
            this.btAprendizajeHebbianoMultipleP.Name = "btAprendizajeHebbianoMultipleP";
            this.btAprendizajeHebbianoMultipleP.Size = new System.Drawing.Size(205, 77);
            this.btAprendizajeHebbianoMultipleP.TabIndex = 4;
            this.btAprendizajeHebbianoMultipleP.Text = "Para multiples perceptrones";
            this.btAprendizajeHebbianoMultipleP.UseVisualStyleBackColor = true;
            this.btAprendizajeHebbianoMultipleP.Click += new System.EventHandler(this.btAprendizajeHebbianoMultipleP_Click);
            // 
            // btMadaline
            // 
            this.btMadaline.Location = new System.Drawing.Point(235, 125);
            this.btMadaline.Name = "btMadaline";
            this.btMadaline.Size = new System.Drawing.Size(205, 77);
            this.btMadaline.TabIndex = 6;
            this.btMadaline.Text = "Para multiples adalines (madaline)";
            this.btMadaline.UseVisualStyleBackColor = true;
            this.btMadaline.Click += new System.EventHandler(this.btMadaline_Click);
            // 
            // btAdaline
            // 
            this.btAdaline.Location = new System.Drawing.Point(235, 42);
            this.btAdaline.Name = "btAdaline";
            this.btAdaline.Size = new System.Drawing.Size(205, 77);
            this.btAdaline.TabIndex = 5;
            this.btAdaline.Text = "Para adaline";
            this.btAdaline.UseVisualStyleBackColor = true;
            this.btAdaline.Click += new System.EventHandler(this.btAdaline_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAdaline);
            this.groupBox1.Controls.Add(this.btMadaline);
            this.groupBox1.Controls.Add(this.btAprendizajeHebbianoUnP);
            this.groupBox1.Controls.Add(this.btAprendizajeHebbianoMultipleP);
            this.groupBox1.Location = new System.Drawing.Point(172, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 219);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aprendizaje Hebbiano";
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btConvergenciaHopfield);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fMenu";
            this.Text = "Inteligencia Artificial: Menu";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btConvergenciaHopfield;
        private System.Windows.Forms.Button btAprendizajeHebbianoUnP;
        private System.Windows.Forms.Button btAprendizajeHebbianoMultipleP;
        private System.Windows.Forms.Button btMadaline;
        private System.Windows.Forms.Button btAdaline;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}