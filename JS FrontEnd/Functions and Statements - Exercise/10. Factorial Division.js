function FactorialNumber(num){
    let fact=1;
    for(i=1;i<=num;i++){      
        fact=fact*i;    
    }
    return fact;
}
function Division(num1, num2){
    let fac1=FactorialNumber(num1);
    let fac2=FactorialNumber(num2);

    let result=fac1/fac2;
    console.log(result.toFixed(2));
}
Division(6,2);