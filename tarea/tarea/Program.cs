using System;

namespace tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] dato = new char[10];
            char buscar;

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("Ingrese una letra: ");
                dato[i] = char.Parse(Console.ReadLine());

            }
            Console.WriteLine("-------------------------------------------------------------");

            for (int x=0;x<9  ;x++)
            {
                Console.WriteLine(dato[x]);

            }
            Console.WriteLine("------------------------------------------------------------");

            Console.Write("Ingrese caracter a buscar: ");
            buscar = char.Parse(Console.ReadLine());

            for (int z=0; z<=9; z++)
            {
                if(dato[z]==buscar)
                {
                    Console.Write("dato " + buscar + " encontrado");
                }
            }

            Console.ReadKey();

        }

    }
}
