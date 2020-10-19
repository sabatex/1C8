using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ФорматыСохраненияОтчетов:V1C8COMObject
    {
        public ФорматыСохраненияОтчетов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase HTML => GetProperty<EnumItemBase>("HTML");
        public EnumItemBase HTML4 => GetProperty<EnumItemBase>("HTML4");
        public EnumItemBase XLS => GetProperty<EnumItemBase>("XLS");
        public EnumItemBase XLSX => GetProperty<EnumItemBase>("XLSX");
        public EnumItemBase PDF => GetProperty<EnumItemBase>("PDF");
        public EnumItemBase MXL => GetProperty<EnumItemBase>("MXL");
        public EnumItemBase ODS => GetProperty<EnumItemBase>("ODS");
        public EnumItemBase DOCX => GetProperty<EnumItemBase>("DOCX");
        public EnumItemBase TXT => GetProperty<EnumItemBase>("TXT");
        public EnumItemBase ANSITXT => GetProperty<EnumItemBase>("ANSITXT");
    }
}
