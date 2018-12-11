var knap = jQuery("#minknap");
console.log(knap);

knap.click(function () {
    //console.log("12");
   // $.getJSON("")

    //$.getJSON("/Home/Test5").done(function (data) {
    //    console.log(data);
    //});
    $.getJSON("/Home/Test5").done(function (data) {
        var ol = $("#minliste");
        ol.empty();

        for (var i = 0; i < data.length; i++) {
            var li = $("<li />").html(data[i].Navn);
            ol.append(li);
        }
    });
});


