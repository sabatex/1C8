using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипХранилищаСертификатов", Comment = "", Synonym = "Тип хранилища сертификатов")]
    public class ТипХранилищаСертификатов:EnumItem
    {
        public static readonly ТипХранилищаСертификатов ПерсональныеСертификаты = new ТипХранилищаСертификатов{Name= "ПерсональныеСертификаты",Synonym="Персональные сертификаты",Comment=""};
        public static readonly ТипХранилищаСертификатов СертификатыПолучателей = new ТипХранилищаСертификатов{Name= "СертификатыПолучателей",Synonym="Сертификаты получателей",Comment=""};
        public static readonly ТипХранилищаСертификатов СертификатыУдостоверяющихЦентров = new ТипХранилищаСертификатов{Name= "СертификатыУдостоверяющихЦентров",Synonym="Сертификаты удостоверяющих центров",Comment=""};
        public static readonly ТипХранилищаСертификатов КорневыеСертификаты = new ТипХранилищаСертификатов{Name= "КорневыеСертификаты",Synonym="Корневые сертификаты",Comment=""};
    }
}
