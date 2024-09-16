using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Cuadrado : FormaGeometricaBase
    {
        private readonly decimal _lado;

        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }

        public override string ObtenerNombre(int idioma, int cantidad)
        {
            var numero = cantidad == 1 ? "1" : "2";
            return Traductor.Traducir($"Cuadrado_{numero}", idioma);
        }
    }


}
