function CircleArea(input){
    let inputType=typeof(input);
    let area;
if(inputType==='number'){
    area=Math.pow(input, 2)*Math.PI;
    console.log(area.toFixed(2));
}
else{
    console.log(`We can not calculate the circle area, because we receive a ${inputType}.`);
}
}
CircleArea(5);
CircleArea('name')