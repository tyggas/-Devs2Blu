using atividade;

class Program
{
    static void Main(string[] args)
    {
        int altura;
        int largura;

        
        Console.WriteLine("Digite a altura do retangulo");
        altura = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a largura do retangulo");
        largura = int.Parse(Console.ReadLine());
        Retangulo retangulo = new Retangulo(largura, altura);
        retangulo.Calculo();

        int lado1;
        int lado2;
        int lado3;

        Console.WriteLine("Digite o primero lado do triangulo");
        lado1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo lado do triangulo");
        lado2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o terceiro lado do triangulo");
        lado3 = int.Parse(Console.ReadLine());
        Triangulo triangulo = new Triangulo(lado1, lado2, lado3);
        triangulo.Calculo();
    }
}
