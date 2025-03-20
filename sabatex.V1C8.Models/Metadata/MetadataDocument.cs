using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8.Models.Metadata
{
    public class MetadataDocument:MetadataDescription
    {
        public MetadataAttribute[] Attributes { get; set; }
        public MetadataTabularSection[] TabularSections { get; set; }
    }
}
