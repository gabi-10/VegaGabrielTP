using System;

namespace Punto_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Ejercicio 3------------");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("                        ");

            char continuar = 'x';
            bool flag = true;
            float cantidadSaborCarne = 0;
            float cantidadSaborVegetal = 0;
            float cantidadSaborPollo = 0;
            float cantidadTotal = 0;
            float kilostotales = 0;
            float promedio = 0;
            float promedioCarne = 0;
            float SumapromedioCarne = 0;
            float BolsaMasLiviana = float.MaxValue;
            string BolsaMasLiviana2 = "nn";

            while (continuar != 'n')
            {
                do
                {
                    //Console.WriteLine("Ingrese cantidad de bolsas (Sugerencia '10')");
                    //int bolsas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la canitdad de KG que quiere que tenga la bolsa");
                    int kilos = int.Parse(Console.ReadLine());
                    Console.WriteLine("¿Que sabor Quiere?");
                    string sabor = Console.ReadLine();


                    if (sabor == "carne" || sabor == "vegetal" || sabor == "pollo" && kilos >= 0 && kilos < 500)
                    {
                        flag = false;
                        if (sabor == "carne")
                        {
                            SumapromedioCarne = SumapromedioCarne + kilos;

                            cantidadSaborCarne++;

                            promedioCarne = SumapromedioCarne / cantidadSaborCarne;
                        }
                        if (sabor == "vegetal")
                        {
                            cantidadSaborVegetal++;
                        }
                        if (sabor == "pollo")
                        {
                            cantidadSaborPollo++;
                        }
                        if (kilos < BolsaMasLiviana)
                        {
                            BolsaMasLiviana = kilos;
                            BolsaMasLiviana2 = sabor;
                        }
                        cantidadTotal++;

                        kilostotales = kilostotales + kilos;

                        promedio = kilostotales / cantidadTotal;




                        Console.WriteLine("{0} Si usted desea deternse presione 'n', para continuar otra letra", Environment.NewLine);
                        continuar = char.Parse(Console.ReadLine());
                    }


                } while (flag);

            }

            Console.WriteLine("*************************************");
            Console.WriteLine($"Los datos Ingresados son los siguientes, ingreso {cantidadTotal} cantidad de bolsas");
            Console.WriteLine("*************************************");
            Console.WriteLine("                                     ");
            Console.WriteLine("El promedio total de total de los kilos es " + promedio + " KG");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"La bolsa mas liviana es de sabor {BolsaMasLiviana2} y pesa {BolsaMasLiviana} KG");
            Console.WriteLine("-----------------*******-----------------");
            Console.WriteLine($"La cantidad de bolsas sabor carne es de {cantidadSaborCarne} y su promedio es de {promedioCarne} KG");
        }
    }
}
