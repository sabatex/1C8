using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыВызоваДополнительныхОбработок", Comment = "", Synonym = "Способы вызова дополнительных обработок")]
    public class СпособыВызоваДополнительныхОбработок:EnumItem
    {
        public static readonly СпособыВызоваДополнительныхОбработок ВызовКлиентскогоМетода = new СпособыВызоваДополнительныхОбработок{Name= "ВызовКлиентскогоМетода",Synonym="Вызов клиентского метода",Comment=""};
        public static readonly СпособыВызоваДополнительныхОбработок ВызовСерверногоМетода = new СпособыВызоваДополнительныхОбработок{Name= "ВызовСерверногоМетода",Synonym="Вызов серверного метода",Comment=""};
        public static readonly СпособыВызоваДополнительныхОбработок ЗаполнениеФормы = new СпособыВызоваДополнительныхОбработок{Name= "ЗаполнениеФормы",Synonym="Заполнение формы",Comment=""};
        public static readonly СпособыВызоваДополнительныхОбработок ОткрытиеФормы = new СпособыВызоваДополнительныхОбработок{Name= "ОткрытиеФормы",Synonym="Открытие формы",Comment=""};
        public static readonly СпособыВызоваДополнительныхОбработок СценарийВБезопасномРежиме = new СпособыВызоваДополнительныхОбработок{Name= "СценарийВБезопасномРежиме",Synonym="Сценарий в безопасном режиме",Comment=""};
        public static readonly СпособыВызоваДополнительныхОбработок ЗагрузкаДанныхИзФайла = new СпособыВызоваДополнительныхОбработок{Name= "ЗагрузкаДанныхИзФайла",Synonym="Загрузка данных из файла",Comment=""};
    }
}
