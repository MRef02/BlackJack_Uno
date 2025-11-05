using System;
using System.Drawing;

namespace BlackJack_Uno.clases;

class CartaBasica21BlackJack : CartaBase
{
    public override int Valor
    {
        get { return _valor; }
        set { _valor = value; }
    }

    public override Colores Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public CartaBasica21BlackJack(int valorcarta, Colores colorCarta, string figuraCarta) : base(valorcarta, colorCarta, valorcarta.ToString())
    {

    }
    
    public void MostrarCarta()
    {
        Console.WriteLine($"Carta: {Valor} {Color}");
    }
}