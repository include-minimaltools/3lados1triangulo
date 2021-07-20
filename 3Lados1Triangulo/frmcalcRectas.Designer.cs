namespace _3Lados1Triangulo
{
    partial class frmcalcRectas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcalcRectas));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.btnCalcular_Distancia = new System.Windows.Forms.Button();
            this.pct_Lienzo = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Lienzo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Cambria", 25F);
            this.labelTitulo.Location = new System.Drawing.Point(58, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(906, 40);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "¡Calcula el valor de las rectas notables de cualquier triángulo!";
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_a.Font = new System.Drawing.Font("Cambria", 15F);
            this.lbl_a.Location = new System.Drawing.Point(29, 207);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(233, 23);
            this.lbl_a.TabIndex = 14;
            this.lbl_a.Text = "Ingresa la distancia AB (c)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Cambria", 15F);
            this.label1.Location = new System.Drawing.Point(29, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ingresa la distancia BC (a)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Cambria", 15F);
            this.label3.Location = new System.Drawing.Point(29, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ingresa la distancia AC (b)";
            // 
            // txt_a
            // 
            this.txt_a.Font = new System.Drawing.Font("Cambria", 15F);
            this.txt_a.Location = new System.Drawing.Point(285, 100);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(103, 31);
            this.txt_a.TabIndex = 17;
            this.txt_a.Text = "5";
            // 
            // txt_c
            // 
            this.txt_c.Font = new System.Drawing.Font("Cambria", 15F);
            this.txt_c.Location = new System.Drawing.Point(285, 204);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(103, 31);
            this.txt_c.TabIndex = 19;
            this.txt_c.Text = "5";
            // 
            // btnCalcular_Distancia
            // 
            this.btnCalcular_Distancia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular_Distancia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCalcular_Distancia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular_Distancia.Font = new System.Drawing.Font("Cambria", 15F);
            this.btnCalcular_Distancia.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular_Distancia.Location = new System.Drawing.Point(285, 246);
            this.btnCalcular_Distancia.Name = "btnCalcular_Distancia";
            this.btnCalcular_Distancia.Size = new System.Drawing.Size(103, 37);
            this.btnCalcular_Distancia.TabIndex = 20;
            this.btnCalcular_Distancia.Text = "Calcular";
            this.btnCalcular_Distancia.UseVisualStyleBackColor = false;
            this.btnCalcular_Distancia.Click += new System.EventHandler(this.btnCalcular_Distancia_Click);
            // 
            // pct_Lienzo
            // 
            this.pct_Lienzo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pct_Lienzo.Location = new System.Drawing.Point(12, 307);
            this.pct_Lienzo.Name = "pct_Lienzo";
            this.pct_Lienzo.Size = new System.Drawing.Size(1030, 626);
            this.pct_Lienzo.TabIndex = 21;
            this.pct_Lienzo.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblResultado.Font = new System.Drawing.Font("Cambria", 15F);
            this.lblResultado.Location = new System.Drawing.Point(420, 85);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(622, 207);
            this.lblResultado.TabIndex = 11;
            // 
            // txt_b
            // 
            this.txt_b.Font = new System.Drawing.Font("Cambria", 15F);
            this.txt_b.Location = new System.Drawing.Point(285, 152);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(103, 31);
            this.txt_b.TabIndex = 24;
            this.txt_b.Text = "5";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Limpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Limpiar.BackgroundImage")));
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.Font = new System.Drawing.Font("Cambria", 15F);
            this.btn_Limpiar.ForeColor = System.Drawing.Color.Black;
            this.btn_Limpiar.Location = new System.Drawing.Point(14, 255);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(38, 37);
            this.btn_Limpiar.TabIndex = 25;
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Cambria", 15F);
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 236);
            this.label2.TabIndex = 26;
            this.label2.Text = "Datos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Cambria", 15F);
            this.label4.Location = new System.Drawing.Point(416, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(626, 236);
            this.label4.TabIndex = 28;
            this.label4.Text = "Resultados";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_home
            // 
            this.btn_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_home.BackgroundImage")));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_home.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Location = new System.Drawing.Point(14, 12);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(38, 37);
            this.btn_home.TabIndex = 29;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // frmcalcRectas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1054, 945);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.pct_Lienzo);
            this.Controls.Add(this.btnCalcular_Distancia);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmcalcRectas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rectas Notables - 3 Lados 1 Triángulo";
            ((System.ComponentModel.ISupportInitialize)(this.pct_Lienzo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Button btnCalcular_Distancia;
        private System.Windows.Forms.PictureBox pct_Lienzo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_home;
    }
}