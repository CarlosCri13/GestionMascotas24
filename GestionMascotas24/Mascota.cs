using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMascotas24
{
    public class Mascota
    {
        public string Nombre { set; get; }
        public string Raza { set; get; }
        public string Tipo { set; get; }
        public int Edad { set; get; }

        public Mascota()
        {
        }

        public Mascota(string nombre, string raza, string tipo, int edad)
        {
            Nombre = nombre;
            Raza = raza;
            Tipo = tipo;
            Edad = edad;
        }
    }
}
