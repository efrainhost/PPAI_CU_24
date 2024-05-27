﻿using System;
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
        public  string getNombre()
        {
            return this.nombre;
        }

        public static (string, string, string) obtenerRegion(Bodega bodega)
        {
            string nombreRegion = bodega.regionVitivinicola.getNombre();
            RegionVitivinicola region = bodega.regionVitivinicola;
            (string nombreProvinicia, string nombrePais) = RegionVitivinicola.obtenerProvincia(region);
            return (nombreRegion, nombreProvinicia, nombrePais);
        }
    }

   
}
