namespace IA_ConvergenciaHopfield
{
    partial class fHopfieldConvergencia
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
            this.tbEntradas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btGenerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVectores = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.dgvW = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvWV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSalida = new System.Windows.Forms.DataGridView();
            this.dgvConvergencia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvergencia)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEntradas
            // 
            this.tbEntradas.Location = new System.Drawing.Point(202, 52);
            this.tbEntradas.Name = "tbEntradas";
            this.tbEntradas.Size = new System.Drawing.Size(82, 26);
            this.tbEntradas.TabIndex = 0;
            this.tbEntradas.Text = "3";
            this.tbEntradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de entradas:";
            // 
            // btGenerar
            // 
            this.btGenerar.Location = new System.Drawing.Point(339, 52);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(118, 57);
            this.btGenerar.TabIndex = 2;
            this.btGenerar.Text = "Generar";
            this.btGenerar.UseVisualStyleBackColor = true;
            this.btGenerar.Click += new System.EventHandler(this.btGenerar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad de vectores:";
            // 
            // tbVectores
            // 
            this.tbVectores.Location = new System.Drawing.Point(202, 89);
            this.tbVectores.Name = "tbVectores";
            this.tbVectores.Size = new System.Drawing.Size(82, 26);
            this.tbVectores.TabIndex = 3;
            this.tbVectores.Text = "4";
            this.tbVectores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(34, 136);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDatos.Size = new System.Drawing.Size(550, 266);
            this.dgvDatos.TabIndex = 5;
            // 
            // dgvW
            // 
            this.dgvW.AllowUserToAddRows = false;
            this.dgvW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvW.ColumnHeadersVisible = false;
            this.dgvW.Location = new System.Drawing.Point(620, 136);
            this.dgvW.MultiSelect = false;
            this.dgvW.Name = "dgvW";
            this.dgvW.RowHeadersVisible = false;
            this.dgvW.RowTemplate.Height = 28;
            this.dgvW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvW.Size = new System.Drawing.Size(453, 266);
            this.dgvW.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "W: Matriz de pesos sinápticos:";
            // 
            // dgvWV
            // 
            this.dgvWV.AllowUserToAddRows = false;
            this.dgvWV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvWV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWV.Location = new System.Drawing.Point(34, 452);
            this.dgvWV.MultiSelect = false;
            this.dgvWV.Name = "dgvWV";
            this.dgvWV.RowHeadersVisible = false;
            this.dgvWV.RowTemplate.Height = 28;
            this.dgvWV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvWV.Size = new System.Drawing.Size(312, 198);
            this.dgvWV.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "W * vectores renglón:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(709, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vectores convergentes: Todo Amarillo";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(620, 52);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(453, 47);
            this.btCalcular.TabIndex = 13;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Salida:";
            // 
            // dgvSalida
            // 
            this.dgvSalida.AllowUserToAddRows = false;
            this.dgvSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalida.Location = new System.Drawing.Point(368, 452);
            this.dgvSalida.MultiSelect = false;
            this.dgvSalida.Name = "dgvSalida";
            this.dgvSalida.RowHeadersVisible = false;
            this.dgvSalida.RowTemplate.Height = 28;
            this.dgvSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSalida.Size = new System.Drawing.Size(312, 198);
            this.dgvSalida.TabIndex = 14;
            // 
            // dgvConvergencia
            // 
            this.dgvConvergencia.AllowUserToAddRows = false;
            this.dgvConvergencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConvergencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConvergencia.Location = new System.Drawing.Point(713, 452);
            this.dgvConvergencia.MultiSelect = false;
            this.dgvConvergencia.Name = "dgvConvergencia";
            this.dgvConvergencia.RowHeadersVisible = false;
            this.dgvConvergencia.RowTemplate.Height = 28;
            this.dgvConvergencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvConvergencia.Size = new System.Drawing.Size(360, 198);
            this.dgvConvergencia.TabIndex = 16;
            // 
            // fHopfieldConvergencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 681);
            this.Controls.Add(this.dgvConvergencia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvSalida);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvWV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvW);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVectores);
            this.Controls.Add(this.btGenerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEntradas);
            this.Name = "fHopfieldConvergencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inteligencia Artificial: Redes Neuronales: Verificador de convergencia en Red Hop" +
    "field";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvergencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEntradas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGenerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVectores;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridView dgvW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvWV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvSalida;
        private System.Windows.Forms.DataGridView dgvConvergencia;
    }
}

