$(document).ready(function () {
    $(".row a").click(function ()
    {
        $("p").toggle();
    });

    $(".btn_show").click(function () {

        $(this).next().slideToggle("slow");
    })

});




