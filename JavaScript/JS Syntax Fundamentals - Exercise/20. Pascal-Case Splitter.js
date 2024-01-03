function SplitPascalCaseWords(words){
    let splitted=words.split(/(?=[A-Z])/);
    console.log(splitted.join(', '));
}
SplitPascalCaseWords('SplitMeIfYouCanHaHaYouCantOrYouCan')