using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КатегорииДолжностейДляУчетаЗабронированных:V1C8COMObject
    {
        public КатегорииДолжностейДляУчетаЗабронированных(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Руководители => GetProperty<EnumItemBase>("Руководители");
        public EnumItemBase СпециалистыСХ => GetProperty<EnumItemBase>("СпециалистыСХ");
        public EnumItemBase СпециалистыПолезныеИскопаемые => GetProperty<EnumItemBase>("СпециалистыПолезныеИскопаемые");
        public EnumItemBase СпециалистыОбрабатывающиеПроизводства => GetProperty<EnumItemBase>("СпециалистыОбрабатывающиеПроизводства");
        public EnumItemBase СпециалистыПроизводствоЭлектроэнергии => GetProperty<EnumItemBase>("СпециалистыПроизводствоЭлектроэнергии");
        public EnumItemBase СпециалистыСтроительство => GetProperty<EnumItemBase>("СпециалистыСтроительство");
        public EnumItemBase СпециалистыТранспорт => GetProperty<EnumItemBase>("СпециалистыТранспорт");
        public EnumItemBase СпециалистыОбразования => GetProperty<EnumItemBase>("СпециалистыОбразования");
        public EnumItemBase СпециалистыЗдравоохранение => GetProperty<EnumItemBase>("СпециалистыЗдравоохранение");
        public EnumItemBase ПрочиеСпециалисты => GetProperty<EnumItemBase>("ПрочиеСпециалисты");
        public EnumItemBase ДругиеСлужащие => GetProperty<EnumItemBase>("ДругиеСлужащие");
        public EnumItemBase РабочиеИмеющиеТарифныйРазряд => GetProperty<EnumItemBase>("РабочиеИмеющиеТарифныйРазряд");
        public EnumItemBase РабочиеНеИмеющиеТарифныхРазрядов => GetProperty<EnumItemBase>("РабочиеНеИмеющиеТарифныхРазрядов");
        public EnumItemBase РабочиеСХ => GetProperty<EnumItemBase>("РабочиеСХ");
        public EnumItemBase РабочиеЛокомотивныхБригад => GetProperty<EnumItemBase>("РабочиеЛокомотивныхБригад");
        public EnumItemBase Водители => GetProperty<EnumItemBase>("Водители");
        public EnumItemBase Трактористы => GetProperty<EnumItemBase>("Трактористы");
    }
}
