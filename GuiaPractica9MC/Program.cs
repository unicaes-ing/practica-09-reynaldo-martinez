using System;

namespace GuiaPractica9MC
{
    class Program
    {
        #region atributos
        private static bool isNumber;
        #endregion

        static void Main(string[] args)
        {
            int opc = 0;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Escoja una opcion");
                    Console.WriteLine("1 - Ejercicio 1");
                    Console.WriteLine("2 - Ejercicio 2");
                    Console.WriteLine("0 - Salir");
                    isNumber = int.TryParse(Console.ReadLine(), out opc);
                } while (isNumber == false || opc < 0);
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Ejercicio1 ejercicio1 = new Ejercicio1();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Ejercicio2 ejercicio2 = new Ejercicio2();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (opc != 0);
        }
    }
}
