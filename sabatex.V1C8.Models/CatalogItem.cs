using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.Models
{
    public class CatalogItem
    {
        public Guid Id { get; set; }
        public bool IsFolder { get; set; }
        public bool DeletionMark { get; set; }
        public bool Predefined {get; set;}
        public Guid? Parent { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Guid? Owner { get; set; }
        
     }
}
