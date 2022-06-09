using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Program
    {
        public static string[] cliente = new string[4];
        public static string[] cargo = new string[4];
        public static double[] salario = new double[4];
        public static int i = 0;

        public static string cadastro()
        {
            Console.Write("Digite o nome do cliente: ");
            cliente[i] = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Digite o cargo cliente: ");
            cargo [i] = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Digite o salário do cliente: ");
            double.TryParse(Console.ReadLine(), out salario[i]);
            Console.WriteLine("");
           

            return null;
        }
        

        public static string relatorio()
         {
             int lista = 0;
             for (lista = 0; lista <= 3; lista++)
             {
                 Console.WriteLine("");
                 Console.WriteLine("Digite o nome do cliente: {0}", cliente[lista]);
                 Console.WriteLine("");

                 Console.WriteLine("Digite seu cargo: {0}", cargo[lista]);
                 Console.WriteLine("");

                 Console.WriteLine("Digite seu salário: R${0}", salario[lista]);
                 Console.WriteLine("");
             }
             i++;
            return null;
         }
    
        
        
        static void Main(string[] args)
        {

            
            
            string opçao = "S";
            
            do
            {
                if (opçao.ToUpper() == "S")
                {
                    cadastro();
                    Console.Write("Deseja continuar? ");
                    Console.WriteLine("");
                    Console.Write(">S< - SIM | NÃO - >N<:  ");
                    opçao = Console.ReadLine();

                      if(opçao == "N" || opçao == "n")
                {
                    relatorio();
                }
                    
                }

               
                    
            }

            while (opçao.ToUpper() == "S");
            Console.ReadKey();

                
            
            
        }
    }
}
