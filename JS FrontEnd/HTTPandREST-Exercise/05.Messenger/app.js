function attachEvents() {
    const submitBTN=document.querySelector("#submit");
    const refreshBTN=document.querySelector("#refresh");

    submitBTN.addEventListener("click", sendMessage);
    refreshBTN.addEventListener("click", getMessages);
}
async function sendMessage(){

    const author=document.querySelector("input[name='author']").value;
    const content=document.querySelector("input[name='content']").value;

    const response=await fetch('http://localhost:3030/jsonstore/messenger', {
        method: "POST",
        body: JSON.stringify({author, content}),
    });
    console.log(response);
}
async function getMessages(){
    const response=await (await fetch("http://localhost:3030/jsonstore/messenger"))
    .json();
    
    const messageBox=document.querySelector("#messages");
    messageBox.textContent='';

    Object.values(response).forEach((message)=>{
        messageBox.textContent+=`${message.author}: ${message.content}\n`;
    })
}
attachEvents();