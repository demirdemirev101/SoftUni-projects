function oddAndEvenSum(number){
    let parsedNumber=String(number);
    let evenSum=0;
    let oddSum=0;
    for (let i = 0; i < parsedNumber.length; i++) {
        const element = Number(parsedNumber[i]);
        if(element%2===0){
            evenSum+=element;
        }
        else{
            oddSum+=element;
        }
    }
    return `Odd sum = ${oddSum}, Even sum = ${evenSum}`;
}
const result1=oddAndEvenSum(1000435);
const result2=oddAndEvenSum(3495892137259234);

console.log(result1);
console.log(result2);