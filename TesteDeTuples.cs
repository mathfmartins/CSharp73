using System;

namespace CSharp73
{
    public static class TesteDeTuples
    {
        public static void Teste() {
            var pessoa = new Pessoa(); 
            var tuple = TesteDeTuples.GetTuple();

            pessoa.Nome = tuple.nome;
            pessoa.Idade = tuple.idade;
            pessoa.Cpf = tuple.cpf;

            Console.WriteLine(pessoa);
        }

        private static (string nome, string cpf, int idade) GetTuple()
        {
            //Nome, Cpf, Idade
            var pessoa_1 = ("Lola Matheus", "181.943.645.12", 27);
            var pessoa_2 = ("Dante", "141.931.487.01", 39);

            bool mesmaPessoa = pessoa_1 == pessoa_2 ? true : false;

            if(mesmaPessoa) 
                return pessoa_1;

            return pessoa_2;            
        }
    }

    public class Pessoa { 
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }

        public override string ToString() { 
            return $"{Nome} | {Cpf} | {Idade}";
        }
    }
}
