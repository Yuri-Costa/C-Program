using System;

namespace sold
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("digite o nome do produto:");
            string nome = Console.ReadLine();
            Console.WriteLine("digite a quantidade:");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor do produto:");
            float valor = float.Parse(Console.ReadLine());

          //----------------------------------------------------------------

            float totalAserpago(string nome, int quantidade, float preco){
                float total = quantidade * preco;
                float desconto;
            //--------------------------------------------------------------

            if(quantidade<=5){
                desconto=0.02f;

            }else if(quantidade <= 10){
                desconto = 0.03f;
            }else{
                desconto = 0.05f;
            }

            float valordesconto= total * desconto;
            float totaldesconto = total - valordesconto;
            Console.WriteLine($"sua compra ficou em {total}");
            Console.WriteLine($"voce ira receber R$ {valordesconto} de desconto");
            Console.WriteLine($" sua compra com desconto ficou em R${totaldesconto}");


            Console.WriteLine(desconto);
            return total;

            //fim do tatal a pagar
            //---------------------------------------------------------------------





            }



            

        


            

            
        }
    }
}
