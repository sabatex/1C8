using System;
using System.Collections.Generic;
using System.Text;


namespace sabatex.V1C8
{
    public class MetaData:IDisposable
    {
        V1C8COMConnector owner;
        internal MetaData(V1C8COMConnector v1C8COMConnector)
        {
            owner = v1C8COMConnector;
            this.Enums = new Enums(v1C8COMConnector);

        }

        public string Name { get=>owner.COMObject.Metadata.Name; }
        public string Version { get => owner.COMObject.Metadata.Version; }
        public dynamic FindByType(dynamic elementType)=>owner.COMObject.Metadata.FindByType(elementType);

        public readonly Enums Enums;

        public void Dispose()
        {
            owner = null;
        }
    }

    
}