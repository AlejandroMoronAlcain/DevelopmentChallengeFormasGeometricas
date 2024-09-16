using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public abstract class FormaGeometricaBase
    {
        // Métodos abstractos para calcular área y perímetro
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();

        // Método abstracto para obtener el nombre de la forma en un idioma específico
        public abstract string ObtenerNombre(int idioma, int cantidad);
    }
}
