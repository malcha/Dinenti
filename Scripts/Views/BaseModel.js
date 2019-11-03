var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
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
    var BaseModel = /** @class */ (function (_super) {
        __extends(BaseModel, _super);
        function BaseModel() {
            var _this = _super.call(this) || this;
            _this.init();
            return _this;
        }
        BaseModel.prototype.init = function () {
            //$("[data-open-modal-target]").click(this.onShowModal(event));
            $("[data-open-modal-target]").click(function (event) {
                $('#myModal5').modal('show');
                var elem = $(event.target);
                var src = elem.data("src");
                $('#myModal5').find('img').attr('src', src);
                $('#myModal5').find('#modal-code').text('Artículo: ' + elem.data("code"));
                $('#myModal5').find('#modal-description').text(elem.data("description"));
                var talles = elem.data("talles").split(";");
                $('#myModal5').find('#modal-talles').text('');
                talles.forEach(function (value) {
                    $('#myModal5').find('#modal-talles').append('<p>' + value + '</p>');
                });
                if (elem.data("tiene-precio"))
                    $('#myModal5').find('#modal-talles').append('<p class="iva">' + "Estos precios no incluyen IVA" + '</p>');
                //$('#myModal5').find('#modal-talles').text(elem.data("talles").replace(";", "\r\n"));
                if (elem.data("colores") != '')
                    $('#myModal5').find('#modal-colores').text('Colores: ' + elem.data("colores"));
            });
        };
        BaseModel.prototype.onShowModal = function (event) {
            $('#myModal5').modal('show');
            //var elem = $(event.target);
            //var src = elem.data("src");
            //$('#myModal5').find('img').attr('src', src);
        };
        return BaseModel;
    }(Views.BaseView));
    Views.BaseModel = BaseModel;
})(Views || (Views = {}));
//# sourceMappingURL=BaseModel.js.map