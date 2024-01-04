function toggle() {
  /*  let extra= document.getElementById("extra");
    if(extra.style.display!=='block'){

        document.querySelector("span.button").textContent ='Less';
        extra.style.display='block';

    } else { 

        document.querySelector("span.button").textContent ='More';
        extra.style.display='none';
    }
    */
    let extra= document.getElementById("extra");
    if(document.querySelector("span.button").textContent ==='More'){

        document.querySelector("span.button").textContent ='Less';
        extra.style.display='block';

    } else { 

        document.querySelector("span.button").textContent ='More';
        extra.style.display='none';
    }
}