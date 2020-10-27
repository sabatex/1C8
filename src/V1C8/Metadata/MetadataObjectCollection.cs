using System.Collections;
using System.Collections.Generic;

namespace sabatex.V1C8.Metadata
{
    public class MetadataObjectCollection<T>:V1C8COMObject,IMetadataObjectCollection<T> where T:V1C8COMObject
    {

        public MetadataObjectCollection(V1C8COMObject owner, object handle):base(owner,handle)
        {

        }
    }
}