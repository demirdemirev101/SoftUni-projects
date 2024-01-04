function colorize() {
  let array=Array.from(document.querySelectorAll("tr:nth-child(even)"));
  array.forEach((row)=>{
        row.style.background="teal";
  });

}