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
            list.Add(new Clouth(7609, "Campera Rústica", "4 al 14", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7607, "Rompeviento", "4 al 14", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.NENA));

            list.Add(new Clouth(7740, "Remera rayada", "4 al 16", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7754, "Remera sin manga con encaje", "4 al 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7749, "Camisola plumeti", "4 al 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7621, "Remera mariposa", "4 al 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7739, "Remera", "4 al 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.NENA));

            list.Add(new Clouth(7615, "Calza Lisa", "4 al 16", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7616, "Pantalón simil jean", "4 al 16", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7617, "Calza estampada", "4 al 16", "", Models.Clouth.SUBCATEGORY.PANTALONES, Models.Clouth.CATEGORY.NENA));
            //ENTERITOS
            list.Add(new Clouth(7748, "Enterito", "4 al 14", "", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7753, "Jardinero Jean con bordado", "4 al 14", "", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7768, "Jardinero Jean", "4 al 14", "", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7750, "Short Jean con estrella", "4 al 14", "", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7751, "Short Jean con puntilla", "4 al 14", "", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7752, "Short fibrana", "4 al 14", "", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.NENA));
            //VESTIDOS y SOLEROS
            list.Add(new Clouth(7741, "Vestido con flecos", "4 al 14", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7742, "Vestido con volado", "4 al 14", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7743, "Vestido fibrana", "4 al 14", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7744, "Vestido guarda", "4 al 14", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7745, "Solero", "4 al 14", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7746, "Solero gajos", "4 al 14", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
            list.Add(new Clouth(7747, "Solero plumeti", "4 al 14", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.NENA));
    

            list.Add(new Clouth(7604, "Campera rústica estampada", "1 al 5", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7606, "Campera rústica lisa", "1 al 5", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7614, "Pantalón rústico", "1 al 5", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7601, "Rompevientos", "1 al 5", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBAS));
            // new Clouth(7770,"","","",Models.Clouth.SUBCATEGORY.MAYAS,Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7619, "Remera flores", "1 al 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7701, "Remera bici", "1 al 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7702, "Remera corazón", "1 al 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7703, "Remera con puntilla", "1 al 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7704, "Remera", "1 al 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7705, "Camisola plumeti", "1 al 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7611, "Calza lisa", "1 al 5", "", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7612, "Calza simil jean", "1 al 5", "", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7613, "Calza estampada", "1 al 5", "", Models.Clouth.SUBCATEGORY.CALZAS, Models.Clouth.CATEGORY.BEBAS));
            //ENTERITOS
            list.Add(new Clouth(7712, "Enterito", "1 al 5", "", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7713, "Enterito fibrana", "1 al 5", "", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7715, "Short liso", "1 al 5", "", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7716, "Short Jean", "1 al 5", "", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7717, "Jardinero gato bordado", "1 al 5", "", Models.Clouth.SUBCATEGORY.ENTERITOS, Models.Clouth.CATEGORY.BEBAS));
            //VESTIDOS y SOLEROS
            list.Add(new Clouth(7706, "Solero fibrana", "1 al 5", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7708, "Vestido plumeti", "1 al 5", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7709, "Vestido modal estampado", "1 al 5", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7710, "Vestido guarda", "1 al 5", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
            list.Add(new Clouth(7711, "Vestido jean", "1 al 5", "", Models.Clouth.SUBCATEGORY.VESTIDOS, Models.Clouth.CATEGORY.BEBAS));
    

            list.Add(new Clouth(7603, "Campera rústica estampada", "1 al 5", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7605, "Campera rústica lisa", "1 al 5", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7614, "Pantalón rústico", "1 al 5", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7602, "Rompevientos", "1 al 5", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7620, "Remera monstruo", "1 al 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7718, "Remera Surf", "1 al 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7719, "Remera", "1 al 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7720, "Remera", "1 al 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7721, "Remera con cartera", "1 al 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7727, "Remera sin mangas", "1 al 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7728, "Remera sin mangas con cartera", "1 al 5", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7722, "camisa blanca", "1 al 5", "", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7723, "camisa estampada", "1 al 5", "", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7769, "camisa escocesa", "1 al 5", "", Models.Clouth.SUBCATEGORY.CAMISAS, Models.Clouth.CATEGORY.BEBES));

            list.Add(new Clouth(7724, "Bermuda rústica", "1 al 5", "", Models.Clouth.SUBCATEGORY.BERMUDAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7725, "Bermuda jean", "1 al 5", "", Models.Clouth.SUBCATEGORY.BERMUDAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7726, "Jardinero", "1 al 4", "", Models.Clouth.SUBCATEGORY.BERMUDAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7729, "Bermuda con cierre", "1 al 5", "", Models.Clouth.SUBCATEGORY.BERMUDAS, Models.Clouth.CATEGORY.BEBES));
            list.Add(new Clouth(7730, "Short baño", "1 al 5", "", Models.Clouth.SUBCATEGORY.BERMUDAS, Models.Clouth.CATEGORY.BEBES, code: "7730 A", imgName: "77302"));
            list.Add(new Clouth(7730, "Short baño", "1 al 5", "", Models.Clouth.SUBCATEGORY.BERMUDAS, Models.Clouth.CATEGORY.BEBES, code: "7730 B", imgName: "77303"));
            list.Add(new Clouth(7730, "Short baño", "1 al 5", "", Models.Clouth.SUBCATEGORY.BERMUDAS, Models.Clouth.CATEGORY.BEBES, code: "7730 C",imgName:"7730"));
            list.Add(new Clouth(7730, "Short baño", "1 al 5", "", Models.Clouth.SUBCATEGORY.BERMUDAS, Models.Clouth.CATEGORY.BEBES, code: "7730 D", imgName:"77301"));
            list.Add(new Clouth(7731, "Short con lycra", "1 al 5", "", Models.Clouth.SUBCATEGORY.BERMUDAS, Models.Clouth.CATEGORY.BEBES));
    
            list.Add(new Clouth(7733, "Conjunto", "0 al 3", "", Models.Clouth.SUBCATEGORY.MINIBEBE, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Clouth(7734, "Jardinero estampado", "0 al 3", "", Models.Clouth.SUBCATEGORY.MINIBEBE, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Clouth(7735, "Vestido con body estampado", "0 al 3", "", Models.Clouth.SUBCATEGORY.MINIBEBA, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Clouth(7736, "Vestido con body plumeti", "0 al 3", "", Models.Clouth.SUBCATEGORY.MINIBEBA, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Clouth(7737, "vestido body", "0 al 3", "", Models.Clouth.SUBCATEGORY.MINIBEBA, Models.Clouth.CATEGORY.MINIBEBES));
            list.Add(new Clouth(7738, "Conjunto", "0 al 3", "", Models.Clouth.SUBCATEGORY.MINIBEBA, Models.Clouth.CATEGORY.MINIBEBES));
    
            list.Add(new Clouth(7610, "Campera combinada rústica", "4 al 14", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Clouth(7618, "Pantalón rústico", "4 al 14", "", Models.Clouth.SUBCATEGORY.CAMPERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Clouth(7622, "Remera", "4 al 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Clouth(7755, "Remera", "4 al 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Clouth(7756, "Remera", "4 al 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Clouth(7757, "Remera", "4 al 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Clouth(7758, "Chomba", "4 al 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Clouth(7765, "Remera Palmeras", "4 al 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Clouth(7766, "Remera 52", "4 al 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Clouth(7764, "Remera sin mangas", "4 al 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Clouth(7767, "Remera sin mangas 23", "4 al 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Clouth(7760, "Bermuda jean", "4 al 14", "", Models.Clouth.SUBCATEGORY.BERMUDAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Clouth(7761, "Bermuda rústica", "4 al 16", "", Models.Clouth.SUBCATEGORY.BERMUDAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Clouth(7762, "Short baño", "4 al 16", "", Models.Clouth.SUBCATEGORY.BERMUDAS, Models.Clouth.CATEGORY.VARON, code: "7762 A"));
            list.Add(new Clouth(7762, "Short baño", "4 al 16", "", Models.Clouth.SUBCATEGORY.BERMUDAS, Models.Clouth.CATEGORY.VARON, code: "7762 B", imgName:"77621"));
            list.Add(new Clouth(7762, "Short baño", "4 al 16", "", Models.Clouth.SUBCATEGORY.BERMUDAS, Models.Clouth.CATEGORY.VARON, code: "7762 C", imgName:"77622"));
            list.Add(new Clouth(7762, "Short baño", "4 al 16", "", Models.Clouth.SUBCATEGORY.BERMUDAS, Models.Clouth.CATEGORY.VARON, code: "7762 D", imgName: "77623"));
            list.Add(new Clouth(7763, "Short con lycra", "4 al 14", "", Models.Clouth.SUBCATEGORY.BERMUDAS, Models.Clouth.CATEGORY.VARON));


            list.Add(new Clouth(7759, "Camisa escocesa", "4 al 16", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));
            list.Add(new Clouth(7771, "Camisa lisa", "4 al 14", "", Models.Clouth.SUBCATEGORY.REMERAS, Models.Clouth.CATEGORY.VARON));

            return list;
        }

    }
}