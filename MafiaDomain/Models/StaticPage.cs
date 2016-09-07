using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaDomain.Models
{
    public class StaticPage
    {
        [Key]
        public String Name { get; set; }

        public String Header { get; set; }

        public String Content { get; set; }
    }
}