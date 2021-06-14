using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.ApplicationObjects
{
    public interface ICatalogObject:ICatalogRef
    {
        public void Write() => Method("Write");
        public new string Code { get => GetProperty<string>("Code"); set => SetProperty("Code", value); }
        public new string Description { get => GetProperty<string>("Description"); set => SetProperty("Description", value); }
        public new ICatalogRef Owner { get => GetProperty<ICatalogRef>("Owner"); set => SetProperty("Owner", value); }
        public new ICatalogRef Parent
        {
            get => GetProperty<ICatalogRef>("Parent"); set => SetProperty("Parent", value);
        }
        public new bool DeletionMark
        {
            get => GetProperty<bool>("DeletionMark"); set => SetProperty("DeletionMark", value);
        } 

    }
}
