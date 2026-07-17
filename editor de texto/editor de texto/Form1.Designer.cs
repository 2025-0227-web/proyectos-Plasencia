namespace editor_de_texto
{
    partial class Form1
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
            this.btnNegrita = new System.Windows.Forms.Button();
            this.btnCursiva = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rtBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnNegrita
            // 
            this.btnNegrita.Location = new System.Drawing.Point(34, 35);
            this.btnNegrita.Name = "btnNegrita";
            this.btnNegrita.Size = new System.Drawing.Size(75, 23);
            this.btnNegrita.TabIndex = 0;
            this.btnNegrita.Text = "N";
            this.btnNegrita.UseVisualStyleBackColor = true;
            // 
            // btnCursiva
            // 
            this.btnCursiva.Location = new System.Drawing.Point(168, 34);
            this.btnCursiva.Name = "btnCursiva";
            this.btnCursiva.Size = new System.Drawing.Size(75, 23);
            this.btnCursiva.TabIndex = 1;
            this.btnCursiva.Text = "I";
            this.btnCursiva.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(291, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "S";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // rtBox
            // 
            this.rtBox.Location = new System.Drawing.Point(34, 90);
            this.rtBox.Name = "rtBox";
            this.rtBox.Size = new System.Drawing.Size(732, 328);
            this.rtBox.TabIndex = 3;
            this.rtBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCursiva);
            this.Controls.Add(this.btnNegrita);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNegrita;
        private System.Windows.Forms.Button btnCursiva;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox rtBox;
    }
}