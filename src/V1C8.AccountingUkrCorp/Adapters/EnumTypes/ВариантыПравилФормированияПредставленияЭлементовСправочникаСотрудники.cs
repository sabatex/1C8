using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВариантыПравилФормированияПредставленияЭлементовСправочникаСотрудники:V1C8COMObject
    {
        public ВариантыПравилФормированияПредставленияЭлементовСправочникаСотрудники(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ФамилияИОДополнение => GetProperty<EnumItemBase>("ФамилияИОДополнение");
        public EnumItemBase ФамилияИмяОтчествоДополнение => GetProperty<EnumItemBase>("ФамилияИмяОтчествоДополнение");
        public EnumItemBase ФамилияИОВидЗанятостиДополнение => GetProperty<EnumItemBase>("ФамилияИОВидЗанятостиДополнение");
        public EnumItemBase ФамилияИмяОтчествоВидЗанятостиДополнение => GetProperty<EnumItemBase>("ФамилияИмяОтчествоВидЗанятостиДополнение");
        public EnumItemBase ФамилияИОВидЗанятостиУволенДополнение => GetProperty<EnumItemBase>("ФамилияИОВидЗанятостиУволенДополнение");
        public EnumItemBase ФамилияИмяОтчествоВидЗанятостиУволенДополнение => GetProperty<EnumItemBase>("ФамилияИмяОтчествоВидЗанятостиУволенДополнение");
        public EnumItemBase ФамилияИОУволенДополнение => GetProperty<EnumItemBase>("ФамилияИОУволенДополнение");
        public EnumItemBase ФамилияИмяОтчествоУволенДополнение => GetProperty<EnumItemBase>("ФамилияИмяОтчествоУволенДополнение");
    }
}
