using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PihaExercicio
{
    internal class Pilha
    {
        public EditorTexto head { get; set; }

        public Pilha()
        {
        }

        public string[] vetor = new string[10];

        public void Empilhar(EditorTexto texto)
        {
            if (EstaVazia())
            {
                head = texto;
            }
            else
            {
                texto.Proximo = head;
                head = texto;
            }
        }

        public EditorTexto Desempilhar()
        {
            if (EstaVazia())
            {
                return null;
            }
            else
            {
                EditorTexto aux = head;
                head = head.Proximo;
                return aux;
            }
        }

        public EditorTexto Topo()
        {
            return head;
        }

        public bool EstaVazia()
        {
            if (head == null)
                return true;
            else
                return false;
        }

        public bool EstaCheia()
        {
            if (vetor[9] != null)
                return true;
            else
                return false;
        }

        public void ExibirPilha()
        {
            if (head == null)
            {
                Console.WriteLine("Pilha vazia!");
            }
            else
            {
                EditorTexto aux = head;
                while (aux != null)
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                }
            }
        }
    }
}
