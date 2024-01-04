function focused() {
  let array =Array.from(document.querySelectorAll('input'));

  array.forEach((a)=>{
    a.addEventListener('focus', (e)=>{
        e.target.parentElement.className="focused";
    })
    a.addEventListener('blur', (e)=>{
        e.target.parentElement.className="";
    })
  });
}