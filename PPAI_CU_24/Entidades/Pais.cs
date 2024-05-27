using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU_24.Entidades
{
    public class Pais
    {
        // Atributos
        private string nombre { get; set; }

        public Pais(string nombre)
        {
            // Inicializar atributos
            this.nombre = nombre;

        }

        // Metodos set y get
        public string getNombre()
        {
            return this.nombre;
        }

        public void setNombre(string nombre)
        {

            this.nombre = nombre;
        }

    }






}


