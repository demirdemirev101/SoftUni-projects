function ArrayRotation(array, number){
    let swap=0;
    let count=1;
    while (count<=number) {
        swap=array.shift();
        array.push(swap);
        count++;
    }

    console.log(array);
}
ArrayRotation([51, 47, 32, 61, 21], 2 )