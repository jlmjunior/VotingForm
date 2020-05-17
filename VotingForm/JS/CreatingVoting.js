var countOptions = 3;

function CreateInput() {
    h = countOptions;

    var listOptions = document.getElementById("listOptions");
    var input = document.createElement("input");

    input.setAttribute("type", "text");
    //input.setAttribute("id", "option" + h);
    input.setAttribute("class", "form-control form-control-lg rounded-right mb-3");
    input.setAttribute("placeholder", "Option");
    input.setAttribute("name", "option");
    //input.setAttribute("runat", "server");
    //input.setAttribute("clientidmode", "Static");

    listOptions.appendChild(input);
    countOptions++;

    return false;
}