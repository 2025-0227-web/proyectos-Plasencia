using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
            ConfigurarMenu();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void ConfigurarMenu()
        {
            this.Text = "Panel de Control - 30 Ejercicios Académicos";
            this.StartPosition = FormStartPosition.CenterScreen;

            cmbEjercicios.Items.Clear();

            // --- BLOQUE 1: BÁSICOS Y SECUENCIALES ---
            cmbEjercicios.Items.Add("Ejercicio 01: Cálculo de Salario Neto y Horas Extra");
            cmbEjercicios.Items.Add("Ejercicio 02: Descuentos Progresivos de Sueldo");
            cmbEjercicios.Items.Add("Ejercicio 03: Operaciones Aritméticas Básicas");
            cmbEjercicios.Items.Add("Ejercicio 04: Conversión de Unidades de Medida");
            cmbEjercicios.Items.Add("Ejercicio 05: Cálculo de Promedios y Porcentajes");

            // --- BLOQUE 2: ESTRUCTURAS CONDICIONALES ---
            cmbEjercicios.Items.Add("Ejercicio 06: Determinación de Número Mayor y Menor");
            cmbEjercicios.Items.Add("Ejercicio 07: Control de Acceso y Validaciones");
            cmbEjercicios.Items.Add("Ejercicio 08: Clasificación por Rangos de Edad");
            cmbEjercicios.Items.Add("Ejercicio 09: Cálculo de Impuestos sobre Ventas");
            cmbEjercicios.Items.Add("Ejercicio 10: Evaluación de Notas Alumnado");

            // --- BLOQUE 3: ESTRUCTURAS REPETITIVAS (CICLOS) ---
            cmbEjercicios.Items.Add("Ejercicio 11: Sumatoria con Bucle For");
            cmbEjercicios.Items.Add("Ejercicio 12: Contador de Pares e Impares (While)");
            cmbEjercicios.Items.Add("Ejercicio 13: Tabla de Multiplicar Dinámica");
            cmbEjercicios.Items.Add("Ejercicio 14: Validación de Credenciales (Do-While)");
            cmbEjercicios.Items.Add("Ejercicio 15: Cálculo de Factorial de un Número");
            cmbEjercicios.Items.Add("Ejercicio 16: Serie de Fibonacci");
            cmbEjercicios.Items.Add("Ejercicio 17: Control de Inventario Simplificado");
            cmbEjercicios.Items.Add("Ejercicio 18: Generador de Números Primos");
            cmbEjercicios.Items.Add("Ejercicio 19: Promedio de N Números Introducidos");
            cmbEjercicios.Items.Add("Ejercicio 20: Simulación de Cajero Automático");

            // --- BLOQUE 4: ARREGLOS Y COLECCIONES (VECTORES/MATRICES) ---
            cmbEjercicios.Items.Add("Ejercicio 21: Almacenamiento en Vector Lineal");
            cmbEjercicios.Items.Add("Ejercicio 22: Búsqueda de Elementos en Arreglo");
            cmbEjercicios.Items.Add("Ejercicio 23: Ordenamiento de Menor a Mayor");
            cmbEjercicios.Items.Add("Ejercicio 24: Suma y Promedio de una Matriz 2D");
            cmbEjercicios.Items.Add("Ejercicio 25: Registro de Nombres y Datos en Arreglos");

            // --- BLOQUE 5: ALGORITMOS AVANZADOS ---
            cmbEjercicios.Items.Add("Ejercicio 26: Manipulación y Concat de Cadenas");
            cmbEjercicios.Items.Add("Ejercicio 27: Funciones con Retorno Personalizadas");
            cmbEjercicios.Items.Add("Ejercicio 28: Cálculo de Interés Compuesto");
            cmbEjercicios.Items.Add("Ejercicio 29: Juego de Adivinar el Número");
            cmbEjercicios.Items.Add("Ejercicio 30: Reporte Final Resumen de Datos");

            if (cmbEjercicios.Items.Count > 0)
            {
                cmbEjercicios.SelectedIndex = 0;
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            int ejercicioSeleccionado = cmbEjercicios.SelectedIndex + 1;

            switch (ejercicioSeleccionado)
            {
                // --- BLOQUE 1: BÁSICOS (Ejercicios 01 al 05) ---
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    FormBloqueBasicos bloque1 = new FormBloqueBasicos();
                    bloque1.ShowDialog();
                    break;

                // --- BLOQUE 2: CONDICIONALES (Ejercicios 06 al 10) ---
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    FormBloqueCondicionales bloque2 = new FormBloqueCondicionales();
                    bloque2.ShowDialog();
                    break;

                // --- BLOQUE 3: CICLOS (Ejercicios 11 al 20) ---
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    FormBloqueCiclos bloque3 = new FormBloqueCiclos();
                    bloque3.ShowDialog();
                    break;

                // --- BLOQUE 4: ARREGLOS (Ejercicios 21 al 25) ---
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                    FormBloqueArreglos bloque4 = new FormBloqueArreglos();
                    bloque4.ShowDialog();
                    break;

                // --- BLOQUE 5: AVANZADOS (Ejercicios 26 al 30) ---
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                    FormBloqueAvanzados bloque5 = new FormBloqueAvanzados();
                    bloque5.ShowDialog();
                    break;

                default:
                    MessageBox.Show("Opción no válida.", "Error");
                    break;
            }
        }

        private void FormMenuPrincipal_Load_1(object sender, EventArgs e) { }
        private void cmbEjercicios_SelectedIndexChanged(object sender, EventArgs e) { }
        private void FormMenuPrincipal_Click(object sender, EventArgs e) { }
        private void btnAbrir_Click_1(object sender, EventArgs e) { }
    }
}