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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double sueldo = double.Parse(txtSueldo.Text);
            double descuento = 0;

            if (sueldo <= 1000) descuento = sueldo * 0.10;
            else if (sueldo <= 2000) descuento = sueldo * 0.05;
            else descuento = sueldo * 0.03;

            lblResultado.Text = "Descuento: " + descuento.ToString("C") + " | Neto: " + (sueldo - descuento).ToString("C");
        }
    }
    }

