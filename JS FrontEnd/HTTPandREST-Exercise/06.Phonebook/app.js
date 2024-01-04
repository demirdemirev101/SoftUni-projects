function attachEvents() {
    const loadBTN=document.querySelector("#btnLoad");
    loadBTN.addEventListener('click', async ()=>{
        const loadedPhoneBooks=await (await fetch("http://localhost:3030/jsonstore/phonebook"))
        .json();

        const items=document.querySelector("#phonebook");
        items.innerHTML="";

        Object.values(loadedPhoneBooks).forEach((phonebook)=>{
            console.log(phonebook);
            const item=document.createElement("li");
            item.textContent=`${phonebook.person}: ${phonebook.phone}`;
            
            const deleteBTN=document.createElement("button");
            deleteBTN.textContent="Delete";
            
            item.appendChild(deleteBTN);
            items.appendChild(item);

            //Delete button
            deleteBTN.addEventListener('click', ()=>{
                const key=phonebook._id;
                const deleteResponse= fetch(`http://localhost:3030/jsonstore/phonebook/${key}`, {
                    method: 'delete',
                });
                console.log(deleteResponse);
            })
        })
    });


    const personInput=document.getElementById("person");
    const phoneInput=document.getElementById("phone");

    const createBTN=document.querySelector("#btnCreate");
    createBTN.addEventListener('click', async ()=>{
        const person= personInput.value;
        const phone=phoneInput.value;
        const response= await fetch("http://localhost:3030/jsonstore/phonebook", {
            method: "POST",
            body: JSON.stringify({person, phone}),
        })
        
        console.log(response);
        personInput.value="";
        phoneInput.value="";
    });

}

attachEvents();