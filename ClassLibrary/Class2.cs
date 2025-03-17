namespace TP3
{
    public class Ingresso
    {
        private string _nomeDoShow;
        private double _preco;
        private int _quantidadeDisponivel;

        public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
        {
            _nomeDoShow = nomeDoShow;
            _preco = preco;
            _quantidadeDisponivel = quantidadeDisponivel;
        }

        public string GetNomeDoShow()
        {
            return _nomeDoShow;
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidadeDisponivel()
        {
            return _quantidadeDisponivel;
        }

        public void SetNomeDoShow(string novoNome)
        {
            _nomeDoShow = novoNome;
        }

        public void SetPreco(double novoPreco)
        {
            _preco = novoPreco;
        }

        public void SetQuantidadeDisponivel(int novaQuantidade)
        {
            _quantidadeDisponivel = novaQuantidade;
        }

        public void AlterarPreco(double novoPreco)
        {
            if (novoPreco <= 0)
            {
                Console.WriteLine("Novo preço precisa ser positivo!");
                return;
            }

            Console.WriteLine($"Preço atual do ingresso: R$ {_preco}");
            Console.WriteLine("");
            _preco = novoPreco;
            Console.WriteLine($"Preço ajustado do ingresso: R$ {_preco}");
        }

        public void AlterarQuantidade(int novaQuantidade)
        {
            if (novaQuantidade < 0)
            {
                Console.WriteLine("A quantidade não pode ser negativa!");
                return;
            }

            Console.WriteLine($"Quantidade atual de ingressos: {_quantidadeDisponivel}");
            Console.WriteLine("");
            _quantidadeDisponivel = novaQuantidade;
            Console.WriteLine($"Quantidade ajustada de ingressos: {_quantidadeDisponivel}");
        }

        public string ExibirInformacoes()
        {
            String result = $"***** Descrições do Show *****\n" +
                   $"Nome do Show: {_nomeDoShow}\n" +
                   $"Valor do ingresso: R$ {_preco}\n" +
                   $"Quantidade de ingressos disponíveis: {_quantidadeDisponivel}";

            return result;
        }

        public void AlterarndoComGetESet()
        {
            Console.WriteLine($"***** Descrições do Show *****\n" +
                              $"Nome do Show: {this.GetNomeDoShow()}\n" +
                              $"Valor do ingresso: R$ {this.GetPreco()}\n" +
                              $"Quantidade de ingressos disponíveis: {this.GetQuantidadeDisponivel()}");

            Console.WriteLine(" ");

            Console.WriteLine("Se deseja alterar o nome do show, digite abaixo, caso contrario, pressione Enter");
            string nome = Console.ReadLine();
            Console.WriteLine(" ");

            if (!string.IsNullOrEmpty(nome))
            {
                this._nomeDoShow = nome;
            }


            Console.WriteLine("Se deseja alterar o valor do show, digite abaixo (Formato XX.XX), caso contrario, deixe em branco");
            string valor = Console.ReadLine();
            Console.WriteLine(" ");

            if (!string.IsNullOrEmpty(valor))
            {
                if (Double.TryParse(valor, out double cValue))
                {
                    this.SetPreco(cValue);
                }
                else
                {
                    Console.WriteLine("Valor invalido");
                }
            }


            Console.WriteLine("Se desejar alterar a quantidade de ingressos disponiveis, digite abaixo, caso contrario deixe em branco");
            string quantidade = Console.ReadLine();
            Console.WriteLine(" ");

            if (!string.IsNullOrEmpty(quantidade))
            {
                if (int.TryParse(quantidade, out int cQuantidade))
                {
                    this.SetQuantidadeDisponivel(cQuantidade);
                }
                else
                {
                    Console.WriteLine("Valor invalido");
                }
            }

            Console.WriteLine($"***** Descrições do Show Atualizada *****\n" +
                              $"Nome do Show: {this.GetNomeDoShow()}\n" +
                              $"Valor do ingresso: R$ {this.GetPreco()}\n" +
                              $"Quantidade de ingressos disponíveis: {this.GetQuantidadeDisponivel()}");
        }
    }
}
