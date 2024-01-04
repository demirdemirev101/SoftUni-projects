function convertingToObject(data){
    let person=JSON.parse(data);
    let keys=Object.keys(person);
    for (const key in person) {
        console.log(`${key}: ${person[key]}`);
    }
}
convertingToObject('{"name": "George", "age": 40, "town": "Sofia"}');