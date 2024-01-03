function MakingReverseArray(input1, input2){

    /*
    let copy=[];
    for(let i=0;i<input1;i++){
        copy[i]=input2[i];
    }
    copy=copy.reverse();
    console.log(copy);
    */
    let copy=[];
    for(let i=0;i<input1;i++){
        copy.push(input2[i]);
    }

    let newcopy=[];
    for(let i=copy.length-1;i>=0;i--){
        newcopy.push(copy[i]+output);
    }
    copy=newcopy;
    console.log(copy.join(" "));
}
MakingReverseArray(3, [10, 20, 30, 40, 50])