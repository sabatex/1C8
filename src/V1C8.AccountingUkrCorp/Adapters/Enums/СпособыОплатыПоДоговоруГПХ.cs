using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыОплатыПоДоговоруГПХ:V1C8COMObject
    {
        public СпособыОплатыПоДоговоруГПХ(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОднократноВКонцеСрока => GetProperty<EnumItemBase>();
        public EnumItemBase ПоАктамВыполненныхРабот => GetProperty<EnumItemBase>();
        public EnumItemBase ВКонцеСрокаСАвансовымиПлатежами => GetProperty<EnumItemBase>();
    }
}
