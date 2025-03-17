using TP3;

namespace TP3
{
    public class Circulo
    {
        private double _raio;

        public Circulo(double Raio)
        {
            _raio = Raio;
        }

        public double Raio { get => _raio; set => _raio = value; }

        public double CalcularArea()
        {

            double calculo = Math.PI * (Math.Pow(Raio, 2));
            return Math.Round(calculo, 4);
        }
    }
}


