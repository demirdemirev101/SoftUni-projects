function printSuccessfulMeetings(arrMeetings){
    const result=arrMeetings.reduce((acc, curr)=>{
        const [weekday, name]=curr.split(' ');
      
        //let keyExist = Object.keys(acc).some(key => key === weekday);
        if(!acc.hasOwnProperty(weekday)){
            acc[weekday]=name;
            console.log(`Scheduled for ${weekday}`);
        }
        else{
            console.log(`Conflict ${weekday}`);
        }
        
        return acc;
    },{})

    Object.entries(result).forEach(([key, value])=>{

        console.log(`${key} -> ${value}`);
    })
}
printSuccessfulMeetings(
[
'Friday Bob',
'Saturday Ted',
'Monday Bill',
'Monday John',
'Wednesday George'
]);