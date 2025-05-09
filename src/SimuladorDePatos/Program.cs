using ProjetoPato.Services; 
using System;

namespace ProjetoPato
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("---- Simulador de Patos -------\n");

            Menus menu = new Menus();
            menu.menupersonagens();
        }
    }
}