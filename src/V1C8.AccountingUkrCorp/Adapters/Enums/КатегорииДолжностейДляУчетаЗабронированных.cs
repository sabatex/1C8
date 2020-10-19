using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class КатегорииДолжностейДляУчетаЗабронированных:V1C8COMObject
    {
        public КатегорииДолжностейДляУчетаЗабронированных(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Руководители => GetProperty<EnumItemBase>();
        public EnumItemBase СпециалистыСХ => GetProperty<EnumItemBase>();
        public EnumItemBase СпециалистыПолезныеИскопаемые => GetProperty<EnumItemBase>();
        public EnumItemBase СпециалистыОбрабатывающиеПроизводства => GetProperty<EnumItemBase>();
        public EnumItemBase СпециалистыПроизводствоЭлектроэнергии => GetProperty<EnumItemBase>();
        public EnumItemBase СпециалистыСтроительство => GetProperty<EnumItemBase>();
        public EnumItemBase СпециалистыТранспорт => GetProperty<EnumItemBase>();
        public EnumItemBase СпециалистыОбразования => GetProperty<EnumItemBase>();
        public EnumItemBase СпециалистыЗдравоохранение => GetProperty<EnumItemBase>();
        public EnumItemBase ПрочиеСпециалисты => GetProperty<EnumItemBase>();
        public EnumItemBase ДругиеСлужащие => GetProperty<EnumItemBase>();
        public EnumItemBase РабочиеИмеющиеТарифныйРазряд => GetProperty<EnumItemBase>();
        public EnumItemBase РабочиеНеИмеющиеТарифныхРазрядов => GetProperty<EnumItemBase>();
        public EnumItemBase РабочиеСХ => GetProperty<EnumItemBase>();
        public EnumItemBase РабочиеЛокомотивныхБригад => GetProperty<EnumItemBase>();
        public EnumItemBase Водители => GetProperty<EnumItemBase>();
        public EnumItemBase Трактористы => GetProperty<EnumItemBase>();
    }
}
