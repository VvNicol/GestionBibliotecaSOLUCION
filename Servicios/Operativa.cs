using GestionBiblioteca.Controladores;
using GestionBiblioteca.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Servicios
{
    public abstract class Operativa
    {

        public abstract void alta();

        public void acceso()
        {
            List<long> listIds = new List<long>();
            long idAcceso;

            foreach (BibliotecaDto biblioteca in Program.listaBibliotecas)
            {
                Console.WriteLine("Id: " + biblioteca.IdBiblioteca +
                    "Nombre: " + biblioteca.NombreBiblioteca);
                listIds.Add(biblioteca.IdBiblioteca);
            }

            do
            {
                Console.WriteLine("¿A qué biblioteca quiere acceder? (id)");
                idAcceso = Convert.ToInt64(Console.ReadLine());

            } while (!listIds.Contains(idAcceso));

            //Menu
        }
    }
}
