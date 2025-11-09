
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

    public CartaBase(int valorCarta,Colores colorCarta)
    {
        Valor = valorCarta;
        Color = colorCarta;
    }
}
