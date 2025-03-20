﻿using sabatex.V1C8.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8.ApplicationObjects
{
    public interface ICatalogRef:ICOMObject1C8
    {
        public Guid UUID
        {
            get
            {
                var uuid = Method<ICOMObject1C8>("UUID");
                return Guid.Parse(GlobalContext.String(uuid));
            }
        }

        public IMetadataObjectCatalog Metadata() => Method<IMetadataObjectCatalog>("Metadata");

        public bool DeletionMark => GetProperty<bool>("DeletionMark");
        public bool ПометкаУдаления => DeletionMark;
        public bool IsFolder => GetProperty<bool>("IsFolder");
        public bool ЭтоГруппа => IsFolder;
        public ICatalogRef Owner=> GetProperty<ICatalogRef>("Owner");
        public ICatalogRef Parent => GetProperty<ICatalogRef>("Parent");
        public string Code =>GetProperty<string>("Code");
        public string Description => GetProperty<string>("Description");
        public ICatalogRef Ref=> GetProperty<ICatalogRef>("Ref");
        public string FullDescr() => Method<string>("FullDescr");
        public string FullCode() => Method<string>("FullCode");
        public ICatalogObject GetObject() => Method<ICatalogObject>("GetObject");
        public bool BelongsToItem(ICatalogRef catalogRef) => Method<bool>("BelongsToItem",catalogRef);
        public bool IsEmpty()=> Method<bool>("IsEmpty");

        public ICatalogObject Copy() => Method<ICatalogObject>("Copy");

        public int Level() => Method<int>("Level");
    }
}
