using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace P01_HospitalDatabase.Data.Models
{
    public class Medicament
    {
        [Key]
        public int MedicamentId { get; set; }
        [MaxLength(50)]
        [Unicode(true)]
        public string Name { get; set; }

        public ICollection<PatientMedicament> Prescriptions { get; set; }
    }
}
