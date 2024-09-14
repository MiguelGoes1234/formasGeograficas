using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaAPS
{
    public partial class frmFormas : Form
    {
        public frmFormas()
        {
            InitializeComponent();
        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbForma.Text)
            {
                case "Quadrado":
                    SelecionarQuadrado();
                    break;
                case "Triângulo":
                    SelecionarTriangulo();
                    break;
                case "Circunferência":
                    SelecionarCircunferencia();
                    break;
                case "Retângulo":
                    SelecionarRetangulo();
                    break;
                default:
                    break;
            }
        }

        private void SelecionarQuadrado()
        {
            ExibirBase(true);
            ExibirAltura(false);
            ExibirRaio(false);
            cmbTriangulo.Visible = false;
        }

        private void SelecionarRetangulo()
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirRaio(false);
            cmbTriangulo.Visible = false;
        }

        private void SelecionarCircunferencia()
        {
            ExibirBase(false);
            ExibirAltura(false);
            ExibirRaio(true);
            cmbTriangulo.Visible = false;
        }

        private void ExibirBase(bool visivel)
        {
            lblBase.Visible = txtBase.Visible = visivel;
        }

        private void SelecionarTriangulo()
        {
            ExibirBase(false);
            ExibirAltura(false);
            ExibirRaio(false);
            cmbTriangulo.Visible = true;
        }

        private void ExibirAltura(bool visivel)
        {
            lblAltura.Visible = txtAltura.Visible = visivel;
        }

        private void ExibirRaio(bool visivel)
        {
            lblRaio.Visible = txtRaio.Visible = visivel;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (cmbForma.Text.Equals("Quadrado"))
            {
                FormaGeometrica quadrado = new Quadrado() 
                {
                    Lado = Convert.ToDouble(txtBase.Text) 
                };
                cmbObjetos.Items.Add(quadrado);
            }
            else if (cmbForma.Text.Equals("Retângulo"))
            {
                FormaGeometrica retangulo = new Retangulo()
                {
                    Base = Convert.ToDouble(txtBase.Text),
                    Altura = Convert.ToDouble(txtAltura.Text)
                };
                cmbObjetos.Items.Add(retangulo);
            }
            else if (cmbForma.Text.Equals("Circunferência"))
            {
                FormaGeometrica circunferencia = new Circunferencia()
                {
                    Raio = Convert.ToDouble(txtRaio.Text)
                };
                cmbObjetos.Items.Add(circunferencia);
            }
            else if (cmbTriangulo.Text.Equals("Equilátero"))
            {
                Triangulo trianguloEquilatero = new TrianguloEquilatero()
                {
                    Base = Convert.ToDouble(txtBase.Text)
                };
                cmbObjetos.Items.Add(trianguloEquilatero);
            }
            else if (cmbTriangulo.Text.Equals("Isósceles"))
            {
                Triangulo trianguloIsosceles = new TrianguloIsosceles()
                {
                    Base = Convert.ToDouble(txtBase.Text),
                    Altura = Convert.ToDouble(txtAltura.Text)
                };
                cmbObjetos.Items.Add(trianguloIsosceles);
            }
            else if (cmbTriangulo.Text.Equals("Reto"))
            {
                Triangulo trianguloReto = new TrianguloReto()
                {
                    Base = Convert.ToDouble(txtBase.Text),
                    Altura = Convert.ToDouble(txtAltura.Text)
                };
                cmbObjetos.Items.Add(trianguloReto);
            }
        }

        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormaGeometrica obj = cmbObjetos.SelectedItem as FormaGeometrica;
            txtArea.Text = obj.CalcularArea().ToString("0.00", CultureInfo.CreateSpecificCulture("pt-br"));
            txtPerimetro.Text = obj.CalcularPerimetro().ToString("0.00", CultureInfo.CreateSpecificCulture("pt-br"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelecionarTrianguloEquilatero()
        {
            ExibirBase(true);
            ExibirAltura(false);
            ExibirRaio(false);
            cmbTriangulo.Visible = true;
        }

        private void SelecionarTrianguloIsosceles()
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirRaio(false);
            cmbTriangulo.Visible = true;
        }

        private void SelecionarTrianguloReto()
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirRaio(false);
            cmbTriangulo.Visible = true;
        }

        private void cmbTriangulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTriangulo.Text)
            {
                case "Equilátero":
                    SelecionarTrianguloEquilatero();
                    break;
                case "Isósceles":
                    SelecionarTrianguloIsosceles();
                    break;
                case "Reto":
                    SelecionarTrianguloReto();
                    break;
                default:
                    break;
            }
        }
    }
}
