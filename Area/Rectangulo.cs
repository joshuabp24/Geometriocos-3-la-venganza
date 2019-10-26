using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public class Rectangulo : Figura
    {
        public override double LadoA { get; set; }
        public override double LadoB { get; set; }
        public double CalcularArea()
        {
            Rectangulo r = new Rectangulo();
            double Area = 0;
            Console.WriteLine("Ingrese la altura");
            r.LadoA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la base");
            r.LadoB = Convert.ToDouble(Console.ReadLine());
            Area = r.LadoA * r.LadoB;
            Console.WriteLine("El resultado es " + Area);
            return Area;
        }
    }
}
