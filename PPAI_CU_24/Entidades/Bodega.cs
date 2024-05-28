using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU_24.Entidades
{
    public class Bodega
    {
        // Atributos
        private string nombre { get; set; }

        // Relacion 
        public RegionVitivinicola regionVitivinicola { get; set; }

        public Bodega(string nombre, RegionVitivinicola regionVitivinicola)
        {
            // Inicializar atributos
            this.nombre = nombre;

            // Inicializar relaciones
            this.regionVitivinicola = regionVitivinicola;
        }


        // Metodos get y set

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }

        public (string, string, string) obtenerRegion()
        {
            string nombreRegion = this.regionVitivinicola.getNombre();
            RegionVitivinicola region = this.regionVitivinicola;
            (string nombreProvincia, string nombrePais) = region.obtenerProvincia();
            return (nombreRegion, nombreProvincia, nombrePais);
        }
    }



}
