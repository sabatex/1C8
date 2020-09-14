using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.Models
{
    public class Catalog
    {
        public Guid Id { get; set; }
        public bool IsFolder { get; set; }
        public bool DeletionMark { get; set; }
        public Guid Parent { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Guid? Owner { get; set; }
        
        public virtual void SetFrom1C(Connection connection, dynamic element)
        {
            Id = connection.GetObjectId(element);
            Code = element.Code;
            DeletionMark = element.DeletionMark;
            Description = element.Description;
            IsFolder = element.IsFolder;
            Parent = connection.GetObjectId(element.Parent);
            Owner = connection.GetObjectId(element.Owner);

        }
    }
}
