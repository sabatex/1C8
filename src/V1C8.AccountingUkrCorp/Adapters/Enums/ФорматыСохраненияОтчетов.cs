using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ФорматыСохраненияОтчетов:V1C8COMObject
    {
        public ФорматыСохраненияОтчетов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase HTML => GetProperty<EnumItemBase>();
        public EnumItemBase HTML4 => GetProperty<EnumItemBase>();
        public EnumItemBase XLS => GetProperty<EnumItemBase>();
        public EnumItemBase XLSX => GetProperty<EnumItemBase>();
        public EnumItemBase PDF => GetProperty<EnumItemBase>();
        public EnumItemBase MXL => GetProperty<EnumItemBase>();
        public EnumItemBase ODS => GetProperty<EnumItemBase>();
        public EnumItemBase DOCX => GetProperty<EnumItemBase>();
        public EnumItemBase TXT => GetProperty<EnumItemBase>();
        public EnumItemBase ANSITXT => GetProperty<EnumItemBase>();
    }
}
