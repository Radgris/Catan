using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public enum Tipodenodo { Paja, Ladrillo, Madera, Comida, Mineral }


    class Node
    {
        List<Node> NodosConectados;
        List<Propiedad> AristasCOnectadas;
        List<Propiedad> VerticesCOnectados;
        Tipodenodo NodeType;
        int valor;
        public Node(List<Node> Nodos, List<Propiedad> Aristas, List<Propiedad>Vertices, Tipodenodo Enumtype, int value)
        {
            this.valor = value;
            
            this.NodeType = Enumtype;

            for(int i =0; i<=6;i++)
            {
                this.NodosConectados[i] = Nodos[i];
            }

            for (int i = 0; i <= 6; i++)
            {
                this.AristasCOnectadas[i] = Aristas[i];
            }

            for (int i = 0; i <= 6; i++)
            {
                this.VerticesCOnectados[i] = Vertices[i];
            }





        }
           
    }
}