using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8
{
    public static class TypeConverter 
    {
        /// <summary>
        /// Перетворити УникальныйИдентификатор в GUID
        /// </summary>
        /// <param name="context">Глобальний контехт зєднання</param>
        /// <param name="Ref">посилання на УникальныйИдентификатор</param>
        /// <returns></returns>
        public static Guid? ToGuid(dynamic context,dynamic value)
        {
            if (value == null)
            {
                throw new Exception("Параметр value не може бути null!");
            }
            string s = context.String(value);
            return new Guid(s);
        }

        /// <summary>
        /// Перетворити УникальныйИдентификатор в GUID
        /// </summary>
        /// <param name="context">Глобальний контехт зєднання</param>
        /// <param name="Ref">посилання на УникальныйИдентификатор</param>
        /// <returns></returns>
        public static Guid? GetGuid(dynamic context,dynamic value)
        {
            if (value == null)
            {
                throw new Exception("Параметр value не може бути null!");
            }
            dynamic g = value.УникальныйИдентификатор();
            string s = context.String(g);
            return new Guid(s);
        }


    }
}
