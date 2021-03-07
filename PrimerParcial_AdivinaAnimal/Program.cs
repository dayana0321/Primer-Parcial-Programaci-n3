using PrimerParcial_AdivinaAnimal.BaseDeDatos;
using PrimerParcial_AdivinaAnimal.clases.JuegoAnimal;
using System;

namespace PrimerParcial_AdivinaAnimal
{
    class Program
    {
        public static void JuegoAnimales()
        {
            Console.WriteLine("Juguemos a adivinar animales");
            Boolean otroJuego = true;
            AdivinaAnimal juego = new AdivinaAnimal();

            do
            {
                juego.jugar();
                Console.WriteLine("¿Jugamos otra vez?");
                otroJuego = juego.respuesta();

                

            } while (otroJuego);
            

        }
        static void Main(string[] args)
        {
            JuegoAnimales();

            insertarArbol mostrar = new insertarArbol();
            mostrar.Mostrardatos();
                        
            
        }
    }
}
