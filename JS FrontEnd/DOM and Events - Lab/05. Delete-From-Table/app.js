function deleteByEmail() {
    const email=document.querySelector('input[name="email"]').value;
    const emailBoxes= Array.from(document.querySelectorAll("td:nth-child(even)"));
    
    let found=emailBoxes.find(box=> box.textContent===email);
    let result=document.querySelector("#result");
    if(found){
        found.parentElement.remove();
        result.textContent='Deleted.';
    }
    else{
        result.textContent='Not found.';
    }
    
    //document.querySelector('input[name="email"]').value='';
}