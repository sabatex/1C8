using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СтатусыИзвлеченияТекстаФайлов:EnumBase
    {
        public СтатусыИзвлеченияТекстаФайлов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НеИзвлечен => GetProperty<EnumItem>("НеИзвлечен");
        public EnumItem Извлечен => GetProperty<EnumItem>("Извлечен");
        public EnumItem ИзвлечьНеУдалось => GetProperty<EnumItem>("ИзвлечьНеУдалось");
    }
}
