using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыСчетчиковВыгрузки:V1C8COMObject
    {
        public ТипыСчетчиковВыгрузки(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СчетчикДокументовВФормате201 => GetProperty<EnumItemBase>("СчетчикДокументовВФормате201");
        public EnumItemBase СчетчикДокументовВФормате300 => GetProperty<EnumItemBase>("СчетчикДокументовВФормате300");
        public EnumItemBase СчетчикФайлов => GetProperty<EnumItemBase>("СчетчикФайлов");
        public EnumItemBase СчетчикФайловАлко => GetProperty<EnumItemBase>("СчетчикФайловАлко");
    }
}
