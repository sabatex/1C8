using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ТипыСчетчиковВыгрузки:V1C8COMObject
    {
        public ТипыСчетчиковВыгрузки(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СчетчикДокументовВФормате201 => GetProperty<EnumItemBase>();
        public EnumItemBase СчетчикДокументовВФормате300 => GetProperty<EnumItemBase>();
        public EnumItemBase СчетчикФайлов => GetProperty<EnumItemBase>();
        public EnumItemBase СчетчикФайловАлко => GetProperty<EnumItemBase>();
    }
}
