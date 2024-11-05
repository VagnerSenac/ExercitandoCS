using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercitando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuInicial();
            ExibirMenu();
        }






        public static void MenuInicial()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Autor: Vagner Lourenço");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
███████╗██╗░░██╗███████╗██████╗░░█████╗░██╗████████╗░█████╗░███╗░░██╗██████╗░░█████╗░
██╔════╝╚██╗██╔╝██╔════╝██╔══██╗██╔══██╗██║╚══██╔══╝██╔══██╗████╗░██║██╔══██╗██╔══██╗
█████╗░░░╚███╔╝░█████╗░░██████╔╝██║░░╚═╝██║░░░██║░░░███████║██╔██╗██║██║░░██║██║░░██║
██╔══╝░░░██╔██╗░██╔══╝░░██╔══██╗██║░░██╗██║░░░██║░░░██╔══██║██║╚████║██║░░██║██║░░██║
███████╗██╔╝╚██╗███████╗██║░░██║╚█████╔╝██║░░░██║░░░██║░░██║██║░╚███║██████╔╝╚█████╔╝
╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("════════════════════════════════════");
            Console.ResetColor();
        }

        public static void ExibirMenu()
        {
            Console.WriteLine("Digite 0 para Sair");
            Console.WriteLine("Digite 1 para o Exercicio 1");
            Console.WriteLine("Digite 2 para o Exercicio 2");
            Console.WriteLine("Digite 3 para o Exercicio 3");
            Console.WriteLine("Digite 4 para o Exercicio 4");
            Console.WriteLine("Digite 5 para o Exercicio 5");
            Console.WriteLine("Digite 6 para o Exercicio 6");
            Console.WriteLine("Digite 7 para o Exercicio 7");
            Console.WriteLine("Digite 8 para o Exercicio 8");
            Console.WriteLine("\nDigite a opção escolhida:");
            int opcaoEscolhidaNumero = int.Parse(Console.ReadLine());


            switch (opcaoEscolhidaNumero)
            {
                case 1:

                    Ex1();
                    break;

                case 2:
                    Ex2();
                    break;


                case 3:

                    Ex3();
                    break;

                case 4:

                    Ex4();
                    break;


                case 5:

                    Ex5();
                    break;


                case 6:

                    Ex6();
                    break;

                case 7:

                    Ex7();
                    break;
                
                
                case 8:

                    Ex8();
                    break;

                case 0:
                    Console.Clear();
                    Console.WriteLine(@"
███████╗██╗░░░██╗██╗
██╔════╝██║░░░██║██║
█████╗░░██║░░░██║██║
██╔══╝░░██║░░░██║██║
██║░░░░░╚██████╔╝██║
╚═╝░░░░░░╚═════╝░╚═╝");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
            }
        }


             



        private static void Ex1()
        {

           
        }




        private static void Ex2()
        {
           
        }



        private static void Ex3()
        {
            
        }





        private static void Ex4()
        {
            
        }



        private static void Ex5() 
        {
           
        }



        private static void Ex6() 
        {
            
        }



        private static void Ex7()
        {

        }



        private static void Ex8()
        {

        }

    }
}
    

