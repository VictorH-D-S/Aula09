using System;
using System.Collections.Generic;
namespace Aula09ProdutosEstoqueSegQua
{
    class Program
    {
            static List<string> produtos = new List<string> { "pepsi", "fanta" };

        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Conrado's Gamer Store");
            while (true)
            {
                Console.WriteLine("Digite 1 para cadastrar ou 2 para listar");
                string resposta = Console.ReadLine();
                if (resposta == "1")
                {
                    Console.Write("Digite o nome do produto: ");
                    string produto = Console.ReadLine();
                    produto = produto.ToLower();
                    if (produtos.Contains(produto))
                    {

                        Console.WriteLine("Esse produto já está na lista...");
                        Console.ReadKey();
                        Console.Clear();
                        Main(args);
                        return;

                    }
                    else
                    {

                        produtos.Add(produto);
                        Console.WriteLine("Produto adicionado!");
                        Console.ReadKey();
                        Console.Clear();
                        Main(args);
                        return;

                    }
                }
                else
                {
                    string texto = "";
                    int contador = 0;
                    while (contador < produtos.Count)
                    {
                        string nome = produtos[contador];
                        string primeira_letra = nome.Substring(0, 1).ToUpper();
                        string resto = nome.Substring(1, nome.Length - 1);
                        string nome_tratado = primeira_letra + resto;
                        texto += nome_tratado + ", ";
                        contador++;
                    }
                    texto = texto.Substring(0, texto.Length - 2);
                    Console.WriteLine(texto);

                    Console.WriteLine("Todos os produtos cadastrados foram listados.");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    return;
                }

            }
        }
    }
}
