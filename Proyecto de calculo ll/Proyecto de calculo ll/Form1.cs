using System;
using System.Windows.Forms;

namespace Proyecto_de_calculo_ll
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            
            cmbFunciones.SelectedIndex = 0;
        }

        // ==========================================
        // 1. FUNCIONES MATEMÁTICAS ORIGINALES f(x)
        // ==========================================
        private double Funcion(double x, int opcion)
        {
            switch (opcion)
            {
                case 0: return x * x;                               
                case 1: return (2.0 / 3.0) * Math.Pow(x, 1.5);      
                case 2: return x;                                   
                default: return x;
            }
        }

        // ==========================================
        // 2. DERIVADAS ANALÍTICAS f'(x)
        // ==========================================
        private double Derivada(double x, int opcion)
        {
            switch (opcion)
            {
                case 0: return 2 * x;                               
                case 1: return Math.Sqrt(x);                        
                case 2: return 1;                                    
                default: return 1;
            }
        }

        // ==========================================
        // 3. EXPRESIÓN DE LA FÓRMULA: √(1 + [f'(x)]²)
        // ==========================================
        private double FuncionLongitud(double x, int opcion)
        {
            double dy = Derivada(x, opcion); 
            return Math.Sqrt(1 + (dy * dy)); 
        }

    // ==========================================
    // 4. MOTOR DE INTEGRACIÓN (Regla del Trapecio)
    // ==========================================
    private double CalcularLongitudArco(double a, double b, int n, int opcion)
    {
        double h = (b - a) / n;

        double suma = 0.5 * (FuncionLongitud(a, opcion) + FuncionLongitud(b, opcion));


            for (int i = 1; i < n; i++)
            {
                double x = a + i * h;
                suma += FuncionLongitud(x, opcion);
            }
            return suma * h;
        
    }
        // ==========================================
        // 5. EVENTO DE ACCIÓN (Clic en el Botón)
        // ==========================================
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Convierte y extrae los valores que el usuario ingresó en la interfaz gráfica
                double limiteA = Convert.ToDouble(txtLimiteA.Text);
                double limiteB = Convert.ToDouble(txtLimiteB.Text);
                int n = Convert.ToInt32(txtIntervalos.Text);
                int opcionSeleccionada = cmbFunciones.SelectedIndex;

                // Validación matemática para evitar un rango inexistente o inverso
                if (limiteA >= limiteB)
                {
                    MessageBox.Show("El límite inferior 'a' debe ser menor de forma estricta que el límite superior 'b'.", "Error de Rango");
                    return;
                }

                // Ejecuta la rutina matemática principal pasando las variables de la UI
                double longitudTotal = CalcularLongitudArco(limiteA, limiteB, n, opcionSeleccionada);

                // Muestra el resultado final formateado a 4 dígitos decimales (:F4)
                lblResultado.Text = $"Longitud de la curva S = {longitudTotal:F4} unidades";
            }
            catch (FormatException)
            {
                // Atrapa errores en caso de que dejen campos vacíos o introduzcan letras
                MessageBox.Show("Asegúrese de rellenar todas las cajas de texto con formatos numéricos válidos.", "Error de Entrada");
            }
        }
    }
}