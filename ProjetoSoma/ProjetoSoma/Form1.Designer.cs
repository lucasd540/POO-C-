namespace ProjetoSoma
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.lblPrimeiroName = new System.Windows.Forms.Label();
            this.txbPrimeiroNumero = new System.Windows.Forms.TextBox();
            this.lblSegundoNumero = new System.Windows.Forms.Label();
            this.txbSegundoNumero = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimeiroName
            // 
            this.lblPrimeiroName.AutoSize = true;
            this.lblPrimeiroName.Location = new System.Drawing.Point(71, 13);
            this.lblPrimeiroName.Name = "lblPrimeiroName";
            this.lblPrimeiroName.Size = new System.Drawing.Size(120, 13);
            this.lblPrimeiroName.TabIndex = 0;
            this.lblPrimeiroName.Text = "Digite o primeiro numero";
            this.lblPrimeiroName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbPrimeiroNumero
            // 
            this.txbPrimeiroNumero.Location = new System.Drawing.Point(50, 29);
            this.txbPrimeiroNumero.Name = "txbPrimeiroNumero";
            this.txbPrimeiroNumero.Size = new System.Drawing.Size(156, 20);
            this.txbPrimeiroNumero.TabIndex = 1;
            this.txbPrimeiroNumero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSegundoNumero
            // 
            this.lblSegundoNumero.AutoSize = true;
            this.lblSegundoNumero.Location = new System.Drawing.Point(66, 52);
            this.lblSegundoNumero.Name = "lblSegundoNumero";
            this.lblSegundoNumero.Size = new System.Drawing.Size(125, 13);
            this.lblSegundoNumero.TabIndex = 2;
            this.lblSegundoNumero.Text = "Digite o segundo numero";
            this.lblSegundoNumero.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbSegundoNumero
            // 
            this.txbSegundoNumero.Location = new System.Drawing.Point(50, 68);
            this.txbSegundoNumero.Name = "txbSegundoNumero";
            this.txbSegundoNumero.Size = new System.Drawing.Size(156, 20);
            this.txbSegundoNumero.TabIndex = 3;
            this.txbSegundoNumero.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(87, 166);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(73, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "RESULTADO";
            this.toolTip1.SetToolTip(this.lblResultado, "Esse é o resultado da operação");
            this.lblResultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(50, 94);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 23);
            this.btnSomar.TabIndex = 5;
            this.btnSomar.Text = "+";
            this.toolTip1.SetToolTip(this.btnSomar, "Clique pra somar");
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(131, 94);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(75, 23);
            this.btnSubtrair.TabIndex = 6;
            this.btnSubtrair.Text = "-";
            this.toolTip1.SetToolTip(this.btnSubtrair, "Clique para subtrair");
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(131, 123);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 7;
            this.btnDividir.Text = "/";
            this.toolTip1.SetToolTip(this.btnDividir, "Clique para dividir");
            this.btnDividir.UseCompatibleTextRendering = true;
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(50, 123);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicar.TabIndex = 8;
            this.btnMultiplicar.Text = "*";
            this.toolTip1.SetToolTip(this.btnMultiplicar, "Clique para multiplicar");
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 212);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txbSegundoNumero);
            this.Controls.Add(this.lblSegundoNumero);
            this.Controls.Add(this.txbPrimeiroNumero);
            this.Controls.Add(this.lblPrimeiroName);
            this.Name = "frmPrincipal";
            this.Text = "CALCULADORA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiroName;
        private System.Windows.Forms.TextBox txbPrimeiroNumero;
        private System.Windows.Forms.Label lblSegundoNumero;
        private System.Windows.Forms.TextBox txbSegundoNumero;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
    }
}

