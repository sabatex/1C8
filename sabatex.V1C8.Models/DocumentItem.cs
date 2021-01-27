using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.Models
{
    public class DocumentItem
    {
        public Guid Id { get; set; }
        public bool DeletionMark { get; set; }
        public bool Posted { get; set; }     
        public string Number { get; set; }
        
     }
}
