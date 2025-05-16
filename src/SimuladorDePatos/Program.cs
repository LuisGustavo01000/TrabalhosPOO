using ProjetoPato.Services; 
using ProjetoPato.Models;
using ProjetoPato.Interfaces;
using System;

namespace ProjetoPato
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("--------- Simulador de Patos --------\n");

            Menus menu = new Menus();
            menu.IniciarMenu();
            menu.BattleMenu();
            
            Console.WriteLine("\n--------- Fim do Simulador de Patos --------");
        }
    }
}