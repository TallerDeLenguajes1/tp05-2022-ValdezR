using System;

namespace ejercicio3
{
    class Program
    {
        static void Main ()
        {
            float numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;

            Console.Clear();
            Console.Write("Ingrese un numero: ");
            numero1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"El numero ingresado es: {numero1}");
            Console.WriteLine($"Su valor Absoluto es: " + Math.Abs(numero1));
            Console.WriteLine($"El cuadrado del numero es: " + Math.Pow(numero1, 2));
            Console.WriteLine($"Su raiz cuadrada es: " + Math.Sqrt(numero1));
            Console.WriteLine($"El seno es: " + Math.Sin(numero1));
            Console.WriteLine($"El coseno es: " + Math.Cos(numero1));
            Console.WriteLine($"La parte entera del numero es: " + Math.Truncate(numero1));

            Console.WriteLine("\n\n--Ingrese 2 numeros--\n\n");
            Console.Write("Ingrese el primero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo: ");
            numero3 = Convert.ToInt32(Console.ReadLine());
            if (numero2>numero3)
            {
                Console.WriteLine($"el numero {numero2} es el maximo ingresado");
                Console.WriteLine($"el numero {numero3} es el menor ingresado");
            }else
            {
                if (numero3>numero2)
                {
                    Console.WriteLine($"el numero {numero3} es el maximo ingresado");
                    Console.WriteLine($"el numero {numero2} es el menor ingresado");
                }else
                {
                    Console.WriteLine("Los numeros ingresados son iguales");
                }
            }
        }
    }
}
