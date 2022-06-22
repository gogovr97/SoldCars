namespace SoldCars.Database.Models
{
    using SoldCars.Database.Models.Abstractions;

    using System;
    public class Note : BaseModel
    {
        public Note()
        {
            this.CreatedAt = DateTime.UtcNow;
        }
        public string Car { get; set; }
        public string Description { get; set; }
        public string Prise { get; set; }
        public bool Sold { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
