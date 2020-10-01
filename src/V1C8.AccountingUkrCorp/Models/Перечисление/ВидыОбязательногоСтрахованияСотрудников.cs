using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОбязательногоСтрахованияСотрудников", Comment = "", Synonym = "Виды обязательного страхования сотрудников")]
    public enum ВидыОбязательногоСтрахованияСотрудников
    {
        [Description1C8(Name = "ПФРПоСуммарномуТарифу", Comment = "", Synonym = "ѳ(не украинский) ПФР - по суммарному тарифу с 1 января 2014 года")]
        ПФРПоСуммарномуТарифу,
        [Description1C8(Name = "ФССНесчастныеСлучаи", Comment = "", Synonym = "(до октября 2018 г.) ФСС, страхование от несчастных случаев")]
        ФССНесчастныеСлучаи,
        [Description1C8(Name = "ФСС", Comment = "", Synonym = "ФСС")]
        ФСС,
        [Description1C8(Name = "ФФОМС", Comment = "", Synonym = "ѳ(не украинский) ФФОМС")]
        ФФОМС,
        [Description1C8(Name = "ПФРЗаЗанятыхНаПодземныхИВредныхРаботах", Comment = "", Synonym = "ѳ(не украинский) ПФР, за занятых на работах с вредными условиями труда")]
        ПФРЗаЗанятыхНаПодземныхИВредныхРаботах,
        [Description1C8(Name = "ПФРЗаЗанятыхНаТяжелыхИПрочихРаботах", Comment = "", Synonym = "ѳ(не украинский) ПФР, за занятых на работах с тяжелыми условиями труда")]
        ПФРЗаЗанятыхНаТяжелыхИПрочихРаботах,
        [Description1C8(Name = "ДоплатаКПенсииЛетчикам", Comment = "", Synonym = "ѳ(не украинский) Доплата к пенсии летчикам")]
        ДоплатаКПенсииЛетчикам,
        [Description1C8(Name = "ДоплатаКПенсииШахтерам", Comment = "", Synonym = "ѳ(не украинский) Доплата к пенсии шахтерам")]
        ДоплатаКПенсииШахтерам,
        [Description1C8(Name = "ПФРСтраховая", Comment = "", Synonym = "ѳ(не украинский) ПФР - страховая часть пенсии за 2010 - 2013 годы")]
        ПФРСтраховая,
        [Description1C8(Name = "ПФРНакопительная", Comment = "", Synonym = "ѳ(не украинский) ПФР - накопительная часть пенсии за 2010 - 2013 годы")]
        ПФРНакопительная,
        [Description1C8(Name = "ТФОМС", Comment = "", Synonym = "ѳ(не украинский) ТФОМС")]
        ТФОМС,
        [Description1C8(Name = "ПФРСПревышения", Comment = "", Synonym = "ѳ(не украинский) ПФР - с базы сверх предельной величины, с 1 января 2016 года")]
        ПФРСПревышения
    }
}
