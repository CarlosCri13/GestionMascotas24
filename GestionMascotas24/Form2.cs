using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMascotas24
{
    public partial class Form2 : Form
    {
        public Mascotas mascotas { set; get; }
        public Form2()
        {
            InitializeComponent();
            mascotas = new Mascotas();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvMascotas.DataSource = mascotas.MascotaLetra(txtCadena.Text);
        }

        private void btnEdadPar_Click(object sender, EventArgs e)
        {
            dgvPar.DataSource = mascotas.EdadPar();
        }
    }
}
