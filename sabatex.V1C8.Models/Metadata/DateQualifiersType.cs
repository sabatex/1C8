using System;
using System.Collections.Generic;
using System.Text;

namespace Sabatex.V1C8.Models.Metadata;

public class DateQualifiersType
{
    public string DateFractions { get; set; }
    public DateQualifiersType(string dateFractions)
    {
        DateFractions = dateFractions;
    }
}
