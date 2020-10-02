using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипХранилищаСертификатов", Comment = "", Synonym = "Тип хранилища сертификатов")]
    public class ТипХранилищаСертификатов:EnumItem
    {
        public static readonly ТипХранилищаСертификатов ПерсональныеСертификаты = new ТипХранилищаСертификатов{Name= "ПерсональныеСертификаты",Synonim="Персональные сертификаты",Comment=""};
        public static readonly ТипХранилищаСертификатов СертификатыПолучателей = new ТипХранилищаСертификатов{Name= "СертификатыПолучателей",Synonim="Сертификаты получателей",Comment=""};
        public static readonly ТипХранилищаСертификатов СертификатыУдостоверяющихЦентров = new ТипХранилищаСертификатов{Name= "СертификатыУдостоверяющихЦентров",Synonim="Сертификаты удостоверяющих центров",Comment=""};
        public static readonly ТипХранилищаСертификатов КорневыеСертификаты = new ТипХранилищаСертификатов{Name= "КорневыеСертификаты",Synonim="Корневые сертификаты",Comment=""};
    }
}
