using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU_24.Entidades
{
    public class RegionVitivinicola
    {
        // Atributos
        public string descripcion { get; set; }
        private string nombre { get; set; }

        

        // Constructor 
        public RegionVitivinicola(string descripcion, string nombre) 
        {
            this.descripcion = descripcion;
            this.nombre = nombre;   
        }

       
        // Metodos set y get
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public String getDescripcion()
        {
            return this.descripcion;
        }

        public static string getNombreRegion()
        {
            return Provincia.obtenerPais();
        }


    }
}
