function adressBook(array){
    const adressBook=array.reduce((acc, curr)=>{
        const [name, address]= curr.split(':');
        acc[name]=address;

        return acc;
    },{});

    Object.keys(adressBook).sort().forEach((key)=>{
        console.log(`${key} -> ${adressBook[key]}`);
    })
}
adressBook(['Tim:Doe Crossing',
'Bill:Nelson Place',
'Peter:Carlyle Ave',
'Bill:Ornery Rd']);

console.log('\n');

adressBook(['Bob:Huxley Rd',
'John:Milwaukee Crossing',
'Peter:Fordem Ave',
'Bob:Redwing Ave',
'George:Mesta Crossing',
'Ted:Gateway Way',
'Bill:Gateway Way',
'John:Grover Rd',
'Peter:Huxley Rd',
'Jeff:Gateway Way',
'Jeff:Huxley Rd']);