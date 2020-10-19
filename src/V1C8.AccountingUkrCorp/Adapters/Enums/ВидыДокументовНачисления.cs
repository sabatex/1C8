using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыДокументовНачисления:V1C8COMObject
    {
        public ВидыДокументовНачисления(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase БольничныйЛист => GetProperty<EnumItemBase>();
        public EnumItemBase ДоходВНатуральнойФорме => GetProperty<EnumItemBase>();
        public EnumItemBase Командировка => GetProperty<EnumItemBase>();
        public EnumItemBase МатериальнаяПомощь => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаДнейУходаЗаДетьмиИнвалидами => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаПоСреднемуЗаработку => GetProperty<EnumItemBase>();
        public EnumItemBase Отпуск => GetProperty<EnumItemBase>();
        public EnumItemBase ОтпускБезСохраненияОплаты => GetProperty<EnumItemBase>();
        public EnumItemBase Премия => GetProperty<EnumItemBase>();
        public EnumItemBase ПрогулНеявка => GetProperty<EnumItemBase>();
        public EnumItemBase ПростойСотрудников => GetProperty<EnumItemBase>();
        public EnumItemBase РазовоеНачисление => GetProperty<EnumItemBase>();
        public EnumItemBase Увольнение => GetProperty<EnumItemBase>();
        public EnumItemBase Отгул => GetProperty<EnumItemBase>();
    }
}
