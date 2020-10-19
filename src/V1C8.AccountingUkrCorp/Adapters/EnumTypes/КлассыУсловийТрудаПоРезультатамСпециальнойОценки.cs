using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КлассыУсловийТрудаПоРезультатамСпециальнойОценки:EnumBase
    {
        public КлассыУсловийТрудаПоРезультатамСпециальнойОценки(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Опасный => GetProperty<EnumItem>("Опасный");
        public EnumItem Вредный1 => GetProperty<EnumItem>("Вредный1");
        public EnumItem Вредный2 => GetProperty<EnumItem>("Вредный2");
        public EnumItem Вредный3 => GetProperty<EnumItem>("Вредный3");
        public EnumItem Вредный4 => GetProperty<EnumItem>("Вредный4");
        public EnumItem Допустимый => GetProperty<EnumItem>("Допустимый");
        public EnumItem Оптимальный => GetProperty<EnumItem>("Оптимальный");
    }
}
