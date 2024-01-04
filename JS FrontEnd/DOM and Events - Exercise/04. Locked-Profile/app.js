function lockedProfile() {
    let buttons=Array.from(document.querySelectorAll("button"));
   
    buttons.forEach(button => {
        button.addEventListener('click', checkAndAction);
   });
}
function checkAndAction(e)
{
    const checkLockedOrNot= e.currentTarget.parentElement.querySelector("input[type='radio']");
            
    if(checkLockedOrNot.checked){
         return;
    }

    const isHidden=e.currentTarget.textContent==="Show more";
    const hiddenInfo=e.currentTarget.parentElement.querySelector('div');

    hiddenInfo.style.display=isHidden ? 'block':'none';
    e.currentTarget.textContent=isHidden ? 'Hide it' : 'Show more';

    return checkLockedOrNot;
}