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
        public string fechaDesde { get; set; }
        public string fechaHasta { get; set; }
        public string reseñaSeleccionada { get; set; }
        public string visualizacionSeleccionada { get; set; }
        public string confirmacionReporte { get; set; }

        // Constructor 


        // Relaciones 
        public Vino vino;

        // Metodos

        public void opcGenerarRankingVinos()
        {
            DateTime fechaDesde = tomarFechaDesde;
            DateTime fechaHasta = tomarFechaHasta;
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

        public void buscarVinosConReseñas()
        {

        }

        public void calcularPromedioCalificaciones()
        {

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
