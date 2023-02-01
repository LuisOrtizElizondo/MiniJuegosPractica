using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TATETI
{
    public partial class FrmAhorcado : Form
    {
        private List<TextBox> listaChar;
       
        public FrmAhorcado()
        {
            InitializeComponent();
        }
        public List<TextBox> ListaChar { 
            get { return listaChar ; }
            set { listaChar = value; }
        }

        public int Contador { get; set; }
        public int Aux { get; set; }

        public bool unJugador { get; set; }


        private void FrmAhorcado_Load(object sender, EventArgs e)
        {
            AgregarPalabra ingresoUsuario = new AgregarPalabra();
            bool palabraCargada = false;

            if (unJugador)
            {
                string palabra = generarPalabra();
                ListaChar = cargarListaTxtBox(palabra);
            }

            if (!unJugador)
                ingresoUsuario.ShowDialog();
            
            if(ingresoUsuario.MiPalabra != string.Empty && !unJugador)
            {
                // MessageBox.Show("palabra cargada : " + ingresoUsuario.MiPalabra);
                ListaChar = cargarListaTxtBox(ingresoUsuario.MiPalabra);
            }

        }

        private List<TextBox> cargarListaTxtBox(string palabra)
        {
            List<TextBox> listaTxtBox = new List<TextBox>();
            listaTxtBox.Add(txt01);
            listaTxtBox.Add(txt02);
            listaTxtBox.Add(txt03);
            listaTxtBox.Add(txt04);
            listaTxtBox.Add(txt05);
            listaTxtBox.Add(txt06);
            listaTxtBox.Add(txt07);
            listaTxtBox.Add(txt08);
            listaTxtBox.Add(txt09);
            listaTxtBox.Add(txt10);

            for (int i = 0; i < palabra.Length; i++)
            {
               string letra = palabra.Substring(i, 1);
               listaTxtBox[i].Text = letra;
            }

            foreach (TextBox letra in listaTxtBox)
            {
                if (letra.Text != "")
                {
                    letra.PasswordChar = '@';
                    Aux++;
                }
                else
                    letra.Visible = false;
            }
            return listaTxtBox;
        }

        private void recorrerPalabra(string letra)
        {
            bool contieneLetra = false;
            foreach (TextBox txtBox in ListaChar)
            {
                if (txtBox.Text == letra)
                {
                    txtBox.PasswordChar = char.Parse(letra);
                    txtBox.Enabled = true;
                    contieneLetra = true;
                }
            }

            if(!contieneLetra)
                descubrirCuerpo();
        }

        private string generarPalabra()
        {
            List<string> listaPalabras = new List<string>();

            listaPalabras.Add("Bocanada");
            listaPalabras.Add("Galletas");
            listaPalabras.Add("Moneda");
            listaPalabras.Add("Papitas");
            listaPalabras.Add("Notebook");
            listaPalabras.Add("Arroz");
            listaPalabras.Add("Quesitos");
            listaPalabras.Add("Cargador");
            listaPalabras.Add("Mollejas");
            listaPalabras.Add("Loro");

            int min = 0;
            int max = 9;
            Random rnd = new Random();
            int indexPalabra = rnd.Next(min, max );

           // MessageBox.Show("Palabra Generada: " + listaPalabras[indexPalabra]);
            return listaPalabras[indexPalabra];
        }

        private void descubrirCuerpo()
        {
            if (!lblCabeza.Visible)
                lblCabeza.Visible = true;
            else if (!lblCuello.Visible)
                lblCuello.Visible = true;
            else if (!lblCuerpo.Visible)
                lblCuerpo.Visible = true;
            else if (!lblBrazoIzq.Visible)
                lblBrazoIzq.Visible = true;
            else if (!lblBrazoDerecho.Visible)
                lblBrazoDerecho.Visible = true;
            else if (!lblPiernaIzquierda.Visible)
                lblPiernaIzquierda.Visible = true;
            else if (!lblPiernaDerecha.Visible)
                lblPiernaDerecha.Visible = true;
            else
            {
                MessageBox.Show("PERDISTE :(");
                reiniciar();
            }   
        }

        private void reiniciar()
        {
            this.Close();       
            //FrmAhorcado ahorcado = new FrmAhorcado();
            //ahorcado.CenterToParent();
            //ahorcado.Show();
            //System.Windows.Forms.Application.Restart();
            Application.Restart();
        }

        private void revisarGanador(string letra )
        {      
            foreach (TextBox txtb in ListaChar)
            {
                if (txtb.Text == letra)
                    Contador++;
            }
            if (Contador == Aux)
            {
                MessageBox.Show("Felicitaciones Ganaste!!!");
                reiniciar();
            }
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnQ.Text);
            revisarGanador(btnQ.Text);
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnW.Text);
            revisarGanador(btnW.Text);
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnE.Text);
            revisarGanador(btnE.Text);
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnR.Text);
            revisarGanador(btnR.Text);
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnT.Text);
            revisarGanador(btnT.Text);
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnY.Text);
            revisarGanador(btnY.Text);
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnU.Text);
            revisarGanador(btnU.Text);
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnI.Text);
            revisarGanador(btnI.Text);
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnO.Text);
            revisarGanador(btnO.Text);
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnP.Text);
            revisarGanador(btnP.Text);
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnA.Text);
            revisarGanador(btnA.Text);
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnS.Text);
            revisarGanador(btnS.Text);
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnD.Text);
            revisarGanador(btnD.Text);
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnF.Text);
            revisarGanador(btnF.Text);
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnG.Text);
            revisarGanador(btnG.Text);
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnH.Text);
            revisarGanador(btnH.Text);
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnJ.Text);
            revisarGanador(btnJ.Text);
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnK.Text);
            revisarGanador(btnK.Text);
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnL.Text);
            revisarGanador(btnL.Text);
        }

        private void btnÑ_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnÑ.Text);
            revisarGanador(btnÑ.Text);
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnZ.Text);
            revisarGanador(btnZ.Text);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnX.Text);
            revisarGanador(btnX.Text);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnC.Text);
            revisarGanador(btnC.Text);
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnV.Text);
            revisarGanador(btnV.Text);
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnB.Text);
            revisarGanador(btnB.Text);
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnN.Text);
            revisarGanador(btnN.Text);
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            recorrerPalabra(btnM.Text);
            revisarGanador(btnM.Text);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            reiniciar();
        }
    }
}

