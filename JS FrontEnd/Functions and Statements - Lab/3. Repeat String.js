function PrintAndRepeat(str, num){
    let count=0;
    let arr=[];
    while(count<num){
        arr.push(str);
        count++;
    }
    return arr;
}

let result=PrintAndRepeat('sbc', 3);
console.log(result);