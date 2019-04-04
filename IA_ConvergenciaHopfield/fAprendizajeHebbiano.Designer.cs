namespace IA_ConvergenciaHopfield
{
    partial class fAprendizajeHebbiano
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
            this.btCalcular = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVectores = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEntradas = new System.Windows.Forms.TextBox();
            this.dgvSalidas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btGenerar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIteraciones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chbxExito = new System.Windows.Forms.CheckBox();
            this.dgvPesos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbUmbral = new System.Windows.Forms.Label();
            this.tbUmbral = new System.Windows.Forms.TextBox();
            this.rbHardLim = new System.Windows.Forms.RadioButton();
            this.rbHardLimS = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tbIteracionesMax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbFactorAprendizaje = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvIteraciones = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.tbUltimasIteraciones = new System.Windows.Forms.TextBox();
            this.rbParoIterMax = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIteraciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.YellowGreen;
            this.btCalcular.Location = new System.Drawing.Point(417, 20);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(177, 51);
            this.btCalcular.TabIndex = 0;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(26, 136);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDatos.Size = new System.Drawing.Size(366, 239);
            this.dgvDatos.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cantidad de vectores:";
            // 
            // tbVectores
            // 
            this.tbVectores.Location = new System.Drawing.Point(194, 48);
            this.tbVectores.Name = "tbVectores";
            this.tbVectores.Size = new System.Drawing.Size(51, 26);
            this.tbVectores.TabIndex = 9;
            this.tbVectores.Text = "3";
            this.tbVectores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad de entradas:";
            // 
            // tbEntradas
            // 
            this.tbEntradas.Location = new System.Drawing.Point(194, 22);
            this.tbEntradas.Name = "tbEntradas";
            this.tbEntradas.Size = new System.Drawing.Size(51, 26);
            this.tbEntradas.TabIndex = 6;
            this.tbEntradas.Text = "2";
            this.tbEntradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvSalidas
            // 
            this.dgvSalidas.AllowUserToAddRows = false;
            this.dgvSalidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalidas.Location = new System.Drawing.Point(26, 401);
            this.dgvSalidas.MultiSelect = false;
            this.dgvSalidas.Name = "dgvSalidas";
            this.dgvSalidas.RowHeadersVisible = false;
            this.dgvSalidas.RowTemplate.Height = 28;
            this.dgvSalidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSalidas.Size = new System.Drawing.Size(366, 98);
            this.dgvSalidas.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "VECTORES";
            // 
            // btGenerar
            // 
            this.btGenerar.BackColor = System.Drawing.Color.SandyBrown;
            this.btGenerar.Location = new System.Drawing.Point(259, 20);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(133, 51);
            this.btGenerar.TabIndex = 14;
            this.btGenerar.Text = "Generar";
            this.btGenerar.UseVisualStyleBackColor = false;
            this.btGenerar.Click += new System.EventHandler(this.btGenerar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "SALIDAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Iteraciones:";
            // 
            // tbIteraciones
            // 
            this.tbIteraciones.Location = new System.Drawing.Point(512, 79);
            this.tbIteraciones.Name = "tbIteraciones";
            this.tbIteraciones.ReadOnly = true;
            this.tbIteraciones.Size = new System.Drawing.Size(82, 26);
            this.tbIteraciones.TabIndex = 16;
            this.tbIteraciones.Text = "0";
            this.tbIteraciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(414, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "RESULTADOS:";
            // 
            // chbxExito
            // 
            this.chbxExito.AutoSize = true;
            this.chbxExito.Enabled = false;
            this.chbxExito.Location = new System.Drawing.Point(417, 202);
            this.chbxExito.Name = "chbxExito";
            this.chbxExito.Size = new System.Drawing.Size(172, 24);
            this.chbxExito.TabIndex = 19;
            this.chbxExito.Text = "Encuentro exitoso?";
            this.chbxExito.UseVisualStyleBackColor = true;
            // 
            // dgvPesos
            // 
            this.dgvPesos.AllowUserToAddRows = false;
            this.dgvPesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvPesos.Location = new System.Drawing.Point(417, 267);
            this.dgvPesos.MultiSelect = false;
            this.dgvPesos.Name = "dgvPesos";
            this.dgvPesos.RowHeadersVisible = false;
            this.dgvPesos.RowTemplate.Height = 28;
            this.dgvPesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPesos.Size = new System.Drawing.Size(177, 232);
            this.dgvPesos.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pesos";
            this.Column1.Name = "Column1";
            this.Column1.Width = 89;
            // 
            // lbUmbral
            // 
            this.lbUmbral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUmbral.AutoSize = true;
            this.lbUmbral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUmbral.Location = new System.Drawing.Point(414, 236);
            this.lbUmbral.Name = "lbUmbral";
            this.lbUmbral.Size = new System.Drawing.Size(71, 20);
            this.lbUmbral.TabIndex = 22;
            this.lbUmbral.Text = "Umbral:";
            // 
            // tbUmbral
            // 
            this.tbUmbral.Location = new System.Drawing.Point(512, 230);
            this.tbUmbral.Name = "tbUmbral";
            this.tbUmbral.ReadOnly = true;
            this.tbUmbral.Size = new System.Drawing.Size(82, 26);
            this.tbUmbral.TabIndex = 21;
            this.tbUmbral.Text = "0";
            this.tbUmbral.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbHardLim
            // 
            this.rbHardLim.AutoSize = true;
            this.rbHardLim.Checked = true;
            this.rbHardLim.Location = new System.Drawing.Point(156, 80);
            this.rbHardLim.Name = "rbHardLim";
            this.rbHardLim.Size = new System.Drawing.Size(239, 24);
            this.rbHardLim.TabIndex = 23;
            this.rbHardLim.Text = "HardLim     0 (si <0) 1 (si >=0)";
            this.rbHardLim.UseVisualStyleBackColor = true;
            // 
            // rbHardLimS
            // 
            this.rbHardLimS.AutoSize = true;
            this.rbHardLimS.Location = new System.Drawing.Point(156, 106);
            this.rbHardLimS.Name = "rbHardLimS";
            this.rbHardLimS.Size = new System.Drawing.Size(239, 24);
            this.rbHardLimS.TabIndex = 24;
            this.rbHardLimS.Text = "HardLimS -1 (si <0) 1 (si >=0)";
            this.rbHardLimS.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Iter. Max = ";
            // 
            // tbIteracionesMax
            // 
            this.tbIteracionesMax.Location = new System.Drawing.Point(512, 108);
            this.tbIteracionesMax.Name = "tbIteracionesMax";
            this.tbIteracionesMax.Size = new System.Drawing.Size(82, 26);
            this.tbIteracionesMax.TabIndex = 25;
            this.tbIteracionesMax.Text = "100";
            this.tbIteracionesMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "FacAprend = ";
            // 
            // tbFactorAprendizaje
            // 
            this.tbFactorAprendizaje.Location = new System.Drawing.Point(525, 140);
            this.tbFactorAprendizaje.Name = "tbFactorAprendizaje";
            this.tbFactorAprendizaje.Size = new System.Drawing.Size(69, 26);
            this.tbFactorAprendizaje.TabIndex = 27;
            this.tbFactorAprendizaje.Text = "1";
            this.tbFactorAprendizaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(621, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 40);
            this.label7.TabIndex = 30;
            this.label7.Text = "PESOS parciales\r\npor iteracion";
            // 
            // dgvIteraciones
            // 
            this.dgvIteraciones.AllowUserToAddRows = false;
            this.dgvIteraciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvIteraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIteraciones.Location = new System.Drawing.Point(622, 79);
            this.dgvIteraciones.MultiSelect = false;
            this.dgvIteraciones.Name = "dgvIteraciones";
            this.dgvIteraciones.ReadOnly = true;
            this.dgvIteraciones.RowHeadersVisible = false;
            this.dgvIteraciones.RowTemplate.Height = 28;
            this.dgvIteraciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvIteraciones.Size = new System.Drawing.Size(348, 420);
            this.dgvIteraciones.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(776, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 40);
            this.label10.TabIndex = 32;
            this.label10.Text = "Cantidad de \r\nultimas iteraciones:";
            // 
            // tbUltimasIteraciones
            // 
            this.tbUltimasIteraciones.Location = new System.Drawing.Point(920, 34);
            this.tbUltimasIteraciones.Name = "tbUltimasIteraciones";
            this.tbUltimasIteraciones.Size = new System.Drawing.Size(51, 26);
            this.tbUltimasIteraciones.TabIndex = 31;
            this.tbUltimasIteraciones.Text = "100";
            this.tbUltimasIteraciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbParoIterMax
            // 
            this.rbParoIterMax.AutoSize = true;
            this.rbParoIterMax.Location = new System.Drawing.Point(26, 80);
            this.rbParoIterMax.Name = "rbParoIterMax";
            this.rbParoIterMax.Size = new System.Drawing.Size(124, 24);
            this.rbParoIterMax.TabIndex = 33;
            this.rbParoIterMax.Text = "Paro IterMax";
            this.rbParoIterMax.UseVisualStyleBackColor = true;
            this.rbParoIterMax.Visible = false;
            // 
            // fAprendizajeHebbiano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 511);
            this.Controls.Add(this.rbParoIterMax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbUltimasIteraciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvIteraciones);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbFactorAprendizaje);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbIteracionesMax);
            this.Controls.Add(this.rbHardLimS);
            this.Controls.Add(this.rbHardLim);
            this.Controls.Add(this.lbUmbral);
            this.Controls.Add(this.tbUmbral);
            this.Controls.Add(this.dgvPesos);
            this.Controls.Add(this.chbxExito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbIteraciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btGenerar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvSalidas);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVectores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEntradas);
            this.Controls.Add(this.btCalcular);
            this.Name = "fAprendizajeHebbiano";
            this.Text = "Aprendizaje Hebbiano de un Perceptron";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIteraciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVectores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEntradas;
        private System.Windows.Forms.DataGridView dgvSalidas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btGenerar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIteraciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbxExito;
        private System.Windows.Forms.DataGridView dgvPesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lbUmbral;
        private System.Windows.Forms.TextBox tbUmbral;
        private System.Windows.Forms.RadioButton rbHardLim;
        private System.Windows.Forms.RadioButton rbHardLimS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbIteracionesMax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbFactorAprendizaje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvIteraciones;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbUltimasIteraciones;
        private System.Windows.Forms.RadioButton rbParoIterMax;
    }
}