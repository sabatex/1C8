using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.ApplicationObjects
{
    public interface IInformationRegisterRecord:ICOMObject1C8
    {
        public bool Active => GetProperty<bool>("Active");
        public int LineNumber => GetProperty<int>("LineNumber");
        public DateTime Period => GetProperty<DateTime>("Period");
        public IDocumentRef Recorder => GetProperty<IDocumentRef>("Recorder");

    }
}
