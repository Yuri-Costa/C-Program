using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("voce quer ver a tabuada de qual número?");
            int resposta = int.Parse(Console.ReadLine());

            //int resultado;

            for(int contador = 0; contador <= 10; contador ++){
                //resultado multiplicando
                Console.WriteLine($"{resposta} * {contador} = {resposta * contador}");
                System.Threading.Thread.Sleep(1000);
        }
    }
}
