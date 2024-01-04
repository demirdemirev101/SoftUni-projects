 async function loadRepos() {
   result= document.querySelector("#res");
   let repos= await (await fetch("https://api.github.com/users/testnakov/repos"))
   .json();
   result.textContent=JSON.stringify(repos);

}