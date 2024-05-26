using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_CU_24.Entidades;

namespace PPAI_CU_24.Gestor
{
    public class GestorGeneradorRankings
    {
        // Atributos
        public static List<float> promediosVino { get; set; }
        public static List<Vino> vinosConReseñaAprobada { get; set; }   
        public static DateTime fechaDesde { get; set; }
        public static DateTime fechaHasta { get; set; }
        public string reseñaSeleccionada { get; set; }
        public string visualizacionSeleccionada { get; set; }
        public string confirmacionReporte { get; set; }

        // Constructor 


        

        // Metodos

        public void opcGenerarRankingVinos()
        {

        }

        public void tomarFechaDesde(DateTime fechaDesde)
        {
            this.fechaDesde = fechaDesde;
        }
        public void tomarFechaHasta(DateTime fechaHasta)
        {
            this.fechaHasta = fechaHasta;
        }

        public void tomarSelecTipoReseña(string reseñaSeleccionada)
        {
            this.reseñaSeleccionada = reseñaSeleccionada;
        }
        public void tomarSelecTipoVisualizacion(string visualizacionSeleccionada)
        {
            this.visualizacionSeleccionada = visualizacionSeleccionada;
        }
        public void tomarConfirmacionReporte(string confirmacionReporte)
        {
            this.confirmacionReporte = confirmacionReporte;
        }

        public static void  buscarVinosConReseñas()
        {
            vinosConReseñaAprobada = Vino.buscarVinosConReseñas();
        }

        public void calcularPromedioCalificaciones()
        {
            int cantidad = 0;
            int puntajeTot = 0;
            

            foreach (Vino vino in vinosConReseñaAprobada)
            {
                foreach (Reseña rese in vino.reseñas)
                {
                    cantidad += 1;
                    puntajeTot += rese.puntaje;
                }
                promediosVino.Add(puntajeTot / cantidad);
            }
        }

        public void ordenarVinosPorCalificacion()
        {

        }

        public void filtrarMejoresDiezVinos()
        {

        }
        public void buscarInformacionVinos() 
        { 
        
        }

        public void generarExcelRanking() 
        {
        }


        public void finCU()
        {
            MessageBox.Show("Ranking generado exitosamente!");
        }
        


    }
}
