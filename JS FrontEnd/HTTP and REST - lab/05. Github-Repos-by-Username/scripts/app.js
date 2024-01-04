async function loadRepos() {
	const username=document.querySelector("#username").value;
	let repos= await (await fetch(`https://api.github.com/users/${username}/repos`))
   .json();

   const list=document.querySelector("#repos");
   list.innerText="";

   repos.forEach(repo => {
	   const a=document.createElement("a");
	   a.innerText=`${repo.full_name}`;
	   a.href=repo.html_url;
	   
	   const item = document.createElement("li");
	   item.appendChild(a);
	   list.appendChild(item);
   });
}
