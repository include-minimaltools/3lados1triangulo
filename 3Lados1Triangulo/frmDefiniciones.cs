using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Lados1Triangulo
{
    public partial class frmDefiniciones : Form
    {
        public frmDefiniciones()
        {
            InitializeComponent();
        }
        byte Pagina=1;
        //Definiciones
        string Concepto = "Se le denomina triángulo a aquella figura geométrica compuesta de tres lados, tres vértices y tres ángulos interiores."+
                            "\n\n Teoremas"+
                            "\n\n 1.";
        string Clasificacion = "Los triangulos pueden clasificarse de dos maneras:"+
            "\n\nSegún sus ángulos:\n\n    Rectángulo: Se denomina triángulo rectángulo a cualquier triángulo con un ángulo recto.\n\n       Oblicuángulos:Son aquellos que no tiene ángulo recto en ninguno de sus lados, se subdivide en:\n\n           Acutángulo:Son aquellos que tienen los tres ángulos internos menor a 90°.\n\n            Obtusángulo: Son aquellos que poseen uno de sus tres ángulos internos mayor a 90°."+
            "\n\nSegún sus lados:\n\n   Escaleno:Un triángulo para el cual dos lados cualesquiera no son congruentes se llama escaleno.\n\n      Equilatero:Un triángulo con sus tres lados congruentes se llama equilátero. Un triángulo es equiángulo, si sus tres ángulos son congruentes. Todo triángulo equilátero es equiángulo.\n\n    Isósceles:Un triángulo con dos lados congruentes se llama isósceles. El otro lado es la base. Los dos ángulos asociados con la base son ángulos en la base. El ángulo opuesto a la base es el ángulo en el vértice.";
        string Rectas = "Las rectas notables que posee todo triángulo son:"+
            "\n\nMediana: La longitud de la mediana correspondiente a la hipotenusa de un triángulo rectángulo es la mitad de la longitud de la hipotenusa."+
            "\n\nMediatriz: La mediatriz de un segmento es la recta perpendicular al segmento en su punto medio."+
            "\n\nBisectriz: es la recta dentro de un ángulo que divide a este mismo en dos ángulos iguales.Si D está en el interior del ∠BAC, y ∠BAD ≅ ∠DAC, entonces AD biseca al ∠BAC, y ADse llama la bisectriz del ∠BAC."+
            "\n\nAltura: Una altura de un triángulo es un segmento perpendicular desde un vértice del triángulo a la recta que contiene al lado opuesto.";
        string Puntos = "Los puntos notables son aquellos creados en la intercepcion de tres rectas notables y son:"+
            "\n\nBaricentro: Es el punto creado por las tres medianas de un triángulo."+
            "\n\nCircuncentro: Es el punto creado por las tres mediatrices de un triángulo."+
            "\n\nIncentro: Es el punto creado en la intercepcion de las bisectricese de los lados de un triángulo."+
            "\n\nOrtocentro: Es el punto creado por las tres alturas de un triángulo";
        //Funciones
        private void btnDefinicion1_Click(object sender, EventArgs e)
        {
            Pagina = 1;
            Escribir();
        }

        private void btnDefinicion2_Click(object sender, EventArgs e)
        {
            Pagina = 2;
            Escribir();
        }

        private void btnPuntos_Click(object sender, EventArgs e)
        {
            Pagina = 3;
            Escribir();
        }

        private void btnRectas_Click(object sender, EventArgs e)
        {
            Pagina = 4;
            Escribir();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            if(Pagina != 1)
            {
                Pagina = Convert.ToByte(Pagina - 1);
                Escribir();
            }
            else
            {
                Pagina = 4;
                Escribir();
            }
        }

        private void btn_adelante_Click(object sender, EventArgs e)
        {
            if(Pagina != 4)
            {
                Pagina = Convert.ToByte(Pagina + 1);
                Escribir();
            }
            else
            {
                Pagina = 1;
                Escribir();
            }
        }
        private void Escribir()
        {
            switch (Pagina)
            {
                case 1:
                    lblPrincipal.Text = Concepto;
                    break;
                case 2:
                    lblPrincipal.Text = Clasificacion;
                    break;
                case 3:
                    lblPrincipal.Text = Rectas;
                    break;
                case 4:
                    lblPrincipal.Text = Puntos;
                    break;
                default:
                    break;
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            MdiSecundario frm = new MdiSecundario();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
