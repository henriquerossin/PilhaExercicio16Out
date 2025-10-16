using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaExemplo
{
    internal class Roupa
    {
        public string Nome { get; set; }
        public string Tamanho { get; set; }

        public Roupa Proximo { get; set; }

        public Roupa()
        {
            this.Nome = Nome;
            this.Tamanho = Tamanho;
            this.Proximo = null;
        }
        public override string ToString()
        {
            return $"Roupa: {this.Nome}, Tamanho: {this.Tamanho}";
        }
    }
}
