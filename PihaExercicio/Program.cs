namespace PihaExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EditorTexto editor = new EditorTexto();
            Pilha pilha = new Pilha();
            Pilha historico = new Pilha();
            int opcao;

            do
            {
                Console.WriteLine("Informe a opção desejada: ");
                Console.WriteLine("1 - Digitar um novo texto: ");
                Console.WriteLine("2 - Desfazer a última ação: ");
                Console.WriteLine("3 - Mostrar pilha: ");
                Console.WriteLine("4 - Mostrar histórico: ");
                Console.WriteLine("5 - Sair.");
                opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 1:
                        editor.Digitar(pilha, historico);
                        break;
                    case 2:
                        editor.Desfazer(pilha);
                        break;
                    case 3:
                        editor.MostrarHistorico(pilha);
                        break;
                    case 4:
                        editor.MostrarHistorico(historico);
                        break;
                    case 5:
                        Console.WriteLine("Saindo...");
                        break;
                }
            } while (opcao != 5);
        }
    }
}
