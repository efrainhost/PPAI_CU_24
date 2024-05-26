using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU_24.Entidades
{
    public class Provincia
    {
        // Atributos
        public string nombre { get; set; }

        // Relacion de agregación
        public List<RegionVitivinicola> regiones { get; set; }
        public RegionVitivinicola regionVitivinicola { get; set; }
        
        // Constructor
        public Provincia(string nombre, List<RegionVitivinicola> regiones)
        {
            // Inicializar atributos
            this.nombre = nombre;

            // Inicializar relacion
            this.regiones = new List<RegionVitivinicola>();

        }   

        // Metodos get y set
        public string getNombreProvincia()
        {
            return this.nombre;
        }
        public void setNombreProvincia(string nombre)
        {
            this.nombre = nombre;
        }

        // Metodos agregar obtener pais
        public static string obtenerPais(Provincia provincia)
        {
            return Pais.getNombrePais(provincia);
        }
    }
}
