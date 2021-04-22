using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using sabatex.V1C8;
using sabatex.V1C8.ApplicationObjects;
using sabatex.V1C8.Metadata;
using sabatex.V1C8.Models.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI1C8.Services
{
    public class Service1C:IDisposable
    {
        private readonly ILogger<Service1C> _logger;
        private readonly IConfiguration _configuration;
        private readonly IGlobalContext globalContext;
        public Service1C(IConfiguration configuration, ILogger<Service1C> logger)
        {
            _configuration = configuration;
            _logger = logger;
            globalContext = COMObject1C8.CreateConnection(configuration["ConnectionString1C8"]);
        }

        public void Dispose()
        {
            globalContext.Dispose();
        }

        public object GetMetadataObject(string objectName)
        {
            void addDescription(Dictionary<string,object> pairs,IMetadataDescription description)
            {
                pairs.Add("Comment", description.Comment);
                pairs.Add("Name", description.Name);
                pairs.Add("Synonym", description.Synonym);
            }
            ObjectType getType(IMetadataTypeDescription mainType)
            {
                var t = mainType.Types();
                var result = new ObjectType();
                for (int i = 0; i < t.Count(); i++)
                {
                    var stringType = globalContext.String(t[i] as ICOMObject1C8);
                    // simple type
                    switch (stringType)
                    {
                        case "Число":
                            result.AddNumber(mainType.NumberQualifiers.Digits, mainType.NumberQualifiers.FractionDigits);
                            break;
                        case "Булево":
                            result.AddBool();
                            break;
                        case "Рядок":
                            result.AddString(mainType.StringQualifiers.Length,mainType.StringQualifiers.AllowedLength);
                            break;
                        case "Дата":
                            result.AddDateTime(globalContext.String(mainType.GetProperty<ICOMObject1C8>("DateQualifiers").GetProperty<ICOMObject1C8>("DateFractions")));
                            break;
                            case "Сховище значень":
                            result.Types.Add("ValueStorage");
                            break;
                        default:
                            string s = globalContext.MetaData.FindByType(t[i] as ICOMObject1C8).FullName();
                            result.Types.Add(s);
                            break;
                    }
                }
                return result;
            }

            string[] s = objectName.Split('.');
            if (s.Length != 2)
                throw new Exception($"Не правильне імя обьэкта метаданих {objectName} ");
            var result = new Dictionary<string, object>();
            switch (s[0])
            {
                case "Документ":
                    var mDocument = globalContext.MetaData.Documents[s[1]];
                    addDescription(result, mDocument);
                    var attributes = new Dictionary<string, object>();
                    foreach (var attr in mDocument.Attributes)
                    {
                        var attribute = new Dictionary<string, object>();
                        addDescription(attribute, attr);
                        attribute.Add("Type", getType(attr.Type));
                        attributes.Add(attr.Name, attribute);
                        
                    }
                    result.Add("Attributes", attributes);
                    foreach (var tb in mDocument.TabularSections)
                    {

                    }



                    return result;
                default:
                    throw new Exception($"Не правильне імя обьэкта метаданих {objectName} ");

            }

        }


        public IEnumerable<object> GetEnumsMetadata()
        {
            return globalContext.MetaData.GetMetadataEnum();
        }

        public IEnumerable<object> GetCatalogMetadataNames()
        {
            foreach (var catalog in globalContext.MetaData.Catalogs)
            {
                yield return new { Name = catalog.Name, FullName = catalog.FullName() };
            }
        }
        public IEnumerable<object> GetDocumentMetadataNames()
        {
            foreach (var c in globalContext.MetaData.Documents)
            {
                yield return new { Name = c.Name, FullName = c.FullName() };
            }
        }
        public IEnumerable<object> GetDocumentsMetadata()
        {
            foreach (var c in globalContext.MetaData.Documents)
            {
                yield return GetMetadataObject($"Документ.{c.Name}");
            }
        }

        object emptyReference = new {id="" };

        public object GetReferenceTypeAttribute(ICOMObject1C8 obj,string typeN = "")
        {

            if (obj == null) return null;
            string typeName = obj.Method<ICOMObject1C8>("Metadata").Method<string>("FullName");

            var s = typeName.Split('.');
            switch (s[0])
            {
                case "Перечисление":
                    return new {
                        Type = typeName,
                        Id = globalContext.Enums[s[1]].IndexOf(obj as IEnumRef),
                        Present = globalContext.String(obj) };
                case "Справочник":
                    return new {
                        Type = typeName,
                        Id = (obj as ICatalogRef).UUID,
                        Present = globalContext.String(obj) };

                default:
                    throw new Exception($"Не визначений тип {typeName}");


            }

        }


        public object GetSingleTypeAttribute(ICOMObject1C8 obj,string fieldName, IMetadataTypeDescription fieldType)
        {
            var stringType = globalContext.String(fieldType);
                // simple type
                switch (stringType)
                {
                    case "Число":
                        return Convert.ToDecimal(obj.GetProperty<object>(fieldName));
                    case "Булево":
                        return obj.GetProperty<bool>(fieldName);
                    case "Рядок":
                        return obj.GetProperty<string>(fieldName).Trim();
                    case "Дата":
                        return obj.GetProperty<DateTime>(fieldName);
                    default:
                    string s = globalContext.MetaData.FindByType(fieldType.Types()[0] as ICOMObject1C8).FullName();
                    return GetReferenceTypeAttribute(obj.GetProperty<ICOMObject1C8>(fieldName),s);
                }

        }


        public object GetAttribute(ICOMObject1C8 obj,IMetadataObjectField field)
        {
            var fullname = globalContext.String(field.Type.Types()[0] as IMetadataTypeDescription);
 
            var types = field.Type.Types();
            if (types.Count() == 1)
                return GetSingleTypeAttribute(obj, field.Name, field.Type);
            
            var fieldName = field.Name;
            var value = obj.GetProperty<ICOMObject1C8>(fieldName);
            if (value == null)
                return new { Type = globalContext.String(field.Type), Id = "null", Present = "" };
            return GetReferenceTypeAttribute(value);

        }
 

        object SerializeJSON(ICOMObject1C8 obj,IMetadataObject metadataObject = null)
        {
            if (metadataObject == null)
            {
                var JSON = globalContext.NewObject<ICOMObject1C8>("ЗаписьJSON");
                JSON.SetProperty("ПроверятьСтруктуру", false);
                var JSONParams = globalContext.NewObject<ICOMObject1C8>("ПараметрыЗаписиJSON");
                JSON.Method<object>("УстановитьСтроку", JSONParams);
                var p = globalContext.GetProperty<ICOMObject1C8>("НазначениеТипаXML").GetProperty<ICOMObject1C8>("Явное");
                var s = globalContext.GetProperty<ICOMObject1C8>("СериализаторXDTO");
                s.Method<object>("ЗаписатьJSON", JSON, obj, p);

                return JSON.Method<string>("Закрыть");
            }
            else
            {
                Dictionary<string, object> json = new Dictionary<string, object>();
                json.Add("type", metadataObject.FullName());
                var iMetaDataObjectDocument = metadataObject as IMetaDataObjectDocument;
                var ms = globalContext.MetaData.Documents["РеализацияТоваровУслуг"].FullName();
                if (iMetaDataObjectDocument != null)
                {
                    var doc = obj as IDocumentRef;

                    json.Add("Data", doc.Date);
                    json.Add("DataVersion", doc.DataVersion);
                    json.Add("Number", doc.Number);
                    json.Add("DeletionMark", doc.DeletionMark);
                    json.Add("Posted", doc.Posted);
                    json.Add("UUID", doc.UUID);
                }
                var iMetadataAttributes = metadataObject as IMetadataAttributes;
                if (iMetadataAttributes != null)
                {
                    foreach (var attr in iMetadataAttributes.Attributes)
                    {
                        json.Add(attr.Name, GetAttribute(obj, attr));
                    }
                }

                return json;
            }

        }
       public object GetObjectByUUID(string objectType, string uuid)
        {
            string[] ot = objectType.ToUpper().Split('.');
            if (ot.Length != 2)
                throw new Exception($"Невідомий обьєкт конфігурації {objectType}");
            switch (ot[0])
            {
                case "ДОКУМЕНТ":
                    var obj = globalContext.Documents[ot[1]].GetRef(uuid);
                    return SerializeJSON(obj.Ref,obj.Metadata());
            }
            return null;

        }

        public object GetDocumentByNumber(string documentName, string number,DateTime? date)
        {
            // отримати метадані
            var metadata = globalContext.MetaData.Documents.Find(documentName);
            if (metadata == null)
                throw new Exception($"В конфігурації відсутній довідник з назвою {documentName}");
 
            var doc = globalContext.Documents[documentName].FindByNumber(number, date);


            if (doc == null)
                return null;

            return SerializeJSON(doc,metadata);
        }

        public object GetDocumentsByPeriod(string docName, DateTime? startDate, DateTime? endDate)
        {
            StringBuilder stringBuilder = new StringBuilder("{");
            stringBuilder.Append($"\"docName\":[");
            var doc = globalContext.Documents[docName].Select(startDate, endDate,null);
            bool isFirst = true;
            while (doc.Next())
            {
                if (isFirst)
                    isFirst = false;
                else
                    stringBuilder.Append(',');
                stringBuilder.Append(SerializeJSON(doc.GetObject()));
            }




            stringBuilder.Append(']');
            stringBuilder.Append('}');
            return stringBuilder.ToString();
        }


 
    }
}
