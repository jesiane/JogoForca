
namespace JogoForca
{
    internal class Program
    {
        static string letra;
        static int mIndex;
        static int tentativas = 0;
        static int lenght;

        static string[] palavras = {"ABACATE","ABACAXI", "ACEROLA", "AÇAI", "ARAÇA", "BACABA", "BACURI", "BANANA",
                 "CAJA", "CAJU", "CARAMBOLA", "CUPUAÇU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO","MAÇA", "MANGABA",
                 "MANGA", "MARACUJA", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA" };

        static void geraStringAleatoria()
        {
            Random rand = new Random();
            int mIndex = rand.Next(palavras.Length);
            Console.WriteLine(palavras[mIndex]);
            Console.WriteLine(palavras.Length);
            // entender isso aqui
            string word = palavras[mIndex];
            char[] letrasForca = word.ToCharArray();
            int lenght = word.Length;
            char[] letras = new char[word.Length];
        }

        static void Main(string[] args)
        {

            Console.WriteLine("--- --- --- --- ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\r Jogo da Forca ");
            Console.ResetColor();
            Console.WriteLine("--- --- --- --- ");

            geraStringAleatoria();

            Console.WriteLine("Escreva uma letra ");
            letra = Console.ReadLine();


            for (int i = 0; i < lenght; i++)
            {
                // if (letra == palavras[i])
                if (letra == "s")
                {
                    Console.WriteLine("certo");

                    break;
                }
                else if (tentativas < 7)
                {
                    switch (tentativas)
                    {
                        case 1:
                            Console.WriteLine("  _______  ");
                            Console.WriteLine(" |/      | ");
                            Console.WriteLine(" |         ");
                            Console.WriteLine(" |         ");
                            Console.WriteLine(" |         ");
                            Console.WriteLine(" |         ");
                            Console.WriteLine("_|___      ");
                            break;
                        case 2:
                            Console.WriteLine("  _______        ");
                            Console.WriteLine(" |/      |       ");
                            Console.WriteLine(" |      (_)      ");
                            Console.WriteLine(" |               ");
                            Console.WriteLine(" |               ");
                            Console.WriteLine(" |               ");
                            Console.WriteLine("_|___            ");
                            break;
                        case 3:
                            Console.WriteLine("  _______        ");
                            Console.WriteLine(" |/      |       ");
                            Console.WriteLine(" |      (_)      ");
                            Console.WriteLine(" |       |       ");
                            Console.WriteLine(" |       |       ");
                            Console.WriteLine(" |               ");
                            Console.WriteLine("_|___            ");
                            break;
                        case 4:
                            Console.WriteLine("  _______        ");
                            Console.WriteLine(" |/      |       ");
                            Console.WriteLine(" |      (_)      ");
                            Console.WriteLine(" |      /|\\     ");
                            Console.WriteLine(" |       |       ");
                            Console.WriteLine(" |               ");
                            Console.WriteLine("_|___            ");
                            break;
                        case 5:
                            Console.WriteLine("  _______        ");
                            Console.WriteLine(" |/      |       ");
                            Console.WriteLine(" |      (_)      ");
                            Console.WriteLine(" |      /|\\     ");
                            Console.WriteLine(" |       |       ");
                            Console.WriteLine(" |      / \\     ");
                            Console.WriteLine("_|___            ");
                            break;
                        case 6:
                            Console.WriteLine("  ______        ");
                            Console.WriteLine(" |/      |      ");
                            Console.WriteLine(" |    MORREU    ");
                            Console.WriteLine(" |              ");
                            Console.WriteLine(" |              ");
                            Console.WriteLine(" |              ");
                            Console.WriteLine("_|___           ");
                            break;

                    }
                    tentativas++;

                }
                else
                {
                    Console.WriteLine("Acabou as chances");
                }
            }
        }
    }
}