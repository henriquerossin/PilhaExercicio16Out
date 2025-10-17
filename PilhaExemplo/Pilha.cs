using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaExemplo
{
    internal class Pilha
    {
        public Roupa head { get; set; }

        public bool Vazia()
        {
            if (head == null)
                return true;
            else
                return false;
        }

        public void EmpilharRoupas(Roupa roupa)
        {
            if (Vazia())
            {
                head = roupa;
            }
            else
            {
                roupa.Proximo = head;
                head = roupa;
            }
        }

        public Roupa DesempilharRoupas()
        {
            if (Vazia())
            {
                return null;
            }
            else
            {
                Roupa aux = head;
                head = head.Proximo;
                return aux;
            }
        }

        public void ExibirRoupas()
        {
            if (head == null)
            {
                Console.WriteLine("Pilha vazia!");
            }
            else
            {
                Roupa aux = head;
                while (aux != null)
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                }
            }
        }
    }
}
