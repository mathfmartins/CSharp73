using System;

namespace CSharp73
{
    static class TesteDeTuples
    {
        public static (string nome, string cpf, int idade) Teste1()
        {
            //Nome, Cpf, Idade
            var pessoa_1 = ("Lola Matheus", "181.943.645.12", 27);
            var pessoa_2 = ("Dante", "141.931.487.01", 39);

            bool mesmaPessoa = pessoa_1 == pessoa_2 ? true : false;

            Console.WriteLine(mesmaPessoa);

            return pessoa_1;
        }

    }
}
