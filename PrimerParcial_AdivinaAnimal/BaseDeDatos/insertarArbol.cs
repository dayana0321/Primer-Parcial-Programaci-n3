using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PrimerParcial_AdivinaAnimal.BaseDeDatos
{
    class insertarArbol
    {
        public int id { get; set; }
        public string animal { get; set; }

        public string pregunta { get; set; }

        public void guardarArbol(insertarArbol nuevonodo)
        {
            string sql = @"insert into Adivina_animal ([Animal], [pregunta]) 
            values ('" + nuevonodo.animal + "','" + nuevonodo.pregunta + "')";
            new Conexion().EjecutaSQLDirecto(sql);

        }

        public List<insertarArbol> Cargardatos()
        {
            Conexion cn = new Conexion();
            insertarArbol Dato = new insertarArbol();
            List<insertarArbol> TodosLosDatos = new List<insertarArbol>();

            DataTable dt = cn.consultaTablaDirecta("SELECT Animal,Pregunta FROM [Adivina_Animal] ORDER BY id ASC");

            foreach (DataRow dr in dt.Rows)
            {

                
                Dato.animal = dr["Animal"].ToString();
                Dato.pregunta = dr["Pregunta"].ToString();
                
                TodosLosDatos.Add(Dato);
                Dato = new insertarArbol();

            }
            return TodosLosDatos;
            
        }

        public void Mostrardatos()
        {
            Conexion cn = new Conexion();
            insertarArbol Dato = new insertarArbol();
            String cont = "          ";
            String cont1 = "  ";
            
            DataTable dt = cn.consultaTablaDirecta("SELECT Animal,Pregunta FROM [Adivina_Animal] ORDER BY id ASC");
            Console.WriteLine("ESTOS SON LOS ANIMALES CON LOS QUE JUGASTE?\n");
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine(cont+dr["Pregunta"]);
                Console.WriteLine(cont1+dr["Animal"]);
                
                cont += "     ";
                cont1 += "     ";
                
            }
            


        }
    }
}
