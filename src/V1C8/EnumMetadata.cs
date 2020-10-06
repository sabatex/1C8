using System;
using System.Collections.Generic;
using System.Text;
using sabatex.V1C8.Models;

namespace sabatex.V1C8
{
    public class EnumMetaData
    {
        public readonly string Name;
        public readonly string Synonym;
        public readonly string Comment;

        public readonly EnumItem[] EnumValues;
        public EnumMetaData(dynamic context)
        {
            Name = context.Name;
            Synonym = context.Synonym;
            Comment = context.Comment;
            int i = context.EnumValues.Count();

            EnumValues = new EnumItem[i];
            while (0 < i--)
            {
                dynamic v = context.Get(i);
                EnumValues[i] = new EnumItem
                {
                    Name = v.Name,
                    Synonym = v.Synonym,
                    Comment = v.Comment,
                    Owner = Name
                };
            }

        }
    }
}