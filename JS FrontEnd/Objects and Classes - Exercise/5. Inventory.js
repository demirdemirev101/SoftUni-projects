function heroesRegister(arrayInput){
    let objArray=arrayInput.reduce((acc, curr)=>{
        const[name,level, items]=curr.split(' / ');

        let obj={
            'Hero': name,
            'level': Number(level),
            'items': items,  
        }
        acc.push(obj);
        return acc;
    },[]);

    let sorted=objArray.sort((a,b)=> a.level-b.level);
for (let i = 0; i < sorted.length; i++) {
    console.log(`Hero: ${sorted[i].Hero}`+'\n'+`level => ${sorted[i].level}`+'\n'+`items => ${sorted[i].items}`)
}
}
heroesRegister(
    [
    'Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara'
    ]
);