using System;
using System.Collections.Generic;
using System.Text;

namespace Sabatex.V1C8.Models.Metadata;

public class MetadataEnum:MetadataObject
{
    public IEnumerable<MetadataEnumItem> Items { get; set; }
}
