using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PPAI_CU_24.Gestor;
using PPAI_CU_24.Servicios;

namespace PPAI_CU_24.Entidades
{
    public class Vino
    {
        // Atributos
        private string nombre { get; set; }
        private float precioARS { get; set; }

        // Relaciones 
        public Bodega bodega { get; set; }
        public List<Varietal> varietales { get; set; }
        public List<Reseña> reseñas { get; set; }



        // Constructor
        public Vino(string nombre, float precioARS, Bodega bodega, List<Varietal> varietales, List<Reseña> reseñas)
        {
            // Inicializar atributos
            this.nombre = nombre;
            this.precioARS = precioARS;

            // Inicializar relacion
            this.bodega = bodega;
            this.varietales = varietales;
            this.reseñas = reseñas;
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

        public void setPrecioARS(float precioARS)
        {
            this.precioARS = precioARS;
        }

        public float getPrecioARS()
        {
            return this.precioARS;
        }

        // Métodos
        public (int, bool) buscarVinosConReseñas(DateTime fechaDesde, DateTime fechaHasta)
        {
            int ReseñasValidas = 0;
            bool tieneReseña = false;
            int puntaje = 0;
            foreach (Reseña reseña in this.reseñas)
            {
                if (reseña.estasEnElPeriodo1(fechaDesde, fechaHasta) && reseña.sosPremium())
                {
                    tieneReseña = true;
                    puntaje += reseña.getPuntaje();
                    ReseñasValidas++;
                }
            }

            return (puntaje, tieneReseña);
        }

        public List<string> obtenerVarietal()
        {
            List<string> descripcionesVar = new List<string>();
            foreach (Varietal var in this.varietales)
            {
                descripcionesVar.Add(var.getDescripcion());
            }
            return descripcionesVar;
        }
    
        public (string, string, string) obtenerBodegaRegionPais()
        {
            string bodega = this.bodega.getNombre();
            (string region, string pais)  = this.bodega.obtenerRegion();

            return (bodega, region, pais);
            
         }
    }
}

  

    

