using System;
using System.Collections.Generic;
using System.Text;

namespace Sabatex.V1C8.Models.Metadata;

public class ObjectType
{
    public NumberQualifiersType NumberQualifiers { get; set; }
    public StringQualifiersType StringQualifiers { get; set; }
    public DateQualifiersType DateQualifiers { get; set; }
    public List<string> Types { get; set; } = new List<string>();

    public void AddNumber(int digits, int fractionDigits)
    {
        Types.Add("Decimal");
        NumberQualifiers = new NumberQualifiersType(digits, fractionDigits);
    }

    public void AddString(int length, string allowedLength)
    {
        Types.Add("String");
        StringQualifiers = new StringQualifiersType(length, allowedLength);
    }
    public void AddBool()
    {
        Types.Add("Bool");
    }
    public void AddDateTime(string dateFractions)
    {
        Types.Add("DateTime");
        DateQualifiers = new DateQualifiersType(dateFractions);
    }
}
