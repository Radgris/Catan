using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Tablero
    {
        List<Node> Board;
        List<Player> Players;
        DeckDesarrollo Deck;
        int PajaRestante;
        int MaderaRestante;
        int MineralRestante;
        int ComidaRestante;
        int LadrilloRestante;
        //19 de cada uno

        public Tablero()
        {
            Deck = new DeckDesarrollo();
        }


        public void Trade(Player Trading, Player ToTrade, List<int> ResourcesTrading, List <int>ResourcesToTrade )
        {
            Trading.Paja -= ResourcesTrading[0];
            Trading.Madera -= ResourcesTrading[1];
            Trading.Mineral -= ResourcesTrading[2];
            Trading.Comida -= ResourcesTrading[3];
            Trading.Ladrillo -= ResourcesTrading[4];

            Trading.Paja += ResourcesToTrade[0];
            Trading.Madera += ResourcesToTrade[1];
            Trading.Mineral += ResourcesToTrade[2];
            Trading.Comida += ResourcesToTrade[3];
            Trading.Ladrillo += ResourcesToTrade[4];


            ToTrade.Paja -= ResourcesToTrade[0];
            ToTrade.Madera -= ResourcesToTrade[1];
            ToTrade.Mineral -= ResourcesToTrade[2];
            ToTrade.Comida -= ResourcesToTrade[3];
            ToTrade.Ladrillo -= ResourcesToTrade[4];


            ToTrade.Paja += ResourcesTrading[0];
            ToTrade.Madera += ResourcesTrading[1];
            ToTrade.Mineral += ResourcesTrading[2];
            ToTrade.Comida += ResourcesTrading[3];
            ToTrade.Ladrillo += ResourcesTrading[4];

        }

        public bool  CheckWin(Player PlayerCheck)
        {
            if (PlayerCheck.puntosVictoria  >=10 )
            {
                return true;
            }

            else
            {
                return false;
            }
        }


        public void ResourceDistribution(int Dicenumber)
        {
            foreach (Node Nodo in Board)
            {
                if(Nodo.valor == Dicenumber)
                {
                   foreach(Propiedad prop in Nodo.VerticesCOnectados)
                   {
                       if(prop.Activo == true)
                       {
                           prop.Propietario.AgregarRecurso(Nodo.NodeType,(int)prop.tipo);
                       }
                   } 
                }
            }
        }

    }
}
