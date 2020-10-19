using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.EnumTypes
{
    public class EnumsBase:V1C8COMObject
    {
        public EnumsBase(V1C8COMConnector owner, object handle) : base(owner, handle)
        {
        }

        public V1C8COMObject AllRefsType()=>GetProperty<V1C8COMObject>("AllRefsType");
        public V1C8COMObject ТипВсеСсылки()=>GetProperty<V1C8COMObject>("AllRefsType");
    }

}