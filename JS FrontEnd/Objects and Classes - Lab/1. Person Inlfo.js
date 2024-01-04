function turnToObject(firstName, lastName, age){
    return {
        firstName: firstName,
        lastName: lastName,
        age: age,
    };
}

const object=turnToObject('Peter', 'Pan', '20');
for (const key in object) {
    console.log(`${key}: ${object[key]}`);
}
