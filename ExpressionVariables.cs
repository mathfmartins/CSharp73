namespace CSharp73
{
    public static class ExpressionVariables { 
        public static void ValidarIdade() { 
           var idadeEmString = "27";
           if (int.TryParse(idadeEmString, out int idade) && idade > 18)
                System.Console.WriteLine("Muito bacana, agora você pode fazer várias paradinhas");
            else
                System.Console.WriteLine("Erro :[");
        }
    }

    public static class AplicacaoWeb { 
        public static string porta = "8080";

        public static bool estaRodandoEmPortaAlta = 
            int.TryParse(porta, out int portaComoInt) && portaComoInt > 1024;
    }
}