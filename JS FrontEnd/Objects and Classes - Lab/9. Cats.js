class Cat{
    constructor(name, age){
        this.name=name;
        this.age=age;
    }
    meow(){
        console.log(`${this.name}, age ${this.age} says Meow`);
    }
}
function catMeowing(array){
    let cats=[];
    for (let i = 0; i < array.length; i++) {
        
        const [name, age] = array[i].split(' ');

        cats.push(new Cat(name,age));
    }

    for (let j = 0; j < cats.length; j++) {
       
        cats[j].meow();
    }
}
catMeowing(['Mellow 2', 'Tom 5']);
console.log('\n');
catMeowing(['Candy 1', 'Poppy 3', 'Nyx 2'])