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


        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            Random rnd = new Random();
            while (n > 1)
            {
                int k = (rnd.Next(0, n) % n);
                n--;
                T value = list[k];
            list[k] = list[n];
                list[n] = value;
            }
        }



        public CDesarrollo Draw()
        {
            CDesarrollo Carta = Deck[0];
            Deck.RemoveAt(0);
            return Carta;  
        }
    }
}
