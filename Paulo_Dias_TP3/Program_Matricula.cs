
using TP3;

namespace TP3
{
    class Program_Matricula
    {

        public void Matricula(Matricula matriculaPaulo)
        {
            while (true)
            {

                Console.WriteLine("***** Digite o número da opção desejada *****");
                Console.WriteLine("");
                Console.WriteLine("01 - Trancar a matrícula do estudante");
                Console.WriteLine("02 - Ativar ou reativar a matrícula do estudante");
                Console.WriteLine("03 - Exibir as informações atuais do estudante");


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
                    Console.WriteLine(" ");
                    matriculaPaulo.ExibirInformacoes();
                    Console.WriteLine("A matrícula do estudante " + matriculaPaulo.NomeDoAluno + " está sendo alterada.");
                    matriculaPaulo.Trancar();
                    matriculaPaulo.ExibirInformacoes();
                    Console.WriteLine(" ");

                }
                else if (cExercise == 2)
                {
                    Console.WriteLine(" ");
                    matriculaPaulo.ExibirInformacoes();
                    Console.WriteLine("A matrícula do estudante " + matriculaPaulo.NomeDoAluno + " está sendo alterada.");
                    matriculaPaulo.Reativar();
                    matriculaPaulo.ExibirInformacoes();
                    Console.WriteLine(" ");

                }
                else if (cExercise == 3)
                {
                    Console.WriteLine(" ");
                    matriculaPaulo.ExibirInformacoes();

                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }
            }
        
        }
    }
}
