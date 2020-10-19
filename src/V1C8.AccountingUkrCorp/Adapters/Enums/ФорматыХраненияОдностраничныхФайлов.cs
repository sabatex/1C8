using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ФорматыХраненияОдностраничныхФайлов:V1C8COMObject
    {
        public ФорматыХраненияОдностраничныхФайлов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase BMP => GetProperty<EnumItemBase>();
        public EnumItemBase GIF => GetProperty<EnumItemBase>();
        public EnumItemBase JPG => GetProperty<EnumItemBase>();
        public EnumItemBase PDF => GetProperty<EnumItemBase>();
        public EnumItemBase PNG => GetProperty<EnumItemBase>();
        public EnumItemBase TIF => GetProperty<EnumItemBase>();
    }
}
