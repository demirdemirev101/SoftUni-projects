function parkingLot(input){
   
    let parkingArr=[];
    for (let i = 0; i < input.length; i++) {
        let [direction, number]=input[i].split(', ');
        if(direction==='IN'){
            
            parkingArr.push(number);
        }
        else if(direction==='OUT'){
            if (parkingArr.includes(number)) {
                let index = parkingArr.indexOf(number);
                parkingArr.splice(index, 1);
         }}
    }
    
    if(parkingArr.length!=0){

        parkingArr = parkingArr.sort((a, b) => a.localeCompare(b));

        parkingArr.forEach(element => {
            console.log(element)
        });
    }
    else{
        console.log(`Parking Lot is Empty`);
    }
}
parkingLot(
    ['IN, CA2844AA',
'IN, CA1234TA',
'OUT, CA2844AA',
'IN, CA9999TT',
'IN, CA2866HI',
'OUT, CA1234TA',
'IN, CA2844AA',
'OUT, CA2866HI',
'IN, CA9876HH',
'IN, CA2822UU']
);
console.log('\n');
parkingLot([
    'IN, CA2844AA',
    'IN, CA1234TA',
    'OUT, CA2844AA',
    'OUT, CA1234TA']);