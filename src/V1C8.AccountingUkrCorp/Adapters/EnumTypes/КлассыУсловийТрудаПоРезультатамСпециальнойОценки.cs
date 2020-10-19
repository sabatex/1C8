using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КлассыУсловийТрудаПоРезультатамСпециальнойОценки:V1C8COMObject
    {
        public КлассыУсловийТрудаПоРезультатамСпециальнойОценки(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Опасный => GetProperty<EnumItemBase>("Опасный");
        public EnumItemBase Вредный1 => GetProperty<EnumItemBase>("Вредный1");
        public EnumItemBase Вредный2 => GetProperty<EnumItemBase>("Вредный2");
        public EnumItemBase Вредный3 => GetProperty<EnumItemBase>("Вредный3");
        public EnumItemBase Вредный4 => GetProperty<EnumItemBase>("Вредный4");
        public EnumItemBase Допустимый => GetProperty<EnumItemBase>("Допустимый");
        public EnumItemBase Оптимальный => GetProperty<EnumItemBase>("Оптимальный");
    }
}
