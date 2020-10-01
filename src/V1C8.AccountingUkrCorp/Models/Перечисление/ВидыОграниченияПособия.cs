using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОграниченияПособия", Comment = "", Synonym = "Виды ограничения пособия")]
    public enum ВидыОграниченияПособия
    {
        [Description1C8(Name = "ОбщееОграничение", Comment = "", Synonym = "Предельной величиной базы для начисления страховых взносов")]
        ОбщееОграничение,
        [Description1C8(Name = "ОграничениеВРазмереММОТ", Comment = "", Synonym = "В размере ММОТ")]
        ОграничениеВРазмереММОТ,
        [Description1C8(Name = "БезОграничений", Comment = "", Synonym = "Отсутствует")]
        БезОграничений,
        [Description1C8(Name = "МаксимальныйРазмерЕжемесячнойСтраховойВыплаты", Comment = "", Synonym = "ѳ(не украинский) Максимальным размером ежемесячной страховой выплаты")]
        МаксимальныйРазмерЕжемесячнойСтраховойВыплаты,
        [Description1C8(Name = "ОграничениеВРазмереДвухММОТ", Comment = "", Synonym = "Ограничение в размере двух ММОТ")]
        ОграничениеВРазмереДвухММОТ
    }
}
