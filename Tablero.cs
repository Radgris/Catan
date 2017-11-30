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
                            if (Nodo.NodeType == NodeType.Paja)
                                PajaRestante -= prop.tipo;
                            else if (Nodo.NodeType == NodeType.Madera)
                                MaderaRestante -= prop.tipo;
                            else if (Nodo.NodeType == NodeType.Mineral)
                                MineralRestante -= prop.tipo;
                            else if (Nodo.NodeType == NodeType.Comida)
                                ComidaRestante -= prop.tipo;
                            else if (Nodo.NodeType == NodeType.Ladrillo)
                                LadrilloRestante -= prop.tipo;
                        }
                    } 
                }
            }
        }
        
        public void ConstruirVertice(Vertices spot, Player building)
        {
            if (!spot.Activo)
            {
                bool vecinos = false;
                bool caminoVertice = false;
                foreach (Vertices vecino in spot.Vecinos)
                {
                    if (vecino.Activo)
                    {
                        vecinos = true;
                        break;
                    }
                }
                    
                foreach(Aristas camino in spot.Caminos)
                {
                    if (camino.Activo && camino.Propietario == building)
                    {
                        caminoVertice = true;
                        break;
                    }
                }
                if (!vecinos && caminoVertice)
                {
                    if (building.Paja >= 1 && building.Madera >= 1 && building.Comida >= 1 && building.Ladrillo >= 1)
                    {
                        building.QuitarRecuerso(Tipodenodo.Paja, 1);
                        building.QuitarRecuerso(Tipodenodo.Madera, 1);
                        building.QuitarRecuerso(Tipodenodo.Comida, 1);
                        building.QuitarRecuerso(Tipodenodo.Ladrillo, 1);
                        spot.Activo = true;
                        spot.Propietario = building;
                    }
                }
            }
            else if (spot.Activo)
            {
                if (spot.Propietario == building)
                {
                    if (building.Paja >= 2 && building.Mineral >= 3)
                    {
                        building.QuitarRecurso(Tipodenodo.Paja, 2);
                        building.QuitarRecurso(Tipodenodo.Mineral, 3);
                        spot.tipo = Type.ciudad;
                    }
                }
            }
        }

        public void ConstruirArista(Arista arista, Player building)
        {
            bool PuebloObstruye = false;
            bool CaminoPermite = false;
            foreach(Vertices Pueblo in arista.PuebloAyacente)
            {
                if (Pueblo.Activo && Pueblo.Propietario != building)
                {
                    PuebloObstruye = true;
                    break;
                }
            }
            foreach(Aristas caminoAdyacente in arista.CaminosVecinos)
            {
                if (caminoAdyacente.Activo && caminoAdyacente.Propietario == building)
                {
                    CaminoPermite = true;
                    break;
                }
            }
            if (!arista.Activo)
            {
                if (!PuebloObstruye && CaminoPermite)
                {
                    if (building.Madera >= 1 && building.Ladrillo >= 1)
                    {
                        building.QuitarRecuero(Tipodenodo.Madera, 1);
                        building.QuitarRecuero(Tipodenodo.Ladrillo, 1);
                        spot.Activo = true;
                        spot.Propietario = building;
                    }
                }
            }
        }

        
    }
}
