using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_CU_24.Entidades;

namespace PPAI_CU_24.Servicios
{
    public class Servicios
    {
        public  static List<Vino> GeneradorVinos()
        {
            
            
            
            
            RegionVitivinicola Mendoza = new RegionVitivinicola("La región vitivinícola más grande y reconocida de Argentina, famosa por sus vinos tintos Malbec, Cabernet Sauvignon y Bonarda, así como vinos blancos como Chardonnay y Torrontés", "Mendoza",);
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

            Varietal UvaMerlot = new Varietal("Merlot");
            Varietal UvaCabernetSauvignon = new Varietal("Cabernet Sauvignon");
            Varietal UvaPinotNoir = new Varietal("Pinot Noir");
            Varietal UvaSyrah = new Varietal("Syrah");
            Varietal UvaMalbec = new Varietal("Malbec");
            Varietal UvaChardonnay = new Varietal("Chardonnay");
            Varietal UvaSauvignonBlanc = new Varietal("Sauvignon Blanc");
            Varietal UvaRiesling = new Varietal("Riesling");
            Varietal UvaTempranillo = new Varietal("Tempranillo");
            Varietal UvaSangiovese = new Varietal("Sangiovese");
            Varietal UvaZinfandel = new Varietal("Zinfandel");
            Varietal UvaGrenache = new Varietal("Grenache");
            Varietal UvaNebbiolo = new Varietal("Nebbiolo");
            Varietal UvaBarbera = new Varietal("Barbera");
            Varietal UvaViognier = new Varietal("Viognier");
            Varietal UvaGewurztraminer = new Varietal("Gewürztraminer");
            Varietal UvaCheninBlanc = new Varietal("Chenin Blanc");
            Varietal UvaMuscat = new Varietal("Muscat");
            Varietal UvaPetitVerdot = new Varietal("Petit Verdot");
            Varietal UvaBonarda = new Varietal("Bonarda");
            Varietal UvaTorrontes = new Varietal("Torrontes");
            Varietal UvaTannat = new Varietal("Tannat");

            Reseña resUno = new Reseña(true, new DateTime (2024, 2, 3), 5);
            Reseña resDos = new Reseña(false, new DateTime(2024, 6, 3), 3);
            Reseña resTres = new Reseña(true, new DateTime(2024, 2, 4), 4);
            Reseña resCuatro = new Reseña(false, new DateTime(2024, 8, 10), 2);
            Reseña resCinco = new Reseña(true, new DateTime(2024, 2, 5), 5);
            Reseña resSeis = new Reseña(false, new DateTime(2024, 9, 20), 2);
            Reseña resSiete = new Reseña(true, new DateTime(2024, 2, 2), 1);
            Reseña resOcho = new Reseña(false, new DateTime(2024, 2, 3), 5);
            Reseña resNueve = new Reseña(true, new DateTime(2024, 2, 6), 3);
            Reseña resDiez = new Reseña(false, new DateTime(2024, 6, 5), 4);
            Reseña resOnce = new Reseña(true, new DateTime(2024, 2, 7), 2);
            Reseña resDoce = new Reseña(false, new DateTime(2024, 8, 12), 5);
            Reseña resTrece = new Reseña(true, new DateTime(2024, 2, 8), 4);
            Reseña resCatorce = new Reseña(false, new DateTime(2024, 9, 25), 3);
            Reseña resQuince = new Reseña(true, new DateTime(2024, 2, 9), 1);
            Reseña resDieciseis = new Reseña(false, new DateTime(2024, 2, 10), 5);
            Reseña resDiecisiete = new Reseña(true, new DateTime(2024, 2, 11), 3);
            Reseña resDieciocho = new Reseña(false, new DateTime(2024, 2, 12), 4);
            Reseña resDiecinueve = new Reseña(true, new DateTime(2024, 2, 13), 2);
            Reseña resVeinte = new Reseña(false, new DateTime(2024, 2, 14), 3);
            Reseña resVeintiuno = new Reseña(true, new DateTime(2024, 2, 15), 4);
            Reseña resVeintidos = new Reseña(false, new DateTime(2024, 2, 16), 2);
            Reseña resVeintitres = new Reseña(true, new DateTime(2024, 2, 17), 1);
            Reseña resVeinticuatro = new Reseña(false, new DateTime(2024, 2, 18), 5);
            Reseña resVeinticinco = new Reseña(true, new DateTime(2024, 2, 19), 3);
            Reseña resVeintiseis = new Reseña(false, new DateTime(2024, 2, 20), 4);
            Reseña resVeintisiete = new Reseña(true, new DateTime(2024, 2, 21), 2);
            Reseña resVeintiocho = new Reseña(false, new DateTime(2024, 2, 22), 3);
            Reseña resVeintinueve = new Reseña(true, new DateTime(2024, 2, 23), 4);
            Reseña resTreinta = new Reseña(false, new DateTime(2024, 2, 24), 1);
            Reseña resTreintiuno = new Reseña(true, new DateTime(2024, 2, 24), 3);



            Vino LasPerdicesMalbec = new Vino("Las Perdices Malbec", 1300, LasPerdices, [UvaMalbec, UvaCabernetSauvignon, UvaBonarda], [resUno, resDos]);
            Vino GraffignaCentenarioMalbec = new Vino("Graffigna Centenario Malbec", 1500, Graffigna, [UvaMalbec], [resTres, resCuatro]);
            Vino ColomeEstateMalbec = new Vino("Colomé Estate Malbec", 1600, Colome, [UvaMalbec], [resCinco, resSeis]);
            Vino LaRiojaAltaVinaArdanzaReserva = new Vino("La Rioja Alta Viña Ardanza Reserva", 1800, LaRiojaAlta, [], [resSiete, resOcho]);
            Vino ElEstecoDonDavidMalbec = new Vino("El Esteco Don David Malbec", 1700,ElEsteco, [UvaMalbec], [resNueve,resDiez]);
            Vino HumbertoCanaleOldVineMalbec = new Vino("Humberto Canale Old Vine Malbec", 1800, HumbertoCanale, [UvaMalbec], [resOnce, resDoce]);
            Vino DelFinDelMundoGranReservaMalbec = new Vino("Del Fin del Mundo Gran Reserva Malbec", 1900, DelFinDelMundo, [UvaMalbec], [resTrece, resCatorce]);
            Vino ChacraPinotNoir = new Vino("Chacra Pinot Noir", 2200, Chacra, [UvaPinotNoir], [resQuince, resDieciseis]);
            Vino MalabrigoSyrah = new Vino("Malabrigo Syrah", 1400, Malabrigo, [UvaSyrah], [resDiecisiete, resDieciocho]);
            Vino EstanciaMendozaCabernetSauvignon = new Vino("Estancia Mendoza Cabernet Sauvignon", 1600, EstanciaMendoza, [UvaCabernetSauvignon], [resDiecinueve, resVeinte]);
            Vino SantaJuliaReservaMalbec = new Vino("Santa Julia Reserva Malbec", 1200, SantaJulia, [UvaMalbec], [resVeintiuno]);
            Vino Ruta40Malbec = new Vino("Ruta 40 Malbec", 1500, Ruta40, [UvaMalbec], [resVeintidos]);
            Vino PatagoniaWinesMerlot = new Vino("Patagonia Wines Merlot", 1700, PatagoniaWines, [UvaMerlot], [resVeintitres]);
            Vino SantiagoGraffignaCabernetSauvignon = new Vino("Santiago Graffigna Cabernet Sauvignon", 1400, Graffigna, [UvaCabernetSauvignon], [resVeinticuatro]);
            Vino VirgenDelSolTorrontes = new Vino("Virgen del Sol Torrontés", 1100, VirgenDelSol, [UvaTorrontes], [resVeinticinco]);
            Vino MisionesVineyardTannat = new Vino("Missiones Vineyard Tannat", 1300, MissionesVineyard, [UvaTannat], [resVeintiseis]);
            Vino IberaValleyMalbec = new Vino("Iberá Valley Malbec", 1600, IberaValley, [UvaMalbec], [resVeintisiete]);
            Vino FincaLaPayaBonarda = new Vino("Finca La Paya Bonarda", 1200, FincaLaPaya, [UvaBonarda], [resVeintiocho]);
            Vino LaPampaWinesChardonnay = new Vino("La Pampa Wines Chardonnay", 1400, LaPampaWines, [UvaChardonnay], [resVeintinueve]);
            Vino EstanciaPatagonicaMalbec = new Vino("Estancia Patagónica Malbec", 1400, EstanciaMendoza, [UvaMalbec], [resTreinta]);
            Vino TierraDelSolCabernetSauvignon = new Vino("Tierra del Sol Cabernet Sauvignon", 1500, VirgenDelSol, [UvaCabernetSauvignon], [resTreintiuno]);

            List<Vino> vinos = new List<Vino>();

            vinos.Add(LasPerdicesMalbec);
            vinos.Add(GraffignaCentenarioMalbec);
            vinos.Add(ColomeEstateMalbec);
            vinos.Add(LaRiojaAltaVinaArdanzaReserva);
            vinos.Add(ElEstecoDonDavidMalbec);
            vinos.Add(HumbertoCanaleOldVineMalbec);
            vinos.Add(DelFinDelMundoGranReservaMalbec);
            vinos.Add(ChacraPinotNoir);
            vinos.Add(MalabrigoSyrah);
            vinos.Add(EstanciaMendozaCabernetSauvignon);
            vinos.Add(SantaJuliaReservaMalbec);
            vinos.Add(Ruta40Malbec);
            vinos.Add(PatagoniaWinesMerlot);
            vinos.Add(SantiagoGraffignaCabernetSauvignon);
            vinos.Add(VirgenDelSolTorrontes);
            vinos.Add(MisionesVineyardTannat);
            vinos.Add(IberaValleyMalbec);
            vinos.Add(FincaLaPayaBonarda);
            vinos.Add(LaPampaWinesChardonnay);
            vinos.Add(EstanciaPatagonicaMalbec);
            vinos.Add(TierraDelSolCabernetSauvignon);

            return vinos;



        }
    }
}
