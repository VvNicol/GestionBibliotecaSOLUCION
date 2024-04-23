using GestionBiblioteca.Dtos;
using GestionBiblioteca.Servicios;

namespace GestionBiblioteca.Controladores
{
    public class Program
    {
        //Global
        public static long idBibliotecaSeleccionada;
        public static List<BibliotecaDto> listaBibliotecas = new List<BibliotecaDto>();

        public static void Main(string[] args)
        {
            MenuImplementacion mi = new MenuImplementacion();
            BibliotecaImplementacion bi = new BibliotecaImplementacion();
            bool cerrarMenu = false;
            int seleccionUsuario;
            //Leer ficheros y guardar en listas

            while(!cerrarMenu){

                seleccionUsuario = mi.mostrarMenuYSeleccion();
                switch (seleccionUsuario)
                {
                    case 0:
                        //Guardar en ficheros
                        cerrarMenu = true;
                        break;
                    case 1:
                        bi.alta();
                        break;
                    case 2:
                        bi.acceso();
                        break;
                    default:
                        break;
                }

            }

        }

    }
}
