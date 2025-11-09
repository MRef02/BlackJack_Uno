using System;
using System.Collections.Generic;
using BlackJack_Uno.Interfaces;

namespace BlackJack_Uno.clases
{
     abstract class BaseJugador
    {
        public string TipoJugador { get; private set; }
         public Mano Mano { get;  set; }

        protected BaseJugador(string tipoJugador)
        {
            TipoJugador = tipoJugador;
            Mano = new Mano();
        }

        
    }
}
