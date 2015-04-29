using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AreaYPerimetro.area1;
using AreaYPerimetro.perimetro1;

namespace AreaYPerimetro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularTriangulo_Click(object sender, EventArgs e)
        {
            if ((txtAlturaTriangulo.Text != string.Empty) && (txtBaseTriangulo.Text != string.Empty))
            {
                try
                {
                    area1.AreasPerimetrosSoapClient ar = new AreasPerimetrosSoapClient();
                    MessageBox.Show(ar.AreaTriangulo(double.Parse(txtAlturaTriangulo.Text), double.Parse(txtBaseTriangulo.Text)), "Resultado de la Area del Triangulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch (FormatException ex)
                {
                    
                    MessageBox.Show(string.Format("Debes introducir un numero valido en las cajas de texto. \n {o}", ex.Message));
                }
            }
            else
            {
                MessageBox.Show(string.Format("Debes introducir valores en la caja de texto"));
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtLadoCuadrado.Text != string.Empty) 
            {
                try
                {
                    area1.AreasPerimetrosSoapClient ar = new AreasPerimetrosSoapClient();
                    MessageBox.Show(ar.AreaCuadrado(double.Parse(txtLadoCuadrado.Text), double.Parse(txtLadoCuadrado.Text)), "Resultado de la Area del Cuadrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException ex)
                {

                    MessageBox.Show(string.Format("Debes introducir un numero valido en las cajas de texto. \n {o}", ex.Message));
                }
            }
            else
            {
                MessageBox.Show(string.Format("Debes introducir valores en la caja de texto"));
            }

        }

        private void btnCalcularCirculo_Click(object sender, EventArgs e)
        {
            if (txtRadioCirculo.Text != string.Empty)
            {
                try
                {
                    area1.AreasPerimetrosSoapClient ar = new AreasPerimetrosSoapClient();
                    MessageBox.Show(ar.AreaCirculo(double.Parse(txtRadioCirculo.Text)), "Resultado de la Area del Circulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException ex)
                {

                    MessageBox.Show(string.Format("Debes introducir un numero valido en las cajas de texto. \n {o}", ex.Message));
                }
            }
            else
            {
                MessageBox.Show(string.Format("Debes introducir valores en la caja de texto"));
            }
        }

        private void btnPerimetroTriangulo_Click(object sender, EventArgs e)
        {
            if (txtPLadoTriangulo.Text != string.Empty)
            {
                try
                {
                    perimetro1.PerimetrosSoapClient pe = new PerimetrosSoapClient();
                    MessageBox.Show(pe.PerimetroTriangulo(double.Parse(txtPLadoTriangulo.Text)), "Resultado del Perimetro del Triangulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                catch (FormatException ex)
                {

                    MessageBox.Show(string.Format("Debes introducir un numero valido en las cajas de texto. \n {o}", ex.Message));
                }
            }
            else
            {
                MessageBox.Show(string.Format("Debes introducir valores en la caja de texto"));
            }
        }

        private void btnPerimetroCuadrado_Click(object sender, EventArgs e)
        {
            if (txtPLadoCuadrado.Text != string.Empty)
            {
                try
                {
                    perimetro1.PerimetrosSoapClient pe = new PerimetrosSoapClient();
                    MessageBox.Show(pe.PerimetroCuadrdo(double.Parse(txtPLadoCuadrado.Text)), "Resultado del Perimetro del Cuadrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException ex)
                {

                    MessageBox.Show(string.Format("Debes introducir un numero valido en las cajas de texto. \n {o}", ex.Message));
                }

            }
            else {
                MessageBox.Show(string.Format("Debes introducir valores en la caja de texto"));
            }
        }

        private void btnPerimetroCirculo_Click(object sender, EventArgs e)
        {
            if (txtPRadioCirculo.Text != string.Empty)
            {
                try
                {
                    perimetro1.PerimetrosSoapClient pe = new PerimetrosSoapClient();
                    MessageBox.Show(pe.PerimetroCirculo(double.Parse(txtPRadioCirculo.Text)), "Resultado del Perimetro del Circulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException ex)
                {

                    MessageBox.Show(string.Format("Debes introducir un numero valido en las cajas de texto. \n {o}", ex.Message));
                }
            }
            else
            {
                MessageBox.Show(string.Format("Debes introducir valores en la caja de texto"));
            }
        }
    }
}
