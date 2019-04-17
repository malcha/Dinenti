/// <reference path="../baseview.ts" />


module Views {
    export class Layout extends BaseView {
        private $form :JQuery;

        constructor() {
            super();
            this.$form = $('#contact');
            //this.$companyId = $('#CompanyId');
            this.init();
        }

        private init() {

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
                } else {
                    return false;
                }
                //return true;
            };

            // Contact form popup send-button click event.
            $("#send").click(() => {
                var name = $("#name").val();
                var email = $("#EmailFrom").val();
                var contact = $("#contactno").val();
                var message = $("#message").val();
                if (name == "" || email == "" || contact == "" || message == "") {
                    alert("Please Fill All Fields");
                } else {
                    if (validateEmail(email)) {
                        $("#contactdiv").css("display", "none");
                    } else {
                        alert('Invalid Email Address');
                    }
                  }
            });
        }
    }
}