using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09ProdutosEstoques
{
    class Program
    {
        static List<string> produtos = new List<string>() { "pepsi", "fanta" };
        static void Main(string[] args)
        {


            Console.WriteLine("Bem vindo ao Conrado Gamer Store");
            Console.WriteLine("1- Cadastrar novo produto\n2- Listar produtos existentes");
            string option = Console.ReadLine();
            
            
            if (option == "1")
            {


                Console.Write("Insira o produto a ser cadastrado: ");
                string produto = Console.ReadLine();

                if (produtos.Contains(produto))
                {

                    Console.WriteLine("Produto já cadastrado...");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    return;

                }
                else
                {
                    produtos.Add(produto);
                    Console.WriteLine($"O item {produto} foi adicionado com sucesso!");
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

                texto = texto.Substring(0, 1);

                Console.WriteLine(texto);
                Console.ReadLine();
                Console.Clear();
                Main(args);
                return;

            }

        }
    }
}
