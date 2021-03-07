using System;
using System.Collections.Generic;
using System.Text;

namespace PrimerParcial_AdivinaAnimal.clases.ArbolBinario
{
    class ArbolBinario
    {
        protected Nodo raiz;

        public ArbolBinario()
        {
            //No hay nada ya que estamos creando el arbol
            raiz = null;
        }

        public ArbolBinario(Nodo ValorRaiz)
        {
            this.raiz = ValorRaiz;
        }

        //Modificadores
        public Nodo raizArbol()
        {
            return raiz;
        }

        //Devuelve si el arbol esta vacio

        bool esVacio()
        {
            //Compara si la raiz esta vacio
            return raiz == null;
        }


        public static Nodo nuevoArbol(Nodo ramaIzqda, object dato, Nodo ramaDrcha)
        {
            return new Nodo(ramaIzqda, dato, ramaDrcha);
        }
    } //fin clase Arbol Binario
}
