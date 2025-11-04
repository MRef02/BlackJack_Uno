namespace BlackJack_Uno.clases.UNO;

class CartaNormalUno : CartaBase
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

    public CartaNormalUno(int valorCarta, Colores colorCarta) : base(valorCarta, colorCarta, valorCarta.ToString())
    {

    }
    
    public void MostrarCarta()
    {
        Console.WriteLine($"Carta: {Valor} {Color}");
    }
}