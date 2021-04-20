using sabatex.V1C8.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8.ApplicationObjects
{
    public interface IDocumentRef:ICOMObject1C8
    {
        /// <summary>
        /// Содержит текущую версию данных объекта.
        /// </summary>
        public string DataVersion => GetProperty<string>("DataVersion");
        /// <summary>
        /// Содержит дату и время документа.
        /// </summary>
        public DateTime Date => GetProperty<DateTime>("Date");
        /// <summary>
        /// Содержит номер документа. Тип значения зависит от установки в Конфигураторе представления номера документа.
        /// </summary>
        public string Number => GetProperty<string>("Number");
        /// <summary>
        /// Содержит признак пометки на удаление документа.
        /// Истина - пометка удаления установлена.
        /// </summary>
        public bool DeletionMark => GetProperty<bool>("DeletionMark");
        /// <summary>
        /// Содержит признак проведенности документа.
        /// Истина - документ проведен.
        /// </summary>
        public bool Posted => GetProperty<bool>("Posted");
        /// <summary>
        /// Содержит ссылку на документ. Это значение может быть записано в базу данных для полей соответствующего типа.
        /// </summary>
        public IDocumentRef Ref=> GetProperty<IDocumentRef>("Ref");


        public Guid UUID
        {
            get
            {
                var uuid = Method<ICOMObject1C8>("UUID");
                return Guid.Parse(GlobalContext.String(uuid));
            }
        }

        public IMetaDataObjectDocument Metadata() => Method<IMetaDataObjectDocument>("Metadata");
    }
}
