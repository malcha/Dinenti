var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
/// <reference path="../typings/jquery/jquery.d.ts" />
/////<reference path='../Helpers/Api.ts'/>
var Views;
(function (Views) {
    var BaseModelLocal = /** @class */ (function (_super) {
        __extends(BaseModelLocal, _super);
        function BaseModelLocal() {
            var _this = _super.call(this) || this;
            _this.init();
            return _this;
        }
        BaseModelLocal.prototype.init = function () {
            //$("[data-open-modal-target]").click(this.onShowModal(event));
            $("[data-open-modal-target]").click(function (event) {
                $('#myModal5').modal('show');
                var elem = $(event.target);
                var src = elem.data("src");
                $('#myModal5').find('img').attr('src', src);
                $('#myModal5').find('#modal-code').text('Artículo: ' + elem.data("code"));
                $('#myModal5').find('#modal-description').text(elem.data("description"));
                //var t = elem.data("talle-por-menor");
                //var t2 = JSON.parse(elem.data("talle-por-menor2"));
                //var t3 = elem.data("talle-por-mayor");
                $('#myModal5').find('#modal-talle-menor').text(elem.data("talle-por-menor"));
                //$('#myModal5').find('#modal-talle-menor2').text(elem.data("talle-por-menor2"));
                $('#myModal5').find('#modal-talle-mayor').text(elem.data("talle-por-mayor"));
                //talles.forEach(function (value) {
                //    $('#myModal5').find('#modal-talle-precio').append('<p>' + value + '</p>');
                //});
                //$('#myModal5').find('#modal-talles').text(elem.data("talles").replace(";", "\r\n"));
                if (elem.data("colores") != '')
                    $('#myModal5').find('#modal-colores').text('Colores: ' + elem.data("colores"));
            });
        };
        BaseModelLocal.prototype.onShowModal = function (event) {
            $('#myModal5').modal('show');
            //var elem = $(event.target);
            //var src = elem.data("src");
            //$('#myModal5').find('img').attr('src', src);
        };
        return BaseModelLocal;
    }(Views.BaseView));
    Views.BaseModelLocal = BaseModelLocal;
})(Views || (Views = {}));
//# sourceMappingURL=BaseModelLocal.js.map