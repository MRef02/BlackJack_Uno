using System;

namespace BlackJack_Uno.clases._21Blackjack;

class CartaBase_21Blackjack : CartaBase
{
    //Valor de la carta
    public override int Valor
    {
        get { return _valor; }
        set { _valor = value; }
    }

    //Color de la carta
    public override Colores Color
    {
        get { return _color; }
        set { _color = value; }
    }

    //Figura de la carta
    public override string Figura
    {
        get { return _figura; }
        set { _figura = value; }
    }

    //Constructor
    public CartaBase_21Blackjack (Colores colorCarta, string figuraCarta) : base (colorCarta, figuraCarta)
    {
        
    }

}
