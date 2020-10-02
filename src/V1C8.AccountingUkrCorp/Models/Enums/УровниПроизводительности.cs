using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УровниПроизводительности", Comment = "", Synonym = "Уровни производительности")]
    public class УровниПроизводительности:EnumItem
    {
        public static readonly УровниПроизводительности Идеально = new УровниПроизводительности{Name= "Идеально",Synonym="Идеально (apdex = 1)",Comment=""};
        public static readonly УровниПроизводительности Отлично = new УровниПроизводительности{Name= "Отлично",Synonym="Отлично (apdex >= 0.94)",Comment=""};
        public static readonly УровниПроизводительности Хорошо = new УровниПроизводительности{Name= "Хорошо",Synonym="Хорошо (apdex >= 0.85)",Comment=""};
        public static readonly УровниПроизводительности Удовлетворительно = new УровниПроизводительности{Name= "Удовлетворительно",Synonym="Удовлетворительно (apdex >= 0.70)",Comment=""};
        public static readonly УровниПроизводительности Плохо = new УровниПроизводительности{Name= "Плохо",Synonym="Плохо (apdex >= 0.50)",Comment=""};
    }
}
