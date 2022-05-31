using System;

Console.WriteLine("Ingrese un numero: ");
string numero=Console.ReadLine();
char [] array = numero.ToCharArray();

Console.WriteLine("El numero ingresado es: " + numero);
Console.Write("El numero invertido es: ");

for (int i = 1; i <= array.Length; i++)
{
    Console.Write(array[array.Length-i]);
}