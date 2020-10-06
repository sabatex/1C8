using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1C8Extensions.Models
{
    public class EnumOwner
    {
        [Key]
        public string Name { get; set; }
        public string Synonym { get; set; }
        public string Comment { get; set; }

    }
}
