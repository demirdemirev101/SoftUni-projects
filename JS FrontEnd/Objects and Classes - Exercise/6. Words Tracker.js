function printOccurences(input){
    words=input.shift().split(' ');
    let array=[];
    let count=0;
    for (let index = 0; index < words.length; index++) {
        let obj={
            word: words[index],
            occurences: count,
        };
        array.push(obj);
    }

    for (let i = 0; i < array.length; i++) 
    {
        for (let j = 0; j < input.length; j++) {
            if(input[j]===array[i].word){
               array[i].occurences+=1;
            }
            
        }
    }
    
    arraySorted=array.sort((a,b)=>b.occurences-a.occurences);
    for (let k = 0; k < arraySorted.length; k++) {
        const element = arraySorted[k];
        console.log(`${element.word} - ${element.occurences}`);
    }
}

printOccurences([
    'this sentence',
    'In', 'this', 'sentence', 'you', 'have',
    'to', 'count', 'the', 'occurrences', 'of',
    'the', 'words', 'this', 'and', 'sentence',
    'because', 'this', 'is', 'your', 'task'
    ]
);
printOccurences([
    'is the',
    'first', 'sentence', 'Here', 'is',
    'another', 'the', 'And', 'finally', 'the',
    'the', 'sentence'
    ]
);