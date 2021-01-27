using System;
using System.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.Models
{
    public class EnumItem
    {
        [Key]
        public string Name { get; set; }
        public string Synonym { get; set; }
        public string Comment { get; set; }

    }

}