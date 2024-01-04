function SmallestOutOfThreeNumbers(num1, num2, num3){
    let array=[];

    array.push(num1);
    array.push(num2);
    array.push(num3);
    
   /* let min=Number.MAX_SAFE_INTEGER + 1;
   for(i=0;i<array.length;i++){
    if(array[i]<min){
        min=array[i];
    }
   }
   */
  
   let min=Math.min(...array); 
   return min;
}

const smallestNumber=SmallestOutOfThreeNumbers(2,3,5);
console.log(smallestNumber);