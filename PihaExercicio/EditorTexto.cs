using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PihaExercicio
{
    internal class EditorTexto
    {
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
