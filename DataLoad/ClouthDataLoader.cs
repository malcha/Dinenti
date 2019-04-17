using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.DataLoad
{
    public class ClouthDataLoader
    {

        public static IEnumerable<Models.Clouth> Data(Guid? type)
        {
            IEnumerable<Models.Clouth> data=null;
            if (type== null)
                return GetAll();
            switch (type.ToString())
            {
                case "8f6ecf5a-c8f3-4739-913e-f7c4332aa0c0":
                    data = GetAllXMayorPrecioVenta();
                    break;
                case "b816fa50-7828-4bf8-88d8-1a841c30d51f":
                    //x-mayor
                    data= GetAllXMayor();
                    break;
                case "213f2fe3-544e-4449-8257-ef8b6e956b2f":
                    //x-NUBE
                    data = GetAllNube();
                    break;
                case "ef384aad-f07a-48e3-a69e-571671e3c004":
                    //GENERAL
                    data = GetAllGeneral();
                    break;
                case "15c2bc84-b67e-406b-9e0a-0b8330ebbfec":
                    //GENERAL
                    data = GetAllLocal();
                    break;
                default:
                    data = GetAll();
                    break;
            }
            return data;
        }


        public static IEnumerable<Models.Clouth> GetAllLocal()
        {
            var list = new List<Models.Clouth>();
            list.Add(new Models.Clouth(7807, "Calza estampada", "1 AL 5", "$ 100,00", "1 AL 5", "$ 100,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: true));
            list.Add(new Models.Clouth(7806, "Calza estampada", "4 AL 14", "$ 150,00", "4 AL 14", "$ 150,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, promocion: true));
            list.Add(new Models.Clouth(7804, "Camisa manga larga broderie", "1 AL 5", "$ 370,00", "1 AL 5", "$ 249,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(7548, "Vestido licra estampado", "10,14,16", "$ 448,00", "10,14,16", "$ 336,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, promocion: false));
            list.Add(new Models.Clouth(7554, "Camiseta estampada", "4 y 10", "$ 298,00", "4 y 10", "$ 199,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, promocion: false));
            list.Add(new Models.Clouth(7823, "Remera manga larga camuflada", "1 AL 5", "$ 298,00", "1 AL 5", "$ 199,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, promocion: false));
            list.Add(new Models.Clouth(5959, "Camiseta escocesa entallada", "4 AL 16", "$ 298,00", "4 AL 16", "$ 199,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, promocion: true));
            list.Add(new Models.Clouth(7803, "Remera lanillla algodon", "1 AL 5", "$ 199,00", "1 AL 5", "$ 138,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(7562, "Camiseta escocesa", "4 AL 16", "$ 398,00", "4 AL 16", "$ 269,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, promocion: false));
            list.Add(new Models.Clouth(7528, "Campera universitaria friza", "1 y 2", "$ 358,00", "1 y 2", "$ 240,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, promocion: false));
            list.Add(new Models.Clouth(7852, "Remera con cartera manga larga", "4 al 14", "$ 250,00", "4 al 14", "$ 168,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, promocion: false));
            list.Add(new Models.Clouth(5931, "Pantalon Gabardina", "1 AL 6", "$ 299,00", "1 AL 6", "$ 199,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, promocion: false));
            list.Add(new Models.Clouth(7881, "Jumper", "0 al 3", "$ 299,00", "0 al 3", "$ 199,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES, promocion: false));
            list.Add(new Models.Clouth(7873, "Enterito plush", "0 al 2", "$ 490,00", "0 al 2", "$ 330,00", "", "", "rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES, promocion: false));
            list.Add(new Models.Clouth(7849, "Campera unicornio algodon friza", "4 al 14", "$ 550,00", "4 al 14", "$ 370,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, promocion: false));
            list.Add(new Models.Clouth(7872, "Enterito plush", "0 al 2", "$ 450,00", "0 al 2", "$ 298,00", "", "", "fucsia", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES, promocion: false));
            list.Add(new Models.Clouth(6811, "Pantalon estampado", "1 AL 5", "$ 199,00", "1 AL 5", "$ 100,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: true));
            list.Add(new Models.Clouth(7874, "Enterito estampado algodon friza", "0 al 2", "$ 348,00", "0 al 2", "$ 229,00", "", "", "varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES, promocion: false));
            list.Add(new Models.Clouth(3122, "Campera impermeable forrada en polar", "1", "$ 398,00", "1", "$ 298,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, promocion: true));
            list.Add(new Models.Clouth(7863, "Chaleco inflado", "1 al 5", "$ 399,00", "1 al 5", "$ 299,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, promocion: false));
            list.Add(new Models.Clouth(7509, "Campera algodon friza", "2 al 5", "$ 390,00", "2 al 5", "$ 290,00", "", "", "rosa bebe y violeta", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(7835, "Saco cruzado forrado en coorderito", "1, 2, 4 y 5", "$ 665,00", "1, 2, 4 y 5", "$ 445,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, promocion: false));
            list.Add(new Models.Clouth(7822, "Tapadito piel largo", "1, 2 y 3", "$ 448,00", "1, 2 y 3", "$ 299,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            //list.Add(new Models.Clouth(3222, "", "1 AL 5", "", "1 AL 5", "#VALUE!", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY., promocion: false));
            list.Add(new Models.Clouth(7563, "Body", "0 al 3", "$ 199,00", "0 al 3", "$ 100,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES, promocion: true));
            list.Add(new Models.Clouth(7519, "Tapado piel", "3 al 5", "$ 398,00", "3 al 5", "$ 298,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(3223, "Saco piel", "1", "$ 398,00", "1", "$ 298,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(4822, "Vestido modal", "1", "$ 199,00", "1", "$ 149,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: true));
            list.Add(new Models.Clouth(3224, "Vestido gatitos", "1", "$ 199,00", "1", "$ 149,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: true));
            list.Add(new Models.Clouth(7213, "Vestido rayado", "1 y 2", "$ 199,00", "1 y 2", "$ 149,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(7293, "Campera plush rayada", "0", "$ 349,00", "0", "$ 268,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(7214, "Vestido escocesa", "1", "$ 299,00", "1", "$ 199,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(7878, "Body escoces", "0  al 3", "$ 295,00", "0  al 3", "$ 195,00", "", "", "varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES, promocion: false));
            list.Add(new Models.Clouth(7222, "Vestido estampado", "1 al 5", "$ 298,00", "1 al 5", "$ 199,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(8001, "Remera manga larga gatito", "1 al 5", "$ 273,00", "1 al 5", "$ 182,00", "", "", "rosa, crudo y blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(7205, "Remera manga larga rayada", "1", "$ 199,00", "1", "$ 149,00", "", "", "rosa, crudo y blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(7877, "Enterito piel", "1 y 2", "$ 548,00", "1 y 2", "$ 368,00", "", "", "Manteca y crudo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES, promocion: false));
            list.Add(new Models.Clouth(7296, "Remeron beba", "1", "$ 169,00", "1", "$ 119,00", "", "", "Blanco y fucsia", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES, promocion: false));
            list.Add(new Models.Clouth(7209, "Vestido lanilla estampado", "2", "$ 298,00", "2", "$ 199,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES, promocion: false));
            list.Add(new Models.Clouth(7831, "Jardinero jean con escoces", "1 al 4", "$ 360,00", "1 al 4", "$ 240,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(7811, "Jardinero jean con bordado", "1 al 4", "$ 480,00", "1 al 4", "$ 320,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(3225, "Chaleco inflado nena", "1", "$ 399,00", "1", "$ 299,00", "", "", "Rosa y rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(7865, "Campera beba forrado polar", "1", "$ 678,00", "1", "$ 498,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(7810, "Jean bordado", "1 al 5", "$ 398,00", "1 al 5", "$ 289,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(7531, "Jean liso", "1 al 5", "$ 248,00", "1 al 5", "$ 198,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(7904, "Rompeviento", "1 al 3", "$ 520,00", "1 al 3", "$ 349,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, promocion: false));
            list.Add(new Models.Clouth(7901, "Campera impermeable", "1 y 2", "$ 550,00", "1 y 2", "$ 369,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, promocion: false));
            list.Add(new Models.Clouth(7864, "Campera camuflada", "2 al 4", "$ 850,00", "2 al 4", "$ 565,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, promocion: false));
            list.Add(new Models.Clouth(7864, "Campera camuflada", "2 al 4", "$ 850,00", "2 al 4", "$ 565,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, promocion: false));
            list.Add(new Models.Clouth(7887, "Campera inflable estampada", "1", "$ 748,00", "1", "$ 530,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, promocion: true));
            list.Add(new Models.Clouth(3226, "Campera inflable forrada polar", "6", "$ 680,00", "6", "$ 460,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, promocion: true));
            list.Add(new Models.Clouth(3227, "Campera estampada forrada polar", "6", "$ 680,00", "6", "$ 460,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, promocion: true));
            list.Add(new Models.Clouth(6849, "Saco rústico", "1 AL 3", "$ 328,00", "1 AL 3", "$ 200,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(6125, "Campera estampada rústica", "1 al 5", "$ 299,00", "1 al 5", "$ 199,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(7505, "Buzo friza", "1", "$ 278,00", "1", "$ 178,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, promocion: false));
            list.Add(new Models.Clouth(7816, "Buzo bordado piel", "2 al 4", "$ 298,00", "2 al 4", "$ 225,00", "", "", "piel, rosa y fucsia", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(3228, "Buzo algodon friza", "1", "$ 298,00", "1", "$ 198,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, promocion: false));
            list.Add(new Models.Clouth(7603, "Campera rústica estampada", "1 al 3", "$ 348,00", "1 al 3", "$ 230,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, promocion: false));
            list.Add(new Models.Clouth(7832, "Camisa escocesa", "1 al 5", "$ 199,00", "1 al 5", "$ 158,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(7829, "Pantalón friza", "1 al 5", "$ 220,00", "1 al 5", "$ 139,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(3229, "Campera", "6", "$ 990,00", "6", "$ 690,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(7521, "Campera rústica estampada", "x", "$ 298,00", "x", "$ 198,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, promocion: false));
            list.Add(new Models.Clouth(7598, "Tapado con piel", "4 al 14", "$ 890,00", "4 al 14", "$ 620,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, promocion: true));
            list.Add(new Models.Clouth(8068, "Chaleco metalizado nena", "4 al 14", "$ 708,00", "4 al 14", "$ 472,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, promocion: true));
            return list;
        }

        public static IEnumerable<Models.Clouth> GetAllXMayor()
        {

            var list = new List<Models.Clouth>();
            //list.Add(new Models.Clouth(7201, "REMERA PINGUINOS", "1 AL 5", "Chicle - Blanco - Natural", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7202, "REMERA CON POMPON", "1 AL 5", "Chicle - Blanco - Natural", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7203, "REMERA CON ANTEOJOS", "1 AL 5", "Chicle - Blanco - Natural", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7204, "REMERON CON ENCAJE", "1 AL 5", "Chicle - Blanco - Natural", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));

            list.Add(new Models.Clouth(8001, "REMERA GATITA BEBA", "1 AL 5", "$ 150,00", "", "", "", "", "Rosa, crudo, blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS,action:""));
            list.Add(new Models.Clouth(8002, "REMERA ARCOÍRIS", "1 AL 5", "$ 155,00", "", "", "", "", "Rosa, crudo, blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8003, "CALZA RÚSTICA BEBA", "1 AL 5", "$ 143,00", "", "", "", "", "Melange, fucsia, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8004, "CALZA LANILLA BEBA", "1 AL 5", "$ 122,00", "", "", "", "", "Rosa, negro y gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8005, "CALZA SIMIL JEAN", "1 AL 5", "$ 140,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8006, "BUZO CON VOLADO", "1 AL 5", "$ 299,00", "", "", "", "", "Rosa chicle, melange, verde beneton", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8007, "BUZO PIEL", "1 AL 5", "$ 285,00", "", "", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8008, "JUMPER ", "1 AL 5", "$ 235,00", "", "", "", "", "Rosa viejo, rosa claro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8009, "VESTIDO ESTAMPADO", "1 AL 5", "$ 215,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8010, "BUZO PIEL LENTEJUELA", "1 AL 5", "$ 348,00", "", "", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8011, "VESTIDO CORDEROY", "1 AL 5", "$ 310,00", "", "", "", "", "Rosa, verde agua, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8012, "JARIDNERO BORDADO", "1 AL 4", "$ 415,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8013, "JUMPER CORDEROY", "1 AL 5", "$ 305,00", "", "", "", "", "Rosa, verde agua, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8014, "REMERA COHETE BEBE", "1 AL 5", "$ 145,00", "", "", "", "", "Melange, aero, oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8015, "REMERA CON CARTERA", "1 AL 5", "$ 135,00", "", "", "", "", "Melange, aero, oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8016, "BUZO DINO", "1 AL 5", "$ 280,00", "", "", "", "", "Marino, melange, verde beneton", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.Clouth(8018, "BUZO COMBINADO OSO", "1 AL 5", "$ 279,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.));
            list.Add(new Models.Clouth(8020, "CAMPERA PIEL", "1 AL 5", "$ 360,00", "", "", "", "", "Rojo, aero, crudo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8021, "PANTALON FRIZA CON RECORTE", "1 AL 5", "$ 165,00", "", "", "", "", "Melange, marino, topo, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8022, "CAMPERA PIEL BORD", "1 AL 5", "$ 405,00", "", "", "", "", "Aero, rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8024, "CAMPERA COMBIN", "1 AL 5", "$ 330,00", "", "", "", "", "Marino, melange, rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8025, "PANTALON FRIZA COMBIN", "1 AL 5", "$ 165,00", "", "", "", "", "Marino, melange, rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8027, "SACO FRIZA", "1 AL 5", "$ 292,00", "", "", "", "", "Naranja, aero, melange, tomate", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8028, "JARDINERO JEAN", "1 AL 4", "$ 415,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8030, "REMERA RAYADA", "4 AL 8", "$ 143,00", "10 AL 14", "$ 153,00", "", "", "rayado rojo, rayado bordo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8031, "REMERA CON STASS", "4 AL 8", "$ 170,00", "10 AL 14", "$ 184,00", "", "", "melange, fucsia, blanca", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8032, "PANTALON RUSTICO", "4 AL 8", "$ 225,00", "10 AL 14", "$ 238,00", "", "", "melange, fucsia, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8033, "PANTALON SIMIL JEAN", "4 AL 8", "$ 215,00", "10 AL 14", "$ 225,00", "16", "$ 235,00", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8035, "CALZA CON ESTAMPA", "4 AL 8", "$ 225,00", "10 AL 14", "$ 238,00", "", "", "Negro, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8036, "CALZA TERMICA", "4 AL 8", "$ 209,00", "10 AL 14", "$ 220,00", "16", "$ 230,00", "Negro, gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8037, "BUZO UNICORNIO", "4 AL 8", "$ 330,00", "10 AL 14", "$ 355,00", "", "", "Rosa chicle, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8038, "BUZO PIEL", "4 AL 8", "$ 340,00", "10 AL 14", "$ 365,00", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8039, "BUZO LENTEJUELAS", "4 AL 8", "$ 445,00", "10 AL 14", "$ 480,00", "", "", "Melange, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8040, "BUZO PIEL C/CAPUCHA", "4 AL 8", "$ 475,00", "10 AL 14", "$ 510,00", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8041, "VESTIDO C/VOLADOS", "4 AL 8", "$ 340,00", "10 AL 14", "$ 365,00", "", "", "Estampado con gris, estampado con aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8042, "VESTIDO LENTEJUELAS", "4 AL 8", "$ 445,00", "10 AL 14", "$ 480,00", "", "", "Fucsia, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8043, "JUMPER JEAN", "4 AL 8", "$ 354,00", "10 AL 14", "$ 380,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8044, "CAMPERA PIEL", "4 AL 8", "$ 440,00", "10 AL 14", "$ 465,00", "", "", "Rojo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8046, "REMERA C/ AURICULARES VARON", "4 AL 8", "$ 185,00", "10 AL 14", "$ 198,00", "", "", "Melange, oxido, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8047, "REMERA ESTAMPADA", "4 AL 8", "$ 193,00", "10 AL 14", "$ 203,00", "", "", "Melange, oxido, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8048, "PANTALON C/ RECORTE", "4 AL 8", "$ 259,00", "10 AL 14", "$ 279,00", "", "", "Negro, topo, melange, marino", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8050, "BUZO C/ CIERRE", "4 AL 8", "$ 345,00", "10 AL 14", "$ 370,00", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8051, "BUZO SKATE", "4 AL 8", "$ 395,00", "10 AL 14", "$ 425,00", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8052, "CAMPERA COMBINADA", "4 AL 8", "$ 470,00", "10 AL 14", "$ 505,00", "", "", "Rojo con topo, francia con melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8054, "SACO FRIZA", "4 AL 8", "$ 359,00", "10 AL 14", "$ 385,00", "", "", "Topo, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8055, "ENTERITO PIEL CONEJO", "0 AL 2", "$ 399,00", "", "", "", "", "Rosa, rojo, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8056, "ENTERITO PIEL OSO PANDA", "0 AL 2", "$ 425,00", "", "", "", "", "Beige, rojo, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8057, "ENTERITO FRIZA OSO", "0 AL 2", "$ 345,00", "", "", "", "", "Rojo con azul, melange con rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8059, "ASTRONAUTA ESTAMPADO", "1 AL 3", "$ 610,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8060, "ASTRONAUTA BORDADO", "1 AL 3", "$ 610,00", "", "", "", "", "Rojo, gris, aero, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8062, "POLLERA CUERINA", "", "", "8 AL 12", "$ 260,00", "14 al 16", "", "Negra", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8063, "BUZO CON CIERRE", "", "", "8 AL 12", "$ 460,00", "14 al 16", "", "Topo con melange, rojo con negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8064, "PANTALON COMBINADO", "", "", "8 AL 12", "$ 359,00", "14 al 16", "", "Topo con melange, rojo con negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8065, "CHALECO BEBA OREJAS", "1 AL 5", "$ 399,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8066, "CHALECO BEBE", "1 AL 5", "$ 340,00", "", "", "", "", "Rojo, naranja, azul marino, verde", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8067, "CAMPERA BEBE  ", "1 AL 5", "$ 570,00", "", "", "", "", "Fondo azul/gris/rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8068, "CHALECO METALIZADO NENA", "4 al 14", "$ 390,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8069, "CAMPERA ESTAMPADA", "4 AL 8", "$ 790,00", "10 AL 14", "$ 850,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8070, "CAMPERON METALIZADO", "4 AL 8", "$ 640,00", "10 AL 14", "$ 695,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8072, "CHALECO VARON", "4 AL 8", "$ 340,00", "10 AL 14", "$ 365,00", "", "", "Gris, negro, marino", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8073, "CAMPERA VARON", "4 AL 8", "$ 690,00", "10 AL 14", "$ 740,00", "", "", "Rojo, azul, negro, gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8074, "TAPADO ESTAMPADA BEBA", "1 AL 5", "$ 625,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8075, "TAPADO CON CORDERITO", "1 AL 5", "$ 625,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8076, "CAMPERA PIEL CON FOIL", "4 AL 8", "$ 480,00", "10 AL 14", "$ 520,00", "", "", "Fucsia, rosa chicle, crudo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8077, "CAMPERA BEBE CAMUFLADA", "1 AL 5", "$ 538,00", "", "", "", "", "Marino, verde militar", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8078, "CALZA TERMICA", "1 AL 5", "$ 130,00", "", "", "", "", "Negro, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8079, "VESTIDO TELA ESTRELLAS", "4 AL 8", "$ 395,00", "10 AL 14", "$ 470,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8080, "CAMPERA PIEL CON FOIL", "1 AL 5", "$ 378,00", "", "", "", "", "Fucsia, rosa chicle, crudo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(8081, "REMERA CON VOLADO", "", "", "", "", "", "", "Azul - francia", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.));
            //list.Add(new Models.Clouth(8082, "", "", "", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.));


            list.Add(new Models.Clouth(8020, "CAMPERA PIEL", "1 AL 5", "$ 360,00", "", "", "", "", "Crudo, rojo, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8022, "CAMPERA PIEL BORD", "1 AL 5", "$ 405,00", "", "", "", "", "Rojo, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8074, "TAPADO ESTAMPADA BEBA", "1 AL 5", "$ 625,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8074-2"));
            list.Add(new Models.Clouth(8075, "TAPADO CON CORDERITO", "1 AL 5", "$ 625,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8075-2"));
            list.Add(new Models.Clouth(8075, "TAPADO CON CORDERITO", "1 AL 5", "$ 625,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8075-3"));

            return list.OrderBy(x=> x.Id);
        }

        public static IEnumerable<Models.Clouth> GetAllXMayorPrecioVenta()
        {

            var list = new List<Models.Clouth>();
            list.Add(new Models.Clouth(true, 8001, "REMERA GATITA BEBA", "1 AL 5", "$ 150,00", "", "", "", "", "Rosa, crudo, blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, action: ""));
            list.Add(new Models.Clouth(true, 8002, "REMERA ARCOÍRIS", "1 AL 5", "$ 155,00", "", "", "", "", "Rosa, crudo, blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8003, "CALZA RÚSTICA BEBA", "1 AL 5", "$ 143,00", "", "", "", "", "Melange, fucsia, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8004, "CALZA LANILLA BEBA", "1 AL 5", "$ 122,00", "", "", "", "", "Rosa, negro y gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8005, "CALZA SIMIL JEAN", "1 AL 5", "$ 140,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8006, "BUZO CON VOLADO", "1 AL 5", "$ 299,00", "", "", "", "", "Rosa chicle, melange, verde beneton", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8007, "BUZO PIEL", "1 AL 5", "$ 285,00", "", "", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8008, "JUMPER ", "1 AL 5", "$ 235,00", "", "", "", "", "Rosa viejo, rosa claro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8009, "VESTIDO ESTAMPADO", "1 AL 5", "$ 215,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8010, "BUZO PIEL LENTEJUELA", "1 AL 5", "$ 348,00", "", "", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8011, "VESTIDO CORDEROY", "1 AL 5", "$ 310,00", "", "", "", "", "Rosa, verde agua, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8012, "JARIDNERO BORDADO", "1 AL 4", "$ 415,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8013, "JUMPER CORDEROY", "1 AL 5", "$ 305,00", "", "", "", "", "Rosa, verde agua, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8014, "REMERA COHETE BEBE", "1 AL 5", "$ 145,00", "", "", "", "", "Melange, aero, oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8015, "REMERA CON CARTERA", "1 AL 5", "$ 135,00", "", "", "", "", "Melange, aero, oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8016, "BUZO DINO", "1 AL 5", "$ 280,00", "", "", "", "", "Marino, melange, verde beneton", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.Clouttrue, h(8018, "BUZO COMBINADO OSO", "1 AL 5", "$ 279,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.));
            list.Add(new Models.Clouth(true, 8020, "CAMPERA PIEL", "1 AL 5", "$ 360,00", "", "", "", "", "Rojo, aero, crudo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8021, "PANTALON FRIZA CON RECORTE", "1 AL 5", "$ 165,00", "", "", "", "", "Melange, marino, topo, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8022, "CAMPERA PIEL BORD", "1 AL 5", "$ 405,00", "", "", "", "", "Aero, rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8024, "CAMPERA COMBIN", "1 AL 5", "$ 330,00", "", "", "", "", "Marino, melange, rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8025, "PANTALON FRIZA COMBIN", "1 AL 5", "$ 165,00", "", "", "", "", "Marino, melange, rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8027, "SACO FRIZA", "1 AL 5", "$ 292,00", "", "", "", "", "Naranja, aero, melange, tomate", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8028, "JARDINERO JEAN", "1 AL 4", "$ 415,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8030, "REMERA RAYADA", "4 AL 8", "$ 143,00", "10 AL 14", "$ 153,00", "", "", "rayado rojo, rayado bordo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8031, "REMERA CON STASS", "4 AL 8", "$ 170,00", "10 AL 14", "$ 184,00", "", "", "melange, fucsia, blanca", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8032, "PANTALON RUSTICO", "4 AL 8", "$ 225,00", "10 AL 14", "$ 238,00", "", "", "melange, fucsia, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8033, "PANTALON SIMIL JEAN", "4 AL 8", "$ 215,00", "10 AL 14", "$ 225,00", "16", "$ 235,00", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8035, "CALZA CON ESTAMPA", "4 AL 8", "$ 225,00", "10 AL 14", "$ 238,00", "", "", "Negro, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8036, "CALZA TERMICA", "4 AL 8", "$ 209,00", "10 AL 14", "$ 220,00", "16", "$ 230,00", "Negro, gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8037, "BUZO UNICORNIO", "4 AL 8", "$ 330,00", "10 AL 14", "$ 355,00", "", "", "Rosa chicle, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8038, "BUZO PIEL", "4 AL 8", "$ 340,00", "10 AL 14", "$ 365,00", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8039, "BUZO LENTEJUELAS", "4 AL 8", "$ 445,00", "10 AL 14", "$ 480,00", "", "", "Melange, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8040, "BUZO PIEL C/CAPUCHA", "4 AL 8", "$ 475,00", "10 AL 14", "$ 510,00", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8041, "VESTIDO C/VOLADOS", "4 AL 8", "$ 340,00", "10 AL 14", "$ 365,00", "", "", "Estampado con gris, estampado con aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8042, "VESTIDO LENTEJUELAS", "4 AL 8", "$ 445,00", "10 AL 14", "$ 480,00", "", "", "Fucsia, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8043, "JUMPER JEAN", "4 AL 8", "$ 354,00", "10 AL 14", "$ 380,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8044, "CAMPERA PIEL", "4 AL 8", "$ 440,00", "10 AL 14", "$ 465,00", "", "", "Rojo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8046, "REMERA C/ AURICULARES VARON", "4 AL 8", "$ 185,00", "10 AL 14", "$ 198,00", "", "", "Melange, oxido, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(true, 8047, "REMERA ESTAMPADA", "4 AL 8", "$ 193,00", "10 AL 14", "$ 203,00", "", "", "Melange, oxido, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(true, 8048, "PANTALON C/ RECORTE", "4 AL 8", "$ 259,00", "10 AL 14", "$ 279,00", "", "", "Negro, topo, melange, marino", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(true, 8050, "BUZO C/ CIERRE", "4 AL 8", "$ 345,00", "10 AL 14", "$ 370,00", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(true, 8051, "BUZO SKATE", "4 AL 8", "$ 395,00", "10 AL 14", "$ 425,00", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(true, 8052, "CAMPERA COMBINADA", "4 AL 8", "$ 470,00", "10 AL 14", "$ 505,00", "", "", "Rojo con topo, francia con melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(true, 8054, "SACO FRIZA", "4 AL 8", "$ 359,00", "10 AL 14", "$ 385,00", "", "", "Topo, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(true, 8055, "ENTERITO PIEL CONEJO", "0 AL 2", "$ 399,00", "", "", "", "", "Rosa, rojo, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(true, 8056, "ENTERITO PIEL OSO PANDA", "0 AL 2", "$ 425,00", "", "", "", "", "Beige, rojo, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(true, 8057, "ENTERITO FRIZA OSO", "0 AL 2", "$ 345,00", "", "", "", "", "Rojo con azul, melange con rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(true, 8059, "ASTRONAUTA ESTAMPADO", "1 AL 3", "$ 610,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(true, 8060, "ASTRONAUTA BORDADO", "1 AL 3", "$ 610,00", "", "", "", "", "Rojo, gris, aero, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(true, 8062, "POLLERA CUERINA", "", "", "8 AL 12", "$ 260,00", "14 al 16", "", "Negra", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8063, "BUZO CON CIERRE", "", "", "8 AL 12", "$ 460,00", "14 al 16", "", "Topo con melange, rojo con negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(true, 8064, "PANTALON COMBINADO", "", "", "8 AL 12", "$ 359,00", "14 al 16", "", "Topo con melange, rojo con negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(true, 8065, "CHALECO BEBA OREJAS", "1 AL 5", "$ 399,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8066, "CHALECO BEBE", "1 AL 5", "$ 340,00", "", "", "", "", "Rojo, naranja, azul marino, verde", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8067, "CAMPERA BEBE  ", "1 AL 5", "$ 570,00", "", "", "", "", "Fondo azul/gris/rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8068, "CHALECO METALIZADO NENA", "4 al 14", "$ 390,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8069, "CAMPERA ESTAMPADA", "4 AL 8", "$ 790,00", "10 AL 14", "$ 850,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8070, "CAMPERON METALIZADO", "4 AL 8", "$ 640,00", "10 AL 14", "$ 695,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8072, "CHALECO VARON", "4 AL 8", "$ 340,00", "10 AL 14", "$ 365,00", "", "", "Gris, negro, marino", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(true, 8073, "CAMPERA VARON", "4 AL 8", "$ 690,00", "10 AL 14", "$ 740,00", "", "", "Rojo, azul, negro, gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(true, 8074, "TAPADO ESTAMPADA BEBA", "1 AL 5", "$ 625,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8075, "TAPADO CON CORDERITO", "1 AL 5", "$ 625,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8076, "CAMPERA PIEL CON FOIL", "4 AL 8", "$ 480,00", "10 AL 14", "$ 520,00", "", "", "Fucsia, rosa chicle, crudo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8077, "CAMPERA BEBE CAMUFLADA", "1 AL 5", "$ 538,00", "", "", "", "", "Marino, verde militar", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8078, "CALZA TERMICA", "1 AL 5", "$ 130,00", "", "", "", "", "Negro, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8079, "VESTIDO TELA ESTRELLAS", "4 AL 8", "$ 395,00", "10 AL 14", "$ 470,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8080, "CAMPERA PIEL CON FOIL", "1 AL 5", "$ 378,00", "", "", "", "", "Fucsia, rosa chicle, crudo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouttrue, h(8081, "REMERA CON VOLADO", "", "", "", "", "", "", "Azul - francia", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.));
            //list.Add(new Models.Clouttrue, h(8082, "", "", "", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.));
                                       
            list.Add(new Models.Clouth(true, 8020, "CAMPERA PIEL", "1 AL 5", "$ 360,00", "", "", "", "", "Crudo, rojo, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8022, "CAMPERA PIEL BORD", "1 AL 5", "$ 405,00", "", "", "", "", "Rojo, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8074, "TAPADO ESTAMPADA BEBA", "1 AL 5", "$ 625,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8074-2"));
            list.Add(new Models.Clouth(true, 8075, "TAPADO CON CORDERITO", "1 AL 5", "$ 625,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8075-2"));
            list.Add(new Models.Clouth(true, 8075, "TAPADO CON CORDERITO", "1 AL 5", "$ 625,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8075-3"));

            return list.OrderBy(x => x.Id);
        }

        public static IEnumerable<Models.Clouth> GetAllGeneral()
        {
            var list = new List<Models.Clouth>();

            list.Add(new Models.Clouth(8001, "REMERA GATITA BEBA", "1 AL 5", "$ 168,00", "", "", "", "", "Rosa, crudo, blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8002, "REMERA ARCOÍRIS", "1 AL 5", "$ 172,00", "", "", "", "", "Rosa, crudo, blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8003, "CALZA RÚSTICA BEBA", "1 AL 5", "$ 159,00", "", "", "", "", "Melange, fucsia, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8004, "CALZA LANILLA BEBA", "1 AL 5", "$ 135,00", "", "", "", "", "Rosa, negro y gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8005, "CALZA SIMIL JEAN", "1 AL 5", "$ 156,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8006, "BUZO CON VOLADO", "1 AL 5", "$ 327,00", "", "", "", "", "Rosa chicle, melange, verde beneton", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8007, "BUZO PIEL", "1 AL 5", "$ 309,00", "", "", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8008, "JUMPER ", "1 AL 5", "$ 257,00", "", "", "", "", "Rosa viejo, rosa claro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8009, "VESTIDO ESTAMPADO", "1 AL 5", "$ 235,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8010, "BUZO PIEL LENTEJUELA", "1 AL 5", "$ 380,00", "", "", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8011, "VESTIDO CORDEROY", "1 AL 5", "$ 345,00", "", "", "", "", "Rosa, verde agua, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8012, "JARIDNERO BORDADO", "1 AL 4", "$ 459,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8013, "JUMPER CORDEROY", "1 AL 5", "$ 338,00", "", "", "", "", "Rosa, verde agua, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8014, "REMERA COHETE BEBE", "1 AL 5", "$ 157,00", "", "", "", "", "Melange, aero, oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8015, "REMERA CON CARTERA", "1 AL 5", "$ 145,00", "", "", "", "", "Melange, aero, oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8016, "BUZO DINO", "1 AL 5", "$ 314,00", "", "", "", "", "Marino, melange, verde beneton", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.Clouth(8018, "BUZO COMBINADO OSO", "1 AL 5", "$ 310,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.));
            list.Add(new Models.Clouth(8020, "CAMPERA PIEL", "1 AL 5", "$ 395,00", "", "", "", "", "Rojo, aero, crudo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8021, "PANTALON FRIZA CON RECORTE", "1 AL 5", "$ 186,00", "", "", "", "", "Melange, marino, topo, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8022, "CAMPERA PIEL BORD", "1 AL 5", "$ 448,00", "", "", "", "", "Aero, rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8024, "CAMPERA COMBIN", "1 AL 5", "$ 368,00", "", "", "", "", "Marino, melange, rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8025, "PANTALON FRIZA COMBIN", "1 AL 5", "$ 186,00", "", "", "", "", "Marino, melange, rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8027, "SACO FRIZA", "1 AL 5", "$ 325,00", "", "", "", "", "Naranja, aero, melange, tomate", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8028, "JARDINERO JEAN", "1 AL 4", "$ 465,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8030, "REMERA RAYADA", "4 AL 8", "$ 159,00", "10 AL 14", "$ 173,00", "", "", "rayado rojo, rayado bordo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8031, "REMERA CON STASS", "4 AL 8", "$ 189,00", "10 AL 14", "$ 205,00", "", "", "melange, fucsia, blanca", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8032, "PANTALON RUSTICO", "4 AL 8", "$ 245,00", "10 AL 14", "$ 265,00", "", "", "melange, fucsia, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8033, "PANTALON SIMIL JEAN", "4 AL 8", "$ 236,00", "10 AL 14", "$ 249,00", "16", "$ 260,00", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8035, "CALZA CON ESTAMPA", "4 AL 8", "$ 245,00", "10 AL 14", "$ 265,00", "", "", "Negro, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8036, "CALZA TERMICA", "4 AL 8", "$ 233,00", "10 AL 14", "$ 246,00", "16", "$ 258,00", "Negro, gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8037, "BUZO UNICORNIO", "4 AL 8", "$ 367,00", "10 AL 14", "$ 397,00", "", "", "Rosa chicle, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8038, "BUZO PIEL", "4 AL 8", "$ 379,00", "10 AL 14", "$ 409,00", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8039, "BUZO LENTEJUELAS", "4 AL 8", "$ 495,00", "10 AL 14", "$ 535,00", "", "", "Melange, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8040, "BUZO PIEL C/CAPUCHA", "4 AL 8", "$ 529,00", "10 AL 14", "$ 569,00", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8041, "VESTIDO C/VOLADOS", "4 AL 8", "$ 378,00", "10 AL 14", "$ 408,00", "", "", "Estampado con gris, estampado con aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8042, "VESTIDO LENTEJUELAS", "4 AL 8", "$ 498,00", "10 AL 14", "$ 538,00", "", "", "Fucsia, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8043, "JUMPER JEAN", "4 AL 8", "$ 394,00", "10 AL 14", "$ 424,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8044, "CAMPERA PIEL", "4 AL 8", "$ 479,00", "10 AL 14", "$ 519,00", "", "", "Rojo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8046, "REMERA C/ AURICULARES VARON", "4 AL 8", "$ 206,00", "10 AL 14", "$ 220,00", "", "", "Melange, oxido, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8047, "REMERA ESTAMPADA", "4 AL 8", "$ 215,00", "10 AL 14", "$ 233,00", "", "", "Melange, oxido, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8048, "PANTALON C/ RECORTE", "4 AL 8", "$ 288,00", "10 AL 14", "$ 310,00", "", "", "Negro, topo, melange, marino", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8050, "BUZO C/ CIERRE", "4 AL 8", "$ 385,00", "10 AL 14", "$ 415,00", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8051, "BUZO SKATE", "4 AL 8", "$ 439,00", "10 AL 14", "$ 475,00", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8052, "CAMPERA COMBINADA", "4 AL 8", "$ 526,00", "10 AL 14", "$ 566,00", "", "", "Rojo con topo, francia con melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8054, "SACO FRIZA", "4 AL 8", "$ 399,00", "10 AL 14", "$ 429,00", "", "", "Topo, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8055, "ENTERITO PIEL CONEJO", "0 AL 2", "$ 445,00", "", "", "", "", "Rosa, rojo, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8056, "ENTERITO PIEL OSO PANDA", "0 AL 2", "$ 475,00", "", "", "", "", "Beige, rojo, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8057, "ENTERITO FRIZA OSO", "0 AL 2", "$ 385,00", "", "", "", "", "Rojo con azul, melange con rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8059, "ASTRONAUTA ESTAMPADO", "1 AL 3", "$ 679,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8060, "ASTRONAUTA BORDADO", "1 AL 3", "$ 679,00", "", "", "", "", "Rojo, gris, aero, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8062, "POLLERA CUERINA", "", "", "8 AL 16", "$ 289,00", "", "", "Negra", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8063, "BUZO CON CIERRE", "", "", "8 AL 16", "$ 515,00", "", "", "Topo con melange, rojo con negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8064, "PANTALON COMBINADO", "", "", "8 AL 16", "$ 399,00", "", "", "Topo con melange, rojo con negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8065, "CHALECO BEBA OREJAS", "1 AL 5", "$ 448,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8066, "CHALECO BEBE", "1 AL 5", "$ 379,00", "", "", "", "", "Rojo, naranja, azul marino, verde", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8067, "CAMPERA BEBE", "1 AL 5", "$ 635,00", "", "", "", "", "Fondo azul/gris/rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8068, "CHALECO METALIZADO NENA", "4 al 14", "$ 390,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8069, "CAMPERA ESTAMPADA", "4 AL 8", "$ 879,00", "10 AL 14", "$ 949,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8070, "CAMPERON METALIZADO", "4 AL 8", "$ 715,00", "10 AL 14", "$ 775,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8072, "CHALECO VARON", "4 AL 8", "$ 379,00", "10 AL 14", "$ 409,00", "", "", "Gris, negro, marino", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8073, "CAMPERA VARON", "4 AL 8", "$ 768,00", "10 AL 14", "$ 828,00", "", "", "Rojo, azul, negro, gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8074, "TAPADO ESTAMPADA BEBA", "1 AL 5", "$ 695,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8075, "TAPADO CON CORDERITO", "1 AL 5", "$ 695,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8076, "CAMPERA PIEL CON FOIL", "4 AL 8", "$ 540,00", "10 AL 14", "$ 580,00", "", "", "Fucsia, rosa chicle, crudo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8077, "CAMPERA BEBE CAMUFLADA", "1 AL 5", "$ 598,00", "", "", "", "", "Marino, verde militar", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8078, "CALZA TERMICA", "1 AL 5", "$ 145,00", "", "", "", "", "Negro, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8079, "VESTIDO TELA ESTRELLAS", "4 AL 8", "$ 439,00", "10 AL 14", "$ 469,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8080, "CAMPERA PIEL CON FOIL", "1 AL 5", "$ 420,00", "", "", "", "", "Fucsia, rosa chicle, crudo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));           

            list.Add(new Models.Clouth(8020, "CAMPERA PIEL", "1 AL 5", "$ 395,00", "", "", "", "", "Crudo, rojo, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8022, "CAMPERA PIEL BORD", "1 AL 5", "$ 448,00", "", "", "", "", "Rojo, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8074, "TAPADO ESTAMPADA BEBA", "1 AL 5", "$ 695,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8074-2"));
            list.Add(new Models.Clouth(8075, "TAPADO CON CORDERITO", "1 AL 5", "$ 695,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8075-2"));
            return list;
        }

        public static IEnumerable<Models.Clouth> GetAllNube()
        {
            var list = new List<Models.Clouth>();
            list.Add(new Models.Clouth(8001, "REMERA GATITA BEBA", "1 AL 5", "$ 148,00", "", "", "", "", "Rosa, crudo, blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8002, "REMERA ARCOÍRIS", "1 AL 5", "$ 154,00", "", "", "", "", "Rosa, crudo, blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8003, "CALZA RÚSTICA BEBA", "1 AL 5", "$ 143,00", "", "", "", "", "Melange, fucsia, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8004, "CALZA LANILLA BEBA", "1 AL 5", "$ 118,00", "", "", "", "", "Rosa, negro y gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8005, "CALZA SIMIL JEAN", "1 AL 5", "$ 133,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8006, "BUZO CON VOLADO", "1 AL 5", "$ 287,00", "", "", "", "", "Rosa chicle, melange, verde beneton", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8007, "BUZO PIEL", "1 AL 5", "$ 265,00", "", "", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8008, "JUMPER ", "1 AL 5", "$ 225,00", "", "", "", "", "Rosa viejo, rosa claro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8009, "VESTIDO ESTAMPADO", "1 AL 5", "$ 199,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8010, "BUZO PIEL LENTEJUELA", "1 AL 5", "$ 335,00", "", "", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8011, "VESTIDO CORDEROY", "1 AL 5", "$ 296,00", "", "", "", "", "Rosa, verde agua, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8012, "JARIDNERO BORDADO", "1 AL 4", "$ 405,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8013, "JUMPER CORDEROY", "1 AL 5", "$ 289,00", "", "", "", "", "Rosa, verde agua, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8014, "REMERA COHETE BEBE", "1 AL 5", "$ 142,00", "", "", "", "", "Melange, aero, oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8015, "REMERA CON CARTERA", "1 AL 5", "$ 131,00", "", "", "", "", "Melange, aero, oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8016, "BUZO DINO", "1 AL 5", "$ 269,00", "", "", "", "", "Marino, melange, verde beneton", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.Clouth(8018, "BUZO COMBINADO OSO", "1 AL 5", "$ 269,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.));
            list.Add(new Models.Clouth(8020, "CAMPERA PIEL", "1 AL 5", "$ 339,00", "", "", "", "", "Rojo, aero, crudo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8021, "PANTALON FRIZA CON RECORTE", "1 AL 5", "$ 167,00", "", "", "", "", "Melange, marino, topo, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8022, "CAMPERA PIEL BORD", "1 AL 5", "$ 380,00", "", "", "", "", "Aero, rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8024, "CAMPERA COMBIN", "1 AL 5", "$ 318,00", "", "", "", "", "Marino, melange, rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8025, "PANTALON FRIZA COMBIN", "1 AL 5", "$ 167,00", "", "", "", "", "Marino, melange, rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8027, "SACO FRIZA", "1 AL 5", "$ 282,00", "", "", "", "", "Naranja, aero, melange, tomate", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8028, "JARDINERO JEAN", "1 AL 4", "$ 399,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8030, "REMERA RAYADA", "4 AL 8", "$ 144,00", "10 AL 14", "$ 156,00", "", "", "rayado rojo, rayado bordo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8031, "REMERA CON STASS", "4 AL 8", "$ 173,00", "10 AL 14", "$ 187,00", "", "", "melange, fucsia, blanca", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8032, "PANTALON RUSTICO", "4 AL 8", "$ 216,00", "10 AL 14", "$ 234,00", "", "", "melange, fucsia, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8033, "PANTALON SIMIL JEAN", "4 AL 8", "$ 209,00", "10 AL 14", "$ 221,00", "16", "$ 233,00", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8035, "CALZA CON ESTAMPA", "4 AL 8", "$ 216,00", "10 AL 14", "$ 234,00", "", "", "Negro, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8036, "CALZA TERMICA", "4 AL 8", "$ 206,00", "10 AL 14", "$ 218,00", "16", "$ 229,00", "Negro, gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8037, "BUZO UNICORNIO", "4 AL 8", "$ 325,00", "10 AL 14", "$ 353,00", "", "", "Rosa chicle, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8038, "BUZO PIEL", "4 AL 8", "$ 324,00", "10 AL 14", "$ 349,00", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8039, "BUZO LENTEJUELAS", "4 AL 8", "$ 439,00", "10 AL 14", "$ 469,00", "", "", "Melange, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8040, "BUZO PIEL C/CAPUCHA", "4 AL 8", "$ 463,00", "10 AL 14", "$ 499,00", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8041, "VESTIDO C/VOLADOS", "4 AL 8", "$ 330,00", "10 AL 14", "$ 358,00", "", "", "Estampado con gris, estampado con aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8042, "VESTIDO LENTEJUELAS", "4 AL 8", "$ 434,00", "10 AL 14", "$ 469,00", "", "", "Fucsia, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8043, "JUMPER JEAN", "4 AL 8", "$ 346,00", "10 AL 14", "$ 374,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8044, "CAMPERA PIEL", "4 AL 8", "$ 409,00", "10 AL 14", "$ 443,00", "", "", "Rojo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8046, "REMERA C/ AURICULARES VARON", "4 AL 8", "$ 184,00", "10 AL 14", "$ 199,00", "", "", "Melange, oxido, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8047, "REMERA ESTAMPADA", "4 AL 8", "$ 192,00", "10 AL 14", "$ 208,00", "", "", "Melange, oxido, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8048, "PANTALON C/ RECORTE", "4 AL 8", "$ 259,00", "10 AL 14", "$ 279,00", "", "", "Negro, topo, melange, marino", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8050, "BUZO C/ CIERRE", "4 AL 8", "$ 335,00", "10 AL 14", "$ 363,00", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8051, "BUZO SKATE", "4 AL 8", "$ 375,00", "10 AL 14", "$ 405,00", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8052, "CAMPERA COMBINADA", "4 AL 8", "$ 449,00", "10 AL 14", "$ 487,00", "", "", "Rojo con topo, francia con melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8054, "SACO FRIZA", "4 AL 8", "$ 349,00", "10 AL 14", "$ 379,00", "", "", "Topo, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8055, "ENTERITO PIEL CONEJO", "0 AL 2", "$ 378,00", "", "", "", "", "Rosa, rojo, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8056, "ENTERITO PIEL OSO PANDA", "0 AL 2", "$ 405,00", "", "", "", "", "Beige, rojo, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8057, "ENTERITO FRIZA OSO", "0 AL 2", "$ 335,00", "", "", "", "", "Rojo con azul, melange con rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8059, "ASTRONAUTA ESTAMPADO", "1 AL 3", "$ 585,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8060, "ASTRONAUTA BORDADO", "1 AL 3", "$ 585,00", "", "", "", "", "Rojo, gris, aero, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8062, "POLLERA CUERINA", "", "", "8 AL 12", "$ 245,00", "14 al 16", "", "Negra", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8063, "BUZO CON CIERRE", "", "", "8 AL 12", "$ 449,00", "14 al 16", "", "Topo con melange, rojo con negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8064, "PANTALON COMBINADO", "", "", "8 AL 12", "$ 360,00", "14 al 16", "", "Topo con melange, rojo con negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8065, "CHALECO BEBA OREJAS", "1 AL 5", "$ 379,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8066, "CHALECO BEBE", "1 AL 5", "$ 325,00", "", "", "", "", "Rojo, naranja, azul marino, verde", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8067, "CAMPERA BEBE  ", "1 AL 5", "$ 545,00", "", "", "", "", "Fondo azul/gris/rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8068, "CHALECO METALIZADO NENA", "4 al 14", "$ 345,00", "", "$ 370,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8069, "CAMPERA ESTAMPADA", "4 AL 8", "$ 745,00", "10 AL 14", "$ 805,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8070, "CAMPERON METALIZADO", "4 AL 8", "$ 608,00", "10 AL 14", "$ 658,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8072, "CHALECO VARON", "4 AL 8", "$ 319,00", "10 AL 14", "$ 345,00", "", "", "Gris, negro, marino", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8073, "CAMPERA VARON", "4 AL 8", "$ 659,00", "10 AL 14", "$ 713,00", "", "", "Rojo, azul, negro, gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8074, "TAPADO ESTAMPADA BEBA", "1 AL 5", "$ 595,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8075, "TAPADO CON CORDERITO", "1 AL 5", "$ 595,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8076, "CAMPERA PIEL CON FOIL", "4 AL 8", "$ 519,00", "10 AL 14", "$ 559,00", "", "", "Fucsia, rosa chicle, crudo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8077, "CAMPERA BEBE CAMUFLADA", "1 AL 5", "$ 515,00", "", "", "", "", "Marino, verde militar", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8078, "CALZA TERMICA", "1 AL 5", "$ 128,00", "", "", "", "", "Negro, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8079, "VESTIDO TELA ESTRELLAS", "4 AL 8", "$ 384,00", "10 AL 14", "$ 415,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8080, "CAMPERA PIEL CON FOIL", "1 AL 5", "$ 360,00", "", "", "", "", "Fucsia, rosa chicle, crudo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(8081, "REMERA CON VOLADO", "", "", "", "", "", "", "Azul - francia", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.));

            list.Add(new Models.Clouth(8020, "CAMPERA PIEL", "1 AL 5", "$ 339,00", "", "", "", "", "Crudo, rojo, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8022, "CAMPERA PIEL BORD", "1 AL 5", "$ 380,00", "", "", "", "", "Rojo, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8074, "TAPADO ESTAMPADA BEBA", "1 AL 5", "$ 595,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8074-2"));
            list.Add(new Models.Clouth(8075, "TAPADO CON CORDERITO", "1 AL 5", "$ 595,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8075-2"));
            return list;
        }

        public static IEnumerable<Models.Clouth> GetAll()
        {

            var list = new List<Models.Clouth>();
            list.Add(new Models.Clouth(8001, "REMERA GATITA BEBA", "1 AL 5", "", "", "", "", "", "Rosa, crudo, blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8002, "REMERA ARCOÍRIS", "1 AL 5", "", "", "", "", "", "Rosa, crudo, blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8003, "CALZA RÚSTICA BEBA", "1 AL 5", "", "", "", "", "", "Melange, fucsia, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8004, "CALZA LANILLA BEBA", "1 AL 5", "", "", "", "", "", "Rosa, negro y gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8005, "CALZA SIMIL JEAN", "1 AL 5", "", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8006, "BUZO CON VOLADO", "1 AL 5", "", "", "", "", "", "Rosa chicle, melange, verde beneton", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8007, "BUZO PIEL", "1 AL 5", "", "", "", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8008, "JUMPER ", "1 AL 5", "", "", "", "", "", "Rosa viejo, rosa claro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8009, "VESTIDO ESTAMPADO", "1 AL 5", "", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8010, "BUZO PIEL LENTEJUELA", "1 AL 5", "", "", "", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8011, "VESTIDO CORDEROY", "1 AL 5", "", "", "", "", "", "Rosa, verde agua, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8012, "JARIDNERO BORDADO", "1 AL 4", "", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8013, "JUMPER CORDEROY", "1 AL 5", "", "", "", "", "", "Rosa, verde agua, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8014, "REMERA COHETE BEBE", "1 AL 5", "", "", "", "", "", "Melange, aero, oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8015, "REMERA CON CARTERA", "1 AL 5", "", "", "", "", "", "Melange, aero, oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8016, "BUZO DINO", "1 AL 5", "", "", "", "", "", "Marino, melange, verde beneton", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.Clouth(8018, "BUZO COMBINADO OSO", "1 AL 5", "", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.));
            list.Add(new Models.Clouth(8020, "CAMPERA PIEL", "1 AL 5", "", "", "", "", "", "Rojo, aero, crudo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8021, "PANTALON FRIZA CON RECORTE", "1 AL 5", "", "", "", "", "", "Melange, marino, topo, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8022, "CAMPERA PIEL BORD", "1 AL 5", "", "", "", "", "", "Aero, rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8024, "CAMPERA COMBIN", "1 AL 5", "", "", "", "", "", "Marino, melange, rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8025, "PANTALON FRIZA COMBIN", "1 AL 5", "", "", "", "", "", "Marino, melange, rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8027, "SACO FRIZA", "1 AL 5", "", "", "", "", "", "Naranja, aero, melange, tomate", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8028, "JARDINERO JEAN", "1 AL 4", "", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8030, "REMERA RAYADA", "4 AL 8", "", "10 AL 14", "", "", "", "rayado rojo, rayado bordo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8031, "REMERA CON STASS", "4 AL 8", "", "10 AL 14", "", "", "", "melange, fucsia, blanca", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8032, "PANTALON RUSTICO", "4 AL 8", "", "10 AL 14", "", "", "", "melange, fucsia, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8033, "PANTALON SIMIL JEAN", "4 AL 8", "", "10 AL 14", "", "16", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8035, "CALZA CON ESTAMPA", "4 AL 8", "", "10 AL 14", "", "", "", "Negro, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8036, "CALZA TERMICA", "4 AL 8", "", "10 AL 14", "", "16", "", "Negro, gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8037, "BUZO UNICORNIO", "4 AL 8", "", "10 AL 14", "", "", "", "Rosa chicle, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8038, "BUZO PIEL", "4 AL 8", "", "10 AL 14", "", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8039, "BUZO LENTEJUELAS", "4 AL 8", "", "10 AL 14", "", "", "", "Melange, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8040, "BUZO PIEL C/CAPUCHA", "4 AL 8", "", "10 AL 14", "", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8041, "VESTIDO C/VOLADOS", "4 AL 8", "", "10 AL 14", "", "", "", "Estampado con gris, estampado con aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8042, "VESTIDO LENTEJUELAS", "4 AL 8", "", "10 AL 14", "", "", "", "Fucsia, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8043, "JUMPER JEAN", "4 AL 8", "", "10 AL 14", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8044, "CAMPERA PIEL", "4 AL 8", "", "10 AL 14", "", "", "", "Rojo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8046, "REMERA C/ AURICULARES VARON", "4 AL 8", "", "10 AL 14", "", "", "", "Melange, oxido, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8047, "REMERA ESTAMPADA", "4 AL 8", "", "10 AL 14", "", "", "", "Melange, oxido, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8048, "PANTALON C/ RECORTE", "4 AL 8", "", "10 AL 14", "", "", "", "Negro, topo, melange, marino", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8050, "BUZO C/ CIERRE", "4 AL 8", "", "10 AL 14", "", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8051, "BUZO SKATE", "4 AL 8", "", "10 AL 14", "", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8052, "CAMPERA COMBINADA", "4 AL 8", "", "10 AL 14", "", "", "", "Rojo con topo, francia con melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8054, "SACO FRIZA", "4 AL 8", "", "10 AL 14", "", "", "", "Topo, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8055, "ENTERITO PIEL CONEJO", "0 AL 2", "", "", "", "", "", "Rosa, rojo, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8056, "ENTERITO PIEL OSO PANDA", "0 AL 2", "", "", "", "", "", "Beige, rojo, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8057, "ENTERITO FRIZA OSO", "0 AL 2", "", "", "", "", "", "Rojo con azul, melange con rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8059, "ASTRONAUTA ESTAMPADO", "1 AL 3", "", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8060, "ASTRONAUTA BORDADO", "1 AL 3", "", "", "", "", "", "Rojo, gris, aero, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8062, "POLLERA CUERINA", "", "", "8 AL 12", "", "14 al 16", "", "Negra", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8063, "BUZO CON CIERRE", "", "", "8 AL 12", "", "14 al 16", "", "Topo con melange, rojo con negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8064, "PANTALON COMBINADO", "", "", "8 AL 12", "", "14 al 16", "", "Topo con melange, rojo con negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8065, "CHALECO BEBA OREJAS", "1 AL 5", "", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8066, "CHALECO BEBE", "1 AL 5", "", "", "", "", "", "Rojo, naranja, azul marino, verde", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8067, "CAMPERA BEBE  ", "1 AL 5", "", "", "", "", "", "Fondo azul/gris/rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8068, "CHALECO METALIZADO NENA", "4 al 14", "", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8069, "CAMPERA ESTAMPADA", "4 AL 8", "", "10 AL 14", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8070, "CAMPERON METALIZADO", "4 AL 8", "", "10 AL 14", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8072, "CHALECO VARON", "4 AL 8", "", "10 AL 14", "", "", "", "Gris, negro, marino", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8073, "CAMPERA VARON", "4 AL 8", "", "10 AL 14", "", "", "", "Rojo, azul, negro, gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8074, "TAPADO ESTAMPADA BEBA", "1 AL 5", "", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8075, "TAPADO CON CORDERITO", "1 AL 5", "", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8076, "CAMPERA PIEL CON FOIL", "4 AL 8", "", "10 AL 14", "", "", "", "Fucsia, rosa chicle, crudo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8077, "CAMPERA BEBE CAMUFLADA", "1 AL 5", "", "", "", "", "", "Marino, verde militar", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8078, "CALZA TERMICA", "1 AL 5", "", "", "", "", "", "Negro, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8079, "VESTIDO TELA ESTRELLAS", "4 AL 8", "", "10 AL 14", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8080, "CAMPERA PIEL CON FOIL", "1 AL 5", "", "", "", "", "", "Fucsia, rosa chicle, crudo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(8081, "REMERA CON VOLADO", "", "", "", "", "", "", "Azul - francia", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.));
            //list.Add(new Models.Clouth(8082, "", "", "", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.));

            list.Add(new Models.Clouth(8020, "CAMPERA PIEL", "1 AL 5", "", "", "", "", "", "Crudo, rojo, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8022, "CAMPERA PIEL BORD", "1 AL 5", "", "", "", "", "", "Rojo, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8074, "TAPADO ESTAMPADA BEBA", "1 AL 5", "", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8074-2"));
            list.Add(new Models.Clouth(8075, "TAPADO CON CORDERITO", "1 AL 5", "", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8075-2"));
            return list.OrderBy(x => x.Id);
        }

    }
}