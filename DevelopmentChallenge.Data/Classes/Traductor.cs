using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public static class Traductor
    {
        // Idiomas soportados
        public const int Castellano = 1;
        public const int Ingles = 2;
        public const int Italiano = 3; // Ejemplo de idioma adicional

        private static readonly Dictionary<string, Dictionary<int, string>> _traducciones = new Dictionary<string, Dictionary<int, string>>
            {
                // Mensajes generales
                { "ReporteTitulo", new Dictionary<int, string> {
                    { Castellano, "Reporte de Formas" },
                    { Ingles, "Shapes report" },
                    { Italiano, "Rapporto sulle forme" }
                }},
                { "ListaVacia", new Dictionary<int, string> {
                    { Castellano, "Lista vacía de formas!" },
                    { Ingles, "Empty list of shapes!" },
                    { Italiano, "Elenco vuoto di forme!" }
                }},
                { "TotalFormas", new Dictionary<int, string> {
                    { Castellano, "formas" },
                    { Ingles, "shapes" },
                    { Italiano, "forme" }
                }},
                { "Perimetro", new Dictionary<int, string> {
                    { Castellano, "Perimetro" },
                    { Ingles, "Perimeter" },
                    { Italiano, "Perimetro" }
                }},
                { "Area", new Dictionary<int, string> {
                    { Castellano, "Area" },
                    { Ingles, "Area" },
                    { Italiano, "Area" }
                }},

                // Nombres de formas
                { "Cuadrado_1", new Dictionary<int, string> {
                    { Castellano, "Cuadrado" },
                    { Ingles, "Square" },
                    { Italiano, "Quadrato" }
                }},
                { "Cuadrado_2", new Dictionary<int, string> {
                    { Castellano, "Cuadrados" },
                    { Ingles, "Squares" },
                    { Italiano, "Quadrati" }
                }},
                { "Circulo_1", new Dictionary<int, string> {
                    { Castellano, "Círculo" },
                    { Ingles, "Circle" },
                    { Italiano, "Cerchio" }
                }},
                { "Circulo_2", new Dictionary<int, string> {
                    { Castellano, "Círculos" },
                    { Ingles, "Circles" },
                    { Italiano, "Cerchi" }
                }},
                { "TrianguloEquilatero_1", new Dictionary<int, string> {
                    { Castellano, "Triángulo" },
                    { Ingles, "Triangle" },
                    { Italiano, "Triangolo" }
                }},
                { "TrianguloEquilatero_2", new Dictionary<int, string> {
                    { Castellano, "Triángulos" },
                    { Ingles, "Triangles" },
                    { Italiano, "Triangoli" }
                }},
                { "Trapecio_1", new Dictionary<int, string> {
                    { Castellano, "Trapecio" },
                    { Ingles, "Trapezoid" },
                    { Italiano, "Trapezio" }
                }},
                { "Trapecio_2", new Dictionary<int, string> {
                    { Castellano, "Trapecios" },
                    { Ingles, "Trapezoids" },
                    { Italiano, "Trapezi" }
                }},
            };

        // Método para obtener una traducción basada en la clave y el idioma
        public static string Traducir(string clave, int idioma)
        {
            if (_traducciones.ContainsKey(clave) && _traducciones[clave].ContainsKey(idioma))
            {
                return _traducciones[clave][idioma];
            }
            // Retorna el texto en inglés si no se encuentra el idioma especificado
            return _traducciones.ContainsKey(clave) ? _traducciones[clave][Ingles] : clave;
        }
    }
}

