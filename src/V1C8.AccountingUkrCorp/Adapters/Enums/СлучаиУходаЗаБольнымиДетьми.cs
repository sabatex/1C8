using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СлучаиУходаЗаБольнымиДетьми:V1C8COMObject
    {
        public СлучаиУходаЗаБольнымиДетьми(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоУходуДо7миЛетАмбулаторно => GetProperty<EnumItemBase>();
        public EnumItemBase ПоУходуДо7миЛетВСтационаре => GetProperty<EnumItemBase>();
        public EnumItemBase ПоУходуДо7миЛетПриОсобомЗаболеванииАмбулаторно => GetProperty<EnumItemBase>();
        public EnumItemBase ПоУходуДо7миЛетПриОсобомЗаболеванииВСтационаре => GetProperty<EnumItemBase>();
        public EnumItemBase ПоУходуДо15тиЛетАмбулаторно => GetProperty<EnumItemBase>();
        public EnumItemBase ПоУходуДо15тиЛетВСтационаре => GetProperty<EnumItemBase>();
        public EnumItemBase ПоУходуЗаРебенкомИнвалидомАмбулаторно => GetProperty<EnumItemBase>();
        public EnumItemBase ПоУходуЗаРебенкомИнвалидомВСтационаре => GetProperty<EnumItemBase>();
        public EnumItemBase ПоУходуДо15тиЛетПриПоствакцинальномОсложненииАмбулаторно => GetProperty<EnumItemBase>();
        public EnumItemBase ПоУходуДо15тиЛетПриПоствакцинальномОсложненииВСтационаре => GetProperty<EnumItemBase>();
        public EnumItemBase ПоУходуДо15тиЛетПриВИЧ => GetProperty<EnumItemBase>();
    }
}
