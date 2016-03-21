$("tr").click(function (e) {
    $("tr").removeClass("highlighted");
    $(this).addClass("highlighted");
});