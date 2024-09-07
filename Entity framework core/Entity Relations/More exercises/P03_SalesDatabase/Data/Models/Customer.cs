using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_SalesDatabase.Data.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [MaxLength(100)]
        [Unicode(true)]
        public string Name { get; set; }
        [MaxLength(80)]
        [Unicode(true)]
        public string Email { get; set; }
        public string CreditCardNumber { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
