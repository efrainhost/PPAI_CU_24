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
        public string nombre { get; set; }

        // Relacion de agregación 
        public List<Provincia> provincias { get; set; } 
        public Provincia provincia { get; set; }



        public Pais(string nombre, List<Provincia> provincias)
        {
            // Inicializar atributos
            this.nombre = nombre;

            // Inicializar relacion
            this.provincias = provincias;

        }

        // Metodos set y get
        public String getNombre()
        {
            return this.nombre;
        }

        public void setNombre( string nombre)
        {
            this.nombre = nombre;
        }
        
    }
}
