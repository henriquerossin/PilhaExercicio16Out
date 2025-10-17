using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PihaExercicio
{
    internal class EditorTexto
    {
        Pilha pilha { get; set; }

        public Pilha historico { get; set; }

        public Pilha Digitar(Pilha pilha, Pilha historico)
        {

            if (pilha.EstaCheia(pilha.count))
            {
                Console.WriteLine("Pilha cheia! Nao é possivel adicionar mais textos.");
                Console.WriteLine();
                return pilha;
            }
            else
            {
                Console.WriteLine("Digite o texto: ");
                string novoTexto = Console.ReadLine()!;

                pilha.Empilhar(new EditorTexto(novoTexto, pilha.head));
                historico.Empilhar(new EditorTexto(novoTexto, historico.head));
                return pilha;
            }
        }

        public Pilha Desfazer(Pilha pilha)
        {
            if (pilha.head != null)
            {
                Console.WriteLine("Texto apagado: " + pilha.head.texto);
                pilha.Desempilhar();
            }
            else
            {
                Console.WriteLine("Nada para apagar.");
            }
            return pilha;
        }

        public EditorTexto MostrarHistorico(Pilha pilha)
        {
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
            return pilha.head;
        }

        public EditorTexto()
        {
        }

        public EditorTexto(string texto, EditorTexto proximo)
        {
            this.texto = texto;
            Proximo = proximo;
        }

        public override string ToString()
        {
            return "Texto: " + this.texto;
        }

        public string texto { get; set; }

        public EditorTexto Proximo { get; set; }

    }
}
