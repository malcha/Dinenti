/// <reference path="../typings/jquery/jquery.d.ts" />
/////<reference path='../Helpers/Api.ts'/>
module Views {

    export class BaseModel extends BaseView {

        constructor() {
            super();
            this.init();
        }

        public init() {
            //$("[data-open-modal-target]").click(this.onShowModal(event));
            $("[data-open-modal-target]").click(function (event) {
                $('#myModal5').modal('show'); 
                var elem = $(event.target);
                var src = elem.data("src");
                $('#myModal5').find('img').attr('src', src);
                $('#myModal5').find('#modal-code').text('Artículo: '+ elem.data("code"));
                $('#myModal5').find('#modal-description').text(elem.data("description"));
                var talles = elem.data("talles").split(";");
                $('#myModal5').find('#modal-talles').text('');
                talles.forEach(function (value) {
                    $('#myModal5').find('#modal-talles').append('<p>' + value + '</p>');
                });
                if (elem.data("tiene-precio"))
                    $('#myModal5').find('#modal-talles').append('<p class="iva">' + "Estos precios no incluyen IVA" + '</p>');
                //$('#myModal5').find('#modal-talles').text(elem.data("talles").replace(";", "\r\n"));
                if (elem.data("colores")!='')
                    $('#myModal5').find('#modal-colores').text('Colores: ' + elem.data("colores"));
                });
        }

        public onShowModal(event) {

            $('#myModal5').modal('show');
            //var elem = $(event.target);
            //var src = elem.data("src");
            //$('#myModal5').find('img').attr('src', src);
        }

    }
}
 