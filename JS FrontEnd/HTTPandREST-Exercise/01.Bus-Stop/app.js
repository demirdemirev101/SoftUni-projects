async function getInfo() {
    try {
        const busStops= await (await fetch(` http://localhost:3030/jsonstore/bus/businfo/${busStopName}`)).json();
        
        const busStopName= document.querySelector("#stopId").value;
        document.querySelector("#stopName").textContent=busStops.name;
    
        const buses= Array.from(Object.entries(busStops.buses));
    
        let items=document.querySelector("#buses");
        items.innerHTML='';
        buses.forEach(bus => {
            const item=document.createElement("li");
            const [busId,time]=bus;

            item.textContent=`Bus ${busId} arrives in ${time} minutes`.trim();
            items.appendChild(item);
        });
    } catch (error) {
        document.querySelector("#stopName").textContent='Error';
    }
    
}