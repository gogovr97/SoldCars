namespace SoldCars.Database.Models
{
    using Abstractions;

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User : BaseModel
    {
        public User()
        {
            this.CreatedAt = DateTime.UtcNow;
            this.Notes = new HashSet<Note>();
        }

        [Required]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public string Salt { get; set; }

        public DateTime CreatedAt { get; set; }
        public ICollection<Note> Notes { get; set; }
    }
}
