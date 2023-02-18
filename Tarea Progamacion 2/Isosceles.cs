using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Progamacion_2
{
    class Isosceles: Triangulo
    {
        private double _altura;
        private double _base;
        

        public Isosceles(double base_triangulo, double lado2, double lado3, string color): base(color, base_triangulo, lado2, lado3)
        {
            _altura = Math.Sqrt((Math.Pow((lado2), 2) - Math.Pow((base_triangulo / 2), 2)) );
            _base = base_triangulo;
        }

        public override double GetArea()
        {
            return (_base * _altura) / 2;
        }


        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy Triangulo Isoceles de Color {GetColor()}, Area {GetArea()} y Perimetro {GetPerimetro()}");
        }
    }
}
