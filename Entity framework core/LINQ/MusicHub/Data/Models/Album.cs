﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data.Models
{
    public class Album
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Name { get; set; } = null!;
        [Required]
        public DateTime ReleaseDate { get; set; }
        public decimal Price => Songs.Sum(s => s.Price);
        [Required]
        public int? ProducerId { get; set; }
        [ForeignKey(nameof(ProducerId))]
        public Producer Producer { get; set; }
        public ICollection<Song> Songs { get; set; }
    }
}
