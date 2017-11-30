using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Vertices:Propiedad
    {
        List<Vertices> Vecinos;
        List<Aristas> Caminos;

        public Vertices(Player Pl, Puerto TipoDePuerto):base(Pl,TipoDePuerto)
        {
            Vecinos = new List<Vertices>(3);
            Caminos = new List<Aristas>(3);
        }

    }
}
