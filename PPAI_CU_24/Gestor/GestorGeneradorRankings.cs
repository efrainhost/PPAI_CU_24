using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_CU_24.Interfaces;
using PPAI_CU_24.Entidades;

namespace PPAI_CU_24.Gestor
{
    public class GestorGeneradorRankings
    {
        // Atributos
        private List<float> promediosVino { get; set; }
        private static List<Vino>? vinosConReseñaAprobada { get; set; }
        private List<Vino>? vinosOrdenados { get; set; }
        private static List<Vino> mejoresDiezVinos { get; set; }
        private static DateTime fechaDesde { get; set; }
        private static DateTime fechaHasta { get; set; }
        private string tipoReseñaSeleccionada { get; set; }
        private string visualizacionSeleccionada { get; set; }
        private string confirmacionReporte { get; set; }

        // Relaciones
        public PantallaGeneradorRanking pantallaGeneradorRanking { get; set; }
        public PantallaVisualizacionVinos pantallaVisualizacionVinos { get; set; }  
        public Vino vino { get; set; }


        // Constructor
        public GestorGeneradorRankings()
        {
            promediosVino = new List<float>();
            vinosOrdenados = new List<Vino>();
            tipoReseñaSeleccionada = string.Empty;
            visualizacionSeleccionada = string.Empty;
            confirmacionReporte = string.Empty;
        }


        // Metodos
        public static void opcGenerarRankingVinos()
        {
            var gestor = new GestorGeneradorRankings();
            gestor.buscarVinosConReseñas();
            gestor.calcularPromedioCalificaciones();
            gestor.ordenarVinosPorCalificacion();
            gestor.filtrarMejoresDiezVinos();
            gestor.buscarInformacionVinos();
        }
        public static DateTime obtenerFechaDesde()
        {
            DateTime fecha = PantallaGeneradorRanking.tomarFechaDesde();
            return fecha;
        }

        public static DateTime obtenerFechaHasta()
        {
            DateTime fecha = PantallaGeneradorRanking.tomarFechaHasta();
            return fecha;
        }

        public void tomarFechaDesde(DateTime fechaDesde)
        {
            GestorGeneradorRankings.fechaDesde = fechaDesde;
        }
        public void tomarFechaHasta(DateTime fechaHasta)
        {
            GestorGeneradorRankings.fechaHasta = fechaHasta;
        }

        public void tomarSelecTipoReseña(string reseñaSeleccionada)
        {
            this.tipoReseñaSeleccionada = reseñaSeleccionada;
        }
        public void tomarSelecTipoVisualizacion(string visualizacionSeleccionada)
        {
            this.visualizacionSeleccionada = visualizacionSeleccionada;
        }
        public void tomarConfirmacionReporte(string confirmacionReporte)
        {
            this.confirmacionReporte = confirmacionReporte;
        }

        private void buscarVinosConReseñas()
        {
            vinosConReseñaAprobada = Vino.buscarVinosConReseñas();
        }

        private void calcularPromedioCalificaciones()
        {

            foreach (Vino vino in vinosConReseñaAprobada)
            {
                int cantidad = 0;
                int puntajeTot = 0;
                foreach (Reseña rese in vino.reseñas)
                {
                    cantidad += 1;
                    puntajeTot += rese.getPuntaje();

                }

                promediosVino.Add(puntajeTot / cantidad);

            }
        }

        private void ordenarVinosPorCalificacion()
        {
            vinosOrdenados = promediosVino
                .Select((promedio, index) => new { Promedio = promedio, Indice = index }) 
                .OrderByDescending(item => item.Promedio) 
                .Select(item => item.Indice) 
                .Distinct() 
                .SelectMany<int, Vino>((index, wineIndex) => new List<Vino> { vinosConReseñaAprobada[index] }) 
                .ToList();
        }

        private void filtrarMejoresDiezVinos()
        {
            mejoresDiezVinos = vinosOrdenados.Take(10).ToList();
        }
        public List<Vino> mejoresDiez()
        {
            return mejoresDiezVinos;
        }
        private void buscarInformacionVinos()
        {
            var formVisualizacionVinos = new PantallaVisualizacionVinos();
            foreach (Vino vino in mejoresDiezVinos)
            {
                string nommbre = vino.getNombre();
                float precio = vino.getPrecioARS();
                (string, string, string, string, List<string>) tupla = vino.obtenerBodega();
                List<Varietal> var = [];
                foreach (Varietal varietal in vino.varietales)
                {
                    var.Add(varietal);
                }

                (string nombreBodega, string nombreRegion, string nombreProvincia, string nombrePais, List<string> descripciones) = vino.obtenerBodega();
                string descripcionesString = string.Join(", ", descripciones);
                
                formVisualizacionVinos.dgvVinos.Rows.Add(vino.getNombre(), vino.getPrecioARS(), descripcionesString, vino.calificacionPromedio(), nombreBodega, nombreRegion, nombrePais);
            }
            formVisualizacionVinos.Show();
        }

        private void generarExcelRanking()
        {
            // Se trabajara con esta funcion mas adelante
        }

        // VER
        public void finCU()
        {
            MessageBox.Show("Finalizó el caso de uso");
        }
    }
}
