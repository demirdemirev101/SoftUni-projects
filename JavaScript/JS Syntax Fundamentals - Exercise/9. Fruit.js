function MoneyToBuyCertainAmountFruit(type, weightInGrams, pricePerKG){
    let weightInKG=weightInGrams/1000;
    let money=weightInKG*pricePerKG;

    console.log(`I need $${money.toFixed(2)} to buy ${weightInKG.toFixed(2)} kilograms ${type}.`)
}
MoneyToBuyCertainAmountFruit('apple', 1563, 2.35);