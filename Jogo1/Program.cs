
namespace Emprestimos.Models
{
    class Program
    {

        static void Main(string[] args)
        {


            int totalDeAcertos = 0;

            Console.WriteLine("Digite seu nome:");

            string nome = Console.ReadLine();


            Console.WriteLine(nome + " Responda as perguntas abaixo");

            Console.WriteLine("Qual a capital da Argentina?");

            Console.WriteLine("Montevidel, Lima, La Paz, Boenos Aires");


            string resposta1 = Console.ReadLine().ToLower();

            if (resposta1 == "boenos aires")
            {

                Console.WriteLine("Parabés, você acertou!");
                totalDeAcertos++;

            }

            else
            {

                Console.WriteLine("Você errou!");
            }

            Console.WriteLine("Qual a formula da Água");

            Console.WriteLine("H2O, 2HO, HO², OH2");

            string resposta2 = Console.ReadLine().ToLower();

            if (resposta2 == "h2o")
            {
                Console.WriteLine("Parabéns você acertou!");
                totalDeAcertos++;
            }

            else
            {

                Console.WriteLine("Você errou!");

            }

            Console.WriteLine("Qual o ano do descobrimento do Brasil");

            Console.WriteLine("1500, 1600, 1800, 1700");

            string resposta3 = Console.ReadLine().ToLower();

            if (resposta3 == "1500")
            {
                Console.WriteLine("Parabéns, você acertou!");
                totalDeAcertos++;
            }

            else
            {
                Console.WriteLine("Você errou!");
            }

            Console.WriteLine("Quato é 1500 - 1300");

            Console.WriteLine("500, 300, 200, 100");

            string resposta4 = Console.ReadLine().ToLower();

            if (resposta4 == "200")
            {
                Console.WriteLine("Parabéns, você acertou!");
                totalDeAcertos++;
            }

            else
            {
                Console.WriteLine("Você errou!");
            }

            Console.WriteLine("Qual o último campeão da copa do mundo de futebol?");

            Console.WriteLine("Brasil, Argentina, França, Espanha");

            string resposta5 = Console.ReadLine().ToLower();

            if (resposta5 == "argentina")
            {
                Console.WriteLine("Parabéns, você acertou!");
                totalDeAcertos++;
            }

            else
            {
                Console.WriteLine("Você errou!");
            }

            Console.WriteLine($"{nome} Você acertou {totalDeAcertos} respostas no total de 5.");
        }

    }

}