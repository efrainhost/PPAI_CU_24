using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU_24.Entidades
{
    public class Reseña
    {
        // Atributos
        public bool esPremium { get; set; }
        private DateTime fechaReseña { get; set; }
        public int puntaje { get; set; }

        // Constructor
        public Reseña(bool esPremium, DateTime fechaReseña, int puntaje)
        {
            // Inicializar atributos
            this.esPremium = esPremium;
            this.fechaReseña = fechaReseña;
            this.puntaje = puntaje;
        }               

        // Metodos set y get
        public void setEsPremium(bool esPremium)
        {
            this.esPremium = esPremium;
        }
        public bool getEsPremium()
        {
            return this.esPremium;
        }

        public void setFechaReseña(DateTime fechaReseña)
        {
            this.fechaReseña = fechaReseña;
        }

        public DateTime getFechaReseña()
        {
            return getFechaReseña();
        }

        public void setPuntaje(int puntaje)
        {
            this.puntaje = puntaje;
        }

        public int getPuntaje()
        {
            return this.puntaje;
        }

        // Metodos
        public bool estasEnElPeriodo(Reseña reseña, DateTime fechaDesde, DateTime fechaHasta)
        {
            int comp_inf = reseña.fechaReseña.CompareTo(fechaDesde);
            int comp_sup = fechaHasta.CompareTo(reseña.fechaReseña);
            
            if (comp_inf == 1 && comp_sup == 1 )
            {
                 return  true;
            }
            else
            {
                return false;

            }

        }

 

    }
}
