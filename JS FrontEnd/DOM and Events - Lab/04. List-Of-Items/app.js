function addItem() {
    let text=document.getElementById("newItemText").value;
    let li=document.createElement("li");
    let ul=document.getElementById("items");

    li.appendChild(document.createTextNode(text));
    ul.appendChild(li);
    document.getElementById("newItemText").value='';
}