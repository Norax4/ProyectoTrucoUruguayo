using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoUruguayo
{
    public class Carta
    {
        public int ID;
        public string? Palo;
        public int Numero;
        public Carta() { }

        public static List<Carta> CrearMazo()
        {
            List<Carta> mazo = new List<Carta>();
            int id = 1;
            string[] palos = { "Espada", "Basto", "Oro", "Copa" };
            foreach (var palo in palos)
            {
                for (int numero = 1; numero <= 7; numero++)
                {
                    Carta carta = new Carta
                    {
                        ID = id++,
                        Palo = palo,
                        Numero = numero
                    };
                    mazo.Add(carta);
                }
                for (int numero = 10; numero <= 12; numero++)
                {
                    Carta carta = new Carta
                    {
                        ID = id++,
                        Palo = palo,
                        Numero = numero
                    };
                    mazo.Add(carta);
                }
            }
            return mazo;
        }

        public static void MostrarMazo(List<Carta> mazo)
        {
            foreach (var carta in mazo)
            {
                Console.WriteLine($"ID: {carta.ID}, Basto: {carta.Palo}, Numero: {carta.Numero}");
            }
        }

    }
}
