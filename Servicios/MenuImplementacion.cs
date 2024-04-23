using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBiblioteca.Controladores;
using GestionBiblioteca.Dtos;

namespace GestionBiblioteca.Servicios 
{
    public class MenuImplementacion : Menu
    {
        override
        public int mostrarMenuYSeleccion()
        {
            Console.WriteLine("0. Cerrar aplicación");
            Console.WriteLine("1. Alta biblioteca");
            Console.WriteLine("2. Acceso biblioteca");
            Console.WriteLine("Selecciones opción: ");
            int seleccion = Convert.ToInt32(Console.ReadLine());

            return seleccion;
        }
    }
}
