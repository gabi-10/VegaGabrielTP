using System;

namespace Punto_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //PUNTO 1 
            //1.Pedir dos números por consola y mostrar el resultado:
            //a.Si son iguales muestro el cuadrado del número.
            //b.Si el primero es divisible por el segundo, los resto, de lo contrario muestro
            //solo el resto.
            //c.si el resto es mayor a 3(tres) informar por consola.
            Console.WriteLine("Ingrese dos numeros");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                int AlCuadrado = num1 * 2;
                Console.WriteLine("Al ser el primer y segundo numero iguales lo elevo al cuadrado: " + AlCuadrado);
            }
            if (num1 % num2 == 0)
            {
                Console.WriteLine($"{num1} es divisor de {num2}");
                int resultado = num1 - num2;
                Console.WriteLine("El resultado de la resta es: " + resultado);

            }
            else
            {
                Console.WriteLine("El Resto es: " + num1 % num2);
            }
            if (num1 % num2 > 3)
            {
                Console.WriteLine("El resto es mayor a 3");
            }
        }
    }
}
