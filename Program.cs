using System;

namespace nomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome; 
            string sobrenome; 
            Console.Write("Digite seu nome: ");
             nome = Console.ReadLine(); 
            Console.Write("Digite o seu sobrenome: "); 
            sobrenome = Console.ReadLine(); 
            Console.WriteLine("\nNome Completo: "+nome + " " + sobrenome);
            Console.WriteLine("Nome de catálogo: "+sobrenome.ToUpper() + ", " + nome );

            
        }
    }
}
