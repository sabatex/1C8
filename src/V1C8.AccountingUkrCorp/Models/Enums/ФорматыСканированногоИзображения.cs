using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ФорматыСканированногоИзображения", Comment = "", Synonym = "Форматы сканированного изображения")]
    public class ФорматыСканированногоИзображения:EnumItem
    {
        public static readonly ФорматыСканированногоИзображения BMP = new ФорматыСканированногоИзображения{Name= "BMP",Synonym="BMP",Comment=""};
        public static readonly ФорматыСканированногоИзображения JPG = new ФорматыСканированногоИзображения{Name= "JPG",Synonym="JPG",Comment=""};
        public static readonly ФорматыСканированногоИзображения GIF = new ФорматыСканированногоИзображения{Name= "GIF",Synonym="GIF",Comment=""};
        public static readonly ФорматыСканированногоИзображения PNG = new ФорматыСканированногоИзображения{Name= "PNG",Synonym="PNG",Comment=""};
        public static readonly ФорматыСканированногоИзображения TIF = new ФорматыСканированногоИзображения{Name= "TIF",Synonym="TIF",Comment=""};
    }
}
