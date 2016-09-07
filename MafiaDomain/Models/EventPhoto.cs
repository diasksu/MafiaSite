using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaDomain.Models
{
    public class EventPhoto
    {
        [Key]
        public int EventPhotoId { get; set; }

        public Event ParentEvent { get; set; }

        public String Path { get; set; }

        public String Caption { get; set; }
    }
}