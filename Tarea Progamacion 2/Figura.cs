using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Progamacion_2
{
    public abstract class Figura
    {
        public abstract double GetArea();
        public abstract double GetPerimetro();

        private string _color;

        public Figura(string color)
        {
            _color = color;
        }


        public string GetColor()
        {
            return _color;
        }

        public virtual void MostrarDatos()
        {
            Console.WriteLine($" Soy una Figura de Color {_color}");
        }
    }
}
