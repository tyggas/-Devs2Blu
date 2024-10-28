using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    internal class Produto
    {
        private string Nome { get; set;}
        private decimal Preco { get; set;}

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;

        }

        public void AlterarNome(string novoNome)
        {
            Nome = novoNome;
            Console.WriteLine($"Nome alterado para: {Nome}");
        }

        public void AlterarPreco(decimal novoPreco)
        {
            if(novoPreco >= 0)
            {
                Preco = novoPreco;
                Console.WriteLine($"Preco alterado para: {Preco}");
            }
            else
            {
                Console.WriteLine("O valor não pode ser menor que 0");
            }
        }
    }
}
