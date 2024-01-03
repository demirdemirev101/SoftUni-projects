function StringOccurrences(text, word){
    let counter=0;
    text=text.split(' ');
  for(let i=0; i<=text.length;i++) {
    let sentence=text[i];
    if(word==sentence){
        counter++;
    }
   }
    console.log(counter);
}
StringOccurrences('This is a word and it also is a sentence', 'is');