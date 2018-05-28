$(document).ready(function () {

    $('#password').change(function () {

        //var a = 5;
        //var z = (a * 10) + 14;
        //alert(z);
        var l = Math.floor((Math.random() * 10000) + 1);
        $('#spantext').html('Your Code is ' + l);
    });
    $('a').click(function () {
        location.href = "Index";


    })
});