using MvcApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcApplication2.DataLoad
{
    public class ClouthDataLoader
    {
        public static IEnumerable<Models.Clouth> Data(Guid? type)
        {
            IEnumerable<Models.Clouth> data = null;
            if (type == null)
                return GetAll();
            switch (type.ToString())
            {
                case "8f6ecf5a-c8f3-4739-913e-f7c4332aa0c0":
                    data = GetAllXMayorPrecioVenta();
                    break;                   
                case "b816fa50-7828-4bf8-88d8-1a841c30d51f":
                    //NEGOCIO x-mayor
                    data = GetAllNegocioXMayor();
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
                case "c0f589e3-ccfd-4367-b3d6-247af4ef28d9":
                    //NEGOCIO x-mayor OLD
                    data = GetAllNegocioXMayorOld();
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
            list.AddRange(GetAllClouthFactory().Select(x => x.GetNegocio()));
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

            //modif
            list.Add(new Models.Clouth(8068, "Chaleco metalizado nena", "4 al 14", "$ 570,00", "4 al 14", "$ 390,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, promocion: true));
            //new
            list.Add(new Models.Clouth(8001, "REMERA GATITA BEBA", "1 AL 5", "$ 225,00", "1 AL 5", "$ 150,00", "", "", "Rosa, crudo, blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, action: ""));
            list.Add(new Models.Clouth(8001, "REMERA GATITA BEBA", "1 AL 5", "$ 225,00", "1 AL 5", "$ 150,00", "", "", "Rosa, crudo, blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, action: "", imgName: "8001-1"));
            list.Add(new Models.Clouth(8007, "BUZO PIEL", "1 AL 4", "$ 425,00", "1 AL 4", "$ 285,00", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8021, "PANTALON FRIZA CON RECORTE", "1 AL 5", "$ 247,00", "1 AL 5", "$ 165,00", "", "", "Melange, marino, topo, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));

            list.Add(new Models.Clouth(8038, "BUZO PIEL", "4 AL 8", "$ 510,00", "4 AL 8", "$ 340,00", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8038, "BUZO PIEL", "10 AL 14", "$ 545,00", "10 AL 14", "$ 365,00", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8038, "BUZO PIEL", "4 AL 8", "$ 510,00", "4 AL 8", "$ 340,00", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8038-1"));
            list.Add(new Models.Clouth(8038, "BUZO PIEL", "10 AL 14", "$ 545,00", "10 AL 14", "$ 365,00", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8038-1"));
            list.Add(new Models.Clouth(8048, "PANTALON C/ RECORTE", "4 AL 8", "$ 388,00", "4 AL 8", "$ 259,00", "", "", "Negro, topo, melange, marino", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8048, "PANTALON C/ RECORTE", "10 AL 14", "$ 418,00", "10 AL 14", "$ 279,00", "", "", "Negro, topo, melange, marino", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8068, "Chaleco metalizado nena", "4 al 14", "$ 570,00", "4 al 14", "$ 390,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, promocion: true, imgName: "8068-1"));

            list.Add(new Models.Clouth(8075, "TAPADO CON CORDERITO", "1 AL 5", "$ 935,00", "1 AL 5", "$ 625,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8075, "TAPADO CON CORDERITO", "1 AL 5", "$ 935,00", "1 AL 5", "$ 625,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8075-2"));
            list.Add(new Models.Clouth(8075, "TAPADO CON CORDERITO", "1 AL 5", "$ 935,00", "1 AL 5", "$ 625,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8075-3"));
            list.Add(new Models.Clouth(8065, "CHALECO BEBA OREJAS", "1 AL 5", "$ 595,00", "1 AL 5", "$ 399,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8065, "CHALECO BEBA OREJAS", "1 AL 5", "$ 595,00", "1 AL 5", "$ 399,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8065-1"));
            list.Add(new Models.Clouth(8065, "CHALECO BEBA OREJAS", "1 AL 5", "$ 595,00", "1 AL 5", "$ 399,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8065-2"));
            list.Add(new Models.Clouth(8065, "CHALECO BEBA OREJAS", "1 AL 5", "$ 595,00", "1 AL 5", "$ 399,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8065-3"));
            list.Add(new Models.Clouth(8016, "BUZO DINO", "1 AL 5", "$ 420,00", "1 AL 5", "$ 280,00", "", "", "Marino, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));

            //DEBERIA CORREGIR
            return list.OrderByDescending(x => x.Id).ToList();
        }

        private static IEnumerable<Models.ClouthFactory> GetAllClouthFactory()
        {
            var list = new List<ClouthFactory>();
            list.Add(new Models.ClouthFactory(8106, "PANTALON RUSTICO UNISEX", new PriceByList("1 AL 5", "$ 195,00", "", ""), new PriceByList("1 AL 5", "$ 168,00", "", ""), new PriceByList("1 AL 5", "$ 166,00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES,imgName:"8106-2"));
            list.Add(new Models.ClouthFactory(8133, "CALZA SIMIL JEAN NENA", new PriceByList("4 AL 8", "$ 326,00", "10 AL 14", "$ 353,00"), new PriceByList("4 AL 8", "$ 280,00", "10 AL 14", "$ 304,00"), new PriceByList("4 AL 8", "$ 277,00", "10 AL 14", "$ 300,00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES,imgName:"8133-2"));
            list.Add(new Models.ClouthFactory(8175, "ENTERITO COCODRILO", new PriceByList("0 AL 3", "$ 262.00", "", ""), new PriceByList("0 AL 3", "$ 225.00", "", ""), new PriceByList("0 AL 3", "$ 223.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, imgName: "8175-2"));
            list.Add(new Models.ClouthFactory(8164, "SHORT DE BANO", new PriceByList("1 AL 5", "$ 246.00", "", ""), new PriceByList("1 AL 5", "$ 212.00", "", ""), new PriceByList("1 AL 5", "$ 209.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, imgName: "8164-2"));
            list.Add(new Models.ClouthFactory(8162, "REMERA SIN MANGAS TIBURON", new PriceByList("1 AL 5", "$ 240.00", "", ""), new PriceByList("1 AL 5", "$ 216.00", "", ""), new PriceByList("1 AL 5", "$ 216.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, imgName: "8162-2"));
            list.Add(new Models.ClouthFactory(8108, "ROMPEVIENTO BEBE ESTAMPADO", new PriceByList("1 AL 5", "$ 572.00", "", ""), new PriceByList("1 AL 5", "$ 491.00", "", ""), new PriceByList("1 AL 5", "$ 486.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, imgName: "8108-2"));
            list.Add(new Models.ClouthFactory(8108, "ROMPEVIENTO BEBE ESTAMPADO", new PriceByList("1 AL 5", "$ 572.00", "", ""), new PriceByList("1 AL 5", "$ 491.00", "", ""), new PriceByList("1 AL 5", "$ 486.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, imgName: "8108-3"));

            //list.Add(new Models.ClouthFactory(8101, "ROMPEVIENTO BEBA LISO", new PriceByList("1 AL 5", "$ 487.00", "", ""), new PriceByList("1 AL 5", "$ 419.00", "", ""), new PriceByList("1 AL 5", "$ 414.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8102, "ROMPEVIENTO BEBA ESTAMP.", new PriceByList("1 AL 5", "$ 590.00", "", ""), new PriceByList("1 AL 5", "$ 507.00", "", ""), new PriceByList("1 AL 5", "$ 501.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8103, "JUMPER GABARDINA", new PriceByList("1 AL 5", "$ 298.00", "", ""), new PriceByList("1 AL 5", "$ 256.00", "", ""), new PriceByList("1 AL 5", "$ 253.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8104, "CALZA C/MONO", new PriceByList("1 AL 5", "$ 180.00", "", ""), new PriceByList("1 AL 5", "$ 155.00", "", ""), new PriceByList("1 AL 5", "$ 153.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8105, "CALZA SIMIL JEAN", new PriceByList("1 AL 5", "$ 206.00", "", ""), new PriceByList("1 AL 5", "$ 177.00", "", ""), new PriceByList("1 AL 5", "$ 175.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8106, "PANTALON RUSTICO UNISEX", new PriceByList("1 AL 5", "$ 195.00", "", ""), new PriceByList("1 AL 5", "$ 168.00", "", ""), new PriceByList("1 AL 5", "$ 166.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8107, "ROMPEVIENTO BEBE", new PriceByList("1 AL 5", "$ 474.00", "", ""), new PriceByList("1 AL 5", "$ 408.00", "", ""), new PriceByList("1 AL 5", "$ 403.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8108, "ROMPEVIENTO BEBE ESTAMPADO", new PriceByList("1 AL 5", "$ 572.00", "", ""), new PriceByList("1 AL 5", "$ 491.00", "", ""), new PriceByList("1 AL 5", "$ 486.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8109, "PANTALON CON RECORTES", new PriceByList("1 AL 5", "$ 209.00", "", ""), new PriceByList("1 AL 5", "$ 180.00", "", ""), new PriceByList("1 AL 5", "$ 178.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8110, "ROMPEVIENTO NENA", new PriceByList("4 AL 8", "$ 600.00", "10 AL 14", "$ 650.00"), new PriceByList("4 AL 8", "$ 516.00", "10 AL 14", "$ 560.00"), new PriceByList("4 AL 8", "$ 510.00", "10 AL 14", "$ 553.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8111, "ROMPEVIENTO NENA C/ESTRELLAS", new PriceByList("4 AL 8", "$ 717.00", "10 AL 14", "$ 777.00"), new PriceByList("4 AL 8", "$ 617.00", "10 AL 14", "$ 668.00"), new PriceByList("4 AL 8", "$ 610.00", "10 AL 14", "$ 661.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8112, "JOGGINETA NENA", new PriceByList("4 AL 8", "$ 300.00", "10 AL 14", "$ 325.00"), new PriceByList("4 AL 8", "$ 258.00", "10 AL 14", "$ 280.00"), new PriceByList("4 AL 8", "$ 255.00", "10 AL 14", "$ 277.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8113, "CALZA C/TIRAS CRUZADAS", new PriceByList("4 AL 8", "$ 232.00", "10 AL 14", "$ 251.00"), new PriceByList("4 AL 8", "$ 199.00", "10 AL 14", "$ 216.00"), new PriceByList("4 AL 8", "$ 197.00", "10 AL 14", "$ 214.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8114, "POLLERA JEAN", new PriceByList("4 AL 8", "$ 405.00", "10 AL 14", "$ 439.00"), new PriceByList("4 AL 8", "$ 348.00", "10 AL 14", "$ 378.00"), new PriceByList("4 AL 8", "$ 344.00", "10 AL 14", "$ 373.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8115, "POLLERA ENGOMADA", new PriceByList("", "", "8 AL 14", "$ 289.00"), new PriceByList("", "", "8 AL 14", "$ 249.00"), new PriceByList("", "", "8 AL 14", "$ 246.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8116, "JUMPER JEAN", new PriceByList("4 AL 8", "$ 375.00", "10 AL 14", "$ 406.00"), new PriceByList("4 AL 8", "$ 322.00", "10 AL 14", "$ 349.00"), new PriceByList("4 AL 8", "$ 319.00", "10 AL 14", "$ 345.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8117, "ROMPEVIENTO VARON C/RED", new PriceByList("4 AL 8", "$ 624.00", "10 AL 14", "$ 676.00"), new PriceByList("4 AL 8", "$ 536.00", "10 AL 14", "$ 581.00"), new PriceByList("4 AL 8", "$ 530.00", "10 AL 14", "$ 574.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8118, "ROMPEVIENTO VARON ESTAMP", new PriceByList("4 AL 8", "$ 773.00", "10 AL 14", "$ 837.00"), new PriceByList("4 AL 8", "$ 665.00", "10 AL 14", "$ 720.00"), new PriceByList("4 AL 8", "$ 657.00", "10 AL 14", "$ 712.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8119, "PANTALON RUSTICOC/RECORTES", new PriceByList("4 AL 8", "$ 330.00", "10 AL 14", "$ 358.00"), new PriceByList("4 AL 8", "$ 283.00", "10 AL 14", "$ 308.00"), new PriceByList("4 AL 8", "$ 281.00", "10 AL 14", "$ 304.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8133, "CALZA SIMIL JEAN NENA", new PriceByList("4 AL 8", "$ 326.00", "10 AL 14", "$ 353.00"), new PriceByList("4 AL 8", "$ 280.00", "10 AL 14", "$ 304.00"), new PriceByList("4 AL 8", "$ 277.00", "10 AL 14", "$ 300.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8120, "JUMPER DE JEAN", new PriceByList("1 AL 5", "$ 455.00", "", ""), new PriceByList("1 AL 5", "$ 391.00", "", ""), new PriceByList("1 AL 5", "$ 387.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8121, "JARDINERO JEAN GATITA", new PriceByList("1 AL 4", "$ 477.00", "", ""), new PriceByList("1 AL 4", "$ 410.00", "", ""), new PriceByList("1 AL 4", "$ 405.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8122, "SHORT JEAN C/ PUNTILLA", new PriceByList("1 AL 5", "$ 311.00", "", ""), new PriceByList("1 AL 5", "$ 268.00", "", ""), new PriceByList("1 AL 5", "$ 265.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8123, "SHORT JEAN  BORDADO", new PriceByList("1 AL 5", "$ 353.00", "", ""), new PriceByList("1 AL 5", "$ 304.00", "", ""), new PriceByList("1 AL 5", "$ 300.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8124, "SHORT FIBRANA", new PriceByList("1 AL 5", "$ 201.00", "", ""), new PriceByList("1 AL 5", "$ 172.00", "", ""), new PriceByList("1 AL 5", "$ 170.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8125, "ENTERITO ESTAMPADO", new PriceByList("1 AL 5", "$ 214.00", "", ""), new PriceByList("1 AL 5", "$ 184.00", "", ""), new PriceByList("1 AL 5", "$ 182.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8126, "REMERA C/VOLADOS", new PriceByList("1 AL 5", "$ 167.00", "", ""), new PriceByList("1 AL 5", "$ 150.00", "", ""), new PriceByList("1 AL 5", "$ 150.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8127, "REMERA CON ARCOIRIS", new PriceByList("1 AL 5", "$ 185.00", "", ""), new PriceByList("1 AL 5", "$ 167.00", "", ""), new PriceByList("1 AL 5", "$ 167.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8128, "REMERON C/PUNTILLA", new PriceByList("1 1L 5", "$ 189.00", "", ""), new PriceByList("1 1L 5", "$ 170.00", "", ""), new PriceByList("1 1L 5", "$ 170.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8129, "VESTIDO CON GALON", new PriceByList("1 AL 5", "$ 249.00", "", ""), new PriceByList("1 AL 5", "$ 214.00", "", ""), new PriceByList("1 AL 5", "$ 211.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8130, "VESTIDO UNICORNIO", new PriceByList("1 AL 5", "$ 180.00", "", ""), new PriceByList("1 AL 5", "$ 155.00", "", ""), new PriceByList("1 AL 5", "$ 153.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8131, "VESTIDO ESTAMPADO", new PriceByList("1 AL 5", "$ 361.00", "", ""), new PriceByList("1 AL 5", "$ 310.00", "", ""), new PriceByList("1 AL 5", "$ 307.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8132, "VESTIDO FIBRANA", new PriceByList("1 AL 5", "$ 384.00", "", ""), new PriceByList("1 AL 5", "$ 330.00", "", ""), new PriceByList("1 AL 5", "$ 326.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8134, "SOLERO FIBRANA", new PriceByList("1 AL 5", "$ 368.00", "", ""), new PriceByList("1 AL 5", "$ 316.00", "", ""), new PriceByList("1 AL 5", "$ 313.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8135, "VESTIDO PLUMETI", new PriceByList("1 AL 5", "$ 360.00", "", ""), new PriceByList("1 AL 5", "$ 309.00", "", ""), new PriceByList("1 AL 5", "$ 306.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8136, "REMERA CAMARA DE FOTOS", new PriceByList("4 AL 8", "$ 190.00", "10 AL 14", "$ 206.00"), new PriceByList("4 AL 8", "$ 171.00", "10 AL 14", "$ 185.00"), new PriceByList("4 AL 8", "$ 171.00", "10 AL 14", "$ 185.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8137, "REMERA CON VOLADO", new PriceByList("4 AL 8", "$ 165.00", "10 AL 14", "$ 179.00"), new PriceByList("4 AL 8", "$ 148.00", "10 AL 14", "$ 161.00"), new PriceByList("4 AL 8", "$ 148.00", "10 AL 14", "$ 161.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8138, "REMERA ESTAMPADA", new PriceByList("4 AL 8", "$ 145.00", "10 AL 14", "$ 157.00"), new PriceByList("4 AL 8", "$ 131.00", "10 AL 14", "$ 142.00"), new PriceByList("4 AL 8", "$ 131.00", "10 AL 14", "$ 142.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8139, "REMERA CORAZON", new PriceByList("4 AL 8", "$ 289.00", "10 AL 14", "$ 313.00"), new PriceByList("4 AL 8", "$ 260.00", "10 AL 14", "$ 282.00"), new PriceByList("4 AL 8", "$ 260.00", "10 AL 14", "$ 282.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.ClouthFactory(8140, "REMERA SI MANGAS ARCO IRIS", new PriceByList("4 AL 8", "$ 194.00", "10 AL 14", "$ 210.00"), new PriceByList("4 AL 8", "$ 174.00", "10 AL 14", "$ 189.00"), new PriceByList("4 AL 8", "$ 174.00", "10 AL 14", "$ 189.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8141, "SHORT FIBRANA", new PriceByList("4 AL 8", "$ 236.00", "10 AL  14", "$ 256.00"), new PriceByList("4 AL 8", "$ 203.00", "10 AL  14", "$ 220.00"), new PriceByList("4 AL 8", "$ 200.00", "10 AL  14", "$ 217.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8142, "SHORT LISO", new PriceByList("4 AL 8", "$ 330.00", "10 AL 14", "$ 357.00"), new PriceByList("4 AL 8", "$ 284.00", "10 AL 14", "$ 307.00"), new PriceByList("4 AL 8", "$ 280.00", "10 AL 14", "$ 304.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8143, "SHORT DE JEAN", new PriceByList("4 AL 8", "$ 388.00", "10 AL 14", "$ 420.00"), new PriceByList("4 AL 8", "$ 334.00", "10 AL 14", "$ 361.00"), new PriceByList("4 AL 8", "$ 330.00", "10 AL 14", "$ 357.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8144, "ENTERITO ESTAMPADO", new PriceByList("4 AL 8", "$ 255.00", "10 AL 14", "$ 276.00"), new PriceByList("4 AL 8", "$ 219.00", "10 AL 14", "$ 237.00"), new PriceByList("4 AL 8", "$ 216.00", "10 AL 14", "$ 234.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.ClouthFactory(8145, "ENTERITO DEPORTIVO", new PriceByList("4 AL 8", "$ 242.00", "10 AL 14", "$ 262.00"), new PriceByList("4 AL 8", "$ 208.00", "10 AL 14", "$ 225.00"), new PriceByList("4 AL 8", "$ 205.00", "10 AL 14", "$ 223.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.ClouthFactory(8146, "ENTERITO VESTIDO", new PriceByList("4 AL 8", "$ 468.00", "10 AL 14", "$ 507.00"), new PriceByList("4 AL 8", "$ 403.00", "10 AL 14", "$ 436.00"), new PriceByList("4 AL 8", "$ 398.00", "10 AL 14", "$ 431.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8147, "SOLERO RAYADO", new PriceByList("4 AL 8", "$ 353.00", "10 AL 14", "$ 382.00"), new PriceByList("4 AL 8", "$ 303.00", "10 AL 14", "$ 329.00"), new PriceByList("4 AL 8", "$ 300.00", "10 AL 14", "$ 325.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8148, "VESTIDO FIBRANA C/VOLADOS", new PriceByList("4 AL 8", "$ 555.00", "10 AL 14", "$ 601.00"), new PriceByList("4 AL 8", "$ 477.00", "10 AL 14", "$ 517.00"), new PriceByList("4 AL 8", "$ 471.00", "10 AL 14", "$ 511.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8149, "VESTIDO FIBRANA C/NUDO", new PriceByList("4 AL 8", "$ 555.00", "10 AL 14", "$ 601.00"), new PriceByList("4 AL 8", "$ 477.00", "10 AL 14", "$ 517.00"), new PriceByList("4 AL 8", "$ 471.00", "10 AL 14", "$ 511.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8150, "SOLERO FIBRANA", new PriceByList("4 AL 8", "$ 555.00", "10 AL 14", "$ 601.00"), new PriceByList("4 AL 8", "$ 477.00", "10 AL 14", "$ 517.00"), new PriceByList("4 AL 8", "$ 471.00", "10 AL 14", "$ 511.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8151, "VESTIDO PLUMETI", new PriceByList("4 AL 8", "$ 587.00", "10 AL 14", "$ 636.00"), new PriceByList("4 AL 8", "$ 505.00", "10 AL 14", "$ 547.00"), new PriceByList("4 AL 8", "$ 499.00", "10 AL 14", "$ 541.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8152, "JARDINERO DE JEAN", new PriceByList("4 AL 8", "$ 559.00", "10 AL 14", "$ 606.00"), new PriceByList("4 AL 8", "$ 481.00", "10 AL 14", "$ 521.00"), new PriceByList("4 AL 8", "$ 475.00", "10 AL 14", "$ 515.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8153, "CAMPERA GABARDINA ELASTIZA", new PriceByList("4 AL 8", "$ 651.00", "10 AL 14", "$ 705.00"), new PriceByList("4 AL 8", "$ 560.00", "10 AL 14", "$ 606.00"), new PriceByList("4 AL 8", "$ 553.00", "10 AL 14", "$ 599.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8154, "REMERA LETS GO", new PriceByList("1 AL 5", "$ 183.00", "", ""), new PriceByList("1 AL 5", "$ 164.00", "", ""), new PriceByList("1 AL 5", "$ 164.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8155, "REMERA C/BOLSILLO", new PriceByList("1 AL 5", "$ 144.00", "", ""), new PriceByList("1 AL 5", "$ 129.00", "", ""), new PriceByList("1 AL 5", "$ 129.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8156, "REMERA C/CARTERA", new PriceByList("1 AL 5", "$ 162.00", "", ""), new PriceByList("1 AL 5", "$ 146.00", "", ""), new PriceByList("1 AL 5", "$ 146.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.ClouthFactory(8157, "REMERA CAMALEON", new PriceByList("1 AL 5", "$ 220.00", "", ""), new PriceByList("1 AL 5", "$ 198.00", "", ""), new PriceByList("1 AL 5", "$ 198.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8158, "SHORT CAMUFLADO", new PriceByList("1 AL 5", "$ 140.00", "", ""), new PriceByList("1 AL 5", "$ 120.00", "", ""), new PriceByList("1 AL 5", "$ 119.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.ClouthFactory(8159, "SHORT RUSTICO", new PriceByList("1 AL 5", "$ 167.00", "", ""), new PriceByList("1 AL 5", "$ 144.00", "", ""), new PriceByList("1 AL 5", "$ 142.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8160, "BERMUDA", new PriceByList("1 AL 5", "$ 285.00", "", ""), new PriceByList("1 AL 5", "$ 245.00", "", ""), new PriceByList("1 AL 5", "$ 242.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.ClouthFactory(8161, "BERMUDA JEAN", new PriceByList("1 AL 5", "$ 362.00", "", ""), new PriceByList("1 AL 5", "$ 312.00", "", ""), new PriceByList("1 AL 5", "$ 308.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8162, "REMERA SIN MANGAS TIBURON", new PriceByList("1 AL 5", "$ 240.00", "", ""), new PriceByList("1 AL 5", "$ 216.00", "", ""), new PriceByList("1 AL 5", "$ 216.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8163, "JARDINERO", new PriceByList("1 AL 5", "$ 427.00", "", ""), new PriceByList("1 AL 5", "$ 367.00", "", ""), new PriceByList("1 AL 5", "$ 363.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8164, "SHORT DE BANO", new PriceByList("1 AL 5", "$ 246.00", "", ""), new PriceByList("1 AL 5", "$ 212.00", "", ""), new PriceByList("1 AL 5", "$ 209.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8165, "REMERA PARADISE", new PriceByList("4 AL 8", "$ 215.00", "10 AL 14", "$ 233.00"), new PriceByList("4 AL 8", "$ 193.00", "10 AL 14", "$ 209.00"), new PriceByList("4 AL 8", "$ 193.00", "10 AL 14", "$ 209.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8166, "REMERA CON RED", new PriceByList("4 AL 8", "$ 215.00", "10 AL 14", "$ 233.00"), new PriceByList("4 AL 8", "$ 193.00", "10 AL 14", "$ 209.00"), new PriceByList("4 AL 8", "$ 193.00", "10 AL 14", "$ 209.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8167, "BERMUDA RUSTICA", new PriceByList("4 AL 8", "$ 244.00", "10 AL 14", "$ 265.00"), new PriceByList("4 AL 8", "$ 210.00", "10 AL 14", "$ 227.00"), new PriceByList("4 AL 8", "$ 207.00", "10 AL 14", "$ 225.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.ClouthFactory(8168, "BERMUDA CON BOTON", new PriceByList("4 AL 8", "$ 254.00", "10 AL 14", "$ 275.00"), new PriceByList("4 AL 8", "$ 218.00", "10 AL 14", "$ 236.00"), new PriceByList("4 AL 8", "$ 216.00", "10 AL 14", "$ 234.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8169, "BERMUDA JEAN", new PriceByList("4 AL 8", "$ 404.00", "10 AL 14", "$ 438.00"), new PriceByList("4 AL 8", "$ 347.00", "10 AL 14", "$ 376.00"), new PriceByList("4 AL 8", "$ 343.00", "10 AL 14", "$ 372.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.ClouthFactory(8170, "REMERA SIN MANGAS", new PriceByList("4 AL 8", "", "10 AL 14", ""), new PriceByList("4 AL 8", "", "10 AL 14", ""), new PriceByList("4 AL 8", "", "10 AL 14", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8171, "VESTIGO GATITA", new PriceByList("0 AL 3", "$ 270.00", "", ""), new PriceByList("0 AL 3", "$ 232.00", "", ""), new PriceByList("0 AL 3", "$ 229.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8172, "VESTIDO CONVOLADO", new PriceByList("0 AL 3", "$ 305.00", "", ""), new PriceByList("0 AL 3", "$ 262.00", "", ""), new PriceByList("0 AL 3", "$ 259.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8173, "VESTIDO PLUMETI", new PriceByList("0 AL 3", "$ 336.00", "", ""), new PriceByList("0 AL 3", "$ 289.00", "", ""), new PriceByList("0 AL 3", "$ 285.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8174, "ENTERITO FLAMENCO", new PriceByList("0 AL 3", "$ 262.00", "", ""), new PriceByList("0 AL 3", "$ 225.00", "", ""), new PriceByList("0 AL 3", "$ 223.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8175, "ENTERITO COCODRILO", new PriceByList("0 AL 3", "$ 262.00", "", ""), new PriceByList("0 AL 3", "$ 225.00", "", ""), new PriceByList("0 AL 3", "$ 223.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8176, "SHORT DE BAÑO", new PriceByList("4 AL 8", "$ 286.00", "10 AL 14", "$ 310.00"), new PriceByList("4 AL 8", "$ 246.00", "10 AL 14", "$ 266.00"), new PriceByList("4 AL 8", "$ 243.00", "10 AL 14", "$ 263.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8177, "JARDINERO ESTRELLA", new PriceByList("4 AL 8", "$ 529.00", "10 AL 14", "$ 573.00"), new PriceByList("4 AL 8", "$ 454.00", "10 AL 14", "$ 492.00"), new PriceByList("4 AL 8", "$ 449.00", "10 AL 14", "$ 487.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.ClouthFactory(8178, "", new PriceByList("", "", "", ""), new PriceByList("", "", "", ""), new PriceByList("", "", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8179, "SOLERO ESTAMPADO", new PriceByList("4 AL 8", "$ 370.00", "10 AL 14", "$ 401.00"), new PriceByList("4 AL 8", "$ 318.00", "10 AL 14", "$ 345.00"), new PriceByList("4 AL 8", "$ 315.00", "10 AL 14", "$ 341.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8180, "REMERA MARIPOSA", new PriceByList("1 AL 5", "$ 146.00", "", ""), new PriceByList("1 AL 5", "$ 131.00", "", ""), new PriceByList("1 AL 5", "$ 131.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8181, "REMERA LISA CON NUDO", new PriceByList("1 AL 5", "$ 195.00", "", ""), new PriceByList("1 AL 5", "$ 175.00", "", ""), new PriceByList("1 AL 5", "$ 175.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.ClouthFactory(8182, "CAMPERA DE JEAN", new PriceByList("4 AL 8", "$ 684.00", "10 AL 14", "$ 741.00"), new PriceByList("4 AL 8", "$ 588.00", "10 AL 14", "$ 637.00"), new PriceByList("4 AL 8", "$ 581.00", "10 AL 14", "$ 630.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8183, "MAYA BARQUITOS", new PriceByList("1 AL 5", "$ 212.00", "", ""), new PriceByList("1 AL 5", "$ 182.00", "", ""), new PriceByList("1 AL 5", "$ 180.00", "", ""), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.ClouthFactory(8184, "MAYA PALMERA", new PriceByList("4 AL 8", "$ 236.00", "10 AL 14", "$ 256.00"), new PriceByList("4 AL 8", "$ 203.00", "10 AL 14", "$ 220.00"), new PriceByList("4 AL 8", "$ 200.00", "10 AL 14", "$ 217.00"), "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));

            return list;
        }

        public static IEnumerable<Clouth> GetAllNegocioXMayorOld()
        {
            var list = new List<Models.Clouth>();
            //list.AddRange(GetAllClouthFactory().Select(x => x.GetNegocio()));
            list.Add(new Models.Clouth(7598, "Tapado con piel", "4 al 14", "$ 620,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8001, "REMERA GATITA BEBA", "1 AL 5", "$ 150,00", "", "", "", "", "Rosa, crudo, blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, action: ""));
            list.Add(new Models.Clouth(8001, "REMERA GATITA BEBA", "1 AL 5", "$ 150,00", "", "", "", "", "Rosa, crudo, blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, action: "", imgName: "8001-1"));
            list.Add(new Models.Clouth(8006, "BUZO CON VOLADO", "1 AL 5", "$ 299,00", "", "", "", "", "Rosa chicle, melange, verde beneton", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8006, "BUZO CON VOLADO", "1 AL 5", "$ 299,00", "", "", "", "", "Rosa chicle, melange, verde beneton", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8006-1"));
            list.Add(new Models.Clouth(8006, "BUZO CON VOLADO", "1 AL 5", "$ 299,00", "", "", "", "", "Rosa chicle, melange, verde beneton", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8006-2"));
            list.Add(new Models.Clouth(8007, "BUZO PIEL", "1 AL 4", "$ 285,00", "", "", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8007, "BUZO PIEL", "1 AL 4", "$ 285,00", "", "", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8007-1"));
            list.Add(new Models.Clouth(8021, "PANTALON FRIZA CON RECORTE", "1 AL 5", "$ 165,00", "", "", "", "", "Melange, marino, topo, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8021, "PANTALON FRIZA CON RECORTE", "1 AL 5", "$ 165,00", "", "", "", "", "Melange, marino, topo, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, imgName: "8021-1"));
            list.Add(new Models.Clouth(8021, "PANTALON FRIZA CON RECORTE", "1 AL 5", "$ 165,00", "", "", "", "", "Melange, marino, topo, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, imgName: "8021-2"));
            list.Add(new Models.Clouth(8021, "PANTALON FRIZA CON RECORTE", "1 AL 5", "$ 165,00", "", "", "", "", "Melange, marino, topo, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, imgName: "8021-3"));
            list.Add(new Models.Clouth(8021, "PANTALON FRIZA CON RECORTE", "1 AL 5", "$ 165,00", "", "", "", "", "Melange, marino, topo, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, imgName: "8021-4"));
            list.Add(new Models.Clouth(8028, "JARDINERO JEAN", "1 AL 4", "$ 415,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8028, "JARDINERO JEAN", "1 AL 4", "$ 415,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, imgName: "8028-1"));
            list.Add(new Models.Clouth(8030, "REMERA RAYADA", "4 AL 8", "$ 143,00", "10 AL 14", "$ 153,00", "", "", "rayado rojo, rayado bordo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8032, "PANTALON RUSTICO", "4 AL 8", "$ 225,00", "10 AL 14", "$ 238,00", "", "", "melange, fucsia, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8038, "BUZO PIEL", "4 AL 8", "$ 340,00", "10 AL 14", "$ 365,00", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8046, "REMERA C/ AURICULARES VARON", "4 AL 8", "$ 185,00", "10 AL 14", "$ 198,00", "", "", "Melange, oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8046, "REMERA C/ AURICULARES VARON", "4 AL 8", "$ 185,00", "10 AL 14", "$ 198,00", "", "", "Melange, oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8046-1"));
            list.Add(new Models.Clouth(8047, "REMERA ESTAMPADA", "4 AL 8", "$ 193,00", "10 AL 14", "$ 203,00", "", "", "Melange, oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8047, "REMERA ESTAMPADA", "4 AL 8", "$ 193,00", "10 AL 14", "$ 203,00", "", "", "Melange, oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8047-1"));
            list.Add(new Models.Clouth(8048, "PANTALON C/ RECORTE", "4 AL 8", "$ 259,00", "10 AL 14", "$ 279,00", "", "", "Negro, topo, melange, marino", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8051, "BUZO SKATE", "2 AL 8", "$ 395,00", "", "", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8051-1"));
            list.Add(new Models.Clouth(8051, "BUZO SKATE", "2 AL 8", "$ 395,00", "", "", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8051-2"));
            list.Add(new Models.Clouth(8051, "BUZO SKATE", "2 AL 8", "$ 395,00", "", "", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8051-3"));
            list.Add(new Models.Clouth(8051, "BUZO SKATE", "2 AL 8", "$ 395,00", "", "", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8051-4"));
            list.Add(new Models.Clouth(8051, "BUZO SKATE", "2 AL 8", "$ 395,00", "", "", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8051-5"));
            list.Add(new Models.Clouth(8052, "CAMPERA COMBINADA", "4 AL 8", "$ 470,00", "10 AL 14", "$ 505,00", "", "", "Rojo con topo, francia con melange, melange con negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8052, "CAMPERA COMBINADA", "4 AL 8", "$ 470,00", "10 AL 14", "$ 505,00", "", "", "Rojo con topo, francia con melange, melange con negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8052-1"));
            list.Add(new Models.Clouth(8052, "CAMPERA COMBINADA", "4 AL 8", "$ 470,00", "10 AL 14", "$ 505,00", "", "", "Rojo con topo, francia con melange, melange con negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8052-2"));
            list.Add(new Models.Clouth(8052, "CAMPERA COMBINADA", "4 AL 8", "$ 470,00", "10 AL 14", "$ 505,00", "", "", "Rojo con topo, francia con melange, melange con negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8052-3"));
            list.Add(new Models.Clouth(8056, "ENTERITO PIEL OSO PANDA", "0 AL 2", "$ 425,00", "", "", "", "", "Beige, rojo, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8060, "ASTRONAUTA BORDADO", "1 AL 3", "$ 610,00", "", "", "", "", "Rojo, gris, aero, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(8060, "ASTRONAUTA BORDADO", "1 AL 3", "$ 610,00", "", "", "", "", "Rojo, gris, aero, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES, imgName: "8060-1"));
            list.Add(new Models.Clouth(8060, "ASTRONAUTA BORDADO", "1 AL 3", "$ 610,00", "", "", "", "", "Rojo, gris, aero, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES, imgName: "8060-2"));
            list.Add(new Models.Clouth(8060, "ASTRONAUTA BORDADO", "1 AL 3", "$ 610,00", "", "", "", "", "Rojo, gris, aero, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES, imgName: "8060-3"));
            list.Add(new Models.Clouth(8060, "ASTRONAUTA BORDADO", "1 AL 3", "$ 610,00", "", "", "", "", "Rojo, gris, aero, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES, imgName: "8060-4"));
            list.Add(new Models.Clouth(8065, "CHALECO BEBA OREJAS", "1 AL 5", "$ 399,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8065, "CHALECO BEBA OREJAS", "1 AL 5", "$ 399,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8065-1"));
            list.Add(new Models.Clouth(8065, "CHALECO BEBA OREJAS", "1 AL 5", "$ 399,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8065-2"));
            list.Add(new Models.Clouth(8067, "CAMPERA BEBE  ", "1 AL 5", "$ 570,00", "", "", "", "", "Fondo azul/gris/rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(8067, "CAMPERA BEBE  ", "1 AL 5", "$ 570,00", "", "", "", "", "Fondo azul/gris/rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, imgName: "8067-1"));
            list.Add(new Models.Clouth(8067, "CAMPERA BEBE  ", "1 AL 5", "$ 570,00", "", "", "", "", "Fondo azul/gris/rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, imgName: "8067-2"));
            list.Add(new Models.Clouth(8067, "CAMPERA BEBE  ", "1 AL 5", "$ 570,00", "", "", "", "", "Fondo azul/gris/rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, imgName: "8067-3"));
            list.Add(new Models.Clouth(8069, "CAMPERA ESTAMPADA", "4 AL 8", "$ 790,00", "10 AL 14", "$ 850,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8069-1"));
            list.Add(new Models.Clouth(8069, "CAMPERA ESTAMPADA", "4 AL 8", "$ 790,00", "10 AL 14", "$ 850,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8069-2"));
            list.Add(new Models.Clouth(8069, "CAMPERA ESTAMPADA", "4 AL 8", "$ 790,00", "10 AL 14", "$ 850,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8069-3"));
            list.Add(new Models.Clouth(8069, "CAMPERA ESTAMPADA", "4 AL 8", "$ 790,00", "10 AL 14", "$ 850,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8069-4"));
            list.Add(new Models.Clouth(8069, "CAMPERA ESTAMPADA", "4 AL 8", "$ 790,00", "10 AL 14", "$ 850,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8069-5"));
            list.Add(new Models.Clouth(8080, "CAMPERA PIEL CON FOIL", "1 AL 5", "$ 378,00", "", "", "", "", "Fucsia, rosa chicle, crudo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(8083, "MEDIA POLERA LISA", "1 AL 5", "$ 98,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8083, "MEDIA POLERA LISA", "1 AL 5", "$ 98,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8083-1"));
            list.Add(new Models.Clouth(8083, "MEDIA POLERA LISA", "1 AL 5", "$ 98,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8083-2"));
            list.Add(new Models.Clouth(8083, "MEDIA POLERA LISA", "1 AL 5", "$ 98,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8083-3"));
            list.Add(new Models.Clouth(8084, "REMERA CON LOL", "1 AL 5", "$ 145,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(8084, "REMERA CON LOL", "1 AL 5", "$ 145,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8084-1"));
            list.Add(new Models.Clouth(8084, "REMERA CON LOL", "1 AL 5", "$ 145,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8084-2"));
            list.Add(new Models.Clouth(8085, "REMERA MANGA LARGA CAMUFLADA", "4 AL 8", "$ 198,00", "10 AL 14", "$ 218,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(8085, "REMERA MANGA LARGA CAMUFLADA", "4 AL 8", "$ 198,00", "10 AL 14", "$ 218,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8085-1"));
            return list.OrderBy(x => x.Id);
        }

        /// <summary>
        /// NEGOCIO POR MAYOR
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Models.Clouth> GetAllNegocioXMayor()
        {
            var list = new List<Models.Clouth>();
            list.AddRange(GetAllClouthFactory().Select(x => x.GetNegocio()));
            //list.Add(new Models.Clouth(7598, "Tapado con piel", "4 al 14", "$ 620,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(8001, "REMERA GATITA BEBA", "1 AL 5", "$ 150,00", "", "", "", "", "Rosa, crudo, blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, action: ""));
            //list.Add(new Models.Clouth(8001, "REMERA GATITA BEBA", "1 AL 5", "$ 150,00", "", "", "", "", "Rosa, crudo, blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, action: "", imgName: "8001-1"));
            //list.Add(new Models.Clouth(8006, "BUZO CON VOLADO", "1 AL 5", "$ 299,00", "", "", "", "", "Rosa chicle, melange, verde beneton", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(8006, "BUZO CON VOLADO", "1 AL 5", "$ 299,00", "", "", "", "", "Rosa chicle, melange, verde beneton", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8006-1"));
            //list.Add(new Models.Clouth(8006, "BUZO CON VOLADO", "1 AL 5", "$ 299,00", "", "", "", "", "Rosa chicle, melange, verde beneton", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8006-2"));
            //list.Add(new Models.Clouth(8007, "BUZO PIEL", "1 AL 4", "$ 285,00", "", "", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(8007, "BUZO PIEL", "1 AL 4", "$ 285,00", "", "", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8007-1"));
            //list.Add(new Models.Clouth(8021, "PANTALON FRIZA CON RECORTE", "1 AL 5", "$ 165,00", "", "", "", "", "Melange, marino, topo, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.Clouth(8021, "PANTALON FRIZA CON RECORTE", "1 AL 5", "$ 165,00", "", "", "", "", "Melange, marino, topo, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, imgName: "8021-1"));
            //list.Add(new Models.Clouth(8021, "PANTALON FRIZA CON RECORTE", "1 AL 5", "$ 165,00", "", "", "", "", "Melange, marino, topo, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, imgName: "8021-2"));
            //list.Add(new Models.Clouth(8021, "PANTALON FRIZA CON RECORTE", "1 AL 5", "$ 165,00", "", "", "", "", "Melange, marino, topo, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, imgName: "8021-3"));
            //list.Add(new Models.Clouth(8021, "PANTALON FRIZA CON RECORTE", "1 AL 5", "$ 165,00", "", "", "", "", "Melange, marino, topo, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, imgName: "8021-4"));
            //list.Add(new Models.Clouth(8028, "JARDINERO JEAN", "1 AL 4", "$ 415,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.Clouth(8028, "JARDINERO JEAN", "1 AL 4", "$ 415,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, imgName: "8028-1"));
            //list.Add(new Models.Clouth(8030, "REMERA RAYADA", "4 AL 8", "$ 143,00", "10 AL 14", "$ 153,00", "", "", "rayado rojo, rayado bordo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(8032, "PANTALON RUSTICO", "4 AL 8", "$ 225,00", "10 AL 14", "$ 238,00", "", "", "melange, fucsia, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(8038, "BUZO PIEL", "4 AL 8", "$ 340,00", "10 AL 14", "$ 365,00", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(8046, "REMERA C/ AURICULARES VARON", "4 AL 8", "$ 185,00", "10 AL 14", "$ 198,00", "", "", "Melange, oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            //list.Add(new Models.Clouth(8046, "REMERA C/ AURICULARES VARON", "4 AL 8", "$ 185,00", "10 AL 14", "$ 198,00", "", "", "Melange, oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8046-1"));
            //list.Add(new Models.Clouth(8047, "REMERA ESTAMPADA", "4 AL 8", "$ 193,00", "10 AL 14", "$ 203,00", "", "", "Melange, oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            //list.Add(new Models.Clouth(8047, "REMERA ESTAMPADA", "4 AL 8", "$ 193,00", "10 AL 14", "$ 203,00", "", "", "Melange, oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8047-1"));
            //list.Add(new Models.Clouth(8048, "PANTALON C/ RECORTE", "4 AL 8", "$ 259,00", "10 AL 14", "$ 279,00", "", "", "Negro, topo, melange, marino", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            //list.Add(new Models.Clouth(8051, "BUZO SKATE", "2 AL 8", "$ 395,00", "", "", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8051-1"));
            //list.Add(new Models.Clouth(8051, "BUZO SKATE", "2 AL 8", "$ 395,00", "", "", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8051-2"));
            //list.Add(new Models.Clouth(8051, "BUZO SKATE", "2 AL 8", "$ 395,00", "", "", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8051-3"));
            //list.Add(new Models.Clouth(8051, "BUZO SKATE", "2 AL 8", "$ 395,00", "", "", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8051-4"));
            //list.Add(new Models.Clouth(8051, "BUZO SKATE", "2 AL 8", "$ 395,00", "", "", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8051-5"));
            //list.Add(new Models.Clouth(8052, "CAMPERA COMBINADA", "4 AL 8", "$ 470,00", "10 AL 14", "$ 505,00", "", "", "Rojo con topo, francia con melange, melange con negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            //list.Add(new Models.Clouth(8052, "CAMPERA COMBINADA", "4 AL 8", "$ 470,00", "10 AL 14", "$ 505,00", "", "", "Rojo con topo, francia con melange, melange con negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8052-1"));
            //list.Add(new Models.Clouth(8052, "CAMPERA COMBINADA", "4 AL 8", "$ 470,00", "10 AL 14", "$ 505,00", "", "", "Rojo con topo, francia con melange, melange con negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8052-2"));
            //list.Add(new Models.Clouth(8052, "CAMPERA COMBINADA", "4 AL 8", "$ 470,00", "10 AL 14", "$ 505,00", "", "", "Rojo con topo, francia con melange, melange con negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8052-3"));
            //list.Add(new Models.Clouth(8056, "ENTERITO PIEL OSO PANDA", "0 AL 2", "$ 425,00", "", "", "", "", "Beige, rojo, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            //list.Add(new Models.Clouth(8060, "ASTRONAUTA BORDADO", "1 AL 3", "$ 610,00", "", "", "", "", "Rojo, gris, aero, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES));
            //list.Add(new Models.Clouth(8060, "ASTRONAUTA BORDADO", "1 AL 3", "$ 610,00", "", "", "", "", "Rojo, gris, aero, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES, imgName: "8060-1"));
            //list.Add(new Models.Clouth(8060, "ASTRONAUTA BORDADO", "1 AL 3", "$ 610,00", "", "", "", "", "Rojo, gris, aero, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES, imgName: "8060-2"));
            //list.Add(new Models.Clouth(8060, "ASTRONAUTA BORDADO", "1 AL 3", "$ 610,00", "", "", "", "", "Rojo, gris, aero, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES, imgName: "8060-3"));
            //list.Add(new Models.Clouth(8060, "ASTRONAUTA BORDADO", "1 AL 3", "$ 610,00", "", "", "", "", "Rojo, gris, aero, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.MINIBEBES, imgName: "8060-4"));
            //list.Add(new Models.Clouth(8065, "CHALECO BEBA OREJAS", "1 AL 5", "$ 399,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(8065, "CHALECO BEBA OREJAS", "1 AL 5", "$ 399,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8065-1"));
            //list.Add(new Models.Clouth(8065, "CHALECO BEBA OREJAS", "1 AL 5", "$ 399,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8065-2"));
            //list.Add(new Models.Clouth(8067, "CAMPERA BEBE  ", "1 AL 5", "$ 570,00", "", "", "", "", "Fondo azul/gris/rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.Clouth(8067, "CAMPERA BEBE  ", "1 AL 5", "$ 570,00", "", "", "", "", "Fondo azul/gris/rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, imgName: "8067-1"));
            //list.Add(new Models.Clouth(8067, "CAMPERA BEBE  ", "1 AL 5", "$ 570,00", "", "", "", "", "Fondo azul/gris/rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, imgName: "8067-2"));
            //list.Add(new Models.Clouth(8067, "CAMPERA BEBE  ", "1 AL 5", "$ 570,00", "", "", "", "", "Fondo azul/gris/rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, imgName: "8067-3"));
            //list.Add(new Models.Clouth(8069, "CAMPERA ESTAMPADA", "4 AL 8", "$ 790,00", "10 AL 14", "$ 850,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8069-1"));
            //list.Add(new Models.Clouth(8069, "CAMPERA ESTAMPADA", "4 AL 8", "$ 790,00", "10 AL 14", "$ 850,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8069-2"));
            //list.Add(new Models.Clouth(8069, "CAMPERA ESTAMPADA", "4 AL 8", "$ 790,00", "10 AL 14", "$ 850,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8069-3"));
            //list.Add(new Models.Clouth(8069, "CAMPERA ESTAMPADA", "4 AL 8", "$ 790,00", "10 AL 14", "$ 850,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8069-4"));
            //list.Add(new Models.Clouth(8069, "CAMPERA ESTAMPADA", "4 AL 8", "$ 790,00", "10 AL 14", "$ 850,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8069-5"));
            //list.Add(new Models.Clouth(8080, "CAMPERA PIEL CON FOIL", "1 AL 5", "$ 378,00", "", "", "", "", "Fucsia, rosa chicle, crudo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(8083, "MEDIA POLERA LISA", "1 AL 5", "$ 98,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(8083, "MEDIA POLERA LISA", "1 AL 5", "$ 98,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8083-1"));
            //list.Add(new Models.Clouth(8083, "MEDIA POLERA LISA", "1 AL 5", "$ 98,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8083-2"));
            //list.Add(new Models.Clouth(8083, "MEDIA POLERA LISA", "1 AL 5", "$ 98,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8083-3"));
            //list.Add(new Models.Clouth(8084, "REMERA CON LOL", "1 AL 5", "$ 145,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(8084, "REMERA CON LOL", "1 AL 5", "$ 145,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8084-1"));
            //list.Add(new Models.Clouth(8084, "REMERA CON LOL", "1 AL 5", "$ 145,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA, imgName: "8084-2"));
            //list.Add(new Models.Clouth(8085, "REMERA MANGA LARGA CAMUFLADA", "4 AL 8", "$ 198,00", "10 AL 14", "$ 218,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            //list.Add(new Models.Clouth(8085, "REMERA MANGA LARGA CAMUFLADA", "4 AL 8", "$ 198,00", "10 AL 14", "$ 218,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON, imgName: "8085-1"));
            return list.OrderBy(x => x.Id);
        }

        public static IEnumerable<Models.Clouth> GetAllXMayorPrecioVenta()
        {
            var list = new List<Models.Clouth>();
            list.AddRange(GetAllClouthFactory().Select(x => x.GetNegocio()));
            list.Add(new Models.Clouth(true, 8001, "REMERA GATITA BEBA", "1 AL 5", "$ 150,00", "", "", "", "", "Rosa, crudo, blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, action: ""));
            list.Add(new Models.Clouth(true, 8003, "CALZA RÚSTICA BEBA", "1 AL 5", "$ 143,00", "", "", "", "", "Melange, fucsia, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8004, "CALZA LANILLA BEBA", "1 AL 5", "$ 122,00", "", "", "", "", "Rosa, negro y gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8006, "BUZO CON VOLADO", "1 AL 5", "$ 299,00", "", "", "", "", "Rosa chicle, melange, verde beneton", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8007, "BUZO PIEL", "1 AL 5", "$ 285,00", "", "", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8009, "VESTIDO ESTAMPADO", "1 AL 5", "$ 215,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8011, "VESTIDO CORDEROY", "1 AL 5", "$ 310,00", "", "", "", "", "Rosa, verde agua, aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8012, "JARIDNERO BORDADO", "1 AL 4", "$ 415,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8015, "REMERA CON CARTERA", "1 AL 5", "$ 135,00", "", "", "", "", "Melange, aero, oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8016, "BUZO DINO", "1 AL 5", "$ 280,00", "", "", "", "", "Marino, melange, verde beneton", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8020, "CAMPERA PIEL", "1 AL 5", "$ 360,00", "", "", "", "", "Rojo, aero, crudo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8021, "PANTALON FRIZA CON RECORTE", "1 AL 5", "$ 165,00", "", "", "", "", "Melange, marino, topo, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8022, "CAMPERA PIEL BORD", "1 AL 5", "$ 405,00", "", "", "", "", "Rosa, rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8024, "CAMPERA COMBIN", "1 AL 5", "$ 330,00", "", "", "", "", "Marino, melange, rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8025, "PANTALON FRIZA COMBIN", "1 AL 5", "$ 165,00", "", "", "", "", "Marino, melange, rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8027, "SACO FRIZA", "1 AL 5", "$ 292,00", "", "", "", "", "Aero, melange, tomate", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8028, "JARDINERO JEAN", "1 AL 4", "$ 415,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8030, "REMERA RAYADA", "4 AL 8", "$ 143,00", "10 AL 14", "$ 153,00", "", "", "rayado rojo, rayado bordo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8031, "REMERA CON STASS", "4 AL 8", "$ 170,00", "10 AL 14", "$ 184,00", "", "", "melange, fucsia, blanca", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8032, "PANTALON RUSTICO", "4 AL 8", "$ 225,00", "10 AL 14", "$ 238,00", "", "", "melange, fucsia, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8035, "CALZA CON ESTAMPA", "4 AL 8", "$ 225,00", "10 AL 14", "$ 238,00", "", "", "Negro, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8036, "CALZA TERMICA", "4 AL 8", "$ 209,00", "10 AL 14", "$ 220,00", "16", "$ 230,00", "Negro, gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8038, "BUZO PIEL", "4 AL 8", "$ 340,00", "10 AL 14", "$ 365,00", "", "", "Crudo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8039, "BUZO LENTEJUELAS", "4 AL 8", "$ 445,00", "10 AL 14", "$ 480,00", "", "", "Melange, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8041, "VESTIDO C/VOLADOS", "4 AL 8", "$ 340,00", "10 AL 14", "$ 365,00", "", "", "Estampado con gris, estampado con aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8042, "VESTIDO LENTEJUELAS", "4 AL 8", "$ 445,00", "10 AL 14", "$ 480,00", "", "", "Fucsia, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8043, "JUMPER JEAN", "4 AL 8", "$ 354,00", "10 AL 14", "$ 380,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8044, "CAMPERA PIEL", "4 AL 8", "$ 440,00", "10 AL 14", "$ 465,00", "", "", "Rojo, beige, rosa nude, rosa chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8046, "REMERA C/ AURICULARES VARON", "4 AL 8", "$ 185,00", "10 AL 14", "$ 198,00", "", "", "Melange, oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(true, 8047, "REMERA ESTAMPADA", "4 AL 8", "$ 193,00", "10 AL 14", "$ 203,00", "", "", "Melange, oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(true, 8048, "PANTALON C/ RECORTE", "4 AL 8", "$ 259,00", "10 AL 14", "$ 279,00", "", "", "Negro, topo, melange, marino", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(true, 8050, "BUZO C/ CIERRE", "4 AL 8", "$ 345,00", "10 AL 14", "$ 370,00", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(true, 8051, "BUZO SKATE", "2 AL 8", "$ 395,00", "", "", "", "", "Marino, melange, negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(true, 8052, "CAMPERA COMBINADA", "4 AL 8", "$ 470,00", "10 AL 14", "$ 505,00", "", "", "Rojo con topo, francia con melange, melange con negro", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
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
            list.Add(new Models.Clouth(true, 8067, "CAMPERA BEBE  ", "1 AL 5", "$ 570,00", "", "", "", "", "Fondo azul/gris/rojo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8068, "CHALECO METALIZADO NENA", "4 al 14", "$ 390,00", "", "", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8069, "CAMPERA ESTAMPADA", "4 AL 8", "$ 790,00", "10 AL 14", "$ 850,00", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8070, "CAMPERÓN METALIZADO", "4 AL 8", "$ 640,00", "10 AL 14", "$ 695,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8072, "CHALECO VARON", "4 AL 8", "$ 340,00", "10 AL 14", "$ 365,00", "", "", "Gris, negro, marino", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(true, 8073, "CAMPERA VARON", "4 AL 8", "$ 690,00", "10 AL 14", "$ 740,00", "", "", "Rojo, azul, negro, gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(true, 8074, "TAPADO ESTAMPADA BEBA", "1 AL 5", "$ 625,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8075, "TAPADO CON CORDERITO", "1 AL 5", "$ 625,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8076, "CAMPERA PIEL CON FOIL", "4 AL 8", "$ 480,00", "10 AL 14", "$ 520,00", "", "", "Fucsia, rosa chicle, crudo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8077, "CAMPERA BEBE CAMUFLADA", "1 AL 5", "$ 538,00", "", "", "", "", "Marino, verde militar", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(true, 8078, "CALZA TERMICA", "1 AL 5", "$ 130,00", "", "", "", "", "Negro, melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8079, "VESTIDO TELA ESTRELLAS", "4 AL 8", "$ 395,00", "10 AL 14", "$ 470,00", "", "", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(true, 8080, "CAMPERA PIEL CON FOIL", "1 AL 5", "$ 378,00", "", "", "", "", "Fucsia, rosa chicle, crudo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));

            list.Add(new Models.Clouth(true, 8020, "CAMPERA PIEL", "1 AL 5", "$ 360,00", "", "", "", "", "Crudo, rojo, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8022, "CAMPERA PIEL BORD", "1 AL 5", "$ 405,00", "", "", "", "", "Rojo, rosa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(true, 8074, "TAPADO ESTAMPADA BEBA", "1 AL 5", "$ 625,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8074-2"));
            list.Add(new Models.Clouth(true, 8075, "TAPADO CON CORDERITO", "1 AL 5", "$ 625,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8075-2"));
            list.Add(new Models.Clouth(true, 8075, "TAPADO CON CORDERITO", "1 AL 5", "$ 625,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8075-3"));
            list.Add(new Models.Clouth(true, 8065, "CHALECO BEBA OREJAS", "1 AL 5", "$ 399,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8065-1"));
            list.Add(new Models.Clouth(true, 8065, "CHALECO BEBA OREJAS", "1 AL 5", "$ 399,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8065-2"));
            list.Add(new Models.Clouth(true, 8065, "CHALECO BEBA OREJAS", "1 AL 5", "$ 399,00", "", "", "", "", "Varios estampados", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, imgName: "8065-3"));

            return list.OrderBy(x => x.Id);
        }

        public static IEnumerable<Models.Clouth> GetAllGeneral()
        {
            var list = new List<Models.Clouth>();
            return GetAllClouthFactory().Select(x => x.GetGeneral()).OrderBy(x => x.Id);
        }

        public static IEnumerable<Models.Clouth> GetAllNube()
        {
            var list = new List<Models.Clouth>();
            return GetAllClouthFactory().Select(x => x.GetNube()).OrderBy(x => x.Id);
        }

        public static IEnumerable<Models.Clouth> GetAll()
        {
            var list = new List<Models.Clouth>();
            return GetAllClouthFactory().Select(x => x.GetSinPrecio()).OrderBy(x => x.Id);
        }
    }
}