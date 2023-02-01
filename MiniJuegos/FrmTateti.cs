using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TATETI
{
    public partial class FrmTateti : Form
    {
        public FrmTateti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (statusLblJugador.Text.Equals("JUGADOR 1")) {
                btn11.Text = "X";
                statusLblJugador.Text = "JUGADOR 2";
                btn11.Enabled = false;
                verificarGanador();

            } else if (statusLblJugador.Text.Equals("JUGADOR 2")) { 
                btn11.Text = "O";
                statusLblJugador.Text = "JUGADOR 1";
                btn11.Enabled = false;
                verificarGanador();
            }      
        }

        private void verificarGanador()
        {
            bool hayGanador = false;

            // VERIFICACION HORIZONTAL
            if ((btn11.Text.Equals("X") && btn12.Text.Equals("X") && btn13.Text.Equals("X"))
                || (btn21.Text.Equals("X") && btn22.Text.Equals("X") && btn23.Text.Equals("X"))
                || (btn31.Text.Equals("X") && btn32.Text.Equals("X") && btn33.Text.Equals("X")))
            {
                MessageBox.Show("JUGADOR 1 GANADOR");
                hayGanador = true;
            }

            if ((btn11.Text.Equals("O") && btn12.Text.Equals("O") && btn13.Text.Equals("O"))
               || (btn21.Text.Equals("O") && btn22.Text.Equals("O") && btn23.Text.Equals("O"))
               || (btn31.Text.Equals("O") && btn32.Text.Equals("O") && btn33.Text.Equals("O")))
            {
                MessageBox.Show("JUGADOR 2 GANADOR");
                hayGanador = true;
            }

            //VERIFICACION VERTICAL
            if ((btn11.Text.Equals("X") && btn21.Text.Equals("X") && btn31.Text.Equals("X"))
                ||(btn12.Text.Equals("X") && btn22.Text.Equals("X") && btn32.Text.Equals("X"))
                ||(btn13.Text.Equals("X") && btn23.Text.Equals("X") && btn33.Text.Equals("X")))
            {
                MessageBox.Show("JUGADOR 1 GANADOR");
                hayGanador = true;
            }

            if ((btn11.Text.Equals("O") && btn21.Text.Equals("O") && btn31.Text.Equals("O"))
                || (btn12.Text.Equals("O") && btn22.Text.Equals("O") && btn32.Text.Equals("O"))
                || (btn13.Text.Equals("O") && btn23.Text.Equals("O") && btn33.Text.Equals("O")))
            {
                MessageBox.Show("JUGADOR 2 GANADOR");
                hayGanador = true;
            }

            //VERIFICACION DIAGONAL
            if((btn11.Text.Equals("X") && btn22.Text.Equals("X") && btn33.Text.Equals("X"))
                || (btn31.Text.Equals("X") && btn22.Text.Equals("X") && btn13.Text.Equals("X")))
            {
                MessageBox.Show("JUGADOR 1 GANADOR");
                hayGanador = true;
            }

            if ((btn11.Text.Equals("O") && btn22.Text.Equals("O") && btn33.Text.Equals("O"))
                || (btn31.Text.Equals("O") && btn22.Text.Equals("O") && btn13.Text.Equals("O")))
            {
                MessageBox.Show("JUGADOR 2 GANADOR");
                hayGanador = true;
            }

            if (hayGanador)
                finalizarPartida();
               
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (statusLblJugador.Text.Equals("JUGADOR 1"))
            {
                btn12.Text = "X";
                statusLblJugador.Text = "JUGADOR 2";
                btn12.Enabled = false;
                verificarGanador();
            }
            else if (statusLblJugador.Text.Equals("JUGADOR 2"))
            {
                btn12.Text = "O";
                statusLblJugador.Text = "JUGADOR 1";
                btn12.Enabled = false;
                verificarGanador();
            }
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (statusLblJugador.Text.Equals("JUGADOR 1"))
            {
                btn13.Text = "X";
                statusLblJugador.Text = "JUGADOR 2";
                btn13.Enabled = false;
                verificarGanador();

            }
            else if (statusLblJugador.Text.Equals("JUGADOR 2"))
            {
                btn13.Text = "O";
                statusLblJugador.Text = "JUGADOR 1";
                btn13.Enabled = false;
                verificarGanador();
            }
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if (statusLblJugador.Text.Equals("JUGADOR 1"))
            {
                btn21.Text = "X";
                statusLblJugador.Text = "JUGADOR 2";
                btn21.Enabled = false;
                verificarGanador();

            }
            else if (statusLblJugador.Text.Equals("JUGADOR 2"))
            {
                btn21.Text = "O";
                statusLblJugador.Text = "JUGADOR 1";
                btn21.Enabled = false;
                verificarGanador();
            }
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (statusLblJugador.Text.Equals("JUGADOR 1"))
            {
                btn22.Text = "X";
                statusLblJugador.Text = "JUGADOR 2";
                btn22.Enabled = false;
                verificarGanador();

            }
            else if (statusLblJugador.Text.Equals("JUGADOR 2"))
            {
                btn22.Text = "O";
                statusLblJugador.Text = "JUGADOR 1";
                btn22.Enabled = false;
                verificarGanador();
            }
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            if (statusLblJugador.Text.Equals("JUGADOR 1"))
            {
                btn23.Text = "X";
                statusLblJugador.Text = "JUGADOR 2";
                btn23.Enabled = false;
                verificarGanador();

            }
            else if (statusLblJugador.Text.Equals("JUGADOR 2"))
            {
                btn23.Text = "O";
                statusLblJugador.Text = "JUGADOR 1";
                btn23.Enabled = false;
                verificarGanador();
            }
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            if (statusLblJugador.Text.Equals("JUGADOR 1"))
            {
                btn31.Text = "X";
                statusLblJugador.Text = "JUGADOR 2";
                btn31.Enabled = false;
                verificarGanador();

            }
            else if (statusLblJugador.Text.Equals("JUGADOR 2"))
            {
                btn31.Text = "O";
                statusLblJugador.Text = "JUGADOR 1";
                btn31.Enabled = false;
                verificarGanador();
            }
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            if (statusLblJugador.Text.Equals("JUGADOR 1"))
            {
                btn32.Text = "X";
                statusLblJugador.Text = "JUGADOR 2";
                btn32.Enabled = false;
                verificarGanador();

            }
            else if (statusLblJugador.Text.Equals("JUGADOR 2"))
            {
                btn32.Text = "O";
                statusLblJugador.Text = "JUGADOR 1";
                btn32.Enabled = false;
                verificarGanador();
            }
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            if (statusLblJugador.Text.Equals("JUGADOR 1"))
            {
                btn33.Text = "X";
                statusLblJugador.Text = "JUGADOR 2";
                btn33.Enabled = false;
                verificarGanador();

            }
            else if (statusLblJugador.Text.Equals("JUGADOR 2"))
            {
                btn33.Text = "O";
                statusLblJugador.Text = "JUGADOR 1";
                btn33.Enabled = false;
                verificarGanador();
            }
        }

        private void finalizarPartida()
        {
            btn11.Enabled = false;
            btn12.Enabled = false;
            btn13.Enabled = false;
            btn21.Enabled = false;
            btn22.Enabled = false;
            btn23.Enabled = false;
            btn31.Enabled = false;
            btn32.Enabled = false;
            btn33.Enabled = false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn13.Enabled = true;
            btn21.Enabled = true;
            btn22.Enabled = true;
            btn23.Enabled = true;
            btn31.Enabled = true;
            btn32.Enabled = true;
            btn33.Enabled = true;

            btn11.Text = null;
            btn12.Text = null;
            btn13.Text = null;
            btn21.Text = null;
            btn22.Text = null;
            btn23.Text = null;
            btn31.Text = null;
            btn32.Text = null;
            btn33.Text = null;

            statusLblJugador.Text = "JUGADOR 1";

        }
    }

}

