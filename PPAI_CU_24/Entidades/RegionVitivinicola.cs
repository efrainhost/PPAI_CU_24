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
        private string descripcion { get; set; }
        private string nombre { get; set; }

        public Provincia provincia { get; set; }   

        

        // Constructor 
        public RegionVitivinicola(string descripcion, string nombre, Provincia provincia) 
        {
            this.descripcion = descripcion;
            this.nombre = nombre;   
            this.provincia = provincia; 
        }

       
        // Metodos set y get
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public string getDescripcion()
        {
            return this.descripcion;
        }
        public static (string, string) obtenerProvincia(RegionVitivinicola region)
        {
            string nombreProvincia = region.provincia.getNombreProvincia();
            Provincia provincia = region.provincia;
            string nombrePais = region.provincia.getNombrePais(provincia);
            return (nombreProvincia, nombrePais);
        }
    }
}
