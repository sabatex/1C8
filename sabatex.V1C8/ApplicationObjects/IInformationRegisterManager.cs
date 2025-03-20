using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabatex.V1C8.ApplicationObjects
{
    public interface IInformationRegisterManager:ICOMObject1C8
    {
        public IIInformationRegisterSelection Select(DateTime? startDate=null,DateTime? endDate=null, ICOMObject1C8 filter = null, string order = null)
        {
            return Method<IIInformationRegisterSelection>("Select", startDate, endDate, filter, order);
        }

        public IIInformationRegisterSelection SelectByRecorder(IDocumentRef documentRef) => Method<IIInformationRegisterSelection>("SelectByRecorder", documentRef);

        public void RecalcTotals() => Method("RecalcTotals");

        public IStructure Get(DateTime? date = null, IStructure filter = null) => Method<IStructure>("Get", date, filter);
        public IStructure Get(IStructure filter = null) => Method<IStructure>("Get", filter);

        public bool GetTotalsUsing() => Method<bool>("GetTotalsUsing");

        public IStructure GetFirst(DateTime? beginPeriod = null, IStructure filter = null) => Method<IStructure>("GetFirst", beginPeriod, filter);
        public IStructure GetLast(DateTime? beginPeriod = null, IStructure filter = null) => Method<IStructure>("GetLast", beginPeriod, filter);

        public IInformationRegisterRecordManager CreateRecordManager() => Method<IInformationRegisterRecordManager>("CreateRecordManager");



    }
}
