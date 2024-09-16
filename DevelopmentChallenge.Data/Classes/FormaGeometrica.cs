/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using DevelopmentChallenge.Data.Classes.Formas;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
    {
        public class FormaGeometrica
        {
            public static string Imprimir(List<FormaGeometricaBase> formas, int idioma)
            {
                var sb = new StringBuilder();

                if (!formas.Any())
                {
                    sb.Append($"<h1>{Traductor.Traducir("ListaVacia", idioma)}</h1>");
                }
                else
                {
                    // Header
                    sb.Append($"<h1>{Traductor.Traducir("ReporteTitulo", idioma)}</h1>");

                    // Agrupar por tipo de forma y calcular áreas y perímetros
                    var grupos = formas.GroupBy(f => f.GetType());

                    foreach (var grupo in grupos)
                    {
                        var cantidad = grupo.Count();
                        var areaTotal = grupo.Sum(f => f.CalcularArea());
                        var perimetroTotal = grupo.Sum(f => f.CalcularPerimetro());
                        sb.Append(ObtenerLinea(cantidad, areaTotal, perimetroTotal, grupo.First(), idioma));
                    }

                    // Footer
                    sb.Append(ObtenerPieDePagina(formas, idioma));
                }

                return sb.ToString();
            }

            private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, FormaGeometricaBase forma, int idioma)
            {
                if (cantidad > 0)
                {
                    var nombreForma = forma.ObtenerNombre(idioma, cantidad);
                    var perimetroTexto = Traductor.Traducir("Perimetro", idioma);
                    var areaTexto = Traductor.Traducir("Area", idioma);
                    return $"{cantidad} {nombreForma} | {areaTexto} {area:#.##} | {perimetroTexto} {perimetro:#.##} <br/>";
                }
                return string.Empty;
            }

            private static string ObtenerPieDePagina(List<FormaGeometricaBase> formas, int idioma)
            {
                var totalFormas = formas.Count;
                var totalPerimetro = formas.Sum(f => f.CalcularPerimetro());
                var totalArea = formas.Sum(f => f.CalcularArea());
                var formasTexto = Traductor.Traducir("TotalFormas", idioma);
                var perimetroTexto = Traductor.Traducir("Perimetro", idioma);

                return $"TOTAL:<br/>{totalFormas} {formasTexto} {perimetroTexto} {totalPerimetro:#.##} Area {totalArea:#.##}";
            }
        }
    }


