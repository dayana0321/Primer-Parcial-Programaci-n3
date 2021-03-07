using PrimerParcial_AdivinaAnimal.BaseDeDatos;
using PrimerParcial_AdivinaAnimal.clases.ArbolBinario;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimerParcial_AdivinaAnimal.clases.JuegoAnimal
{
    class AdivinaAnimal
    {
        //Es un pequeño juego que se trata de adivinar el animal que uno está pensando, utilizando un árbol de toma de decisiones
        private static Nodo raiz;

        public AdivinaAnimal()
        {
            //Creacion del arbol
            raiz = new Nodo("Elefante");
        }

        //Mecanica del juego
        public void jugar()
        {
            Nodo nodo = raiz;

            //Ciclo para iterar el arbol 
            while (nodo != null)
            {
                if (nodo.izquierda != null) //existe una pregunta
                {
                    //Imprimir en pantalla el vlaor del nodo
                    Console.WriteLine(nodo.ValorNodo());
                    nodo = (respuesta()) ? nodo.izquierda : nodo.derecha;
                }
                else
                {
                    Console.WriteLine($"Ya sé, es un {nodo.ValorNodo()}?");
                    if (respuesta())
                    {
                        Console.WriteLine("Gane !!!!");
                    }
                    else
                    {
                        animalNuevo(nodo);
                    }
                    nodo = null;
                    return;
                }
            }//fin while
        }//fin jugar

        public bool respuesta()
        {
            while (true)
            {
                String resp = Console.ReadLine().ToLower().Trim();
                if (resp.Equals("si")) return true;
                if (resp.Equals("no")) return false;
                Console.WriteLine("La respuesta debe ser Si o No");
            }
        }//fin respuesta

        private void animalNuevo(Nodo nodo)
        {
            //Cuando el animal no esta en la lista
            //Se castea porque el dato inicial es de tipo Object
            insertarArbol inser = new insertarArbol(); 
            String animalNodo = (String)nodo.ValorNodo();
            String raiz1 = (String)nodo.ValorNodo();
           

            Console.WriteLine("¿Cuál es tu animal pues?");
            String nuevoA = Console.ReadLine();

            Console.WriteLine($"¿Qué pregunta con respuesta si / no puedo hacer para poder decir que es un {nuevoA} ?");
            String pregunta = Console.ReadLine();

            //Tiene valor de animal Nodo
            Nodo nodo1 = new Nodo(animalNodo);

            //Tiene valor de nuevo animal
            Nodo nodo2 = new Nodo(nuevoA);

            

            Console.WriteLine($"Para un(a ) {nuevoA} la respuesta es si / no?");
            nodo.nuevoValor(pregunta + "?");

            //Colocar en el if el punto de interrupcion
            if (respuesta())
            {
                nodo.izquierda = nodo2;
                nodo.derecha = nodo1;
                inser.animal = nuevoA;
                inser.pregunta = pregunta;
                inser.guardarArbol(inser);
            }
            else
            {
                nodo.izquierda = nodo1;
                nodo.derecha = nodo2;
                inser.animal = animalNodo;
                inser.pregunta = pregunta;

            }
        }

     

    }//fin clase Adivina Animal
}
