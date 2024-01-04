function passwordValidator(password){
    const regexForDigits=new RegExp(/[0-9]{2,}/);
    const regexForDigitsAndLetters=new RegExp(/^[A-Za-z0-9_-]*$/); 

    if(password.length<6||password.length>10){
        console.log("Password must be between 6 and 10 characters");
    }
    if(regexForDigitsAndLetters.test(password)===false){
        console.log("Password must consist only of letters and digits");
    }
    if(regexForDigits.test(password)===false){
        console.log("Password must have at least 2 digits");
    }
    if(password.length>=6&&password.length<=10
    && regexForDigits.test(password)===true
    && regexForDigitsAndLetters.test(password)===true){
        console.log("Password is valid");
    }
}
passwordValidator('logIn');
passwordValidator('MyPass123');
passwordValidator('Pa$s$s');