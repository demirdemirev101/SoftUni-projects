function SquareMatrix(matrix){
    let result='';
    for (let i = 0; i < matrix; i++) {
       
        for (let j = 0; j< matrix; j++){
            result+=matrix+' ';
        }
        console.log(result);
        result='';
    }
}
SquareMatrix(7);