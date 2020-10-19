using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КатегорииДолжностейДляУчетаЗабронированных:EnumBase
    {
        public КатегорииДолжностейДляУчетаЗабронированных(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Руководители => GetProperty<EnumItem>("Руководители");
        public EnumItem СпециалистыСХ => GetProperty<EnumItem>("СпециалистыСХ");
        public EnumItem СпециалистыПолезныеИскопаемые => GetProperty<EnumItem>("СпециалистыПолезныеИскопаемые");
        public EnumItem СпециалистыОбрабатывающиеПроизводства => GetProperty<EnumItem>("СпециалистыОбрабатывающиеПроизводства");
        public EnumItem СпециалистыПроизводствоЭлектроэнергии => GetProperty<EnumItem>("СпециалистыПроизводствоЭлектроэнергии");
        public EnumItem СпециалистыСтроительство => GetProperty<EnumItem>("СпециалистыСтроительство");
        public EnumItem СпециалистыТранспорт => GetProperty<EnumItem>("СпециалистыТранспорт");
        public EnumItem СпециалистыОбразования => GetProperty<EnumItem>("СпециалистыОбразования");
        public EnumItem СпециалистыЗдравоохранение => GetProperty<EnumItem>("СпециалистыЗдравоохранение");
        public EnumItem ПрочиеСпециалисты => GetProperty<EnumItem>("ПрочиеСпециалисты");
        public EnumItem ДругиеСлужащие => GetProperty<EnumItem>("ДругиеСлужащие");
        public EnumItem РабочиеИмеющиеТарифныйРазряд => GetProperty<EnumItem>("РабочиеИмеющиеТарифныйРазряд");
        public EnumItem РабочиеНеИмеющиеТарифныхРазрядов => GetProperty<EnumItem>("РабочиеНеИмеющиеТарифныхРазрядов");
        public EnumItem РабочиеСХ => GetProperty<EnumItem>("РабочиеСХ");
        public EnumItem РабочиеЛокомотивныхБригад => GetProperty<EnumItem>("РабочиеЛокомотивныхБригад");
        public EnumItem Водители => GetProperty<EnumItem>("Водители");
        public EnumItem Трактористы => GetProperty<EnumItem>("Трактористы");
    }
}
