using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СлучаиУходаЗаБольнымиДетьми:EnumBase
    {
        public СлучаиУходаЗаБольнымиДетьми(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПоУходуДо7миЛетАмбулаторно => GetProperty<EnumItem>("ПоУходуДо7миЛетАмбулаторно");
        public EnumItem ПоУходуДо7миЛетВСтационаре => GetProperty<EnumItem>("ПоУходуДо7миЛетВСтационаре");
        public EnumItem ПоУходуДо7миЛетПриОсобомЗаболеванииАмбулаторно => GetProperty<EnumItem>("ПоУходуДо7миЛетПриОсобомЗаболеванииАмбулаторно");
        public EnumItem ПоУходуДо7миЛетПриОсобомЗаболеванииВСтационаре => GetProperty<EnumItem>("ПоУходуДо7миЛетПриОсобомЗаболеванииВСтационаре");
        public EnumItem ПоУходуДо15тиЛетАмбулаторно => GetProperty<EnumItem>("ПоУходуДо15тиЛетАмбулаторно");
        public EnumItem ПоУходуДо15тиЛетВСтационаре => GetProperty<EnumItem>("ПоУходуДо15тиЛетВСтационаре");
        public EnumItem ПоУходуЗаРебенкомИнвалидомАмбулаторно => GetProperty<EnumItem>("ПоУходуЗаРебенкомИнвалидомАмбулаторно");
        public EnumItem ПоУходуЗаРебенкомИнвалидомВСтационаре => GetProperty<EnumItem>("ПоУходуЗаРебенкомИнвалидомВСтационаре");
        public EnumItem ПоУходуДо15тиЛетПриПоствакцинальномОсложненииАмбулаторно => GetProperty<EnumItem>("ПоУходуДо15тиЛетПриПоствакцинальномОсложненииАмбулаторно");
        public EnumItem ПоУходуДо15тиЛетПриПоствакцинальномОсложненииВСтационаре => GetProperty<EnumItem>("ПоУходуДо15тиЛетПриПоствакцинальномОсложненииВСтационаре");
        public EnumItem ПоУходуДо15тиЛетПриВИЧ => GetProperty<EnumItem>("ПоУходуДо15тиЛетПриВИЧ");
    }
}
