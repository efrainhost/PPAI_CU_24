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
        private bool esPremium { get; set; }
        private DateTime fechaReseña { get; set; }
        private int puntaje { get; set; }

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
        public static List<Reseña> buscarReseña(Vino vino, DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Reseña> reseñasValidas = [];
            foreach (Reseña rese in vino.reseñas)
            {
                bool periodo = estasEnElPeriodo(rese, fechaDesde, fechaHasta);
                bool premium = sosPremium(rese);

                if (periodo && premium)
                {
                    reseñasValidas.Add(rese);
                }
            }
            return reseñasValidas;

        }

        private static bool sosPremium(Reseña rese)
        {
             return rese.esPremium;
        }

        private static bool estasEnElPeriodo(Reseña rese, DateTime fechaDesde, DateTime fechaHasta)
        {
          
            if (rese.fechaReseña >= fechaDesde && rese.fechaReseña <= fechaHasta)
                {
                    return true;
                }
            else
                {
                    return false;
                }    
        }

        //private static int getPuntaje(Reseña rese)
        //{
        //    return rese.puntaje;
        //}

    }
}
