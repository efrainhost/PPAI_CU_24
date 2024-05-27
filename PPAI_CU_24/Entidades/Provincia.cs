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
        
        public Pais pais { get; set; }
        
        // Constructor
        public Provincia(string nombre, Pais pais)
        {
            // Inicializar atributos
            this.nombre = nombre;

            // Inicializar relacion

            this.pais = pais;
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
        public  string getNombrePais(Provincia provincia)
        {
            string nombrePais = provincia.pais.getNombre();
            return nombrePais;
        }
    }
}
