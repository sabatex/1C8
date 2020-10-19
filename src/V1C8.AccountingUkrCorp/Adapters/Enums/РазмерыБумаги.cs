using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class РазмерыБумаги:V1C8COMObject
    {
        public РазмерыБумаги(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НеЗадано => GetProperty<EnumItemBase>();
        public EnumItemBase A3 => GetProperty<EnumItemBase>();
        public EnumItemBase A4 => GetProperty<EnumItemBase>();
        public EnumItemBase A5 => GetProperty<EnumItemBase>();
        public EnumItemBase B4 => GetProperty<EnumItemBase>();
        public EnumItemBase B5 => GetProperty<EnumItemBase>();
        public EnumItemBase B6 => GetProperty<EnumItemBase>();
        public EnumItemBase C4 => GetProperty<EnumItemBase>();
        public EnumItemBase C5 => GetProperty<EnumItemBase>();
        public EnumItemBase C6 => GetProperty<EnumItemBase>();
        public EnumItemBase USExecutive => GetProperty<EnumItemBase>();
        public EnumItemBase USLegal => GetProperty<EnumItemBase>();
        public EnumItemBase USLetter => GetProperty<EnumItemBase>();
    }
}
