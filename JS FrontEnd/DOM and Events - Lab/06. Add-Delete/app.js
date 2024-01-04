function addItem() {
    let text=document.getElementById("newItemText").value;
    let item=document.createElement("li");
    let ul=document.getElementById("items");

    item.appendChild(document.createTextNode(text));
    item.appendChild(addDeleteButtonAndEventHandler());

    ul.appendChild(item);

}
function addDeleteButtonAndEventHandler(){
    let deleteButton= document.createElement("a");
    deleteButton.href="#";
    deleteButton.textContent="[Delete]";
    
    deleteButton.addEventListener('click', (e)=>{
        e.target.parentElement.remove();
    })
    return deleteButton;
}