function CharsInRange(char1, char2){
    let toNumChar1=char1.charCodeAt(0);
    let toNumChar2=char2.charCodeAt(0);

    let array=[];
    if(toNumChar1<toNumChar2){

        for (let i = toNumChar1+1; i < toNumChar2; i++) {
            array.push(String.fromCharCode(i));
        }
        return array.join(' ');
    }
    else if(toNumChar1>toNumChar2){
        for (let i = toNumChar2+1; i < toNumChar1; i++) {
            array.push(String.fromCharCode(i));
        }
        return array.join(' ');
    }
}
const result=CharsInRange('C','#');
console.log(result);