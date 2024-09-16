using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Classes.Formas;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometricaBase>(), Traductor.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometricaBase>(), Traductor.Ingles));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometricaBase> { new Cuadrado(5) };

            var resumen = FormaGeometrica.Imprimir(cuadrados, Traductor.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometricaBase>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, Traductor.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometricaBase>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, Traductor.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 97.66 Area 91.65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometricaBase>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, Traductor.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13.01 | Perimetro 18.06 <br/>3 Triángulos | Area 49.64 | Perimetro 51.6 <br/>TOTAL:<br/>7 formas Perimetro 97.66 Area 91.65",
                resumen);
        }

        [Test]
        public void TestResumenListaConUnTrapecio()
        {
            var trapecios = new List<FormaGeometricaBase> { new Trapecio(6, 4, 3) };

            var resumen = FormaGeometrica.Imprimir(trapecios, Traductor.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 15 | Perimetro 16.32 <br/>TOTAL:<br/>1 formas Perimetro 16.32 Area 15", resumen);
        }

        [Test]
        public void TestResumenListaConUnCuadradoEnItaliano()
        {
            var cuadrados = new List<FormaGeometricaBase> { new Cuadrado(5) };

            var resumen = FormaGeometrica.Imprimir(cuadrados, Traductor.Italiano);

            Assert.AreEqual("<h1>Rapporto sulle forme</h1>1 Quadrato | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 forme Perimetro 20 Area 25", resumen);
        }

        [Test]
        public void TestResumenListaConVariosTiposEnItaliano()
        {
            var formas = new List<FormaGeometricaBase>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Trapecio(6, 4, 3)
            };

            var resumen = FormaGeometrica.Imprimir(formas, Traductor.Italiano);

            Assert.AreEqual(
                "<h1>Rapporto sulle forme</h1>1 Quadrato | Area 25 | Perimetro 20 <br/>1 Cerchio | Area 7.07 | Perimetro 9.42 <br/>1 Triangolo | Area 6.93 | Perimetro 12 <br/>1 Trapezio | Area 15 | Perimetro 16.32 <br/>TOTAL:<br/>4 forme Perimetro 57.75 Area 54",
                resumen);
        }
    }
}
