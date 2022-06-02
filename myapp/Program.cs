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
                int bandera = 0;
                Console.Clear();
                Console.WriteLine("Ingrese la operacion que desea realizar:\n1. SUMA\n2. RESTA\n3. MULTIPLICACION\n4. DIVISION\n0. SALIR");
                operacion = Convert.ToInt32(Console.ReadLine());

                if (operacion == 1 || operacion == 2 || operacion == 3 || operacion == 4)
                {
                    Console.Write("Ingrese el primer numero: ");
                    int numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el segundo numero: ");
                    int numero2 = Convert.ToInt32(Console.ReadLine());
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
                    Console.WriteLine("\nDesea realizar otro calculo? (1.SI - 0.NO)");
                    bandera=Convert.ToInt32(Console.ReadLine());
                    if (bandera==0)
                    {
                        operacion=0;
                    }
                }
            } while (operacion != 0) ;
        }
    }
}
