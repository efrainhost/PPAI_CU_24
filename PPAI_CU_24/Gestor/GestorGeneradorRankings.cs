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
        private string reseñaSeleccionada { get; set; }
        private string visualizacionSeleccionada { get; set; }
        private string confirmacionReporte { get; set; }
        public PantallaGeneradorRanking pantallaGeneradorRanking { get; set; }

        public GestorGeneradorRankings()
        {
            promediosVino = new List<float>();
            vinosOrdenados = new List<Vino>();
            reseñaSeleccionada = string.Empty;
            visualizacionSeleccionada = string.Empty;
            confirmacionReporte = string.Empty;
        }



        public static void opcGenerarRankingVinos()
        {
            var gestor = new GestorGeneradorRankings();
            gestor.buscarVinosConReseñas();
            gestor.calcularPromedioCalificaciones();
            gestor.ordenarVinosPorCalificacion();
            gestor.filtrarMejoresDiezVinos();
            gestor.buscarInformacionVinos();
            gestor.finCU();
        }
        public static DateTime obtenerFechaDesde()
        {
            DateTime fecha = PantallaGeneradorRanking.tomarFechaDesde();
            return fecha;
        }

        // Método para obtener la fecha hasta
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

        private void buscarVinosConReseñas()
        {
            vinosConReseñaAprobada = Vino.buscarVinosConReseñas();
        }

        private void calcularPromedioCalificaciones()
        {
            int cantidad = 0;
            int puntajeTot = 0;

            foreach (Vino vino in vinosConReseñaAprobada)
            {
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
                .OrderByDescending(promedio => promedio) // Ordena de mayor a menor promedio
                .Select(promedio => vinosConReseñaAprobada[promediosVino.IndexOf(promedio)]) // Obtiene los vinos según el índice del promedio
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
            foreach (Vino vino in mejoresDiezVinos)
            {
                string nommbre = vino.getNombre();
                float precio = vino.getPrecioARS();
                (string, string, string, string, List<string>) tupla = vino.obtenerBodega(vino);
            }
        }

        private void generarExcelRanking()
        {
        }



        private void finCU()
        {
            MessageBox.Show("Ranking generado exitosamente!");
        }



    }
}
