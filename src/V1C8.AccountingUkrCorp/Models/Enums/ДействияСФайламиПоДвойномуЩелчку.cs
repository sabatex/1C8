using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ДействияСФайламиПоДвойномуЩелчку", Comment = "", Synonym = "Действия с файлами по двойному щелчку")]
    public class ДействияСФайламиПоДвойномуЩелчку:EnumItem
    {
        public static readonly ДействияСФайламиПоДвойномуЩелчку ОткрыватьФайл = new ДействияСФайламиПоДвойномуЩелчку{Name= "ОткрыватьФайл",Synonym="Открывать файл",Comment=""};
        public static readonly ДействияСФайламиПоДвойномуЩелчку ОткрыватьКарточку = new ДействияСФайламиПоДвойномуЩелчку{Name= "ОткрыватьКарточку",Synonym="Открывать карточку",Comment=""};
    }
}
