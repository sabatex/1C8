using System;
using System.Collections.Generic;
using System.Text;

namespace Sabatex.V1C8.Metadata
{
    /// <summary>
    /// Определяет набор вариантов использования реквизита справочника для групп и элементов.
    /// </summary>
    public enum AttributeUse
    {
        /// <summary>
        /// Использовать реквизит только для групп.
        /// </summary>
        ForFolder,
        /// <summary>
        /// Использовать реквизит для элементов и для групп.
        /// </summary>
        ForFolderAndItem,
        /// <summary>
        /// Использовать реквизит только для элементов.
        /// </summary>
        ForItem
    }
}
