using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ФорматыСохраненияОтчетов:EnumBase
    {
        public ФорматыСохраненияОтчетов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem HTML => GetProperty<EnumItem>("HTML");
        public EnumItem HTML4 => GetProperty<EnumItem>("HTML4");
        public EnumItem XLS => GetProperty<EnumItem>("XLS");
        public EnumItem XLSX => GetProperty<EnumItem>("XLSX");
        public EnumItem PDF => GetProperty<EnumItem>("PDF");
        public EnumItem MXL => GetProperty<EnumItem>("MXL");
        public EnumItem ODS => GetProperty<EnumItem>("ODS");
        public EnumItem DOCX => GetProperty<EnumItem>("DOCX");
        public EnumItem TXT => GetProperty<EnumItem>("TXT");
        public EnumItem ANSITXT => GetProperty<EnumItem>("ANSITXT");
    }
}
