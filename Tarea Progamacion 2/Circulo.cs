using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Progamacion_2
{
    class Circulo: Figura
    {
        private float _radio;

        public Circulo(float radio, string color) : base(color)
        {
            _radio = radio;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radio, 2);
        }
        public override double GetPerimetro()
        {
            return 2 * Math.PI * _radio;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Circulo de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }
    }
}
