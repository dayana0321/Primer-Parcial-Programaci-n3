using System;
using System.Collections.Generic;
using System.Text;

namespace PrimerParcial_AdivinaAnimal.clases.ArbolBinario
{
    class Nodo
    {
        //Creando la estructura del árbol
        public object dato;
        public Nodo izquierda;
        public Nodo derecha;

        //Sólo enviamos el valor
        public Nodo(object valor)
        {
            dato = valor;
            izquierda = null;
            derecha = null;
        }

        //Enviamos el valor y los hijos de rama derecha e izquierda
        public Nodo(Nodo ramaIzquierda, object valor, Nodo ramaDerecha)
        {
            dato = valor;
            izquierda = ramaIzquierda;
            derecha = ramaDerecha;
        }

        public void visitar()
        {
            Console.WriteLine(dato + "<->");

        }

        //Devuelve el valor nodo
        public object ValorNodo()
        {
            return dato;
        }

        //Devuelve el valor del nodo derecho
        public Nodo subarbolDerecho()
        {
            return derecha;
        }

        //Devuelve el valor de la rama izquierda
        public Nodo subarbolIzquierdo()
        {
            return izquierda;
        }

        //Accesos para asignarle valor
        public void nuevoValor(object nv)
        {
            dato = nv;
        }

        //Accesos para cambiar valores a ramas
        public void ramaIzquiera(Nodo n)
        {
            izquierda = n;
        }
        public void ramaDerecha(Nodo n)
        {
            derecha = n;
        }
    } //Fin clase Nodo
}
