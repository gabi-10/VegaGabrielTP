using System;

namespace Punto_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("-----------------Ejercicio 4--------------------");
            Console.WriteLine("                        ");

            char continuar = 'x';
            bool flag = true;
            int cantidadRojos = 0;
            int cantidadVerdes = 0;
            int cantidadAmarillos = 0;
            float RojosCincoMil = 0;
            float vehiculosMenorPrecio = 0;
            float cantidadDeVehiculos = 0;
            float VehiculoMasCaro = float.MinValue;
            float promedio = 0;
            float valorTotal = 0;
            string automascaro = "nn";


            while (continuar != 'n')
            {
                do
                {
                    Console.WriteLine("Ingrese color de Vehiculo");
                    string color = Console.ReadLine();
                    Console.WriteLine("Ingrese el valor de cuanto desea pagar");
                    int valor = int.Parse(Console.ReadLine());

                    if (color == "rojo" || color == "verde" || color == "amarillo" && valor >= 0 && valor < 10000)
                    {
                        flag = false;
                        if (color == "rojo")
                        {
                            if (valor > 5000)
                            {
                                RojosCincoMil++;
                            }
                            cantidadRojos++;
                        }
                        if (color == "verde")
                        {
                            cantidadVerdes++;
                        }
                        if (color == "amarillo")
                        {
                            cantidadAmarillos++;
                        }
                        if (valor < 5000)
                        {
                            vehiculosMenorPrecio++;
                        }
                        if (valor > VehiculoMasCaro)
                        {
                            VehiculoMasCaro = valor;
                            automascaro = color;
                        }
                        cantidadDeVehiculos++;

                        valorTotal = valorTotal + valor;

                        promedio = valorTotal / cantidadDeVehiculos;





                        Console.WriteLine("{0} Si usted desea deternse presione 'n', para continuar otra letra", Environment.NewLine);
                        continuar = char.Parse(Console.ReadLine());

                    }

                } while (flag);

            }

            Console.WriteLine("*************************************");
            Console.WriteLine($"Los datos Ingresados son los siguientes, ingreso {cantidadDeVehiculos} Autos");
            Console.WriteLine("*************************************");
            Console.WriteLine("                                     ");
            Console.WriteLine("La Cantidad total de autos rojos es de " + cantidadRojos);
            Console.WriteLine("                                     ");
            Console.WriteLine($"Y hay {RojosCincoMil} Autos rojos superiores a 5000 $");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("La Cantidad total de autos verdes es de " + cantidadVerdes);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("La Cantidad de total autos amarillos es de " + cantidadAmarillos);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"La Cantidad de Vehiculos menor a 5000 $ es de {vehiculosMenorPrecio}");
            Console.WriteLine("El promedio de todos los vehiculos ingresados es " + promedio);
            Console.WriteLine("Eñ Vehiculo mas caro cuesta " + VehiculoMasCaro + " Y es de color " + automascaro);
        }
    }
}
