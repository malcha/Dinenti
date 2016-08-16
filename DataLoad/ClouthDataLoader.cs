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
            list.Add(new Models.Clouth(7405, "VESTIDO SOLERO", "1 AL 5", "Turquesa - Rosa", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7406, "VESTIDO 3 VOLADOS", "1 AL 5", "Rosa - Patito", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7407, "VESTIDO PLUMETI", "1 AL 5", "Blanco - Rosa- Agua Marinoa", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7408, "VESTIDO GUARDA FLORES", "1 AL 5", "Rosa - Rojo", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7409, "SOLERO FIBRANA", "1 AL 5", "Blanco - Salmon", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7410, "VESTIDO JEAN", "1 AL 5", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7416, "ENTERITO ESTAMPADO", "1 AL 5", "Turquesa - Rosa", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7417, "ENTERITO FIBRANA", "1 AL 5", "Azul Francia - Rojo con Azul marino - Rosa", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7315, "PANTALON RUSTICO BEBE", "1 AL 5", "Verde - Rosa - Melange", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7411, "CALZA ESTAMPADA", "1 AL 5", "Blanco - Turquesa con Blanco - Coral", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7412, "CALZA JASPEADA", "1 AL 5", "Frutilla - Fucsia", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7418, "SORT RUSTICO", "1 AL 5", "Fucsia - Verde - Rosa", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7419, "SHORT FIBRANA ESTAMPADA", "1 AL 5", "Fucsia - Verde ", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7420, "SHORT C - LAZO", "1 AL 5", "Coral - Rosa - Blanco", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7421, "SHORT JEAN", "1 AL 5", "Jean", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7422, "JARDINERO JEAN BEBA", "1 AL 5", "Jean", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7312, "CAMPERA RUSTICA BEBA", "1 AL 5", "Chicle - Gris Melange", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7313, "CAMPERA ESTAMPADA BEBA", "1 AL 5", "Blanco - Salmon", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7322, "ROMPEVIENTO BEBA", "1 AL 5", "Fucsia - Rojo", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7401, "REMERA BEBA", "1 AL 5", "Blanco - Coral - Salmon", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, "remerasremerones"));
            list.Add(new Models.Clouth(7402, "REMERON PUNTILLA", "1 AL 5", "Blanco - Coral - Salmon", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7403, "REMERA ESTAMPADA", "1 AL 5", "Rosa - Patito", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7404, "REMERON CON VOLADOS", "1 AL 5", "Blanco - Coral - Salmon", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7413, "CAMISOLA FIBRANA ESTAMPADA", "1 AL 5", "Blanco - Salmon", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7414, "CAMISOLA PLUMETI", "1 AL 5", "Blanco - Rosa - Agua Marinoa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7484, "REMERON SIN MANGAS BEBA", "1 AL 5", "Blanco - Coral - Salmon", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7314, "CAMPERA RUSTICA BEBE", "1 AL 5", "Melange - Verde con Melange - Francia", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7323, "ROMPEVIENTO BEBE", "1 AL 5", "Rojo - Verde - Azul", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7423, "REMERA CARICATURA", "1 AL 5", "Gris Melange - Francia - Aero - Verde", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7424, "REMERA PALMERAS", "1 AL 5", "Gris Melange - Francia - Aero - Verde", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7425, "REMERA COMBINADA", "1 AL 5", "Melange - Fucsia con Blanco - Francia con Blanco - Verde", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, "remerascamisas"));
            list.Add(new Models.Clouth(7426, "CHOMBA", "1 AL 5", "Melange - Fucsia - Blanco - Verde - Aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7427, "CAMISA LISA", "1 AL 5", "Blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7428, "CAMISA ESCOCESA", "1 AL 5", "Rosa - Azul - Blanco con Turquesa - Francia - Blanco con Verde - Rojo - Blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7429, "CAMISA JEAN", "1 AL 5", "Jean", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7430, "BERMUDA RUSTICA", "1 AL 5", "Francia Gris Melange - Verde", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7432, "BERMUDA GABARDINA", "1 A 5", "Francia - Marino - Verde", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7433, "BERMUDA JEAN", "1 AL 5", "Jean", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7434, "SHORT BAÑO 3 RECORTES", "1 AL 5", "Rojo - Azul", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7436, "SHORT BAÑO ESTAMPADO", "1 AL 5", "", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7440, "VESTIDO 3 VOLADOS MINI", "0 AL 3", "Blanco - Turquesa con Blanco - Coral", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(7441, "VESTIDO FIBRANA", "0 AL 3", "Blanco - Salmon", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(7443, "BODY CHOMBA MINI BEBE", "0 AL 3", "Melange - Marino con Celeste - Marino", Models.Clouth.SUBCATEGORY.BODY, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(7445, "CONJUNTO REMERA Y SORT", "0 AL 3", "Melange - Marino con Celeste - Marino", Models.Clouth.SUBCATEGORY.BODY, Models.Clouth.CATEGORY.MINIBEBES,"all"));
            list.Add(new Models.Clouth(7317, "CAMPERA NENA", "4 AL 8 y 10 AL 14", "Fucsia - Chicle", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7446, "REMERA CON MANGAS", "4 AL 8 y 10 AL 14", "Blanco - Salmon - Frutilla", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7447, "REMERON CON ENCAJE", "4 AL 8 y 10 AL 14", "Blanco - Salmon - Frutilla", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7450, "CALZA JASPEADA", "4 AL 8 y 10 AL 14", "Topo - Frutilla - Fucsia", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7451, "CAMISOLA PLUMETI", "4 AL 8 y 10 AL 14", "Blanco - Rosa - AguaMarinoa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7452, "CALZA ESTAMPADA", "4 AL 8 y 10 AL 14", "Marino - Violeta - Salmon - Fucsia", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7453, "VESTIDO ESTAMPADO", "4 AL 8 y 10 AL 14", "Rosa - Turquesa", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7454, "VESTIDO FLOREADO", "4 AL 8 y 10 AL 14", "Verde - Chicle", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7455, "SOLERO GUARDA", "4 AL 8 y 10 AL 14", "Fucsia - Verde", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7456, "VESTIDO MODAL C - MANGA", "4 AL 8 y 10 AL 14", "Chicle - Salmon", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA, "vestidos"));
            list.Add(new Models.Clouth(7457, "SOLERO 3 VOLADOS", "2 AL 6 y 8 AL 10", "Blanco - Salmon", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7458, "VESTIDO CON CINTO", "4 AL 8 y 10 AL 14", "Chicle - Rojo", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7459, "SOLERO PLUMETI", "2 AL 6 y 8 AL 10", "Blanco - Rosa - Agua Marino", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7460, "ENTERITO LARGO", "4 AL 8 y 10 AL 14", "Francia - Rojo con Marino - Fucsia", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7461, "ENTERITO CORTO", "4 AL 8 y 10 AL 14", "Rosa - Turquesa", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7463, "SHORT FIBRANA  ", "4 AL 8 y 10 AL 14", "Francia - Rojo con Marino - Fucsia", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7466, "SHORT JEAN", "4 AL 8 y 10 AL 14", "Jean", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7482, "SOLERO JEAN", "4 AL 8 y 10 AL 14", "Jean", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7483, "REMERON FLOR GRANDE", "4 AL 8 y 10 AL 14", "Melange - Blanco - Frutilla", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7320, "CAMPERA VARON", "4 AL 8 y 10 AL 14", "Negro  - Topo - Marino", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7468, "REMERA C - ESTAMPA VARON", "4 AL 8 y 10 AL 14", "Gris Melange - Francia - Verde - Aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7469, "REMERA SKATE", "4 AL 8 y 10 AL 14", "Gris Melange - Francia - Verde - Aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7470, "REMERA ESTAMPADA", "4 AL 8 y 10 AL 14", "Melange - Marino con Fucsia - Verde - Celeste - Marino", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7472, "CAMISA ESCOCESA", "4 AL 8 y 10 AL 14", "Rojo - Azul - Blanco con Turquesa - Francia - Blanco con Verder - Rosa - Blanco", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7473, "CAMISA JEAN", "4 AL 8 y 10 AL 14", "Jean", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7474, "BEMUDA GABARDINA", "4 AL 8 y 10 AL 14", "Francia - Marino - Verde", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7476, "BERMUDA JEAN", "4 AL 8  y 10 AL 14", "Jean", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.VARON, "pantalonesshorts"));
            list.Add(new Models.Clouth(7477, "SORT BAÑO C - VIVOS", "4 AL 8 y 10 AL 14", "Azul - Rojo", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7479, "SHORT BAÑO ESTAMPADO", "4 AL 8 y 10 AL 14", "", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7480, "MUSCULOSA CON ESTAMPA", "4 AL 8 y 10 AL 14", "Gris Melange - Francia - Verde - Aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7481, "MUSCULOSA COMBINADA", "4 AL 8 y 10 AL 14", "Verde - Aero - Gris Melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));

            //BEBA
            //1 - Remeras - Remerones - Camisolas
            //2 - (Calzas - Jardinero (Calzas)
            //    Shorts - Pantalon rustico  (Pantalon)) POR AHORA TODOS JUNTOS
            //3 - Campera rustica - Rompeviento
            //4 - Vestidos - Enteritos

            //BEBE
            //1 - Remeras - Musculosas - Camisas - Chombas
            //2 - Bermudas - Shorts baño - Jardinero
            //3 - Campera rustica - Rompeviento

            //            NENA
            //1 - Remeras - Camisolas - Campera rustica
            //2 - Vestidos - Soleros - Enteritos
            //3 - Calzas - Shorts

            //VARON
            //1 - Remeras - Musculosas - 
            //      Camisas - Campera rustica
            //2 - Bermudas - Shorts de baño

            return list;
        }

    }
}