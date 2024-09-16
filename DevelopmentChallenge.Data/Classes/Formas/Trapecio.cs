using System;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Trapecio : FormaGeometricaBase
    {
        private readonly decimal _baseMayor;
        private readonly decimal _baseMenor;
        private readonly decimal _altura;

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
        }

        public override decimal CalcularArea()
        {
            return ((_baseMayor + _baseMenor) * _altura) / 2;
        }

        public override decimal CalcularPerimetro()
        {
            double lado = Math.Sqrt(Math.Pow((double)(_baseMayor - _baseMenor) / 2, 2) + Math.Pow((double)_altura, 2));
            return (decimal)lado * 2 + _baseMayor + _baseMenor;
        }

        public override string ObtenerNombre(int idioma, int cantidad)
        {
            var numero = cantidad == 1 ? "1" : "2";
            return Traductor.Traducir($"Trapecio_{numero}", idioma);
        }
    }
}
