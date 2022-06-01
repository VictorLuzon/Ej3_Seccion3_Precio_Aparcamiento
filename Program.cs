using System;

namespace Ej_3_Sección_3
{
    /*Hacer un programa que le diga al usuario el precio que debe pagar por el servicio de estacionamiento de un centro comercial 
    con base en el tiempo que ha permanecido ahí, los primeros 60 minutos: 5.00€, 
    las primeras 2 horas 15.00€ y de 2 horas en adelante: 40.00€*/
    class Program
    {
        static void Main(string[] args)
        {
            //Pide al usuario el nº de horas en minutos.
            Console.WriteLine("Escribe el nº de horas en minutos que vas a pasar en el aparcamiento."
                            + "Dónde 0.5H serán 30min, 1h serán 60min, 1,5h serán 90min, 2h serán 120min, etc.");
            double minutos = Double.Parse(Console.ReadLine());

            //Metemos un condicional, en el que si los minutos son menores o iguales a 60, muestra que el precio es 5.00€.
            if(minutos <= 60){
                Console.WriteLine($"El precio por estar {minutos} minutos en el aparcamiento, es de 5.00 euros");
            }
            //Si los minutos introducidos por el usuario son mas de 60 pero menor o igual a 240, muestra que el precio es de 15.00€.
            else if(minutos > 60 && minutos <= 240){
                Console.WriteLine($"El precio por estar {minutos} minutos en el aparcamiento, es de 15.00 euros");
            }
            //Y finalmente, si son mas de 240 minutos, muestra que el precio es de 40.00€.
            else if(minutos > 240){
                Console.WriteLine($"El precio por estar {minutos} minutos en el aparcamiento, es de 40.00 euros");
            }
        }
    }
}
