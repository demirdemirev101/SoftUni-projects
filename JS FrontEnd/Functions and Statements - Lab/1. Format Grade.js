function FormatGrade(grade){
    if(grade<3.00){
        console.log(`Fail (2)`)
    }
    else if(grade<3.50){
        console.log(`Poor (${grade.toFixed(2)})`);
    }
    else if(grade<4.50){
        console.log(`Good (${grade.toFixed(2)})`);
    }
    else if(grade<5.50){
        console.log(`Very Good (${grade.toFixed(2)})`);
    }
    else if(grade<=6.00){
        console.log(`Excellent (${grade.toFixed(2)})`);
    }
}
FormatGrade(3.33)
FormatGrade(4.40)
FormatGrade(5.40)