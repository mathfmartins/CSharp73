using System;
using System.Collections.Generic;

namespace CSharp73 { 
    public static class ReatribuicaoEmRefs {
        public static void Teste() { 
            var numeros = new int[] { 1, 2, 3, 42, 256, 19, 12, 01 };
            ImprimirNumeros(numeros);
            
            ref var maiorValor = ref ObterMaiorValor_1(numeros);
            maiorValor *= 2;
            ImprimirNumeros(numeros);

            maiorValor = ref ObterMaiorValor_2(numeros);
            maiorValor *= 4;
            ImprimirNumeros(numeros);

        }

        public static void ImprimirNumeros(int[] numeros) => 
            Console.WriteLine(string.Join(", ", numeros));

        public static ref int ObterMaiorValor_1(int[] numeros) { 
            ref var maior = ref numeros[0];
            for (int i = 1; i < numeros.Length; i++) { 
                if (numeros[i] > maior)
                    maior = ref numeros[i]; //reatribuindo ref \o/
            }

            return ref maior;
        }

        public static ref int ObterMaiorValor_2(int[] numeros) { 
            //Span<T> permite retornar um valor de referência para o item
            Span<int> spanDeNumeros = new Span<int>(numeros);

            ref var maior = ref numeros[0];
            foreach (ref var item in spanDeNumeros.Slice(0)) { 
                if (item > maior) 
                    maior = ref item;
            }
            return ref maior;
        }
    }
}