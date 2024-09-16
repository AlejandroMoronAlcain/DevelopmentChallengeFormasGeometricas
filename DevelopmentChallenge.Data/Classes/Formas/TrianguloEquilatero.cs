using System;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class TrianguloEquilatero : FormaGeometricaBase
    {
        private readonly decimal _lado;

        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
        }

        public override string ObtenerNombre(int idioma, int cantidad)
        {
            var numero = cantidad == 1 ? "1" : "2";
            return Traductor.Traducir($"TrianguloEquilatero_{numero}", idioma);
        }
    }
}
