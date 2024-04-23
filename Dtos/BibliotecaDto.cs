using GestionBiblioteca.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Transactions;

namespace GestionBiblioteca.Dtos
{
    public class BibliotecaDto
    {
        
        long idBiblioteca; 
        string nombreBiblioteca = "aaaaa";
        string direccionBiblioteca = "aaaaa";

        public BibliotecaDto(long idBiblioteca, string nombreBiblioteca, string direccionBiblioteca)
        {
            this.idBiblioteca = idBiblioteca;
            this.nombreBiblioteca = nombreBiblioteca;
            this.direccionBiblioteca = direccionBiblioteca;
        }

        public BibliotecaDto()
        {
       
        }

        public long IdBiblioteca { get => idBiblioteca; set => idBiblioteca = value; }
        public string NombreBiblioteca { get => nombreBiblioteca; set => nombreBiblioteca = value; }
        public string DireccionBiblioteca { get => direccionBiblioteca; set => direccionBiblioteca = value; }
    }
}
