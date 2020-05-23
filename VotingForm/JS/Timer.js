setInterval(function () {

    var divElement = document.getElementsByName("option");

    divElement.forEach(function (item, index) {

        var link = "../JsonRequest.aspx/?value=" + item.id;
        
        $.getJSON(link, function (result) {
            document.getElementById(item.id + "b").innerHTML = result["votes"];
            //item.innerHTML = result["votes"];
        });

    });

}, 2000);

function SendVote(op) {
    var option = op.id;

    var http = new XMLHttpRequest();

    var url = "../SendVote.aspx";
    //var params = "value=" + option;

    //console.log(option);

    http.open("POST", url, true);

    http.setRequestHeader("Content-type", "application/x-www-form-urlencoded");

    http.send('value=' + option);

}


