using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Helpers.Mvc
{
    public static class HtmlHelperModelConversionExtensions
    {

        public static HtmlHelper<TModel> ToModel<TModel>(this HtmlHelper @this, TModel model, Boolean defaultModel = false)
        {
            return new HtmlHelper<TModel>(
                @this.ViewContext,
                new CustomViewDataContainer<TModel>(@this.ViewData, model, defaultModel));
        }


        //<Extension>
        //Public Function ToItemModel(Of TModel)(htmlHelper As HtmlHelper(Of IEnumerable(Of TModel))) As HtmlHelper(Of TModel)
        //    Return htmlHelper.ToModel(Of TModel)()
        //End Function

        //<Extension>
        //Public Function ToItemModel(Of TModel)(htmlHelper As HtmlHelper(Of IEnumerable(Of TModel)), model As TModel) As HtmlHelper(Of TModel)
        //    Return htmlHelper.ToModel(Of TModel)(model)
        //End Function

        private class CustomViewDataContainer<TModel> : IViewDataContainer
        {
            public ViewDataDictionary ViewData { get; set; }

            public CustomViewDataContainer(ViewDataDictionary initialData)
            {

                ViewData = new ViewDataDictionary(null);

                foreach (var item in initialData)
                {
                    ViewData.Add(item);
                }
            }

            public CustomViewDataContainer(ViewDataDictionary initialData, TModel model, bool? defaultModel = null)
            {
                if (defaultModel.HasValue)
                {
                    ViewData = new ViewDataDictionary(Activator.CreateInstance<TModel>());
                }
                else
                {
                    ViewData = new ViewDataDictionary(model);
                }
                foreach (var item in initialData)
                {
                    ViewData.Add(item);
                }
            }


        }
    }




}