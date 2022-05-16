namespace Practica_GitHub_1oDAWSemi_Calculadora
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
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.textBoxOperador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSeno = new System.Windows.Forms.Button();
            this.btnCoseno = new System.Windows.Forms.Button();
            this.btnTangente = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnBorrarOperador = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.btnRaizCuadrada = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResultado.Location = new System.Drawing.Point(10, 30);
            this.textBoxResultado.MaxLength = 128;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(430, 30);
            this.textBoxResultado.TabIndex = 0;
            this.textBoxResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxOperador
            // 
            this.textBoxOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOperador.Location = new System.Drawing.Point(10, 96);
            this.textBoxOperador.MaxLength = 128;
            this.textBoxOperador.Name = "textBoxOperador";
            this.textBoxOperador.Size = new System.Drawing.Size(430, 30);
            this.textBoxOperador.TabIndex = 1;
            this.textBoxOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Operador";
            // 
            // btnSeno
            // 
            this.btnSeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeno.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSeno.Location = new System.Drawing.Point(10, 145);
            this.btnSeno.Name = "btnSeno";
            this.btnSeno.Size = new System.Drawing.Size(100, 50);
            this.btnSeno.TabIndex = 4;
            this.btnSeno.Text = "Seno";
            this.btnSeno.UseVisualStyleBackColor = true;
            this.btnSeno.Click += new System.EventHandler(this.btnSeno_Click);
            // 
            // btnCoseno
            // 
            this.btnCoseno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoseno.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnCoseno.Location = new System.Drawing.Point(120, 145);
            this.btnCoseno.Name = "btnCoseno";
            this.btnCoseno.Size = new System.Drawing.Size(100, 50);
            this.btnCoseno.TabIndex = 5;
            this.btnCoseno.Text = "Coseno";
            this.btnCoseno.UseVisualStyleBackColor = true;
            this.btnCoseno.Click += new System.EventHandler(this.btnCoseno_Click);
            // 
            // btnTangente
            // 
            this.btnTangente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTangente.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnTangente.Location = new System.Drawing.Point(230, 145);
            this.btnTangente.Name = "btnTangente";
            this.btnTangente.Size = new System.Drawing.Size(100, 50);
            this.btnTangente.TabIndex = 6;
            this.btnTangente.Text = "Tangente";
            this.btnTangente.UseVisualStyleBackColor = true;
            this.btnTangente.Click += new System.EventHandler(this.btnTangente_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTodo.ForeColor = System.Drawing.Color.Red;
            this.btnBorrarTodo.Location = new System.Drawing.Point(340, 145);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(100, 50);
            this.btnBorrarTodo.TabIndex = 7;
            this.btnBorrarTodo.Text = "CE";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnBorrarOperador
            // 
            this.btnBorrarOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarOperador.ForeColor = System.Drawing.Color.Red;
            this.btnBorrarOperador.Location = new System.Drawing.Point(340, 210);
            this.btnBorrarOperador.Name = "btnBorrarOperador";
            this.btnBorrarOperador.Size = new System.Drawing.Size(100, 50);
            this.btnBorrarOperador.TabIndex = 11;
            this.btnBorrarOperador.Text = "C";
            this.btnBorrarOperador.UseVisualStyleBackColor = true;
            this.btnBorrarOperador.Click += new System.EventHandler(this.btnBorrarOperador_Click);
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcentaje.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnPorcentaje.Location = new System.Drawing.Point(230, 210);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(100, 50);
            this.btnPorcentaje.TabIndex = 10;
            this.btnPorcentaje.Text = "%";
            this.btnPorcentaje.UseVisualStyleBackColor = true;
            this.btnPorcentaje.Click += new System.EventHandler(this.btnPorcentaje_Click);
            // 
            // btnRaizCuadrada
            // 
            this.btnRaizCuadrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaizCuadrada.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnRaizCuadrada.Location = new System.Drawing.Point(120, 210);
            this.btnRaizCuadrada.Name = "btnRaizCuadrada";
            this.btnRaizCuadrada.Size = new System.Drawing.Size(100, 50);
            this.btnRaizCuadrada.TabIndex = 9;
            this.btnRaizCuadrada.Text = "Raiz";
            this.btnRaizCuadrada.UseVisualStyleBackColor = true;
            this.btnRaizCuadrada.Click += new System.EventHandler(this.btnRaizCuadrada_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotencia.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnPotencia.Location = new System.Drawing.Point(10, 210);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(100, 50);
            this.btnPotencia.TabIndex = 8;
            this.btnPotencia.Text = "Potencia";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDividir.Location = new System.Drawing.Point(340, 275);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(100, 50);
            this.btnDividir.TabIndex = 15;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.Location = new System.Drawing.Point(230, 275);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(100, 50);
            this.btnNueve.TabIndex = 14;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.Location = new System.Drawing.Point(120, 275);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(100, 50);
            this.btnOcho.TabIndex = 13;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.Location = new System.Drawing.Point(10, 275);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(100, 50);
            this.btnSiete.TabIndex = 12;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMultiplicar.Location = new System.Drawing.Point(340, 340);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(100, 50);
            this.btnMultiplicar.TabIndex = 19;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.Location = new System.Drawing.Point(230, 340);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(100, 50);
            this.btnSeis.TabIndex = 18;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.Location = new System.Drawing.Point(120, 340);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(100, 50);
            this.btnCinco.TabIndex = 17;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.Location = new System.Drawing.Point(10, 340);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(100, 50);
            this.btnCuatro.TabIndex = 16;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnResta.Location = new System.Drawing.Point(340, 405);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(100, 50);
            this.btnResta.TabIndex = 23;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnTres
            // 
            this.btnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.Location = new System.Drawing.Point(230, 405);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(100, 50);
            this.btnTres.TabIndex = 22;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnDos
            // 
            this.btnDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.Location = new System.Drawing.Point(120, 405);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(100, 50);
            this.btnDos.TabIndex = 21;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnUno
            // 
            this.btnUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.Location = new System.Drawing.Point(10, 405);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(100, 50);
            this.btnUno.TabIndex = 20;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSumar.Location = new System.Drawing.Point(340, 470);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(100, 50);
            this.btnSumar.TabIndex = 27;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnIgual.Location = new System.Drawing.Point(230, 470);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(100, 50);
            this.btnIgual.TabIndex = 26;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnCero
            // 
            this.btnCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.Location = new System.Drawing.Point(120, 470);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(100, 50);
            this.btnCero.TabIndex = 25;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.btnCero_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPunto.Location = new System.Drawing.Point(10, 470);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(100, 50);
            this.btnPunto.TabIndex = 24;
            this.btnPunto.Text = ",";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 553);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnBorrarOperador);
            this.Controls.Add(this.btnPorcentaje);
            this.Controls.Add(this.btnRaizCuadrada);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnTangente);
            this.Controls.Add(this.btnCoseno);
            this.Controls.Add(this.btnSeno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOperador);
            this.Controls.Add(this.textBoxResultado);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.TextBox textBoxOperador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeno;
        private System.Windows.Forms.Button btnCoseno;
        private System.Windows.Forms.Button btnTangente;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnBorrarOperador;
        private System.Windows.Forms.Button btnPorcentaje;
        private System.Windows.Forms.Button btnRaizCuadrada;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnPunto;
    }
}

