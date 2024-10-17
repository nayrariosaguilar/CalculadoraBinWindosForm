namespace CalculadoraBin
{
    partial class Calculadora
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
            this.BotonCero = new System.Windows.Forms.Button();
            this.BotonUno = new System.Windows.Forms.Button();
            this.BotonConvertir = new System.Windows.Forms.Button();
            this.BotonLimpiar = new System.Windows.Forms.Button();
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BotonCero
            // 
            this.BotonCero.Location = new System.Drawing.Point(225, 110);
            this.BotonCero.Name = "BotonCero";
            this.BotonCero.Size = new System.Drawing.Size(100, 38);
            this.BotonCero.TabIndex = 0;
            this.BotonCero.Text = "0";
            this.BotonCero.UseVisualStyleBackColor = true;
            this.BotonCero.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BotonUno
            // 
            this.BotonUno.Location = new System.Drawing.Point(343, 110);
            this.BotonUno.Name = "BotonUno";
            this.BotonUno.Size = new System.Drawing.Size(115, 38);
            this.BotonUno.TabIndex = 1;
            this.BotonUno.Text = "1";
            this.BotonUno.UseVisualStyleBackColor = true;
            this.BotonUno.Click += new System.EventHandler(this.button2_Click);
            // 
            // BotonConvertir
            // 
            this.BotonConvertir.Location = new System.Drawing.Point(225, 165);
            this.BotonConvertir.Name = "BotonConvertir";
            this.BotonConvertir.Size = new System.Drawing.Size(233, 32);
            this.BotonConvertir.TabIndex = 2;
            this.BotonConvertir.Text = "Convertir";
            this.BotonConvertir.UseVisualStyleBackColor = true;
            this.BotonConvertir.Click += new System.EventHandler(this.button3_Click);
            // 
            // BotonLimpiar
            // 
            this.BotonLimpiar.Location = new System.Drawing.Point(225, 225);
            this.BotonLimpiar.Name = "BotonLimpiar";
            this.BotonLimpiar.Size = new System.Drawing.Size(233, 32);
            this.BotonLimpiar.TabIndex = 3;
            this.BotonLimpiar.Text = "Limpiar";
            this.BotonLimpiar.UseVisualStyleBackColor = true;
            this.BotonLimpiar.Click += new System.EventHandler(this.button4_Click);
            // 
            // Pantalla
            // 
            this.Pantalla.AccessibleName = "pantalla";
            this.Pantalla.BackColor = System.Drawing.SystemColors.Window;
            this.Pantalla.Enabled = false;
            this.Pantalla.Location = new System.Drawing.Point(225, 69);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(233, 26);
            this.Pantalla.TabIndex = 4;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pantalla);
            this.Controls.Add(this.BotonLimpiar);
            this.Controls.Add(this.BotonConvertir);
            this.Controls.Add(this.BotonUno);
            this.Controls.Add(this.BotonCero);
            this.Name = "Calculadora";
            this.Text = "Calculadora naysita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BotonCero;
        public System.Windows.Forms.Button BotonUno;
        public System.Windows.Forms.Button BotonConvertir;
        public System.Windows.Forms.Button BotonLimpiar;
        public System.Windows.Forms.TextBox Pantalla;
    }
}

