using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Progamacion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo equilatero = new Equilatero(2, 2, 2, "Azul");            
            Triangulo isosceles = new Isosceles(3, 5, 5, "Verde");
            Triangulo escaleno = new Escaleno(4, 5, 6, "Rojo");
            Circulo circulo = new Circulo(3, "Amarillo");
            Rectangulo rectangulo = new Rectangulo(8, 6, "Blanco");
            Cuadrado cuadrado = new Cuadrado(6, "Morado");
            
            equilatero.MostrarDatos();
            
            isosceles.MostrarDatos();

            escaleno.MostrarDatos();

            circulo.MostrarDatos();

            rectangulo.MostrarDatos();

            cuadrado.MostrarDatos();
            
            Console.ReadKey();
        }
    }
}
