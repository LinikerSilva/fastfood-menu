using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            double total = 0.00;

            Console.WriteLine("=============================================");
            Console.WriteLine("Olá! Bem vindo ao Fast-Food Comida Rápida.");
            Console.WriteLine("Escolha algo do nosso cardápio:");
            Console.WriteLine("=============================================");
            Console.WriteLine("          -=Cardápio Comida Rápida=-");
            Console.WriteLine("||Hambúrguer: R$13,50                        ||");
            Console.WriteLine("||Refrigerante: R$5,00                       ||");
            Console.WriteLine("||Cachorro-Quente: R$7,50                    ||");
            Console.WriteLine("||Suco: R$6,00                               ||");
            Console.WriteLine("||Cerveja: R$4,00                            ||");
            Console.WriteLine("||Pizza: R$15,00                             ||");
            Console.WriteLine("||Batata-Frita c/ Bacon: R$20,00             ||");
            Console.WriteLine("||Batata-Frita c/ Cheddar: R$25,00           ||");
            Console.WriteLine("||Batata-Frita c/ Bacon e Cheddar: R$30,00   ||");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-==-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine();

            while (answer != "N")
            {
                switch (Console.ReadLine())
                {
                    case "S":
                        answer = "S";
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Ótimo! Qual o nome do que você quer comer ou beber?");
                        break;
                    case "Hambúrguer":
                        total = total + 13.50;
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("Hambúrguer adicionado com sucesso ao pedido! Algo mais? (S/N)");
                        break;
                    case "Refrigerante":
                        total = total + 5.00;
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("Refrigerante adicionado com sucesso ao pedido! Algo mais? (S/N)");
                        break;
                    case "Cachorro-Quente":
                        total = total + 7.50;
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("Cachorro-Quente adicionado com sucesso ao pedido! Algo mais? (S/N)");
                        break;
                    case "Suco":
                        total = total + 6.00;
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("Suco adicionado com sucesso ao pedido! Algo mais? (S/N)");
                        break;
                    case "Cerveja":
                        total = total + 4.00;
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("Cerveja adicionada com sucesso ao pedido! Algo mais? (S/N)");
                        break;
                    case "Pizza":
                        total = total + 15.00;
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("Pizza adicionada com sucesso ao pedido! Algo mais? (S/N)");
                        break;
                    case "Batata-Frita c/ Bacon":
                        total = total + 20.00;
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("Batata-Frita c/ Bacon adicionada com sucesso ao pedido! Algo mais? (S/N)");
                        break;
                    case "Batata-Frita c/ Cheddar":
                        total = total + 25.00;
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("Batata-Frita c/ Cheddar adicionada com sucesso ao pedido! Algo mais? (S/N)");
                        break;
                    case "Batata-Frita c/ Bacon e Cheddar":
                        total = total + 30.00;
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("Batata-Frita c/ Bacon e Cheddar adicionada com sucesso ao pedido! Algo mais? (S/N)");
                        break;
                    case "N":
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Pedido finalizado com sucesso! O total a pagar é: R$" + total + ".");
                        answer = "N";
                        break;
                    default:
                        Console.WriteLine("Este não é um produto cadastrado! Tente novamente com um nome válido.");
                        Console.WriteLine("--------------------------------------------------------");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
