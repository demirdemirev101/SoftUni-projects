let posts;
async function attachEvents() {
   const loadButton=document.querySelector("#btnLoadPosts");
   const viewButton=document.querySelector("#btnViewPost");

   loadButton.addEventListener('click', loadPosts);
   viewButton.addEventListener('click', loadSinglePost); 
}

async function loadPosts(){
    const response= await (await fetch("http://localhost:3030/jsonstore/blog/posts"))
    .json();
    const values=Object.values(response);
    posts=response;
    let postsToFill=document.querySelector("#posts");
    
    values.forEach((v)=>{
        const option=document.createElement("option");
        option.value=v.id;
        option.textContent=v.title;
        postsToFill.appendChild(option);
    })
}
async function loadSinglePost(){
    const response= await (await fetch("http://localhost:3030/jsonstore/blog/comments"))
    .json();
   
    const selectedPost=posts[document.querySelector("#posts").value];
    const filtered=Object.values(response).filter((comment)=>comment.postId===selectedPost.id);

    document.querySelector("#post-title").textContent="Post Details";
    document.querySelector('#post-body').textContent='';

    const h1=document.querySelector("#post-title");
    h1.textContent=selectedPost.title;
    
    const p=document.querySelector('#post-body');
    p.textContent=selectedPost.body;

    const ul= document.querySelector("#post-comments");

    ul.innerHTML="";
    filtered.forEach((f)=>{
        let li= document.createElement("li");
        li.id=f.id;
        li.textContent=f.text;
        ul.appendChild(li);
    });


}
attachEvents();