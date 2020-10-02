using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыМалоценныхАктивов", Comment = "", Synonym = "Виды малоценных активов")]
    public class ВидыМалоценныхАктивов:EnumItem
    {
        public static readonly ВидыМалоценныхАктивов МалоценныйБыстроизнашивающийсяПредмет = new ВидыМалоценныхАктивов{Name= "МалоценныйБыстроизнашивающийсяПредмет",Synonym="Малоценный быстроизнашивающийся предмет",Comment=""};
        public static readonly ВидыМалоценныхАктивов МалоценныйНеоборотныйАктив = new ВидыМалоценныхАктивов{Name= "МалоценныйНеоборотныйАктив",Synonym="Малоценный необоротный актив",Comment=""};
        public static readonly ВидыМалоценныхАктивов БиблиотечныеФонды = new ВидыМалоценныхАктивов{Name= "БиблиотечныеФонды",Synonym="Библиотечные фонды",Comment=""};
    }
}
