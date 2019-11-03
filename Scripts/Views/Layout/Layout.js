/// <reference path="../baseview.ts" />
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
var Views;
(function (Views) {
    var Layout = /** @class */ (function (_super) {
        __extends(Layout, _super);
        function Layout() {
            var _this = _super.call(this) || this;
            _this.$form = $('#contact');
            //this.$companyId = $('#CompanyId');
            _this.init();
            return _this;
        }
        Layout.prototype.init = function () {
            $("[name='tocontactus']").click(function () {
                $("#contactdiv").css("display", "block");
            });
            //$("#contactus").click(function () {
            //    $("#contactdiv").css("display", "block");
            //});
            $("#contact #cancel").click(function () {
                $(this).parent().parent().hide();
            });
            function validateEmail(email) {
                var filter = /^[\w\-\.\+]+\@[a-zA-Z0-9\.\-]+\.[a-zA-z0-9]{2,4}$/;
                if (filter.test(email)) {
                    $('#contact').submit();
                    return true;
                }
                else {
                    return false;
                }
                //return true;
            }
            ;
            // Contact form popup send-button click event.
            $("#send").click(function () {
                var name = $("#name").val();
                var email = $("#EmailFrom").val();
                var contact = $("#contactno").val();
                var message = $("#message").val();
                if (name == "" || email == "" || contact == "" || message == "") {
                    alert("Please Fill All Fields");
                }
                else {
                    if (validateEmail(email)) {
                        $("#contactdiv").css("display", "none");
                    }
                    else {
                        alert('Invalid Email Address');
                    }
                }
            });
        };
        return Layout;
    }(Views.BaseView));
    Views.Layout = Layout;
})(Views || (Views = {}));
//# sourceMappingURL=Layout.js.map