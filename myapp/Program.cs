using System;

namespace ejercicio3
{
    class Program
    {
        static void Main ()
        {
            
            string texto1, texto2, texto3;
            char letra='e';
            
            Console.WriteLine("Ingrese una cadena de texto");

            texto1 = Console.ReadLine();
            Console.WriteLine(texto1.Substring(3));
            Console.WriteLine("La longitud del texto ingresado es: " + texto1.Length);
            Console.WriteLine("Ingrese otra cadena de texto");
            texto2 = Console.ReadLine();
            Console.WriteLine(texto1+texto2);
            Console.WriteLine(texto2.IndexOf(letra));
            foreach (var item in texto1)
            {
                Console.WriteLine(item);
            }
            texto1=texto1.ToUpper();
            Console.WriteLine(texto1);
            Console.WriteLine(texto1.ToLower());

            Console.WriteLine("Ingrese una nueva cadena de texto");
            texto3 = Console.ReadLine();
            Console.WriteLine(string.Compare(texto1,texto3));
            string[] vector=texto3.Split(',');
            foreach (var item in vector)
            {
                Console.WriteLine(item);
            }
            string operacion;
            Console.WriteLine("Ingrese ua operacion simple a resolver (Por ejemplo: 52+35)");
            operacion=Console.ReadLine();
            bool suma, resta, multiplicacion, division;
            string[] operacion1=operacion.Split('+','-','/','*');
            float resultado=0;
            suma=operacion.Contains('+');
            multiplicacion=operacion.Contains('*');
            division=operacion.Contains('/');
            resta=operacion.Contains('-');
            
            if (resta)
            {
                resultado=(float.Parse(operacion1[0]))-(float.Parse(operacion1[1]));
                Console.WriteLine($"El resultado de restar {operacion1[0]} - {operacion1[1]} es = {resultado}");
            }else if (suma)
            {
                resultado=float.Parse(operacion1[0])+float.Parse(operacion1[1]);
                Console.WriteLine($"El resultado de sumar {operacion1[0]} + {operacion1[1]} es = {resultado}");
            }else if (multiplicacion)
            {
                resultado=float.Parse(operacion1[0])*float.Parse(operacion1[1]);
                Console.WriteLine($"El resultado de multiplicar {operacion1[0]} * {operacion1[1]} es = {resultado}");
            } else if (division && float.Parse(operacion1[1])!=0)
            {
                resultado=float.Parse(operacion1[0])/float.Parse(operacion1[1]);
                Console.WriteLine($"El resultado de dividir {operacion1[0]} / {operacion1[1]} es = {resultado}");
            }
            
        }
    }
}