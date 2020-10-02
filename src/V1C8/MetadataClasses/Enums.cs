using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8.MetadataClasses
{
    public class Enums
    {
        dynamic context;
        dynamic enumsContext;
        public Enums(dynamic context)
        {
            this.context = context;
            this.enumsContext = context.Metadata.Enums;   
        }
        public int Count()=>enumsContext.Count();
        public EnumMetadata  Get(int i)=>new EnumMetadata(enumsContext.Get(i));

    }

}