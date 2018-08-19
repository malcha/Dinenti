using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class HyalcoreClouth
    {
        public Clouth Clouth { get; set; }

        public string RecommendationId { get; set; }
    }

    public class Clouth
    {
        public enum CATEGORY
        {
            VARON = 1,
            NENA = 2,
            BEBES = 3,
            BEBAS = 4,
            MINIBEBES = 5,
            TEENS=6
        }

        public enum SUBCATEGORY
        {
            REMERAS = 1,
            REMERON = 2,
            PANTALONES = 3,
            CALZAS = 4,
            BUZOS = 5,
            CAMPERAS = 6,
            CAMISAS = 7,
            ABRIGOS = 8,
            JUMPER = 9,
            VESTIDOS = 10,
            BODY = 11,
            ENTERITOS = 12,
            ASTRONAUTAS = 13,
            CHALECOS = 14,
            SHORTDEBANO = 15,
            SOLEROS = 16,
            SHORT = 17,
            CHOMBAS=18,
            GENERAL = 19,
            MINIBEBA = 20,
            MINIBEBE = 21,
            BERMUDAS = 22,
            NENA=23,
            NENE=24
        }

        public Clouth (int id,string description, string size, string colours,SUBCATEGORY subcategory,CATEGORY category, string action="", string imgName=null, string code=null,string anotherDesc="", string shortDescription=""){
            Id=id;

            LowImg = imgName == null? id.ToString(): imgName;
            HighImg = imgName == null ? id.ToString() : imgName;
            GetCode = code == null ? "Art. " + Id.ToString() : code;
            //string IdToString = String.IsNullOrEmpty(imgName) ? id.ToString(): imgName;
            string IdToString = id.ToString();

            
            ShortDescription = String.IsNullOrEmpty(shortDescription)? description.ToLower(): shortDescription.ToLower();
            SubCategory = subcategory;
            Category = category;
            Action = action;
            if (String.IsNullOrEmpty(code))
            {
                Description = String.Format("Art. {0} -  {1}", IdToString, description);
            }
            else {
                Description = String.Format("{0}", description);
            }

            if (!String.IsNullOrEmpty(colours))
                Description = String.Format("{0} - Talles: {1} - Colores: {2}", Description, size, colours);
            else if (!String.IsNullOrEmpty(anotherDesc))
                Description = String.Format("{0} - Talles: {1} - {2}", Description, size,anotherDesc);
            else
                Description = String.Format("{0} - Talles: {1}", Description, size);
        }

        #region "privateMethods"
        public String getSubCategory()
        {
            var subCat = "";
            switch (SubCategory)
            {
                case SUBCATEGORY.ABRIGOS:
                    subCat = "abrigos";
                    break;
                case SUBCATEGORY.ASTRONAUTAS:
                    subCat = "astronautas";
                    break;
                case SUBCATEGORY.BODY:
                    subCat = "body";
                    break;
                case SUBCATEGORY.BUZOS:
                    subCat = "buzos";
                    break;
                case SUBCATEGORY.CALZAS:
                    subCat = "calzas";
                    break;
                case SUBCATEGORY.CAMISAS:
                    subCat = "camisas";
                    break;
                case SUBCATEGORY.CAMPERAS:
                    subCat = "camperas";
                    break;
                case SUBCATEGORY.CHALECOS:
                    subCat = "chalecos";
                    break;
                case SUBCATEGORY.ENTERITOS:
                    subCat = "enteritos";
                    break;
                case SUBCATEGORY.JUMPER:
                    subCat = "jumpers";
                    break;
                case SUBCATEGORY.PANTALONES:
                    subCat = "pantalon";
                    break;
                case SUBCATEGORY.REMERAS:
                    subCat = "remeras";
                    break;
                case SUBCATEGORY.REMERON:
                    subCat = "remeron";
                    break;
                case SUBCATEGORY.SHORTDEBANO:
                    subCat = "shortdebano";
                    break;
                case SUBCATEGORY.SOLEROS:
                    subCat = "soleros";
                    break;
                case SUBCATEGORY.VESTIDOS:
                    subCat = "vestidos";
                    break;
                default:
                    break;
            }

            return subCat;
        }

        public String getCategory()
        {
            String category = "";
            switch (Category)
            {
                case CATEGORY.BEBAS:
                    category = "bebas";
                    break;
                case CATEGORY.BEBES:
                    category = "bebes";
                    break;
                case CATEGORY.MINIBEBES:
                    category = "minibebes";
                    break;
                case CATEGORY.NENA:
                    category = "nena";
                    break;
                case CATEGORY.VARON:
                    category = "varon";
                    break;
            }
            return category;
        }

        #endregion

        
        public String getUrlPath()
        {
            return String.Format("/{0}/{1}", getCategory(), Action);
        }

        public String getLowImgPath()
        {
            return String.Format("/{0}/{1}.gif", "Content/images/baja", LowImg);
        }
        public String getHighImgPath()
        {
            return String.Format("/{0}/{1}.jpg", "Content/images/alta", HighImg);
        }
        public String getHomeImgPath()
        {
            return String.Format("/{0}/{1}.jpg", "Content/images/recomendaciones", LowImg);
        }

        public string GetCode { get; set; }
        public int Id { get; set; }
        public String ShortDescription { get; set; }
        public String Description { get; set; }
        public String LowImg { get; set; }
        public String HighImg { get; set; }
        public CATEGORY Category { get; set; }
        public SUBCATEGORY? SubCategory { get; set; }
        public String Action { get; set; }
    }
}