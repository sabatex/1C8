using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabatex.V1C8.ApplicationObjects
{
    public interface IIInformationRegisterSelection:IInformationRegisterRecord
    {
        public bool Next() => Method<bool>("Next");
        public IInformationRegisterRecordManager GetRecordManager() => Method<IInformationRegisterRecordManager>("GetRecordManager");
    }
}
