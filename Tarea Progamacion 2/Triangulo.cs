using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Progamacion_2
{
    class Triangulo: Figura
    {
        private double _base;
        private double _lado2;
        private double _lado3;
        private double _altura;


        public Triangulo(string color, double base_triangulo, double lado2, double lado3) : base(color)
        {
            _base = base_triangulo;
            _lado2 = lado2;
            _lado3 = lado3;

        }


        public override double GetArea()
        {
            return (_base * _altura) / 2;
        }
        public override double GetPerimetro()
        {
            return _base + _lado2 + _lado3;
        }
    }
}
