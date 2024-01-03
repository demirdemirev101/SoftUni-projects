function CensoredWords(text, word){
    
    const censoredWord='*'.repeat(word.length);
    while(text.includes(word)){
        text=text.replace(word, censoredWord);
    }
    console.log(text);
}
CensoredWords('A small sentence with some words small', 'small');