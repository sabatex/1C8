using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ТипХранилищаСертификатов:V1C8COMObject
    {
        public ТипХранилищаСертификатов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПерсональныеСертификаты => GetProperty<EnumItemBase>();
        public EnumItemBase СертификатыПолучателей => GetProperty<EnumItemBase>();
        public EnumItemBase СертификатыУдостоверяющихЦентров => GetProperty<EnumItemBase>();
        public EnumItemBase КорневыеСертификаты => GetProperty<EnumItemBase>();
    }
}
