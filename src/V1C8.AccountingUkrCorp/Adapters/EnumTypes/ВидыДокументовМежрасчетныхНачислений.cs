using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДокументовМежрасчетныхНачислений:EnumBase
    {
        public ВидыДокументовМежрасчетныхНачислений(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem БольничныйЛист => GetProperty<EnumItem>("БольничныйЛист");
        public EnumItem ВозвратНДФЛ => GetProperty<EnumItem>("ВозвратНДФЛ");
        public EnumItem ЕдиновременноеПособиеЗаСчетФСС => GetProperty<EnumItem>("ЕдиновременноеПособиеЗаСчетФСС");
        public EnumItem Командировка => GetProperty<EnumItem>("Командировка");
        public EnumItem КомпенсацияЗаЗадержкуЗарплаты => GetProperty<EnumItem>("КомпенсацияЗаЗадержкуЗарплаты");
        public EnumItem МатериальнаяПомощь => GetProperty<EnumItem>("МатериальнаяПомощь");
        public EnumItem НачислениеЗарплаты => GetProperty<EnumItem>("НачислениеЗарплаты");
        public EnumItem ОплатаДнейУходаЗаДетьмиИнвалидами => GetProperty<EnumItem>("ОплатаДнейУходаЗаДетьмиИнвалидами");
        public EnumItem ОплатаПоСреднемуЗаработку => GetProperty<EnumItem>("ОплатаПоСреднемуЗаработку");
        public EnumItem Отпуск => GetProperty<EnumItem>("Отпуск");
        public EnumItem ОтпускПоУходуЗаРебенком => GetProperty<EnumItem>("ОтпускПоУходуЗаРебенком");
        public EnumItem Премия => GetProperty<EnumItem>("Премия");
        public EnumItem ПростойСотрудников => GetProperty<EnumItem>("ПростойСотрудников");
        public EnumItem РазовоеНачисление => GetProperty<EnumItem>("РазовоеНачисление");
        public EnumItem Увольнение => GetProperty<EnumItem>("Увольнение");
    }
}
