async function loadCommits() {

    const username=document.querySelector("#username").value;
    const repo=document.querySelector("#repo").value;
    let list=document.querySelector("#commits");
    list.innerHTML='';
    try {
        let commits = await (await fetch(`https://api.github.com/repos/${username}/${repo}/commits`))
        .json()
            commits.forEach(commitObject => {
                const item=document.createElement("li");
                item.textContent=`${commitObject.commit.author.name}: ${commitObject.commit.message}`;
                list.appendChild(item);
            })
    } catch (error) {
            const item=document.createElement("li");
                
            item.textContent=`Error: ${error.message='404'} (Not Found)`;
            list.appendChild(item);    
    }
}