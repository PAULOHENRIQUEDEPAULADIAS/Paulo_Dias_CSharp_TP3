
namespace TP3
{
    class Program_Ingressos
    {

        public void Ingressos(Ingresso show1)
        {
            

            while (true)
            {
                Console.WriteLine("***** Digite o número da opção desejada *****");
                Console.WriteLine("");
                Console.WriteLine("01 - Altera valor do ingresso");
                Console.WriteLine("02 - Alterar quantidade de ingressos disponíveis");
                Console.WriteLine("03 - Exibir informações dos ingressos");
                Console.WriteLine("04 - Alterando usando Get e Set");


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

                    try
                    {
                        Console.WriteLine("Digite o novo valor do ingresso: R$ ");
                        string novoPreco = Console.ReadLine();

                        if(!Double.TryParse(novoPreco, out double cNovoPreco))
                        {
                            Console.WriteLine("Valor incorreto");
                        }

                        show1.AlterarPreco(cNovoPreco);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor inválido (Formato XX.XX)");
                    }

                }

                else if (cExercise == 2)
                {
                    try
                    {
                        Console.WriteLine("Digite a nova quantidade de ingressos: ");
                        string novaQuantidade = Console.ReadLine();

                        if (!int.TryParse(novaQuantidade, out int cNovaQuantidade))
                        {
                            Console.WriteLine("Valor incorreto");
                        }

                        show1.AlterarQuantidade(cNovaQuantidade);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Quantidade inválida (Formato XXX)");
                    }
                }

                else if (cExercise == 3)
                {
                    String result = show1.ExibirInformacoes();

                    Console.WriteLine(result);
                }
                else if (cExercise == 4)
                {
                    show1.AlterarndoComGetESet();
                }



                else
                        {
                    Console.WriteLine("Númeração inválida!");
                }
            }
        }
    }
}
