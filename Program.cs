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
            bool validar=false;
            do
            {
                Console.WriteLine("1. ingresar empleado");
                Console.WriteLine("2. modificar");
                Console.WriteLine("3. ver empleados");
                Console.WriteLine("0. salir");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1:
                       Console.WriteLine($"Ingrese Id de empleado");
                        int.TryParse(Console.ReadLine(), out ID);
                        if (empleado.ContainsKey(ID))
                        {
                            Console.WriteLine("nombre ya ingresado ingrese otro");


                        }
                        else
                        {
                            Console.WriteLine("ingrese nombre:");
                           nombre= Console.ReadLine();
                            empleado.Add(ID, nombre);

                        }

                        break;
                    case 2:
                        Console.WriteLine("ingrese el ID que desea modificar");
                        int.TryParse (Console.ReadLine(), out ID);
                        if(empleado.ContainsKey(ID))
                        {
                            Console.WriteLine("ingrese nuevo nombre: ");
                            nombre= Console.ReadLine();
                            empleado[ID] = nombre;
                        }
                        else
                        {
                            Console.WriteLine("ID no encontrado");
                        }
                       
                        break;
                        case 3:
                        foreach (var item in empleado)
                        {
                            Console.WriteLine(" el ID: "+item.Key+ " empleado: "+item.Value);
                        }
                        break;
                    case 0:
                        validar= true;
                        break;
                    default:
                        Console.WriteLine("ingrese valor valido");
                        break;
                }

            }
            while (validar!= true);
            Console.WriteLine("hasta luego");


        }
    }
}
