using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoUruguayo
{
    public class Jugador
    {
        public int ID;
        public string? Nombre;
        public List<Carta> Mano = new List<Carta>();
        public Jugador() { }
        public Jugador(int id, string nombre)
        {
            ID = id;
            Nombre = nombre;
        }

        public static List<Jugador> CrearJugadores(int cantidad)
        {
            List<Jugador> jugadores = new List<Jugador>();
            for (int i = 1; i <= cantidad; i++)
            {
                Jugador jugador = new Jugador
                {
                    ID = i,
                    Nombre = $"Jugador {i}",
                    Mano = new List<Carta>()
                };
                jugadores.Add(jugador);
            }
            return jugadores;
        } // Implementar más tarde (tal vez)
    }
}
