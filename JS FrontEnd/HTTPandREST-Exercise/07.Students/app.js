async function attachEvents() {
  
  const submitBTN=document.querySelector("#submit");
  const tableBody=document.querySelector("tbody");

  const fName=document.querySelector("input[name='firstName']");
  const lName=document.querySelector("input[name='lastName']");
  const fnumber=document.querySelector("input[name='facultyNumber']");
  const sGrade=document.querySelector("input[name='grade']");

  const response=await(await fetch("http://localhost:3030/jsonstore/collections/students"))
    .json();
    console.log(Object.values(response));
    Object.values(response).forEach((student)=>{

      const tableRow=document.createElement('tr');
      const firstNameCell=document.createElement('td');
      const lastNameCell=document.createElement('td');
      const facultyNumberCell=document.createElement('td');
      const gradeCell=document.createElement('td');

      firstNameCell.textContent=student.firstName;
      lastNameCell.textContent=student.lastName;
      facultyNumberCell.textContent=student.facultyNumber;
      gradeCell.textContent=Number(student.grade).toFixed(2);

      tableRow.appendChild(firstNameCell);
      tableRow.appendChild(lastNameCell);
      tableRow.appendChild(facultyNumberCell);
      tableRow.appendChild(gradeCell);

      tableBody.appendChild(tableRow);
    });


  submitBTN.addEventListener("click", async ()=>{
    const firstName=fName.value;
    const lastName=lName.value;
    const facultyNumber=fnumber.value;
    const grade=sGrade.value;

    const postResponse= await fetch("http://localhost:3030/jsonstore/collections/students",{
      method: "POST",
      body: JSON.stringify({firstName, lastName, facultyNumber, grade}),
    });
    console.log(postResponse);

    fName.value='';
    lName.value='';
    fnumber.value='';
    sGrade.value='';
  });
}

attachEvents();