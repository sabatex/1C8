using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДокументовНачисления:V1C8COMObject
    {
        public ВидыДокументовНачисления(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase БольничныйЛист => GetProperty<EnumItemBase>("БольничныйЛист");
        public EnumItemBase ДоходВНатуральнойФорме => GetProperty<EnumItemBase>("ДоходВНатуральнойФорме");
        public EnumItemBase Командировка => GetProperty<EnumItemBase>("Командировка");
        public EnumItemBase МатериальнаяПомощь => GetProperty<EnumItemBase>("МатериальнаяПомощь");
        public EnumItemBase ОплатаДнейУходаЗаДетьмиИнвалидами => GetProperty<EnumItemBase>("ОплатаДнейУходаЗаДетьмиИнвалидами");
        public EnumItemBase ОплатаПоСреднемуЗаработку => GetProperty<EnumItemBase>("ОплатаПоСреднемуЗаработку");
        public EnumItemBase Отпуск => GetProperty<EnumItemBase>("Отпуск");
        public EnumItemBase ОтпускБезСохраненияОплаты => GetProperty<EnumItemBase>("ОтпускБезСохраненияОплаты");
        public EnumItemBase Премия => GetProperty<EnumItemBase>("Премия");
        public EnumItemBase ПрогулНеявка => GetProperty<EnumItemBase>("ПрогулНеявка");
        public EnumItemBase ПростойСотрудников => GetProperty<EnumItemBase>("ПростойСотрудников");
        public EnumItemBase РазовоеНачисление => GetProperty<EnumItemBase>("РазовоеНачисление");
        public EnumItemBase Увольнение => GetProperty<EnumItemBase>("Увольнение");
        public EnumItemBase Отгул => GetProperty<EnumItemBase>("Отгул");
    }
}
