using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace editor_de_texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
        }
        
            private void CambiarEstiloFuente(FontStyle estilo)
        {
            if (rtBox.SelectionFont == null) return;

            Font fuenteActual = rtBox.SelectionFont;

            FontStyle nuevoEstilo;

            if (fuenteActual.Style.HasFlag(estilo))
            {
                nuevoEstilo = fuenteActual.Style & ~estilo;
            }
            else
            {
                nuevoEstilo = fuenteActual.Style | estilo;
            }

            rtBox.SelectionFont = new Font(fuenteActual.FontFamily, fuenteActual.Size, nuevoEstilo);


        }

        private void btnNegrita_Click(object sender, EventArgs e)
        {
            CambiarEstiloFuente(FontStyle.Bold);
        }

        private void btnCursiva_Click(object sender, EventArgs e)
        {
            CambiarEstiloFuente(FontStyle.Italic);
        }

        private void btnSubrayado_Click(object sender, EventArgs e)
        {
            CambiarEstiloFuente(FontStyle.Underline);

        }
    }
    }

