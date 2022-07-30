using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMascotas24
{
    public class Mascotas
    {
        public List<Mascota> MisMascotas { set; get; }

        public Mascotas()
        {
            MisMascotas = new List<Mascota> { };
        }
        public void Agregar(Mascota mascota)
        {
            MisMascotas.Add(mascota);
        }
        public List<Mascota> MascotaLetra(string cadena)
        {
            List<Mascota> aux = new List<Mascota> { };
            foreach (Mascota mascota in MisMascotas)
            {
                if (mascota.Nombre.Contains(cadena))
                {
                    aux.Add(mascota);
                }
            }
            return aux;
        }

        public List<Mascota> EdadPar()
        {
            List<Mascota> aux = new List<Mascota>();
            foreach (Mascota mascota in MisMascotas)
            {
                if (mascota.Edad %2==0)
                {
                    aux.Add(mascota);
                }
            }
            return aux;
        }
         


    }
}
