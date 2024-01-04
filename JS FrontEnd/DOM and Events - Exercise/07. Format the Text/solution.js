function solve() {
  
  const input=Array.from(document.querySelector('#input').value.split('.'));
  input.pop();
  
  let output=document.querySelector("#output");
  
    while(input.length>0){
      
      let p=document.createElement('p');
      p.textContent=input
      .splice(0,3)
      .map((c)=>c.trim())
      .join('.');
      
      output.appendChild(p);
  }
}