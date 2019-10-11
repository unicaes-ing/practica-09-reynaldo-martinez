using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaPractica9MC //Reynaldo
{
    public class Ejercicio1
    {
        #region atributos
        private static bool isNumber;
        private static List<string> _frutas;
        #endregion

        public Ejercicio1()
        {
            _frutas = new List<string> { "Manzana", "Pera", "Sandia" };
            int opc = 0;
            bool isNumber;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Escoja una opcion");
                    Console.WriteLine("1 - Agregar a lista");
                    Console.WriteLine("2 - Mostrar lista");
                    Console.WriteLine("3 - Insertar en la lista");
                    Console.WriteLine("4 - Eliminar de la lista");
                    Console.WriteLine("5 - Buscar en la lista");
                    Console.WriteLine("6 - Vaciar");
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
                        Insertar();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Eliminar();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Buscar();
                        Console.ReadKey();
                        break;
                    case 6:
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
            Console.WriteLine("Ingrese el nombre de la fruta");
            _frutas.Add(Console.ReadLine());
            Console.WriteLine("Fruta agregada");
        }

        private static void MostrarTodos()
        {
            for (int i = 0; i < _frutas.Count; i++)
            {
                Console.WriteLine("[{0}] {1}", i, _frutas[i]);
            }
        }

        private static void Insertar()
        {
            Console.WriteLine("Insertar en la lista: Elija el numero donde quiera que se ubique la nueva fruta");
            for (int i = 0; i < _frutas.Count; i++)
            {
                Console.WriteLine("[{0}] {1}", i, _frutas[i]);
            }
            int opc = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nuevo nombre de la fruta");
            _frutas.Insert(opc, Console.ReadLine());
            Console.WriteLine("Fruta insertada");
        }

        private static void Eliminar()
        {
            Console.WriteLine("Eliminar de la lista: Elija el numero de la fruta que desea eliminar");
            for (int i = 0; i < _frutas.Count; i++)
            {
                Console.WriteLine("[{0}] {1}", i, _frutas[i]);
            }
            int opc = int.Parse(Console.ReadLine());
            _frutas.RemoveAt(opc);
            Console.WriteLine("Fruta eliminada");
        }

        private static void Buscar()
        {
            Console.WriteLine("Buscar: Ingrese el nombre de la fruta que desea buscar");
            string fruta = Console.ReadLine();
            string frutaEncontrada = _frutas.Find(f => f.Equals(fruta));
            if (frutaEncontrada == null)
            {
                Console.WriteLine("Fruta no encontrada");
                return;
            }
            Console.WriteLine("Fruta encontrada con el id: {0}", _frutas.IndexOf(frutaEncontrada));
        }

        private static void Vaciar()
        {
            Console.WriteLine("Vaciar toda la lista: Seguro que desea vaciar la lista?");
            Console.WriteLine("[1] Si");
            Console.WriteLine("[0] No");
            int resp = int.Parse(Console.ReadLine());

            if (resp == 0) return;

            _frutas.Clear();

            Console.WriteLine("Lista vaciada");
        }
    }
}
