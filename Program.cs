using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            Console.WriteLine("Qual tipo de conta você deseja realizar?");
            calculadora.conta = Console.ReadLine();

            if(calculadora.conta == "soma"){
                Console.WriteLine ("Digite o primeiro valor: ");
                calculadora.valor = Int32.Parse(Console.ReadLine());
                Console.WriteLine ("Digite o segundo valor: ");
                calculadora.valor = Int32.Parse(Console.ReadLine());
                
            }            
        }
    }
}
