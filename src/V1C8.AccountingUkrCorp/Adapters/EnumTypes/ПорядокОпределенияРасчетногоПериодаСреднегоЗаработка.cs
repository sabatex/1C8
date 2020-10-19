using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПорядокОпределенияРасчетногоПериодаСреднегоЗаработка:V1C8COMObject
    {
        public ПорядокОпределенияРасчетногоПериодаСреднегоЗаработка(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоТрудовомуЗаконодательству => GetProperty<EnumItemBase>("ПоТрудовомуЗаконодательству");
        public EnumItemBase ПоКолдоговору => GetProperty<EnumItemBase>("ПоКолдоговору");
    }
}
