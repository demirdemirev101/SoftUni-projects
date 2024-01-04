function printPhoneNameAndNumbers(arrayPhoneBook){
    
    const objectPhoneBook= arrayPhoneBook.reduce((acc,curr)=>{
        const [name, phone] = curr.split(' ');
        acc[name]=phone;

        return acc;
    },{})
    
    Object.entries(objectPhoneBook).forEach(([key,value]) => {
        console.log(`${key} -> ${value}`);
    });
}
printPhoneNameAndNumbers(['Tim 0834212554','Peter 0877547887','Bill 0896543112','Tim 0876566344']);
console.log('\n');
printPhoneNameAndNumbers(['George 0552554','Peter 087587','George 0453112','Bill 0845344']);