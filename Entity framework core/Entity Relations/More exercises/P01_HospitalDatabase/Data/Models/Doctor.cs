using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_HospitalDatabase.Data.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        [MaxLength(100)]
        [Unicode(true)]
        public string Name { get; set; }
        [MaxLength(100)]
        [Unicode(true)]
        public string Specialty { get; set; }
        public ICollection<Visitation> Visitations { get; set; }
    }
}
