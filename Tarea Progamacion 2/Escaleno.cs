using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Progamacion_2
{
    class Escaleno: Triangulo
    {
        private double _altura;
        private double _base;


        public Escaleno(double base_triangulo, double lado2, double lado3, string color) : base(color, base_triangulo, lado2, lado3)
        {
            _altura = (2 / base_triangulo) * Math.Sqrt(((base_triangulo + lado2 + lado3) / 2) *
                (((base_triangulo + lado2 + lado3) / 2) - base_triangulo) *
                (((base_triangulo + lado2 + lado3) / 2) - lado2) * (((base_triangulo + lado2 + lado3) / 2) - lado3));
            _base = base_triangulo;

        }

        public override double GetArea()
        {
            return (_base * _altura) / 2;
        }


        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy Triangulo Escaleno de Color {GetColor()}, Area {GetArea()} y Perimetro {GetPerimetro()}");
        }
    }
}
