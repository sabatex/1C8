using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8.Metadata
{
    /// <summary>
    /// Определяет набор вариантов индексирования по реквизиту справочника, документа (а также по реквизиту табличной части), измерению регистра.
    /// </summary>
    public enum Indexing
    {
        /// <summary>
        /// Индексировать.
        /// </summary>
        Index,
        /// <summary>
        /// Индексировать с дополнительным упорядочиванием.
        /// </summary>
        IndexWithAdditionalOrder,
        /// <summary>
        /// Не индексировать
        /// </summary>
        DontIndex

    }
}
