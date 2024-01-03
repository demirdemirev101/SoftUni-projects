function FindWord(word, text){
    word=word.toLowerCase();
    let newText=text.toLowerCase().split(' ');
    if(newText.includes(word)){
        console.log(word)
    }
    else{
        console.log(`${word} not found!`)
    }
}
FindWord('javascript',
'JavaScript is the best programming language')
FindWord('python',
'JavaScript is the best programming language')