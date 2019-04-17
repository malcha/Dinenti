///// <reference path="../baseview.ts" />
var Helpers;
(function (Helpers) {
    var Hyalcore = /** @class */ (function () {
        function Hyalcore() {
            this.init();
        }
        Hyalcore.prototype.init = function () {
            //$("[data-hyalcore]").click(function (event) {
            //    var elem = $(event.target);
            //    var id = elem.data("hyalcore-id");
            //    var isRecommendations = elem.data("hyalcore-recommendation");
            //    //$("#contactdiv").css("display", "block");
            //    $.post("hyalcore/interaction", { id: id, isRecommendations: isRecommendations })
            //});
        };
        Hyalcore.postInteraction = function (elem) {
            var id = elem.data("hyalcore-id");
            var RecommendationId = elem.data("hyalcore-recommendation");
            //var fromRecommendation = (isRecommendations === 'true' || isRecommendations === true);
            $.get("/hyalcore/interaction", { id: id.toString(), recommendation: RecommendationId });
        };
        return Hyalcore;
    }());
    Helpers.Hyalcore = Hyalcore;
})(Helpers || (Helpers = {}));
//# sourceMappingURL=Hyalcore.js.map