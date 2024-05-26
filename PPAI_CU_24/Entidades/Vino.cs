using System;
using System.Collections.Generic;
using System.Linq;
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
        public float precioARS { get; set; }

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

        // Metodos
        public static List<Vino> buscarVinosConReseñas()
        {
            List<Vino> vinos = Servicios.Servicios.GeneradorVinos();
            List<Vino> vinosAprobados = [];

            foreach (Vino vino in vinos)
            {
                if (vino.reseñas.Count > 0)
                {
                    List<Reseña> reseñasAprobadas = Reseña.buscarReseña(vino, GestorGeneradorRankings.fechaDesde, GestorGeneradorRankings.fechaHasta);
                    if (reseñasAprobadas.Count > 0)
                    {
                        vinosAprobados.Add(vino);
                    }
                }
            }
            return vinosAprobados;
 
        }
        public string obtenerBodega(Bodega bodega)
        {
            return bodega.getNombre();
        }
    }

    
}
