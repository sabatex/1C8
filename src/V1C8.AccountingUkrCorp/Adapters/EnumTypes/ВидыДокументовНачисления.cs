using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДокументовНачисления:EnumBase
    {
        public ВидыДокументовНачисления(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem БольничныйЛист => GetProperty<EnumItem>("БольничныйЛист");
        public EnumItem ДоходВНатуральнойФорме => GetProperty<EnumItem>("ДоходВНатуральнойФорме");
        public EnumItem Командировка => GetProperty<EnumItem>("Командировка");
        public EnumItem МатериальнаяПомощь => GetProperty<EnumItem>("МатериальнаяПомощь");
        public EnumItem ОплатаДнейУходаЗаДетьмиИнвалидами => GetProperty<EnumItem>("ОплатаДнейУходаЗаДетьмиИнвалидами");
        public EnumItem ОплатаПоСреднемуЗаработку => GetProperty<EnumItem>("ОплатаПоСреднемуЗаработку");
        public EnumItem Отпуск => GetProperty<EnumItem>("Отпуск");
        public EnumItem ОтпускБезСохраненияОплаты => GetProperty<EnumItem>("ОтпускБезСохраненияОплаты");
        public EnumItem Премия => GetProperty<EnumItem>("Премия");
        public EnumItem ПрогулНеявка => GetProperty<EnumItem>("ПрогулНеявка");
        public EnumItem ПростойСотрудников => GetProperty<EnumItem>("ПростойСотрудников");
        public EnumItem РазовоеНачисление => GetProperty<EnumItem>("РазовоеНачисление");
        public EnumItem Увольнение => GetProperty<EnumItem>("Увольнение");
        public EnumItem Отгул => GetProperty<EnumItem>("Отгул");
    }
}
