function SumOfNumbersDigits(number){
    let toString=String(number);
    let sum=0;
    for (let i = 0; i < toString.length; i++) {
        let ch=toString[i];
        sum+=Number(ch);
    }
    console.log(sum);
}
SumOfNumbersDigits(97561);