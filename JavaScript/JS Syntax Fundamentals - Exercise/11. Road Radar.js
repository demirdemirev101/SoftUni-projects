function SpeedLimit(speed, area){
    let limit=0;
    let status;
    let difference=0;
    if(area==='city'){
        limit=50;
        if(speed>=0 && speed<=limit){
            console.log(`Driving ${speed} km/h in a ${limit} zone`
            )
        }
        else if(speed<=limit+20){
            status='speeding';
            difference=speed-limit;
            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${limit} - ${status}`);
        }
        else if(speed<=limit+40){
            status="excessive speeding";
            difference=speed-limit;
            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${limit} - ${status}`);
        }
        else{
            status='reckless driving';
            difference=speed-limit;
            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${limit} - ${status}`);
        }
    }
    else if(area==='residential'){
        limit=20;
        if(speed>=0 && speed<=limit){
            console.log(`Driving ${speed} km/h in a ${limit} zone`
            )
        }
        else if(speed<=limit+20){
            status='speeding';
            difference=speed-limit;
            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${limit} - ${status}`);
        }
        else if(speed<=limit+40){
            status="excessive speeding";
            difference=speed-limit;
            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${limit} - ${status}`);
        }
        else{
            status='reckless driving';
            difference=speed-limit;
            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${limit} - ${status}`);
        }
    }
    else if(area==='interstate'){
        limit=90;
        if(speed>=0 && speed<=limit){
            console.log(`Driving ${speed} km/h in a ${limit} zone`
            )
        }
        else if(speed<=limit+20){
            status='speeding';
            difference=speed-limit;
            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${limit} - ${status}`);
        }
        else if(speed<=limit+40){
            status="excessive speeding";
            difference=speed-limit;
            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${limit} - ${status}`);
        }
        else{
            status='reckless driving';
            difference=speed-limit;
            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${limit} - ${status}`);
        }
    }
    else if(area==='motorway'){
        limit=130;
        if(speed>=0 && speed<=limit){
            console.log(`Driving ${speed} km/h in a ${limit} zone`
            )
        }
        else if(speed<=limit+20){
            status='speeding';
            difference=speed-limit;
            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${limit} - ${status}`);
        }
        else if(speed<=limit+40){
            status="excessive speeding";
            difference=speed-limit;
            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${limit} - ${status}`);
        }
        else{
            status='reckless driving';
            difference=speed-limit;
            console.log(`The speed is ${difference} km/h faster than the allowed speed of ${limit} - ${status}`);
        }
    }
}
SpeedLimit(40, 'city');
SpeedLimit(21, 'residential');
SpeedLimit(120, 'interstate');
SpeedLimit(180, 'motorway');