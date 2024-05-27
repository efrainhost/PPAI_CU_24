using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU_24.Entidades
{
    public class Varietal
    {
        // Atributos
        private string descripcion;

        // Constructos
        public Varietal(string descripcion) 
        {
            // Inicializar atributos
            this.descripcion = descripcion;
        }   

        // Metodos set y get
        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }
        public string getDescripcion()
        {
            return this.descripcion;
        }
    }
}
