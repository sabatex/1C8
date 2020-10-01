using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипХранилищаСертификатов", Comment = "", Synonym = "Тип хранилища сертификатов")]
    public enum ТипХранилищаСертификатов
    {
        [Description1C8(Name = "ПерсональныеСертификаты", Comment = "", Synonym = "Персональные сертификаты")]
        ПерсональныеСертификаты,
        [Description1C8(Name = "СертификатыПолучателей", Comment = "", Synonym = "Сертификаты получателей")]
        СертификатыПолучателей,
        [Description1C8(Name = "СертификатыУдостоверяющихЦентров", Comment = "", Synonym = "Сертификаты удостоверяющих центров")]
        СертификатыУдостоверяющихЦентров,
        [Description1C8(Name = "КорневыеСертификаты", Comment = "", Synonym = "Корневые сертификаты")]
        КорневыеСертификаты
    }
}
