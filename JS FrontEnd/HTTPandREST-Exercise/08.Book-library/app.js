let editKey=null;
const authorInput=document.querySelector("input[name='author']");
const titleInput=document.querySelector("input[name='title']");
tableBody=document.querySelector("body table tbody");

function attachEvents() {
  const loadButton=document.querySelector("#loadBooks");
  loadButton.addEventListener('click', loadBooks);

  const submitButton=document.querySelector("#form button");
  console.log(submitButton.textContent);
  submitButton.addEventListener("click", ()=>{
    if (submitButton.textContent === 'Submit') {
      submitData();
    } else if (submitButton.textContent === 'Save'){
      changeContent();
    }
  });
}

//POST request
async function submitData(){
  const author=authorInput.value;
  const title=titleInput.value;
  if(!author&& !title){
    return;
  }
  const postResponse= await fetch("http://localhost:3030/jsonstore/collections/books", {
    method: "POST",
    body: JSON.stringify({author, title}),
  });
  console.log(postResponse);
  authorInput.value='';
  titleInput.value='';
}

//PUT request
async function changeContent(){
  const author=authorInput.value;
  const title=titleInput.value;
  
  const putResponse= await fetch(`http://localhost:3030/jsonstore/collections/books/${editKey}`,{
    method: 'PUT',
    body: JSON.stringify({author, title})
  })
  console.log(putResponse);

  document.querySelector("#form h3").textContent="FORM";
  document.querySelector("#form button").textContent="Submit";

  document.querySelector("input[name='author']").value='';
  document.querySelector("input[name='title']").value='';
}

//Get request
async function loadBooks(){
  const response= await(await fetch("http://localhost:3030/jsonstore/collections/books"))
  .json();
  console.log(Object.values(response));

  tableBody=createTable(response);
}

function createTable(response){
  tableBody.innerHTML='';
  Object.values(response).forEach(async (book)=>{
    const key=book._id;
    const tableRow=document.createElement("tr");

    const authorCell=document.createElement("td");
    const titleCell=document.createElement("td");
    const actionCell=document.createElement("td");
    
    const editButton=document.createElement("button");
    const deleteButton=document.createElement("button");
    editButton.textContent="Edit";
    deleteButton.textContent="Delete";

    actionCell.appendChild(editButton);
    actionCell.appendChild(deleteButton);

    authorCell.textContent=book.author;
    titleCell.textContent=book.title;

    tableRow.appendChild(titleCell);
    tableRow.appendChild(authorCell);
    tableRow.appendChild(actionCell);

    tableBody.appendChild(tableRow);

  //DELETE request
    deleteButton.addEventListener("click", async ()=>{
      const deleteResponse= await fetch(`http://localhost:3030/jsonstore/collections/books/${key}`,{
        method: 'DELETE',
      })
    })

    //Edit
    editButton.addEventListener('click', async ()=>{
      
      document.querySelector("#form h3").textContent="Edit FORM";
      document.querySelector("#form button").textContent="Save";
      
      authorInput.value=book.author;
      titleInput.value=book.title;

      editKey=book._id;
    })
  });

  return tableBody;
}
attachEvents();