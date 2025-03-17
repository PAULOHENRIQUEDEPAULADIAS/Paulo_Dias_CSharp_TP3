namespace TP3
{
    public class Carro
    {
        private string _modelo;
        private double _capacidadeDoTanque;
        private int _capacidadeDePassageiros;

        public Carro(double capacidadeDoTanque, string modelo, int capacidadeDePassageiros)
        {
            this._modelo = modelo;
            this._capacidadeDoTanque = capacidadeDoTanque;
            this._capacidadeDePassageiros = capacidadeDePassageiros;
        }

        public string Descricao()
        {

            string result = $"***** Descrições do Veículo *****\n" +
                            $"Modelo: {this._modelo}\n" +
                            $"Capacidade Do Tanque: {this._capacidadeDoTanque}\n" +
                            $"Capacidade de Passageiros: {this._capacidadeDePassageiros}";

            return result;
        }
    }
}
