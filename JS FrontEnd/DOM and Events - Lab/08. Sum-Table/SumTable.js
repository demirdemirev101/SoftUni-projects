function sumTable() {
    let prices= Array.from(document.querySelectorAll('tr td:nth-child(2)'));
    let sum=0;
    for (let i = 0; i < prices.length-1; i++) {
        const element = Number(prices[i].textContent);
        sum+=element;
    }
    document.getElementById('sum').textContent=sum.toString();
}