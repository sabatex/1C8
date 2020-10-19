using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДоговоровКонтрагентов:EnumBase
    {
        public ВидыДоговоровКонтрагентов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem СПоставщиком => GetProperty<EnumItem>("СПоставщиком");
        public EnumItem СПокупателем => GetProperty<EnumItem>("СПокупателем");
        public EnumItem СКомитентом => GetProperty<EnumItem>("СКомитентом");
        public EnumItem СКомиссионером => GetProperty<EnumItem>("СКомиссионером");
        public EnumItem Бартерный => GetProperty<EnumItem>("Бартерный");
        public EnumItem Прочее => GetProperty<EnumItem>("Прочее");
    }
}
