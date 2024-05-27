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
            Pais Argentina = new Pais("Argentina");

            Provincia BuenosAires = new Provincia("Buenos Aires", [], Argentina);
            Provincia Catamarca = new Provincia("Catamarca", [], Argentina);
            Provincia Chaco = new Provincia("Chaco", [], Argentina);
            Provincia Chubut = new Provincia("Chubut", [], Argentina);
            Provincia Cordoba = new Provincia("Cordoba", [], Argentina);
            Provincia Corrientes = new Provincia("Corrientes", [], Argentina);
            Provincia EntreRios = new Provincia("Entre Rios", [], Argentina);
            Provincia Formosa = new Provincia("Formosa", [], Argentina);
            Provincia Jujuy = new Provincia("Jujuy", [], Argentina);
            Provincia LaPampa = new Provincia("La Pampa", [RegionLaPampa], Argentina);
            Provincia LaRioja = new Provincia("La Rioja", [], Argentina);
            Provincia Mendoza = new Provincia("Mendoza", [ZonaEsteMendoza], Argentina);
            Provincia Misiones = new Provincia("Misiones", [], Argentina);
            Provincia Neuquen = new Provincia("Neuquen", [RegionNeuquen], Argentina);
            Provincia RioNegro = new Provincia("Rio Negro", [RegionRioNegro, RegionPatagonia], Argentina);
            Provincia Salta = new Provincia("Salta", [], Argentina);
            Provincia SanJuan = new Provincia("San Juan", [RegionSanJuan], Argentina);
            Provincia SanLuis = new Provincia("San Luis", [], Argentina);
            Provincia SantaCruz = new Provincia("Santa Cruz", [], Argentina);
            Provincia SantaFe = new Provincia("Santa Fe", [], Argentina);
            Provincia SantiagoDelEstero = new Provincia("Santiago del Estero", [], Argentina);
            Provincia TierraDelFuego = new Provincia("Tierra del Fuego", [], Argentina);
            Provincia Tucuman = new Provincia("Tucuman", [], Argentina);


            RegionVitivinicola RegionLaPampa = new RegionVitivinicola("Esta región se encuentra en el centro de Argentina y es conocida por su clima semiárido, ideal para el cultivo de uvas", "RegionLaPampa", LaPampa);
            RegionVitivinicola RegionNeuquen = new RegionVitivinicola("Su clima fresco y sus suelos volcánicos contribuyen a la singularidad de sus vinos.", "RegionNeuquen", Neuquen);
            RegionVitivinicola RegionRioNegro = new RegionVitivinicola("Sus condiciones climáticas únicas, con amplitudes térmicas marcadas, aportan complejidad a sus vinos.", "RegionRioNegro", RioNegro);
            RegionVitivinicola RegionPatagonia = new RegionVitivinicola("Los vinos de la Patagonia suelen ser elegantes, con una acidez notable y sabores frutales intensos.", "RegionPatagonia", RioNegro);
            RegionVitivinicola ZonaEsteMendoza = new RegionVitivinicola(" La zona Este se distingue por su diversidad de suelos y microclimas, dando lugar a vinos varietales excepcionales.", "ZonaEsteMendoza", Mendoza);
            RegionVitivinicola RegionSanJuan = new RegionVitivinicola("Sus viñedos se benefician de la radiación solar intensa y las condiciones áridas que favorecen la calidad de las uvas.", "RegionSanJuan", SanJuan);
            
       

            
           

            Bodega CatenaZapata = new Bodega("Catena Zapata", ZonaEsteMendoza);
            Bodega Graffigna = new Bodega("Graffigna", RegionSanJuan);
            Bodega Colome = new Bodega("Colomé", RegionPatagonia);
            Bodega LaRiojaAlta = new Bodega("La Rioja Alta", RegionPatagonia);
            Bodega ElEsteco = new Bodega("El Esteco", RegionNeuquen);
            Bodega HumbertoCanale = new Bodega("Humberto Canale", RegionRioNegro);
            Bodega DelFinDelMundo = new Bodega("Del Fin del Mundo", RegionNeuquen);
            Bodega Chacra = new Bodega("Chacra", RegionLaPampa);
            Bodega LasPerdices = new Bodega("Las Perdices", ZonaEsteMendoza);
            Bodega Malabrigo = new Bodega("Malabrigo", RegionSanJuan);
            Bodega EstanciaMendoza = new Bodega("Estancia Mendoza", ZonaEsteMendoza);
            Bodega SantaJulia = new Bodega("Santa Julia", RegionPatagonia);
            Bodega Ruta40 = new Bodega("Ruta 40", RegionPatagonia);
            Bodega PatagoniaWines = new Bodega("Patagonia Wines", RegionPatagonia);
            Bodega SantiagoGraffigna = new Bodega("Santiago Graffigna", RegionNeuquen);
            Bodega VirgenDelSol = new Bodega("Virgen del Sol", RegionNeuquen);
            Bodega MissionesVineyard = new Bodega("Missiones Vineyard", RegionSanJuan);
            Bodega IberaValley = new Bodega("Iberá Valley", RegionRioNegro);
            Bodega FincaLaPaya = new Bodega("Finca La Paya", RegionPatagonia);
            Bodega LaPampaWines = new Bodega("La Pampa Wines", RegionLaPampa);

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
