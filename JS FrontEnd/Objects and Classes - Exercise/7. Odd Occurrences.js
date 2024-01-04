function printOddOccurrences(input){
    let words=input.toLowerCase().split(' ');
    let count=1;
    let array=[];
    let word;
    while(words.length!=0){
        count=0;
        let wordToFilter=words.shift();
        for (let i = 0; i < words.length; i++) {
            const element = words[i];
            if(element===wordToFilter){
                let index= array.indexOf(element);
                words.splice(i, 1);
                count+=1;
            }
        }
        if(count%2===0){
            array.push(wordToFilter);
        }
    }
  console.log(array.join(' '));
}
printOddOccurrences('Java C# Php PHP Java PhP 3 C# 3 1 5 C#');
printOddOccurrences('Cake IS SWEET is Soft CAKE sweet Food');