var countOptions = 4;

function CreateInput() {
    h = countOptions;

    var listOptions = document.getElementById("listOptions");
    var input = document.createElement("input");

    input.setAttribute("type", "text");
    input.setAttribute("class", "form-control form-control-lg rounded-right mb-3");
    input.setAttribute("placeholder", "Option");
    input.setAttribute("name", "option" + countOptions);
    input.required = true;

    listOptions.appendChild(input);
    countOptions++;

    return false;
}