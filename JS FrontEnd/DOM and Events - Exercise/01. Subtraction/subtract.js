function subtract() {
    const firstNumber=Number(document.getElementById('firstNumber').value);
    const secondNumber=Number(document.getElementById('secondNumber').value);

    let subtraction=firstNumber-secondNumber;

    document.getElementById('result').textContent=subtraction;
}