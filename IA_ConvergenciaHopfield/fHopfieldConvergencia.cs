using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA_ConvergenciaHopfield
{
    public partial class fHopfieldConvergencia : Form
    {
        int entradas;
        int vectores;

        public fHopfieldConvergencia()
        {
            InitializeComponent();
            Ejemplo();
            entradas = 3;
            vectores = 4;
        }

        private void btGenerar_Click(object sender, EventArgs e)
        {
            entradas = Convert.ToInt32(tbEntradas.Text);
            vectores = Convert.ToInt32(tbVectores.Text);

            dgvDatos.Rows.Clear();
            dgvDatos.Columns.Clear();

            for (int i = 1; i <= vectores; i++)
                dgvDatos.Columns.Add("X" + i, "X" + i);

            for (int i = 0; i < entradas; i++)
                dgvDatos.Rows.Add();
        }

        void Ejemplo()
        {
            dgvDatos.Columns.Clear();
            for (int i = 1; i <= 4; i++)
            {
                dgvDatos.Columns.Add("X " + i, "X " + i);
            }
            dgvDatos.Rows.Add(-1, 1, -1, 1);
            dgvDatos.Rows.Add(-1, 1, 1, -1);
            dgvDatos.Rows.Add(1, 1, -1, 1);
        }

        void Matriz_A_DGV(int[] dimensiones, double[,] matriz , DataGridView dgv)
        {
            dgv.Columns.Clear();

            for (int columna = 0; columna < dimensiones[1]; columna++)
                dgv.Columns.Add("a" + (columna + 1), "a" + (columna + 1));
            for (int fila = 0; fila < dimensiones[0]; fila++)
                dgv.Rows.Add();

            for (int fila = 0; fila < dimensiones[0]; fila++)
                for (int columna = 0; columna < dimensiones[1]; columna++)
                    dgv[columna, fila].Value = matriz[columna, fila];

            dgv.Show();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double[,] Vectores = new double[vectores, entradas];
            double[,] Matriz = new double[entradas, entradas];
            double[,] Resultados = new double[vectores, entradas];

            for (int columna = 0; columna < vectores; columna++)
                for (int i = 0; i < entradas; i++)
                    Vectores[columna, i] = Convert.ToDouble(dgvDatos[columna, i].Value);

            for (int i = 0; i < entradas; i++)
            {
                Matriz[i, i] = 0;
            }

            for (int i = 0; i < entradas; i++)
            {
                for (int j = i+1; j < entradas; j++)
                {
                    Matriz[i, j] = 0;
                    for (int k = 0; k < vectores; k++)
                    {
                        Matriz[i, j] += Vectores[k, i] * Vectores[k, j];
                    }
                    Matriz[j, i] = Matriz[i, j];
                }
            }

            Matriz_A_DGV(new int[] { entradas, entradas }, Matriz, dgvW);

            for (int fila = 0; fila < entradas; fila++)
            {
                for (int columna = 0; columna < vectores; columna++)
                {
                    Resultados[columna, fila] = 0;
                    for (int k = 0; k < entradas; k++)
                    {
                        Resultados[columna, fila] += Matriz[fila, k] * Vectores[columna, k];
                    }
                }
            }
            
            Matriz_A_DGV(new int[] { entradas, vectores }, Resultados, dgvWV);

            // Salida oficial -1 0 1
            for (int fila = 0; fila < entradas; fila++)
            {
                for (int columna = 0; columna < vectores; columna++)
                {
                    if (Resultados[columna, fila] < 0) Resultados[columna, fila] = -1;
                    //if (Resultados[columna, fila] == 0) Resultados[columna, fila] = 0;
                    if (Resultados[columna, fila] > 0) Resultados[columna, fila] = 1;
                }
            }

            Matriz_A_DGV(new int[] { entradas, vectores }, Resultados, dgvSalida);

            // Estadarización de entradas -1 0 1

            for (int fila = 0; fila < entradas; fila++)
            {
                for (int columna = 0; columna < vectores; columna++)
                {
                    if (Vectores[columna, fila] < 0) Vectores[columna, fila] = -1;
                    if (Vectores[columna, fila] > 0) Vectores[columna, fila] = 1;
                }
            }

            // Convergencia: fin = inicio

            dgvConvergencia.Rows.Clear();
            dgvConvergencia.Columns.Clear();

            for (int i = 1; i <= vectores; i++)
                dgvConvergencia.Columns.Add("X" + i, "X" + i);

            for (int i = 0; i < entradas; i++)
                dgvConvergencia.Rows.Add();


            for (int fila = 0; fila < entradas; fila++)
            {
                for (int columna = 0; columna < vectores; columna++)
                {
                    Resultados[columna, fila] = Resultados[columna, fila] - Vectores[columna, fila];
                    dgvConvergencia[columna, fila].Value = Resultados[columna, fila];

                    if (Resultados[columna, fila] == 0)
                        dgvConvergencia[columna, fila].Style.BackColor = System.Drawing.Color.Yellow;
                }
            }
            
        }
    }
}
