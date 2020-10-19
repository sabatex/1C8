using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СлучаиУходаЗаБольнымиДетьми:V1C8COMObject
    {
        public СлучаиУходаЗаБольнымиДетьми(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоУходуДо7миЛетАмбулаторно => GetProperty<EnumItemBase>("ПоУходуДо7миЛетАмбулаторно");
        public EnumItemBase ПоУходуДо7миЛетВСтационаре => GetProperty<EnumItemBase>("ПоУходуДо7миЛетВСтационаре");
        public EnumItemBase ПоУходуДо7миЛетПриОсобомЗаболеванииАмбулаторно => GetProperty<EnumItemBase>("ПоУходуДо7миЛетПриОсобомЗаболеванииАмбулаторно");
        public EnumItemBase ПоУходуДо7миЛетПриОсобомЗаболеванииВСтационаре => GetProperty<EnumItemBase>("ПоУходуДо7миЛетПриОсобомЗаболеванииВСтационаре");
        public EnumItemBase ПоУходуДо15тиЛетАмбулаторно => GetProperty<EnumItemBase>("ПоУходуДо15тиЛетАмбулаторно");
        public EnumItemBase ПоУходуДо15тиЛетВСтационаре => GetProperty<EnumItemBase>("ПоУходуДо15тиЛетВСтационаре");
        public EnumItemBase ПоУходуЗаРебенкомИнвалидомАмбулаторно => GetProperty<EnumItemBase>("ПоУходуЗаРебенкомИнвалидомАмбулаторно");
        public EnumItemBase ПоУходуЗаРебенкомИнвалидомВСтационаре => GetProperty<EnumItemBase>("ПоУходуЗаРебенкомИнвалидомВСтационаре");
        public EnumItemBase ПоУходуДо15тиЛетПриПоствакцинальномОсложненииАмбулаторно => GetProperty<EnumItemBase>("ПоУходуДо15тиЛетПриПоствакцинальномОсложненииАмбулаторно");
        public EnumItemBase ПоУходуДо15тиЛетПриПоствакцинальномОсложненииВСтационаре => GetProperty<EnumItemBase>("ПоУходуДо15тиЛетПриПоствакцинальномОсложненииВСтационаре");
        public EnumItemBase ПоУходуДо15тиЛетПриВИЧ => GetProperty<EnumItemBase>("ПоУходуДо15тиЛетПриВИЧ");
    }
}
