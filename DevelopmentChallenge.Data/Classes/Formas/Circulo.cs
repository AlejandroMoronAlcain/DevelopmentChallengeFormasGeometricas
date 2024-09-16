
using System;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Circulo : FormaGeometricaBase
    {
        private readonly decimal _radio;

        public Circulo(decimal radio)
        {
            _radio = radio;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_radio / 2) * (_radio / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _radio;
        }

        public override string ObtenerNombre(int idioma, int cantidad)
        {
            var numero = cantidad == 1 ? "1" : "2";
            return Traductor.Traducir($"Circulo_{numero}", idioma);
        }
    }
}
