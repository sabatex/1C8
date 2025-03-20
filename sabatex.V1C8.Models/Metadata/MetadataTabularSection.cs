using System;
using System.Collections.Generic;
using System.Text;

namespace Sabatex.V1C8.Models.Metadata;

public class MetadataTabularSection:MetadataDescription
{
    public MetadataAttribute[] Attributes { get; set; }
}
