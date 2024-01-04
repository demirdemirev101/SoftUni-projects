function personalNumberByNameLength(names){
    const objectNames=names.reduce((acc, curr) => {
        
        const nameLength=curr.length;
        acc[curr]=nameLength;

        return acc;
    },{});

    Object.entries(objectNames)
    .forEach(([name, nameLength])=>
    console.log(`Name: ${name} -- Personal Number: ${nameLength}`));
}
personalNumberByNameLength([
    'Silas Butler',
    'Adnaan Buckley',
    'Juan Peterson',
    'Brendan Villarreal'
    ]
    );