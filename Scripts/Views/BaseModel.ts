
/// <reference path="../typings/jquery/jquery.d.ts" />

/////<reference path='../Helpers/Api.ts'/>

module Views {

    export class BaseModel extends BaseView {

        constructor() {
            super();
            this.init();
        }

        public init() {
            (<any>$(".fancybox")).fancybox({
                openEffect: 'none',
                closeEffect: 'none'
            });
            //(<any>$("a[rel=example_group]")).fancybox({
            //    afterLoad: function (current, prev) {
            //        var from = current.href.lastIndexOf("/") + 1;
            //        var to = current.href.lastIndexOf(".");
            //        var id = current.href.substring(from, to);
            //        var elem = $("[data-hyalcore-id=" + id + "]");
            //        if (elem.length > 0) {
            //            Helpers.Hyalcore.postInteraction(elem);
            //        }
            //    },
            //    'transitionIn': 'none',
            //    'transitionOut': 'none',
            //    'titlePosition': 'over',
            //    loop: false,
            //    autoSize: false,
            //    autoDimensions: false,
            //    //'autoScale': false,
            //    titleFormat: function (title, currentArray, currentIndex, currentOpts) {
            //        return '<span id="fancybox-title-over">Foto ' + (currentIndex + 1) + ' / ' + currentArray.length + (title.length ? ' &nbsp; ' + title : '') + '</span>';
            //    }
            //});

        }

    }
}
 