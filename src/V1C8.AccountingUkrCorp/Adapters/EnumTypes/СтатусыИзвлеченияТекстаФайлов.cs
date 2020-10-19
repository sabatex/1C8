using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СтатусыИзвлеченияТекстаФайлов:V1C8COMObject
    {
        public СтатусыИзвлеченияТекстаФайлов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеИзвлечен => GetProperty<EnumItemBase>("НеИзвлечен");
        public EnumItemBase Извлечен => GetProperty<EnumItemBase>("Извлечен");
        public EnumItemBase ИзвлечьНеУдалось => GetProperty<EnumItemBase>("ИзвлечьНеУдалось");
    }
}
