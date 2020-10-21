using System;
using System.Collections.Generic;
using System.Text;


namespace sabatex.V1C8.Metadata
{
    public class ChartOfAccountTableMetaData:ObjectMetaData
    {
        public ChartOfAccountTableMetaData(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public EnumerationsMetadata<FieldMetadata> Attributes{get=>GetProperty<EnumerationsMetadata<FieldMetadata>>("Attributes");}

    }
}