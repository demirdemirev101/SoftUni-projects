function printMovies(input){
    
    let result=input.reduce((acc, curr)=>{
        if(curr.includes('addMovie')){
            let splitted=curr.split('addMovie ');
            obj={
                name: splitted[1]
            }
            acc.push(obj);
        }
        else if(curr.includes('directedBy')){
            let splitted=curr.split(' directedBy ');
            if(acc.find(c=>c.name===splitted[0])){
                let finded=acc.find(c=>c.name===splitted[0]);
                finded.director=splitted[1];
            }
        }
        else if(curr.includes('onDate')){
            let splitted=curr.split(' onDate ');
            if(acc.find(c=>c.name===splitted[0])){
                let finded=acc.find(c=>c.name===splitted[0]);
                finded.date=splitted[1];
            }
        }
        return acc;
    },[]);

    for (let i = 0; i < result.length; i++) {
        const element = result[i];
        let count=Object.keys(element).length;
        if(count===3){
            let toJSON=JSON.stringify(element);
            console.log(toJSON);
        }
    }
}
printMovies([
    'addMovie Fast and Furious',
    'addMovie Godfather',
    'Inception directedBy Christopher Nolan',
    'Godfather directedBy Francis Ford Coppola',
    'Godfather onDate 29.07.2018',
    'Fast and Furious onDate 30.07.2018',
    'Batman onDate 01.08.2018',
    'Fast and Furious directedBy Rob Cohen'
    ]);

    console.log('\n');
printMovies(
    ['addMovie The Avengers',
'addMovie Superman',
'The Avengers directedBy Anthony Russo',
'The Avengers onDate 30.07.2010',
'Captain America onDate 30.07.2010',
'Captain America directedBy Joe Russo']
)