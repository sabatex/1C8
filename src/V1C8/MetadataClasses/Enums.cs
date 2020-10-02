using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8.MetadataClasses
{
    public class Enums
    {
        dynamic context;
        public Enums(dynamic context)
        {
            this.context = context;
        }
        public int Count()=>context.Metadata.Enums.Count();
        public EnumMetadata  Get(int i)=>new EnumMetadata(context.Metadata.Enums.Get(i));

    }

}