function PalindromeNumbers(array){
    let parsedArray=String(array);
    parsedArray=parsedArray.split(',');
    
    let resultArray=[];

    for(i=0;i<parsedArray.length;i++) {
        const element=parsedArray[i];
        if(reverseString(element)===element){
            resultArray.push('true');
        }
        else{
            resultArray.push('false');
        }
    }

    return resultArray;
}
function reverseString(str) {
    return str.split("").reverse().join("");
}
const result=PalindromeNumbers([32,2,232,1010]);
for (let i = 0; i < result.length; i++) {
    const element = result[i];
    console.log(element);
}
