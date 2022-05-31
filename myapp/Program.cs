using System;

namespace ejercicio2
{
    class Program
    {
        static void Main ()
        {
            int operacion = 5;
            do
            {
                int resultado = 0;

                Console.Clear();
                Console.WriteLine("1. SUMA");
                Console.WriteLine("2. RESTA");
                Console.WriteLine("3. MULTIPLICACION");
                Console.WriteLine("4. DIVISION");
                Console.WriteLine("0. SALIR");
                Console.WriteLine("--");
                Console.Write("Ingrese la opcion: ");
                operacion = int.Parse(Console.ReadLine());

                if (operacion == 1 || operacion == 2 || operacion == 3 || operacion == 4)
                {
                    Console.Write("Ingrese el primer numero: ");
                    int numero1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo numero: ");
                    int numero2 = int.Parse(Console.ReadLine());

                    if (operacion == 1)
                    {
                        resultado = numero1 + numero2;

                    }
                    if (operacion == 2)
                    {
                        resultado = numero1 - numero2;

                    }
                    if (operacion == 3)
                    {
                        resultado = numero1 * numero2;

                    }
                    if (operacion == 4 && numero2 != 0)
                    {
                        resultado = numero1 / numero2;

                    }
                    Console.WriteLine("--");
                    Console.WriteLine("El resultado es: " + resultado);
                    Console.Write("Presione una tecla...");
                    Console.Read();

                }
            } while (operacion != 0) ;
        }
    }
}
