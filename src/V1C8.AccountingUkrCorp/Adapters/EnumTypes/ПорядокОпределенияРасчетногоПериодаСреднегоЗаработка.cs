using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПорядокОпределенияРасчетногоПериодаСреднегоЗаработка:EnumBase
    {
        public ПорядокОпределенияРасчетногоПериодаСреднегоЗаработка(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПоТрудовомуЗаконодательству => GetProperty<EnumItem>("ПоТрудовомуЗаконодательству");
        public EnumItem ПоКолдоговору => GetProperty<EnumItem>("ПоКолдоговору");
    }
}
