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
            list.Add(new Models.Clouth(7049, "Vestido body", "0 al 3", "Rosa con lila- Rosa con verde", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.MINIBEBES, "all"));
            list.Add(new Models.Clouth(70461, "Vestido estampado con body", "0 al 3", "Rojo - Rosa", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.MINIBEBES, "all"));
            list.Add(new Models.Clouth(7046, "Vestido liso c/body", "0 al 3", "Blanco- Natural", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.MINIBEBES, "all"));
            list.Add(new Models.Clouth(7053, "Jardinero jean unisex", "1 al 4", "", Models.Clouth.SUBCATEGORY.JUMPER, Models.Clouth.CATEGORY.MINIBEBES, "all"));
            list.Add(new Models.Clouth(7052, "Enterito escoces", "0 al 3", "Azul con rojo - Turquesa con verde - Aero con blanco", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.MINIBEBES, "all"));
            return list;
        }


        public static IEnumerable<Models.Clouth> DataLoadBeba()
        {
            var list = new List<Models.Clouth>();
            //remeras
            list.Add(new Models.Clouth(7001, "Remera con anteojos", "1 al 6", "Blanco - Natural - Salmon - Fucsia - Coral", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, "remerasremerones"));
            list.Add(new Models.Clouth(7002, "Remera ardilla ", "1 al 6", "Blanco - Natural", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, "remerasremerones"));
            list.Add(new Models.Clouth(7025, "Remera 'I saw'", "1 al 6", "Blanco - Natural - Salmon - Fucsia - Coral", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, "remerasremerones"));
            list.Add(new Models.Clouth(7003, "Remera estampada", "1 al 6", "Rosa con lila - Rosa con verde", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, "remerasremerones"));
            list.Add(new Models.Clouth(7005, "Remeron con puntilla", "1 al 6", "Blanco - Natural - Salmon - Fucsia - Coral", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, "remerasremerones"));
            list.Add(new Models.Clouth(7006, "Remeron con encaje", "1 al 6", "Blanco - Natural - Salmon - Fucsia - Coral", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, "remerasremerones"));


            //vestidos
            list.Add(new Models.Clouth(7008, "Vestido 2 volados", "1 al 6", "Estampado turquesa - Coral - Chickle", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS, "vestidos"));
            list.Add(new Models.Clouth(7009, "Vestido con flores", "1 al 6", "estampado Amarillo - Rojo", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS, "vestidos"));
            list.Add(new Models.Clouth(7010, "Vestido plumeti", "1 al 6", "Blanco - Natural", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS, "vestidos"));
            list.Add(new Models.Clouth(7011, "Vestido 4 volados", "1 al 6", "Tosa - Rojo", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS, "vestidos"));
            list.Add(new Models.Clouth(7013, "Solero con guarda", "1 al 6", "Fucsia - Azul", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS, "vestidos"));

            //Enteritos
            list.Add(new Models.Clouth(7014, "Monito con  1 volado", "1 al 6", "Rosa con lila - Rosa con verde", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.BEBAS, "enteritos"));
            list.Add(new Models.Clouth(7015, "Monito estampado", "1 al 6", "Turquesa - Coral - Chickle", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.BEBAS, "enteritos"));
            list.Add(new Models.Clouth(7017, "Monito largo fibrana", "1 al 6", "Blanco - Verde agua", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.BEBAS, "enteritos"));

            //Calzas short y pantalon
            list.Add(new Models.Clouth(7019, "Calza estampada", "1 al 6", "Turquesa - Coral - Chickle", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.BEBAS, "pantalonescalzasshorts"));
            list.Add(new Models.Clouth(7018, "Pantalón", "1 al 6", "Fucsia", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS, "pantalonescalzasshorts"));
            list.Add(new Models.Clouth(7024, "Short con volados", "1 al 6", "Blanco - Chickle - Coral", Models.Clouth.SUBCATEGORY.SHORT, Models.Clouth.CATEGORY.BEBAS, "pantalonescalzasshorts"));
            list.Add(new Models.Clouth(7026, "Short rústico estampado", "1 al 6", "Manteca - Rosa", Models.Clouth.SUBCATEGORY.SHORT, Models.Clouth.CATEGORY.BEBAS, "pantalonescalzasshorts"));


            //camperas
            list.Add(new Models.Clouth(7022, "Campera rústica estampada", "1 al 6", "Rosa - Manteca", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS, "camperas"));
            list.Add(new Models.Clouth(7023, "Campera rústica lisa", "1 al 6", "Coral - Melange - Fucsia", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS, "camperas"));
            
            //camisas
            list.Add(new Models.Clouth(7020, "Camisa plumeti", "1 al 6", "Blanca - Natural", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.BEBAS, "camisas"));
            list.Add(new Models.Clouth(7021, "Camisola estampada", "1 al 6", "Rosa - Rojo", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.BEBAS, "camisas"));

            return list;
        }

        public static IEnumerable<Models.Clouth> DataLoadBebe()
        {
            var list = new List<Models.Clouth>();
            //REMERA CAMISA
            list.Add(new Models.Clouth(7027, "Remera 'We are'", "1 al 6", "Blanco - Turquesa - Francia - Verde -Rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, "remeraschombas"));
            list.Add(new Models.Clouth(7028, "Remera triangulo", "1 al 6", "Blanco - Turquesa - Francia - Verde -Rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, "remeraschombas"));
            list.Add(new Models.Clouth(7029, "Remera tremb", "1 al 6", "Blanco - Turquesa - Francia - Verde -Rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, "remeraschombas"));
            list.Add(new Models.Clouth(7030, "Remera rayada con anteojos", "1 al 6", "Turquesa - Rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, "remeraschombas"));
            list.Add(new Models.Clouth(7031, "Chomba", "1 al 6", "Blanco - Turquesa - Francia - Verde -Rojo", Models.Clouth.SUBCATEGORY.CHOMBAS, Models.Clouth.CATEGORY.BEBES, "remeraschombas"));
            list.Add(new Models.Clouth(7033, "Camisa blanca", "1 al 6", "Blanco", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.BEBES, "remeraschombas"));
            list.Add(new Models.Clouth(7034, "Camisa escocesa", "1 al 6", "Rojo/Azul - Turquesa/Verde - Aero/Blanco", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.BEBES, "remeraschombas"));
            list.Add(new Models.Clouth(7036, "Camisa de jean", "1 al 6", "", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.BEBES, "remeraschombas"));

            //campera
            list.Add(new Models.Clouth(7044, "Ca,éra rústica", "1 al 6", "Melange - Aero", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBES, "Camperas"));

            //PANTALON - BERMUDA - SHORT BAÑO		
            list.Add(new Models.Clouth(7037, "Pantalón gabardina", "1 al 6", "Francia - Verde - Aero", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBES, "pantalonesshorts"));
            list.Add(new Models.Clouth(7039, "Bermuda gabardina", "1 al 6", "Francia - Verde - Aero", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBES, "pantalonesshorts"));
            list.Add(new Models.Clouth(7041, "Bermuda de jean", "1 al 6", "", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBES, "pantalonesshorts"));
            list.Add(new Models.Clouth(7042, "Short de baño combinado", "1 al 6", "Pescaditos turquesa/Verde - Letras Rojo/Turquesa ", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.BEBES, "pantalonesshorts"));
            list.Add(new Models.Clouth(7043, "Short de baño  estampado", "1 al 6", "Barquitos de fondo verde - Fucsia / Celeeste - Turquesa ", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.BEBES, "pantalonesshorts"));

            //Abrigos
            list.Add(new Models.Clouth(6901, "Campera con puños", "1 al 6", "Francia - Marino - Rojo", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.BEBES, "camisas"));
            list.Add(new Models.Clouth(6902, "Campera combinada", "1 al 6", "", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.BEBES, "camisas"));
            list.Add(new Models.Clouth(6891, "Chaleco combinado", "1 al 6", "", Models.Clouth.SUBCATEGORY.CHALECOS, Models.Clouth.CATEGORY.BEBES, "camisas"));
            
            return list;
        }


        public static IEnumerable<Models.Clouth> DataLoadNena()
        {
            var list = new List<Models.Clouth>();
            //REMERA CAMISA
            list.Add(new Models.Clouth(7054, "Remera love", "4 al 14", "Blanco - Natual - Fucsia - Salmón - Coral", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, "remerascamisas"));
            list.Add(new Models.Clouth(7055, "Remerón corazón", "4 al 14", "Blanco - Fucsia - Coral", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, "remerascamisas"));
            list.Add(new Models.Clouth(7100, "Remera dream", "4 al 14", "Blanco - Fucsia - Coral", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, "remerascamisas"));
            list.Add(new Models.Clouth(7056, "Remera con encaje", "4 al 14", "Blanco - Natural - Fucsia - Coral", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, "remerascamisas"));
            list.Add(new Models.Clouth(70561, "Remera con encaje", "4 al 14", "Blanco - Natural - Fucsia - Coral", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, "remerascamisas"));
            list.Add(new Models.Clouth(7057, "Musculosa mariposa", "4 al 14", "Blanco - Natural", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, "remerascamisas"));
            list.Add(new Models.Clouth(7101, "Musculosa yeah", "4 al 14", "Blanco - Natural", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, "remerascamisas"));
            list.Add(new Models.Clouth(7065, "Camisa fibrana", "4 al 14", "Blanco/Fucsia - Blanco/Turquesa", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.NENA, "remerascamisas"));


            //Calzas pantalones
            list.Add(new Models.Clouth(7064, "Calza larga", "4 al 14", "Salmón - Fucsia", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.NENA, "calzashorts"));
            list.Add(new Models.Clouth(7070, "Short fibrana", "4 al 14", "Azul - Salmón", Models.Clouth.SUBCATEGORY.SHORT, Models.Clouth.CATEGORY.NENA, "calzashorts"));
            list.Add(new Models.Clouth(7071, "Short encaje", "4 al 14", "Blanco - Coral - Fucsia", Models.Clouth.SUBCATEGORY.SHORT, Models.Clouth.CATEGORY.NENA, "calzashorts"));
            list.Add(new Models.Clouth(7072, "Short rústico", "4 al 14", "Blanco con Fucsia", Models.Clouth.SUBCATEGORY.SHORT, Models.Clouth.CATEGORY.NENA, "calzashorts"));

            //Enteritos
            list.Add(new Models.Clouth(7058, "Enterito modal estampado", "4 al 14", "Coral - Fucsia", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.NENA, "enteritos"));
            list.Add(new Models.Clouth(7059, "Enterito con botones", "4 al 14", "Azul - Coral - Turquesa", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.NENA, "enteritos"));
            list.Add(new Models.Clouth(7060, "Enterito fibrana", "4 al 14", "Azul - Salmón", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.NENA, "enteritos"));
            list.Add(new Models.Clouth(7061, "Enterito con volados", "4 al 14", "Agua marina - Salmón", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.NENA, "enteritos"));
            list.Add(new Models.Clouth(7062, "Enterito largo", "4 al 14", "Blanco/Fucsia - Verde agua/Fucsia", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.NENA, "enteritos"));
            list.Add(new Models.Clouth(7098, "Enterito nena estampado", "4 al 14", "Blanco con Turquesa - Blanco con Fucsia - Blanco con Amarillo", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.NENA, "enteritos"));


            //Vestido - SOLEROS
            list.Add(new Models.Clouth(7075, "Vestido con encaje", "4 al 14", "Blanco - Natural - Fucsia - Salmón - Coral", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA, "vestidossoleros"));
            list.Add(new Models.Clouth(7076, "Vestido fibrana", "4 al 14", "Salmón - Fucsia", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA, "vestidossoleros"));
            list.Add(new Models.Clouth(7077, "Solero fibrana", "4 al 14", "Blanco con Fucsia - Blanco con Turquesa", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA, "vestidossoleros"));
            list.Add(new Models.Clouth(7078, "Solero con puntilla", "2 al 10", "Blanco - Natural", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA, "vestidossoleros"));
            list.Add(new Models.Clouth(7073, "Solero con flores grandes", "4 al 14", "Blanco/Fucsia - Blanco/Salmón", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA, "vestidossoleros"));
            list.Add(new Models.Clouth(7096, "Vestido jean", "4 al 14", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA, "vestidossoleros"));
            list.Add(new Models.Clouth(7094, "Vestido jersey", "4 al 14", "Azul - Coral - Turquesa", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA, "vestidossoleros"));

            return list;
        }

        public static IEnumerable<Models.Clouth> DataLoadVaron()
        {
            var list = new List<Models.Clouth>();
            //REMERA CAMISA
            list.Add(new Models.Clouth(7080, "Remera athletic", "4 al 14", "Blanco - Turquesa - Francia - Verde - Rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, "remerascamisas"));
            list.Add(new Models.Clouth(7081, "Remera tigre", "4 al 14", "Blanco - Turquesa - Francia - Verde - Rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, "remerascamisas"));
            list.Add(new Models.Clouth(7082, "Remera pacific", "4 al 14", "Blanco - Turquesa - Francia - Verde - Rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, "remerascamisas"));
            list.Add(new Models.Clouth(7083, "Camisa escocesa", "4 al 14", "Rojo/Azul - Turquesa/Verde - Aero/Blanco", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.VARON, "remerascamisas"));
            list.Add(new Models.Clouth(7084, "Camisa escocesa", "4 al 14", "Rojo/Azul - Turquesa/Verde - Aero/Blanco", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.VARON, "remerascamisas"));
            list.Add(new Models.Clouth(7085, "Camisa jean", "4 al 14", "", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.VARON, "remerascamisas"));

            //PANTALON -  BERMUDA - SHORT BAÑO
            list.Add(new Models.Clouth(7086, "Pantalón gabardina", "4 al 14", "Francia - Verde - Aero", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.VARON, "pantalonesshorts"));
            list.Add(new Models.Clouth(7087, "Bermuda gabardina", "4 al 14", "Francia - Verde - Aero", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.VARON, "pantalonesshorts"));
            list.Add(new Models.Clouth(7089, "Short de baño combinado", "4 al 14", "Negro - Azul - Blanco/Negro - Rojo - Blanco", Models.Clouth.SUBCATEGORY.SHORT, Models.Clouth.CATEGORY.VARON, "pantalonesshorts"));
            list.Add(new Models.Clouth(7091, "Short de baño estampado", "4 al 14", "Azul - Rojo", Models.Clouth.SUBCATEGORY.SHORT, Models.Clouth.CATEGORY.VARON, "pantalonesshorts"));

            return list;
        }

    }
}