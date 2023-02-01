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
    public partial class PantallaPpal : Form
    {
        public PantallaPpal()
        {
            InitializeComponent();
        }


        private void barraMenuTateti_Click(object sender, EventArgs e)
        {
            //Se recorren todos los elementos Forms en la coleccion
            //Application.OpenForms.
            //GetType() devuelve el tipo de objeto que es
            //typeof tipo de Form
            foreach (var item in Application.OpenForms)
            {
                if ((item.GetType() == typeof(FrmTateti))
                    || (item.GetType() == typeof(FrmAhorcado)))
                {
                    MessageBox.Show("Ya existe una ventana abierta.");
                    return;
                }

            }

            FrmTateti tateti = new FrmTateti();
            tateti.MdiParent = this;
            tateti.Show();
        }

        private void barraMenuAhorcado1J_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if ((item.GetType() == typeof(FrmTateti))
                    || (item.GetType() == typeof(FrmAhorcado)))
                {
                    MessageBox.Show("Ya existe una ventana abierta.");
                    return;
                }

            }

            FrmAhorcado ahorcado = new FrmAhorcado();

            ahorcado.unJugador = true;

            ahorcado.MdiParent = this;
            ahorcado.Show();  
        }

        private void barraMenuAhorcado2J_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if ((item.GetType() == typeof(FrmTateti))
                    || (item.GetType() == typeof(FrmAhorcado)))
                {
                    MessageBox.Show("Ya existe una ventana abierta.");
                    return;
                }

            }

            FrmAhorcado ahorcado = new FrmAhorcado();

            ahorcado.unJugador = false;

            ahorcado.MdiParent = this;
            ahorcado.Show();
        }
    }
}
