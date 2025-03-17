using System.Security;
using TP3;

using static System.Runtime.InteropServices.JavaScript.JSType;


namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingresso show1 = new Ingresso("Mamonas Assassinas", 250.00, 1000);
            Matricula matriculaPaulo = new Matricula("Paulo Henrique de Paula Dias", "Engenharia de Software", 522037, "Ativa", "07/2023");
            Circulo circulo = new Circulo(3.0);
            Esfera esfera = new Esfera(5.0);

            while (true)
            {
                Console.WriteLine("***** Digite o número da opção desejada *****");
                Console.WriteLine("");
                Console.WriteLine("01 - Exercício 1");
                Console.WriteLine("02 - Exercício 2 ao 6 (Classe Ingresso)");
                Console.WriteLine("03 - Exercício 7 ao 9 (Classe Matrícula)");
                Console.WriteLine("04 - Exercício 10 ao 12 (Classe da Esfera e Circulo)");

                Console.WriteLine("00 - Sair");


                string exercise = Console.ReadLine();

                if (!(int.TryParse(exercise, out int cExercise)))
                {
                    Console.WriteLine("Númeração inválida!");
                    continue;
                }

                if (cExercise == 00)
                {
                    Console.WriteLine("Saindo ...");
                    break;
                }
                else if (cExercise == 1)
                {
                    Carro carro = new Carro(100, "Ford Fiesta", 5);

                    Console.WriteLine(carro.Descricao());
                    Console.WriteLine(" ");
                }
                else if (cExercise == 2)
                {
                    
                    Program_Ingressos ingressos = new Program_Ingressos();

                    ingressos.Ingressos(show1);
                    Console.WriteLine(" ");
                }
                else if (cExercise == 3)
                {
                    Program_Matricula programMatricula = new Program_Matricula();

                    programMatricula.Matricula(matriculaPaulo);
                    Console.WriteLine(" ");

                }
                else if (cExercise == 4)
                {
                    Program_Esfera_Circulo esferaCirculo = new Program_Esfera_Circulo();

                    esferaCirculo.Esfera_Circulo(circulo, esfera);
                    Console.WriteLine(" ");
                }

            }
        }
    }
}