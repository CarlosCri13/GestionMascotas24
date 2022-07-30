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
    public partial class Form1GL : Form
    {
        Mascotas mascotas = new Mascotas();
        public Form1GL()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = txtNombre.Text;
            mascota.Tipo = cmbTipo.SelectedItem.ToString();
            mascota.Raza = txtRaza.Text;
            mascota.Edad = Convert.ToInt32(mtxtEdad.Text);
            mascotas.Agregar(mascota);
            MessageBox.Show("Los datos ingresados correctamente ");
            Limpiar();
        }

        private void dgvMascotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvMascotas.DataSource = mascotas.MisMascotas;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.mascotas = mascotas;
        }
        public void Limpiar()
        {
            txtNombre.Text = " ";
            txtRaza.Text = " ";
            mtxtEdad.Text = "  ";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void MASCOTAS_Click(object sender, EventArgs e)
        {

        }
    }
}
