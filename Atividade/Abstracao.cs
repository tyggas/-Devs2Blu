using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    public abstract class Forma
    {
        public abstract void CalcularPerimetro();
    }

    public class Retangulo : Forma
    {
        private double altura = 0;
        private double largura = 0;

        public Retangulo(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        

        public override void CalcularPerimetro()
        {
            double perimetro = 2*(altura + largura);
            Console.WriteLine($"O perimetro do retangulo é: {perimetro}\n");
        }
    }

    public class Triangulo : Forma
    {

        private double lado1 = 0;
        private double lado2 = 0;
        private double lado3 = 0;
        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public override void CalcularPerimetro()
        {
            double perimetro = lado1 + lado2 + lado3;
            Console.WriteLine($"O perimetro do retangulo é: {perimetro}\n");

        }
    }
}
