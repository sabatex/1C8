using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВариантыПравилФормированияПредставленияЭлементовСправочникаСотрудники:V1C8COMObject
    {
        public ВариантыПравилФормированияПредставленияЭлементовСправочникаСотрудники(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ФамилияИОДополнение => GetProperty<EnumItemBase>();
        public EnumItemBase ФамилияИмяОтчествоДополнение => GetProperty<EnumItemBase>();
        public EnumItemBase ФамилияИОВидЗанятостиДополнение => GetProperty<EnumItemBase>();
        public EnumItemBase ФамилияИмяОтчествоВидЗанятостиДополнение => GetProperty<EnumItemBase>();
        public EnumItemBase ФамилияИОВидЗанятостиУволенДополнение => GetProperty<EnumItemBase>();
        public EnumItemBase ФамилияИмяОтчествоВидЗанятостиУволенДополнение => GetProperty<EnumItemBase>();
        public EnumItemBase ФамилияИОУволенДополнение => GetProperty<EnumItemBase>();
        public EnumItemBase ФамилияИмяОтчествоУволенДополнение => GetProperty<EnumItemBase>();
    }
}
