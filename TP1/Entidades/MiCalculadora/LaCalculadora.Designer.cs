namespace MiCalculadora
{
    partial class LaCalculadora
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.btnOperar_Click = new System.Windows.Forms.Button();
            this.btnLimpiar_Click = new System.Windows.Forms.Button();
            this.btnCerrar_Click = new System.Windows.Forms.Button();
            this.btnConvertirABinario_Click = new System.Windows.Forms.Button();
            this.btnConvertirADecimal_Click = new System.Windows.Forms.Button();
            this.lblLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(40, 70);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(111, 20);
            this.txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(335, 70);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(111, 20);
            this.txtNumero2.TabIndex = 1;
            this.txtNumero2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cmbOperador
            // 
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Items.AddRange(new object[] {
            "",
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperador.Location = new System.Drawing.Point(188, 70);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(111, 21);
            this.cmbOperador.TabIndex = 2;
            // 
            // btnOperar_Click
            // 
            this.btnOperar_Click.Location = new System.Drawing.Point(55, 130);
            this.btnOperar_Click.Name = "btnOperar_Click";
            this.btnOperar_Click.Size = new System.Drawing.Size(82, 28);
            this.btnOperar_Click.TabIndex = 3;
            this.btnOperar_Click.Text = "Operar";
            this.btnOperar_Click.UseVisualStyleBackColor = true;
            this.btnOperar_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar_Click
            // 
            this.btnLimpiar_Click.Location = new System.Drawing.Point(200, 130);
            this.btnLimpiar_Click.Name = "btnLimpiar_Click";
            this.btnLimpiar_Click.Size = new System.Drawing.Size(82, 28);
            this.btnLimpiar_Click.TabIndex = 4;
            this.btnLimpiar_Click.Text = "Limpiar";
            this.btnLimpiar_Click.UseVisualStyleBackColor = true;
            this.btnLimpiar_Click.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // btnCerrar_Click
            // 
            this.btnCerrar_Click.Location = new System.Drawing.Point(348, 130);
            this.btnCerrar_Click.Name = "btnCerrar_Click";
            this.btnCerrar_Click.Size = new System.Drawing.Size(82, 28);
            this.btnCerrar_Click.TabIndex = 5;
            this.btnCerrar_Click.Text = "Cerrar";
            this.btnCerrar_Click.UseVisualStyleBackColor = true;
            this.btnCerrar_Click.Click += new System.EventHandler(this.btnCerrar_Click_Click);
            // 
            // btnConvertirABinario_Click
            // 
            this.btnConvertirABinario_Click.Location = new System.Drawing.Point(105, 201);
            this.btnConvertirABinario_Click.Name = "btnConvertirABinario_Click";
            this.btnConvertirABinario_Click.Size = new System.Drawing.Size(114, 28);
            this.btnConvertirABinario_Click.TabIndex = 6;
            this.btnConvertirABinario_Click.Text = "Convertir a binario";
            this.btnConvertirABinario_Click.UseVisualStyleBackColor = true;
            this.btnConvertirABinario_Click.Click += new System.EventHandler(this.btnConvertirABinario_Click_Click);
            // 
            // btnConvertirADecimal_Click
            // 
            this.btnConvertirADecimal_Click.Location = new System.Drawing.Point(268, 201);
            this.btnConvertirADecimal_Click.Name = "btnConvertirADecimal_Click";
            this.btnConvertirADecimal_Click.Size = new System.Drawing.Size(114, 28);
            this.btnConvertirADecimal_Click.TabIndex = 7;
            this.btnConvertirADecimal_Click.Text = "Convertir a decimal";
            this.btnConvertirADecimal_Click.UseVisualStyleBackColor = true;
            this.btnConvertirADecimal_Click.Click += new System.EventHandler(this.btnConvertirADecimal_Click_Click);
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(446, 29);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(0, 13);
            this.lblLabel.TabIndex = 8;
            // 
            // LaCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 273);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.btnConvertirADecimal_Click);
            this.Controls.Add(this.btnConvertirABinario_Click);
            this.Controls.Add(this.btnCerrar_Click);
            this.Controls.Add(this.btnLimpiar_Click);
            this.Controls.Add(this.btnOperar_Click);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LaCalculadora";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Nicolas Sande del curso 2C";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.Button btnOperar_Click;
        private System.Windows.Forms.Button btnLimpiar_Click;
        private System.Windows.Forms.Button btnCerrar_Click;
        private System.Windows.Forms.Button btnConvertirABinario_Click;
        private System.Windows.Forms.Button btnConvertirADecimal_Click;
        private System.Windows.Forms.Label lblLabel;
    }
}

