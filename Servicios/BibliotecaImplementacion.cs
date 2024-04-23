using GestionBiblioteca.Controladores;
using GestionBiblioteca.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Servicios
{
    internal class BibliotecaImplementacion : Operativa
    {
        override
        public void alta()
        {
            Console.WriteLine("ALTA DE UNA NUEVA BIBLIOTECA");
            Console.WriteLine("Nombre biblioteca: ");
            string nombre =  Console.ReadLine();
            Console.WriteLine("Dirección biblioteca: ");
            string direccion = Console.ReadLine();
            long id = calculoIdBiblioteca();

            BibliotecaDto biblioteca = new BibliotecaDto(id, nombre, direccion);

            Program.listaBibliotecas.Add(biblioteca);

        }

        private long calculoIdBiblioteca()
        {
            long idNuevo;            

            if (Program.listaBibliotecas.Count > 0) {

                idNuevo = Program.listaBibliotecas[Program.listaBibliotecas.Count - 1].IdBiblioteca + 1;

            }
            else
            {
                idNuevo = 1;
            }

            return idNuevo;
        }
 
    }
}
