function perfectNumberORNot(number){
    let n = number;
    let sum = 0;
    for (let i = 0; i < n; i++) {
        if (n % i == 0) {
            sum = sum + i;
        }
    }
    if (sum == n){
        console.log("We have a perfect number!");
    }
    else{
        console.log("It's not so perfect.");
    }
}
perfectNumberORNot(6);
perfectNumberORNot(1236498);
perfectNumberORNot(28);