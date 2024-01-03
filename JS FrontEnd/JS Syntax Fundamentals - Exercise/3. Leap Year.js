function LeapYearOrNot(year){
    if(year%400===0 || year%4===0){
        console.log('yes');
    }
    else{
        console.log('no');
    }

}
LeapYearOrNot(1984);
LeapYearOrNot(2003);
LeapYearOrNot(4);