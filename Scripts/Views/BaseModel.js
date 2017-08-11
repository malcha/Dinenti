/// <reference path="../typings/jquery/jquery.d.ts" />
var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
/////<reference path='../Helpers/Api.ts'/>
var Views;
(function (Views) {
    var BaseModel = (function (_super) {
        __extends(BaseModel, _super);
        function BaseModel() {
            _super.call(this);
            this.init();
        }
        BaseModel.prototype.init = function () {
            $("a[rel=example_group]").fancybox({
                afterLoad: function (current, prev) {
                    var from = current.href.lastIndexOf("/") + 1;
                    var to = current.href.lastIndexOf(".");
                    var id = current.href.substring(from, to);
                    var elem = $("[data-hyalcore-id=" + id + "]");
                    if (elem.length > 0) {
                        Helpers.Hyalcore.postInteraction(elem);
                    }
                },
                'transitionIn': 'none',
                'transitionOut': 'none',
                'titlePosition': 'over',
                loop: false,
                autoSize: false,
                autoDimensions: false,
                //'autoScale': false,
                titleFormat: function (title, currentArray, currentIndex, currentOpts) {
                    return '<span id="fancybox-title-over">Foto ' + (currentIndex + 1) + ' / ' + currentArray.length + (title.length ? ' &nbsp; ' + title : '') + '</span>';
                }
            });
        };
        return BaseModel;
    }(Views.BaseView));
    Views.BaseModel = BaseModel;
})(Views || (Views = {}));
//# sourceMappingURL=BaseModel.js.map