using System;

namespace _2da_practica
{
    class Program
    {
        static void Main(string[] args)
        {
            //definicion de varibles 
            string cadena  = "";
            int edad = 0;
            double estatura = 0.0;

            //informacion requerida 
            
            Console.WriteLine(" bienvenido a nuestro parque, por favor introducir su edad:");
            cadena = Console.ReadLine();
            edad = Convert.ToInt32(cadena);

            if (edad>=25)
            {
               Console.WriteLine(" usted a superado el limite de edad requerida para entrer al parque.");
            }
           else
           {
               Console.WriteLine("sea usted bienvenido");

               Console.WriteLine("por favor indicar su estatura en metros");
               cadena = Console.ReadLine();
               estatura = Convert.ToDouble(cadena);

               if ( estatura<1.9)
               {
                   Console.WriteLine("usted puede ir a la casa embrujada, la montaña rusa y el carusel");
            
               }
               else
               {
                   Console.WriteLine("usted puede visitar la casa embrujada, la rueda de la fortuna,la motaña rusa, el carusel y el viaje en tren.");
                   Console.WriteLine("le deseamos una feliz visita que transcurra entre risas y diversion");
               }
               //
           }

           Console.ReadKey();
        }
    }
}

