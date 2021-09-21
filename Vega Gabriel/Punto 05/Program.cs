using System;

namespace Punto_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("-----------------Ejercicio 5--------------------");
            Console.WriteLine("                        ");

            bool flag = true;
            char continuar = 'x';
            float SumaVarones = 0;
            float NotaFinalA = 0;
            float cantidadVarones = 0;
            float cantidadMujeres = 0;
            
            float cantidadVaronesMenoresD = 0;
            float cantidadMujeresMenoresD = 0;
            float cantidadVaronesAdolecentesD = 0;
            float cantidadMujeresAdolecentesD = 0;
            float cantidadVaronesDesaprovados = 0;
            float cantidadMujeresDesaprovadas = 0;

            float cantidadVaronesMenoresA = 0;
            float cantidadMujeresMenoresA = 0;
            float cantidadMujeresAdolecentesA = 0;
            float cantidadVaronesAdolecentesA = 0;
            float cantidadMujeresAdultasA = 0;
            float cantidadHombresAdultosA = 0;


            while (continuar != 'n')
            {
                do
                {
                    //Console.WriteLine("Ingrese un nombre de un estudiante");
                    //string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese la edad del estudiante");
                    int edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese Sexo");
                    char sexo = char.Parse(Console.ReadLine());
                    Console.WriteLine("Ingres su nota Final");
                    int nota = int.Parse(Console.ReadLine());



                    if (sexo == 'm' || sexo == 'f' )
                    {
                        flag = false;
                        if (sexo == 'f')
                        {
                            if (edad <= 12)
                            {
                                if (nota >= 7)
                                {
                                    cantidadMujeresMenoresA++;
                                }
                                if (nota < 6)
                                {
                                    cantidadMujeresMenoresD++;
                                }

                            }
                            if (edad > 13 || edad < 17)
                            {
                                if (nota > 7)
                                {
                                    cantidadMujeresAdolecentesA++;
                                }
                                if (nota <= 6)
                                {
                                    cantidadMujeresAdolecentesD++;
                                }
                            }
                            if (edad > 18)
                            {
                                if (nota > 7)
                                {
                                    cantidadMujeresDesaprovadas++;
                                }
                                if (nota <= 6)
                                {
                                    cantidadMujeresAdultasA++;
                                }
                            }
                        }
                        if (sexo == 'm')
                        {
                            if (edad <= 12)
                            {
                                if (nota >= 7)
                                {
                                    cantidadVaronesMenoresA++;
                                }
                                if (nota < 6)
                                {
                                    cantidadVaronesMenoresD++;
                                }

                            }
                            if (edad > 13 || edad < 17)
                            {
                                if (nota > 7)
                                {
                                    cantidadVaronesAdolecentesA++;
                                }
                                if (nota <= 6)
                                {
                                    cantidadVaronesAdolecentesD++;
                                }
                                NotaFinalA = NotaFinalA + nota;
                            }
                            if (edad > 18)
                            {
                                if (nota > 7)
                                {
                                    cantidadHombresAdultosA++;
                                }
                                if (nota <= 6)
                                {
                                    cantidadVaronesDesaprovados++;
                                }
                            }
                            SumaVarones = cantidadHombresAdultosA + cantidadVaronesAdolecentesA + cantidadVaronesMenoresA;
                        }
                        
                       
                    }
                    





                    Console.WriteLine("{0} Si usted desea deternse presione 'n', para continuar otra letra", Environment.NewLine);
                    continuar = char.Parse(Console.ReadLine());

                } while (flag);

            }

            Console.WriteLine(" Usted Ingreso Los Siguientes Datos: ");
            Console.WriteLine("**************************************");
            Console.WriteLine($"La cantidad de varones aprovados es {SumaVarones}");
        }
    }
}
