function objectToJSON(firstName, lastName, hairColor){
    let object={
        firstName,
        lastName,
        hairColor,
    };
    let toString=JSON.stringify(object);
    console.log(toString);
}
objectToJSON('George', 'Jones','Brown');
objectToJSON('Peter', 'Smith','Blond');