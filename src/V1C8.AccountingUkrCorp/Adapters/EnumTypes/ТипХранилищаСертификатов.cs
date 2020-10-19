using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипХранилищаСертификатов:EnumBase
    {
        public ТипХранилищаСертификатов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПерсональныеСертификаты => GetProperty<EnumItem>("ПерсональныеСертификаты");
        public EnumItem СертификатыПолучателей => GetProperty<EnumItem>("СертификатыПолучателей");
        public EnumItem СертификатыУдостоверяющихЦентров => GetProperty<EnumItem>("СертификатыУдостоверяющихЦентров");
        public EnumItem КорневыеСертификаты => GetProperty<EnumItem>("КорневыеСертификаты");
    }
}
