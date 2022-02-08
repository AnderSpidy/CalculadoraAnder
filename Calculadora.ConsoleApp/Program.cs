using System;
using System.Collections.Generic;

namespace Calculadora.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string historicodeOperacoes = "";
            
            string opcao = "";
            while (opcao != "s")
            {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("Calculadora Topzera!!! 1.5");
            Console.WriteLine("Digite 1 para somar ");
            Console.WriteLine("Digite 2 para subtrair");
            Console.WriteLine("Digite 3 para multiplicar");
            Console.WriteLine("Digite 4 para dividir");
            Console.WriteLine("Digite 5 para obter o resto da divisão");
            Console.WriteLine("Digite 's' para fechar o progama");
            opcao = Console.ReadLine();
            
                switch (opcao)
                {
                    
                    case "1":
                        Console.WriteLine("\n--------------------\n");
                        Console.WriteLine("ADIÇÃO");
                        Console.WriteLine("Primeiro numero: ");
                        string strPrimeiroNumero = Console.ReadLine();
                        Console.WriteLine("Segundo numero: ");
                        string strSegundoNumero = Console.ReadLine();

                        int primeiroNumero = Convert.ToInt32(strPrimeiroNumero);
                        int segundoNumero = Convert.ToInt32(strSegundoNumero);

                        int resultado = primeiroNumero + segundoNumero;
                        Console.WriteLine("O resultado da adição é " + resultado);
                        Console.WriteLine("\n--------------------\n");

                        break;
                    case "2":
                        
                        Console.WriteLine("\n--------------------\n");
                        Console.WriteLine("SUBTRAÇÃO");
                        Console.WriteLine("Primeiro numero: ");
                        string strPrimeiroNumero2 = Console.ReadLine();
                        Console.WriteLine("Segundo numero: ");
                        string strSegundoNumero2 = Console.ReadLine();

                        int primeiroNumero2 = Convert.ToInt32(strPrimeiroNumero2);
                        int segundoNumero2 = Convert.ToInt32(strSegundoNumero2);

                        int resultado2 = primeiroNumero2 - segundoNumero2;
                        Console.WriteLine("O resultado da subtração é " + resultado2);
                        Console.WriteLine("\n--------------------\n");

                        break;
                    case "3":
                        Console.WriteLine("\n--------------------\n");
                        Console.WriteLine("MULTPLICAÇÃO");
                        Console.WriteLine("Primeiro numero: ");
                        string strPrimeiroNumero3 = Console.ReadLine();
                        Console.WriteLine("Segundo numero: ");
                        string strSegundoNumero3 = Console.ReadLine();

                        int primeiroNumero3 = Convert.ToInt32(strPrimeiroNumero3);
                        int segundoNumero3 = Convert.ToInt32(strSegundoNumero3);

                        int resultado3 = primeiroNumero3 * segundoNumero3;
                        Console.WriteLine("O resultado da multplicação é " + resultado3);
                        Console.WriteLine("\n--------------------\n");
                        break;

                    case "4":
                        Console.WriteLine("\n--------------------\n");
                        Console.WriteLine("DIVISÃO");
                        Console.WriteLine("Primeiro numero: ");
                        string strPrimeiroNumero4 = Console.ReadLine();
                        Console.WriteLine("Segundo numero: ");
                        string strSegundoNumero4 = Console.ReadLine();

                        int primeiroNumero4 = Convert.ToInt32(strPrimeiroNumero4);
                        int segundoNumero4 = Convert.ToInt32(strSegundoNumero4);
                        
                        if (segundoNumero4 != 0)
                        {
                            float resultado4 = ((float)primeiroNumero4 / segundoNumero4);
                            Console.WriteLine("O resultado da Divisão é " + resultado4);
                            Console.WriteLine("\n--------------------\n");

                        }
                        else
                        {
                            Console.WriteLine("Não é posivel divisão com o numero 0!!!");
                        }
                        
                        
                        break;

                    case "5":
                        Console.WriteLine("\n--------------------\n");
                        Console.WriteLine("RESTO DA DIVISÃO");
                        Console.WriteLine("Primeiro numero: ");
                        string strPrimeiroNumero5 = Console.ReadLine();
                        Console.WriteLine("Segundo numero: ");
                        string strSegundoNumero5 = Console.ReadLine();

                        int primeiroNumero5 = Convert.ToInt32(strPrimeiroNumero5);
                        int segundoNumero5 = Convert.ToInt32(strSegundoNumero5);

                        if (segundoNumero5 != 0)
                        {
                            float resultado5 = ((float)primeiroNumero5 % segundoNumero5);
                            Console.WriteLine("O o resto da Divisão é " + resultado5);

                        }
                        else
                        {
                            Console.WriteLine("Não é posivel divisão com o numero 0!!!");
                        }

                        break;
                    case "s":
                        Console.WriteLine("FECHAR CALCULADORA\nATÉ A PROXIMA!!!");
                        break;
                    default:
                        Console.WriteLine("OPÇÃO INVALIDA.\n DIGITE UMA DAS OPÇÕES SUGERIDAS NO MENU!!!");
                        break;
                        
                }
                historicodeOperacoes = 
                Console.ReadLine();
            }
            //.....................................OPÇÃO SEM SWITCH CASE..........................
            //.....................................APENAS COM WHILE..............................


            /*string opcao = "";
            while(opcao != "s")
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                Console.WriteLine("Calculadora Topzera!!! 1.5");
                Console.WriteLine("Digite 1 para somar ");
                Console.WriteLine("Digite 2 para subtrair");
                Console.WriteLine("Digite 3 para multiplicar");
                Console.WriteLine("Digite 4 para dividir");
                Console.WriteLine("Digite 5 para obter o resto da divisão");
                Console.WriteLine("Digite 's' para fechar o progama");
                opcao = Console.ReadLine();
                
                Console.WriteLine("-------------------------");
                if (opcao == "s")
                    {
                    break;
                    }
                else if ( opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4" || opcao == "5")
                { 

                    Console.WriteLine("Primeiro numero: ");
                    string strPrimeiroNumero = Console.ReadLine();
                    Console.WriteLine("Segundo numero: ");
                    string strSegundoNumero = Console.ReadLine();

                   

                    int primeiroNumero = Convert.ToInt32(strPrimeiroNumero);
                    int segundoNumero = Convert.ToInt32(strSegundoNumero);
                    if (opcao == "1")
                    {
                        int resultado = primeiroNumero + segundoNumero;
                        Console.WriteLine("O resultado da adição é " + resultado);


                    }
                    else if (opcao == "2")
                    {
                        int resultado = primeiroNumero - segundoNumero;
                        Console.WriteLine("O resultado do subtração é " + resultado);

                    }
                    else if (opcao == "3")
                    {
                        int resultado = primeiroNumero * segundoNumero;
                        Console.WriteLine("O resultado da multiplicação é " + resultado);

                    }
                    else if (opcao == "4")
                    {
                        if (segundoNumero != 0)
                        {
                            float resultado = ((float)primeiroNumero / segundoNumero);
                            Console.WriteLine("O resultado da Divisão é " + resultado);

                        }
                        else
                        {
                            Console.WriteLine("Não é posivel divisão com o numero 0!!!");
                        }
                    }
                    else if (opcao == "5")
                    {
                        if (segundoNumero != 0)
                        {
                            float resultado = ((float)primeiroNumero % segundoNumero);
                            Console.WriteLine("O o resto da Divisão é " + resultado);

                        }
                        else
                        {
                            Console.WriteLine("Não é posivel divisão com o numero 0!!!");
                        }
                    }

                }

                Console.WriteLine("-----------------------");
                Console.ReadLine();            
            }*/
        }
    }
}
