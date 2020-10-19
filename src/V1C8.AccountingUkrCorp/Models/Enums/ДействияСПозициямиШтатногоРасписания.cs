using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("DeistvyiaSPozytsyiamyShtatnohoRaspysanyia")]
    [Description1C8(Name = "ДействияСПозициямиШтатногоРасписания", Comment = "", Synonym = "Действия с позициями штатного расписания")]
    public class ДействияСПозициямиШтатногоРасписания:EnumItem
    {
        public static readonly ДействияСПозициямиШтатногоРасписания СоздатьНовуюПозицию = new ДействияСПозициямиШтатногоРасписания{Name= "СоздатьНовуюПозицию",Synonym="Создать новую позицию",Comment=""};
        public static readonly ДействияСПозициямиШтатногоРасписания ЗакрытьПозицию = new ДействияСПозициямиШтатногоРасписания{Name= "ЗакрытьПозицию",Synonym="Закрыть позицию",Comment=""};
    }
}
