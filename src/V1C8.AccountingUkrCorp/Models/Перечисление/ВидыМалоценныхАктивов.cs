using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыМалоценныхАктивов", Comment = "", Synonym = "Виды малоценных активов")]
    public enum ВидыМалоценныхАктивов
    {
        [Description1C8(Name = "МалоценныйБыстроизнашивающийсяПредмет", Comment = "", Synonym = "Малоценный быстроизнашивающийся предмет")]
        МалоценныйБыстроизнашивающийсяПредмет,
        [Description1C8(Name = "МалоценныйНеоборотныйАктив", Comment = "", Synonym = "Малоценный необоротный актив")]
        МалоценныйНеоборотныйАктив,
        [Description1C8(Name = "БиблиотечныеФонды", Comment = "", Synonym = "Библиотечные фонды")]
        БиблиотечныеФонды
    }
}
