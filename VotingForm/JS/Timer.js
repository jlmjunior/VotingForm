setInterval(function () {

    var divElement = document.getElementsByName("option");

    divElement.forEach(function (item, index) {

        var link = "../JsonRequest.aspx/?value=" + item.id;

        $.getJSON(link, function (result) {
            item.innerHTML = result["votes"];
        });

    });

}, 2000);


