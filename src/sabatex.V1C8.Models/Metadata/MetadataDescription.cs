using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8.Models.Metadata
{
    public abstract class MetadataDescription
    {
        public string Name { get; set; }
        public string Synonym { get; set; }
        public string Comment { get; set; }
    }
}
