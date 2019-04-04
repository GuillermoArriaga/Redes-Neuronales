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
    public partial class fAprendizajeHebbianoMultiple : Form
    {
        string tipo;

        public fAprendizajeHebbianoMultiple(string tipo1)
        {
            InitializeComponent();
            tipo = tipo1;
            this.Text = "Aprendizaje Hebbiano para mas de un " + tipo1;
        }

        private void btGenerar_Click(object sender, EventArgs e)
        {
            int cantPercep = 0;
            try
            {
                cantPercep = Convert.ToInt32(tbCantidadPerceptrones.Text);
            }
            catch
            {
                MessageBox.Show("Indique la cantidad de Perceptrones con un entero positivo y vuelva a intentarlo.");
            }

            for (int i = cantPercep; i > 0; i--)
            {
                new fAprendizajeHebbiano(tipo, i).Show();
            }
        }
    }
}