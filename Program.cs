using System;

namespace ConsoleCadastro
{
    class Program
    {
        static void Main(string[] args)
        {
           FazerCafe("caramelo");
           
            
        }

    static void FazerCafe(string capsula)
    {
        System.Console.WriteLine("Esquentar água");
        System.Console.WriteLine("colocar o pó de café");
        System.Console.WriteLine("Colocar " + capsula);
    }



    }
}
