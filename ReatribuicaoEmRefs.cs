using System;

namespace CSharp73 { 
    public static class ReatribuicaoEmRefs {
        public static void Teste() { 
            var numeros = new int[] { 1, 2, 3, 42, 256, 19, 12, 01 };
            ImprimirNumeros(numeros);
            
            ref var maiorValor = ref ObterMaiorValor(numeros);
            maiorValor *= 2;

            ImprimirNumeros(numeros);

        }

        public static void ImprimirNumeros(int[] numeros) => 
            Console.WriteLine(string.Join(", ", numeros));

        public static ref int ObterMaiorValor(int[] numeros) { 
            ref var maior = ref numeros[0];
            for (int i = 0; i < numeros.Length; i++) { 
                if (numeros[i] > maior)
                    maior = ref numeros[i]; //reatribuindo ref \o/
            }

            return ref maior;
        }
    }
}