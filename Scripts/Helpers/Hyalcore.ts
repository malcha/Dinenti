///// <reference path="../baseview.ts" />


module Helpers {
    export class Hyalcore  {
        constructor() {
            this.init();
        }

        private init() {

            //$("[data-hyalcore]").click(function (event) {
            //    var elem = $(event.target);
            //    var id = elem.data("hyalcore-id");
            //    var isRecommendations = elem.data("hyalcore-recommendation");
            //    //$("#contactdiv").css("display", "block");
            //    $.post("hyalcore/interaction", { id: id, isRecommendations: isRecommendations })


            //});

        }

        public static postInteraction(elem: JQuery) {
            var id = elem.data("hyalcore-id");
            var isRecommendations = elem.data("hyalcore-recommendation");
            var fromRecommendation = (isRecommendations === 'true' || isRecommendations === true);
            $.get("/hyalcore/interaction", { id: id.toString(), recommendation: fromRecommendation })
        }

    }
} 