using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.ApplicationObjects
{
    public interface IInformationRegisterRecordManager:IInformationRegisterRecord
    {
        public new DateTime Period
        {
            get => GetProperty<DateTime>("Period");
            set => SetProperty("Period", value);
        }
        public bool Selected() => Method<bool>("Selected");
        public void Write(bool overwrite = false) => Method("Write", overwrite);
        public void Fill(ICatalogObject source = null) => Method("Fill", source);
        public bool Modified() => Method<bool>("Modified");
        public string GetDataHistoryVersionComment() => Method<string>("GetDataHistoryVersionComment");
        public bool Read() => Method<bool>("Read");
        public void Delete() => Method("Delete");
        public void SetDataHistoryVersionComment(string comment) => Method("SetDataHistoryVersionComment", comment);





    }
}
