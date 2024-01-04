function checkProducts(input1, input2){
    let objProducts=[];
    for (let i = 0; i < input1.length; i+=2) {
        
        let product=input1[i];
        let quantity=input1[i+1];
        
        let obj={
            product,
            quantity
        };
        objProducts.push(obj);
    }

    for (let j = 0; j < input2.length; j+=2) {
        
        let product=input2[j];
        let quantity=input2[j+1];

        let input2Obj={
            product,
            quantity
        };
       
        if(objProducts.find(p=>p.product===product)){
           
            checker=objProducts.find(p=>p.product===product);
            let toNumberPruducts=Number(checker.quantity);
            let toNumberINput2=Number(input2Obj.quantity);

            toNumberPruducts+=toNumberINput2;
            checker.quantity=toNumberPruducts.toString();
                    
        } else {
             objProducts.push(input2Obj);
        }
        
    }

   objProducts.forEach(obj => {
    console.log(`${obj.product} -> ${obj.quantity}`);
   });
}
checkProducts(
    [
       'Salt', '2', 'Fanta', '4', 'Apple', '14',
        'Water', '4', 'Juice', '5'
        ],
        [
        'Sugar', '44', 'Oil', '12', 'Apple', '7',
        'Tomatoes', '7', 'Bananas', '30'
    ]
        
);