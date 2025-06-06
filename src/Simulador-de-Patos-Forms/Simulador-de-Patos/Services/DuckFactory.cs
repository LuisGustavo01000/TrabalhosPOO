using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoPato.Models;
using Simulador_de_Patos.Models;

namespace Simulador_de_Patos.Services
{
    public static class DuckFactory
    {
        public static Duck CriarPato(string tipo, int id)
        {
            return tipo switch
            {
                "Pato Selvagem" => new MallardDuck(id),
                "Pato Mudo" => new MuteDuck(id),
                "Pato Vermelho" => new RedHeadDuck(id),
                "Pato de Borracha" => new RuberDuck(id),
                "Pato Foguete" => new RocketDuck(id),
                "Super Pato" => new SuperDuck(id),
                "Pato Filhote" => new DuckLing(id),
                "Pato Tonto" => new DizzyDuck(id),
                "Pato de Madeira" => new DecoyDuck(id),
                _ => throw new ArgumentException("Tipo de pato desconhecido.")
            };
        }

    }

}

