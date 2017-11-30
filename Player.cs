using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Player
    {

        int Paja;
        int Madera;
        int Mineral;
        int Comida;
        int Ladrillo;
        int puntosVictoria;

        int limitePuentes = 15;
        int limiteCasas= 5;
        int limiteCiudades =4;

        List<Propiedad> Propiedades;

        List<CDesarrollo> CartasDeDesarrollo;


        public void  CartaDeDesarrollo(CDesarrollo carta)
        {

        }

        public void AgregarRecurso(Tipodenodo tipo, int cantidad)
        {
            if(tipo==Tipodenodo.Paja)
                Paja+=cantidad;
            else if(tipo==Tipodenodo.Madera)
                Madera+=cantidad;
            else if(tipo==Tipodenodo.Mineral)
                Mineral+=cantidad;
            else if(tipo==Tipodenodo.Comida)
                Comida+=cantidad;
            else if(tipo==Tipodenodo.Ladrillo)
                Ladrillo+=cantidad;
        }

        public void QuitarRecurso(Tipodenodo tipo, int cantidad)
        {
            if(tipo==Tipodenodo.Paja)
                Paja-=cantidad;
            else if(tipo==Tipodenodo.Madera)
                Madera-=cantidad;
            else if(tipo==Tipodenodo.Mineral)
                Mineral-=cantidad;
            else if(tipo==Tipodenodo.Comida)
                Comida-=cantidad;
            else if(tipo==Tipodenodo.Ladrillo)
                Ladrillo-=cantidad;
        }
    }
}
