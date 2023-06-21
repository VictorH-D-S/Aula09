using System;
using System.Collections.Generic;
namespace Aula09ProdutosEstoqueSegQua
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> produtos = new List<string> { "pepsi", "fanta" };
            Console.WriteLine("Bem-vindo ao Conradito Store");
            while (true)
            {
                Console.WriteLine("Digite 1 para cadastrar ou 2 para listar");
                string resposta = Console.ReadLine();
                if (resposta == "1")
                {
                    Console.WriteLine("Digite o nome do produto");
                    string produto = Console.ReadLine();
                    produto = produto.ToLower();
                    if (produtos.Contains(produto))
                    {
                        Console.WriteLine("Esse produto já está na lista...");
                    }
                    else
                    {
                        produtos.Add(produto);
                        Console.WriteLine("Produto adicionado!");
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
                }

            }
        }
    }
}
