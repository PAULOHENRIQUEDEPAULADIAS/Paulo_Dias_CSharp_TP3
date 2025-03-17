using TP3;

namespace TP3
{
    public class Matricula
    {
        private string _nomeDoAluno;
        private string _curso;
        private int _numeroMatricula;
        private string _situacao;
        private string _dataInicial;

        public Matricula(string NomeDoAluno, string Curso, int NumeroDaMatricula, string Situacao, string DataInicial)
        {
            _nomeDoAluno = NomeDoAluno;
            _curso = Curso;
            _numeroMatricula = NumeroDaMatricula;
            _situacao = Situacao;
            _dataInicial = DataInicial;
        }

        public string NomeDoAluno { get => _nomeDoAluno; set => _nomeDoAluno = value; }
        public string Curso { get => _curso; set => _curso = value; }
        public int NumeroDaMatricula => _numeroMatricula; 
        public string Situacao { get => _situacao; set => _situacao = value; }
        public string DataInicial => _dataInicial;

        public void Trancar()
        {
            Situacao = "Trancada";

            Console.WriteLine("Matrícula trancada com sucesso");
            Console.WriteLine("");

        }

        public void Reativar()
        {
            Situacao = "Ativa";

            Console.WriteLine("Matrícula ativada com sucesso");
            Console.WriteLine("");

        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("");

            Console.WriteLine($"***** Detalhes da Matrícula *****" +
                              $"\nNome do estudante: {NomeDoAluno}" +
                              $"\nCurso: {Curso}" +
                              $"\nSituação Atual: {Situacao}" +
                              $"\nData de Matrícula: {DataInicial}");
            Console.WriteLine("");
        }
    }
}
