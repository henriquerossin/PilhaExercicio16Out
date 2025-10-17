namespace PihaExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();
            int opcao, count = 0;

            do
            {
                Console.WriteLine("Informe a opção desejada: ");
                Console.WriteLine("1 - Digitar um novo texto: ");
                Console.WriteLine("2 - Desfazer a última ação: ");
                Console.WriteLine("3 - Mostrar histórico: ");
                Console.WriteLine("4 - Sair.");
                opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 1:
                        if (pilha.EstaCheia(count))
                        {
                            Console.WriteLine("Pilha cheia! Nao é possivel adicionar mais textos.");
                            Console.WriteLine();
                            break;
                        }
                        EditorTexto texto = new EditorTexto();
                        Console.WriteLine("Digite o texto: ");
                        string novoTexto = Console.ReadLine()!;
                        pilha.Empilhar(new EditorTexto(novoTexto, pilha.head));
                        count++;
                        break;
                    case 2:
                        if (pilha.head != null)
                        {
                            Console.WriteLine("Texto apagado: " + pilha.head.texto);
                            pilha.Desempilhar();
                            count--;
                        }
                        else
                        {
                            Console.WriteLine("Nada para apagar.\n");
                        }
                        break;
                    case 3:
                        if (pilha.EstaVazia())
                        {
                            Console.WriteLine("Historico vazio!\n");
                        }
                        else
                        {
                            EditorTexto aux = pilha.head;
                            while (aux != null)
                            {
                                Console.WriteLine(aux.ToString());
                                aux = aux.Proximo;
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Saindo...");
                        break;
                }
            } while (opcao != 4);
        }
    }
}
