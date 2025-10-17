namespace PihaExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();
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
                        EditorTexto texto = new EditorTexto();

                }

            } while (opcao != 4);
        }
    }
}
