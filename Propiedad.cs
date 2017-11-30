using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public enum Puerto {Nulo,Generico,Paja,Madera,Mineral,Comida,Ladrillo}

    public enum Type {puente,casa,ciudad}

    class Propiedad
    {
        Player Propietario;
        bool Activo;
        Puerto Port;
        //nulo, tipo, generico
        Type tipo;
        //casa, ciuidad, puente

        public Propiedad(Player Pl, Puerto TipoDePuerto)
        {
            this.Propietario=Pl;
            this.activo=false;
            this.Port = TipoDePuerto;
        }

    }
}
