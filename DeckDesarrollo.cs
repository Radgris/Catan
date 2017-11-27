using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DeckDesarrollo
    {
        List<CDesarrollo> Deck;
        //14 caballero
        //2 monopolio
        //2 construcion puente
        //2 recursos
        //5 puntos de victoria

        public DeckDesarrollo()
        {


            shuffle();
        }


        public void  shuffle()
        {

        }


        public CDesarrollo Draw()
        {
            CDesarrollo Carta = Deck[0];
            Deck.RemoveAt(0);
            return Carta;  
        }
    }
}
