using System;
using System.Collections.Generic;
using System.Text;

namespace Sabatex.V1C8.Metadata;

public interface IMetadataTabularSectionCollection:IMetadataObjectCollection<IMetadataObjectTabularSection>
{
    public new IEnumerator<IMetadataObjectTabularSection> GetEnumerator()
    {
        return new V1C8Enumerator<IMetadataObjectTabularSection>(this);
    }

}
