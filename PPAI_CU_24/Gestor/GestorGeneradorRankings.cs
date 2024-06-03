using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_CU_24.Interfaces;
using PPAI_CU_24.Entidades;
using System.Runtime.CompilerServices;
using System.Collections;

namespace PPAI_CU_24.Gestor
{
    public class GestorGeneradorRankings
    {
        // Atributos
        private List<(Vino, float)> vinosConReseñaYPromedio { get; set; }
        private List<Vino> vinosOrdenados { get; set; }
        private List<Vino> mejoresDiezVinos { get; set; }
        private DateTime fechaDesde { get; set; }
        private DateTime fechaHasta { get; set; }
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
            vinosConReseñaYPromedio = new List<(Vino, float)>();
            vinosOrdenados = new List<Vino>();
            mejoresDiezVinos = new List<Vino>();
            tipoReseñaSeleccionada = string.Empty;
            visualizacionSeleccionada = string.Empty;
            confirmacionReporte = string.Empty;
        }

        // Metodos
        public static void opcGenerarRankingVinos()
        {
            var gestor = new GestorGeneradorRankings();
            gestor.buscarVinosConReseñas();
            gestor.ordenarVinosPorCalificacion();
            gestor.filtrarMejoresDiezVinos();
            gestor.buscarInformacionVinos();
        }

        public DateTime obtenerFechaDesde()
        {
            DateTime fecha = PantallaGeneradorRanking.tomarFechaDesde();
            return fecha;
        }

        public DateTime obtenerFechaHasta()
        {
            DateTime fecha = PantallaGeneradorRanking.tomarFechaHasta();
            return fecha;
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
            List<Vino> vinos = Servicios.Servicios.GeneradorVinos();
            foreach (Vino v in vinos)
            {
                (int puntaje, bool tieneReseñaAprobada) = v.buscarVinosConReseñas(this.obtenerFechaDesde(), this.obtenerFechaHasta());
                if (tieneReseñaAprobada)
                {
                    float promedio = calcularPromedioCalificaciones(puntaje, v.reseñas.Count);
                    vinosConReseñaYPromedio.Add((v, promedio));
                }
            }
        }

        private float calcularPromedioCalificaciones(int puntaje, int cantrese)
        {
            return cantrese > 0 ? (float)puntaje / cantrese : 0;
        }

        private void ordenarVinosPorCalificacion()
        {
            vinosOrdenados = vinosConReseñaYPromedio.OrderByDescending(vp => vp.Item2).Select(vp => vp.Item1).ToList();
        }

        private void filtrarMejoresDiezVinos()
        {
            mejoresDiezVinos = vinosOrdenados.Take(10).ToList();
        }
        private void buscarInformacionVinos()
        {
            var formVisualizacionVinos = new PantallaVisualizacionVinos();
            foreach (Vino vino in mejoresDiezVinos)
            {
                string nombre = vino.getNombre();
                float precio = vino.getPrecioARS();
                List<string> descripVar = vino.obtenerVarietal();
                (string bodega, string region, string pais) = vino.obtenerBodegaRegionPais();
                float puntaje = vinosConReseñaYPromedio.Where(vp => vp.Item1 == vino).Select(vp => vp.Item2).FirstOrDefault();
                string descripcionesString = string.Join(", ", descripVar);
                
                formVisualizacionVinos.dgvVinos.Rows.Add(nombre, precio, descripcionesString,puntaje, bodega, region, pais);
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
