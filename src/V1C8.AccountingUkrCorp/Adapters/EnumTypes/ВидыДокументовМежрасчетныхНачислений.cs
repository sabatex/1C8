using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДокументовМежрасчетныхНачислений:V1C8COMObject
    {
        public ВидыДокументовМежрасчетныхНачислений(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase БольничныйЛист => GetProperty<EnumItemBase>("БольничныйЛист");
        public EnumItemBase ВозвратНДФЛ => GetProperty<EnumItemBase>("ВозвратНДФЛ");
        public EnumItemBase ЕдиновременноеПособиеЗаСчетФСС => GetProperty<EnumItemBase>("ЕдиновременноеПособиеЗаСчетФСС");
        public EnumItemBase Командировка => GetProperty<EnumItemBase>("Командировка");
        public EnumItemBase КомпенсацияЗаЗадержкуЗарплаты => GetProperty<EnumItemBase>("КомпенсацияЗаЗадержкуЗарплаты");
        public EnumItemBase МатериальнаяПомощь => GetProperty<EnumItemBase>("МатериальнаяПомощь");
        public EnumItemBase НачислениеЗарплаты => GetProperty<EnumItemBase>("НачислениеЗарплаты");
        public EnumItemBase ОплатаДнейУходаЗаДетьмиИнвалидами => GetProperty<EnumItemBase>("ОплатаДнейУходаЗаДетьмиИнвалидами");
        public EnumItemBase ОплатаПоСреднемуЗаработку => GetProperty<EnumItemBase>("ОплатаПоСреднемуЗаработку");
        public EnumItemBase Отпуск => GetProperty<EnumItemBase>("Отпуск");
        public EnumItemBase ОтпускПоУходуЗаРебенком => GetProperty<EnumItemBase>("ОтпускПоУходуЗаРебенком");
        public EnumItemBase Премия => GetProperty<EnumItemBase>("Премия");
        public EnumItemBase ПростойСотрудников => GetProperty<EnumItemBase>("ПростойСотрудников");
        public EnumItemBase РазовоеНачисление => GetProperty<EnumItemBase>("РазовоеНачисление");
        public EnumItemBase Увольнение => GetProperty<EnumItemBase>("Увольнение");
    }
}
