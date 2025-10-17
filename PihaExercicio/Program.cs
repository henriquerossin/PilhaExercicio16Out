namespace PihaExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();
            string[] vetor = new string[10];
            int opcao;

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
                        if (pilha.EstaCheia())
                        {
                            Console.WriteLine("Historico cheio! Nao é possivel adicionar mais textos.");
                            Console.WriteLine();
                            break;
                        }
                        EditorTexto texto = new EditorTexto();
                        Console.WriteLine("Digite o texto: ");
                        string novoTexto = Console.ReadLine()!;
                        pilha.Empilhar(new EditorTexto(novoTexto, pilha.head));
                        for (int i = 0; i < vetor.Length; i++)
                        {
                            if (vetor[i] == null)
                            {
                                vetor[i] = novoTexto;
                                break;
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        if (pilha.head != null)
                        {
                            Console.WriteLine("Texto apagado: " + pilha.head.texto);
                            pilha.Desempilhar();
                            for (int i = vetor.Length - 1; i >= 0; i--)
                            {
                                if (vetor[i] != null)
                                {
                                    vetor[i] = null;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nada para apagar.");
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        if (pilha.EstaVazia())
                        {
                            Console.WriteLine("Historico vazio!");
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
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Saindo...");
                        Console.WriteLine();
                        break;
                }
            } while (opcao != 4);
        }
    }
}
