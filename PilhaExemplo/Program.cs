using System.Text.RegularExpressions;

namespace PilhaExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();
            int opcao;

            do
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Empilhar roupa");
                Console.WriteLine("2 - Desempilhar roupa");
                Console.WriteLine("3 - Exibir roupas");
                Console.WriteLine("4 - Sair");
                opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 1:
                        Roupa roupa = new Roupa();
                        Console.WriteLine("Digite o nome da roupa: ");
                        roupa.Nome = Console.ReadLine()!;
                        Console.WriteLine("Digite o tamanho da roupa: ");
                        roupa.Tamanho = Console.ReadLine()!;
                        pilha.EmpilharRoupas(roupa);
                        Console.WriteLine();
                        break;
                    case 2:
                        pilha.DesempilharRoupas();
                        Console.WriteLine();
                        break;
                    case 3:
                        pilha.ExibirRoupas();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Saindo...");
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        Console.WriteLine();
                        break;
                }

            } while (opcao != 4);
        }
    }
}
