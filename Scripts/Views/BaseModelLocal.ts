/// <reference path="../typings/jquery/jquery.d.ts" />
/////<reference path='../Helpers/Api.ts'/>
module Views {

    export class BaseModelLocal extends BaseView {

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
 