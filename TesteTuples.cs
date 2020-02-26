using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp73
{
    static class TesteTuples_1
    {
        public static (string nome, string cpf, int idade) TestarTuple()
        {
            //Nome, Cpf, Idade
            var pessoa_1 = ("Lola Matheus", "181.943.645.12", 27);
            var pessoa_2 = ("Dante", "141.931.487.01", 39);

            bool mesmaPessoa = pessoa_1 == pessoa_2 ? true : false;

            if (mesmaPessoa)
                Console.WriteLine("São a mesma pessoa");
            else
                Console.WriteLine("Não são a mesma pessoa");

            return pessoa_1;
        }
    }
}
