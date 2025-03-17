using TP3;

namespace TP3
{
    public class Esfera
    {
        private double _raio;

        public Esfera(double Raio)
        {
            _raio = Raio;
        }

        public double Raio { get => _raio; set => _raio = value; }


        public double CalcularVolume()
        {
            return Math.Round((4.0 / 3.0) * Math.PI * (Math.Pow(Raio, 3)));
        }

    }
}
