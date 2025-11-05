
namespace BlackJack_Uno.clases;

abstract class CartaBase
{
    protected int _valor;
    public abstract int Valor { get; set; }

    public enum Colores
    {
        Azul, Amarillo, Rojo, Verde, Negro
    }

    protected Colores _color;
    public abstract Colores Color { get; set; }

    protected string _figura = "";
    public string Figura { get; set; }

    protected CartaBase(Colores colorCarta, string figuraCarta)
    {
        Color = colorCarta;
        Figura = figuraCarta;
    }
}
