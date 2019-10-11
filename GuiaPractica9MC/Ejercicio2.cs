using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaPractica9MC
{
    class Ejercicio2
    {
        #region atributos
        private static bool isNumber;
        private static Dictionary<string, Alumno> _estudiantes;
        #endregion

        private struct Alumno
        {
            public string Carnet { get; set; }
            public string Nombre { get; set; }
            public string Carrera { get; set; }
            private double _cum;

            public double Cum
            {
                get { return _cum; }
                set
                {
                    if (value >= 0.0 && value <= 10.0)
                    {
                        _cum = value;
                        return;
                    }
                    _cum = 0.0; 
                }
            }

        }

        public Ejercicio2()
        {
            _estudiantes = new Dictionary<string, Alumno>
            {
                { "2019MM", new Alumno { Carnet = "2019MM", Nombre = "Martinez", Carrera = "Software", Cum = 5.0 } }
            };

            int opc = 0;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Escoja una opcion");
                    Console.WriteLine("1 - Agregar a lista");
                    Console.WriteLine("2 - Mostrar lista");
                    Console.WriteLine("3 - Eliminar de la lista");
                    Console.WriteLine("4 - Buscar en la lista");
                    Console.WriteLine("5 - Vaciar");
                    Console.WriteLine("0 - Salir");
                    isNumber = int.TryParse(Console.ReadLine(), out opc);
                } while (isNumber == false || opc < 0);
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Agregar();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        MostrarTodos();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Eliminar();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Buscar();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Vaciar();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (opc != 0);
        }

        private static void Agregar()
        {
            Console.WriteLine("Ingrese el carnet del alumno");
            string carnet = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del alumno");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la carrera del alumno");
            string carrera = Console.ReadLine();
            Console.WriteLine("Ingrese el CUM del alumno");
            double cum = double.Parse(Console.ReadLine());

            _estudiantes.Add( carnet, new Alumno { Carnet = carnet, Nombre = nombre, Carrera = carrera, Cum = cum } );

            Console.WriteLine("Alumno agregado");
        }

        private static void MostrarTodos()
        {
            foreach (var item in _estudiantes)
            {
                Console.WriteLine("[{0}]", item.Key);
                Console.WriteLine("Nombre: {0}", item.Value.Nombre);
                Console.WriteLine("Carrera: {0}", item.Value.Carrera);
                Console.WriteLine("Cum: {0}", item.Value.Cum);
            }
        }

        private static void Eliminar()
        {
            Console.WriteLine("Eliminar de la lista: Elija el carnet del estudiante que desea eliminar");
            foreach (var item in _estudiantes)
            {
                Console.WriteLine("[{0}]", item.Key);
                Console.WriteLine("Nombre: {0}", item.Value.Nombre);
                Console.WriteLine("Carrera: {0}", item.Value.Carrera);
                Console.WriteLine("Cum: {0}", item.Value.Cum);
            }
            string opc = Console.ReadLine();
            _estudiantes.Remove(opc);
            Console.WriteLine("Alumno eliminado");
        }

        private static void Buscar()
        {
            Console.WriteLine("Buscar: Ingrese el carnet del alumno que desea buscar");
            string carnet = Console.ReadLine();
            if (!_estudiantes.ContainsKey(carnet))
            {
                Console.WriteLine("Alumno no encontrado");
                return;
            }
            Alumno alumno = _estudiantes[carnet];
            Console.WriteLine("Carnet {0}", alumno.Carnet);
            Console.WriteLine("Nombre {0}", alumno.Nombre);
            Console.WriteLine("Carrera {0}", alumno.Carrera);
            Console.WriteLine("Cum {0}", alumno.Cum);
        }

        private static void Vaciar()
        {
            Console.WriteLine("Vaciar toda la lista:  desea vaciar la lista?");
            Console.WriteLine("[1] Si");
            Console.WriteLine("[0] No");
            int resp = int.Parse(Console.ReadLine());

            if (resp == 0) return;

            _estudiantes.Clear();

            Console.WriteLine("Lista vaciada");
        }
    }
}
