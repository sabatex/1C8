using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ФорматыХраненияОдностраничныхФайлов:V1C8COMObject
    {
        public ФорматыХраненияОдностраничныхФайлов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase BMP => GetProperty<EnumItemBase>("BMP");
        public EnumItemBase GIF => GetProperty<EnumItemBase>("GIF");
        public EnumItemBase JPG => GetProperty<EnumItemBase>("JPG");
        public EnumItemBase PDF => GetProperty<EnumItemBase>("PDF");
        public EnumItemBase PNG => GetProperty<EnumItemBase>("PNG");
        public EnumItemBase TIF => GetProperty<EnumItemBase>("TIF");
    }
}
