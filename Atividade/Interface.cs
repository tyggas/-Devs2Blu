using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    public interface IAutenticar
    {
        void Autenticar(string nome, string senha);

        void Deslogar();
    }

    public class UsuarioSistema : IAutenticar
    {
        private string nome;
        private string senha;
        public void Autenticar(string nome, string senha)
        {
            this.senha = senha;
            this.nome = nome;
            Console.WriteLine("Usuario Logado");
        }

        public void Deslogar()
        {
            Console.WriteLine("usuario deslogado");
            
        }
    }
}
