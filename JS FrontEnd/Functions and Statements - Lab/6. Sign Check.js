function CheckSign(numOne, numTwo, numThree){
    if(    numOne<0 && numTwo<0 && numThree>0
        || numTwo<0 && numThree<0 && numOne>0
        || numOne<0 && numThree<0 && numTwo>0){
            return "Positive";
    }
    else if(numOne>0 && numTwo>0 && numThree>0){
        return 'Positive';
    }
    else if(numOne>0 && numTwo>0 && numThree<0
        || numTwo>0 && numThree>0 && numOne<0
        || numOne>0 && numThree>0 && numTwo<0){
            return 'Negative';
    }
    else if(numOne<0 && numTwo<0 && numThree<0){
        return 'Negative';
    }
}
const result=CheckSign(5,12,15);
console.log(result)