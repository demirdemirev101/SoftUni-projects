function makeDictionary(input){
    arrayDictionary=[];
    for (let i = 0; i < input.length; i++) {
        let element = JSON.parse(input[i]);
        
        let term=Object.keys(element).toString();
        let definition=element[term];
        
        let dictionary={
            Term: term,
            Definition: definition
        }
        arrayDictionary.push(dictionary);
    }

    let sorted=arrayDictionary.sort((a,b)=>a.Term.localeCompare(b.Term));
    sorted.forEach(element => {
        console.log(`Term: ${element.Term} => Definition: ${element.Definition}`);
    });
}
makeDictionary(
    [
    '{"Cup":"A small bowl-shaped container for drinking from, typically having a handle"}',
    '{"Cake":"An item of soft sweet food made from a mixture of flour, fat, eggs, sugar, and other ingredients, baked and sometimes iced or decorated."}',
    '{"Watermelon":"The large fruit of a plant of the gourd family, with smooth green skin, red pulp, and watery juice."} ',
    '{"Music":"Vocal or instrumental sounds (or both) combined in such a way as to produce beauty of form, harmony, and expression of emotion."} ',
    '{"Art":"The expression or application of human creative skill and imagination, typically in a visual form such as painting or sculpture, producing works to be appreciated primarily for their beauty or emotional power."} '
    ]    
    )