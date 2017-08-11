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
            //list.Add(new Models.Clouth(7439, "JARDINERO JEAN BEBE", "1 AL 5", "", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.Clouth(7405, "VESTIDO SOLERO", "1 AL 5", "Turquesa - Rosa", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7406, "VESTIDO 3 VOLADOS", "1 AL 5", "Rosa - Patito", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7407, "VESTIDO PLUMETI", "1 AL 5", "Blanco - Rosa- Agua Marinoa", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7408, "VESTIDO GUARDA FLORES", "1 AL 5", "Rosa - Rojo", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7409, "SOLERO FIBRANA", "1 AL 5", "Blanco - Salmon", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7410, "VESTIDO JEAN", "1 AL 5", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7416, "ENTERITO ESTAMPADO", "1 AL 5", "Turquesa - Rosa", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7417, "ENTERITO FIBRANA", "1 AL 5", "Azul Francia con Rojo - Azul marino con Rosa", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7315, "PANTALON RUSTICO BEBE", "1 AL 5", "Verde - Rosa - Melange", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7411, "CALZA ESTAMPADA", "1 AL 5", "Blanco con Turquesa - Blanco con Coral", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7412, "CALZA JASPEADA", "1 AL 5", "Frutilla - Fucsia", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7418, "SORT RUSTICO", "1 AL 5", "Fucsia - Verde - Rosa", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7419, "SHORT FIBRANA ESTAMPADA", "1 AL 5", "Fucsia - Verde ", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7420, "SHORT C - LAZO", "1 AL 5", "Coral - Rosa - Blanco", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7421, "SHORT JEAN", "1 AL 5", "Jean", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7422, "JARDINERO JEAN BEBA", "1 AL 5", "Jean", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7312, "CAMPERA RUSTICA BEBA", "1 AL 5", "Chicle - Gris Melange", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7313, "CAMPERA ESTAMPADA BEBA", "1 AL 5", "Blanco - Aguamarina", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7322, "ROMPEVIENTO BEBA", "1 AL 5", "Fucsia - Rojo", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7401, "REMERA BEBA", "1 AL 5", "Blanco - Coral - Salmon", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, "remerasremerones"));
            //list.Add(new Models.Clouth(7402, "REMERON PUNTILLA", "1 AL 5", "Blanco - Coral - Salmon", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7403, "REMERA ESTAMPADA", "1 AL 5", "Rosa - Patito", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7404, "REMERON CON VOLADOS", "1 AL 5", "Blanco - Coral - Salmon", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7413, "CAMISOLA FIBRANA ESTAMPADA", "1 AL 5", "Blanco - Salmon", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7414, "CAMISOLA PLUMETI", "1 AL 5", "Blanco - Rosa - Agua Marinoa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7484, "REMERON SIN MANGAS BEBA", "1 AL 5", "Blanco - Coral - Salmon", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            //list.Add(new Models.Clouth(7314, "CAMPERA RUSTICA BEBE", "1 AL 5", "Melange con Verde - Melange con Francia", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.Clouth(7323, "ROMPEVIENTO BEBE", "1 AL 5", "Rojo - Verde - Azul", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.Clouth(7423, "REMERA CARICATURA", "1 AL 5", "Gris Melange - Francia - Aero - Verde", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.Clouth(7424, "REMERA PALMERAS", "1 AL 5", "Gris Melange - Francia - Aero - Verde", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.Clouth(7425, "REMERA COMBINADA", "1 AL 5", "Melange con Francia - Blanco con Francia - Blanco con Verde", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES, "remerascamisas"));
            //list.Add(new Models.Clouth(7426, "CHOMBA", "1 AL 5", "Melange - Francia - Blanco - Verde - Aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.Clouth(7427, "CAMISA LISA", "1 AL 5", "Blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.Clouth(7428, "CAMISA ESCOCESA", "1 AL 5", "Rosa / Azul / Blanco - Turquesa / Francia / Blanco - Verde / Rojo / Blanco", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.Clouth(7429, "CAMISA JEAN", "1 AL 5", "Jean", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.Clouth(7430, "BERMUDA RUSTICA", "1 AL 5", "Francia Gris Melange - Verde", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.Clouth(7432, "BERMUDA GABARDINA", "1 A 5", "Francia - Marino - Verde", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.Clouth(7433, "BERMUDA JEAN", "1 AL 5", "Jean", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.Clouth(7434, "SHORT BAÑO 3 RECORTES", "1 AL 5", "Rojo - Azul", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.BEBES));
            //list.Add(new Models.Clouth(7436, "SHORT BAÑO ESTAMPADO", "1 AL 5", "", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.BEBES, anotherDesc: "Diseño A"));
            //list.Add(new Models.Clouth(7436, "SHORT BAÑO ESTAMPADO", "1 AL 5", "", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.BEBES,imgName:"7436-B", anotherDesc: "Diseño B"));
            //list.Add(new Models.Clouth(7436, "SHORT BAÑO ESTAMPADO", "1 AL 5", "", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.BEBES, imgName: "7436-c", anotherDesc: "Diseño C"));
            //list.Add(new Models.Clouth(7436, "SHORT BAÑO ESTAMPADO", "1 AL 5", "", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.BEBES, imgName: "7436-D",anotherDesc:"Diseño D"));
            //list.Add(new Models.Clouth(7440, "VESTIDO 3 VOLADOS MINI", "0 AL 3", "Blanco con Turquesa - Blanco con Coral", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.MINIBEBES));
            //list.Add(new Models.Clouth(7441, "VESTIDO FIBRANA", "0 AL 3", "Blanco - Salmon", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.MINIBEBES));
            //list.Add(new Models.Clouth(7443, "BODY CHOMBA MINI BEBE", "0 AL 3", "Melange con Marino - Celeste con Marino", Models.Clouth.SUBCATEGORY.BODY, Models.Clouth.CATEGORY.MINIBEBES));
            //list.Add(new Models.Clouth(7445, "CONJUNTO REMERA Y SORT", "0 AL 3", "Melange con Marino - Celeste con Marino", Models.Clouth.SUBCATEGORY.BODY, Models.Clouth.CATEGORY.MINIBEBES,"all"));
            //list.Add(new Models.Clouth(7317, "CAMPERA NENA", "4 AL 8 y 10 AL 14", "Fucsia - Chicle", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(7446, "REMERA CON MANGAS", "4 AL 8 y 10 AL 14", "Blanco - Salmon - Frutilla", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(7447, "REMERON CON ENCAJE", "4 AL 8 y 10 AL 14", "Blanco - Salmon - Frutilla", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(7450, "CALZA JASPEADA", "4 AL 8 y 10 AL 14", "Topo - Frutilla - Fucsia", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(7451, "CAMISOLA PLUMETI", "4 AL 8 y 10 AL 14", "Blanco - Rosa - AguaMarinoa", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(7452, "CALZA ESTAMPADA", "4 AL 8 y 10 AL 14", "Marino - Violeta - Salmon - Fucsia", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(7453, "VESTIDO ESTAMPADO", "4 AL 8 y 10 AL 14", "Rosa - Turquesa", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(7454, "VESTIDO FLOREADO", "4 AL 8 y 10 AL 14", "Verde - Chicle", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(7455, "SOLERO GUARDA", "4 AL 8 y 10 AL 14", "Fucsia - Verde", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(7456, "VESTIDO MODAL C - MANGA", "4 AL 8 y 10 AL 14", "Chicle - Salmon", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA, "vestidos"));
            //list.Add(new Models.Clouth(7457, "SOLERO 3 VOLADOS", "2 AL 6 y 8 AL 10", "Blanco - Salmon", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(7458, "VESTIDO CON CINTO", "4 AL 8 y 10 AL 14", "Chicle - Rojo", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(7459, "SOLERO PLUMETI", "2 AL 6 y 8 AL 10", "Blanco - Rosa - Agua Marino", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(7460, "ENTERITO LARGO", "4 AL 8 y 10 AL 14", "Francia con Rojo - Marino con Fucsia", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(7461, "ENTERITO CORTO", "4 AL 8 y 10 AL 14", "Rosa - Turquesa", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(7463, "SHORT FIBRANA  ", "4 AL 8 y 10 AL 14", "Francia con Rojo - Marino con Fucsia", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(7466, "SHORT JEAN", "4 AL 8 y 10 AL 14", "Jean", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(7482, "SOLERO JEAN", "4 AL 8 y 10 AL 14", "Jean", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(7483, "REMERON FLOR GRANDE", "4 AL 8 y 10 AL 14", "Melange - Blanco - Frutilla", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(7320, "CAMPERA VARON", "4 AL 8 y 10 AL 14", "Negro  - Topo - Marino", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.VARON));
            //list.Add(new Models.Clouth(7468, "REMERA C - ESTAMPA VARON", "4 AL 8 y 10 AL 14", "Gris Melange - Francia - Verde - Aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            //list.Add(new Models.Clouth(7469, "REMERA SKATE", "4 AL 8 y 10 AL 14", "Gris Melange - Francia - Verde - Aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            //list.Add(new Models.Clouth(7470, "REMERA ESTAMPADA", "4 AL 8 y 10 AL 14", "Melange con Marino - Francia con Verde - Celeste con Marino", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            //list.Add(new Models.Clouth(7472, "CAMISA ESCOCESA", "4 AL 8 y 10 AL 14", "Rojo / Azul / Blanco - Turquesa / Francia / Blanco - Verder / Rojo / Blanco", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.VARON));
            //list.Add(new Models.Clouth(7473, "CAMISA JEAN", "4 AL 8 y 10 AL 14", "Jean", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.VARON));
            //list.Add(new Models.Clouth(7474, "BEMUDA GABARDINA", "4 AL 8 y 10 AL 14", "Francia - Marino - Verde", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.VARON));
            //list.Add(new Models.Clouth(7476, "BERMUDA JEAN", "4 AL 8  y 10 AL 14", "Jean", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.VARON, "pantalonesshorts"));
            //list.Add(new Models.Clouth(7477, "SORT BAÑO C - VIVOS", "4 AL 8 y 10 AL 14", "Azul - Rojo", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.VARON));
            //list.Add(new Models.Clouth(7479, "SHORT BAÑO ESTAMPADO", "4 AL 8 y 10 AL 14", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.NENA, anotherDesc: "Diseño A"));
            //list.Add(new Models.Clouth(7479, "SHORT BAÑO ESTAMPADO", "4 AL 8 y 10 AL 14", "", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.VARON,imgName:"7479-B", anotherDesc: "Diseño B"));
            //list.Add(new Models.Clouth(7479, "SHORT BAÑO ESTAMPADO", "4 AL 8 y 10 AL 14", "", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.VARON, imgName: "7479-C", anotherDesc: "Diseño C"));
            //list.Add(new Models.Clouth(7479, "SHORT BAÑO ESTAMPADO", "4 AL 8 y 10 AL 14", "", Models.Clouth.SUBCATEGORY.SHORTDEBANO, Models.Clouth.CATEGORY.VARON, imgName: "7479-D", anotherDesc: "Diseño D"));
            //list.Add(new Models.Clouth(7480, "MUSCULOSA CON ESTAMPA", "4 AL 8 y 10 AL 14", "Gris Melange - Francia - Verde - Aero", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            //list.Add(new Models.Clouth(7481, "MUSCULOSA COMBINADA", "4 AL 8 y 10 AL 14", "Verde - Aero - Gris Melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7501, "REMERA MARIPOSA", "1 AL 5", "Blanco - Melange - Rosa - Fucsia", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7502, "REMERA BAILARINA", "1 AL 5", "Blanco - Melange - Rosa - Fucsia", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7503, "REMERA BAILARINA", "1 AL 5", "Blanco - Melange - Rosa - Fucsia", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7505, "Art 7505: BUZO - Art 7506: PANTALON FRISA", "1 AL 5", "Rosa - Rosa viejo - Melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS, code: "7505/7506", shortDescription: "BUZO - PANTALON FRISA"));
            list.Add(new Models.Clouth(7507, "BUZO PIEL", "1 AL 5", "Manteca - Rosa -Coral - Gris", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7504, "CALZA ESTAMPADA", "1 AL 5", "", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7508, "PANTALON RUSTICO ELASTIZADO", "1 AL 5", "Negro - Fucsia - Rosa", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7515, "CALZA LANILLA", "1 AL 5", "", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7520, "CALZA SIMIL JEAN", "1 AL 5", "Marino - Negro", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7521, "PANTALON JEAN ELASTIZADO", "1 AL 5", "", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7509, "Art 7509: PANTALON FRISA - Art 7510: CAMPERA FRISA", "1 AL 5", "Rosa - Rosa viejo - Fucsia - Melange", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBAS, code: "7509/7510", shortDescription: "PANTALON FRISA - CAMPERA FRISA"));
            list.Add(new Models.Clouth(7513, "CAMISOLA PLUMETI", "1 AL 5", "Blanco - Manteca", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7514, "VESTIDO LANILLA", "1 AL 5", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7516, "VESTIDO JEAN", "1 AL 5", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7509, "Art 7510: CAMPERA FRISA - Art 7509: PANTALON FRISA", "1 AL 5", "Rosa - Rosa viejo - Fucsia - Melange", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS, code: "7510/7509", shortDescription: "CAMPERA FRISA - PANTALON FRISA"));
            list.Add(new Models.Clouth(7531, "CAMPERA PIEL", "1 AL 5", "Rojo - Rosa - Crudo - Coral", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7518, "SACO PIEL", "1 AL 5", "Crudo - Coral - Rosa", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7519, "TAPADO PIEL", "1 AL 5", "Crudo - Rosa", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7517, "CAMPERA FRISA ESTAMPADA", "1 AL 5", "Melange - Natural", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7582, "CHALECO", "1 AL 5", "Rojo -Chicle - Gris", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7586, "CAMPERA BEBA", "1 AL 5", "Rojo -Chicle - Gris", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7587, "TAPADO ESTAMPADO", "1 AL 5", "", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Models.Clouth(7522, "REMERA CARICATURA", "1 AL 5", "Melange - Maiz - Aero - Petroleo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7523, "REMERA COMBINADA", "1 AL 5", "Melange - Maiz - Francia - Oxido", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7524, "CHOMBA", "1 AL 5", "Petroleo con Melange - Oxido con Beige - Petroleo con Maiz", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7533, "CAMISA CUADROS Y BLANCA LISA", "1 AL 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7525, "BUZO CON CODERA", "1 AL 5", "Melange - Verde - Petroleo - Naranja", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7526, "BUZO CON CAPUCHA", "1 AL 5", "Melange - Verde - Petroleo - Naranja", Models.Clouth.SUBCATEGORY.BUZOS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7529, "PANTALON FRISA", "1 AL 5", "Marino - Petroleo - Tomate - Melange - Topo", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7532, "JARDINERO JEAN", "1 AL 5", "", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7527, "CAMPERA FRISA EMOTICONES", "1 AL 5", "Azul - Rojo", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7528, "CAMPERA FRISA UNIVERSITARIA", "1 AL 5", "Tomate - Petroleo - Gris", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7530, "SACO PIEL", "1 AL 5", "Aero - Gris - Crudo", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7531, "CAMPERA PIEL", "1 AL 5", "Rojo - Crudo - Aero - Gris", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7588, "CAMPERA", "1 AL 5", "Petroleo con Gris - Rojo con Gris - Marino con Turquesa", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7583, "CHALECO", "1 AL 5", "Francia - Rojo - Gris - Aero", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Models.Clouth(7563, "Art 7563: BODY - Art 7564: JUMPER CORDEROY", "0 AL 3", "Blanco con Rosa - Rosa con Manteca", Models.Clouth.SUBCATEGORY.MINIBEBA, Models.Clouth.CATEGORY.MINIBEBES,code: "7563/7564", shortDescription: "BODY - JUMPER CORDEROY"));
            list.Add(new Models.Clouth(7565, "Art 7565: REMERA LANILLA - Art 7566: ENTERITO FRISA OSO", "0 AL 2", "Rosa - Rosa viejo - Melange", Models.Clouth.SUBCATEGORY.MINIBEBA, Models.Clouth.CATEGORY.MINIBEBES, code: "7565/7566", shortDescription: "REMERA LANILLA - ENTERITO FRISA OSO"));
            list.Add(new Models.Clouth(7568, "ENTERITO PLUSH GATO", "0 AL 3", "Rosa - Melange - Rojo - Fucsia", Models.Clouth.SUBCATEGORY.MINIBEBA, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(7569, "Art 7569: CAMPERA PLUSH RAYADA - Art 7576: PANTALON PLUSH", "0 AL 3", "Rosa con Gris", Models.Clouth.SUBCATEGORY.MINIBEBA, Models.Clouth.CATEGORY.MINIBEBES, code: "7569/7576", shortDescription: "CAMPERA PLUSH RAYADA - PANTALON PLUSH"));
            list.Add(new Models.Clouth(7569, "Art 7569: CAMPERA PLUSH RAYADA - Art 7576: PANTALON PLUSH", "0 AL 3", "Azul con Gris", Models.Clouth.SUBCATEGORY.MINIBEBE, Models.Clouth.CATEGORY.MINIBEBES, code: "7569/7576", shortDescription: "CAMPERA PLUSH RAYADA - PANTALON PLUSH"));
            list.Add(new Models.Clouth(7571, "REMERA CON BODY", "0 AL 3", "Petroleo con Melange - Petroleo con Maiz - Oxido con Beige", Models.Clouth.SUBCATEGORY.MINIBEBE, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(7572, "ENTERITO PLUSH OSO", "0 AL 3", "Rojo - Melange - Rosa", Models.Clouth.SUBCATEGORY.MINIBEBE, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(7565, "Art 7565: REMERA LANILLA - Art 7566: ENTERITO FRISA OSO", "0 AL 2", "Melange - Aero", Models.Clouth.SUBCATEGORY.MINIBEBE, Models.Clouth.CATEGORY.MINIBEBES, code: "7565/7566", shortDescription: "REMERA LANILLA - ENTERITO FRISA OSO"));
            list.Add(new Models.Clouth(7577, "PANTALON CORDEROY", "0 AL 3", "Aero - Marino", Models.Clouth.SUBCATEGORY.MINIBEBE, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(7579, "ENTERITO PIEL", "0 AL 2", "Crudo - Rojo - Aero - Gris - Coral", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(7580, "ASTRONAUTA OSO", "1 AL 3", "Gris - Beige - Rojo - Rosa -Aero", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(7581, "ASTRONAUTA ESTAMPADO", "1 AL 3", "", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Models.Clouth(7534, "REMERA CON APLIQUES", "4 AL 16", "Blanco - Melange - Fucsia", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7535, "REMERA CON PUNTILLA", "4 AL 14", "Blanco - Melange - Fucsia", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7537, "BUZO FRISA CON APLIQUES", "4 AL 14", "Fucsia - Melange - Rosa viejo", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7550, "BUZO PIEL BORDADO", "4 AL 16", "Crudo - Tomate - Rojo - Coral", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7540, "CALZA ESTAMPADA", "4 AL 16", "", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7541, "CALZA SIMIL JEAN", "4 AL 16", "Azul - Negro", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7542, "PANTALON RUSTICO ELASTIZADO", "4 AL 16", "Negro Fucsia", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7549, "CALZA CON RODILLERA", "4 AL 14", "Topo", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7544, "PANTALON JEAN ELASTIZADO", "4 AL 16", "", Models.Clouth.SUBCATEGORY.PANTALON, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7543, "CAMISOLA PLUMETI", "4 AL 14", "Blanco - Manteca", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7548, "VESTIDO ESTAMPADO", "4 AL 16", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7593, "VESTIDO JEAN", "4 AL 14", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7546, "CAMPERA FRISA CON CAPUCHA", "4 AL 14", "Fucsia - Melange - Rosa viejo", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7551, "CAMPERA PIEL", "4 AL 14", "Tomate - Beige - Rojo -Coral", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7545, "CAMPERA FRISA ESTAMPADA", "4 AL 16", "Melange - Crudo", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7584, "CHALECO ESTAMPADA", "4 AL 16", "", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7589, "CAMPERA LISA", "4 AL 14", "Rojo - Fucsia - Negro", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7590, "TAPADO", "4 AL 14", "Beige - Gris - Fucsia - Negro", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7591, "CAMPERA ESTAMPADA", "4 AL 14", "", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7594, "CAMPERA ESTAMPADA", "4 AL 14", "", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Models.Clouth(7598, "TAPADO CON PIEL", "4 AL 16", "Beige - Gris - Fucsia - Negro", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.NENA));
            //list.Add(new Models.Clouth(7552, "", "4 AL 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7555, "BUZO FRISA CON CIERRE", "4 AL 16", "Tomate - topo - Petroleo - Melange", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7562, "CAMISA ESCOCESA", "4 AL 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7557, "CAMPERA FRISA CON CUELLO", "4 AL 14", "Tomate - Topo - Petroleo - Melange", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7558, "CAMPERA FRISA CON CAPUCHA", "4 AL 14", "Grisa con Negro - Naranja con Gris - Petroleo con Melange", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7559, "CAMPERA FRISA UNIVERSITARIA", "4 AL 16", "Gris con Negro - Melange con Tomate - Petroleo con Topo", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7561, "PANTALON FRISA CON CIERRE", "4 AL 16", "Negro - Topo - Marino - Melange", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7585, "CHALECO VARON", "4 AL 14", "Negro - Francia - Marino - Gris", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Models.Clouth(7592, "CAMPERA COMBINADA", "4 AL 14", "Turquesa con Marino - Gris con Negro - Verde con Marino", Models.Clouth.SUBCATEGORY.ABRIGOS, Models.Clouth.CATEGORY.VARON));


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