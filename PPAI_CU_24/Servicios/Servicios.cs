using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_CU_24.Entidades;

namespace PPAI_CU_24.Servicios
{
    internal class Servicios
    {
        public void GeneradorVinos()
        {
            RegionVitivinicola Mendoza = new RegionVitivinicola("La región vitivinícola más grande y reconocida de Argentina, famosa por sus vinos tintos Malbec, Cabernet Sauvignon y Bonarda, así como vinos blancos como Chardonnay y Torrontés", "Mendoza");
            RegionVitivinicola SanJuan = new RegionVitivinicola("Conocida por su producción de vinos tintos y blancos de alta calidad, incluyendo Syrah, Bonarda, y Sauvignon Blanc", "San Juan");
            RegionVitivinicola Salta = new RegionVitivinicola("Destacada por sus vinos de altura, especialmente los tintos elaborados con la uva Malbec y los blancos con Torrontés", "Salta");
            RegionVitivinicola LaRioja = new RegionVitivinicola("Reconocida por sus vinos tintos, especialmente los elaborados con la uva Bonarda, Syrah y Malbec", "La Rioja");
            RegionVitivinicola Catamarca = new RegionVitivinicola("Productora de vinos tintos y blancos de alta calidad, incluyendo Malbec, Cabernet Sauvignon y Chardonnay", "Catamarca");
            RegionVitivinicola RioNegro = new RegionVitivinicola("Famosa por sus vinos blancos y espumosos, especialmente elaborados con la uva Chardonnay y Pinot Noir", "Río Negro");
            RegionVitivinicola Neuquen = new RegionVitivinicola("Conocida por sus vinos tintos, principalmente Malbec y Merlot, así como vinos blancos frescos como Sauvignon Blanc", "Neuquén");
            RegionVitivinicola LaPampa = new RegionVitivinicola("Productora de vinos tintos y blancos, destacándose por la producción de uvas como Malbec y Cabernet Sauvignon", "La Pampa");
            RegionVitivinicola Cordoba = new RegionVitivinicola("Región diversa en variedades de uva, produciendo vinos tintos y blancos de calidad", "Córdoba");
            RegionVitivinicola EntreRios = new RegionVitivinicola("Conocida por su producción de vinos blancos y rosados, especialmente con la uva Malbec y Chardonnay", "Entre Ríos");
            RegionVitivinicola SanLuis = new RegionVitivinicola("Productora de vinos tintos y blancos de calidad, con variedades como Malbec, Syrah y Sauvignon Blanc", "San Luis");
            RegionVitivinicola Tucuman = new RegionVitivinicola("Región emergente en la producción de vinos, especialmente con la uva Torrontés", "Tucumán");
            RegionVitivinicola Chubut = new RegionVitivinicola("Productora de vinos tintos y blancos, con un enfoque en variedades como Malbec, Merlot y Sauvignon Blanc", "Chubut");
            RegionVitivinicola SantaCruz = new RegionVitivinicola("Destacada por su producción de vinos tintos, principalmente con la uva Malbec y Merlot", "Santa Cruz");
            RegionVitivinicola SantiagoDelEstero = new RegionVitivinicola("Región con potencial en la producción de vinos tintos y blancos, especialmente con uvas como Malbec y Chardonnay", "Santiago del Estero");
            RegionVitivinicola Formosa = new RegionVitivinicola("Aunque no es una región vitivinícola principal, cuenta con viñedos que producen vinos locales", "Formosa");
            RegionVitivinicola Misiones = new RegionVitivinicola("Conocida por su producción de vinos tropicales, como el vino de naranja y otras frutas", "Misiones");
            RegionVitivinicola Corrientes = new RegionVitivinicola("Aunque no es una región vitivinícola destacada, cuenta con algunas producciones de vinos locales", "Corrientes");
            RegionVitivinicola Jujuy = new RegionVitivinicola("Región en crecimiento en la producción de vinos de altura, especialmente tintos y blancos frescos", "Jujuy");
            RegionVitivinicola SantaFe = new RegionVitivinicola("Si bien no es una región vitivinícola principal, tiene algunos viñedos que producen vinos locales", "Santa Fe");

            Bodega CatenaZapata = new Bodega("Catena Zapata", Mendoza);
            Bodega Graffigna = new Bodega("Graffigna", SanJuan);
            Bodega Colome = new Bodega("Colomé", Salta);
            Bodega LaRiojaAlta = new Bodega("La Rioja Alta", LaRioja);
            Bodega ElEsteco = new Bodega("El Esteco", Catamarca);
            Bodega HumbertoCanale = new Bodega("Humberto Canale", RioNegro);
            Bodega DelFinDelMundo = new Bodega("Del Fin del Mundo", Neuquen);
            Bodega Chacra = new Bodega("Chacra", LaPampa);
            Bodega LasPerdices = new Bodega("Las Perdices", Cordoba);
            Bodega Malabrigo = new Bodega("Malabrigo", EntreRios);
            Bodega EstanciaMendoza = new Bodega("Estancia Mendoza", SanLuis);
            Bodega SantaJulia = new Bodega("Santa Julia", Tucuman);
            Bodega Ruta40 = new Bodega("Ruta 40", Chubut);
            Bodega PatagoniaWines = new Bodega("Patagonia Wines", SantaCruz);
            Bodega SantiagoGraffigna = new Bodega("Santiago Graffigna", SantiagoDelEstero);
            Bodega VirgenDelSol = new Bodega("Virgen del Sol", Formosa);
            Bodega MissionesVineyard = new Bodega("Missiones Vineyard", Misiones);
            Bodega IberaValley = new Bodega("Iberá Valley", Corrientes);
            Bodega FincaLaPaya = new Bodega("Finca La Paya", Jujuy);
            Bodega LaPampaWines = new Bodega("La Pampa Wines", SantaFe);

        }
    }
}
