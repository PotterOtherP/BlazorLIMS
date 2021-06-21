function boxChecked(boxId) {

    var box = document.getElementById(boxId);

    console.log(boxId + ", " + box.checked);

    return box.checked;
}

function sayHello() {
    console.log("Hello from our JS file!");
}