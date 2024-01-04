function addItem() {
    let textItem=document.getElementById('newItemText').value;
    let itemValue=document.getElementById('newItemValue').value;
    let option=document.createElement('option');

    option.textContent=textItem;
    option.setAttribute("value",itemValue);

    document.getElementById('menu').appendChild(option);

    document.getElementById('newItemText').value="";
    document.getElementById('newItemValue').value="";
}