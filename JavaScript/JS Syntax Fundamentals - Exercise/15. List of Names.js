function SortingNames(names){
    names=names.sort();
    for(i=0;i<names.length;i++){
        console.log(`${i+1}.${names[i]}`);
    }
}
SortingNames(["John","Bob","Christina","Ema"]);