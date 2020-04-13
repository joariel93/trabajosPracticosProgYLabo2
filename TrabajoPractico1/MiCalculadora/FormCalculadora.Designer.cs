namespace MiCalculadora
{
    partial class laCalculadora
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
            this.calculadoraNumeroDos = new System.Windows.Forms.TextBox();
            this.calculadoraNumeroUno = new System.Windows.Forms.TextBox();
            this.calculadoraBotonOperar = new System.Windows.Forms.Button();
            this.calculadoraBotonLimpiar = new System.Windows.Forms.Button();
            this.calculadoraBotonCerrar = new System.Windows.Forms.Button();
            this.calculadoraBotonConvertirABinario = new System.Windows.Forms.Button();
            this.calculadoraBotonConvertirADecimal = new System.Windows.Forms.Button();
            this.calculadoraResultado = new System.Windows.Forms.Label();
            this.calculadoraOperadores = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // calculadoraNumeroDos
            // 
            this.calculadoraNumeroDos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculadoraNumeroDos.Location = new System.Drawing.Point(254, 68);
            this.calculadoraNumeroDos.Name = "calculadoraNumeroDos";
            this.calculadoraNumeroDos.Size = new System.Drawing.Size(165, 29);
            this.calculadoraNumeroDos.TabIndex = 3;
            this.calculadoraNumeroDos.Text = "Ingrese un número";
            // 
            // calculadoraNumeroUno
            // 
            this.calculadoraNumeroUno.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculadoraNumeroUno.Location = new System.Drawing.Point(12, 68);
            this.calculadoraNumeroUno.Name = "calculadoraNumeroUno";
            this.calculadoraNumeroUno.Size = new System.Drawing.Size(165, 29);
            this.calculadoraNumeroUno.TabIndex = 1;
            this.calculadoraNumeroUno.Text = "Ingrese un número";
            // 
            // calculadoraBotonOperar
            // 
            this.calculadoraBotonOperar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculadoraBotonOperar.Location = new System.Drawing.Point(12, 142);
            this.calculadoraBotonOperar.Name = "calculadoraBotonOperar";
            this.calculadoraBotonOperar.Size = new System.Drawing.Size(125, 37);
            this.calculadoraBotonOperar.TabIndex = 4;
            this.calculadoraBotonOperar.Text = "Operar";
            this.calculadoraBotonOperar.UseVisualStyleBackColor = true;
            // 
            // calculadoraBotonLimpiar
            // 
            this.calculadoraBotonLimpiar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.calculadoraBotonLimpiar.Location = new System.Drawing.Point(154, 142);
            this.calculadoraBotonLimpiar.Name = "calculadoraBotonLimpiar";
            this.calculadoraBotonLimpiar.Size = new System.Drawing.Size(125, 37);
            this.calculadoraBotonLimpiar.TabIndex = 5;
            this.calculadoraBotonLimpiar.Text = "Limpiar";
            this.calculadoraBotonLimpiar.UseVisualStyleBackColor = true;
            // 
            // calculadoraBotonCerrar
            // 
            this.calculadoraBotonCerrar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.calculadoraBotonCerrar.Location = new System.Drawing.Point(294, 142);
            this.calculadoraBotonCerrar.Name = "calculadoraBotonCerrar";
            this.calculadoraBotonCerrar.Size = new System.Drawing.Size(125, 37);
            this.calculadoraBotonCerrar.TabIndex = 6;
            this.calculadoraBotonCerrar.Text = "Cerrar";
            this.calculadoraBotonCerrar.UseVisualStyleBackColor = true;
            this.calculadoraBotonCerrar.Click += new System.EventHandler(this.calculadoraBotonCerrar_Click);
            // 
            // calculadoraBotonConvertirABinario
            // 
            this.calculadoraBotonConvertirABinario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.calculadoraBotonConvertirABinario.Location = new System.Drawing.Point(12, 199);
            this.calculadoraBotonConvertirABinario.Name = "calculadoraBotonConvertirABinario";
            this.calculadoraBotonConvertirABinario.Size = new System.Drawing.Size(201, 37);
            this.calculadoraBotonConvertirABinario.TabIndex = 7;
            this.calculadoraBotonConvertirABinario.Text = "Convertir a Binario";
            this.calculadoraBotonConvertirABinario.UseVisualStyleBackColor = true;
            // 
            // calculadoraBotonConvertirADecimal
            // 
            this.calculadoraBotonConvertirADecimal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.calculadoraBotonConvertirADecimal.Location = new System.Drawing.Point(218, 199);
            this.calculadoraBotonConvertirADecimal.Name = "calculadoraBotonConvertirADecimal";
            this.calculadoraBotonConvertirADecimal.Size = new System.Drawing.Size(201, 37);
            this.calculadoraBotonConvertirADecimal.TabIndex = 8;
            this.calculadoraBotonConvertirADecimal.Text = "Convertir a Decimal";
            this.calculadoraBotonConvertirADecimal.UseVisualStyleBackColor = true;
            // 
            // calculadoraResultado
            // 
            this.calculadoraResultado.Font = new System.Drawing.Font("Arial", 16.25F, System.Drawing.FontStyle.Bold);
            this.calculadoraResultado.Location = new System.Drawing.Point(21, 16);
            this.calculadoraResultado.Name = "calculadoraResultado";
            this.calculadoraResultado.Size = new System.Drawing.Size(387, 42);
            this.calculadoraResultado.TabIndex = 8;
            this.calculadoraResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calculadoraOperadores
            // 
            this.calculadoraOperadores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.calculadoraOperadores.FormattingEnabled = true;
            this.calculadoraOperadores.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.calculadoraOperadores.Location = new System.Drawing.Point(188, 67);
            this.calculadoraOperadores.Name = "calculadoraOperadores";
            this.calculadoraOperadores.Size = new System.Drawing.Size(57, 30);
            this.calculadoraOperadores.TabIndex = 2;
            // 
            // laCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 263);
            this.Controls.Add(this.calculadoraOperadores);
            this.Controls.Add(this.calculadoraResultado);
            this.Controls.Add(this.calculadoraBotonConvertirADecimal);
            this.Controls.Add(this.calculadoraBotonConvertirABinario);
            this.Controls.Add(this.calculadoraBotonCerrar);
            this.Controls.Add(this.calculadoraBotonLimpiar);
            this.Controls.Add(this.calculadoraBotonOperar);
            this.Controls.Add(this.calculadoraNumeroUno);
            this.Controls.Add(this.calculadoraNumeroDos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "laCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Joaquin Calero del curso 2C";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calculadoraNumeroDos;
        private System.Windows.Forms.TextBox calculadoraNumeroUno;
        private System.Windows.Forms.Button calculadoraBotonOperar;
        private System.Windows.Forms.Button calculadoraBotonLimpiar;
        private System.Windows.Forms.Button calculadoraBotonCerrar;
        private System.Windows.Forms.Button calculadoraBotonConvertirABinario;
        private System.Windows.Forms.Button calculadoraBotonConvertirADecimal;
        private System.Windows.Forms.Label calculadoraResultado;
        private System.Windows.Forms.ComboBox calculadoraOperadores;
    }
}

