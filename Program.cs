using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad_10__08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cree un diccionario de empleados. Modifique el nombre de uno usando la sintaxis diccionario[id] = nuevoNombre.");
        Dictionary<int, string>empleado=new Dictionary<int, string>();
            int ID;
            string nombre;
            int opcion;
            do
            {
                Console.WriteLine("1. ingresar empleado");
                Console.WriteLine("2. modificar");
                Console.WriteLine("0. salir");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1:




                        Console.WriteLine($"Ingrese Id de empleado");
                        nombre = Console.ReadLine();
                        if (empleado.ContainsKey(nombre))
                        {
                            Console.WriteLine("nombre ya ingresado ingrese otro");


                        }
                        else
                        {
                            Console.WriteLine("ingrese notas:");
                            double.TryParse(Console.ReadLine(), out notas);
                            estudiantes.Add(nombre, notas);

                        }

                        break;
                    case 2:
                        Console.WriteLine("ingrese el nombre que desea ver notas");
                        nombre = Console.ReadLine();
                        Console.WriteLine("la nota de " + nombre + " es:" + estudiantes[nombre]);


                        break;
                    default:
                        Console.WriteLine("ingrese valor valido");
                        break;
                }

            }
            while (opcion != 0);
            Console.WriteLine("hasta luego");


        }
    }
}
