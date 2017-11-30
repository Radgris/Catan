using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Aristas:Propiedad
    {
        List<Aristas> CaminosVecinos;
        List<Vertices> PuebloAdyacente;

        public Aristas(Player Pl, Puerto TipoDePuerto):base(Pl, TipoDePuerto)
        {
            CaminosVecinos = new List<Aristas>(3);
            PuebloAdyacente = new List<Vertices>(2);
        }

    }
}
