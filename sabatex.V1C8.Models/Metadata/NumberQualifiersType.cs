using System;
using System.Collections.Generic;
using System.Text;

namespace Sabatex.V1C8.Models.Metadata;

public class NumberQualifiersType
{
    public NumberQualifiersType(int digits,int fractionDigits)
    {
        Digits = digits;
        FractionDigits = fractionDigits;
    }
    public int Digits { get; set; }
    public int FractionDigits { get; set; }

}
