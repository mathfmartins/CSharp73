using System;

namespace CSharp73
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuple = TesteTuples_1.TestarTuple();
            var pessoa = new Pessoa(); 

            pessoa.Nome = tuple.nome;
            pessoa.Idade = tuple.idade;
            pessoa.Cpf = tuple.cpf;

            Console.WriteLine(pessoa);
        }

        public class Pessoa
        {
            public string Nome { get; set; }
            public string Cpf { get; set; }
            public int Idade { get; set; }

            public override string ToString()
            {
                return $"{Nome} | {Idade} | {Cpf}";
            }
        }
    }
}
