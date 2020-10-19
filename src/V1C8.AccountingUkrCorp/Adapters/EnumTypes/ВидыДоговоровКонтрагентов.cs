using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДоговоровКонтрагентов:V1C8COMObject
    {
        public ВидыДоговоровКонтрагентов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СПоставщиком => GetProperty<EnumItemBase>("СПоставщиком");
        public EnumItemBase СПокупателем => GetProperty<EnumItemBase>("СПокупателем");
        public EnumItemBase СКомитентом => GetProperty<EnumItemBase>("СКомитентом");
        public EnumItemBase СКомиссионером => GetProperty<EnumItemBase>("СКомиссионером");
        public EnumItemBase Бартерный => GetProperty<EnumItemBase>("Бартерный");
        public EnumItemBase Прочее => GetProperty<EnumItemBase>("Прочее");
    }
}
