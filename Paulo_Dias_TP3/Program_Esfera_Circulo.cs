
namespace TP3
{
    class Program_Esfera_Circulo
    {

        public void Esfera_Circulo(Circulo circulo, Esfera esfera)
        {


            while (true)
            {
                Console.WriteLine("***** Digite o número da opção desejada *****");
                Console.WriteLine("");
                Console.WriteLine("01 - Calcular a Área do Circulo");
                Console.WriteLine("02 - Calcular o Volume da Esfera");



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
                    Console.WriteLine($"Raio do Circulo: {circulo.Raio}");
                    Console.Write("Área do Círculo: ");
                    Console.WriteLine(circulo.CalcularArea());

                }
                else if (cExercise == 2)
                {
                    Console.WriteLine($"Raio da Esfera: {esfera.Raio}");
                    Console.Write("Volume da Esfera: ");
                    Console.WriteLine(esfera.CalcularVolume());
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }
            }
        }
    }
}
