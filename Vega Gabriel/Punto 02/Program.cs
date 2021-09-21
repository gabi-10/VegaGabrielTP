using System;

namespace Punto_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string continente, mediodepago;
            int CantidadDeDias;
            Console.WriteLine("Ingrese A que continente le gustaria viajar");
            continente = Console.ReadLine();
            Console.WriteLine("Ingrese MedioDepago");
            mediodepago = Console.ReadLine();
            Console.WriteLine("cuantos dias quiere quedarse");
            CantidadDeDias = int.Parse(Console.ReadLine());

            bool continenteRecibido = ValidarContinente(continente);
            bool mediodePagoRecibido = ValidarMedioDepago(mediodepago);
            if (continenteRecibido && mediodePagoRecibido)
            {
                ValidarPrecio(continente, CantidadDeDias, mediodepago);
            }
            else
            {
                Console.WriteLine("Continente o Medio de pago invalido");
            }
        }
        static bool ValidarContinente(string continente)
        {
            bool continentevalido = (continente == "america" || continente == "europa" || continente == "africa" || continente == "asia" || continente == "oceania");
            return continentevalido;
        }
        static bool ValidarMedioDepago(string MedioDePago)
        {
            bool medioDePagovalido = (MedioDePago == "debito" || MedioDePago == "credito" || MedioDePago == "mercadopago" || MedioDePago == "cheque" || MedioDePago == "efectivo");
            return medioDePagovalido;
        }
        static void ValidarPrecio(string continente, int CantidadDeDias, string medioDePago)
            {
            float precioFinal = 0;
            float ValorDia = 100;
            float PrecioTotalDias = 0;
            float descuento = 0;

            switch (continente)
            {
                case "america":
                    descuento = (CantidadDeDias * ValorDia) * 0.15f;
                    precioFinal = (CantidadDeDias * ValorDia) - descuento;
                    if (medioDePago == "debito")
                    {
                        descuento = (CantidadDeDias * ValorDia) * 0.10f;
                        precioFinal = precioFinal - descuento;
                        Console.WriteLine("Con Debito tiene un 10% de descuento mas, por lo tanto abona " + precioFinal);
                    }
                    else
                    {
                        Console.WriteLine("el precio final con el descuento por ser America es de " + precioFinal);
                    }

                    break;

                case "africa":
                    descuento = (CantidadDeDias * ValorDia) * 0.30f;
                    precioFinal = (CantidadDeDias * ValorDia) - descuento;
                    if (medioDePago == "mercadopago")
                    {
                        descuento = (CantidadDeDias * ValorDia) * 0.15f;
                        precioFinal = precioFinal - descuento;
                        Console.WriteLine("Con mercadopago tiene un 15% mas de descuento mas sumado al descuento inicial, por lo tanto abona " + precioFinal);
                    }

                    break;
                case "europa":
                    descuento = (CantidadDeDias * ValorDia) * 0.20f;
                    precioFinal = (CantidadDeDias * ValorDia) - descuento;
                    if (medioDePago == "debito")
                    {
                        descuento = (CantidadDeDias * ValorDia) * 0.15f;
                        precioFinal = precioFinal - descuento;
                        Console.WriteLine("Con debito tiene un 15% mas de descuento mas sumado al descuento inicial, por lo tanto abona " + precioFinal);
                    }
                    if (medioDePago == "mercadopago")
                    {
                        descuento = (CantidadDeDias * ValorDia) * 0.10f;
                        precioFinal = precioFinal - descuento;
                        Console.WriteLine("con mercado pago tiene un 10% mas de descuento sumado al inicial, por lo tanto paga " + precioFinal);
                    }

                    break;

                case "asia":
                    precioFinal = CantidadDeDias;
                    if (medioDePago == "debito" || medioDePago == "efectivo" || medioDePago == "mercadopago")
                    {
                        PrecioTotalDias = CantidadDeDias * ValorDia;
                        Console.WriteLine("El Precio por la cantidad de dias que usted quiere es " + CantidadDeDias + " $");
                        double incremento = (CantidadDeDias * 20) / 100;
                        Console.WriteLine("Con el Recargo de 20% usted abona " + incremento + " $");
                    }
                    break;

                case "oceania":
                    descuento = (CantidadDeDias * ValorDia) * 0.30f;
                    precioFinal = (CantidadDeDias * ValorDia) - descuento;
                    if (medioDePago == "mercadopago")
                    {
                        descuento = (CantidadDeDias * ValorDia) * 0.15f;
                        precioFinal = precioFinal - descuento;
                        Console.WriteLine("Con mercadopago tiene un 15% mas de descuento mas sumado al descuento inicial, por lo tanto abona " + precioFinal);
                    }
                    break; 
            }
        }
    }
}
