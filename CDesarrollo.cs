using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public enum CardType { monopolio, puntoVictoria, caballero, puentes, recursos }


    class CDesarrollo
    {
        CardType TipoDeCarta;   
        //monopolio, punto de victoria, caballero, puentes, recurso

        public CDesarrollo(CardType tipo)
        {
            this.TipoDeCarta = tipo;
        }
    }
}
