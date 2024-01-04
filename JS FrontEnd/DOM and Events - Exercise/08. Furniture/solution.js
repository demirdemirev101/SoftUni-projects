function solve() {

  const formatButton=document.querySelector("#exercise button");
  formatButton.addEventListener('click', parseFurnitureInput);
  
  const buyButton=document.querySelector("#exercise button:nth-of-type(2)");
  buyButton.addEventListener('click', buySelectedFurniture);

  Array.from(
    document.querySelectorAll('input[type="checkbox"]')
    ).forEach((checkBox)=> checkBox.removeAttribute('disabled'));
}
function parseFurnitureInput(){
  const input=JSON.parse(document.querySelector("#exercise textarea").value);
  let tbody=document.querySelector(".table tbody");
  input
  .map((furniture)=>{
    const row=document.createElement('tr');

    const imageCell=document.createElement('td');
    const image=document.createElement('img');
    image.src=furniture.img;
    imageCell.appendChild(image);
    
    const nameCell=document.createElement('td');
    nameCell.textContent=furniture.name;

    const priceCell=document.createElement('td');
    priceCell.textContent=furniture.price;
    
    const decorationCell=document.createElement('td');
    decorationCell.textContent=furniture.decFactor;

    const checkBoxCell=document.createElement('td');
    const checkBox=document.createElement('input');
    checkBox.type='checkbox';
    checkBoxCell.appendChild(checkBox);

    row.appendChild(imageCell);
    row.appendChild(nameCell);
    row.appendChild(priceCell);
    row.appendChild(decorationCell);
    row.appendChild(checkBoxCell);

    return row;
  })
  .forEach((row) => tbody.appendChild(row));
}
function buySelectedFurniture(){
  
  markedCheckBoxes=Array.from(document.querySelectorAll('input[type="checkbox"]:checked'));
  textarea=document.querySelector("#exercise textarea:nth-of-type(2)");
  
  const cart=markedCheckBoxes.map((checkbox)=>{
    const row=checkbox.parentElement.parentElement;
    const name=row.querySelector("td:nth-of-type(2)").innerText;
    const price=Number(row.querySelector("td:nth-of-type(3)").innerText);
    const decorationFactor=Number(row.querySelector("td:nth-of-type(4)").innerText);

    return {name, price, decorationFactor};
  })
  .reduce((acc,curr)=> {
    acc.names.push(curr.name);
    acc.price+=curr.price;
    acc.avrgDecFactor+=curr.decorationFactor/markedCheckBoxes.length;

    return acc;
  },{
    names: [],
    price: 0,
    avrgDecFactor: 0, 
    })

  textarea.value+="Bought furniture: "+cart.names.join(", ")+'\n';
  textarea.value+=`Total price: ${cart.price.toFixed(2)} \n`;
  textarea.value+="Average decoration factor: "+cart.avrgDecFactor;
}