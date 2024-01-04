function solve() {
    const departButton=document.querySelector("#depart");
    const arriveButton=document.querySelector("#arrive");
    const stop=document.querySelector("#info .info");

    let busStopInfo={
        name: '',
        next: 'depot'
    };

    function depart() {
        fetch(`http://localhost:3030/jsonstore/bus/schedule/${busStopInfo.next}`)
        .then((res)=>res.json())
        .then((busStop)=>{
            busStopInfo=busStop;
            stop.textContent=`Next stop ${busStopInfo.name}`;
        })
        .catch(()=>{
            departButton.disabled=true;
            arriveButton.disabled=true;
            stop.textContent=`Error`;
        });

        departButton.disabled=true;
        arriveButton.disabled=false;
    }

    async function arrive() {
        const busStop= await (await fetch(`http://localhost:3030/jsonstore/bus/schedule/depot`))
        .json();
        
        stop.textContent=`Arriving at ${busStopInfo.name}`;
        
        departButton.disabled=false;
        arriveButton.disabled=true;
    }

    return {
        depart,
        arrive
    };
}

let result = solve();