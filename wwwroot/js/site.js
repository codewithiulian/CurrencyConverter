// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
function GetCurrency() {
    var url = "/Home/GetCurrency";
    var data = {
        "SourceAmount": $("#sourceAmount").val(),
        "SourceCurrency": $("#sourceCurrency").val(),
        "TargetCurrency": $("#targetCurrency").val()
    };

    $.ajax({
        type: "GET",
        url: url,
        data: data
    }).then(function (result) {
        $("#result").html(data.SourceAmount + " " + data.SourceCurrency + " = " + result + " " + data.TargetCurrency);
    }).fail(function (err) { console.log(err); });
}