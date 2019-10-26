using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace Area
{
    public class RepoArea
    {

        Rectangulo r = new Rectangulo();
        Cuadrado c = new Cuadrado();
        public void Bienvenido()
        {
            Console.WriteLine("---Bienvenido al programa---\nPresione cualquier tecla para acceder al menu.");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        public void Menu()
        {
            Console.WriteLine("---Menu---");
            Console.WriteLine("Ingrese uno de los siguientes valores segun su preferencia.\n1.- Calcular el area de un rectangulo\n2.-Calcular area de un cuadrado\n3.- Salir");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    r.CalcularArea();
                    Console.WriteLine("Presione cualquier tecla par regresa al menu");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case "2":
                    Console.Clear();
                    c.CalcularArea();
                    Console.WriteLine("Presione cualquier tecla par regresa al menu");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Seleccion invalida, presione cualquier tecla para regresar al menu");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
            }
        }
    }
}
