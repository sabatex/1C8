using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РазмерыБумаги:EnumBase
    {
        public РазмерыБумаги(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НеЗадано => GetProperty<EnumItem>("НеЗадано");
        public EnumItem A3 => GetProperty<EnumItem>("A3");
        public EnumItem A4 => GetProperty<EnumItem>("A4");
        public EnumItem A5 => GetProperty<EnumItem>("A5");
        public EnumItem B4 => GetProperty<EnumItem>("B4");
        public EnumItem B5 => GetProperty<EnumItem>("B5");
        public EnumItem B6 => GetProperty<EnumItem>("B6");
        public EnumItem C4 => GetProperty<EnumItem>("C4");
        public EnumItem C5 => GetProperty<EnumItem>("C5");
        public EnumItem C6 => GetProperty<EnumItem>("C6");
        public EnumItem USExecutive => GetProperty<EnumItem>("USExecutive");
        public EnumItem USLegal => GetProperty<EnumItem>("USLegal");
        public EnumItem USLetter => GetProperty<EnumItem>("USLetter");
    }
}
