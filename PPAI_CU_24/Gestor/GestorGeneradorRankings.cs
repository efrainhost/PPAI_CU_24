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
        public string fechaDesdeYHasta { get; set; }
        public string tipoReseñaSeleccionada { get; set; }
        public string tipoVisualizacionSeleccionada { get; set; }

        // Constructor 


        // Relaciones 
        public Vino vino;

        // Metodos

        //public buscarVinosConReseñas(Vino vinos)
        //{

        //}
        

        
        public void finCU()
        {
            MessageBox.Show("Ranking generado exitosamente!");
        }
        


    }
}
