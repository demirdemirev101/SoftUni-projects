using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_SalesDatabase.Data.Models
{
    public class Store
    {
        [Key]
        public int StoreId { get; set; }
        [MaxLength(80)]
        [Unicode(true)]
        public string Name { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
