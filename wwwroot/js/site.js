function boxChecked(boxId) {

    return document.getElementById(boxId).checked;
}

function sayHello() {
    console.log("Hello from our JS file!");
}

function toggleVisibility(name, value) {

    var element = document.getElementById(name);

    if (!value)
    {
        element.setAttribute("style", "display: grid; grid-template-columns: 1fr 1fr 1fr; ");
    }
    else
    {
        element.setAttribute("style", "display: none; ");
    }
}