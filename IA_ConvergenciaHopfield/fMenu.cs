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
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        private void btConvergenciaHopfield_Click(object sender, EventArgs e)
        {
            fHopfieldConvergencia objfHopfield = new fHopfieldConvergencia();
            objfHopfield.Show();
        }

        private void btAprendizajeHebbiano_Click(object sender, EventArgs e)
        {
            fAprendizajeHebbiano objfhebb = new fAprendizajeHebbiano("perceptron", 0);
            objfhebb.Show();
        }

        private void btAprendizajeHebbianoMultipleP_Click(object sender, EventArgs e)
        {
            fAprendizajeHebbianoMultiple objfhebbMultiple = new fAprendizajeHebbianoMultiple("perceptron");
            objfhebbMultiple.Show();
        }

        private void btAdaline_Click(object sender, EventArgs e)
        {
            fAprendizajeHebbiano objfhebb = new fAprendizajeHebbiano("adaline", 0);
            objfhebb.Show();
        }

        private void btMadaline_Click(object sender, EventArgs e)
        {
            fAprendizajeHebbianoMultiple objfhebbMultiple = new fAprendizajeHebbianoMultiple("adaline");
            objfhebbMultiple.Show();
        }
    }
}
