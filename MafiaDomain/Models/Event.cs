using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaDomain.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        public String Name { get; set; }
        
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public String Country { get; set; }

        public String Description { get; set; }

        [Required]
        public String City { get; set; }

        [Required]
        public String Address { get; set; }

        [Required]
        public EGameType GameType { get; set; }
        
        public bool Beginner { get; set; }

        [Required]
        public string Photo { get; set; }

        public List<EventPhoto> EventPhotos { get; set; }
    }
    public enum EGameType
    {
        Cartel, Tourney, Classic
    }
}