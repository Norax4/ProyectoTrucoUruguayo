namespace TrucoUruguayo.Tests;
using System;
using Xunit;

public class TrucoTests
{
    [Fact]
    public void ContadorCartas()
    {
        List<Carta> cartas = Carta.CrearMazo();

        int largo = cartas.Count;

        Assert.Equal(40, largo);
    }

    [Fact]
    public void ExcluirCartas_8_9()
    {
        List<Carta> cartas = Carta.CrearMazo();
        //cartas.RemoveAll(c => c.Valor == 8 || c.Valor == 9);

        foreach (Carta c in cartas) {
            Assert.NotEqual(8, c.Numero);
            Assert.NotEqual(9, c.Numero);
        }
    }

    [Fact]
    public void ContarCartasPorPalo()
    {
        List<Carta> cartas = Carta.CrearMazo();
        int espadas = cartas.Count(c => c.Palo == "espada");
        int bastos = cartas.Count(c => c.Palo == "basto");
        int oros = cartas.Count(c => c.Palo == "oro");
        int copas = cartas.Count(c => c.Palo == "copa");
        Assert.Equal(10, espadas);
        Assert.Equal(10, bastos);
        Assert.Equal(10, oros);
        Assert.Equal(10, copas);
    }

    [Fact]
    public void ContarCartasPorJugador()
    {
        Random rand = new Random();
        List<Carta> cartas = Carta.CrearMazo();
        List<Jugador> jugadores = new List<Jugador>
        {
            new Jugador {ID = 1, Nombre = "Juan"},
            new Jugador {ID = 2, Nombre = "Pedro"}
        };

        foreach (Jugador jugador in jugadores)
        {
            for (int i = 0; i < 3; i++)
            {
                int indCarta = rand.Next(0, cartas.Count);
                Carta added = cartas[indCarta];
                cartas.RemoveAt(indCarta);
                jugador.Cartas.Add(added);
            }
        }
        
        foreach (var jugador in jugadores)
        {
            Assert.Equal(3, jugador.Cartas.Count);
        }
    }

    [Fact]
    public void AsignarCartaMuestra()
    {
        Random rand = new Random();
        List<Carta> cartas = Carta.CrearMazo();
        int indCarta = rand.Next(0, cartas.Count);
        Carta cartaMuestra = cartas[indCarta];
        cartas.RemoveAt(indCarta);
        Assert.NotNull(cartaMuestra);
        Assert.DoesNotContain(cartaMuestra, cartas);
    }

    [Fact]
    public void CompararMuestraYCartasJugadores()
    {
        Random rand = new Random();
        List<Carta> cartas = Carta.CrearMazo();
        List<Jugador> jugadores = new List<Jugador>
        {
            new Jugador { Nombre = "Juan", Mano = new List<Carta>()},
            new Jugador { Nombre = "Pedro", Mano = new List<Carta>() }
        };

        foreach (Jugador jugador in jugadores)
        {
            for (int i = 0; i < 3; i++)
            {
                int indCarta = rand.Next(0, cartas.Count);
                Carta added = cartas[indCarta];
                cartas.RemoveAt(indCarta);
                jugador.Cartas.Add(added);
            }
        }

        int indCarta = rand.Next(0, cartas.Count);
        Carta cartaMuestra = cartas[indCarta];
        cartas.RemoveAt(indCarta);

        foreach (var jugador in jugadores)
        {
            Assert.DoesNotContain(cartaMuestra, jugador.Cartas);
        }
    }
}
