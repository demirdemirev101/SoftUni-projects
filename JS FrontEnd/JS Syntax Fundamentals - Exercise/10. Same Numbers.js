function SameNumbersOrNotAndTheirSum(num){
    let tostr=String(num);
    let counter=0;
    for (let i = 0; i < tostr.length-1; i++) {
        if(tostr[i]===tostr[i+1]){
            counter++;
            continue;
        }
        else{
            console.log('false');
            break;
        }
    }
    if(counter===tostr.length-1){
        console.log('true');
    }
    let sum=0;
    for (let j = 0; j < tostr.length; j++){
        sum+=Number(tostr[j]);
    }
    console.log(sum);
}
SameNumbersOrNotAndTheirSum(2222222);
SameNumbersOrNotAndTheirSum(1234);