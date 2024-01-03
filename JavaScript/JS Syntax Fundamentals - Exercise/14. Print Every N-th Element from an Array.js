function PrintNthElement(array, num)
{
     let newArray=ReturnArray(num, array);
    console.log(newArray);
}
function ReturnArray(num, array){
    let newArr=new Array();
 for (let i = 0; i <= array.length; i+=num) {
    newArr.push(array[i]);
 }
 return newArr;
}
PrintNthElement(['5','20','31','4','20'],2)
PrintNthElement(['5','20','31','4','20'],3)