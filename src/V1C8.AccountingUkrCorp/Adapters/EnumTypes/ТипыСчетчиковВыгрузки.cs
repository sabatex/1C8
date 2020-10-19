using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыСчетчиковВыгрузки:EnumBase
    {
        public ТипыСчетчиковВыгрузки(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem СчетчикДокументовВФормате201 => GetProperty<EnumItem>("СчетчикДокументовВФормате201");
        public EnumItem СчетчикДокументовВФормате300 => GetProperty<EnumItem>("СчетчикДокументовВФормате300");
        public EnumItem СчетчикФайлов => GetProperty<EnumItem>("СчетчикФайлов");
        public EnumItem СчетчикФайловАлко => GetProperty<EnumItem>("СчетчикФайловАлко");
    }
}
