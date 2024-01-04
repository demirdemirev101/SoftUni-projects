function collectTownnLatitudeAndLongitude(array){
    const arrayObj=array.reduce((acc, curr)=>{
        let [town, latitude, longitude]=curr.split(' | ');
        
        toNumberLatitude=Number(latitude);
        toNumberLongitude=Number(longitude);
        
        latitude=toNumberLatitude.toFixed(2).toString();
        longitude=toNumberLongitude.toFixed(2).toString();
        
        let obj={
            town,
            latitude,
            longitude
        };
        
        acc.push(obj);

        return acc;
    },[]);

    for (let i = 0; i < arrayObj.length; i++) {
        const element = arrayObj[i];
        
        console.log(element);
    }
}
collectTownnLatitudeAndLongitude(
['Sofia | 42.696552 | 23.32601',
'Beijing | 39.913818 | 116.363625']);