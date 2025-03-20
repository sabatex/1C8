using System;
using System.Collections.Generic;
using System.Text;

namespace Sabatex.V1C8.ApplicationObjects
{
    public interface IDocumentsManager:ICOMObject1C8
    {
        public IDocumentManager this[string index] => GetProperty<IDocumentManager>(index);
    }
}
