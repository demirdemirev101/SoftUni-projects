﻿
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace P01_HospitalDatabase.Data.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        [MaxLength(50)]
        [Unicode(true)]
        public string FirstName { get; set;}
        [MaxLength(50)]
        [Unicode(true)]
        public string LastName { get; set;}
        [MaxLength(250)]
        [Unicode(true)]
        public string Address { get; set;}
        [MaxLength(80)]
        [Unicode(false)]
        public string Email { get; set;}
        public bool HasInsurance { get; set;}
        public ICollection<Diagnose> Diagnoses { get; set; }
        public ICollection<PatientMedicament> Prescriptions { get; set; }
        public ICollection<Visitation> Visitations { get; set; }
    }
}
