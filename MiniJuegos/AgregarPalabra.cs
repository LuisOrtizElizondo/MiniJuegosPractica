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
    public partial class AgregarPalabra : Form
    {
        public AgregarPalabra()
        {
            InitializeComponent();
        }

        public string MiPalabra { get; set; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MiPalabra = txtPalabra.Text;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
