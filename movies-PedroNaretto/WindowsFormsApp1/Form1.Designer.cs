namespace WindowsFormsApp1
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
            this.PeliculasBoton = new System.Windows.Forms.Button();
            this.ActoresBoton = new System.Windows.Forms.Button();
            this.DirectoresBoton = new System.Windows.Forms.Button();
            this.ProductoresBoton = new System.Windows.Forms.Button();
            this.EstudiosBoton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PeliculasBoton
            // 
            this.PeliculasBoton.Location = new System.Drawing.Point(178, 247);
            this.PeliculasBoton.Name = "PeliculasBoton";
            this.PeliculasBoton.Size = new System.Drawing.Size(75, 23);
            this.PeliculasBoton.TabIndex = 0;
            this.PeliculasBoton.Text = "Peliculas";
            this.PeliculasBoton.UseVisualStyleBackColor = true;
            this.PeliculasBoton.Click += new System.EventHandler(this.PeliculasBoton_Click);
            // 
            // ActoresBoton
            // 
            this.ActoresBoton.Location = new System.Drawing.Point(259, 247);
            this.ActoresBoton.Name = "ActoresBoton";
            this.ActoresBoton.Size = new System.Drawing.Size(75, 23);
            this.ActoresBoton.TabIndex = 1;
            this.ActoresBoton.Text = "Actores";
            this.ActoresBoton.UseVisualStyleBackColor = true;
            // 
            // DirectoresBoton
            // 
            this.DirectoresBoton.Location = new System.Drawing.Point(340, 247);
            this.DirectoresBoton.Name = "DirectoresBoton";
            this.DirectoresBoton.Size = new System.Drawing.Size(75, 23);
            this.DirectoresBoton.TabIndex = 2;
            this.DirectoresBoton.Text = "Directores";
            this.DirectoresBoton.UseVisualStyleBackColor = true;
            // 
            // ProductoresBoton
            // 
            this.ProductoresBoton.Location = new System.Drawing.Point(421, 247);
            this.ProductoresBoton.Name = "ProductoresBoton";
            this.ProductoresBoton.Size = new System.Drawing.Size(75, 23);
            this.ProductoresBoton.TabIndex = 3;
            this.ProductoresBoton.Text = "Productores";
            this.ProductoresBoton.UseVisualStyleBackColor = true;
            // 
            // EstudiosBoton
            // 
            this.EstudiosBoton.Location = new System.Drawing.Point(502, 247);
            this.EstudiosBoton.Name = "EstudiosBoton";
            this.EstudiosBoton.Size = new System.Drawing.Size(75, 23);
            this.EstudiosBoton.TabIndex = 4;
            this.EstudiosBoton.Text = "Estudios";
            this.EstudiosBoton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(178, 146);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(399, 95);
            this.listBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.EstudiosBoton);
            this.Controls.Add(this.ProductoresBoton);
            this.Controls.Add(this.DirectoresBoton);
            this.Controls.Add(this.ActoresBoton);
            this.Controls.Add(this.PeliculasBoton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PeliculasBoton;
        private System.Windows.Forms.Button ActoresBoton;
        private System.Windows.Forms.Button DirectoresBoton;
        private System.Windows.Forms.Button ProductoresBoton;
        private System.Windows.Forms.Button EstudiosBoton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

