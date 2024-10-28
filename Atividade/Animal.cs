using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    public class Animal
    {
        public virtual void EmitirSom()
        {
        }
    }

    public class Cachorro : Animal
    {
      public override void EmitirSom()
        {
            Console.WriteLine("AU AU");
        }
    }

    public class Gato : Animal
    {
        public override void EmitirSom() {
            Console.WriteLine("MIAU MIAU");
        }
    }

}
    