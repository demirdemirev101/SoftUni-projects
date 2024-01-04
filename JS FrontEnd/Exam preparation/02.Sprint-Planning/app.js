window.addEventListener('load', solve);

function solve() {
    
    const createBUtton= document.querySelector("#create-task-btn");
    
    createBUtton.addEventListener('click', ()=>{
        const title=document.querySelector("#title").value;
        const description=document.querySelector("#description").value;
        const selectedOption=Array.from(document.querySelector("#label"));
        selectedOption.forEach(option => {
        
        });
        console.log(selectedOption[0].value)
        const estimationPoints=document.querySelector("#points").textContent;
        const assignee=document.querySelector("#assignee").textContent;

        console.log(title+"\n"+description+"\n"+selectedOption+"\n"+estimationPoints+"\n"+assignee);
    })
}