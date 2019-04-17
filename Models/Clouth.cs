﻿using System;
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
            MINIBEBES = 5
        }

        public enum SUBCATEGORY
        {
            REMERAS = 1,
            REMERON = 2,
            PANTALON = 3,
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
            GENERAL = 19
        }

        public Clouth(
            int id, string description, 
            string size1, string price1, 
            string size2, string price2, 
            string size3, string price3, 
            string colours, SUBCATEGORY subcategory, 
            CATEGORY category, 
            string action = "", 
            string imgName = null, 
            string code = null,
            bool promocion=false)
        {
            Promocion = promocion;
            Id = id;
            //LowImg = imgName == null ? id.ToString() : imgName;
            //HighImg = imgName == null ? id.ToString() : imgName;
            LowImg = imgName == null ? 7202.ToString() : imgName;
            //HighImg = (id % 2).ToString();
            HighImg = imgName == null ? id.ToString() : imgName; 
            GetCode = code == null ? Id.ToString() : code;

            TienePrecio = !String.IsNullOrWhiteSpace(price1)
                              || !String.IsNullOrWhiteSpace(price2)
                              || !String.IsNullOrWhiteSpace(price3);

            Talles = new List<string>();
            //if (!String.IsNullOrEmpty(size1))
                Talles.Add($"{size1}  {price1}");
            //if (!String.IsNullOrEmpty(size2))
                Talles.Add($"{size2}  {price2}");
                Talles.Add($"{size3}  {price3}");
            Colores = colours;
            ShortDescription = description.ToLower();
            SubCategory = subcategory;
            Category = category;
            
            Action = action;
            if (String.IsNullOrEmpty(colours))
                Description = String.Format("Art. {0} -  {1} - Talles: {2}", id.ToString(), description, String.Join(" / ", String.Join("/",Talles)));
            else
                Description = String.Format("Art. {0} -  {1} - Talles: {2} - Colores: {3}", id.ToString(), description, String.Join(" / ", String.Join("/", Talles)), colours);
        }

        public Clouth(
            bool isLocal,
            int id, string description,
            string size1, string price1,
            string size2, string price2,
            string size3, string price3,
            string colours, SUBCATEGORY subcategory,
            CATEGORY category,
            string action = "",
            string imgName = null,
            string code = null,
            bool promocion = false)
        {
            Promocion = promocion;
            Id = id;
            HighImg = imgName == null ? id.ToString() : imgName;
            GetCode = code == null ? Id.ToString() : code;

            TienePrecio = !String.IsNullOrWhiteSpace(price1)
                              || !String.IsNullOrWhiteSpace(price2)
                              || !String.IsNullOrWhiteSpace(price3);


            Talles = new List<string>();
            //if (!String.IsNullOrEmpty(size1))
          
            if (!string.IsNullOrEmpty(price1))
            {
                decimal.TryParse(price1.Replace("$","").Replace(" ",""), out var priceDecimal1);
                Talles.Add($"{size1}  Mayor {Decimal.Ceiling(Decimal.Multiply(priceDecimal1, 1.21m))} / Menor {Decimal.Ceiling(Decimal.Multiply(priceDecimal1, Decimal.Multiply(1.21m ,1.5m)))}");
            }
            else
            {
                Talles.Add($"{size1} {price1}");
            }
            //if (!String.IsNullOrEmpty(size2))
            //Talles.Add($"{size2}  {price2}");
            if (!string.IsNullOrEmpty(price2))
            {
                decimal.TryParse(price2.Replace("$", "").Replace(" ", ""), out var priceDecimal);
                Talles.Add($"{size2}  Mayor {Decimal.Ceiling(Decimal.Multiply(priceDecimal, 1.21m))} / Menor {Decimal.Ceiling(Decimal.Multiply(priceDecimal, Decimal.Multiply(1.21m, 1.5m)))}");
            }
            else
            {
                Talles.Add($"{size2} {price2}");
            }

            if (!String.IsNullOrEmpty(size3))
            {
                decimal.TryParse(price3.Replace("$", "").Replace(" ", ""), out var priceDecimal);
                Talles.Add($"{size3}  Mayor {Decimal.Ceiling(Decimal.Multiply(priceDecimal, 1.21m))} / Menor {Decimal.Ceiling(Decimal.Multiply(priceDecimal, Decimal.Multiply(1.21m, 1.5m)))}");
            }
            else
            {
                Talles.Add($"{size3} {price3}");

            }

            Colores = colours;
            ShortDescription = description.ToLower();
            SubCategory = subcategory;
            Category = category;

            Action = action;
            if (String.IsNullOrEmpty(colours))
                Description = String.Format("Art. {0} -  {1} - Talles: {2}", id.ToString(), description, String.Join(" / ", String.Join("/", Talles)));
            else
                Description = String.Format("Art. {0} -  {1} - Talles: {2} - Colores: {3}", id.ToString(), description, String.Join(" / ", String.Join("/", Talles)), colours);
        }

        public Clouth (int id,string description, string size, string colours,SUBCATEGORY subcategory,CATEGORY category, string action="", string imgName=null, string code=null ){
            Id=id;
            LowImg = imgName == null? id.ToString(): imgName;
            HighImg = imgName == null ? id.ToString() : imgName;
            GetCode = code == null ? Id.ToString() : code;

            Colores = colours;
            ShortDescription =description.ToLower();
            SubCategory = subcategory;
            Category = category;
            Action = action;
            if (String.IsNullOrEmpty(colours))
                Description = String.Format("Art. {0} -  {1} - Talles: {2}", id.ToString(), description, size);
            else
                Description = String.Format("Art. {0} -  {1} - Talles: {2} - Colores: {3}",id.ToString(), description, size, colours);
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
                case SUBCATEGORY.PANTALON:
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
            return String.Format("/{0}/{1}.gif", "Content/images/alta", HighImg);
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
        public String Colores { get; set; }
        public bool Promocion { get; set; }
        public bool TienePrecio { get; set; }
        public IList<string> Talles { get; set; }
        public CATEGORY Category { get; set; }
        public SUBCATEGORY? SubCategory { get; set; }
        public String Action { get; set; }
    }
}