using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8.Models.Metadata
{
    public class StringQualifiersType
    {
        public int Length { get; set; }
        public string AllowedLength { get; set; }
        public StringQualifiersType(int length, string allowedLength)
        {
            Length = length;
            AllowedLength = allowedLength;

        }
    }
}
