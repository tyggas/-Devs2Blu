using System;

namespace atividade
{
    // Classe base
    public class InstrumentoMusical
    {
        public virtual void Tocar()
        {
            Console.WriteLine("O instrumento está tocando");
        }
    }

    // Classe tambor
    public class Tambor : InstrumentoMusical
    {
        public override void Tocar()
        {
            Console.WriteLine("Tum!");
        }
    }

    // Classe guitarra
    public class Guitarra : InstrumentoMusical
    {
        public override void Tocar()
        {
            Console.WriteLine("Barulho de guitarra!");
        }
    }

    // Classe piano
    public class Piano : InstrumentoMusical
    {
        public override void Tocar()
        {
            Console.WriteLine("Plim!");
        }
    }
}