using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ПорядокОпределенияРасчетногоПериодаСреднегоЗаработка:V1C8COMObject
    {
        public ПорядокОпределенияРасчетногоПериодаСреднегоЗаработка(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоТрудовомуЗаконодательству => GetProperty<EnumItemBase>();
        public EnumItemBase ПоКолдоговору => GetProperty<EnumItemBase>();
    }
}
