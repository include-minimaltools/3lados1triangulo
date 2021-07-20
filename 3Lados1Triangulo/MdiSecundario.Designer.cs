namespace _3Lados1Triangulo
{
    partial class MdiSecundario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiSecundario));
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnDefiniciones = new System.Windows.Forms.Button();
            this.btnCalcularRectas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.BackColor = System.Drawing.Color.White;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Cambria", 50F);
            this.lblTituloPrincipal.Location = new System.Drawing.Point(60, 25);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(603, 79);
            this.lblTituloPrincipal.TabIndex = 0;
            this.lblTituloPrincipal.Text = "3 Lados 1 Triangulo";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Font = new System.Drawing.Font("Cambria", 20F);
            this.lblSubtitulo.Location = new System.Drawing.Point(74, 131);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(589, 173);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = resources.GetString("lblSubtitulo.Text");
            // 
            // btnDefiniciones
            // 
            this.btnDefiniciones.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDefiniciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDefiniciones.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDefiniciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefiniciones.Font = new System.Drawing.Font("Cambria", 20F);
            this.btnDefiniciones.Location = new System.Drawing.Point(80, 350);
            this.btnDefiniciones.Name = "btnDefiniciones";
            this.btnDefiniciones.Size = new System.Drawing.Size(175, 90);
            this.btnDefiniciones.TabIndex = 2;
            this.btnDefiniciones.Text = "Definiciones";
            this.btnDefiniciones.UseVisualStyleBackColor = false;
            this.btnDefiniciones.Click += new System.EventHandler(this.btnDefiniciones_Click);
            // 
            // btnCalcularRectas
            // 
            this.btnCalcularRectas.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCalcularRectas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCalcularRectas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularRectas.Font = new System.Drawing.Font("Cambria", 20F);
            this.btnCalcularRectas.Location = new System.Drawing.Point(273, 350);
            this.btnCalcularRectas.Name = "btnCalcularRectas";
            this.btnCalcularRectas.Size = new System.Drawing.Size(390, 90);
            this.btnCalcularRectas.TabIndex = 4;
            this.btnCalcularRectas.Text = "Calcular area y rectas notables";
            this.btnCalcularRectas.UseVisualStyleBackColor = false;
            this.btnCalcularRectas.Click += new System.EventHandler(this.btnCalcularRectas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15F);
            this.label1.Location = new System.Drawing.Point(12, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(732, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Creado por Gabriel Alejandro Ortiz Amador - Universidad Nacional de Ingeniería UN" +
    "I";
            // 
            // MdiPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(748, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcularRectas);
            this.Controls.Add(this.btnDefiniciones);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTituloPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MdiPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3 Lados 1 Triangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnDefiniciones;
        private System.Windows.Forms.Button btnCalcularRectas;
        private System.Windows.Forms.Label label1;
    }
}

