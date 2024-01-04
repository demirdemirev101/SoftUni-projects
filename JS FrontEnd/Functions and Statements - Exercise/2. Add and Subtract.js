function finalResult(num1,num2,num3){
    let addResult=sum(num1,num2)
    let subtractResult=subtract(addResult, num3);

    return subtractResult;
}
function sum(numOne,numTwo){
    return numOne+numTwo;
}
function subtract(result, numThree){
    return result-numThree;
}

const result=finalResult(42,58,100);
console.log(result);