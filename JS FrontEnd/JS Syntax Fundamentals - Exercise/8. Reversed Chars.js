function ReversedChars(ch1, ch2, ch3){
    let result=ch1+ch2+ch3;
    let newResult='';
    for (let i = result.length-1; i >=0; i--) {
        newResult+=result[i]+" ";
    }
    console.log(newResult)
}
ReversedChars('A','B','C');