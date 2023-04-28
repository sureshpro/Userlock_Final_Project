/*
  Company Name : Allyhealth Business Process Solutions
  Title : Userlock Status Project
  Author Name : Suresh Mohan
  File Name : script.js
*/

// this is the jquery autocomplete textbox code
$(function () {
    $("#TextBox1").autocomplete({
        source: function (request, response) {
            var param = { empdetails: $('#TextBox1').val() };

            // Send a POST request to the server to retrieve employee details.
            $.ajax({
                url: "index.aspx/GetEmp",
                data: JSON.stringify(param),
                type: "post",
                contentType: "application/json; charset=utf-8",
                success: function (data) {

                    // Map the returned data to the format expected by the autocomplete feature.
                    response($.map(data.d, function (item) { return { value: item } }))
                },
            });
        },
        minLength: 1 // Set the minimum number of characters required for autocomplete to start.
    });
});




