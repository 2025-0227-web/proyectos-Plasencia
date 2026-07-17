namespace Proyecto_de_calculo_ll
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtLimiteA = new System.Windows.Forms.TextBox();
            this.txtLimiteB = new System.Windows.Forms.TextBox();
            this.txtIntervalos = new System.Windows.Forms.TextBox();
            this.cmbFunciones = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Cyan;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(710, 194);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(209, 70);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular Longitud de  Arco";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtLimiteA
            // 
            this.txtLimiteA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtLimiteA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimiteA.Location = new System.Drawing.Point(514, 95);
            this.txtLimiteA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLimiteA.Multiline = true;
            this.txtLimiteA.Name = "txtLimiteA";
            this.txtLimiteA.Size = new System.Drawing.Size(150, 41);
            this.txtLimiteA.TabIndex = 1;
            this.txtLimiteA.Text = "0";
            // 
            // txtLimiteB
            // 
            this.txtLimiteB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtLimiteB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimiteB.Location = new System.Drawing.Point(790, 95);
            this.txtLimiteB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLimiteB.Multiline = true;
            this.txtLimiteB.Name = "txtLimiteB";
            this.txtLimiteB.Size = new System.Drawing.Size(129, 41);
            this.txtLimiteB.TabIndex = 2;
            this.txtLimiteB.Text = "2";
            // 
            // txtIntervalos
            // 
            this.txtIntervalos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtIntervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntervalos.Location = new System.Drawing.Point(1022, 95);
            this.txtIntervalos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIntervalos.Multiline = true;
            this.txtIntervalos.Name = "txtIntervalos";
            this.txtIntervalos.Size = new System.Drawing.Size(136, 41);
            this.txtIntervalos.TabIndex = 3;
            this.txtIntervalos.Text = "1000";
            // 
            // cmbFunciones
            // 
            this.cmbFunciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmbFunciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFunciones.FormattingEnabled = true;
            this.cmbFunciones.Items.AddRange(new object[] {
            "f(x) = x^2",
            "f(x) = (2/3)x^(3/2)",
            "f(x) =Lineal simple (f(x)=x)"});
            this.cmbFunciones.Location = new System.Drawing.Point(980, 212);
            this.cmbFunciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFunciones.Name = "cmbFunciones";
            this.cmbFunciones.Size = new System.Drawing.Size(272, 33);
            this.cmbFunciones.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(639, 370);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(372, 30);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Longitud de la curva S = 0.0000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1551, 630);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmbFunciones);
            this.Controls.Add(this.txtIntervalos);
            this.Controls.Add(this.txtLimiteB);
            this.Controls.Add(this.txtLimiteA);
            this.Controls.Add(this.btnCalcular);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtLimiteA;
        private System.Windows.Forms.TextBox txtLimiteB;
        private System.Windows.Forms.TextBox txtIntervalos;
        private System.Windows.Forms.ComboBox cmbFunciones;
        private System.Windows.Forms.Label lblResultado;
    }
}

