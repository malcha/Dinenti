using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.DataLoad
{
    public class ClouthDataLoader
    {
        public static IEnumerable<Models.Clouth> Data()
        {
            var list = new List<Models.Clouth>();
            list.AddRange(DataLoadMiniBebaBebe());
            list.AddRange(DataLoadBeba());
            list.AddRange(DataLoadBebe());
            list.AddRange(DataLoadNena());
            list.AddRange(DataLoadVaron());

            return list;
        }

        public static IEnumerable<Models.Clouth> DataLoadMiniBebaBebe()
        {
            var list = new List<Models.Clouth>();
            list.Add(new Models.Clouth(6828, "Body con cuello", "0 al 3", "Blanco - Chicle", Models.Clouth.SUBCATEGORY.BODY, Models.Clouth.CATEGORY.MINIBEBES, "BodyEnteritos"));
            list.Add(new Models.Clouth(6834, "Enterito piel", "0 al 2", "Crudo - Rojo - Rosa - Salmon", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.MINIBEBES, "BodyEnteritos"));
            list.Add(new Models.Clouth(6835, "Enterito frisa", "0 al 2", "Fucsia - Aero - Petroleo", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.MINIBEBES, "BodyEnteritos"));

            //CAMPERAS
            list.Add(new Models.Clouth(6830, "Campera plush rayada", "0 al 3", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.MINIBEBES, "CamperasAbrigos"));
            list.Add(new Models.Clouth(6831, "Campera micropolar", "0 al 3", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.MINIBEBES, "CamperasAbrigos"));
            list.Add(new Models.Clouth(6832, "Campera micropolar", "0 al 3", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.MINIBEBES, "CamperasAbrigos"));

            //Enteritos
            list.Add(new Models.Clouth(6888, "Enterito astronauta", "1 al 3", "Rojo - Francia - Fucsia - Plata - Marino", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.MINIBEBES, "CamperasAbrigos"));
            list.Add(new Models.Clouth(6889, "Enterito astronauta estampado", "1 al 3", "", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.MINIBEBES, "CamperasAbrigos"));

            return list;
        }


        public static IEnumerable<Models.Clouth> DataLoadBeba()
        {
            var list = new List<Models.Clouth>();
            list.Add(new Models.Clouth(6801, "Remera", "1 al 6", "Blanco - Natural - Chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, "Remeras"));
            list.Add(new Models.Clouth(6802, "Remera con encaje", "1 al 6", "Blanco - Natural - Chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, "Remeras"));
            list.Add(new Models.Clouth(6803, "Remerón estampado", "1 al 6", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, "Remeras"));


            //PAnTAlon
            list.Add(new Models.Clouth(6805, "Calza lanilla", "1 al 6", "Fucsia - Negro", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.BEBAS, "PantalonesCalzas"));
            list.Add(new Models.Clouth(6807, "Calza rústica elastizada", "1 al 6", "Fucsia - Topo - Negro", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.BEBAS, "PantalonesCalzas"));
            list.Add(new Models.Clouth(6808, "Calza lanilla estampada", "1 al 6", "", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.BEBAS, "PantalonesCalzas"));
            list.Add(new Models.Clouth(6809, "Calza estampada", "1 al 6", "", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.BEBAS, "PantalonesCalzas"));
            list.Add(new Models.Clouth(6806, "Pantalón simil jean", "1 al 6", "Azul - Bordeaux - Negro", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS, "PantalonesCalzas"));
            list.Add(new Models.Clouth(6810, "Pantalón gabardina", "1 al 6", "ROSA VIEJO - FUCSIA - CEREZA", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS, "PantalonesCalzas"));
            list.Add(new Models.Clouth(6811, "Pantalón estampado", "1 al 6", "Fucsia - Negro", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS, "PantalonesCalzas"));
            list.Add(new Models.Clouth(6818, "Pantalón jogging", "1 al 6", "Fucsia - Guinda - Gris", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS, "PantalonesCalzas"));

            //Buzos camperas
            list.Add(new Models.Clouth(6816, "Buzo con volado", "1 al 6", "Fucsia - Guinda - Gris", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBAS, "BuzosCamperas"));
            list.Add(new Models.Clouth(6817, "Buzo con encaje", "1 al 6", "Fucsia - Guinda - Gris", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBAS, "BuzosCamperas"));
            list.Add(new Models.Clouth(6819, "Campera de frisa con capucha", "1 al 6", "Fucsia - Guinda - Gris", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBAS, "BuzosCamperas"));
            list.Add(new Models.Clouth(6820, "Campera de frisa estampada", "1 al 6", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS, "BuzosCamperas"));
            list.Add(new Models.Clouth(6821, "Campera plush", "1 al 6", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS, "BuzosCamperas"));
            list.Add(new Models.Clouth(6823, "Tapado de frisa", "1 al 6", "Fucsia - Guinda - Gris", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS, "BuzosCamperas"));


            //Jumper vestido
            list.Add(new Models.Clouth(6824, "Jumper de corderoy", "1 al 6", "Fucsia - Guinda", Models.Clouth.SUBCATEGORY.JUMPER, Models.Clouth.CATEGORY.BEBAS, "VestidosJumpers"));
            list.Add(new Models.Clouth(6825, "Vestido fibrana", "1 al 6", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS, "VestidosJumpers"));
            list.Add(new Models.Clouth(6812, "Vestido con flor", "1 al 6", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS, "VestidosJumpers"));
            list.Add(new Models.Clouth(6813, "Vestido estampado", "1 al 6", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS, "VestidosJumpers"));
            list.Add(new Models.Clouth(6804, "Vestido con puntilla", "1 al 6", "Chicle - Blanco - Natural", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS, "VestidosJumpers"));
            
            //Abrigos
            list.Add(new Models.Clouth(6826, "Campera piel", "1 al 6", "Natural - Chicle - Rojo - Salmón", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.BEBAS, "Abrigos"));
            list.Add(new Models.Clouth(6896, "Tapado con moños", "1 al 6", "Fucsia - Rojo - Plata", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.BEBAS, "Abrigos"));
            list.Add(new Models.Clouth(6901, "Campera conpuños", "1 al 6", "Fucsia - Rojo", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.BEBAS, "Abrigos"));
            list.Add(new Models.Clouth(6890, "Chaleco", "1 al 6", "Fucsia - Rojo - Plata", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.BEBAS, "Abrigos"));
            list.Add(new Models.Clouth(6895, "Campera estampada", "1 al 6", "Estrellas - Flores", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.BEBAS, "Abrigos"));

            return list;
        }


        //Petróleo
        //SALMón
        public static IEnumerable<Models.Clouth> DataLoadBebe()
        {
            var list = new List<Models.Clouth>();
            //REMERA CAMISA
            list.Add(new Models.Clouth(6856, "Remera combinada", "1 al 6", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, "remerascamisas"));
            list.Add(new Models.Clouth(6857, "Remera sobrepuesta", "1 al 6", "Bordeaux - Francia - Topo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, "remerascamisas"));
            list.Add(new Models.Clouth(6858, "Remera rayada", "1 al 6", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, "remerascamisas"));
            list.Add(new Models.Clouth(6860, "Camisa escocesa", "1 al 6", "", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.BEBES, "remerascamisas"));
            list.Add(new Models.Clouth(6861, "Camisa escocesa", "1 al 6", "", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.BEBES, "remerascamisas"));
            list.Add(new Models.Clouth(6862, "Camisa de jean", "1 al 6", "", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.BEBES, "remerascamisas"));

            //BUZO y campera
            list.Add(new Models.Clouth(6863, "Buzo combinado", "1 al 6", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBES, "BuzosCamperas"));
            list.Add(new Models.Clouth(6864, "Buzo con capucha", "1 al 6", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBES, "BuzosCamperas"));
            list.Add(new Models.Clouth(6865, "Buzo con cartera", "1 al 6", "Petróleo - Aero - Gris", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBES, "BuzosCamperas"));
            list.Add(new Models.Clouth(6869, "Campera universitaria", "1 al 6", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBES, "BuzosCamperas"));
            list.Add(new Models.Clouth(6859, "Campera de frisa", "1 al 6", "Petróleo - Aero - Gris", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBES, "BuzosCamperas"));

            //Pantalon
            list.Add(new Models.Clouth(6872, "Pantalón chupín", "1 al 6", "Uva - Petróleo - Bordeaux", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBES, "Pantalones"));
            list.Add(new Models.Clouth(6870, "Pantalón de frisa", "1 al 6", "Petróleo - Aero - Gris", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBES, "Pantalones"));

            //Abrigos
            list.Add(new Models.Clouth(6901, "Campera con puños", "1 al 6", "Francia - Marino - Rojo", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.BEBES, "Abrigos"));
            list.Add(new Models.Clouth(6902, "Campera combinada", "1 al 6", "", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.BEBES, "Abrigos"));
            list.Add(new Models.Clouth(6891, "Chaleco combinado", "1 al 6", "", Models.Clouth.SUBCATEGORY.CHALECOS, Models.Clouth.CATEGORY.BEBES, "Abrigos"));
            
            return list;
        }


        public static IEnumerable<Models.Clouth> DataLoadNena()
        {
            var list = new List<Models.Clouth>();
            //REMERA CAMISA
            list.Add(new Models.Clouth(6836, "Remera corazones", "4 al 14", "Rosa viejo - Blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, "remerascamisas"));
            list.Add(new Models.Clouth(6837, "Remera con encaje", "4 al 14", "Blanco - Natural - Chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, "remerascamisas"));
            list.Add(new Models.Clouth(6838, "Remera encaje hombros", "4 al 14", "Blanco - Natural - Chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, "remerascamisas"));

            //Calzas pantalones
            list.Add(new Models.Clouth(6840, "Calza lanilla estampada", "4 al 14", "Fucsia - Violeta", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.NENA, "pantalonescalzas"));
            list.Add(new Models.Clouth(6848, "Calza lanilla", "4 al 14", "Fucsia - Negro", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.NENA, "pantalonescalzas"));
            list.Add(new Models.Clouth(6846, "Pantalón simil jean", "4 al 14", "Azul - Negro - Bordeaux", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.NENA, "pantalonescalzas"));
            list.Add(new Models.Clouth(6841, "Pantalón", "4 al 14", "Fucsia - Guinda - Gris", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.NENA, "pantalonescalzas"));
            list.Add(new Models.Clouth(6844, "Pantalón  estampado", "4 al 14", "", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.NENA, "pantalonescalzas"));
            list.Add(new Models.Clouth(6845, "Pantalón  rústico", "4 al 14", "Fucsia - Topo - Negro", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.NENA, "pantalonescalzas"));

            //Vestido
            list.Add(new Models.Clouth(6849, "Vestido lanilla", "4 al 14", "Fucsia - Violeta", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA, "vestidos"));

            //Camisas
            list.Add(new Models.Clouth(6842, "Camisa de jean", "4 al 14", "", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.NENA, "remerascamisas"));
            list.Add(new Models.Clouth(6843, "Camisa escocesa", "4 al 14", "", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.NENA, "remerascamisas"));

            //Buzo Camperas
            list.Add(new Models.Clouth(6852, "Buzo con puntilla", "4 al 14", "Fucsia - Guinda - Gris", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.NENA, "camperasbuzos"));
            list.Add(new Models.Clouth(6851, "Campera de frisa", "4 al 14", "Fucsia - Guinda - Gris", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.NENA, "camperasbuzos"));
            list.Add(new Models.Clouth(6854, "Campera con piel", "4 al 14", "Fucsia - Guinda - Gris", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.NENA, "camperasbuzos"));
            list.Add(new Models.Clouth(6855, "Campera de frisa estampada", "4 al 14", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.NENA, "camperasbuzos"));
            list.Add(new Models.Clouth(6847, "Campera universitaria", "4 al 14", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.NENA, "camperasbuzos"));

            //Abrigos
            list.Add(new Models.Clouth(6893, "Chaleco", "4 al 14", "Fucsia - Rojo - Plata", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.NENA, "abrigos"));
            list.Add(new Models.Clouth(6898, "Campera", "4 al 14", "Fucsia - Rojo - Violeta", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.NENA, "abrigos"));
            list.Add(new Models.Clouth(6899, "Campera estampada", "4 al 14", "", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.NENA, "abrigos"));
            list.Add(new Models.Clouth(6900, "Tapado", "4 al 14", "Fucsia - Rojo", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.NENA, "abrigos"));
            list.Add(new Models.Clouth(6850, "Chaleco de piel", "4 al 14", "Negro - Beige", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.NENA, "abrigos"));
            return list;
        }

        public static IEnumerable<Models.Clouth> DataLoadVaron()
        {
            var list = new List<Models.Clouth>();
            //REMERA CAMISA
            list.Add(new Models.Clouth(6873, "Remera con chapitas", "4 al 14", "Azul - Topo - Bordeaux", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, "remerascamisas"));
            list.Add(new Models.Clouth(6874, "Remera con cartera", "4 al 14", "Azul - Topo - Bordeaux", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, "remerascamisas"));
            list.Add(new Models.Clouth(6884, "Camisa escocesa", "4 al 14", "", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.VARON, "remerascamisas"));
            list.Add(new Models.Clouth(6885, "Camisa escocesa", "4 al 14", "", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.VARON, "remerascamisas"));

            //Buzo camperas y sacos
            list.Add(new Models.Clouth(6876, "Buzo con gamuza", "4 al 14", "Gris - Petróleo - Bordeaux", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.VARON, "camperasbuzos"));
            list.Add(new Models.Clouth(6877, "Buzo combinado", "4 al 14", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.VARON, "camperasbuzos"));
            list.Add(new Models.Clouth(6878, "Buzo con capucha", "4 al 14", "Topo - Francia", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.VARON, "camperasbuzos"));
            list.Add(new Models.Clouth(6879, "Campera", "4 al 14", "Topo - Francia", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.VARON, "camperasbuzos"));
            list.Add(new Models.Clouth(6880, "Saco 4 bolsillos", "4 al 14", "Topo - Petróleo - Francia", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.VARON, "camperasbuzos"));
            list.Add(new Models.Clouth(6881, "Campera universitaria", "4 al 14", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.VARON, "camperasbuzos"));


            //Pantalon
            list.Add(new Models.Clouth(6883, "Pantalón de frisa sin puño", "4 al 14", "Negro - Topo - Petróleo", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.VARON, "Pantalones"));
            list.Add(new Models.Clouth(6882, "Pantalón de frisa", "4 al 14", "Topo - Petróleo - Bordeaux - Gris - Negro", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.VARON, "Pantalones"));
            list.Add(new Models.Clouth(6887, "Pantalón chupín", "4 al 14", "Petróleo - Bordeaux - Uva - Negro", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.VARON, "Pantalones"));


            //Abrigos
            list.Add(new Models.Clouth(6894, "Chaleco", "4 al 14", "Azul - Gris - Negro", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.VARON, "Abrigos"));
            list.Add(new Models.Clouth(6904, "Campera", "4 al 14", "Negro con Gris y Rojo", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.VARON, "Abrigos"));
            list.Add(new Models.Clouth(6903, "Campera con puños", "4 al 14", "Negro - Marino - Francia - Rojo", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.VARON, "Abrigos"));
            
            return list;
        }

    }
}