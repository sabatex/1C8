using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВариантыПравилФормированияПредставленияЭлементовСправочникаСотрудники:EnumBase
    {
        public ВариантыПравилФормированияПредставленияЭлементовСправочникаСотрудники(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ФамилияИОДополнение => GetProperty<EnumItem>("ФамилияИОДополнение");
        public EnumItem ФамилияИмяОтчествоДополнение => GetProperty<EnumItem>("ФамилияИмяОтчествоДополнение");
        public EnumItem ФамилияИОВидЗанятостиДополнение => GetProperty<EnumItem>("ФамилияИОВидЗанятостиДополнение");
        public EnumItem ФамилияИмяОтчествоВидЗанятостиДополнение => GetProperty<EnumItem>("ФамилияИмяОтчествоВидЗанятостиДополнение");
        public EnumItem ФамилияИОВидЗанятостиУволенДополнение => GetProperty<EnumItem>("ФамилияИОВидЗанятостиУволенДополнение");
        public EnumItem ФамилияИмяОтчествоВидЗанятостиУволенДополнение => GetProperty<EnumItem>("ФамилияИмяОтчествоВидЗанятостиУволенДополнение");
        public EnumItem ФамилияИОУволенДополнение => GetProperty<EnumItem>("ФамилияИОУволенДополнение");
        public EnumItem ФамилияИмяОтчествоУволенДополнение => GetProperty<EnumItem>("ФамилияИмяОтчествоУволенДополнение");
    }
}
