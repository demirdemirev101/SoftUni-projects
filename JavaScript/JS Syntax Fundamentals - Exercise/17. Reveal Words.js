function RevealWords(words, sentence){
    words=words.split(', ');
    sentence=sentence.split(' ');

    for (let j = 0; j < words.length; j++){

        for (let i = 0; i < sentence.length; i++) {
            if(sentence[i].includes('*') && sentence[i].length===words[j].length){
                sentence[i]=sentence[i].replace(sentence[i],words[j]);
            }
        }
    }
    console.log(sentence);
}
RevealWords('great',
 'softuni is ***** place for learning new programming languages');
 RevealWords('great, learning',
 'softuni is ***** place for ******** new programming languages');