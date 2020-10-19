using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыОплатыПоДоговоруГПХ:V1C8COMObject
    {
        public СпособыОплатыПоДоговоруГПХ(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОднократноВКонцеСрока => GetProperty<EnumItemBase>("ОднократноВКонцеСрока");
        public EnumItemBase ПоАктамВыполненныхРабот => GetProperty<EnumItemBase>("ПоАктамВыполненныхРабот");
        public EnumItemBase ВКонцеСрокаСАвансовымиПлатежами => GetProperty<EnumItemBase>("ВКонцеСрокаСАвансовымиПлатежами");
    }
}
