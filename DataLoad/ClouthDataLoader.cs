using MvcApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.DataLoad
{
    public class ClouthDataLoader
    {

        private static IEnumerable<Models.Clouth> all=null;
        public static IEnumerable<Models.Clouth> Data()
        {
            if (all==null){
                all = GetAll();
            }

            //IEnumerable<Models.Clouth> list = GetAll();
            return all;
        }


        public static IEnumerable<Models.Clouth> GetAll()
        {

            var list = new List<Models.Clouth>();
            list.Add(new Clouth(7801, "Remera Beba Unicornio", "1 AL 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7802, "Remera Beba Con Volado", "1 AL 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7803, "Remeron Beba Lanilla", "1 AL 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7804, "Camisa Plumeti", "1 AL 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7805, "Calza Con Volado", "1 AL 5", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7806, "Calza Lanilla", "1 AL 5", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7807, "Calza Estampada", "1 AL 5", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7808, "Pantalon Rustico Con Volado", "1 AL 5", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7809, "Pantalon Jean Con Volados", "1 AL 5", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7810, "Pantalon Jean Bordado", "1 AL 5", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7811, "Jardinero Jean Gato Bordado", "1 AL 4", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7820, "Pantalon Plush", "1 AL 5", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7891, "Calza Simil Jean Beba", "1 AL 5", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.BEBAS));

            list.Add(new Clouth(7815, "Buzo Frisa Gato", "1 AL 5", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7816, "Buzo Combin Frisa Y Piel", "1 AL 5", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7817, "Buzo Piel Perro", "1 AL 5", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7818, "Campera Frisa Estampada", "1 AL 5", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7819, "Campera Plush", "1 AL 5", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7821, "Campera Piel", "1 AL 5", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7822, "Campera Piel Larga", "1 AL 5", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBAS));
            
            list.Add(new Clouth(7812, "Vestido Lanilla", "1 AL 5", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7813, "Vestido Combinado Con Escoces", "1 AL 5", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7814, "Vestido Jean", "1 AL 5", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7893, "Jumper Jean Con Gato", "1 AL 5", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));


            list.Add(new Clouth(7867, "Campera Beba Gatitos", "1 AL 5", "", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7868, "Tapado Estampado", "1 AL 5", "", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7862, "Chaleco Beba", "1 AL 5", "", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.BEBAS));
            ////BEBES
            list.Add(new Clouth(7823, "Remera Bebe Camuflada", "1 AL 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7824, "Remera Bebe Zorro", "1 AL 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7825, "Remera Bebe Con Cartera", "1 AL 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7832, "Camisa Escocesa", "1 AL 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            
            list.Add(new Clouth(7826, "Buzo Bebe Tigre", "1 AL 5", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7827, "Buzo Bebe Con Capucha", "1 AL 5", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7833, "Saco Frisa Bebe", "1 AL 5", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7834, "Campera Frisa Bebe", "1 AL 5", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7835, "Saco Cruzado Bebe", "1 AL 5", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7863, "Chaleco Bebe", "1 AL 5", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7864, "Campera Camuflada Bebe", "1 AL 5", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBES));

            list.Add(new Clouth(7828, "Pantalon Con Rodillera", "1 AL 5", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7829, "Pantalon Frisa Con Puño", "1 AL 5", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7830, "Pantalon Frisa Camuflado", "1 AL 5", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7831, "Jardinero Jean", "1 AL 4", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.BEBES));

            //NENAS
            list.Add(new Clouth(7836, "Remera Nena Con Volados", "4 AL 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7837, "Remera Con Unicornio", "4 AL 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7838, "Remera Con Aplique", "4 AL 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7839, "Camisola Plumeti", "4 AL 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));

            list.Add(new Clouth(7840, "Calza Lycra Estampada", "4 AL 14", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7841, "Calza Estampada Como Jean", "4 AL 14", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7842, "Pantalon Rustico Con Volado", "4 AL 14", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.NENA, imgName: "7808"));
            list.Add(new Clouth(7843, "Calza Con Lentejuelas", "4 AL 14", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7844, "Pantalon Rustico Con Rodilleras", "4 AL 14", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7892, "Calza Simil Jean Nena", "4 AL 16", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.NENA));

            list.Add(new Clouth(7845, "Buzo Love", "4 AL 14", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7846, "Buzo Corazon", "4 AL 14", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7847, "Buzo Unicornio", "4 AL 14", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7848, "Buzo Piel", "4 AL 14", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7849, "Campera Unicornio", "4 AL 14", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7850, "Campera Piel Lisa", "4 AL 14", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7851, "Campera Piel Bordada", "4 AL 14", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7865, "Chaleco Liso Nena", "4 AL 14", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7866, "Chaleco Estampado Nena", "4 AL 14", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7869, "Campera Nena", "4 AL 14", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.NENA));

            list.Add(new Clouth(7895, "Vestido Modal Combinado", "4 AL 14", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));

            //VARON
            list.Add(new Clouth(7852, "Remera Con Cartera", "4 AL 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Clouth(7853, "Remera Con Bolsillo Jean", "4 AL 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Clouth(7854, "Remera Camuflada", "4 AL 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));

            list.Add(new Clouth(7855, "Buzo Camuflado Con Capucha", "4 AL 14", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Clouth(7856, "Buzo Con Cuello", "4 AL 14", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Clouth(7857, "Campera Frisa Varon", "4 AL 14", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Clouth(7858, "Saco Cruzado", "4 AL 14", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Clouth(7870, "Campera Varon", "4 AL 14", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Clouth(7871, "Campera Universitaria", "4 AL 14", "", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.VARON));
            
            list.Add(new Clouth(7859, "Panatalon Con Cierre", "4 AL 14", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.VARON));

            //MINIBEBES
            list.Add(new Clouth(7872, "Enterito Mini Plush Gato", "0 AL 2", "", Models.Clouth.SUBCATEGORY.MINIBEBE, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Clouth(7873, "Enterito Mini Plush Oso", "0 AL 2", "", Models.Clouth.SUBCATEGORY.MINIBEBE, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Clouth(7874, "Enterito Frisa Camuflado Bebe", "1 AL 3", "", Models.Clouth.SUBCATEGORY.MINIBEBE, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Clouth(7875, "Enterito Plush Estampado", "0 AL 2", "", Models.Clouth.SUBCATEGORY.MINIBEBE, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Clouth(7876, "Enterito Mini Piel Con Cierre", "0 AL 2", "", Models.Clouth.SUBCATEGORY.MINIBEBE, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Clouth(7877, "Enterito Mini Piel Oso", "0 AL 2", "", Models.Clouth.SUBCATEGORY.MINIBEBE, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Clouth(7878, "Camisa Body", "0 AL 3", "", Models.Clouth.SUBCATEGORY.MINIBEBE, Models.Clouth.CATEGORY.MINIBEBES));
/*IGUAL*/   list.Add(new Clouth(7879, "Campera Mini Plush", "0 AL 3", "", Models.Clouth.SUBCATEGORY.MINIBEBE, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Clouth(7880, "Pantalon Mini Plush", "0 AL 3", "", Models.Clouth.SUBCATEGORY.MINIBEBE, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Clouth(7881, "Jumper Mini", "0 AL 3", "", Models.Clouth.SUBCATEGORY.MINIBEBE, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Clouth(7894, "Enterito Frisa Estamp. Beba", "1 AL 3", "", Models.Clouth.SUBCATEGORY.MINIBEBE, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Clouth(7860, "Astronauta Estampado", "1 AL 3", "", Models.Clouth.SUBCATEGORY.MINIBEBE, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Clouth(7861, "Enterito Liso", "1 AL 3", "", Models.Clouth.SUBCATEGORY.MINIBEBE, Models.Clouth.CATEGORY.MINIBEBES));


            //LINEA TEENS
            list.Add(new Clouth(7882, "Remera Nena Con Cara", "S, M, L y XL", "", Models.Clouth.SUBCATEGORY.NENA, Models.Clouth.CATEGORY.TEENS));
            list.Add(new Clouth(7883, "Buzo 94", "S, M, L y XL", "", Models.Clouth.SUBCATEGORY.NENA, Models.Clouth.CATEGORY.TEENS));
            list.Add(new Clouth(7884, "Buzo Con Capucha", "S, M, L y XL", "", Models.Clouth.SUBCATEGORY.NENA, Models.Clouth.CATEGORY.TEENS));
            list.Add(new Clouth(7885, "Pollera", "S, M, L y XL", "", Models.Clouth.SUBCATEGORY.NENA, Models.Clouth.CATEGORY.TEENS));
            list.Add(new Clouth(7886, "Pantalon Rustico Con Ojalillos", "S, M, L y XL", "", Models.Clouth.SUBCATEGORY.NENA, Models.Clouth.CATEGORY.TEENS));
            list.Add(new Clouth(7887, "Vestido", "S, M, L y XL", "", Models.Clouth.SUBCATEGORY.NENA, Models.Clouth.CATEGORY.TEENS));
            list.Add(new Clouth(7890, "Calza Engomada", "S, M, L y XL", "", Models.Clouth.SUBCATEGORY.NENA, Models.Clouth.CATEGORY.TEENS));

            list.Add(new Clouth(7888, "Remera Manga Estampada", "S, M, L y XL", "", Models.Clouth.SUBCATEGORY.NENE, Models.Clouth.CATEGORY.TEENS));
            list.Add(new Clouth(7889, "Pantalon Frisa Con Recorte", "S, M, L y XL", "", Models.Clouth.SUBCATEGORY.NENE, Models.Clouth.CATEGORY.TEENS));
            
            //list.Add(new Clouth(7896, "Body Mini Con Encaje", "0 AL 3", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7897, "Pantalon Jean Elastizado", "4 AL 16", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.NENA));
            return list;
        }

    }
}