using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double factorial(int numero1)
        {
            int factor = 1;

            for (int i = 1; i <= numero1; i++)
            {

                factor = factor * i;

            }

            return factor;
        }

        double potencias(int factor, int numeroM)
        {

            int poten = 1;

            for (int i = 1; i <= factor; i++)
            {

                poten = poten * numeroM;

            }
            return poten;
        }

        double series(int numeroM, int numeroN)
        {
            double result = 0;

            double resultadopotencia, resultadofactorial;

            for (int i = 1; i <= numeroM; i++)
            {

                resultadopotencia = potencias(i, numeroM);

                resultadofactorial = factorial(i);

                result = result + resultadopotencia / resultadofactorial;

            }

            return result;
        }

        private void buno_Click(object sender, EventArgs e)
        {
            int numeroM, numeroN;

            double definitivo;


            numeroM = int.Parse(boxuno.Text);

            numeroN = int.Parse(boxdos.Text);


            definitivo = series(numeroM, numeroN);

            MessageBox.Show("La serie de los numeros esritos es: " + definitivo);
        }
    }
    }
