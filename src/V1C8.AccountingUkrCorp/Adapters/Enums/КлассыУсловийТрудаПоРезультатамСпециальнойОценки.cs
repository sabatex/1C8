using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class КлассыУсловийТрудаПоРезультатамСпециальнойОценки:V1C8COMObject
    {
        public КлассыУсловийТрудаПоРезультатамСпециальнойОценки(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Опасный => GetProperty<EnumItemBase>();
        public EnumItemBase Вредный1 => GetProperty<EnumItemBase>();
        public EnumItemBase Вредный2 => GetProperty<EnumItemBase>();
        public EnumItemBase Вредный3 => GetProperty<EnumItemBase>();
        public EnumItemBase Вредный4 => GetProperty<EnumItemBase>();
        public EnumItemBase Допустимый => GetProperty<EnumItemBase>();
        public EnumItemBase Оптимальный => GetProperty<EnumItemBase>();
    }
}
