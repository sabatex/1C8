using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипХранилищаСертификатов:V1C8COMObject
    {
        public ТипХранилищаСертификатов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПерсональныеСертификаты => GetProperty<EnumItemBase>("ПерсональныеСертификаты");
        public EnumItemBase СертификатыПолучателей => GetProperty<EnumItemBase>("СертификатыПолучателей");
        public EnumItemBase СертификатыУдостоверяющихЦентров => GetProperty<EnumItemBase>("СертификатыУдостоверяющихЦентров");
        public EnumItemBase КорневыеСертификаты => GetProperty<EnumItemBase>("КорневыеСертификаты");
    }
}
