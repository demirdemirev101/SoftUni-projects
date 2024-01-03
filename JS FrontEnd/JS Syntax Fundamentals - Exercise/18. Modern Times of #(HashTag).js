function PrintSpecialWords(words){
    words=words.split(' ');
    let newArr=[];
    for(i=0;i<words.length;i++){
        if(words[i].startsWith('#') && words[i].length>1){
            newArr.push(words[i].substring(1,words[i].length));
        }
    }
    console.log(newArr.join('\n'));
}
PrintSpecialWords('Nowadays everyone uses # to tag a #special word in #socialMedia');
PrintSpecialWords('The symbol # is known #variously in English-speaking #regions as the #number sign');