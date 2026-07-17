using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_formularios
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

            private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Variables
            double tarifa, horas, salario, extra, tarifaExtra;

            // Obtener valores de los cuadros de texto
            horas = double.Parse(txtHoras.Text);
            tarifa = double.Parse(txtTarifa.Text);

            // Lógica del ejercicio
            if (horas <= 40)
            {
                salario = horas * tarifa;
                lblResultado.Text = "El salario es: " + salario.ToString("C");
            }
            else
            {
                extra = horas - 40;
                tarifaExtra = tarifa * 1.5;
                salario = (40 * tarifa) + (extra * tarifaExtra);
                lblResultado.Text = "Salario con extras: " + salario.ToString("C");
            }
        }
    }
    }

