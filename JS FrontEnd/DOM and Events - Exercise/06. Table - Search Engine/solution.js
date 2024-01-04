function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      const searchQuery=document.querySelector('#searchField').value;
      
      let cells=Array.from(document.querySelectorAll('tbody td'));
      let activeRows=Array.from(document.querySelectorAll('tbody tr.select'));
      
      activeRows.forEach((row)=>{
         row.className='';
      });

      cells.forEach(cell => {    
            if(cell.textContent.includes(searchQuery)){
            cell.parentElement.className='select';
        }
      });


      document.querySelector('#searchField').value='';

   }
}