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
            // Nueva instancia Pais
            Pais Argentina = new Pais("Argentina");

            // Nuevas instancias Provincias
            Provincia BuenosAires = new Provincia("Buenos Aires", Argentina);
            Provincia Catamarca = new Provincia("Catamarca", Argentina);
            Provincia Chaco = new Provincia("Chaco", Argentina);
            Provincia Chubut = new Provincia("Chubut", Argentina);
            Provincia Cordoba = new Provincia("Cordoba", Argentina);
            Provincia Corrientes = new Provincia("Corrientes", Argentina);
            Provincia EntreRios = new Provincia("Entre Rios", Argentina);
            Provincia Formosa = new Provincia("Formosa", Argentina);
            Provincia Jujuy = new Provincia("Jujuy", Argentina);
            Provincia LaPampa = new Provincia("La Pampa", Argentina);
            Provincia LaRioja = new Provincia("La Rioja", Argentina);
            Provincia Mendoza = new Provincia("Mendoza", Argentina);
            Provincia Misiones = new Provincia("Misiones", Argentina);
            Provincia Neuquen = new Provincia("Neuquen",  Argentina);
            Provincia RioNegro = new Provincia("Rio Negro", Argentina);
            Provincia Salta = new Provincia("Salta",  Argentina);
            Provincia SanJuan = new Provincia("San Juan",  Argentina);
            Provincia SanLuis = new Provincia("San Luis", Argentina);
            Provincia SantaCruz = new Provincia("Santa Cruz",  Argentina);
            Provincia SantaFe = new Provincia("Santa Fe", Argentina);
            Provincia SantiagoDelEstero = new Provincia("Santiago del Estero", Argentina);
            Provincia TierraDelFuego = new Provincia("Tierra del Fuego",  Argentina);
            Provincia Tucuman = new Provincia("Tucuman",  Argentina);

            // Nuevas instancias Regiones
            RegionVitivinicola RegionLaPampa = new RegionVitivinicola("Esta región se encuentra en el centro de Argentina y es conocida por su clima semiárido, ideal para el cultivo de uvas", "RegionLaPampa", LaPampa);
            RegionVitivinicola RegionNeuquen = new RegionVitivinicola("Su clima fresco y sus suelos volcánicos contribuyen a la singularidad de sus vinos.", "RegionNeuquen", Neuquen);
            RegionVitivinicola RegionRioNegro = new RegionVitivinicola("Sus condiciones climáticas únicas, con amplitudes térmicas marcadas, aportan complejidad a sus vinos.", "RegionRioNegro", RioNegro);
            RegionVitivinicola RegionPatagonia = new RegionVitivinicola("Los vinos de la Patagonia suelen ser elegantes, con una acidez notable y sabores frutales intensos.", "RegionPatagonia", RioNegro);
            RegionVitivinicola ZonaEsteMendoza = new RegionVitivinicola(" La zona Este se distingue por su diversidad de suelos y microclimas, dando lugar a vinos varietales excepcionales.", "ZonaEsteMendoza", Mendoza);
            RegionVitivinicola RegionSanJuan = new RegionVitivinicola("Sus viñedos se benefician de la radiación solar intensa y las condiciones áridas que favorecen la calidad de las uvas.", "RegionSanJuan", SanJuan);
            
            // Nuevas instancias de Bodega
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

            // Nuevas instancias de varietal
            Varietal Merlot = new Varietal("80% Uva merlot");
            Varietal CabernetSauvignon = new Varietal("40% Uva Cabernet Sauvignon");
            Varietal PinotNoir = new Varietal("90% Uva Pinot Noir");
            Varietal Syrah = new Varietal("70% Uva Syrah");
            Varietal Malbec = new Varietal("60% Uva Malbec");
            Varietal Chardonnay = new Varietal("80% Uva Chardonnay");
            Varietal SauvignonBlanc = new Varietal("90% Uva Sauvignon Blanc");
            Varietal Riesling = new Varietal("70% Uva SyrahRiesling");
            Varietal Tempranillo = new Varietal("80% Uva Tempranillo");
            Varietal Sangiovese = new Varietal("Sangiovese");
            Varietal Zinfandel = new Varietal("80% Uva Zinfandel");
            Varietal Grenache = new Varietal("90% Uva Grenache");
            Varietal Nebbiolo = new Varietal("80% Uva Nebbiolo");
            Varietal Barbera = new Varietal("90% Uva Barbera");
            Varietal Viognier = new Varietal("80% Uva Viognier");
            Varietal Gewurztraminer = new Varietal("90% Uva Gewürztraminer");
            Varietal CheninBlanc = new Varietal("90% Uva Chenin Blanc");
            Varietal Muscat = new Varietal("80% Uva Muscat");
            Varietal PetitVerdot = new Varietal("80% Uva Petit Verdot");
            Varietal Bonarda = new Varietal("70% Uva SyrahBonarda");
            Varietal Torrontes = new Varietal("80% Uva Torrontes");
            Varietal Tannat = new Varietal("70% Uva SyrahTannat");

            // Nuevas instancias de Reseña
            Reseña resUno = new Reseña(true, new DateTime (2024, 5, 28), 5);
            Reseña resDos = new Reseña(true, new DateTime(2024, 5, 28), 3);
            Reseña resTres = new Reseña(true, new DateTime(2024, 5, 28), 4);
            Reseña resCuatro = new Reseña(false, new DateTime(2024, 5, 28), 2);
            Reseña resCinco = new Reseña(true, new DateTime(2024, 5, 28), 5);
            Reseña resSeis = new Reseña(true, new DateTime(2024, 5, 28), 2);
            Reseña resSiete = new Reseña(true, new DateTime(2024, 5, 28), 1);
            Reseña resOcho = new Reseña(false, new DateTime(2024, 5, 28), 5);
            Reseña resNueve = new Reseña(true, new DateTime(2024, 5, 28), 3);
            Reseña resDiez = new Reseña(true, new DateTime(2024, 5, 27), 4);
            Reseña resOnce = new Reseña(true, new DateTime(2024, 5, 28), 2);
            Reseña resDoce = new Reseña(false, new DateTime(2024, 5, 28), 5);
            Reseña resTrece = new Reseña(true, new DateTime(2024, 5, 28), 4);
            Reseña resCatorce = new Reseña(false, new DateTime(2024, 5, 28), 3);
            Reseña resQuince = new Reseña(true, new DateTime(2024, 5, 28), 1);
            Reseña resDieciseis = new Reseña(false, new DateTime(2024, 5, 28), 5);
            Reseña resDiecisiete = new Reseña(true, new DateTime(2024, 5, 28), 3);
            Reseña resDieciocho = new Reseña(false, new DateTime(2024, 2, 28), 4);
            Reseña resDiecinueve = new Reseña(true, new DateTime(2024, 2, 29), 2);
            Reseña resVeinte = new Reseña(true, new DateTime(2024, 5, 29), 3);
            Reseña resVeintiuno = new Reseña(true, new DateTime(2024, 2, 29), 4);
            Reseña resVeintidos = new Reseña(true, new DateTime(2024, 2, 29), 2);
            Reseña resVeintitres = new Reseña(true, new DateTime(2024, 2, 29), 1);
            Reseña resVeinticuatro = new Reseña(false, new DateTime(2024, 2, 29), 5);
            Reseña resVeinticinco = new Reseña(true, new DateTime(2024, 2, 28), 3);
            Reseña resVeintiseis = new Reseña(false, new DateTime(2024, 2, 29), 4);
            Reseña resVeintisiete = new Reseña(true, new DateTime(2024, 2, 21), 2);
            Reseña resVeintiocho = new Reseña(false, new DateTime(2024, 2, 22), 3);
            Reseña resVeintinueve = new Reseña(true, new DateTime(2024, 2, 23), 4);
            Reseña resTreinta = new Reseña(false, new DateTime(2024, 2, 24), 1);
            Reseña resTreintiuno = new Reseña(true, new DateTime(2024, 2, 24), 3);

            // Nuevas instancias de vino
            Vino LasPerdicesMalbec = new Vino("Las Perdices Malbec", 1300, LasPerdices, [Malbec, CabernetSauvignon], [resUno, resDos]);
            Vino GraffignaCentenarioMalbec = new Vino("Graffigna Centenario Malbec", 1500, Graffigna, [Malbec], [resTres, resCuatro]);
            Vino ColomeEstateMalbec = new Vino("Colomé Estate Malbec", 1600, Colome, [Malbec], [resCinco, resSeis]);
            Vino LaRiojaAltaVinaArdanzaReserva = new Vino("La Rioja Alta Viña Ardanza Reserva", 1800, LaRiojaAlta, [Barbera], [resSiete, resOcho]);
            Vino ElEstecoDonDavidMalbec = new Vino("El Esteco Don David Malbec", 1700,ElEsteco, [Malbec], [resNueve,resDiez]);
            Vino HumbertoCanaleOldVineMalbec = new Vino("Humberto Canale Old Vine Malbec", 1800, HumbertoCanale, [Malbec], [resOnce, resDoce]);
            Vino DelFinDelMundoGranReservaMalbec = new Vino("Del Fin del Mundo Gran Reserva Malbec", 1900, DelFinDelMundo, [Malbec], [resTrece, resCatorce]);
            Vino ChacraPinotNoir = new Vino("Chacra Pinot Noir", 2200, Chacra, [PinotNoir], [resQuince, resDieciseis]);
            Vino MalabrigoSyrah = new Vino("Malabrigo Syrah", 1400, Malabrigo, [Syrah], [resDiecisiete, resDieciocho]);
            Vino EstanciaMendozaCabernetSauvignon = new Vino("Estancia Mendoza Cabernet Sauvignon", 1600, EstanciaMendoza, [CabernetSauvignon], [resDiecinueve, resVeinte]);
            Vino SantaJuliaReservaMalbec = new Vino("Santa Julia Reserva Malbec", 1200, SantaJulia, [Malbec], [resVeintiuno]);
            Vino Ruta40Malbec = new Vino("Ruta 40 Malbec", 1500, Ruta40, [Malbec], [resVeintidos]);
            Vino PatagoniaWinesMerlot = new Vino("Patagonia Wines Merlot", 1700, PatagoniaWines, [Merlot], [resVeintitres]);
            Vino SantiagoGraffignaCabernetSauvignon = new Vino("Santiago Graffigna Cabernet Sauvignon", 1400, Graffigna, [CabernetSauvignon], [resVeinticuatro]);
            Vino VirgenDelSolTorrontes = new Vino("Virgen del Sol Torrontés", 1100, VirgenDelSol, [Torrontes], [resVeinticinco]);
            Vino MisionesVineyardTannat = new Vino("Missiones Vineyard Tannat", 1300, MissionesVineyard, [Tannat], [resVeintiseis]);
            Vino IberaValleyMalbec = new Vino("Iberá Valley Malbec", 1600, IberaValley, [Malbec], [resVeintisiete]);
            Vino FincaLaPayaBonarda = new Vino("Finca La Paya Bonarda", 1200, FincaLaPaya, [Bonarda], [resVeintiocho]);
            Vino LaPampaWinesChardonnay = new Vino("La Pampa Wines Chardonnay", 1400, LaPampaWines, [Chardonnay], [resVeintinueve]);
            Vino EstanciaPatagonicaMalbec = new Vino("Estancia Patagónica Malbec", 1400, EstanciaMendoza, [Malbec], [resTreinta]);
            Vino TierraDelSolCabernetSauvignon = new Vino("Tierra del Sol Cabernet Sauvignon", 1500, VirgenDelSol, [CabernetSauvignon], [resTreintiuno]);

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
