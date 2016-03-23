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
            //list.Add(new Models.Clouth(7201, "REMERA PINGUINOS", "1 AL 5", "Chicle - Blanco - Natural", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7202, "REMERA CON POMPON", "1 AL 5", "Chicle - Blanco - Natural", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7203, "REMERA CON ANTEOJOS", "1 AL 5", "Chicle - Blanco - Natural", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7204, "REMERON CON ENCAJE", "1 AL 5", "Chicle - Blanco - Natural", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7205, "REMERON RAYADO Y ESTAMPADO", "1 AL 5", "Rojo - Bordeaux", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7206, "CAMISOLA ESTAMPADA", "1 AL 5", "Azul con Fucsia - Gris con turquesa", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7207, "CAMISOLA PLUMETI", "1 AL 5", "Blanco - Natural", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7209, "VESTIDO CON VOLADOS", "1 AL 5", "Rosa - Fucsia", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7210, "CALZA ESTAMPADA", "1 AL 5", "Rosa - Verde agua - Rojo - Bordeaux", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7211, "CALZA SIMIL JEAN", "1 AL 5", "Azul - Negro", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7212, "CALZA RUSTICA ELASTIZADA", "1 AL 5", "Fucsia - Coral", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7213, "VESTIDO COMBINADO CON CORAZON", "1 AL 5", "Rojo - Bordeaux", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7214, "VESTIDO ESCOCES", "1 AL 5", "Tomate con Gris - Azul con Fucsia", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7215, "VESTIDO JEAN ESTAMPADO", "1 AL 5", "Azul", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7218, "CAMPERA ESTAMPADA", "1 AL 5", "Rosa - Gris", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7219, "CAMPERA CON PUNTILLA", "1 AL 5", "Fucsia - Melange - Rojo - Coral", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7221, "SACO DE PIEL", "1 AL 5", "Chicle - Natural - Coral", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7222, "VESTIDO CON CHALECO", "1 AL 5", "Azul con Fucsia - Gris con Turquesa", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7224, "JUMPER CORDEROY", "1 AL 6", "Chicle - Rojo", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7226, "REMERA CON BORDADOR", "1 AL 5", "Melange - Francia - Petróleo - Azul - Oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7227, "REMERA CARICATURAS", "1 AL 5", "Melange - Francia - Petróleo - Azul - Oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7228, "BUZO CALIFORNIA", "1 AL 6", "Bordeaux - Petróleo", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7231, "CAMPERA COMBINADA", "1 AL 5", "Melange con Petróleo - Melange con Bordeaux", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7232, "CAMPERA UNIVERSITARIA", "1 AL 5", "Melange con Bordeaux - Melange Petróleo - Aero Gris", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7235, "CAMPERA DNT", "1 AL 5", "Aero - Rojo - Francia", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7236, "CAMPERA DE PIEL", "1 AL 5", "Chicle - Natural - Coral - Rojo - Beige - Gris", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS,action:"camperas"  ));
            list.Add(new Models.Clouth(7237, "PANTALON DE FRISA", "1 AL 5", "Fucsia - Coral - Melange - Rojo - Aero - Marino", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7238, "PANTALON DE GABARDINA", "1 AL 6", "Petróleo - Bordeaux", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7239, "CAMISA ESCOCESA", "1 AL 5", "Azul con Violeta - Rojo con Azul - Azul con Verde - Rojo con Gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7240, "JARDINERO DE JEAN", "1 AL 4", "Azul", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7240, "JARDINERO DE JEAN", "1 AL 4", "Azul", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS,imgName: "7240_beba"));
            list.Add(new Models.Clouth(7242, "REMERA CON FLECOS", "4 AL 8 y 10 AL 14", "Blanco - Natural - Chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7243, "REMERA ESTAMPADA", "4 AL 8 y 10 AL 14", "Fucsia - Azul - Gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7244, "REMERON CON BRODERIE", "4 AL 8 y 10 AL 14", "Blanco - Natural - Chicle", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7245, "CAMPERA DE FRISA", "4 AL 8 y 10 AL 14", "Melange - Fucsia - Coral - Violeta", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.NENA, action: "CamperasBuzos"));
            list.Add(new Models.Clouth(7247, "BUZO CLASICO", "4 AL 8 y 10 AL 14", "Melange - Fucsia - Coral - Violeta", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7249, "CAMPERA UNIVERSITARIA NENA", "4 AL 8 y 10 AL 14", "Melange con Fucsia - Melange con Negro - Gris con Violeta", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7250, "CALZA ESTAMPADA", "4 AL 8 y 10 AL 14", "Fondo claro con Azul - Fondo claro con Fucsia - Fucsia con Azul y Gris", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7251, "CALZA SIMIL JEAN", "4 AL 8 y 10 AL 14", "Azul - Negro", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7252, "CALZA SIMIL JEAN OXFORD", "4 AL 8 y 10 AL 14", "Azul - Negro", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7253, "CALZA RUSTICA ELASTIZADA", "4 AL 8 y 10 AL 14", "Negro Fucsia", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7254, "CAMISA ESTAMPADA", "4 AL 8 y 10 AL 14", "Azul con Fucsia - Azul con Mostaza", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7255, "SACO CRUZADO DE PIEL", "4 AL 8 y 10 AL 14", "Negro - Gris - Beige", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7256, "VESTIDO CON VOLADO", "4 AL 8 y 10 AL 14", "Azul - Bordeaux", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7260, "PANTALON FRISA NENA", "4 AL 8 y 10 AL 14", "Melange - Violeta - Fucsia - Coral", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7261, "REMERA", "4 AL 8 y 10 AL 14", "Melange - Francia - Petróleo - Azul - Oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7263, "BUZO CON BOLSILLOS", "4 AL 8 y 10 AL 14", "Bordeaux - Petróleo - Marino - Melange", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7266, "CAMPERA UNIVERSITARIA VARON", "4 AL 8 y 10 AL 14", "Petróleo con Topo - Melange con Negro - Bordeaux con Topo", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.VARON, action: "buzoscamperas"));
            list.Add(new Models.Clouth(7267, "PANTALON DE FRISA", "4 AL 8 y 10 AL 14", "Melange - Topo - Negro - Marino", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7268, "PANTALON DE GABARDINA", "4 AL 8 y 10 AL 14", "Petróleo - Bordeaux - Negro", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7269, "CAMISA ESCOCESA", "4 AL 8 y 10 AL 14", "Azul con Violeta - Rojo con Azul - Azul con Verde - Rojo con Gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7270, "ASTRONAUTA", "1 AL 3", "Rojo - Fucsia - Francia", Models.Clouth.SUBCATEGORY.GENERAL, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(7271, "ASTRONAUTA ESTAMPADO", "1 AL 3", "Azul - Fucsia - Rojo", Models.Clouth.SUBCATEGORY.GENERAL, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(7271, "ASTRONAUTA ESTAMPADO", "1 AL 3", "Azul - Fucsia - Rojo", Models.Clouth.SUBCATEGORY.GENERAL, Models.Clouth.CATEGORY.MINIBEBES, imgName: "7271_beba"));
            list.Add(new Models.Clouth(7272, "CHALECO BEBA", "1 AL 5", "Rojo - Fucsia ", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7273, "CHALECO BEBE", "1 AL 5", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7274, "CHALECO DE NENA ESTAMPADO", "4 AL 8 y 10 AL 14", "Azul - Fucsia", Models.Clouth.SUBCATEGORY.CHALECOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7275, "CHALECO DE VARON", "4 AL 8 y 10 AL 14", "Negro - Gris - Marino - Francia", Models.Clouth.SUBCATEGORY.CHALECOS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7276, "CAMPERA CON VOLADOS", "1 AL 5", "Rojo - Fucsia ", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7277, "CAMPERA ESTAMPADA", "1 AL 5", "Azul - Fucsia", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS, action: "camperas"));
            list.Add(new Models.Clouth(7278, "CAMPERA DE BEBE", "1 AL 5", "Francia - Rojo - Gris", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7280, "CAMPERA ESTAMPADA NENA", "4 AL 8 y 10 AL 14", "Fucsia - Mostaza - Gris", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7283, "CAMPERA UNISEX", "4 AL 8 y 10 AL 14", "Rojo - Negro - Gris - Marino - Francia", Models.Clouth.SUBCATEGORY.CHALECOS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7285, "CONJUNTO INTERLOK", "0 AL 2", "Azul - Rojo", Models.Clouth.SUBCATEGORY.GENERAL, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(7286, "CALZA MINI JEAN", "0 AL 3", "Azul", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(7287, "ENTERITO DE FRISA ESTAMPADO", "0 AL 2", "Rosa - Gris", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(7288, "ENTERITO RAYADO", "0 AL 2", "Gris francia - Aero beige - Rojo -Azul", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(7289, "PANTALON DE FRISA MINI", "0 AL 3", "Melange - Marino - Aero - Rojo", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(7291, "CAMISA BODY ESCOCESA", "0 AL 3", "Azul con Violeta - Azul con Verde - Rojo con Gris", Models.Clouth.SUBCATEGORY.GENERAL, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(7292, "ENTERITO DE PIEL", "0 AL 2", "Natural con Rojo / Gris / Beige / Fucsia / Coral", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.MINIBEBES, action:"all"));
            list.Add(new Models.Clouth(7293, "7293 CAMPERA DE PLUSH RAYADA y 7299 PANTALON PLUSH", "0 AL 3", "Rosa con Fucsia - Amarillo,  Azul y Rojo ", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.MINIBEBES,code: "7293 y 7299"));
            list.Add(new Models.Clouth(7293, "7293 CAMPERA DE PLUSH RAYADA y 7299 PANTALON PLUSH", "0 AL 3", "Amarillo con Azul y Rojo ", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.MINIBEBES, imgName: "72931", code: "7293 y 7299"));
            list.Add(new Models.Clouth(7295, "CAMPERA CON VOLADOS", "1 AL 5", "Fucsia - Coral", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7296, "REMERA BEBA C/PUNTILLA", "1 AL 5", "Chicle - Blanco - Natural", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7297, "REMERA VARON PAISAJE", "4 AL 8 y 10 AL 14", "Melange - Francia - Petróleo - Azul - Oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7298, "BUZO VARON", "4 AL 8 y 10 AL 14", "Francia - Topo - Melange", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7300, "CAMPERA BEBE", "1 AL 5", "Marino - Francia - Rojo - Gris", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBES));

            return list;
        }

    }
}