function VacantionPrices(groupCount, groupType, dayOfWeek){
    let price;
    let totalPrice;
    let priceWithDiscount;
    if(dayOfWeek==='Friday'){
        if(groupType==='Students'){
            price=8.45;
        }
        else if(groupType==='Business'){
            price=10.90;
        }
        else if(groupType==='Regular'){
            price=15;
        }
    }
    else if(dayOfWeek==='Saturday'){
        if(groupType==='Students'){
            price=9.80;
        }
        else if(groupType==='Business'){
            price=15.60;
        }
        else if(groupType==='Regular'){
            price=20;
        }
    }
    else if(dayOfWeek==='Sunday'){
        if(groupType==='Students'){
            price=10.46;
        }
        else if(groupType==='Business'){
            price=16;
        }
        else if(groupType==='Regular'){
            price=22.50;
        }
    }
    
    if(groupType==='Students' && groupCount>=30){
        totalPrice=price*groupCount;
        priceWithDiscount=totalPrice-(totalPrice*15/100.0);
        totalPrice=priceWithDiscount;
    }
    else if(groupType==='Business' && groupCount>=100){
        totalPrice=price*(groupCount-10);
    }
    else if(groupType==='Regular' && groupCount>=10 && groupCount<=20){
        totalPrice=price*groupCount;
        priceWithDiscount=totalPrice-(totalPrice*5/100.0);
        totalPrice=priceWithDiscount;
    }
    else {
        totalPrice=price*groupCount;
    }
    console.log(`Total price: ${totalPrice}`);
}
VacantionPrices(30, "Students", "Sunday");
VacantionPrices(40, "Regular", "Saturday");