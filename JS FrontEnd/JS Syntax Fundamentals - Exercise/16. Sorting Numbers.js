function SortingArrayNumbers(array){
    let sortedArray=array.sort((a, b) => a - b);
    let resultArray=[];
    let length=array.length;
    for (let i = 0; i < length; i++) {
        if(i%2===0){
            resultArray.push(sortedArray.shift());
        }
        else{
            resultArray.push(sortedArray.pop());
        }
    }
    console.log(resultArray);
}
SortingArrayNumbers([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]);