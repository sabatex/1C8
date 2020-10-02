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
        public int Count()=>context.Count();
        public EnumMetadata  Get(int i)=>new EnumMetadata(context.Get(i));

    }

}