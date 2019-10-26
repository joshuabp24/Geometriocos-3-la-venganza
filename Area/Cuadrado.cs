using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public class Cuadrado:Figura
    {
        public override double LadoA { get; set; }
        public override double LadoB { get; set; }
        public  double CalcularArea()
        {
            Cuadrado c = new Cuadrado();
            Console.WriteLine("Ingrese un lado del cuadrado");
            c.LadoA = Convert.ToDouble(Console.ReadLine());
            double Area = 0;
            Area = c.LadoA * c.LadoA;
            Console.WriteLine("El resultado es " + Area);
            return Area;
        }
    }
}
