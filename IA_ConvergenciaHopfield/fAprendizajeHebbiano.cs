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
    public partial class fAprendizajeHebbiano : Form
    {
        int entradas;
        int vectores;
        string tipo;

        public fAprendizajeHebbiano(string tipo1, int numero1)
        {
            InitializeComponent();

            tipo = tipo1;

            this.Text = "Aprendizaje Hebbiano para ";

            if (numero1 == 0) this.Text += "un " + tipo1;
            if (numero1 > 0) this.Text += "el " + tipo1 + " " + numero1;

            switch (tipo1)
            {
                case "perceptron":
                    if (numero1 == 0)
                    {
                        Ejemplo();
                        entradas = 2;
                        vectores = 3;
                        tbEntradas.Text = "2";
                        tbVectores.Text = "3";
                    }
                    else
                    {
                        entradas = 0;
                        vectores = 0;
                        tbEntradas.Text = "";
                        tbVectores.Text = "";
                    }
                    break;

                case "adaline":
                    tbFactorAprendizaje.Text = "0.1";
                    rbHardLim.Text = "Paro si Error MC < 0.0001";
                    rbHardLimS.Text = "Paro si DeltaEMC < 0.0001";
                    rbParoIterMax.Visible = true;
                    rbParoIterMax.Checked = true;

                    if (numero1 == 0)
                    {
                        Ejemplo();
                        entradas = 2;
                        vectores = 3;
                        tbEntradas.Text = "2";
                        tbVectores.Text = "3";                        
                    }
                    else
                    {
                        entradas = 0;
                        vectores = 0;
                        tbEntradas.Text = "";
                        tbVectores.Text = "";
                    }
                    break;
            }
        }

        public fAprendizajeHebbiano()
        {
            InitializeComponent();
            Ejemplo();
            entradas = 2;
            vectores = 3;
            tbEntradas.Text = "2";
            tbVectores.Text = "3";
            tipo = "perceptron";
        }

        private void btGenerar_Click(object sender, EventArgs e)
        {
            entradas = Convert.ToInt32(tbEntradas.Text);
            vectores = Convert.ToInt32(tbVectores.Text);

            dgvDatos.Rows.Clear();
            dgvDatos.Columns.Clear();

            dgvSalidas.Rows.Clear();
            dgvSalidas.Columns.Clear();

            for (int i = 1; i <= vectores; i++)
            {
                dgvDatos.Columns.Add("X" + i, "X" + i);
                dgvSalidas.Columns.Add("S" + i, "S" + i);
            }

            dgvSalidas.Rows.Add();

            for (int i = 0; i < entradas; i++)
            {
                dgvDatos.Rows.Add();
                //dgvPesos.Rows.Add();
            }
        }

        void Ejemplo()
        {
            dgvDatos.Columns.Clear();
            dgvSalidas.Columns.Clear();

            for (int i = 1; i <= 3; i++)
            {
                dgvDatos.Columns.Add("X" + i, "X" + i);
                dgvSalidas.Columns.Add("S" + i, "S" + i);
            }
            dgvDatos.Rows.Add(1, -1, 0);
            dgvDatos.Rows.Add(2, 2, -1);
            dgvSalidas.Rows.Add(1, 0, 0);
        }

        private void PrepararTablaIteraciones()
        {
            // Tabla de resultados por iteracion
            dgvIteraciones.Columns.Clear();
            dgvIteraciones.Columns.Add("Iteracion", "Iteracion");

            if (tipo == "perceptron")
            {
                dgvIteraciones.Columns.Add("colUmbral", "Umbral");
            }
            if (tipo == "adaline")
            {
                dgvIteraciones.Columns.Add("colError", "Error Medio Cuadratico");
            }
            for (int k = 1; k <= entradas; k++)
            {
                dgvIteraciones.Columns.Add("e" + k, "e" + k);
            }
        }

        private void ResultadoPorIteracion(int iteracion1, double especial1, double[] pesos1)
        {
            double especial = especial1;   // Si es perceptron, es el umbral. Si es adaline es el error medio cuadratico

            dgvIteraciones.Rows.Add(iteracion1, especial1);

            int n = dgvIteraciones.Rows.Count - 1;
            for (int ent = 0; ent < entradas; ent++)
            {
                dgvIteraciones[2+ent, n].Value = pesos1[ent].ToString();
            }

            int maxFilas = Convert.ToInt32(tbUltimasIteraciones.Text);

            if (dgvIteraciones.Rows.Count > maxFilas)
            {
                dgvIteraciones.Rows.RemoveAt(0);
            }
            dgvIteraciones.CurrentCell = dgvIteraciones[0, dgvIteraciones.Rows.Count - 1];
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double[,] Vectores = new double[vectores, entradas];
            double[] Salida = new double[vectores];
            double[] VectorPesosSinapticos = new double[entradas];
            double Umbral = 0;
            double SalidaParcial;
            double ErrorParcial;
            double tolerancia = 0.0001;
            int iteracion;
            int columna;
            chbxExito.Checked = false;   // Permanece false si no logra exito
            double factorAprendizaje = Convert.ToDouble(tbFactorAprendizaje.Text);
            int iteracionesMax = 1 + Convert.ToInt32(tbIteracionesMax.Text);

            PrepararTablaIteraciones();

            // =================================================    CAPTURA DE DATOS 
            //tolerancia = Math.Abs(Convert.ToDouble(dgvDatos[0, 0].Value));
            for (columna = 0; columna < vectores; columna++)
            {
                for (int i = 0; i < entradas; i++)
                {
                    Vectores[columna, i] = Convert.ToDouble(dgvDatos[columna, i].Value);
                    /*
                    if (tolerancia > Math.Abs(Vectores[columna, i]))
                    {
                        tolerancia = Math.Abs(Vectores[columna, i]);
                    }
                    */
                    VectorPesosSinapticos[i] = 1;
                }
                Salida[columna] = Convert.ToDouble(dgvSalidas[columna, 0].Value);
            }
            //tolerancia /= 1000;   // La tolerancia es una milesima parte del la entrada mas pequeña en valor absoluto
            //if (tolerancia == 0) tolerancia = 0.001;


            // Cada iteracion es un paso desde el vector inicial hasta el final o hasta un vector donde falle
            //    Si uno fallo, se corrige y se revisa desde el principio, habra solución cuando el error sea
            //    cero en el ultimo vector, para llegar a el hubo error cero en los anteriores


            // =================================================    PERCEPTRON
            if (tipo == "perceptron")
            {
                for (iteracion = 1; iteracion < iteracionesMax; iteracion++)
                {
                    // Revision de salidas con pesos actuales por cada vector
                    for (columna = 0; columna < vectores; columna++)
                    {
                        SalidaParcial = 0;    // Sera salida parcial despues de aplicar hardlim o hardlims
                        ErrorParcial = 0;

                        for (int i = 0; i < entradas; i++)
                        {
                            SalidaParcial += Vectores[columna, i] * VectorPesosSinapticos[i];
                        }
                        SalidaParcial += Umbral;

                        // Aplicacion de HardLim o HardLimS
                        if (SalidaParcial >= 0) SalidaParcial = 1;
                        else
                        {
                            if (rbHardLim.Checked) SalidaParcial = 0;
                            if (rbHardLimS.Checked) SalidaParcial = -1;
                        }

                        // Deteccion de error = (esperado - obtenido)
                        ErrorParcial = Salida[columna] - SalidaParcial;

                        // Arreglo si hubo error
                        if (ErrorParcial != 0)
                        {
                            // Vector de pesos nuevo
                            for (int i = 0; i < entradas; i++)
                            {
                                VectorPesosSinapticos[i] += ErrorParcial * Vectores[columna, i] * factorAprendizaje;
                            }
                            // Umbral nuevo
                            Umbral += ErrorParcial;

                            // Deja de verificar posibles siguientes y va a siguiente iteracion
                            //columna = vectores + 1;
                            break;
                        }
                    }

                    // Revision de salida
                    if (columna == vectores)
                    {
                        // Hubo exito
                        //     Impresion de resultados
                        dgvPesos.Rows.Clear();
                        tbIteraciones.Text = iteracion.ToString();
                        tbUmbral.Text = Umbral.ToString();
                        for (int i = 0; i < entradas; i++)
                        {
                            dgvPesos.Rows.Add(VectorPesosSinapticos[i]);
                        }
                        chbxExito.Checked = true;
                    }

                    // Resultado parcial de la iteracion
                    ResultadoPorIteracion(iteracion, Umbral, VectorPesosSinapticos);

                    // Posible fin de iteraciones
                    if (chbxExito.Checked) break;
                }
                if (!chbxExito.Checked)
                {
                    // No hubo exito
                    //     Impresion de resultados parciales alcanzados
                    dgvPesos.Rows.Clear();
                    tbIteraciones.Text = (iteracion - 1).ToString();
                    tbUmbral.Text = Umbral.ToString();
                    for (int i = 0; i < entradas; i++)
                    {
                        dgvPesos.Rows.Add(VectorPesosSinapticos[i]);
                    }

                    // Resultado parcial de la ultima iteracion
                    //ResultadoPorIteracion(iteracion-1, Umbral, VectorPesosSinapticos);
                }
            }

            // =================================================    ADALINE
            // No usa umbral
            // Minimiza el error medio cuadratico de las entradas anteriores y nuevas de cada vector integrante
            // La minimizacion de Suma( 0.5(anterior - nuevo)^2) es en su derivada = |nuevo - anterior| < tolerancia

            if (tipo == "adaline")
            {
                lbUmbral.Text = "Error MC:";
                for (iteracion = 1; iteracion < iteracionesMax; iteracion++)
                {
                    // Revision de salidas con pesos actuales por cada vector
                    for (columna = 0; columna < vectores; columna++)
                    {
                        SalidaParcial = 0;
                        ErrorParcial = 0;

                        for (int i = 0; i < entradas; i++)
                        {
                            SalidaParcial += Vectores[columna, i] * VectorPesosSinapticos[i];
                        }

                        // Salida Parcial pasa igual por funcion identidad

                        // Deteccion de error = (esperado - obtenido)
                        ErrorParcial = Salida[columna] - SalidaParcial;

                        // Vector de pesos nuevo
                        for (int i = 0; i < entradas; i++)
                        {
                            VectorPesosSinapticos[i] += ErrorParcial * Vectores[columna, i] * factorAprendizaje;
                        }
                    }

                    // Obtencion de error medio cuadratico 
                    ErrorParcial = 0;
                    for (columna = 0; columna < vectores; columna++)
                    {
                        SalidaParcial = 0;
                        for (int i = 0; i < entradas; i++)
                        {
                            SalidaParcial += Vectores[columna, i] * VectorPesosSinapticos[i];
                        }
                        // Salida Parcial pasa igual por funcion identidad
                        // Deteccion de error += 0.5*(esperado - obtenido)^2
                        ErrorParcial += 0.5 * (Salida[columna] - SalidaParcial) * (Salida[columna] - SalidaParcial);
                    }

                    // Resultado parcial de la iteracion
                    ResultadoPorIteracion(iteracion, ErrorParcial, VectorPesosSinapticos);

                    // Revision de paro
                    bool paro = false;

                    if (rbParoIterMax.Checked)
                    {
                        paro = false;
                    }
                    else if (rbHardLim.Checked && ErrorParcial < tolerancia)   // Paro por EMC < tolerancia
                    {
                        //MessageBox.Show(ErrorParcial.ToString() + " < " + tolerancia.ToString());
                        paro = true;
                    }
                    else if (rbHardLimS.Checked)   // Paro si Delta EMC < tolerancia
                    {
                        try
                        {
                            if ( Convert.ToDouble(dgvIteraciones[1, dgvIteraciones.Rows.Count - 2].Value) - ErrorParcial < tolerancia)
                            {
                                paro = true;
                            }
                        }
                        catch
                        {
                            paro = false;
                        }
                    }

                    if (paro)
                    {
                        // Hubo exito
                        //     Impresion de resultados
                        dgvPesos.Rows.Clear();
                        tbIteraciones.Text = iteracion.ToString();
                        tbUmbral.Text = Umbral.ToString();
                        for (int i = 0; i < entradas; i++)
                        {
                            dgvPesos.Rows.Add(VectorPesosSinapticos[i]);
                        }
                        chbxExito.Checked = true;
                    }

                    tbUmbral.Text = ErrorParcial.ToString();
                    if (chbxExito.Checked) break;
                }
                if (!chbxExito.Checked)
                {
                    // No hubo exito
                    //     Impresion de resultados parciales alcanzados
                    dgvPesos.Rows.Clear();
                    tbIteraciones.Text = (iteracion - 1).ToString();
                    for (int i = 0; i < entradas; i++)
                    {
                        dgvPesos.Rows.Add(VectorPesosSinapticos[i]);
                    }
                }
            }
        }
    }
}