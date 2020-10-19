using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РазмерыБумаги:V1C8COMObject
    {
        public РазмерыБумаги(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеЗадано => GetProperty<EnumItemBase>("НеЗадано");
        public EnumItemBase A3 => GetProperty<EnumItemBase>("A3");
        public EnumItemBase A4 => GetProperty<EnumItemBase>("A4");
        public EnumItemBase A5 => GetProperty<EnumItemBase>("A5");
        public EnumItemBase B4 => GetProperty<EnumItemBase>("B4");
        public EnumItemBase B5 => GetProperty<EnumItemBase>("B5");
        public EnumItemBase B6 => GetProperty<EnumItemBase>("B6");
        public EnumItemBase C4 => GetProperty<EnumItemBase>("C4");
        public EnumItemBase C5 => GetProperty<EnumItemBase>("C5");
        public EnumItemBase C6 => GetProperty<EnumItemBase>("C6");
        public EnumItemBase USExecutive => GetProperty<EnumItemBase>("USExecutive");
        public EnumItemBase USLegal => GetProperty<EnumItemBase>("USLegal");
        public EnumItemBase USLetter => GetProperty<EnumItemBase>("USLetter");
    }
}
