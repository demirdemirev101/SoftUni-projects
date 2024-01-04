function cityDescription(city){
for (const key in city) {
    console.log(`${key} -> ${city[key]}`);
}
/*let entries=Object.entries(city);
for (const iterator of entries) {
    console.log(iterator[0]+' -> '+iterator[1]);
}
*/
}
cityDescription({
    name: "Sofia",
    area: 492,
    population: 1238438,
    country: "Bulgaria",
    postCode: "1000"
})