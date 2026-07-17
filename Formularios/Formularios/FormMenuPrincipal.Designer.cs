namespace Formularios
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbEjercicios = new System.Windows.Forms.ComboBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbEjercicios
            // 
            this.cmbEjercicios.FormattingEnabled = true;
            this.cmbEjercicios.Location = new System.Drawing.Point(39, 36);
            this.cmbEjercicios.Name = "cmbEjercicios";
            this.cmbEjercicios.Size = new System.Drawing.Size(179, 21);
            this.cmbEjercicios.TabIndex = 0;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(237, 36);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(106, 23);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir Ejercicio";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.cmbEjercicios);
            this.Name = "FormMenuPrincipal";
            this.Text = "FormMenuPrincipal";
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEjercicios;
        private System.Windows.Forms.Button btnAbrir;
    }
}