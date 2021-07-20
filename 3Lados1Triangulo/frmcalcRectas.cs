using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace _3Lados1Triangulo
{
    public partial class frmcalcRectas : Form
    {
        public frmcalcRectas()
        {
            InitializeComponent();
        }

        Double a = 0, b = 0, c = 0, S, Area, m_a, m_b, m_c, B_a, B_b, B_c, h_a, h_b, h_c,Escala;
        string TipoTriangulo = String.Empty;
        int ALTURA = 600, PUNTOB, FINPUNTOB, INICIOPUNTOB, DIFERENCIA_ALTURA, DIFERENCIA_ALTURA2;

        private void btn_home_Click(object sender, EventArgs e)
        {
            MdiSecundario frm = new MdiSecundario();
            this.Hide();
            frm.ShowDialog();
        }

        Graphics Triangulo; Pen Lapiz = new Pen(Color.DarkRed,2); Brush Pintura = new SolidBrush(Color.DarkCyan);
        Point A, B, C;

        bool Retorno;
        #region Botones
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            pct_Lienzo.Refresh();
        }
        private void btnCalcular_Distancia_Click(object sender, EventArgs e)
        {
            try
            {
                Triangulo = pct_Lienzo.CreateGraphics();
                Triangulo.SmoothingMode = SmoothingMode.AntiAlias;
                Registrar_Lados();
                if(Retorno == true)
                {
                    Limpiar();
                    return;
                }
                else
                {
                    CalcularEscala();
                    Medianas();
                    Bisectrices();
                    Alturas();
                    AreadelTriangulo();
                    Digitar_Resultado();
                    pct_Lienzo.Refresh();
                    try
                    {
                        GraficarTriangulo();
                    }
                    catch
                    {
                        MessageBox.Show("El triángulo no se ha podido graficar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Funciones    
        private void Limpiar()
        {
            txt_a.Text = string.Empty; txt_b.Text = string.Empty; txt_c.Text = string.Empty;
            lblResultado.Text = string.Empty;
        }

        private void CalcularEscala()
        {
            if ((a >= b) && (a >= c))
            {
                Escala = 540 / a;
            }
            else
            {
                if ((b >= a) && (b >= c))
                {
                    Escala = 540 / b;
                }
                else if ((c >= a) && (c >= b))
                {
                    Escala = 540 / c;
                }
            }
        }
        private void Registrar_Lados()
        {
            try
            {
                a = Convert.ToDouble(txt_a.Text);
                b = Convert.ToDouble(txt_b.Text);
                c = Convert.ToDouble(txt_c.Text);
                S = (a + b + c) / 2;
                if ((S <= a) || (S <= b) || (S <= c))
                {
                    MessageBox.Show("Es imposible graficar un triángulo con las medidas dada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Retorno = true;
                }
                else
                {
                    Retorno = false;
                }
                if ((a == b && a != c) || (b == c && c != a) || (c == a && a != b))
                {
                    TipoTriangulo = "Isosceles";
                }
                else
                {
                    if (a == b && b == c)
                    {
                        TipoTriangulo = "Equilatero";
                    }
                    else
                    {
                        TipoTriangulo = "Escaleno";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ingrese las distancias del triángulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblResultado.Text = string.Empty;
            }
            
        }

        private void Digitar_Resultado()
        {
            lblResultado.Text = "El valor de las rectas notables son:\n\n" + "Mediana A = " + m_a + "        Bisectriz A = " + B_a + "        Altura A  = " + h_a + "       a = " + a+ "\nMediana B = " + m_b + "        Bisectriz B = " + B_b + "        Altura B  = " + h_b + "      b = " + b + "\nMediana C = " + m_c + "        Bisectriz C = " + B_c + "        Altura C  = " + h_c + "      c = " + c + "\nTipo de Triangulo: " + TipoTriangulo + "       Area = " + Area;

        }
        #endregion
        #region Formulas
        private void Medianas()
        {
            m_a = Math.Round(Math.Sqrt(2 * (Math.Pow(b, 2) + Math.Pow(c, 2)) - Math.Pow(a, 2)) / 2, 2);
            m_b = Math.Round(Math.Sqrt(2 * (Math.Pow(c, 2) + Math.Pow(a, 2)) - Math.Pow(b, 2)) / 2, 2);
            m_c = Math.Round(Math.Sqrt(2 * (Math.Pow(a, 2) + Math.Pow(b, 2)) - Math.Pow(c, 2)) / 2, 2);
        }
        private void Bisectrices()
        {
            B_a = Math.Round((2 / (b + c)) * (Math.Sqrt(b * c * S * (S - a))),2);
            B_b = Math.Round(((2 / (c + a)) * (Math.Sqrt(c * a * S * (S - b)))),2);
            B_c = Math.Round(((2 / (a + b)) * (Math.Sqrt(a * b * S * (S - c)))),2);
        }
        private void Alturas()
        {
            h_a = Math.Round((2 / a) * Math.Sqrt(S * (S - a) * (S - b) * (S - c)),2);
            h_b = Math.Round((2 / b) * Math.Sqrt(S * (S - a) * (S - b) * (S - c)),2);
            h_c = Math.Round((2 / c) * Math.Sqrt(S * (S - a) * (S - b) * (S - c)),2);
        }
        private void AreadelTriangulo()
        {
            switch (TipoTriangulo)
            {
                case "Equilatero":
                    Area = Math.Round((Math.Sqrt(3) / 4) * (Math.Pow(a, 2)), 2);
                    break;
                case "Escaleno":
                    Area = Math.Round(Math.Sqrt(S * (S - a) * (S - b) * (S - c)), 2);
                    break;
                case "Isosceles":
                    Area = Math.Round((b * Math.Sqrt(Math.Pow(a, 2) - (Math.Pow(b, 2) / 4))) / 2, 2);
                    break;
                default:
                    break;
            }
        }
        #endregion
        #region DibujoTriangulo
        private void GraficarTriangulo()
        {
            /* Variables
            ALTURA: la cantidad de pixeles hacia abajo que hay en el picturebox
            PUNTOB: 
            FINPUNTOB: numero minimo en x donde se calculara la recta del lado a
            DIFERENCIA_ALTURA & DIFERENCIA_ALTURA2: altura que tendra el punto de la recta calculada por el teorema de pitagoras, siendo i uno de los catetos y b la hipotenusa (a su vez la medida del lado del triangulo), para calcular la altura final se debe restar a la ALTURA
            INICIOPUNTOB: numero maximo en x donde se calculara la recta del lado a
             */
            ALTURA = 600; 
            PUNTOB = Convert.ToInt32(c) * Convert.ToInt32(Escala);
            FINPUNTOB = PUNTOB - (Convert.ToInt32(a)* Convert.ToInt32(Escala));
            INICIOPUNTOB = PUNTOB + (Convert.ToInt32(a) * Convert.ToInt32(Escala));

            for (int i = 0; i <= (b * Escala);) //ciclo que calcula la recta b el numero de veces de i en x, Escala es la cantidad real multiplicada por una constante para generar el triangulo proporcional al tamaño de la picturebox
            {
                DIFERENCIA_ALTURA = Convert.ToInt32(Math.Round(Math.Sqrt(Math.Pow(b * Escala, 2) - Math.Pow(i, 2)),2));
                //Triangulo.DrawLine(Lapiz, 0, ALTURA, i,(ALTURA - DIFERENCIA_ALTURA));

                for (int j = INICIOPUNTOB; j >= FINPUNTOB;) //ciclo que calcula la recta a simultaneamente  la recta b
                {
                    DIFERENCIA_ALTURA2 = Convert.ToInt32(Math.Round(Math.Sqrt(Math.Pow(a * Escala, 2) - Math.Pow(j - PUNTOB, 2)),2));
                    if ((i == j) && ((ALTURA - DIFERENCIA_ALTURA) == (ALTURA - DIFERENCIA_ALTURA2))) //Condicionante, cuando ambas rectas tengan misma "x" y misma "y"
                    {
                        A = new Point(0, ALTURA); B = new Point(PUNTOB, ALTURA); C = new Point(j, (ALTURA - DIFERENCIA_ALTURA2));
                    }
                    j -= 1;
                }
                i++;
            }
            Point[] PuntosABC = { A, B, C };
            Triangulo.FillPolygon(Pintura, PuntosABC);
        }
        #endregion
    }
}
