using LibreriaEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEntidades.AdministrarPublicadores
{
    public static class AdminPublicador
    {
        public static List<Publicador> publicadores = new List<Publicador>()
            {
                new Publicador(1, "Medrano", "Angel", Convert.ToDateTime("11/06/1990"), "Mar del Plata"),
                new Publicador(2, "Gonzalez", "Manuel", Convert.ToDateTime("12/04/1980"), "La plata"),
                new Publicador(3, "Rapen", "Guillermo", Convert.ToDateTime("26/03/1989"), "Rosario"),
            };
        public static void insertar(Publicador publicador)
        {
            publicadores.Add(publicador);
        }

        public static List<Publicador> listar()
        {
            return publicadores;
        }

        public static void eliminar(int iD)
        {
            int contador = 0;
            foreach (Publicador publicador in publicadores)
            {
                if(publicador.ID == iD)
                {
                    contador++;
                }
            }
            publicadores.RemoveAt(contador);
        }
    }
}

        
 

